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
using Azure.Management.Storage.Models;
using Azure.ResourceManager.Core;

namespace Azure.Management.Storage
{
    /// <summary> A class representing collection of BlobContainer and their operations over its parent. </summary>
    public partial class BlobContainerCollection : ArmCollection, IEnumerable<BlobContainer>, IAsyncEnumerable<BlobContainer>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly BlobContainersRestOperations _blobContainersRestClient;

        /// <summary> Initializes a new instance of the <see cref="BlobContainerCollection"/> class for mocking. </summary>
        protected BlobContainerCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="BlobContainerCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal BlobContainerCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _blobContainersRestClient = new BlobContainersRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != BlobService.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, BlobService.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/blobServices/default/containers/{containerName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/blobServices/{BlobServicesName}
        /// OperationId: BlobContainers_Create
        /// <summary> Creates a new container under the specified account as described by request body. The container resource includes metadata and properties for that container. It does not include a list of the blobs contained by the container. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="containerName"> The name of the blob container within the specified storage account. Blob container names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only. Every dash (-) character must be immediately preceded and followed by a letter or number. </param>
        /// <param name="blobContainer"> Properties of the blob container to create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="containerName"/> or <paramref name="blobContainer"/> is null. </exception>
        public virtual BlobContainerCreateOperation CreateOrUpdate(bool waitForCompletion, string containerName, BlobContainerData blobContainer, CancellationToken cancellationToken = default)
        {
            if (containerName == null)
            {
                throw new ArgumentNullException(nameof(containerName));
            }
            if (blobContainer == null)
            {
                throw new ArgumentNullException(nameof(blobContainer));
            }

            using var scope = _clientDiagnostics.CreateScope("BlobContainerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _blobContainersRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, containerName, blobContainer, cancellationToken);
                var operation = new BlobContainerCreateOperation(this, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/blobServices/default/containers/{containerName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/blobServices/{BlobServicesName}
        /// OperationId: BlobContainers_Create
        /// <summary> Creates a new container under the specified account as described by request body. The container resource includes metadata and properties for that container. It does not include a list of the blobs contained by the container. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="containerName"> The name of the blob container within the specified storage account. Blob container names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only. Every dash (-) character must be immediately preceded and followed by a letter or number. </param>
        /// <param name="blobContainer"> Properties of the blob container to create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="containerName"/> or <paramref name="blobContainer"/> is null. </exception>
        public async virtual Task<BlobContainerCreateOperation> CreateOrUpdateAsync(bool waitForCompletion, string containerName, BlobContainerData blobContainer, CancellationToken cancellationToken = default)
        {
            if (containerName == null)
            {
                throw new ArgumentNullException(nameof(containerName));
            }
            if (blobContainer == null)
            {
                throw new ArgumentNullException(nameof(blobContainer));
            }

            using var scope = _clientDiagnostics.CreateScope("BlobContainerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _blobContainersRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, containerName, blobContainer, cancellationToken).ConfigureAwait(false);
                var operation = new BlobContainerCreateOperation(this, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/blobServices/default/containers/{containerName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/blobServices/{BlobServicesName}
        /// OperationId: BlobContainers_Get
        /// <summary> Gets properties of a specified container. </summary>
        /// <param name="containerName"> The name of the blob container within the specified storage account. Blob container names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only. Every dash (-) character must be immediately preceded and followed by a letter or number. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="containerName"/> is null. </exception>
        public virtual Response<BlobContainer> Get(string containerName, CancellationToken cancellationToken = default)
        {
            if (containerName == null)
            {
                throw new ArgumentNullException(nameof(containerName));
            }

            using var scope = _clientDiagnostics.CreateScope("BlobContainerCollection.Get");
            scope.Start();
            try
            {
                var response = _blobContainersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, containerName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BlobContainer(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/blobServices/default/containers/{containerName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/blobServices/{BlobServicesName}
        /// OperationId: BlobContainers_Get
        /// <summary> Gets properties of a specified container. </summary>
        /// <param name="containerName"> The name of the blob container within the specified storage account. Blob container names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only. Every dash (-) character must be immediately preceded and followed by a letter or number. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="containerName"/> is null. </exception>
        public async virtual Task<Response<BlobContainer>> GetAsync(string containerName, CancellationToken cancellationToken = default)
        {
            if (containerName == null)
            {
                throw new ArgumentNullException(nameof(containerName));
            }

            using var scope = _clientDiagnostics.CreateScope("BlobContainerCollection.Get");
            scope.Start();
            try
            {
                var response = await _blobContainersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, containerName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new BlobContainer(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="containerName"> The name of the blob container within the specified storage account. Blob container names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only. Every dash (-) character must be immediately preceded and followed by a letter or number. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="containerName"/> is null. </exception>
        public virtual Response<BlobContainer> GetIfExists(string containerName, CancellationToken cancellationToken = default)
        {
            if (containerName == null)
            {
                throw new ArgumentNullException(nameof(containerName));
            }

            using var scope = _clientDiagnostics.CreateScope("BlobContainerCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _blobContainersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, containerName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<BlobContainer>(null, response.GetRawResponse());
                return Response.FromValue(new BlobContainer(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="containerName"> The name of the blob container within the specified storage account. Blob container names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only. Every dash (-) character must be immediately preceded and followed by a letter or number. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="containerName"/> is null. </exception>
        public async virtual Task<Response<BlobContainer>> GetIfExistsAsync(string containerName, CancellationToken cancellationToken = default)
        {
            if (containerName == null)
            {
                throw new ArgumentNullException(nameof(containerName));
            }

            using var scope = _clientDiagnostics.CreateScope("BlobContainerCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _blobContainersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, containerName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<BlobContainer>(null, response.GetRawResponse());
                return Response.FromValue(new BlobContainer(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="containerName"> The name of the blob container within the specified storage account. Blob container names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only. Every dash (-) character must be immediately preceded and followed by a letter or number. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="containerName"/> is null. </exception>
        public virtual Response<bool> Exists(string containerName, CancellationToken cancellationToken = default)
        {
            if (containerName == null)
            {
                throw new ArgumentNullException(nameof(containerName));
            }

            using var scope = _clientDiagnostics.CreateScope("BlobContainerCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(containerName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="containerName"> The name of the blob container within the specified storage account. Blob container names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only. Every dash (-) character must be immediately preceded and followed by a letter or number. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="containerName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string containerName, CancellationToken cancellationToken = default)
        {
            if (containerName == null)
            {
                throw new ArgumentNullException(nameof(containerName));
            }

            using var scope = _clientDiagnostics.CreateScope("BlobContainerCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(containerName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/blobServices/default/containers
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/blobServices/{BlobServicesName}
        /// OperationId: BlobContainers_List
        /// <summary> Lists all containers and does not support a prefix like data plane. Also SRP today does not return continuation token. </summary>
        /// <param name="maxpagesize"> Optional. Specified maximum number of containers that can be included in the list. </param>
        /// <param name="filter"> Optional. When specified, only container names starting with the filter will be listed. </param>
        /// <param name="include"> Optional, used to include the properties for soft deleted blob containers. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="BlobContainer" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<BlobContainer> GetAll(int? maxpagesize = null, string filter = null, ListContainersInclude? include = null, CancellationToken cancellationToken = default)
        {
            Page<BlobContainer> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("BlobContainerCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _blobContainersRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, pageSizeHint, filter, include, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new BlobContainer(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<BlobContainer> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("BlobContainerCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _blobContainersRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, pageSizeHint, filter, include, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new BlobContainer(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/blobServices/default/containers
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/blobServices/{BlobServicesName}
        /// OperationId: BlobContainers_List
        /// <summary> Lists all containers and does not support a prefix like data plane. Also SRP today does not return continuation token. </summary>
        /// <param name="maxpagesize"> Optional. Specified maximum number of containers that can be included in the list. </param>
        /// <param name="filter"> Optional. When specified, only container names starting with the filter will be listed. </param>
        /// <param name="include"> Optional, used to include the properties for soft deleted blob containers. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="BlobContainer" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<BlobContainer> GetAllAsync(int? maxpagesize = null, string filter = null, ListContainersInclude? include = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<BlobContainer>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("BlobContainerCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _blobContainersRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, pageSizeHint, filter, include, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new BlobContainer(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<BlobContainer>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("BlobContainerCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _blobContainersRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, pageSizeHint, filter, include, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new BlobContainer(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<BlobContainer> IEnumerable<BlobContainer>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<BlobContainer> IAsyncEnumerable<BlobContainer>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, BlobContainer, BlobContainerData> Construct() { }
    }
}
