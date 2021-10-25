// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;
using SupersetFlattenInheritance.Models;

namespace SupersetFlattenInheritance
{
    /// <summary> A class representing collection of TrackedResourceModel1 and their operations over its parent. </summary>
    public partial class TrackedResourceModel1Container : ArmContainer
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly TrackedResourceModel1SRestOperations _trackedResourceModel1sRestClient;

        /// <summary> Initializes a new instance of the <see cref="TrackedResourceModel1Container"/> class for mocking. </summary>
        protected TrackedResourceModel1Container()
        {
        }

        /// <summary> Initializes a new instance of TrackedResourceModel1Container class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal TrackedResourceModel1Container(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _trackedResourceModel1sRestClient = new TrackedResourceModel1SRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroup.ResourceType;

        // Container level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/trackedResourceModel1s/{trackedResourceModel1sName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: TrackedResourceModel1s_Put
        /// <param name="trackedResourceModel1SName"> The String to use. </param>
        /// <param name="parameters"> The TrackedResourceModel1 to use. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="trackedResourceModel1SName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual TrackedResourceModel1PutOperation CreateOrUpdate(string trackedResourceModel1SName, TrackedResourceModel1Data parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (trackedResourceModel1SName == null)
            {
                throw new ArgumentNullException(nameof(trackedResourceModel1SName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("TrackedResourceModel1Container.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _trackedResourceModel1sRestClient.Put(Id.ResourceGroupName, trackedResourceModel1SName, parameters, cancellationToken);
                var operation = new TrackedResourceModel1PutOperation(Parent, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/trackedResourceModel1s/{trackedResourceModel1sName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: TrackedResourceModel1s_Put
        /// <param name="trackedResourceModel1SName"> The String to use. </param>
        /// <param name="parameters"> The TrackedResourceModel1 to use. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="trackedResourceModel1SName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<TrackedResourceModel1PutOperation> CreateOrUpdateAsync(string trackedResourceModel1SName, TrackedResourceModel1Data parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (trackedResourceModel1SName == null)
            {
                throw new ArgumentNullException(nameof(trackedResourceModel1SName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("TrackedResourceModel1Container.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _trackedResourceModel1sRestClient.PutAsync(Id.ResourceGroupName, trackedResourceModel1SName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new TrackedResourceModel1PutOperation(Parent, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/trackedResourceModel1s/{trackedResourceModel1sName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: TrackedResourceModel1s_Get
        /// <param name="trackedResourceModel1SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="trackedResourceModel1SName"/> is null. </exception>
        public virtual Response<TrackedResourceModel1> Get(string trackedResourceModel1SName, CancellationToken cancellationToken = default)
        {
            if (trackedResourceModel1SName == null)
            {
                throw new ArgumentNullException(nameof(trackedResourceModel1SName));
            }

            using var scope = _clientDiagnostics.CreateScope("TrackedResourceModel1Container.Get");
            scope.Start();
            try
            {
                var response = _trackedResourceModel1sRestClient.Get(Id.ResourceGroupName, trackedResourceModel1SName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TrackedResourceModel1(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/trackedResourceModel1s/{trackedResourceModel1sName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: TrackedResourceModel1s_Get
        /// <param name="trackedResourceModel1SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="trackedResourceModel1SName"/> is null. </exception>
        public async virtual Task<Response<TrackedResourceModel1>> GetAsync(string trackedResourceModel1SName, CancellationToken cancellationToken = default)
        {
            if (trackedResourceModel1SName == null)
            {
                throw new ArgumentNullException(nameof(trackedResourceModel1SName));
            }

            using var scope = _clientDiagnostics.CreateScope("TrackedResourceModel1Container.Get");
            scope.Start();
            try
            {
                var response = await _trackedResourceModel1sRestClient.GetAsync(Id.ResourceGroupName, trackedResourceModel1SName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new TrackedResourceModel1(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="trackedResourceModel1SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="trackedResourceModel1SName"/> is null. </exception>
        public virtual Response<TrackedResourceModel1> GetIfExists(string trackedResourceModel1SName, CancellationToken cancellationToken = default)
        {
            if (trackedResourceModel1SName == null)
            {
                throw new ArgumentNullException(nameof(trackedResourceModel1SName));
            }

            using var scope = _clientDiagnostics.CreateScope("TrackedResourceModel1Container.GetIfExists");
            scope.Start();
            try
            {
                var response = _trackedResourceModel1sRestClient.Get(Id.ResourceGroupName, trackedResourceModel1SName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<TrackedResourceModel1>(null, response.GetRawResponse())
                    : Response.FromValue(new TrackedResourceModel1(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="trackedResourceModel1SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="trackedResourceModel1SName"/> is null. </exception>
        public async virtual Task<Response<TrackedResourceModel1>> GetIfExistsAsync(string trackedResourceModel1SName, CancellationToken cancellationToken = default)
        {
            if (trackedResourceModel1SName == null)
            {
                throw new ArgumentNullException(nameof(trackedResourceModel1SName));
            }

            using var scope = _clientDiagnostics.CreateScope("TrackedResourceModel1Container.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _trackedResourceModel1sRestClient.GetAsync(Id.ResourceGroupName, trackedResourceModel1SName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<TrackedResourceModel1>(null, response.GetRawResponse())
                    : Response.FromValue(new TrackedResourceModel1(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="trackedResourceModel1SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="trackedResourceModel1SName"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string trackedResourceModel1SName, CancellationToken cancellationToken = default)
        {
            if (trackedResourceModel1SName == null)
            {
                throw new ArgumentNullException(nameof(trackedResourceModel1SName));
            }

            using var scope = _clientDiagnostics.CreateScope("TrackedResourceModel1Container.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(trackedResourceModel1SName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="trackedResourceModel1SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="trackedResourceModel1SName"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string trackedResourceModel1SName, CancellationToken cancellationToken = default)
        {
            if (trackedResourceModel1SName == null)
            {
                throw new ArgumentNullException(nameof(trackedResourceModel1SName));
            }

            using var scope = _clientDiagnostics.CreateScope("TrackedResourceModel1Container.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(trackedResourceModel1SName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="TrackedResourceModel1" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TrackedResourceModel1Container.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(TrackedResourceModel1.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="TrackedResourceModel1" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TrackedResourceModel1Container.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(TrackedResourceModel1.ResourceType);
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
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, TrackedResourceModel1, TrackedResourceModel1Data> Construct() { }
    }
}
