// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.CoreResources.Models;
using Azure.ResourceManager.Management;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.CoreResources
{
    /// <summary> A class representing collection of PolicySetDefinition and their operations over a Tenant. </summary>
    public partial class PolicySetDefinitionContainer : ArmContainer
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly PolicySetDefinitionsRestOperations _restClient;

        /// <summary> Initializes a new instance of the <see cref="PolicySetDefinitionContainer"/> class for mocking. </summary>
        protected PolicySetDefinitionContainer()
        {
        }

        /// <summary> Initializes a new instance of PolicySetDefinitionContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal PolicySetDefinitionContainer(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new PolicySetDefinitionsRestOperations(_clientDiagnostics, Pipeline, BaseUri);
        }

        /// <summary> Verify that the input resource Id is a valid container for this type. </summary>
        /// <param name="identifier"> The input resource Id to check. </param>
        protected override void ValidateResourceType(ResourceIdentifier identifier)
        {
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceIdentifier.RootResourceIdentifier.ResourceType;

        // Container level operations.

        /// <summary> This operation creates or updates a policy set definition in the given subscription with the given name. </summary>
        /// <param name="policySetDefinitionName"> The name of the policy set definition to create. </param>
        /// <param name="parameters"> The policy set definition properties. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="policySetDefinitionName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual PolicySetDefinitionCreateOrUpdateOperation CreateOrUpdate(string policySetDefinitionName, PolicySetDefinitionData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (policySetDefinitionName == null)
            {
                throw new ArgumentNullException(nameof(policySetDefinitionName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("PolicySetDefinitionContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                if (Id.TryGetSubscriptionId(out _))
                {
                    var response = _restClient.CreateOrUpdate(Id.Name, policySetDefinitionName, parameters, cancellationToken);
                    var operation = new PolicySetDefinitionCreateOrUpdateOperation(Parent, response);
                    if (waitForCompletion)
                        operation.WaitForCompletion(cancellationToken);
                    return operation;
                }
                else
                {
                    var response = _restClient.CreateOrUpdateAtManagementGroup(Id.Name, policySetDefinitionName, parameters, cancellationToken);
                    var operation = new PolicySetDefinitionCreateOrUpdateOperation(Parent, response);
                    if (waitForCompletion)
                        operation.WaitForCompletion(cancellationToken);
                    return operation;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation creates or updates a policy set definition in the given subscription with the given name. </summary>
        /// <param name="policySetDefinitionName"> The name of the policy set definition to create. </param>
        /// <param name="parameters"> The policy set definition properties. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="policySetDefinitionName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<PolicySetDefinitionCreateOrUpdateOperation> CreateOrUpdateAsync(string policySetDefinitionName, PolicySetDefinitionData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (policySetDefinitionName == null)
            {
                throw new ArgumentNullException(nameof(policySetDefinitionName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("PolicySetDefinitionContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                if (Id.TryGetSubscriptionId(out _))
                {
                    var response = await _restClient.CreateOrUpdateAsync(Id.Name, policySetDefinitionName, parameters, cancellationToken).ConfigureAwait(false);
                    var operation = new PolicySetDefinitionCreateOrUpdateOperation(Parent, response);
                    if (waitForCompletion)
                        await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                    return operation;
                }
                else
                {
                    var response = await _restClient.CreateOrUpdateAtManagementGroupAsync(Id.Name, policySetDefinitionName, parameters, cancellationToken).ConfigureAwait(false);
                    var operation = new PolicySetDefinitionCreateOrUpdateOperation(Parent, response);
                    if (waitForCompletion)
                        await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                    return operation;
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="policySetDefinitionName"> The name of the policy set definition to get. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<PolicySetDefinition> Get(string policySetDefinitionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicySetDefinitionContainer.Get");
            scope.Start();
            try
            {
                if (policySetDefinitionName == null)
                {
                    throw new ArgumentNullException(nameof(policySetDefinitionName));
                }

                if (Id.TryGetSubscriptionId(out _))
                {
                    var response = _restClient.Get(Id.Name, policySetDefinitionName, cancellationToken: cancellationToken);
                    if (response.Value == null)
                        throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                    return Response.FromValue(new PolicySetDefinition(Parent, response.Value), response.GetRawResponse());
                }
                else
                {
                    var parent = Id;
                    while (parent.Parent != ResourceIdentifier.RootResourceIdentifier)
                    {
                        parent = parent.Parent;
                    }
                    if (parent.ResourceType.Equals(ManagementGroup.ResourceType))
                    {
                        var response = _restClient.GetAtManagementGroup(Id.Name, policySetDefinitionName, cancellationToken: cancellationToken);
                        if (response.Value == null)
                            throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                        return Response.FromValue(new PolicySetDefinition(Parent, response.Value), response.GetRawResponse());
                    }
                    else
                    {
                        var response = _restClient.GetBuiltIn(policySetDefinitionName, cancellationToken: cancellationToken);
                        if (response.Value == null)
                            throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                        return Response.FromValue(new PolicySetDefinition(Parent, response.Value), response.GetRawResponse());
                    }
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="policySetDefinitionName"> The name of the policy set definition to get. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<PolicySetDefinition>> GetAsync(string policySetDefinitionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicySetDefinitionContainer.Get");
            scope.Start();
            try
            {
                if (policySetDefinitionName == null)
                {
                    throw new ArgumentNullException(nameof(policySetDefinitionName));
                }

                if (Id.TryGetSubscriptionId(out _))
                {
                    var response = await _restClient.GetAsync(Id.Name, policySetDefinitionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    if (response.Value == null)
                        throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                    return Response.FromValue(new PolicySetDefinition(Parent, response.Value), response.GetRawResponse());
                }
                else
                {
                    var parent = Id;
                    while (parent.Parent != ResourceIdentifier.RootResourceIdentifier)
                    {
                        parent = parent.Parent;
                    }
                    if (parent.ResourceType.Equals(ManagementGroup.ResourceType))
                    {
                        var response = await _restClient.GetAtManagementGroupAsync(Id.Name, policySetDefinitionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                        if (response.Value == null)
                            throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                        return Response.FromValue(new PolicySetDefinition(Parent, response.Value), response.GetRawResponse());
                    }
                    else
                    {
                        var response = await _restClient.GetBuiltInAsync(policySetDefinitionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                        if (response.Value == null)
                            throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                        return Response.FromValue(new PolicySetDefinition(Parent, response.Value), response.GetRawResponse());
                    }
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="policySetDefinitionName"> The name of the policy set definition to get. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<PolicySetDefinition> GetIfExists(string policySetDefinitionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicySetDefinitionContainer.GetIfExists");
            scope.Start();
            try
            {
                if (policySetDefinitionName == null)
                {
                    throw new ArgumentNullException(nameof(policySetDefinitionName));
                }

                var response = _restClient.Get(Id.Name, policySetDefinitionName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<PolicySetDefinition>(null, response.GetRawResponse())
                    : Response.FromValue(new PolicySetDefinition(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="policySetDefinitionName"> The name of the policy set definition to get. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<PolicySetDefinition>> GetIfExistsAsync(string policySetDefinitionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicySetDefinitionContainer.GetIfExists");
            scope.Start();
            try
            {
                if (policySetDefinitionName == null)
                {
                    throw new ArgumentNullException(nameof(policySetDefinitionName));
                }

                var response = await _restClient.GetAsync(Id.Name, policySetDefinitionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<PolicySetDefinition>(null, response.GetRawResponse())
                    : Response.FromValue(new PolicySetDefinition(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="policySetDefinitionName"> The name of the policy set definition to get. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<bool> CheckIfExists(string policySetDefinitionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicySetDefinitionContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (policySetDefinitionName == null)
                {
                    throw new ArgumentNullException(nameof(policySetDefinitionName));
                }

                var response = GetIfExists(policySetDefinitionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="policySetDefinitionName"> The name of the policy set definition to get. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string policySetDefinitionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicySetDefinitionContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (policySetDefinitionName == null)
                {
                    throw new ArgumentNullException(nameof(policySetDefinitionName));
                }

                var response = await GetIfExistsAsync(policySetDefinitionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation retrieves a list of all the policy set definitions in a given subscription that match the optional given $filter. Valid values for $filter are: &apos;atExactScope()&apos;, &apos;policyType -eq {value}&apos; or &apos;category eq &apos;{value}&apos;&apos;. If $filter is not provided, the unfiltered list includes all policy set definitions associated with the subscription, including those that apply directly or from management groups that contain the given subscription. If $filter=atExactScope() is provided, the returned list only includes all policy set definitions that at the given subscription. If $filter=&apos;policyType -eq {value}&apos; is provided, the returned list only includes all policy set definitions whose type match the {value}. Possible policyType values are NotSpecified, BuiltIn and Custom. If $filter=&apos;category -eq {value}&apos; is provided, the returned list only includes all policy set definitions whose category match the {value}. </summary>
        /// <param name="filter"> The filter to apply on the operation. Valid values for $filter are: &apos;atExactScope()&apos;, &apos;policyType -eq {value}&apos; or &apos;category eq &apos;{value}&apos;&apos;. If $filter is not provided, no filtering is performed. If $filter=atExactScope() is provided, the returned list only includes all policy set definitions that at the given scope. If $filter=&apos;policyType -eq {value}&apos; is provided, the returned list only includes all policy set definitions whose type match the {value}. Possible policyType values are NotSpecified, BuiltIn, Custom, and Static. If $filter=&apos;category -eq {value}&apos; is provided, the returned list only includes all policy set definitions whose category match the {value}. </param>
        /// <param name="top"> Maximum number of records to return. When the $top filter is not provided, it will return 500 records. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PolicySetDefinition" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PolicySetDefinition> GetAll(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            Page<PolicySetDefinition> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PolicySetDefinitionContainer.GetAll");
                scope.Start();
                try
                {
                    if (Id.TryGetSubscriptionId(out _))
                    {
                        var response = _restClient.GetAll(Id.Name, filter, top, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value.Select(value => new PolicySetDefinition(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    else
                    {
                        var parent = Id;
                        while (parent.Parent != ResourceIdentifier.RootResourceIdentifier)
                        {
                            parent = parent.Parent;
                        }
                        if (parent.ResourceType.Equals(ManagementGroup.ResourceType))
                        {
                            var response = _restClient.GetAllByManagementGroup(Id.Name, filter, top, cancellationToken: cancellationToken);
                            return Page.FromValues(response.Value.Value.Select(value => new PolicySetDefinition(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                        }
                        else
                        {
                            var response = _restClient.GetBuiltIn(filter, top, cancellationToken: cancellationToken);
                            return Page.FromValues(response.Value.Value.Select(value => new PolicySetDefinition(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                        }
                    }
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<PolicySetDefinition> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PolicySetDefinitionContainer.GetAll");
                scope.Start();
                try
                {
                    if (Id.TryGetSubscriptionId(out _))
                    {
                        var response = _restClient.GetAllNextPage(nextLink, Id.Name, filter, top, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value.Select(value => new PolicySetDefinition(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    else
                    {
                        var parent = Id;
                        while (parent.Parent != ResourceIdentifier.RootResourceIdentifier)
                        {
                            parent = parent.Parent;
                        }
                        if (parent.ResourceType.Equals(ManagementGroup.ResourceType))
                        {
                            var response = _restClient.GetAllByManagementGroupNextPage(nextLink, Id.Name, filter, top, cancellationToken: cancellationToken);
                            return Page.FromValues(response.Value.Value.Select(value => new PolicySetDefinition(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                        }
                        else
                        {
                            var response = _restClient.GetBuiltInNextPage(nextLink, filter, top, cancellationToken: cancellationToken);
                            return Page.FromValues(response.Value.Value.Select(value => new PolicySetDefinition(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                        }
                    }
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> This operation retrieves a list of all the policy set definitions in a given subscription that match the optional given $filter. Valid values for $filter are: &apos;atExactScope()&apos;, &apos;policyType -eq {value}&apos; or &apos;category eq &apos;{value}&apos;&apos;. If $filter is not provided, the unfiltered list includes all policy set definitions associated with the subscription, including those that apply directly or from management groups that contain the given subscription. If $filter=atExactScope() is provided, the returned list only includes all policy set definitions that at the given subscription. If $filter=&apos;policyType -eq {value}&apos; is provided, the returned list only includes all policy set definitions whose type match the {value}. Possible policyType values are NotSpecified, BuiltIn and Custom. If $filter=&apos;category -eq {value}&apos; is provided, the returned list only includes all policy set definitions whose category match the {value}. </summary>
        /// <param name="filter"> The filter to apply on the operation. Valid values for $filter are: &apos;atExactScope()&apos;, &apos;policyType -eq {value}&apos; or &apos;category eq &apos;{value}&apos;&apos;. If $filter is not provided, no filtering is performed. If $filter=atExactScope() is provided, the returned list only includes all policy set definitions that at the given scope. If $filter=&apos;policyType -eq {value}&apos; is provided, the returned list only includes all policy set definitions whose type match the {value}. Possible policyType values are NotSpecified, BuiltIn, Custom, and Static. If $filter=&apos;category -eq {value}&apos; is provided, the returned list only includes all policy set definitions whose category match the {value}. </param>
        /// <param name="top"> Maximum number of records to return. When the $top filter is not provided, it will return 500 records. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PolicySetDefinition" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PolicySetDefinition> GetAllAsync(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<PolicySetDefinition>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PolicySetDefinitionContainer.GetAll");
                scope.Start();
                try
                {
                    if (Id.TryGetSubscriptionId(out _))
                    {
                        var response = await _restClient.GetAllAsync(Id.Name, filter, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value.Select(value => new PolicySetDefinition(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    else
                    {
                        var parent = Id;
                        while (parent.Parent != ResourceIdentifier.RootResourceIdentifier)
                        {
                            parent = parent.Parent;
                        }
                        if (parent.ResourceType.Equals(ManagementGroup.ResourceType))
                        {
                            var response = await _restClient.GetAllByManagementGroupAsync(Id.Name, filter, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                            return Page.FromValues(response.Value.Value.Select(value => new PolicySetDefinition(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                        }
                        else
                        {
                            var response = await _restClient.GetBuiltInAsync(filter, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                            return Page.FromValues(response.Value.Value.Select(value => new PolicySetDefinition(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                        }
                    }
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<PolicySetDefinition>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PolicySetDefinitionContainer.GetAll");
                scope.Start();
                try
                {
                    if (Id.TryGetSubscriptionId(out _))
                    {
                        var response = await _restClient.GetAllNextPageAsync(nextLink, Id.Name, filter, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value.Select(value => new PolicySetDefinition(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    else
                    {
                        var parent = Id;
                        while (parent.Parent != ResourceIdentifier.RootResourceIdentifier)
                        {
                            parent = parent.Parent;
                        }
                        if (parent.ResourceType.Equals(ManagementGroup.ResourceType))
                        {
                            var response = await _restClient.GetAllByManagementGroupNextPageAsync(nextLink, Id.Name, filter, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                            return Page.FromValues(response.Value.Value.Select(value => new PolicySetDefinition(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                        }
                        else
                        {
                            var response = await _restClient.GetBuiltInNextPageAsync(nextLink, filter, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                            return Page.FromValues(response.Value.Value.Select(value => new PolicySetDefinition(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                        }
                    }
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="PolicySetDefinition" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicySetDefinitionContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(PolicySetDefinition.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="PolicySetDefinition" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicySetDefinitionContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(PolicySetDefinition.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<ResourceIdentifier, PolicySetDefinition, PolicySetDefinitionData> Construct() { }
    }
}
