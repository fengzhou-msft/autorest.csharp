﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoRest.CSharp.Generation.Types;
using AutoRest.CSharp.Generation.Writers;
using AutoRest.CSharp.Mgmt.AutoRest;
using AutoRest.CSharp.Mgmt.Decorator;
using AutoRest.CSharp.Mgmt.Output;
using AutoRest.CSharp.Output.Models.Requests;
using AutoRest.CSharp.Output.Models.Shared;
using AutoRest.CSharp.Output.Models.Types;
using AutoRest.CSharp.Utilities;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Core;

namespace AutoRest.CSharp.Mgmt.Generation
{
    /// <summary>
    /// Code writer for resource container.
    /// A resource container should have 3 operations:
    /// 1. CreateOrUpdate (4 variants)
    /// 2. Get (2 variants)
    /// 3. List (4 variants)
    /// and the following builder methods:
    /// 1. Construct
    /// </summary>
    internal class ResourceContainerWriter : MgmtClientBaseWriter
    {
        private readonly string _parentProperty;
        private CodeWriter _writer;
        private ResourceContainer _resourceContainer;
        private ResourceData _resourceData;
        private Resource _resource;
        private ResourceOperation _resourceOperation;
        private BuildContext<MgmtOutputLibrary> _context;
        // Whether the container is for operation groups with "/{scope}" paths
        private readonly bool _isScope;

        private Type _operationBaseType;

        protected override string ContextProperty => "Parent";

        public ResourceContainerWriter(CodeWriter writer, ResourceContainer resourceContainer, BuildContext<MgmtOutputLibrary> context)
        {
            _writer = writer;
            _resourceContainer = resourceContainer;
            var operationGroup = resourceContainer.OperationGroup;
            _isScope = operationGroup.IsScopeResource();
            _parentProperty = _isScope ? "this" : "Parent";
            _resourceData = context.Library.GetResourceData(operationGroup);
            _restClient = context.Library.GetRestClient(operationGroup);
            _resource = context.Library.GetArmResource(operationGroup);
            _resourceOperation = context.Library.GetResourceOperation(operationGroup);
            _context = context;
            _operationBaseType =  _isScope ? typeof(OperationsBase) : typeof(ResourceOperationsBase);
        }

        public void WriteContainer()
        {
            WriteUsings(_writer);

            var cs = _resourceContainer.Type;
            var @namespace = cs.Namespace;
            using (_writer.Namespace(@namespace))
            {
                _writer.WriteXmlDocumentationSummary(_resourceContainer.Description);
                string baseClass = GetBaseType();
                using (_writer.Scope($"{_resourceContainer.Declaration.Accessibility} partial class {cs.Name:D} : {baseClass}"))
                {
                    WriteContainerCtors(_writer, _resourceContainer.Type.Name, _operationBaseType, _isScope);
                    WriteFields(_writer, _restClient!);
                    WriteIdProperty();
                    WriteContainerProperties(_writer, _resourceContainer.GetValidResourceValue());
                    WriteResourceOperations();
                    WriteRemainingMethods();
                    WriteBuilders();
                }
            }
        }

        private void WriteRemainingMethods()
        {
            _writer.Line();
            foreach (var restMethod in _resourceContainer.RemainingMethods)
            {
                WriteClientMethod(_writer, restMethod, _resourceContainer.GetDiagnostic(restMethod.RestClientMethod), _resourceContainer.OperationGroup, _context, true);
                WriteClientMethod(_writer, restMethod, _resourceContainer.GetDiagnostic(restMethod.RestClientMethod), _resourceContainer.OperationGroup, _context, false);
            }
        }

        protected virtual string GetBaseType()
        {
            return (_resourceContainer.GetMethod != null && !_isScope)
                ? $"ResourceContainerBase<{_resourceContainer.ResourceIdentifierType}, {_resource.Type.Name}, {_resourceData.Type.Name}>"
                : $"ContainerBase";
        }

        private void WriteIdProperty()
        {
            _writer.Line();
            _writer.WriteXmlDocumentationSummary($"Typed Resource Identifier for the container.");
            var idType = _resourceContainer.OperationGroup.GetResourceIdentifierType(_context);
            _writer.Line($"public new {idType} Id => base.Id as {idType};");
        }

        private void WriteResourceOperations()
        {
            _writer.Line();
            _writer.LineRaw($"// Container level operations.");

            if (_resourceContainer.PutMethod != null)
            {
                WriteCreateOrUpdateVariants(_resourceContainer.PutMethod);
            }

            if (_resourceContainer.GetMethod != null)
            {
                WriteGetVariants(_resourceContainer.GetMethod.RestClientMethod);
            }

            if (_resourceContainer.PutByIdMethod != null)
            {
                WriteCreateByIdVariants(_resourceContainer.PutByIdMethod);
            }

            if (_resourceContainer.GetByIdMethod != null)
            {
                WriteGetByIdVariants(_resourceContainer.GetByIdMethod);
            }

            WriteListVariants();
        }

        private void WriteCreateOrUpdateVariants(RestClientMethod restClientMethod)
        {
            Debug.Assert(restClientMethod.Operation != null);
            var parameterMapping = BuildParameterMapping(restClientMethod);
            IEnumerable<Parameter> passThruParameters = parameterMapping.Where(p => p.IsPassThru).Select(p => p.Parameter);

            _writer.Line();
            _writer.WriteXmlDocumentationSummary($"The operation to create or update a {_resource.Type.Name}. Please note some properties can be set only during creation.");
            var methodName = _isScope ? "CreateOrUpdateAtScope" : "CreateOrUpdate";
            var startMethodName = _isScope ? "StartCreateOrUpdateAtScope" : "StartCreateOrUpdate";
            WriteContainerMethodScope(false, $"{typeof(Response)}<{_resource.Type.Name}>", methodName, passThruParameters, writer =>
            {
                _writer.Append($"return {startMethodName}(");
                foreach (var parameter in passThruParameters)
                {
                    _writer.AppendRaw($"{parameter.Name}, ");
                }
                _writer.Line($"cancellationToken: cancellationToken).WaitForCompletion(cancellationToken);");
            });

            _writer.Line();
            _writer.WriteXmlDocumentationSummary($"The operation to create or update a {_resource.Type.Name}. Please note some properties can be set only during creation.");
            WriteContainerMethodScope(true, $"{typeof(Task)}<{typeof(Response)}<{_resource.Type.Name}>>", methodName, passThruParameters, writer =>
            {
                _writer.Append($"var operation = await {startMethodName}Async(");
                foreach (var parameter in passThruParameters)
                {
                    _writer.AppendRaw($"{parameter.Name}, ");
                }
                _writer.Line($"cancellationToken: cancellationToken).ConfigureAwait(false);");
                _writer.Line($"return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);");
            });

            _writer.Line();
            WriteStartCreateVariants(false, restClientMethod, startMethodName, passThruParameters, parameterMapping);
            _writer.Line();
            WriteStartCreateVariants(true, restClientMethod, startMethodName, passThruParameters, parameterMapping);
        }

        private void WriteCreateByIdVariants(RestClientMethod restClientMethod)
        {
            Debug.Assert(restClientMethod.Operation != null);
            var parameterMapping = BuildParameterMapping(restClientMethod);
            IEnumerable<Parameter> passThruParameters = parameterMapping.Where(p => p.IsPassThru).Select(p => p.Parameter);

            _writer.Line();
            _writer.WriteXmlDocumentationSummary($"The operation to create or update a {_resource.Type.Name} by ID. Please note some properties can be set only during creation.");
            var methodName = "CreateById";
            var startMethodName = "StartCreateById";
            WriteContainerMethodScope(false, $"{typeof(Response)}<{_resource.Type.Name}>", methodName, passThruParameters, writer =>
            {
                _writer.Append($"return {startMethodName}(");
                foreach (var parameter in passThruParameters)
                {
                    _writer.AppendRaw($"{parameter.Name}, ");
                }
                _writer.Line($"cancellationToken: cancellationToken).WaitForCompletion(cancellationToken);");
            });

            _writer.Line();
            _writer.WriteXmlDocumentationSummary($"The operation to create or update a {_resource.Type.Name} by ID. Please note some properties can be set only during creation.");
            WriteContainerMethodScope(true, $"{typeof(Task)}<{typeof(Response)}<{_resource.Type.Name}>>", methodName, passThruParameters, writer =>
            {
                _writer.Append($"var operation = await {startMethodName}Async(");
                foreach (var parameter in passThruParameters)
                {
                    _writer.AppendRaw($"{parameter.Name}, ");
                }
                _writer.Line($"cancellationToken: cancellationToken).ConfigureAwait(false);");
                _writer.Line($"return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);");
            });

            _writer.Line();
            WriteStartCreateVariants(false, restClientMethod, startMethodName, passThruParameters, parameterMapping, isCreateById: true);
            _writer.Line();
            WriteStartCreateVariants(true, restClientMethod, startMethodName, passThruParameters, parameterMapping, isCreateById: true);
        }

        private void WriteStartCreateVariants(bool isAsync, RestClientMethod restClientMethod, string startMethodName, IEnumerable<Parameter> passThruParameters, IEnumerable<ParameterMapping> parameterMapping, bool isCreateById = false)
        {
            var isLongRunning = restClientMethod.Operation!.IsLongRunning;
            CSharpType lroObjectType = isLongRunning
                ? _context.Library.GetLongRunningOperation(restClientMethod.Operation).Type
                : _context.Library.GetNonLongRunningOperation(restClientMethod.Operation).Type;
            _writer.WriteXmlDocumentationSummary($"The operation to create or update a {_resource.Type.Name}{(isCreateById ? " by ID" : "")}. Please note some properties can be set only during creation.");
            WriteContainerMethodScope(isAsync, $"{(isAsync ? $"{typeof(Task)}<{lroObjectType.Name}>" : $"{lroObjectType.Name}")}", startMethodName, passThruParameters, writer =>
            {
                var awaitStr = isAsync ? "await " : string.Empty;
                var asyncStr = isAsync ? "Async" : string.Empty;
                _writer.Append($"var originalResponse = {awaitStr}{RestClientField}.{restClientMethod.Name}{asyncStr}(");
                WriteArguments(writer, parameterMapping);
                var configAwaitStr = isAsync ? ".ConfigureAwait(false)" : string.Empty;
                _writer.Line($"cancellationToken: cancellationToken){configAwaitStr};");
                if (isLongRunning)
                {
                    _writer.Append($"return new {lroObjectType}(");
                    _writer.Append($"{_parentProperty}, {ClientDiagnosticsField}, {PipelineProperty}, {RestClientField}.Create{restClientMethod.Name}Request(");
                    WriteArguments(writer, parameterMapping);
                    _writer.RemoveTrailingComma();
                    _writer.Append($").Request,");
                    _writer.Line($"originalResponse);");
                }
                else
                {
                    _writer.Append($"return new {lroObjectType}(");
                    _writer.Append($"{_parentProperty},");
                    _writer.Line($"originalResponse);");
                }
            });
        }

        /// <summary>
        /// Write some scaffolding for container operation methods.
        /// </summary>
        /// <param name="isAsync"></param>
        /// <param name="returnType">Must be string.</param>
        /// <param name="syncMethodName">Method name in its sync form.</param>
        /// <param name="parameters">Must not contain cancellationToken.</param>
        /// <param name="inner">Main logic of the method writer.</param>
        /// <param name="isOverride"></param>
        private void WriteContainerMethodScope(bool isAsync, FormattableString returnType, string syncMethodName, IEnumerable<Parameter> parameters, CodeWriterDelegate inner, bool isOverride = false)
        {
            if (isOverride)
            {
                _writer.WriteXmlDocumentationInheritDoc();
            }
            foreach (var parameter in parameters)
            {
                _writer.WriteXmlDocumentationParameter(parameter);
            }

            const string cancellationTokenParameter = "cancellationToken";
            _writer.WriteXmlDocumentationParameter(cancellationTokenParameter, @"A token to allow the caller to cancel the call to the service. The default value is <see cref=""CancellationToken.None"" />.");

            _writer.Append($"public {(isAsync ? "async " : string.Empty)}{(isOverride ? "override " : string.Empty)}{returnType} {CreateMethodName(syncMethodName, isAsync)}(");
            foreach (var parameter in parameters)
            {
                _writer.WriteParameter(parameter);
            }
            _writer.Append($"{typeof(CancellationToken)} {cancellationTokenParameter} = default)");
            using var _ = _writer.Scope();
            WriteDiagnosticScope(_writer, new Diagnostic($"{_resourceContainer.Type.Name}.{syncMethodName}"), ClientDiagnosticsField, writer =>
            {
                _writer.WriteParameterNullChecks(parameters.ToList());
                inner(_writer);
            });
        }

        private void WriteGetVariants(RestClientMethod method)
        {
            var parameterMapping = BuildParameterMapping(method);

            var methodName = _isScope ? "GetAtScope" : "Get";
            var scopeName = methodName;

            IEnumerable<Parameter> passThruParameters = parameterMapping.Where(p => p.IsPassThru).Select(p => p.Parameter);

            _writer.Line();
            _writer.WriteXmlDocumentationSummary($"Gets details for this resource from the service.");
            WriteContainerMethodScope(false, $"{typeof(Response)}<{_resource.Type.Name}>", methodName, passThruParameters, writer =>
            {
                _writer.Append($"var response = {RestClientField}.{method.Name}(");
                foreach (var parameter in parameterMapping)
                {
                    _writer.AppendRaw(parameter.IsPassThru ? parameter.Parameter.Name : parameter.ValueExpression);
                    _writer.AppendRaw(", ");
                }
                _writer.Line($"cancellationToken: cancellationToken);");
                _writer.Line($"return {typeof(Response)}.FromValue(new {_resource.Type}({_parentProperty}, response.Value), response.GetRawResponse());");
            }, isOverride: false);

            _writer.Line();
            _writer.WriteXmlDocumentationSummary($"Gets details for this resource from the service.");
            WriteContainerMethodScope(true, $"{typeof(Task)}<{typeof(Response)}<{_resource.Type.Name}>>", methodName, passThruParameters, writer =>
            {
                _writer.Append($"var response = await {RestClientField}.{method.Name}Async(");
                foreach (var parameter in parameterMapping)
                {
                    _writer.AppendRaw(parameter.IsPassThru ? parameter.Parameter.Name : parameter.ValueExpression);
                    _writer.AppendRaw(", ");
                }
                _writer.Line($"cancellationToken: cancellationToken).ConfigureAwait(false);");
                _writer.Line($"return {typeof(Response)}.FromValue(new {_resource.Type}({_parentProperty}, response.Value), response.GetRawResponse());");
            }, isOverride: false);
        }

        protected void WriteListAtScope(CodeWriter writer, bool async, CSharpType resourceType, List<PagingMethod> listMethods, FormattableString converter)
        {
            var methodName = CreateMethodName("ListAtScope", async);
            writer.Line();
            Parameter[] scopeParam = { new Parameter($"{_restClient?.ClientPrefix.ToSingular().FirstCharToLowerCase()}Scope", "The scope of the resource.", typeof(ResourceIdentifier), null, true) };
            Parameter[] nonPathParameters = scopeParam.Concat(listMethods[0].Method.NonPathParameters).ToArray();

            writer.WriteXmlDocumentationSummary("List resources at the specified scope");
            foreach (var param in nonPathParameters)
            {
                writer.WriteXmlDocumentationParameter(param);
            }
            writer.WriteXmlDocumentationParameter("cancellationToken", "The cancellation token to use.");
            string returnText = $"{(async ? "An async" : "A")} collection of <see cref=\"{resourceType.Name}\" /> that may take multiple service requests to iterate over.";
            writer.WriteXmlDocumentation("returns", returnText);

            var returnType = resourceType.WrapPageable(async);

            writer.Append($"public {returnType} {methodName}(");
            foreach (var param in nonPathParameters)
            {
                writer.WriteParameter(param);
            }
            writer.Line($"{typeof(CancellationToken)} cancellationToken = default)");

            using (writer.Scope())
            {
                WriteScopePagingOperationBody(writer, listMethods, resourceType, RestClientField, new Diagnostic($"{_resourceContainer.Type.Name}.{methodName}"), ClientDiagnosticsField, converter, async, nonPathParameters);
            }
        }

        protected void WriteScopePagingOperationBody(CodeWriter writer, List<PagingMethod> pagingMethods, CSharpType resourceType,
            string restClientName, Diagnostic diagnostic, string clientDiagnosticsName, FormattableString converter, bool async, Parameter[] parameters)
        {
            var returnType = new CSharpType(typeof(Page<>), resourceType).WrapAsync(async);
            using (writer.Scope($"{AsyncKeyword(async)} {returnType} FirstPageFunc({typeof(int?)} pageSizeHint)"))
            {
                // no null-checks because all are optional
                WriteDiagnosticScope(writer, diagnostic, clientDiagnosticsName, writer =>
                {
                    WriteScopePageFuncs(writer, pagingMethods, restClientName, converter, async, parameters, false);
                });
            }

            var nextPageFunctionName = "null";
            if (pagingMethods[0].NextPageMethod != null)
            {
                nextPageFunctionName = "NextPageFunc";
                var nextPageParameters = pagingMethods[0].NextPageMethod!.Parameters;
                using (writer.Scope($"{AsyncKeyword(async)} {returnType} {nextPageFunctionName}({typeof(string)} nextLink, {typeof(int?)} pageSizeHint)"))
                {
                    WriteDiagnosticScope(writer, diagnostic, clientDiagnosticsName, writer =>
                    {
                        WriteScopePageFuncs(writer, pagingMethods, restClientName, converter, async, parameters, true);
                    });
                }
            }
            writer.Line($"return {typeof(PageableHelpers)}.{CreateMethodName("Create", async)}Enumerable(FirstPageFunc, {nextPageFunctionName});");
        }

        private void WriteScopePageFuncs(CodeWriter writer, List<PagingMethod> pagingMethods, string restClientName, FormattableString converter, bool async, Parameter[] parameters, bool isNextPageFunc)
        {
            writer.WriteParameterNullChecks(new List<Parameter>{parameters[0]});
            var nextLinkName = pagingMethods[0].PagingResponse.NextLinkProperty?.Declaration.Name;
            var itemName = pagingMethods[0].PagingResponse.ItemProperty.Declaration.Name;
            var continuationTokenText = nextLinkName != null ? $"response.Value.{nextLinkName}" : "null";
            var configureAwaitText = async ? ".ConfigureAwait(false)" : string.Empty;
            var listAtScopeMethod = pagingMethods.FirstOrDefault(m => m.Method.Name.StartsWith("ListAtScope"));
            if (listAtScopeMethod != null)
            {
                writer.Append($"var response = {AwaitKeyword(async)} {restClientName}.{CreateMethodName(isNextPageFunc ? listAtScopeMethod.NextPageMethod!.Name : listAtScopeMethod.Method.Name, async)}(");
                if (isNextPageFunc)
                {
                    writer.Append($"nextLink, ");
                }
                foreach (var parameter in parameters)
                {
                    writer.Append($"{parameter.Name}, ");
                }
                writer.Line($"cancellationToken: cancellationToken){configureAwaitText};");
            }
            else
            {
                writer.Line($"Response<{pagingMethods[0].PagingResponse.ResponseType.Name}> response;");
                var listForManagementGroupMethod = pagingMethods.FirstOrDefault(m => m.Method.Name.StartsWith("List") && m.Method.Name.EndsWith("ManagementGroup"));
                if (listForManagementGroupMethod != null)
                {
                    using (writer.Scope($"if ({parameters[0].Name}.GetType() == typeof(TenantResourceIdentifier))"))
                    {
                        using (writer.Scope($"if ({parameters[0].Name}.ResourceType.Equals(\"Microsoft.Management/managementGroups\"))"))
                        {
                            writer.Append($"response = {AwaitKeyword(async)} {restClientName}.{CreateMethodName(isNextPageFunc ? listForManagementGroupMethod.NextPageMethod!.Name : listForManagementGroupMethod.Method.Name, async)}(");
                            if (isNextPageFunc)
                            {
                                writer.Append($"nextLink, ");
                            }
                            foreach (var parameter in parameters)
                            {
                                if (parameter.Name.EndsWith("Scope", StringComparison.InvariantCultureIgnoreCase))
                                {
                                    writer.Append($"{parameter.Name}.Name, ");
                                }
                                else
                                {
                                    writer.Append($"{parameter.Name}, ");
                                }
                            }
                            writer.Line($"cancellationToken: cancellationToken){configureAwaitText};");
                        }
                        using (writer.Scope($"else"))
                        {
                            writer.Line($"throw new ArgumentException($\"Invalid scope: {{{parameters[0].Name}}}.\", nameof({parameters[0].Name}));");
                        }
                    }
                }
                var elseStr = listForManagementGroupMethod != null ? "else " : "";
                var listForSubscriptionMethod = pagingMethods.FirstOrDefault(m => m.Method.Name.StartsWith("List") && (m.Method.Name.EndsWith("Subscription") || (m.Method.Description?.Contains("subscription", StringComparison.InvariantCultureIgnoreCase) == true && m.Method.Description?.Contains("resource group", StringComparison.InvariantCultureIgnoreCase) == false)));
                if (listForSubscriptionMethod != null)
                {
                    using (writer.Scope($"{elseStr}if ({parameters[0].Name:D}.GetType() == typeof(SubscriptionResourceIdentifier))"))
                    {
                        writer.Line($"var subscription = {parameters[0].Name} as SubscriptionResourceIdentifier;");
                        writer.Append($"response = {AwaitKeyword(async)} {restClientName}.{CreateMethodName(isNextPageFunc ? listForSubscriptionMethod.NextPageMethod!.Name : listForSubscriptionMethod.Method.Name, async)}(");
                        if (isNextPageFunc)
                        {
                            writer.Append($"nextLink, ");
                        }
                        foreach (var parameter in parameters)
                        {
                            if (parameter.Name.EndsWith("Scope", StringComparison.InvariantCultureIgnoreCase))
                            {
                                writer.Append($"subscription.SubscriptionId, ");
                            }
                            else
                            {
                                writer.Append($"{parameter.Name}, ");
                            }
                        }
                        writer.Line($"cancellationToken: cancellationToken){configureAwaitText};");
                    }
                }
                elseStr = (!elseStr.IsNullOrEmpty() || listForSubscriptionMethod != null) ? "else " : "";
                var listForResourceGroupMethod = pagingMethods.FirstOrDefault(m => m.Method.Name.StartsWith("List") && m.Method.Name.EndsWith("ResourceGroup"));
                if (listForResourceGroupMethod != null)
                {
                    using (writer.Scope($"{elseStr}if ({parameters[0].Name:D}.GetType() == typeof(ResourceGroupResourceIdentifier))"))
                    {
                        writer.Line($"var resourceGroupId = {parameters[0].Name} as ResourceGroupResourceIdentifier;");
                        using (writer.Scope($"if ({parameters[0].Name:D}.ResourceType.Equals(ResourceGroupOperations.ResourceType))"))
                        {
                            writer.Append($"response = {AwaitKeyword(async)} {restClientName}.{CreateMethodName(isNextPageFunc ? listForResourceGroupMethod.NextPageMethod!.Name : listForResourceGroupMethod.Method.Name, async)}(");
                            if (isNextPageFunc)
                            {
                                writer.Append($"nextLink, ");
                            }
                            foreach (var parameter in parameters)
                            {
                                if (parameter.Name.EndsWith("Scope", StringComparison.InvariantCultureIgnoreCase))
                                {
                                    writer.Append($"resourceGroupId.SubscriptionId, ");
                                    writer.Append($"resourceGroupId.ResourceGroupName, ");
                                }
                                else
                                {
                                    writer.Append($"{parameter.Name}, ");
                                }
                            }
                            writer.Line($"cancellationToken: cancellationToken){configureAwaitText};");
                        }
                        using (writer.Scope($"else"))
                        {
                            var listForResourceMethod = pagingMethods.FirstOrDefault(m => m.Method.Name.StartsWith("List") && m.Method.Name.EndsWith("Resource"));
                            if (listForResourceMethod != null)
                            {
                                //TODO: the parameter names are hardcoded now instead of checking the real parameters.
                                //Here we need to parse ID to the path parameters, in RestClient, the path parameters are combined into ID as part of the URL.
                                //We may consider making RestClient taking in ID as a parameter directly.
                                writer.Line($"var resourceProviderNamespace = resourceGroupId.ResourceType.Namespace;");
                                writer.Line($"var resourceType = resourceGroupId.ResourceType.Types[resourceGroupId.ResourceType.Types.Count - 1];");
                                writer.Line($"var resourceName = resourceGroupId.Name;");
                                writer.Line($"var parent = resourceGroupId.Parent;");
                                writer.UseNamespace("System.Collections.Generic");
                                writer.Line($"var parentParts = new List<string>();");
                                using (writer.Scope($"while (!parent.ResourceType.Equals(ResourceGroupOperations.ResourceType))"))
                                {
                                    writer.Line($"parentParts.Insert(0, $\"{{parent.ResourceType.Types[parent.ResourceType.Types.Count - 1]}}/{{parent.Name}}\");");
                                    writer.Line($"parent = parent.Parent;");
                                }
                                writer.Line($"var parentResourcePath = parentParts.Count > 0 ? string.Join(\"/\", parentParts) : \"\";");
                                writer.Append($"response = {AwaitKeyword(async)} {restClientName}.{CreateMethodName(isNextPageFunc ? listForResourceMethod.NextPageMethod!.Name : listForResourceMethod.Method.Name, async)}(");
                                if (isNextPageFunc)
                                {
                                    writer.Append($"nextLink, ");
                                }
                                foreach (var parameter in parameters)
                                {
                                    if (parameter.Name.EndsWith("Scope", StringComparison.InvariantCultureIgnoreCase))
                                    {
                                        writer.Append($"resourceGroupId.SubscriptionId, ");
                                        writer.Append($"resourceGroupId.ResourceGroupName, ");
                                        writer.Append($"resourceProviderNamespace, ");
                                        writer.Append($"parentResourcePath, ");
                                        writer.Append($"resourceType, ");
                                        writer.Append($"resourceName, ");
                                    }
                                    else
                                    {
                                        writer.Append($"{parameter.Name}, ");
                                    }
                                }
                                writer.Line($"cancellationToken: cancellationToken){configureAwaitText};");
                            }
                            else
                            {
                                writer.Line($"throw new ArgumentException($\"Invalid scope: {{{parameters[0].Name}}}.\", nameof({parameters[0].Name}));");
                            }
                        }
                    }
                }
                using (writer.Scope($"else"))
                {
                    writer.Line($"throw new ArgumentException($\"Invalid scope: {{{parameters[0].Name}}}.\", nameof({parameters[0].Name}));");
                }
            }
            // need the Select() for converting XXXResourceData to XXXResource
            if (!string.IsNullOrEmpty(converter.ToString()))
            {
                writer.UseNamespace("System.Linq");
            }
            writer.Append($"return {typeof(Page)}.FromValues(response.Value.{itemName}");
            writer.Append($"{converter}");
            writer.Line($", {continuationTokenText}, response.GetRawResponse());");
        }

        private void WriteGetByIdVariants(RestClientMethod method)
        {
            var parameterMapping = BuildParameterMapping(method);

            var methodName = "GetById";
            var scopeName = methodName;

            IEnumerable<Parameter> passThruParameters = parameterMapping.Where(p => p.IsPassThru).Select(p => p.Parameter);

            _writer.Line();
            _writer.WriteXmlDocumentationSummary($"Gets details for this resource from the service by ID.");
            WriteContainerMethodScope(false, $"{typeof(Response)}<{_resource.Type.Name}>", methodName, passThruParameters, writer =>
            {
                _writer.Append($"var response = {RestClientField}.{method.Name}(");
                foreach (var parameter in parameterMapping)
                {
                    _writer.AppendRaw(parameter.IsPassThru ? parameter.Parameter.Name : parameter.ValueExpression);
                    _writer.AppendRaw(", ");
                }
                _writer.Line($"cancellationToken: cancellationToken);");
                _writer.Line($"return {typeof(Response)}.FromValue(new {_resource.Type}({_parentProperty}, response.Value), response.GetRawResponse());");
            }, isOverride: false);

            _writer.Line();
            _writer.WriteXmlDocumentationSummary($"Gets details for this resource from the service by ID.");
            WriteContainerMethodScope(true, $"{typeof(Task)}<{typeof(Response)}<{_resource.Type.Name}>>", methodName, passThruParameters, writer =>
            {
                _writer.Append($"var response = await {RestClientField}.{method.Name}Async(");
                foreach (var parameter in parameterMapping)
                {
                    _writer.AppendRaw(parameter.IsPassThru ? parameter.Parameter.Name : parameter.ValueExpression);
                    _writer.AppendRaw(", ");
                }
                _writer.Line($"cancellationToken: cancellationToken).ConfigureAwait(false);");
                _writer.Line($"return {typeof(Response)}.FromValue(new {_resource.Type}({_parentProperty}, response.Value), response.GetRawResponse());");
            }, isOverride: false);
        }

        private void WriteListVariants()
        {
            if (_isScope)
            {
                if (_resourceContainer.ScopeListMethods != null)
                {
                    WriteListAtScope(_writer, false, _resource.Type, _resourceContainer.ScopeListMethods, $".Select(value => new {_resource.Type.Name}({_parentProperty}, value))");
                    WriteListAtScope(_writer, true, _resource.Type, _resourceContainer.ScopeListMethods, $".Select(value => new {_resource.Type.Name}({_parentProperty}, value))");
                }

            }
            else
            {
                if (_resourceContainer.ListMethod != null)
                {
                    WriteList(_writer, false, _resource.Type, _resourceContainer.ListMethod, $".Select(value => new {_resource.Type.Name}({_parentProperty}, value))");
                    WriteList(_writer, true, _resource.Type, _resourceContainer.ListMethod, $".Select(value => new {_resource.Type.Name}({_parentProperty}, value))");
                }

                WriteListAsGenericResource(async: false);
                WriteListAsGenericResource(async: true);
            }
        }

        private void WriteListAsGenericResource(bool async)
        {
            const string syncMethodName = "ListAsGenericResource";
            var methodName = CreateMethodName(syncMethodName, async);
            _writer.Line();
            _writer.WriteXmlDocumentationSummary($"Filters the list of {_resource.Type.Name} for this resource group represented as generic resources.");
            _writer.WriteXmlDocumentationParameter("nameFilter", "The filter used in this operation.");
            _writer.WriteXmlDocumentationParameter("expand", "Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`.");
            _writer.WriteXmlDocumentationParameter("top", "The number of results to return.");
            _writer.WriteXmlDocumentationParameter("cancellationToken", "A token to allow the caller to cancel the call to the service. The default value is <see cref=\"CancellationToken.None\" />.");
            _writer.WriteXmlDocumentation("returns", $"{(async ? "An async" : "A")} collection of resource that may take multiple service requests to iterate over.");
            CSharpType returnType = new CSharpType(async ? typeof(AsyncPageable<>) : typeof(Pageable<>), typeof(GenericResourceExpanded));
            using (_writer.Scope($"public {returnType} {methodName}(string nameFilter, string expand = null, int? top = null, {typeof(CancellationToken)} cancellationToken = default)"))
            {
                WriteDiagnosticScope(_writer, new Diagnostic($"{_resourceContainer.Type.Name}.{syncMethodName}"), ClientDiagnosticsField, writer =>
                {
                    _writer.Line($"var filters = new {typeof(ResourceFilterCollection)}({_resource.Type}.ResourceType);");
                    _writer.Line($"filters.SubstringFilter = nameFilter;");
                    _writer.Line($"return {typeof(ResourceListOperations)}.{CreateMethodName("ListAtContext", async)}({_parentProperty} as {typeof(ResourceGroupOperations)}, filters, expand, top, cancellationToken);");
                });
            }
        }

        private void WriteBuilders()
        {
            _writer.Line();
            _writer.Line($"// Builders.");
            _writer.LineRaw($"// public ArmBuilder<{_resourceContainer.ResourceIdentifierType.Name}, {_resource.Type.Name}, {_resourceData.Type.Name}> Construct() {{ }}");
        }
    }
}
