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
using Azure.Core.Pipeline;
using Azure.Management.Storage.Models;
using Azure.ResourceManager.Core;

namespace Azure.Management.Storage
{
    /// <summary> A class representing collection of FileService and their operations over a StorageAccount. </summary>
    public partial class FileServiceContainer : ResourceContainerBase<ResourceGroupResourceIdentifier, FileService, FileServiceData>
    {
        /// <summary> Initializes a new instance of the <see cref="FileServiceContainer"/> class for mocking. </summary>
        protected FileServiceContainer()
        {
        }

        /// <summary> Initializes a new instance of FileServiceContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal FileServiceContainer(OperationsBase parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        /// <summary> Get the parent resource of this container. </summary>
        protected new ResourceOperationsBase Parent { get { return base.Parent as ResourceOperationsBase; } }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private FileServicesRestOperations _restClient => new FileServicesRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);

        /// <summary> Typed Resource Identifier for the container. </summary>
        public new ResourceGroupResourceIdentifier Id => base.Id as ResourceGroupResourceIdentifier;

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => StorageAccountOperations.ResourceType;

        // Container level operations.

        /// <summary> Sets the properties of file services in storage accounts, including CORS (Cross-Origin Resource Sharing) rules. </summary>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="parameters"> The properties of file services in storage accounts, including CORS (Cross-Origin Resource Sharing) rules. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual Response<FileService> CreateOrUpdate(string accountName, FileServiceData parameters, CancellationToken cancellationToken = default)
        {
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("FileServiceContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = StartCreateOrUpdate(accountName, parameters, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Sets the properties of file services in storage accounts, including CORS (Cross-Origin Resource Sharing) rules. </summary>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="parameters"> The properties of file services in storage accounts, including CORS (Cross-Origin Resource Sharing) rules. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<Response<FileService>> CreateOrUpdateAsync(string accountName, FileServiceData parameters, CancellationToken cancellationToken = default)
        {
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("FileServiceContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = await StartCreateOrUpdateAsync(accountName, parameters, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Sets the properties of file services in storage accounts, including CORS (Cross-Origin Resource Sharing) rules. </summary>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="parameters"> The properties of file services in storage accounts, including CORS (Cross-Origin Resource Sharing) rules. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual FileServicesSetServicePropertiesOperation StartCreateOrUpdate(string accountName, FileServiceData parameters, CancellationToken cancellationToken = default)
        {
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("FileServiceContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.SetServiceProperties(Id.ResourceGroupName, accountName, parameters, cancellationToken);
                return new FileServicesSetServicePropertiesOperation(Parent, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Sets the properties of file services in storage accounts, including CORS (Cross-Origin Resource Sharing) rules. </summary>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="parameters"> The properties of file services in storage accounts, including CORS (Cross-Origin Resource Sharing) rules. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<FileServicesSetServicePropertiesOperation> StartCreateOrUpdateAsync(string accountName, FileServiceData parameters, CancellationToken cancellationToken = default)
        {
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("FileServiceContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.SetServicePropertiesAsync(Id.ResourceGroupName, accountName, parameters, cancellationToken).ConfigureAwait(false);
                return new FileServicesSetServicePropertiesOperation(Parent, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<FileService> Get(string accountName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FileServiceContainer.Get");
            scope.Start();
            try
            {
                if (accountName == null)
                {
                    throw new ArgumentNullException(nameof(accountName));
                }

                var response = _restClient.GetServiceProperties(Id.ResourceGroupName, accountName, cancellationToken: cancellationToken);
                return Response.FromValue(new FileService(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<FileService>> GetAsync(string accountName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FileServiceContainer.Get");
            scope.Start();
            try
            {
                if (accountName == null)
                {
                    throw new ArgumentNullException(nameof(accountName));
                }

                var response = await _restClient.GetServicePropertiesAsync(Id.ResourceGroupName, accountName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new FileService(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual FileService TryGet(string accountName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FileServiceContainer.TryGet");
            scope.Start();
            try
            {
                if (accountName == null)
                {
                    throw new ArgumentNullException(nameof(accountName));
                }

                return Get(accountName, cancellationToken: cancellationToken).Value;
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
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<FileService> TryGetAsync(string accountName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FileServiceContainer.TryGet");
            scope.Start();
            try
            {
                if (accountName == null)
                {
                    throw new ArgumentNullException(nameof(accountName));
                }

                return await GetAsync(accountName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual bool DoesExist(string accountName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FileServiceContainer.DoesExist");
            scope.Start();
            try
            {
                if (accountName == null)
                {
                    throw new ArgumentNullException(nameof(accountName));
                }

                return TryGet(accountName, cancellationToken: cancellationToken) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<bool> DoesExistAsync(string accountName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FileServiceContainer.DoesExist");
            scope.Start();
            try
            {
                if (accountName == null)
                {
                    throw new ArgumentNullException(nameof(accountName));
                }

                return await TryGetAsync(accountName, cancellationToken: cancellationToken).ConfigureAwait(false) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of FileService for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResourceExpanded> ListAsGenericResource(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FileServiceContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(FileServiceOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContext(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of FileService for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResourceExpanded> ListAsGenericResourceAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FileServiceContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(FileServiceOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContextAsync(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> List all file services in storage accounts. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<IReadOnlyList<FileService>>> ListAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FileServiceContainer.List");
            scope.Start();
            try
            {
                var response = await _restClient.ListAsync(Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value.Value.Select(data => new FileService(Parent, data)).ToArray() as IReadOnlyList<FileService>, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> List all file services in storage accounts. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<IReadOnlyList<FileService>> List(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FileServiceContainer.List");
            scope.Start();
            try
            {
                var response = _restClient.List(Id.ResourceGroupName, Id.Name, cancellationToken);
                return Response.FromValue(response.Value.Value.Select(data => new FileService(Parent, data)).ToArray() as IReadOnlyList<FileService>, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<ResourceGroupResourceIdentifier, FileService, FileServiceData> Construct() { }
    }
}
