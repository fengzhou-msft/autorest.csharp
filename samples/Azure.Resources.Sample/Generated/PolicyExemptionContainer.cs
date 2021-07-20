// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;

namespace Azure.Resources.Sample
{
    /// <summary> A class representing collection of PolicyExemption and their operations over a Tenant. </summary>
    public partial class PolicyExemptionContainer : ResourceContainerBase<TenantResourceIdentifier, PolicyExemption, PolicyExemptionData>
    {
        /// <summary> Initializes a new instance of the <see cref="PolicyExemptionContainer"/> class for mocking. </summary>
        protected PolicyExemptionContainer()
        {
        }

        /// <summary> Initializes a new instance of PolicyExemptionContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal PolicyExemptionContainer(OperationsBase parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        /// <summary> Verify that the input resource Id is a valid container for this type. </summary>
        /// <param name="identifier"> The input resource Id to check. </param>
        protected override void Validate(ResourceIdentifier identifier)
        {
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private PolicyExemptionsRestOperations _restClient => new PolicyExemptionsRestOperations(_clientDiagnostics, Pipeline, BaseUri);

        /// <summary> Typed Resource Identifier for the container. </summary>
        public new TenantResourceIdentifier Id => base.Id as TenantResourceIdentifier;

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceIdentifier.RootResourceIdentifier.ResourceType;

        // Container level operations.

        /// <summary>  This operation creates or updates a policy exemption with the given scope and name. Policy exemptions apply to all resources contained within their scope. For example, when you create a policy exemption at resource group scope for a policy assignment at the same or above level, the exemption exempts to all applicable resources in the resource group. </summary>
        /// <param name="policyExemptionName"> The name of the policy exemption to delete. </param>
        /// <param name="parameters"> Parameters for the policy exemption. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="policyExemptionName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual Response<PolicyExemption> CreateOrUpdate(string policyExemptionName, PolicyExemptionData parameters, CancellationToken cancellationToken = default)
        {
            if (policyExemptionName == null)
            {
                throw new ArgumentNullException(nameof(policyExemptionName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("PolicyExemptionContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = StartCreateOrUpdate(policyExemptionName, parameters, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>  This operation creates or updates a policy exemption with the given scope and name. Policy exemptions apply to all resources contained within their scope. For example, when you create a policy exemption at resource group scope for a policy assignment at the same or above level, the exemption exempts to all applicable resources in the resource group. </summary>
        /// <param name="policyExemptionName"> The name of the policy exemption to delete. </param>
        /// <param name="parameters"> Parameters for the policy exemption. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="policyExemptionName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<Response<PolicyExemption>> CreateOrUpdateAsync(string policyExemptionName, PolicyExemptionData parameters, CancellationToken cancellationToken = default)
        {
            if (policyExemptionName == null)
            {
                throw new ArgumentNullException(nameof(policyExemptionName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("PolicyExemptionContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = await StartCreateOrUpdateAsync(policyExemptionName, parameters, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>  This operation creates or updates a policy exemption with the given scope and name. Policy exemptions apply to all resources contained within their scope. For example, when you create a policy exemption at resource group scope for a policy assignment at the same or above level, the exemption exempts to all applicable resources in the resource group. </summary>
        /// <param name="policyExemptionName"> The name of the policy exemption to delete. </param>
        /// <param name="parameters"> Parameters for the policy exemption. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="policyExemptionName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual PolicyExemptionsCreateOrUpdateOperation StartCreateOrUpdate(string policyExemptionName, PolicyExemptionData parameters, CancellationToken cancellationToken = default)
        {
            if (policyExemptionName == null)
            {
                throw new ArgumentNullException(nameof(policyExemptionName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("PolicyExemptionContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id, policyExemptionName, parameters, cancellationToken);
                return new PolicyExemptionsCreateOrUpdateOperation(this, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>  This operation creates or updates a policy exemption with the given scope and name. Policy exemptions apply to all resources contained within their scope. For example, when you create a policy exemption at resource group scope for a policy assignment at the same or above level, the exemption exempts to all applicable resources in the resource group. </summary>
        /// <param name="policyExemptionName"> The name of the policy exemption to delete. </param>
        /// <param name="parameters"> Parameters for the policy exemption. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="policyExemptionName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<PolicyExemptionsCreateOrUpdateOperation> StartCreateOrUpdateAsync(string policyExemptionName, PolicyExemptionData parameters, CancellationToken cancellationToken = default)
        {
            if (policyExemptionName == null)
            {
                throw new ArgumentNullException(nameof(policyExemptionName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("PolicyExemptionContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id, policyExemptionName, parameters, cancellationToken).ConfigureAwait(false);
                return new PolicyExemptionsCreateOrUpdateOperation(this, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="policyExemptionName"> The name of the policy exemption to delete. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<PolicyExemption> Get(string policyExemptionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyExemptionContainer.Get");
            scope.Start();
            try
            {
                if (policyExemptionName == null)
                {
                    throw new ArgumentNullException(nameof(policyExemptionName));
                }

                var response = _restClient.Get(Id, policyExemptionName, cancellationToken: cancellationToken);
                return Response.FromValue(new PolicyExemption(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="policyExemptionName"> The name of the policy exemption to delete. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<PolicyExemption>> GetAsync(string policyExemptionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyExemptionContainer.Get");
            scope.Start();
            try
            {
                if (policyExemptionName == null)
                {
                    throw new ArgumentNullException(nameof(policyExemptionName));
                }

                var response = await _restClient.GetAsync(Id, policyExemptionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new PolicyExemption(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="policyExemptionName"> The name of the policy exemption to delete. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual PolicyExemption TryGet(string policyExemptionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyExemptionContainer.TryGet");
            scope.Start();
            try
            {
                if (policyExemptionName == null)
                {
                    throw new ArgumentNullException(nameof(policyExemptionName));
                }

                return Get(policyExemptionName, cancellationToken: cancellationToken).Value;
            }
            catch (RequestFailedException e) when (e.Status == 404)
            {
                return null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="policyExemptionName"> The name of the policy exemption to delete. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<PolicyExemption> TryGetAsync(string policyExemptionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyExemptionContainer.TryGet");
            scope.Start();
            try
            {
                if (policyExemptionName == null)
                {
                    throw new ArgumentNullException(nameof(policyExemptionName));
                }

                return await GetAsync(policyExemptionName, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
            catch (RequestFailedException e) when (e.Status == 404)
            {
                return null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="policyExemptionName"> The name of the policy exemption to delete. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual bool DoesExist(string policyExemptionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyExemptionContainer.DoesExist");
            scope.Start();
            try
            {
                if (policyExemptionName == null)
                {
                    throw new ArgumentNullException(nameof(policyExemptionName));
                }

                return TryGet(policyExemptionName, cancellationToken: cancellationToken) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="policyExemptionName"> The name of the policy exemption to delete. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<bool> DoesExistAsync(string policyExemptionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyExemptionContainer.DoesExist");
            scope.Start();
            try
            {
                if (policyExemptionName == null)
                {
                    throw new ArgumentNullException(nameof(policyExemptionName));
                }

                return await TryGetAsync(policyExemptionName, cancellationToken: cancellationToken).ConfigureAwait(false) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> List resources at the specified scope. </summary>
        /// <param name="filter"> The filter to apply on the operation. Valid values for $filter are: &apos;atScope()&apos;, &apos;atExactScope()&apos;, &apos;excludeExpired()&apos; or &apos;policyAssignmentId eq &apos;{value}&apos;&apos;. If $filter is not provided, no filtering is performed. If $filter is not provided, the unfiltered list includes all policy exemptions associated with the scope, including those that apply directly or apply from containing scopes. If $filter=atScope() is provided, the returned list only includes all policy exemptions that apply to the scope, which is everything in the unfiltered list except those applied to sub scopes contained within the given scope. If $filter=atExactScope() is provided, the returned list only includes all policy exemptions that at the given scope. If $filter=excludeExpired() is provided, the returned list only includes all policy exemptions that either haven&apos;t expired or didn&apos;t set expiration date. If $filter=policyAssignmentId eq &apos;{value}&apos; is provided. the returned list only includes all policy exemptions that are associated with the give policyAssignmentId. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PolicyExemption" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<PolicyExemption> List(string filter = null, CancellationToken cancellationToken = default)
        {
            Page<PolicyExemption> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PolicyExemptionContainer.List");
                scope.Start();
                try
                {
                    Response<PolicyExemptionListResult> response;
                    if (Id.GetType() == typeof(TenantResourceIdentifier))
                    {
                        if (Id.ResourceType.Equals("Microsoft.Management/managementGroups"))
                        {
                            response = _restClient.ListForManagementGroup(Id.Name, filter, cancellationToken: cancellationToken);
                        }
                        else
                        {
                            throw new ArgumentException($"Invalid container Id: {Id}.");
                        }
                    }
                    else if (Id.GetType() == typeof(SubscriptionResourceIdentifier))
                    {
                        var subscription = Id as SubscriptionResourceIdentifier;
                        response = _restClient.List(subscription.SubscriptionId, filter, cancellationToken: cancellationToken);
                    }
                    else if (Id.GetType() == typeof(ResourceGroupResourceIdentifier))
                    {
                        var resourceGroupId = Id as ResourceGroupResourceIdentifier;
                        if (Id.ResourceType.Equals(ResourceGroupOperations.ResourceType))
                        {
                            response = _restClient.ListForResourceGroup(resourceGroupId.SubscriptionId, resourceGroupId.ResourceGroupName, filter, cancellationToken: cancellationToken);
                        }
                        else
                        {
                            var resourceProviderNamespace = resourceGroupId.ResourceType.Namespace;
                            var resourceType = resourceGroupId.ResourceType.Types[resourceGroupId.ResourceType.Types.Count - 1];
                            var resourceName = resourceGroupId.Name;
                            var parent = resourceGroupId.Parent;
                            var parentParts = new List<string>();
                            while (!parent.ResourceType.Equals(ResourceGroupOperations.ResourceType))
                            {
                                parentParts.Insert(0, $"{parent.ResourceType.Types[parent.ResourceType.Types.Count - 1]}/{parent.Name}");
                                parent = parent.Parent;
                            }
                            var parentResourcePath = parentParts.Count > 0 ? string.Join("/", parentParts) : "";
                            response = _restClient.ListForResource(resourceGroupId.SubscriptionId, resourceGroupId.ResourceGroupName, resourceProviderNamespace, parentResourcePath, resourceType, resourceName, filter, cancellationToken: cancellationToken);
                        }
                    }
                    else
                    {
                        throw new ArgumentException($"Invalid container Id: {Id}.");
                    }
                    return Page.FromValues(response.Value.Value.Select(value => new PolicyExemption(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<PolicyExemption> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PolicyExemptionContainer.List");
                scope.Start();
                try
                {
                    Response<PolicyExemptionListResult> response;
                    if (Id.GetType() == typeof(TenantResourceIdentifier))
                    {
                        if (Id.ResourceType.Equals("Microsoft.Management/managementGroups"))
                        {
                            response = _restClient.ListForManagementGroupNextPage(nextLink, Id.Name, filter, cancellationToken: cancellationToken);
                        }
                        else
                        {
                            throw new ArgumentException($"Invalid container Id: {Id}.");
                        }
                    }
                    else if (Id.GetType() == typeof(SubscriptionResourceIdentifier))
                    {
                        var subscription = Id as SubscriptionResourceIdentifier;
                        response = _restClient.ListNextPage(nextLink, subscription.SubscriptionId, filter, cancellationToken: cancellationToken);
                    }
                    else if (Id.GetType() == typeof(ResourceGroupResourceIdentifier))
                    {
                        var resourceGroupId = Id as ResourceGroupResourceIdentifier;
                        if (Id.ResourceType.Equals(ResourceGroupOperations.ResourceType))
                        {
                            response = _restClient.ListForResourceGroupNextPage(nextLink, resourceGroupId.SubscriptionId, resourceGroupId.ResourceGroupName, filter, cancellationToken: cancellationToken);
                        }
                        else
                        {
                            var resourceProviderNamespace = resourceGroupId.ResourceType.Namespace;
                            var resourceType = resourceGroupId.ResourceType.Types[resourceGroupId.ResourceType.Types.Count - 1];
                            var resourceName = resourceGroupId.Name;
                            var parent = resourceGroupId.Parent;
                            var parentParts = new List<string>();
                            while (!parent.ResourceType.Equals(ResourceGroupOperations.ResourceType))
                            {
                                parentParts.Insert(0, $"{parent.ResourceType.Types[parent.ResourceType.Types.Count - 1]}/{parent.Name}");
                                parent = parent.Parent;
                            }
                            var parentResourcePath = parentParts.Count > 0 ? string.Join("/", parentParts) : "";
                            response = _restClient.ListForResourceNextPage(nextLink, resourceGroupId.SubscriptionId, resourceGroupId.ResourceGroupName, resourceProviderNamespace, parentResourcePath, resourceType, resourceName, filter, cancellationToken: cancellationToken);
                        }
                    }
                    else
                    {
                        throw new ArgumentException($"Invalid container Id: {Id}.");
                    }
                    return Page.FromValues(response.Value.Value.Select(value => new PolicyExemption(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> List resources at the specified scope. </summary>
        /// <param name="filter"> The filter to apply on the operation. Valid values for $filter are: &apos;atScope()&apos;, &apos;atExactScope()&apos;, &apos;excludeExpired()&apos; or &apos;policyAssignmentId eq &apos;{value}&apos;&apos;. If $filter is not provided, no filtering is performed. If $filter is not provided, the unfiltered list includes all policy exemptions associated with the scope, including those that apply directly or apply from containing scopes. If $filter=atScope() is provided, the returned list only includes all policy exemptions that apply to the scope, which is everything in the unfiltered list except those applied to sub scopes contained within the given scope. If $filter=atExactScope() is provided, the returned list only includes all policy exemptions that at the given scope. If $filter=excludeExpired() is provided, the returned list only includes all policy exemptions that either haven&apos;t expired or didn&apos;t set expiration date. If $filter=policyAssignmentId eq &apos;{value}&apos; is provided. the returned list only includes all policy exemptions that are associated with the give policyAssignmentId. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PolicyExemption" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<PolicyExemption> ListAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<PolicyExemption>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PolicyExemptionContainer.ListAsync");
                scope.Start();
                try
                {
                    Response<PolicyExemptionListResult> response;
                    if (Id.GetType() == typeof(TenantResourceIdentifier))
                    {
                        if (Id.ResourceType.Equals("Microsoft.Management/managementGroups"))
                        {
                            response = await _restClient.ListForManagementGroupAsync(Id.Name, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                        }
                        else
                        {
                            throw new ArgumentException($"Invalid container Id: {Id}.");
                        }
                    }
                    else if (Id.GetType() == typeof(SubscriptionResourceIdentifier))
                    {
                        var subscription = Id as SubscriptionResourceIdentifier;
                        response = await _restClient.ListAsync(subscription.SubscriptionId, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    }
                    else if (Id.GetType() == typeof(ResourceGroupResourceIdentifier))
                    {
                        var resourceGroupId = Id as ResourceGroupResourceIdentifier;
                        if (Id.ResourceType.Equals(ResourceGroupOperations.ResourceType))
                        {
                            response = await _restClient.ListForResourceGroupAsync(resourceGroupId.SubscriptionId, resourceGroupId.ResourceGroupName, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                        }
                        else
                        {
                            var resourceProviderNamespace = resourceGroupId.ResourceType.Namespace;
                            var resourceType = resourceGroupId.ResourceType.Types[resourceGroupId.ResourceType.Types.Count - 1];
                            var resourceName = resourceGroupId.Name;
                            var parent = resourceGroupId.Parent;
                            var parentParts = new List<string>();
                            while (!parent.ResourceType.Equals(ResourceGroupOperations.ResourceType))
                            {
                                parentParts.Insert(0, $"{parent.ResourceType.Types[parent.ResourceType.Types.Count - 1]}/{parent.Name}");
                                parent = parent.Parent;
                            }
                            var parentResourcePath = parentParts.Count > 0 ? string.Join("/", parentParts) : "";
                            response = await _restClient.ListForResourceAsync(resourceGroupId.SubscriptionId, resourceGroupId.ResourceGroupName, resourceProviderNamespace, parentResourcePath, resourceType, resourceName, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                        }
                    }
                    else
                    {
                        throw new ArgumentException($"Invalid container Id: {Id}.");
                    }
                    return Page.FromValues(response.Value.Value.Select(value => new PolicyExemption(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<PolicyExemption>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PolicyExemptionContainer.ListAsync");
                scope.Start();
                try
                {
                    Response<PolicyExemptionListResult> response;
                    if (Id.GetType() == typeof(TenantResourceIdentifier))
                    {
                        if (Id.ResourceType.Equals("Microsoft.Management/managementGroups"))
                        {
                            response = await _restClient.ListForManagementGroupNextPageAsync(nextLink, Id.Name, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                        }
                        else
                        {
                            throw new ArgumentException($"Invalid container Id: {Id}.");
                        }
                    }
                    else if (Id.GetType() == typeof(SubscriptionResourceIdentifier))
                    {
                        var subscription = Id as SubscriptionResourceIdentifier;
                        response = await _restClient.ListNextPageAsync(nextLink, subscription.SubscriptionId, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    }
                    else if (Id.GetType() == typeof(ResourceGroupResourceIdentifier))
                    {
                        var resourceGroupId = Id as ResourceGroupResourceIdentifier;
                        if (Id.ResourceType.Equals(ResourceGroupOperations.ResourceType))
                        {
                            response = await _restClient.ListForResourceGroupNextPageAsync(nextLink, resourceGroupId.SubscriptionId, resourceGroupId.ResourceGroupName, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                        }
                        else
                        {
                            var resourceProviderNamespace = resourceGroupId.ResourceType.Namespace;
                            var resourceType = resourceGroupId.ResourceType.Types[resourceGroupId.ResourceType.Types.Count - 1];
                            var resourceName = resourceGroupId.Name;
                            var parent = resourceGroupId.Parent;
                            var parentParts = new List<string>();
                            while (!parent.ResourceType.Equals(ResourceGroupOperations.ResourceType))
                            {
                                parentParts.Insert(0, $"{parent.ResourceType.Types[parent.ResourceType.Types.Count - 1]}/{parent.Name}");
                                parent = parent.Parent;
                            }
                            var parentResourcePath = parentParts.Count > 0 ? string.Join("/", parentParts) : "";
                            response = await _restClient.ListForResourceNextPageAsync(nextLink, resourceGroupId.SubscriptionId, resourceGroupId.ResourceGroupName, resourceProviderNamespace, parentResourcePath, resourceType, resourceName, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                        }
                    }
                    else
                    {
                        throw new ArgumentException($"Invalid container Id: {Id}.");
                    }
                    return Page.FromValues(response.Value.Value.Select(value => new PolicyExemption(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        // Builders.
        // public ArmBuilder<TenantResourceIdentifier, PolicyExemption, PolicyExemptionData> Construct() { }
    }
}
