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
using AutoRest.CSharp.Input;
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
        private CodeWriter _writer;
        private ResourceContainer _resourceContainer;
        private ResourceData _resourceData;
        private Resource _resource;
        private ResourceOperation _resourceOperation;
        private BuildContext<MgmtOutputLibrary> _context;

        protected override string ContextProperty => "Parent";

        protected CSharpType TypeOfThis => _resourceContainer.Type;
        protected override string TypeNameOfThis => TypeOfThis.Name;

        public ResourceContainerWriter(CodeWriter writer, ResourceContainer resourceContainer, BuildContext<MgmtOutputLibrary> context)
        {
            _writer = writer;
            _resourceContainer = resourceContainer;
            var operationGroup = resourceContainer.OperationGroup;
            _resourceData = context.Library.GetResourceData(operationGroup);
            _restClient = context.Library.GetRestClient(operationGroup);
            _resource = context.Library.GetArmResource(operationGroup);
            _resourceOperation = context.Library.GetResourceOperation(operationGroup);
            _context = context;
        }

        public void WriteContainer()
        {
            WriteUsings(_writer);

            using (_writer.Namespace(TypeOfThis.Namespace))
            {
                _writer.WriteXmlDocumentationSummary($"{_resourceContainer.Description}");
                _writer.Append($"{_resourceContainer.Declaration.Accessibility} partial class {TypeNameOfThis:D} : ");
                if (_resourceContainer.GetMethod != null)
                {
                    _writer.Line($"ResourceContainerBase<{_resourceContainer.ResourceIdentifierType}, {_resource.Type}, {_resourceData.Type}>");
                }
                else
                {
                    _writer.Line($"{typeof(ContainerBase)}");
                }
                using (_writer.Scope())
                {
                    WriteContainerCtors(_writer, typeof(OperationsBase), "parent");
                    //TODO: this is a workaround to allow resource container to accept multiple parent resource types
                    //Eventually we can change ValidResourceType to become ValidResourceTypes and rewrite the base Validate().
                    if (_resourceContainer.OperationGroup.IsScopeResource(_context.Configuration.MgmtConfiguration) || _resourceContainer.OperationGroup.IsExtensionResource(_context.Configuration.MgmtConfiguration) && _resourceContainer.GetValidResourceValue() == ResourceContainer.TenantResourceType)
                    {
                        WriteValidate();
                    }
                    WriteFields(_writer, _restClient!);
                    WriteIdProperty();
                    WriteContainerProperties(_writer, _resourceContainer.GetValidResourceValue());
                    WriteResourceOperations();
                    WriteRemainingMethods();
                    WriteBuilders();
                }
            }
        }

        private void WriteParent()
        {
            _writer.Line();
            _writer.WriteXmlDocumentationSummary($"Get the parent resource of this container.");
            _writer.Line($"protected new ResourceOperationsBase Parent {{ get {{return base.Parent as ResourceOperationsBase;}} }}");
        }

        private void WriteValidate()
        {
            _writer.Line();
            _writer.WriteXmlDocumentationSummary($"Verify that the input resource Id is a valid container for this type.");
            _writer.WriteXmlDocumentationParameter("identifier", $"The input resource Id to check.");
            _writer.Line($"protected override void ValidateResourceType(ResourceIdentifier identifier)");
            using (_writer.Scope())
            {
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

            if (_resourceContainer.CreateMethod != null)
            {
                WriteCreateOrUpdateVariants(_resourceContainer.CreateMethod, _resourceContainer.PutMethods);
            }

            if (_resourceContainer.GetMethod != null)
            {
                var getMethods = _resourceContainer.GetMethods.Select(m => m.RestClientMethod).ToList();
                WriteGetVariants(_resourceContainer.GetMethod.RestClientMethod, getMethods);
                WriteTryGetVariants(_resourceContainer.GetMethod.RestClientMethod);
                WriteDoesExistVariants(_resourceContainer.GetMethod.RestClientMethod);
            }

            // TODO: Add back code with refactored base method as in WriteCreateOrUpdateVariants
            // if (_resourceContainer.PutByIdMethod != null)
            // {
            //     WriteCreateByIdVariants(_resourceContainer.PutByIdMethod);
            // }

            if (_resourceContainer.GetByIdMethod?.RestClientMethod != null && _resourceContainer.GetMethod?.RestClientMethod != _resourceContainer.GetByIdMethod.RestClientMethod)
            {
                WriteGetByIdVariants(_resourceContainer.GetByIdMethod.RestClientMethod);
            }

            WriteListVariants();
        }

        private void WriteDoesExistVariants(RestClientMethod getMethod)
        {
            var parameterMapping = BuildParameterMapping(getMethod);

            var methodName = "Get";
            var scopeName = methodName;

            IEnumerable<Parameter> passThruParameters = parameterMapping.Where(p => p.IsPassThru).Select(p => p.Parameter);

            _writer.Line();
            _writer.WriteXmlDocumentationSummary($"Tries to get details for this resource from the service.");
            WriteContainerMethodScope(false, $"bool", "DoesExist", passThruParameters, writer =>
            {
                _writer.Append($"return TryGet(");
                foreach (var parameter in passThruParameters)
                {
                    _writer.AppendRaw(parameter.Name);
                    _writer.AppendRaw(", ");
                }
                _writer.Line($"cancellationToken: cancellationToken) != null;");
            }, isOverride: false);

            _writer.Line();
            _writer.WriteXmlDocumentationSummary($"Tries to get details for this resource from the service.");
            WriteContainerMethodScope(true, $"{typeof(Task)}<bool>", "DoesExist", passThruParameters, writer =>
            {
                _writer.Append($"return await TryGetAsync(");
                foreach (var parameter in passThruParameters)
                {
                    _writer.AppendRaw(parameter.Name);
                    _writer.AppendRaw(", ");
                }
                _writer.Line($"cancellationToken: cancellationToken).ConfigureAwait(false) != null;");
            }, isOverride: false);
        }

        private void WriteTryGetVariants(RestClientMethod getMethod)
        {
            var parameterMapping = BuildParameterMapping(getMethod);

            var methodName = "Get";
            var scopeName = methodName;

            IEnumerable<Parameter> passThruParameters = parameterMapping.Where(p => p.IsPassThru).Select(p => p.Parameter);

            _writer.Line();
            _writer.WriteXmlDocumentationSummary($"Tries to get details for this resource from the service.");
            WriteContainerMethodScope(false, $"{_resource.Type.Name}", "TryGet", passThruParameters, writer =>
            {
                _writer.Append($"return Get(");
                foreach (var parameter in passThruParameters)
                {
                    _writer.AppendRaw(parameter.Name);
                    _writer.AppendRaw(", ");
                }
                _writer.Line($"cancellationToken: cancellationToken).Value;");
            }, isOverride: false, catch404: true);

            _writer.Line();
            _writer.WriteXmlDocumentationSummary($"Tries to get details for this resource from the service.");
            WriteContainerMethodScope(true, $"{typeof(Task)}<{_resource.Type.Name}>", "TryGet", passThruParameters, writer =>
            {
                _writer.Append($"return await GetAsync(");
                foreach (var parameter in passThruParameters)
                {
                    _writer.AppendRaw(parameter.Name);
                    _writer.AppendRaw(", ");
                }
                _writer.Line($"cancellationToken: cancellationToken).ConfigureAwait(false);");
            }, isOverride: false, catch404: true);
        }

        private void WriteCreateOrUpdateVariants(RestClientMethod clientMethod, List<RestClientMethod>? clientMethods = null)
        {
            WriteFirstLROMethod(_writer, clientMethod, _context, false, true, "CreateOrUpdate");
            WriteFirstLROMethod(_writer, clientMethod, _context, true, true, "CreateOrUpdate");

            WriteStartLROMethod(_writer, clientMethod, _context, false, true, "CreateOrUpdate", clientMethods);
            WriteStartLROMethod(_writer, clientMethod, _context, true, true, "CreateOrUpdate", clientMethods);
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
        private void WriteContainerMethodScope(bool isAsync, FormattableString returnType, string syncMethodName, IEnumerable<Parameter> parameters, CodeWriterDelegate inner, bool isOverride = false, bool catch404 = false)
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
            _writer.WriteXmlDocumentationParameter(cancellationTokenParameter, $"A token to allow the caller to cancel the call to the service. The default value is <see cref=\"CancellationToken.None\" />.");

            _writer.Append($"public {AsyncKeyword(isAsync)} {OverrideKeyword(isOverride, true)} {returnType} {CreateMethodName(syncMethodName, isAsync)}(");
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
            }, catch404);
        }

        private void WriteGetVariants(RestClientMethod method, List<RestClientMethod> methods)
        {
            WriteGetMethod(method, false, methods, "Get");
            WriteGetMethod(method, true, methods, "Get");
        }

        private void WriteGetMethod(RestClientMethod method, bool async, List<RestClientMethod> methods, string? methodName = null)
        {
            methodName = methodName ?? method.Name;
            var parameterMapping = BuildParameterMapping(method);
            var scopeName = methodName;

            IEnumerable<Parameter> passThruParameters = parameterMapping.Where(p => p.IsPassThru).Select(p => p.Parameter);

            _writer.Line();
            _writer.WriteXmlDocumentationSummary($"Gets details for this resource from the service.");
            var taskStrStart = async ? $"{typeof(Task)}<" : string.Empty;
            var taskStrEnd = async ? ">" : string.Empty;
            WriteContainerMethodScope(async, $"{taskStrStart}{typeof(Response)}<{_resource.Type.Name}>{taskStrEnd}", methodName, passThruParameters, writer =>
            {
                if (method.Operation.IsAncestorScope() || methods.Count < 2)
                {
                    WriteGetMethodBody(writer, method, parameterMapping, async);
                }
                else
                {
                    var methodDict = methods.ToDictionary(m => m, m => m.Operation.AncestorResourceType());
                    var managementGroupMethod = methodDict.FirstOrDefault(kv => kv.Value == ResourceTypeBuilder.ManagementGroups).Key;
                    if (managementGroupMethod != null)
                    {
                        methodDict.Remove(managementGroupMethod);
                        using (writer.Scope($"if (Id.GetType() == typeof(TenantResourceIdentifier))"))
                        {
                            var parent = new CodeWriterDeclaration("parent");
                            writer.Line($"var {parent:D} = Id;");
                            using (writer.Scope($"while ({parent}.Parent != ResourceIdentifier.RootResourceIdentifier)"))
                            {
                                writer.Line($"{parent} = {parent}.Parent as TenantResourceIdentifier;");
                            }
                            using (writer.Scope($"if (parent.ResourceType.Equals(ManagementGroupOperations.ResourceType))"))
                            {
                                WriteGetMethodBody(writer, managementGroupMethod, BuildParameterMapping(managementGroupMethod), async);
                            }
                            using (writer.Scope($"else"))
                            {
                                var tenantMethod = methodDict.FirstOrDefault(kv => kv.Value == ResourceTypeBuilder.Tenant).Key;
                                if (tenantMethod != null)
                                {
                                    methodDict.Remove(tenantMethod);
                                    WriteGetMethodBody(writer, tenantMethod, BuildParameterMapping(tenantMethod), async);
                                }
                                else
                                {
                                    writer.Line($"throw new ArgumentException($\"Invalid Id: {{Id}}.\");");
                                }
                            }
                        }
                    }
                    var elseStr = managementGroupMethod != null ? "else " : "";
                    var subscriptionMethod = methodDict.FirstOrDefault(kv => kv.Value == ResourceTypeBuilder.Subscriptions).Key;
                    if (subscriptionMethod != null)
                    {
                        methodDict.Remove(subscriptionMethod);
                        using (writer.Scope($"{elseStr}if (Id.GetType() == typeof(SubscriptionResourceIdentifier))"))
                        {
                            WriteGetMethodBody(writer, subscriptionMethod, BuildParameterMapping(subscriptionMethod), async);
                        }
                    }

                    elseStr = (!elseStr.IsNullOrEmpty() || subscriptionMethod != null) ? "else " : string.Empty;
                    // There could be methods at resource group scope and at resource scope.
                    var resourceGroupMethod = methodDict.FirstOrDefault(kv => kv.Value == ResourceTypeBuilder.ResourceGroups).Key;
                    if (resourceGroupMethod != null)
                    {
                        methodDict.Remove(resourceGroupMethod);
                        using (writer.Scope($"{elseStr}if (Id.GetType() == typeof(ResourceGroupResourceIdentifier))"))
                        {
                            WriteGetMethodBody(writer, resourceGroupMethod, BuildParameterMapping(resourceGroupMethod), async);
                        }
                    }
                    using (writer.Scope($"else"))
                    {
                        if (methodDict.Count() > 0)
                        {
                            throw new Exception($"When trying to merge methods, multiple methods can be mapped to the same scope. The methods not handled: {String.Join(", ", methodDict.Select(kv => kv.Key.Name).ToList())}.");
                        }
                        writer.Line($"throw new ArgumentException($\"Invalid Id: {{Id}}.\");");
                    }
                }
            }, isOverride: false);
        }

        private void WriteGetMethodBody(CodeWriter writer, RestClientMethod method, IEnumerable<ParameterMapping> parameterMapping, bool async)
        {
            writer.Append($"var response = ");
            if (async)
            {
                writer.Append($"await ");
            }
            writer.Append($"{RestClientField}.{CreateMethodName($"{method.Name}", async)}(");
            foreach (var parameter in parameterMapping)
            {
                writer.AppendRaw(parameter.IsPassThru ? parameter.Parameter.Name : parameter.ValueExpression);
                writer.AppendRaw(", ");
            }
            writer.Append($"cancellationToken: cancellationToken)");
            if (async)
            {
                writer.Append($".ConfigureAwait(false)");
            }
            writer.Line($";");
            writer.Line($"return {typeof(Response)}.FromValue(new {_resource.Type}({ContextProperty}, response.Value), response.GetRawResponse());");
        }

        protected void WriteListAtScope(CodeWriter writer, bool async, CSharpType resourceType, List<PagingMethod> listMethods, FormattableString converter)
        {
            var methodName = CreateMethodName("List", async);
            writer.Line();
            var mainListMethod = listMethods.FirstOrDefault(m => m.Method.Parameters.FirstOrDefault()?.Name.Equals("scope") == true) ?? listMethods[0];
            var nonPathDomainParameters = mainListMethod.NonPathDomainParameters;

            writer.WriteXmlDocumentationSummary($"List resources at the specified scope");
            foreach (var param in nonPathDomainParameters)
            {
                writer.WriteXmlDocumentationParameter(param);
            }
            writer.WriteXmlDocumentationParameter("cancellationToken", $"The cancellation token to use.");
            string returnText = $"{(async ? "An async" : "A")} collection of <see cref=\"{resourceType.Name}\" /> that may take multiple service requests to iterate over.";
            writer.WriteXmlDocumentation("returns", $"{returnText}");

            var returnType = resourceType.WrapPageable(async);

            writer.Append($"public {returnType} {methodName}(");
            foreach (var param in nonPathDomainParameters)
            {
                writer.WriteParameter(param);
            }
            writer.Line($"{typeof(CancellationToken)} cancellationToken = default)");

            using (writer.Scope())
            {
                WriteScopePagingOperationBody(writer, listMethods, resourceType, RestClientField, new Diagnostic($"{_resourceContainer.Type.Name}.{methodName}"), ClientDiagnosticsField, converter, async, nonPathDomainParameters);
            }
        }

        protected void WriteScopePagingOperationBody(CodeWriter writer, List<PagingMethod> pagingMethods, CSharpType resourceType,
            string restClientName, Diagnostic diagnostic, string clientDiagnosticsName, FormattableString converter, bool async, List<Parameter> parameters)
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

            var mainListMethod = pagingMethods.FirstOrDefault(m => m.Method.Parameters.FirstOrDefault()?.Name.Equals("scope") == true) ?? pagingMethods[0];
            var nextPageFunctionName = "null";
            if (mainListMethod.NextPageMethod != null)
            {
                nextPageFunctionName = "NextPageFunc";
                var nextPageParameters = mainListMethod.NextPageMethod!.Parameters;
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

        private void WriteScopePageFuncs(CodeWriter writer, List<PagingMethod> pagingMethods, string restClientName, FormattableString converter, bool async, List<Parameter> parameters, bool isNextPageFunc)
        {
            var mainListMethod = pagingMethods.FirstOrDefault(m => m.Method.Parameters.FirstOrDefault()?.Name.Equals("scope") == true) ?? pagingMethods[0];
            writer.WriteParameterNullChecks(parameters);
            var nextLinkName = mainListMethod.PagingResponse.NextLinkProperty?.Declaration.Name;
            var itemName = mainListMethod.PagingResponse.ItemProperty.Declaration.Name;
            var continuationTokenText = nextLinkName != null ? $"response.Value.{nextLinkName}" : "null";
            var configureAwaitText = async ? ".ConfigureAwait(false)" : string.Empty;
            var listAtScopeMethod = pagingMethods.FirstOrDefault(m => m.Method.Name.StartsWith("List", StringComparison.InvariantCultureIgnoreCase) && m.Method.Parameters.FirstOrDefault()?.Name.Equals("scope") == true);
            if (listAtScopeMethod != null)
            {
                writer.Append($"var response = {AwaitKeyword(async)} {restClientName}.{CreateMethodName(isNextPageFunc ? listAtScopeMethod.NextPageMethod!.Name : listAtScopeMethod.Method.Name, async)}(");
                if (isNextPageFunc)
                {
                    writer.Append($"nextLink, ");
                }
                writer.Append($"Id, ");
                foreach (var parameter in parameters)
                {
                    writer.Append($"{parameter.Name}, ");
                }
                writer.Line($"cancellationToken: cancellationToken){configureAwaitText};");
            }
            else
            {
                writer.Line($"Response<{mainListMethod.PagingResponse.ResponseType.Name}> response;");
                var listForManagementGroupMethod = pagingMethods.FirstOrDefault(m => m.Method.Name.StartsWith("List") && m.Method.Name.EndsWith("ManagementGroup"));
                if (listForManagementGroupMethod != null)
                {
                    using (writer.Scope($"if (Id.GetType() == typeof(TenantResourceIdentifier))"))
                    {
                        using (writer.Scope($"if (Id.ResourceType.Equals(\"Microsoft.Management/managementGroups\"))"))
                        {
                            writer.Append($"response = {AwaitKeyword(async)} {restClientName}.{CreateMethodName(isNextPageFunc ? listForManagementGroupMethod.NextPageMethod!.Name : listForManagementGroupMethod.Method.Name, async)}(");
                            if (isNextPageFunc)
                            {
                                writer.Append($"nextLink, ");
                            }
                            writer.Append($"Id.Name, ");
                            foreach (var parameter in parameters)
                            {
                                writer.Append($"{parameter.Name}, ");
                            }
                            writer.Line($"cancellationToken: cancellationToken){configureAwaitText};");
                        }
                        using (writer.Scope($"else"))
                        {
                            writer.Line($"throw new ArgumentException($\"Invalid container Id: {{Id}}.\");");
                        }
                    }
                }
                var elseStr = listForManagementGroupMethod != null ? "else " : "";
                var listForSubscriptionMethod = pagingMethods.FirstOrDefault(m => m.Method.Name.StartsWith("List") && (m.Method.Name.EndsWith("Subscription") || (m.Method.Description?.Contains("subscription", StringComparison.InvariantCultureIgnoreCase) == true && m.Method.Description?.Contains("resource group", StringComparison.InvariantCultureIgnoreCase) == false)));
                if (listForSubscriptionMethod != null)
                {
                    using (writer.Scope($"{elseStr}if (Id.GetType() == typeof(SubscriptionResourceIdentifier))"))
                    {
                        writer.Line($"var subscription = Id as SubscriptionResourceIdentifier;");
                        writer.Append($"response = {AwaitKeyword(async)} {restClientName}.{CreateMethodName(isNextPageFunc ? listForSubscriptionMethod.NextPageMethod!.Name : listForSubscriptionMethod.Method.Name, async)}(");
                        if (isNextPageFunc)
                        {
                            writer.Append($"nextLink, ");
                        }
                        writer.Append($"subscription.SubscriptionId, ");
                        foreach (var parameter in parameters)
                        {
                            writer.Append($"{parameter.Name}, ");
                        }
                        writer.Line($"cancellationToken: cancellationToken){configureAwaitText};");
                    }
                }
                elseStr = (!elseStr.IsNullOrEmpty() || listForSubscriptionMethod != null) ? "else " : string.Empty;
                var listForResourceGroupMethod = pagingMethods.FirstOrDefault(m => m.Method.Name.StartsWith("List") && m.Method.Name.EndsWith("ResourceGroup"));
                if (listForResourceGroupMethod != null)
                {
                    using (writer.Scope($"{elseStr}if (Id.GetType() == typeof(ResourceGroupResourceIdentifier))"))
                    {
                        writer.Line($"var resourceGroupId = Id as ResourceGroupResourceIdentifier;");
                        using (writer.Scope($"if (Id.ResourceType.Equals(ResourceGroupOperations.ResourceType))"))
                        {
                            writer.Append($"response = {AwaitKeyword(async)} {restClientName}.{CreateMethodName(isNextPageFunc ? listForResourceGroupMethod.NextPageMethod!.Name : listForResourceGroupMethod.Method.Name, async)}(");
                            if (isNextPageFunc)
                            {
                                writer.Append($"nextLink, ");
                            }
                            writer.Append($"resourceGroupId.SubscriptionId, ");
                            writer.Append($"resourceGroupId.ResourceGroupName, ");
                            foreach (var parameter in parameters)
                            {
                                writer.Append($"{parameter.Name}, ");
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
                                writer.Append($"resourceGroupId.SubscriptionId, ");
                                writer.Append($"resourceGroupId.ResourceGroupName, ");
                                writer.Append($"resourceProviderNamespace, ");
                                writer.Append($"parentResourcePath, ");
                                writer.Append($"resourceType, ");
                                writer.Append($"resourceName, ");
                                foreach (var parameter in parameters)
                                {
                                    writer.Append($"{parameter.Name}, ");
                                }
                                writer.Line($"cancellationToken: cancellationToken){configureAwaitText};");
                            }
                            else
                            {
                                writer.Line($"throw new ArgumentException($\"Invalid container Id: {{Id}}.\");");
                            }
                        }
                    }
                }
                using (writer.Scope($"else"))
                {
                    writer.Line($"throw new ArgumentException($\"Invalid container Id: {{Id}}.\");");
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
                _writer.Line($"return {typeof(Response)}.FromValue(new {_resource.Type}({ContextProperty}, response.Value), response.GetRawResponse());");
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
                _writer.Line($"return {typeof(Response)}.FromValue(new {_resource.Type}({ContextProperty}, response.Value), response.GetRawResponse());");
            }, isOverride: false);
        }

        private void WriteListVariants()
        {
            // TODO: Remove WriteListAtScope and also use WriteList for scope resource.
            if (_resourceContainer.OperationGroup.IsScopeResource(_context.Configuration.MgmtConfiguration))
            {
                if (_resourceContainer.ScopeListMethods != null)
                {
                    WriteListAtScope(_writer, false, _resource.Type, _resourceContainer.ScopeListMethods, $".Select(value => new {_resource.Type.Name}({ContextProperty}, value))");
                    WriteListAtScope(_writer, true, _resource.Type, _resourceContainer.ScopeListMethods, $".Select(value => new {_resource.Type.Name}({ContextProperty}, value))");
                }
            }
            else
            {
                var pagingMethods = _resourceContainer.ListMethods.Where(m => m.PagingMethod != null).Select(m => m.PagingMethod!).ToList();
                var pagingMethod = pagingMethods.OrderBy(m => m.Name.Length).FirstOrDefault();
                var clientMethods = _resourceContainer.ListMethods.Where(m => m.ClientMethod != null).Select(m => m.ClientMethod!).ToList();
                var clientMethod = clientMethods.OrderBy(m => m.Name.Length).FirstOrDefault();
                if (pagingMethod != null)
                {
                    WriteList(_writer, false, _resource.Type, pagingMethod, "List", $".Select(value => new {_resource.Type.Name}({ContextProperty}, value))", pagingMethods);
                    WriteList(_writer, true, _resource.Type, pagingMethod, "List", $".Select(value => new {_resource.Type.Name}({ContextProperty}, value))", pagingMethods);
                }

                _writer.Line();
                if (clientMethod != null)
                {
                    //TODO: merge methods like WriteList
                    WriteClientMethod(_writer, clientMethod, _resourceContainer.GetDiagnostic(clientMethod.RestClientMethod), _resourceContainer.OperationGroup, _context, true);
                    WriteClientMethod(_writer, clientMethod, _resourceContainer.GetDiagnostic(clientMethod.RestClientMethod), _resourceContainer.OperationGroup, _context, false);
                }
                if (_resourceContainer.GetValidResourceValue() == ResourceContainer.ResourceGroupOperationsResourceType)
                {
                    WriteListAsGenericResource(async: false);
                    WriteListAsGenericResource(async: true);
                }
            }
        }

        private void WriteListAsGenericResource(bool async)
        {
            const string syncMethodName = "ListAsGenericResource";
            var methodName = CreateMethodName(syncMethodName, async);
            _writer.Line();
            _writer.WriteXmlDocumentationSummary($"Filters the list of <see cref=\"{_resource.Type}\" /> for this resource group represented as generic resources.");
            _writer.WriteXmlDocumentationParameter("nameFilter", $"The filter used in this operation.");
            _writer.WriteXmlDocumentationParameter("expand", $"Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`.");
            _writer.WriteXmlDocumentationParameter("top", $"The number of results to return.");
            _writer.WriteXmlDocumentationParameter("cancellationToken", $"A token to allow the caller to cancel the call to the service. The default value is <see cref=\"CancellationToken.None\" />.");
            _writer.WriteXmlDocumentation("returns", $"{(async ? "An async" : "A")} collection of resource that may take multiple service requests to iterate over.");
            CSharpType returnType = new CSharpType(async ? typeof(AsyncPageable<>) : typeof(Pageable<>), typeof(GenericResourceExpanded));
            using (_writer.Scope($"public {returnType} {methodName}(string nameFilter, string expand = null, int? top = null, {typeof(CancellationToken)} cancellationToken = default)"))
            {
                WriteDiagnosticScope(_writer, new Diagnostic($"{_resourceContainer.Type.Name}.{syncMethodName}"), ClientDiagnosticsField, writer =>
                {
                    _writer.Line($"var filters = new {typeof(ResourceFilterCollection)}({_resource.Type}.ResourceType);");
                    _writer.Line($"filters.SubstringFilter = nameFilter;");
                    _writer.Line($"return {typeof(ResourceListOperations)}.{CreateMethodName("ListAtContext", async)}({ContextProperty} as {typeof(ResourceGroupOperations)}, filters, expand, top, cancellationToken);");
                });
            }
        }

        private void WriteBuilders()
        {
            _writer.Line();
            _writer.Line($"// Builders.");
            _writer.LineRaw($"// public ArmBuilder<{_resourceContainer.ResourceIdentifierType.Name}, {_resource.Type.Name}, {_resourceData.Type.Name}> Construct() {{ }}");
        }

        protected override void MakeResourceNameParamPassThrough(RestClientMethod method, List<ParameterMapping> parameterMapping, Stack<string> parentNameStack)
        {
            // if the method needs resource name (typically all non-list methods), we should make it pass-thru by
            // making the last string-like mandatory parameter (typically the resource name) pass-through
            if (!method.Name.StartsWith("List", StringComparison.InvariantCultureIgnoreCase))
            {
                var lastString = parameterMapping.LastOrDefault(parameter => parameter.Parameter.Type.IsStringLike() && IsMandatory(parameter.Parameter));
                if (lastString?.Parameter != null && !lastString.Parameter.Name.Equals("resourceGroupName", StringComparison.InvariantCultureIgnoreCase))
                {
                    lastString.IsPassThru = true;
                    parentNameStack.Pop();
                }
            }
        }

        protected override bool ShouldPassThrough(ref string dotParent, Stack<string> parentNameStack, Parameter parameter, ref string valueExpression)
        {
            bool passThru = false;
            var isAncestorResourceTypeTenant = _resourceOperation.OperationGroup.IsAncestorResourceTypeTenant(_context);
            if (string.Equals(parameter.Name, "resourceGroupName", StringComparison.InvariantCultureIgnoreCase) && !isAncestorResourceTypeTenant)
            {
                valueExpression = "Id.ResourceGroupName";
            }
            else
            {
                // container.Id is the ID of parent resource, so the first name should just be `Id.Name`
                parentNameStack.Push($"Id{dotParent}.Name");
                dotParent += ".Parent";
            }

            return passThru;
        }
    }
}
