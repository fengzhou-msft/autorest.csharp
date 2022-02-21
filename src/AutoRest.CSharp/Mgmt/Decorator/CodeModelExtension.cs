﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using AutoRest.CSharp.AutoRest.Plugins;
using AutoRest.CSharp.Input;
using AutoRest.CSharp.Mgmt.AutoRest;
using AutoRest.CSharp.Mgmt.Models;
using AutoRest.CSharp.Utilities;

namespace AutoRest.CSharp.Mgmt.Decorator
{
    internal static class CodeModelExtension
    {
        public static void VerifyAndUpdateFrameworkTypes(this IEnumerable<Schema> allSchemas)
        {
            foreach (var schema in allSchemas)
            {
                if (schema is not ObjectSchema objSchema)
                    continue;

                foreach (var property in objSchema.Properties)
                {
                    if (property.Language.Default.Name.EndsWith("Uri"))
                        property.Schema.Type = AllSchemaTypes.Uri;
                    if (property.Language.Default.Name.SplitByCamelCase().Last().Equals("Duration") && property.Schema.Type == AllSchemaTypes.String)
                        throw new InvalidOperationException($"The {property.Language.Default.Name} property of {objSchema.Name} ends with \"Duration\" but does not use \"format\": \"duration\" to be generated as TimeSpan type. Either fix service swagger or add the format with directive in autorest.md. If the property does not conform to the duration format, please use x-ms-client-name to rename the property for the client.");
                }
            }
        }

        public static void UpdateSubscriptionIdForAllResource(this CodeModel codeModel)
        {
            bool setSubParam = false;
            foreach (var operationGroup in codeModel.OperationGroups)
            {
                foreach (var op in operationGroup.Operations)
                {
                    foreach (var p in op.Parameters)
                    {
                        //updater the first subscriptionId to be 'method'
                        if (!setSubParam && p.Language.Default.Name.Equals("subscriptionId", StringComparison.OrdinalIgnoreCase))
                        {
                            setSubParam = true;
                            p.Implementation = ImplementationLocation.Method;
                        }
                        //updater the first subscriptionId to be 'method'
                        if (p.Language.Default.Name.Equals("apiVersion", StringComparison.OrdinalIgnoreCase))
                        {
                            p.Implementation = ImplementationLocation.Client;
                        }
                    }
                }
            }
        }

        public static void UpdateAcronyms(this IEnumerable<Schema> allSchemas)
        {
            if (MgmtContext.MgmtConfiguration.RenameRules.Count == 0)
                return;
            var transformer = new NameTransformer(MgmtContext.MgmtConfiguration.RenameRules);
            var wordCache = new ConcurrentDictionary<string, string>();
            foreach (var schema in allSchemas)
            {
                TransformSchema(schema, transformer, wordCache);
            }
        }

        private static void TransformSchema(Schema schema, NameTransformer transformer, ConcurrentDictionary<string, string> wordCache)
        {
            switch (schema)
            {
                case ChoiceSchema:
                case SealedChoiceSchema:
                    TransformBasicSchema(schema, transformer, wordCache);
                    break;
                case ObjectSchema objSchema: // GroupSchema inherits ObjectSchema, therefore we do not need to handle that
                    TransformObjectSchema(objSchema, transformer, wordCache);
                    break;
                default:
                    throw new InvalidOperationException($"Unknown schema type {schema.GetType()}");
            }
        }

        private static void TransformBasicSchema(Schema schema, NameTransformer transformer, ConcurrentDictionary<string, string> wordCache)
        {
            TransformLanguage(schema.Language, transformer, wordCache);
        }

        private static void TransformLanguage(Languages languages, NameTransformer transformer, ConcurrentDictionary<string, string> wordCache)
        {
            var originalName = languages.Default.Name;
            if (wordCache.TryGetValue(originalName, out var result))
            {
                languages.Default.Name = result;
                return;
            }
            result = transformer.EnsureNameCase(originalName);
            languages.Default.Name = result;
            wordCache.TryAdd(originalName, result);
        }

        private static void TransformObjectSchema(ObjectSchema objSchema, NameTransformer transformer, ConcurrentDictionary<string, string> wordCache)
        {
            // transform the name of this schema
            TransformBasicSchema(objSchema, transformer, wordCache);
            foreach (var property in objSchema.Properties)
            {
                TransformLanguage(property.Language, transformer, wordCache);
            }
        }
    }
}
