// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Threading;
using AutoRest.CSharp.Generation.Writers;
using AutoRest.CSharp.Mgmt.AutoRest;
using AutoRest.CSharp.Mgmt.Decorator;
using AutoRest.CSharp.Mgmt.Output;
using AutoRest.CSharp.Output.Models.Requests;
using AutoRest.CSharp.Output.Models.Shared;
using AutoRest.CSharp.Output.Models.Types;
using AutoRest.CSharp.Utilities;
using Azure.ResourceManager.Core;

namespace AutoRest.CSharp.Mgmt.Generation
{
    internal class ArmClientExtensionsWriter : MgmtExtensionWriter
    {
        protected override string Description => "A class to add extension methods to ArmClient.";
        protected override string ExtensionClassType => ResourceTypeBuilder.TypeToExtensionName[ResourceTypeBuilder.Tenant];
        protected override string ExtensionOperationVariableName => "armClient";

        protected override Type ExtensionOperationVariableType => typeof(ArmClient);

        public override void WriteExtension(CodeWriter writer, BuildContext<MgmtOutputLibrary> context)
        {
            var @namespace = context.DefaultNamespace;
            using (writer.Namespace(@namespace))
            {
                writer.WriteXmlDocumentationSummary(Description);
                using (writer.Scope($"{Accessibility} static partial class {ExtensionClassType}"))
                {
                    foreach (var resource in context.Library.ArmResource)
                    {
                        if (resource.OperationGroup.IsScopeResource())
                        {
                            writer.Line($"#region {resource.Type.Name}");
                            var resourceContainer = context.Library.GetResourceContainer(resource.OperationGroup);
                            WriteGetScopeResourceContainerMethod(writer, resourceContainer!);
                            writer.LineRaw("#endregion");
                        }
                        writer.Line();
                    }

                }
            }
        }

        private void WriteGetScopeResourceContainerMethod(CodeWriter writer, ResourceContainer resourceContainer)
        {
            writer.WriteXmlDocumentationSummary($"Gets an object representing a {resourceContainer.Type.Name} along with the instance operations that can be performed on it.");
            writer.WriteXmlDocumentationParameter(ExtensionOperationVariableName, $"The <see cref=\"{typeof(ArmClient)}\" /> instance the method will execute against.");
            writer.WriteXmlDocumentationReturns($"Returns a <see cref=\"{resourceContainer.Type.Name}\" /> object.");

            using (writer.Scope($"public static {resourceContainer.Type} Get{resourceContainer.Type.Name}(this {typeof(ArmClient)} {ExtensionOperationVariableName})"))
            {
                writer.Line($"return armClient.GetContainer((options, credential, baseUri, pipeline) => new {resourceContainer.Type}(options, credential, baseUri, pipeline));");
            }
        }

        // private void WriteListResourceMethod(CodeWriter writer, Resource resource, ResourceOperation resourceOperation, PagingMethod pagingMethod, bool async)
        // {
        //     WriteExtensionPagingMethod(writer, resource.Type, resourceOperation.RestClient, pagingMethod,
        //         $".Select(value => new {resource.Type.Name}(subscription, value))", async);
        // }

        // private void WriteListResourceByNameMethod(CodeWriter writer, ResourceOperation resourceOperation, bool async)
        // {
        //     writer.Line();
        //     writer.WriteXmlDocumentationSummary($"Filters the list of {resourceOperation.ResourceName.ToPlural()} for a {typeof(SubscriptionOperations)} represented as generic resources.");
        //     writer.WriteXmlDocumentationParameter("subscription", $"The <see cref=\"{typeof(SubscriptionOperations)}\" /> instance the method will execute against.");
        //     writer.WriteXmlDocumentationParameter("filter", "The string to filter the list.");
        //     writer.WriteXmlDocumentationParameter("expand", "Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`.");
        //     writer.WriteXmlDocumentationParameter("top", "The number of results to return.");
        //     writer.WriteXmlDocumentationParameter("cancellationToken", "The cancellation token to use.");
        //     writer.WriteXmlDocumentationReturns($"A collection of resource operations that may take multiple service requests to iterate over.");

        //     var responseType = typeof(GenericResourceExpanded).WrapPageable(async);
        //     using (writer.Scope($"public static {responseType} {CreateMethodName($"List{resourceOperation.ResourceName}ByName", async)}(this {typeof(SubscriptionOperations)} subscription, {typeof(string)} filter, {typeof(string)} expand, {typeof(int?)} top, {typeof(CancellationToken)} cancellationToken = default)"))
        //     {
        //         var filters = new CodeWriterDeclaration("filters");
        //         writer.Line($"{typeof(ResourceFilterCollection)} {filters:D} = new({resourceOperation.Type}.ResourceType);");
        //         writer.Line($"{filters}.SubstringFilter = filter;");
        //         writer.Line($"return {typeof(ResourceListOperations)}.{CreateMethodName("ListAtContext", async)}(subscription, {filters}, expand, top, cancellationToken);");
        //     }
        // }

        // private void WriteChildSingletonGetOperationMethods(CodeWriter writer, ResourceOperation resourceOperation)
        // {
        //     // The resourceOperation already has a suffix "Operations" therefore it is already in plural form
        //     // there we do not need to change it to plural again
        //     writer.Line($"#region Get {resourceOperation.Type.Name} operation");

        //     writer.WriteXmlDocumentationSummary($"Gets an object representing a {resourceOperation.Type.Name} along with the instance operations that can be performed on it.");
        //     writer.WriteXmlDocumentationReturns($"Returns a <see cref=\"{resourceOperation.Type.Name}\" /> object.");
        //     using (writer.Scope($"public static {resourceOperation.Type} Get{resourceOperation.Type.Name}(this {typeof(SubscriptionOperations)} subscriptionOperations)"))
        //     {
        //         writer.Line($"return new {resourceOperation.Type.Name}(subscriptionOperations);");
        //     }
        //     writer.LineRaw("#endregion");
        //     writer.Line();
        // }

        // protected override bool ShouldPassThrough(ref string dotParent, Stack<string> parentNameStack, Parameter parameter, ref string valueExpression)
        // {
        //     return true;
        // }

        // protected override void MakeResourceNameParamPassThrough(RestClientMethod method, List<ParameterMapping> parameterMapping, Stack<string> parentNameStack)
        // {
        //     // override to do nothing since we do not need anything from subscription.Id in the SubscriptionExtensions class
        // }
    }
}
