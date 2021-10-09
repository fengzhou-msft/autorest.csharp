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
using Azure.Management.Storage.Models;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace Azure.Management.Storage
{
    /// <summary> A class representing collection of BlobService and their operations over its parent. </summary>
    public partial class BlobServiceContainer : ArmContainer
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly BlobServicesRestOperations _blobServicesRestClient;

        /// <summary> Initializes a new instance of the <see cref="BlobServiceContainer"/> class for mocking. </summary>
        protected BlobServiceContainer()
        {
        }

        /// <summary> Initializes a new instance of BlobServiceContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal BlobServiceContainer(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _blobServicesRestClient = new BlobServicesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => "Microsoft.Storage/storageAccounts";

        // Container level operations.

        /// <summary> Sets the properties of a storage account’s Blob service, including properties for Storage Analytics and CORS (Cross-Origin Resource Sharing) rules. </summary>
        /// <param name="blobServicesName"> The name of the blob Service within the specified storage account. Blob Service Name must be &apos;default&apos;. </param>
        /// <param name="parameters"> The properties of a storage account’s Blob service, including properties for Storage Analytics and CORS (Cross-Origin Resource Sharing) rules. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual BlobServiceSetServicePropertiesOperation CreateOrUpdate(Enum2 blobServicesName, BlobServiceData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("BlobServiceContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _blobServicesRestClient.SetServiceProperties(Id.ResourceGroupName, Id.Name, blobServicesName, parameters, cancellationToken);
                var operation = new BlobServiceSetServicePropertiesOperation(Parent, response);
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

        /// <summary> Sets the properties of a storage account’s Blob service, including properties for Storage Analytics and CORS (Cross-Origin Resource Sharing) rules. </summary>
        /// <param name="blobServicesName"> The name of the blob Service within the specified storage account. Blob Service Name must be &apos;default&apos;. </param>
        /// <param name="parameters"> The properties of a storage account’s Blob service, including properties for Storage Analytics and CORS (Cross-Origin Resource Sharing) rules. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public async virtual Task<BlobServiceSetServicePropertiesOperation> CreateOrUpdateAsync(Enum2 blobServicesName, BlobServiceData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("BlobServiceContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _blobServicesRestClient.SetServicePropertiesAsync(Id.ResourceGroupName, Id.Name, blobServicesName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new BlobServiceSetServicePropertiesOperation(Parent, response);
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

        /// <summary> Gets the properties of a storage account’s Blob service, including properties for Storage Analytics and CORS (Cross-Origin Resource Sharing) rules. </summary>
        /// <param name="blobServicesName"> The name of the blob Service within the specified storage account. Blob Service Name must be &apos;default&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<BlobService> Get(Enum2 blobServicesName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BlobServiceContainer.Get");
            scope.Start();
            try
            {
                var response = _blobServicesRestClient.GetServiceProperties(Id.ResourceGroupName, Id.Name, blobServicesName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BlobService(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the properties of a storage account’s Blob service, including properties for Storage Analytics and CORS (Cross-Origin Resource Sharing) rules. </summary>
        /// <param name="blobServicesName"> The name of the blob Service within the specified storage account. Blob Service Name must be &apos;default&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<BlobService>> GetAsync(Enum2 blobServicesName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BlobServiceContainer.Get");
            scope.Start();
            try
            {
                var response = await _blobServicesRestClient.GetServicePropertiesAsync(Id.ResourceGroupName, Id.Name, blobServicesName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new BlobService(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="blobServicesName"> The name of the blob Service within the specified storage account. Blob Service Name must be &apos;default&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<BlobService> GetIfExists(Enum2 blobServicesName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BlobServiceContainer.GetIfExists");
            scope.Start();
            try
            {
                var response = _blobServicesRestClient.GetServiceProperties(Id.ResourceGroupName, Id.Name, blobServicesName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<BlobService>(null, response.GetRawResponse())
                    : Response.FromValue(new BlobService(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="blobServicesName"> The name of the blob Service within the specified storage account. Blob Service Name must be &apos;default&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<BlobService>> GetIfExistsAsync(Enum2 blobServicesName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BlobServiceContainer.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _blobServicesRestClient.GetServicePropertiesAsync(Id.ResourceGroupName, Id.Name, blobServicesName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<BlobService>(null, response.GetRawResponse())
                    : Response.FromValue(new BlobService(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="blobServicesName"> The name of the blob Service within the specified storage account. Blob Service Name must be &apos;default&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> CheckIfExists(Enum2 blobServicesName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BlobServiceContainer.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(blobServicesName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="blobServicesName"> The name of the blob Service within the specified storage account. Blob Service Name must be &apos;default&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(Enum2 blobServicesName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BlobServiceContainer.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(blobServicesName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> List blob services of storage account. It returns a collection of one object named default. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="BlobService" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<BlobService> GetAll(CancellationToken cancellationToken = default)
        {
            Page<BlobService> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("BlobServiceContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _blobServicesRestClient.GetAll(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new BlobService(Parent, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary> List blob services of storage account. It returns a collection of one object named default. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="BlobService" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<BlobService> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<BlobService>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("BlobServiceContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _blobServicesRestClient.GetAllAsync(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new BlobService(Parent, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, BlobService, BlobServiceData> Construct() { }
    }
}
