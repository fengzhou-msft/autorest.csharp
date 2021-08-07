// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using AutoRest.CSharp.AutoRest.Plugins;
using AutoRest.CSharp.Generation.Types;
using AutoRest.CSharp.Input;
using AutoRest.CSharp.Mgmt.AutoRest;
using AutoRest.CSharp.Mgmt.Generation;
using AutoRest.CSharp.Mgmt.Output;
using AutoRest.CSharp.Output.Builders;
using AutoRest.CSharp.Output.Models.Types;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace AutoRest.CSharp.Mgmt.Decorator
{
    internal static class ReferenceTypePropertyChooser
    {
        internal const string PropertyReferenceAttributeName = "PropertyReferenceTypeAttribute";

        private static IList<System.Type> GetReferenceClassCollection()
        {
            var assembly = Assembly.GetAssembly(typeof(ArmClient));
            if (assembly == null)
            {
                return new List<System.Type>();
            }
            var list = assembly.GetTypes().Where(t => t.GetCustomAttributes(false).Where(a => a.GetType().Name == PropertyReferenceAttributeName).Count() > 0).ToList();
            return list;
        }

        public static ObjectTypeProperty? GetExactMatch(ObjectTypeProperty originalTypeToReplace, MgmtObjectType typeToReplace)
        {
            foreach (System.Type replacementType in GetReferenceClassCollection())
            {
                if ($"{typeToReplace.Type.Namespace}.{typeToReplace.Type.Name}" == $"{replacementType.Namespace}.{replacementType.Name}")
                    return GetObjectTypeProperty(originalTypeToReplace, typeToReplace, replacementType);
                var attributeObj = replacementType.GetCustomAttributes()?.Where(a => a.GetType().Name == PropertyReferenceAttributeName).First();
                var propertiesToSkipArray = attributeObj?.GetType().GetProperty("SkipTypes")?.GetValue(attributeObj) as Type[];
                var propertiesToSkip = new HashSet<string>(propertiesToSkipArray!.Select(p => p.Name));
                // flatten properties
                List<PropertyInfo> replacementTypeProperties = replacementType.GetProperties(BindingFlags.Public | BindingFlags.Instance).Where(p => !propertiesToSkip.Contains(p.PropertyType.Name)).ToList();
                // List<PropertyInfo> flattenedReplacementTypeProperties = new List<PropertyInfo>();
                // foreach (var parentProperty in replacementTypeProperties)
                // {
                    // if (parentProperty.PropertyType.IsClass)
                    // {
                    //     flattenedReplacementTypeProperties.AddRange(parentProperty.PropertyType.GetProperties());
                    // }
                    // else
                    // {
                    // flattenedReplacementTypeProperties.Add(parentProperty);
                    // }
                // }
                List<ObjectTypeProperty> typeToReplaceProperties = typeToReplace.MyProperties.Where(p => !propertiesToSkip.Contains(p.ValueType.Name)).ToList();

                if (PropertyMatchDetection.IsEqual(replacementTypeProperties, typeToReplaceProperties))
                {
                    return GetObjectTypeProperty(originalTypeToReplace, typeToReplace, replacementType);
                }
            }
            return null;
        }
        public static CSharpType? GetExactMatch(MgmtObjectType typeToReplace)
        {
            var properties = typeToReplace.MyProperties;
            foreach (System.Type replacementType in GetReferenceClassCollection())
            {
                var attributeObj = replacementType.GetCustomAttributes()?.Where(a => a.GetType().Name == PropertyReferenceAttributeName).First();
                var propertiesToSkipArray = attributeObj?.GetType().GetProperty("SkipTypes")?.GetValue(attributeObj) as Type[];
                var propertiesToSkip = new HashSet<string>(propertiesToSkipArray!.Select(p => p.Name));
                List<PropertyInfo> replacementTypeProperties = replacementType.GetProperties(BindingFlags.Public | BindingFlags.Instance).Where(p => !propertiesToSkip.Contains(p.PropertyType.Name)).ToList();
                List<ObjectTypeProperty> typeToReplaceProperties = typeToReplace.MyProperties.Where(p => !propertiesToSkip.Contains(p.ValueType.Name)).ToList();

                if (PropertyMatchDetection.IsEqual(replacementTypeProperties, typeToReplaceProperties))
                {
                    return CSharpType.FromSystemType(typeToReplace.Context, replacementType);
                }
            }
            return null;
        }

        private static ObjectTypeProperty GetObjectTypeProperty(ObjectTypeProperty originalType, MgmtObjectType typeToReplace, Type replacementType)
        {
            return new ObjectTypeProperty(
                    new MemberDeclarationOptions(originalType.Declaration.Accessibility, replacementType.Name, CSharpType.FromSystemType(typeToReplace.Context, replacementType)),
                    originalType.Description,
                    originalType.IsReadOnly,
                    originalType.SchemaProperty
                    );
        }
    }
}
