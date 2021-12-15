// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;
using SupersetInheritance.Models;

namespace SupersetInheritance
{
    /// <summary> A class representing collection of SupersetModel1 and their operations over its parent. </summary>
    public partial class SupersetModel1Collection : ArmCollection, IEnumerable<SupersetModel1>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly SupersetModel1SRestOperations _supersetModel1sRestClient;

        /// <summary> Initializes a new instance of the <see cref="SupersetModel1Collection"/> class for mocking. </summary>
        protected SupersetModel1Collection()
        {
        }

        /// <summary> Initializes a new instance of SupersetModel1Collection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal SupersetModel1Collection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _supersetModel1sRestClient = new SupersetModel1SRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroup.ResourceType;

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/supersetModel1s/{supersetModel1sName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: SupersetModel1s_Put
        /// <param name="supersetModel1SName"> The String to use. </param>
        /// <param name="parameters"> The SupersetModel1 to use. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="supersetModel1SName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual SupersetModel1PutOperation CreateOrUpdate(string supersetModel1SName, SupersetModel1Data parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (supersetModel1SName == null)
            {
                throw new ArgumentNullException(nameof(supersetModel1SName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("SupersetModel1Collection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _supersetModel1sRestClient.Put(Id.SubscriptionId, Id.ResourceGroupName, supersetModel1SName, parameters, cancellationToken);
                var operation = new SupersetModel1PutOperation(Parent, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/supersetModel1s/{supersetModel1sName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: SupersetModel1s_Put
        /// <param name="supersetModel1SName"> The String to use. </param>
        /// <param name="parameters"> The SupersetModel1 to use. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="supersetModel1SName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<SupersetModel1PutOperation> CreateOrUpdateAsync(string supersetModel1SName, SupersetModel1Data parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (supersetModel1SName == null)
            {
                throw new ArgumentNullException(nameof(supersetModel1SName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("SupersetModel1Collection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _supersetModel1sRestClient.PutAsync(Id.SubscriptionId, Id.ResourceGroupName, supersetModel1SName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new SupersetModel1PutOperation(Parent, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/supersetModel1s/{supersetModel1sName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: SupersetModel1s_Get
        /// <param name="supersetModel1SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="supersetModel1SName"/> is null. </exception>
        public virtual Response<SupersetModel1> Get(string supersetModel1SName, CancellationToken cancellationToken = default)
        {
            if (supersetModel1SName == null)
            {
                throw new ArgumentNullException(nameof(supersetModel1SName));
            }

            using var scope = _clientDiagnostics.CreateScope("SupersetModel1Collection.Get");
            scope.Start();
            try
            {
                var response = _supersetModel1sRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, supersetModel1SName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SupersetModel1(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/supersetModel1s/{supersetModel1sName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: SupersetModel1s_Get
        /// <param name="supersetModel1SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="supersetModel1SName"/> is null. </exception>
        public async virtual Task<Response<SupersetModel1>> GetAsync(string supersetModel1SName, CancellationToken cancellationToken = default)
        {
            if (supersetModel1SName == null)
            {
                throw new ArgumentNullException(nameof(supersetModel1SName));
            }

            using var scope = _clientDiagnostics.CreateScope("SupersetModel1Collection.Get");
            scope.Start();
            try
            {
                var response = await _supersetModel1sRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, supersetModel1SName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SupersetModel1(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="supersetModel1SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="supersetModel1SName"/> is null. </exception>
        public virtual Response<SupersetModel1> GetIfExists(string supersetModel1SName, CancellationToken cancellationToken = default)
        {
            if (supersetModel1SName == null)
            {
                throw new ArgumentNullException(nameof(supersetModel1SName));
            }

            using var scope = _clientDiagnostics.CreateScope("SupersetModel1Collection.GetIfExists");
            scope.Start();
            try
            {
                var response = _supersetModel1sRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, supersetModel1SName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<SupersetModel1>(null, response.GetRawResponse())
                    : Response.FromValue(new SupersetModel1(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="supersetModel1SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="supersetModel1SName"/> is null. </exception>
        public async virtual Task<Response<SupersetModel1>> GetIfExistsAsync(string supersetModel1SName, CancellationToken cancellationToken = default)
        {
            if (supersetModel1SName == null)
            {
                throw new ArgumentNullException(nameof(supersetModel1SName));
            }

            using var scope = _clientDiagnostics.CreateScope("SupersetModel1Collection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _supersetModel1sRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, supersetModel1SName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<SupersetModel1>(null, response.GetRawResponse())
                    : Response.FromValue(new SupersetModel1(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="supersetModel1SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="supersetModel1SName"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string supersetModel1SName, CancellationToken cancellationToken = default)
        {
            if (supersetModel1SName == null)
            {
                throw new ArgumentNullException(nameof(supersetModel1SName));
            }

            using var scope = _clientDiagnostics.CreateScope("SupersetModel1Collection.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(supersetModel1SName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="supersetModel1SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="supersetModel1SName"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string supersetModel1SName, CancellationToken cancellationToken = default)
        {
            if (supersetModel1SName == null)
            {
                throw new ArgumentNullException(nameof(supersetModel1SName));
            }

            using var scope = _clientDiagnostics.CreateScope("SupersetModel1Collection.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(supersetModel1SName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/supersetModel1s
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: SupersetModel1s_List
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<IReadOnlyList<SupersetModel1>> GetAll(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SupersetModel1Collection.GetAll");
            scope.Start();
            try
            {
                var response = _supersetModel1sRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken);
                return Response.FromValue(response.Value.Value.Select(value => new SupersetModel1(Parent, value)).ToArray() as IReadOnlyList<SupersetModel1>, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/supersetModel1s
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: SupersetModel1s_List
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<IReadOnlyList<SupersetModel1>>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SupersetModel1Collection.GetAll");
            scope.Start();
            try
            {
                var response = await _supersetModel1sRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value.Value.Select(value => new SupersetModel1(Parent, value)).ToArray() as IReadOnlyList<SupersetModel1>, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="SupersetModel1" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SupersetModel1Collection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(SupersetModel1.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="SupersetModel1" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SupersetModel1Collection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(SupersetModel1.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SupersetModel1> IEnumerable<SupersetModel1>.GetEnumerator()
        {
            return GetAll().Value.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().Value.GetEnumerator();
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, SupersetModel1, SupersetModel1Data> Construct() { }
    }
}
