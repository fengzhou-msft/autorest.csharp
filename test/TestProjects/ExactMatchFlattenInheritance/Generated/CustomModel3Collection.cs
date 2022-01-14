// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;
using ExactMatchFlattenInheritance.Models;

namespace ExactMatchFlattenInheritance
{
    /// <summary> A class representing collection of CustomModel3 and their operations over its parent. </summary>
    public partial class CustomModel3Collection : ArmCollection, IEnumerable<CustomModel3>, IAsyncEnumerable<CustomModel3>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly CustomModel3SRestOperations _customModel3sRestClient;

        /// <summary> Initializes a new instance of the <see cref="CustomModel3Collection"/> class for mocking. </summary>
        protected CustomModel3Collection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CustomModel3Collection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal CustomModel3Collection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _customModel3sRestClient = new CustomModel3SRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/customModel3s/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: CustomModel3s_Put
        /// <summary> Create or update an CustomModel3. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="name"> The String to use. </param>
        /// <param name="parameters"> The CustomModel3 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="parameters"/> is null. </exception>
        public virtual CustomModel3SPutOperation CreateOrUpdate(bool waitForCompletion, string name, CustomModel3Data parameters, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("CustomModel3Collection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _customModel3sRestClient.Put(Id.SubscriptionId, Id.ResourceGroupName, name, parameters, cancellationToken);
                var operation = new CustomModel3SPutOperation(this, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/customModel3s/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: CustomModel3s_Put
        /// <summary> Create or update an CustomModel3. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="name"> The String to use. </param>
        /// <param name="parameters"> The CustomModel3 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<CustomModel3SPutOperation> CreateOrUpdateAsync(bool waitForCompletion, string name, CustomModel3Data parameters, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("CustomModel3Collection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _customModel3sRestClient.PutAsync(Id.SubscriptionId, Id.ResourceGroupName, name, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new CustomModel3SPutOperation(this, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/customModel3s/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: CustomModel3s_Get
        /// <summary> Get an CustomModel3. </summary>
        /// <param name="name"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<CustomModel3> Get(string name, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            using var scope = _clientDiagnostics.CreateScope("CustomModel3Collection.Get");
            scope.Start();
            try
            {
                var response = _customModel3sRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CustomModel3(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/customModel3s/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: CustomModel3s_Get
        /// <summary> Get an CustomModel3. </summary>
        /// <param name="name"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public async virtual Task<Response<CustomModel3>> GetAsync(string name, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            using var scope = _clientDiagnostics.CreateScope("CustomModel3Collection.Get");
            scope.Start();
            try
            {
                var response = await _customModel3sRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new CustomModel3(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="name"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<CustomModel3> GetIfExists(string name, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            using var scope = _clientDiagnostics.CreateScope("CustomModel3Collection.GetIfExists");
            scope.Start();
            try
            {
                var response = _customModel3sRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<CustomModel3>(null, response.GetRawResponse());
                return Response.FromValue(new CustomModel3(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="name"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public async virtual Task<Response<CustomModel3>> GetIfExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            using var scope = _clientDiagnostics.CreateScope("CustomModel3Collection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _customModel3sRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<CustomModel3>(null, response.GetRawResponse());
                return Response.FromValue(new CustomModel3(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="name"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            using var scope = _clientDiagnostics.CreateScope("CustomModel3Collection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(name, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="name"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            using var scope = _clientDiagnostics.CreateScope("CustomModel3Collection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(name, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/customModel3s
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: CustomModel3s_List
        /// <summary> Get an CustomModel3s. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CustomModel3" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CustomModel3> GetAll(CancellationToken cancellationToken = default)
        {
            Page<CustomModel3> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CustomModel3Collection.GetAll");
                scope.Start();
                try
                {
                    var response = _customModel3sRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new CustomModel3(this, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/customModel3s
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: CustomModel3s_List
        /// <summary> Get an CustomModel3s. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CustomModel3" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CustomModel3> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<CustomModel3>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("CustomModel3Collection.GetAll");
                scope.Start();
                try
                {
                    var response = await _customModel3sRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new CustomModel3(this, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary> Filters the list of <see cref="CustomModel3" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CustomModel3Collection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(CustomModel3.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="CustomModel3" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CustomModel3Collection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(CustomModel3.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<CustomModel3> IEnumerable<CustomModel3>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CustomModel3> IAsyncEnumerable<CustomModel3>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, CustomModel3, CustomModel3Data> Construct() { }
    }
}
