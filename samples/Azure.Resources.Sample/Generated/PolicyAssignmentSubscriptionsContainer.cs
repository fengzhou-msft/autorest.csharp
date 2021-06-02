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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Core.Resources;

namespace Azure.ResourceManager.Resources
{
    /// <summary> A class representing collection of PolicyAssignment and their operations over a Subscription. </summary>
    public partial class PolicyAssignmentSubscriptionsContainer : ResourceContainerBase<SubscriptionResourceIdentifier, PolicyAssignment, PolicyAssignmentData>
    {
        /// <summary> Initializes a new instance of the <see cref="PolicyAssignmentSubscriptionsContainer"/> class for mocking. </summary>
        protected PolicyAssignmentSubscriptionsContainer()
        {
        }

        /// <summary> Initializes a new instance of PolicyAssignmentSubscriptionsContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal PolicyAssignmentSubscriptionsContainer(ResourceOperationsBase parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _pipeline = ManagementPipelineBuilder.Build(Credential, BaseUri, ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;

        /// <summary> Represents the REST operations. </summary>
        private PolicyAssignmentsRestOperations _restClient => new PolicyAssignmentsRestOperations(_clientDiagnostics, _pipeline, Id.SubscriptionId);

        /// <summary> Typed Resource Identifier for the container. </summary>
        public new ResourceGroupResourceIdentifier Id => base.Id as ResourceGroupResourceIdentifier;

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => SubscriptionOperations.ResourceType;

        // Container level operations.

        /// <summary> The operation to create or update a PolicyAssignment. Please note some properties can be set only during creation. </summary>
        /// <param name="policyAssignmentName"> The name of the policy assignment. </param>
        /// <param name="parameters"> Parameters for the policy assignment. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="P:System.Threading.CancellationToken.None" />. </param>
        public Response<PolicyAssignment> CreateOrUpdate(string policyAssignmentName, PolicyAssignmentData parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyAssignmentSubscriptionsContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                if (policyAssignmentName == null)
                {
                    throw new ArgumentNullException(nameof(policyAssignmentName));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                return StartCreateOrUpdate(policyAssignmentName, parameters, cancellationToken: cancellationToken).WaitForCompletion();
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a PolicyAssignment. Please note some properties can be set only during creation. </summary>
        /// <param name="policyAssignmentName"> The name of the policy assignment. </param>
        /// <param name="parameters"> Parameters for the policy assignment. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="P:System.Threading.CancellationToken.None" />. </param>
        public async Task<Response<PolicyAssignment>> CreateOrUpdateAsync(string policyAssignmentName, PolicyAssignmentData parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyAssignmentSubscriptionsContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                if (policyAssignmentName == null)
                {
                    throw new ArgumentNullException(nameof(policyAssignmentName));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                var operation = await StartCreateOrUpdateAsync(policyAssignmentName, parameters, cancellationToken: cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync().ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a PolicyAssignment. Please note some properties can be set only during creation. </summary>
        /// <param name="policyAssignmentName"> The name of the policy assignment. </param>
        /// <param name="parameters"> Parameters for the policy assignment. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="P:System.Threading.CancellationToken.None" />. </param>
        public PolicyAssignmentsCreateOperation StartCreateOrUpdate(string policyAssignmentName, PolicyAssignmentData parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyAssignmentSubscriptionsContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                if (policyAssignmentName == null)
                {
                    throw new ArgumentNullException(nameof(policyAssignmentName));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                var originalResponse = _restClient.Create(Id.Name, policyAssignmentName, parameters, cancellationToken: cancellationToken);
                return new PolicyAssignmentsCreateOperation(Parent, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a PolicyAssignment. Please note some properties can be set only during creation. </summary>
        /// <param name="policyAssignmentName"> The name of the policy assignment. </param>
        /// <param name="parameters"> Parameters for the policy assignment. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="P:System.Threading.CancellationToken.None" />. </param>
        public async Task<PolicyAssignmentsCreateOperation> StartCreateOrUpdateAsync(string policyAssignmentName, PolicyAssignmentData parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyAssignmentSubscriptionsContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                if (policyAssignmentName == null)
                {
                    throw new ArgumentNullException(nameof(policyAssignmentName));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                var originalResponse = await _restClient.CreateAsync(Id.Name, policyAssignmentName, parameters, cancellationToken: cancellationToken).ConfigureAwait(false);
                return new PolicyAssignmentsCreateOperation(Parent, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        /// <param name="policyAssignmentName"> The name of the policy assignment to get. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="P:System.Threading.CancellationToken.None" />. </param>
        public override Response<PolicyAssignment> Get(string policyAssignmentName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyAssignmentSubscriptionsContainer.Get");
            scope.Start();
            try
            {
                if (policyAssignmentName == null)
                {
                    throw new ArgumentNullException(nameof(policyAssignmentName));
                }

                var response = _restClient.Get(Id.Name, policyAssignmentName, cancellationToken: cancellationToken);
                return Response.FromValue(new PolicyAssignment(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        /// <param name="policyAssignmentName"> The name of the policy assignment to get. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="P:System.Threading.CancellationToken.None" />. </param>
        public async override Task<Response<PolicyAssignment>> GetAsync(string policyAssignmentName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyAssignmentSubscriptionsContainer.Get");
            scope.Start();
            try
            {
                if (policyAssignmentName == null)
                {
                    throw new ArgumentNullException(nameof(policyAssignmentName));
                }

                var response = await _restClient.GetAsync(Id.Name, policyAssignmentName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new PolicyAssignment(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="PolicyAssignment" /> for this resource group. </summary>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="P:System.Threading.CancellationToken.None" />. </param>
        /// <returns> A collection of <see cref="PolicyAssignment" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<PolicyAssignment> List(int? top = null, CancellationToken cancellationToken = default)
        {
            Page<PolicyAssignment> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PolicyAssignmentSubscriptionsContainer.List");
                scope.Start();
                try
                {
                    var response = _restClient.List(cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new PolicyAssignment(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<PolicyAssignment> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PolicyAssignmentSubscriptionsContainer.List");
                scope.Start();
                try
                {
                    var response = _restClient.ListNextPage(nextLink, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new PolicyAssignment(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="PolicyAssignment" /> for this resource group. Makes an additional network call to retrieve the full data model for each resource group. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="P:System.Threading.CancellationToken.None" />. </param>
        /// <returns> A collection of <see cref="PolicyAssignment" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<PolicyAssignment> List(string nameFilter, int? top = null, CancellationToken cancellationToken = default)
        {
            var results = ListAsGenericResource(null, top, cancellationToken);
            return new PhWrappingPageable<GenericResource, PolicyAssignment>(results, genericResource => new PolicyAssignmentSubscriptionsOperations(genericResource, genericResource.Id as SubscriptionResourceIdentifier).Get().Value);
        }

        /// <summary> Filters the list of <see cref="PolicyAssignment" /> for this resource group. </summary>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="P:System.Threading.CancellationToken.None" />. </param>
        /// <returns> An async collection of <see cref="PolicyAssignment" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<PolicyAssignment> ListAsync(int? top = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<PolicyAssignment>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PolicyAssignmentSubscriptionsContainer.List");
                scope.Start();
                try
                {
                    var response = await _restClient.ListAsync(cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new PolicyAssignment(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<PolicyAssignment>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PolicyAssignmentSubscriptionsContainer.List");
                scope.Start();
                try
                {
                    var response = await _restClient.ListNextPageAsync(nextLink, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new PolicyAssignment(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="PolicyAssignment" /> for this resource group. Makes an additional network call to retrieve the full data model for each resource group. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="P:System.Threading.CancellationToken.None" />. </param>
        /// <returns> An async collection of <see cref="PolicyAssignment" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<PolicyAssignment> ListAsync(string nameFilter, int? top = null, CancellationToken cancellationToken = default)
        {
            var results = ListAsGenericResourceAsync(null, top, cancellationToken);
            return new PhWrappingAsyncPageable<GenericResource, PolicyAssignment>(results, genericResource => new PolicyAssignmentSubscriptionsOperations(genericResource, genericResource.Id as SubscriptionResourceIdentifier).Get().Value);
        }

        /// <summary> Filters the list of PolicyAssignment for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="P:System.Threading.CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<Core.GenericResource> ListAsGenericResource(string nameFilter, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyAssignmentSubscriptionsContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(PolicyAssignment.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContext(Parent as Core.ResourceGroupOperations, filters, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of PolicyAssignment for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="P:System.Threading.CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<Core.GenericResource> ListAsGenericResourceAsync(string nameFilter, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyAssignmentSubscriptionsContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(PolicyAssignment.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContextAsync(Parent as Core.ResourceGroupOperations, filters, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<SubscriptionResourceIdentifier, PolicyAssignment, PolicyAssignmentData> Construct() { }
    }
}
