// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.Management.Storage.Models;
using Azure.ResourceManager.Core;

namespace Azure.Management.Storage
{
    /// <summary> A class representing collection of PrivateEndpointConnection and their operations over a StorageAccount. </summary>
    public partial class PrivateEndpointConnectionContainer : ResourceContainerBase<ResourceGroupResourceIdentifier, PrivateEndpointConnection, PrivateEndpointConnectionData>
    {
        /// <summary> Initializes a new instance of the <see cref="PrivateEndpointConnectionContainer"/> class for mocking. </summary>
        protected PrivateEndpointConnectionContainer()
        {
        }

        /// <summary> Initializes a new instance of PrivateEndpointConnectionContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal PrivateEndpointConnectionContainer(OperationsBase parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private PrivateEndpointConnectionsRestOperations _restClient => new PrivateEndpointConnectionsRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);

        /// <summary> Typed Resource Identifier for the container. </summary>
        public new ResourceGroupResourceIdentifier Id => base.Id as ResourceGroupResourceIdentifier;

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => StorageAccountOperations.ResourceType;

        // Container level operations.

        /// <summary> The operation to create or update a PrivateEndpointConnection. Please note some properties can be set only during creation. </summary>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection associated with the Storage Account. </param>
        /// <param name="properties"> The private endpoint connection properties. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<PrivateEndpointConnection> CreateOrUpdate(string privateEndpointConnectionName, PrivateEndpointConnectionData properties, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PrivateEndpointConnectionContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                if (privateEndpointConnectionName == null)
                {
                    throw new ArgumentNullException(nameof(privateEndpointConnectionName));
                }
                if (properties == null)
                {
                    throw new ArgumentNullException(nameof(properties));
                }

                return StartCreateOrUpdate(privateEndpointConnectionName, properties, cancellationToken: cancellationToken).WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a PrivateEndpointConnection. Please note some properties can be set only during creation. </summary>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection associated with the Storage Account. </param>
        /// <param name="properties"> The private endpoint connection properties. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<PrivateEndpointConnection>> CreateOrUpdateAsync(string privateEndpointConnectionName, PrivateEndpointConnectionData properties, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PrivateEndpointConnectionContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                if (privateEndpointConnectionName == null)
                {
                    throw new ArgumentNullException(nameof(privateEndpointConnectionName));
                }
                if (properties == null)
                {
                    throw new ArgumentNullException(nameof(properties));
                }

                var operation = await StartCreateOrUpdateAsync(privateEndpointConnectionName, properties, cancellationToken: cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a PrivateEndpointConnection. Please note some properties can be set only during creation. </summary>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection associated with the Storage Account. </param>
        /// <param name="properties"> The private endpoint connection properties. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual PrivateEndpointConnectionsPutOperation StartCreateOrUpdate(string privateEndpointConnectionName, PrivateEndpointConnectionData properties, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PrivateEndpointConnectionContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                if (privateEndpointConnectionName == null)
                {
                    throw new ArgumentNullException(nameof(privateEndpointConnectionName));
                }
                if (properties == null)
                {
                    throw new ArgumentNullException(nameof(properties));
                }

                var originalResponse = _restClient.Put(Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, properties, cancellationToken: cancellationToken);
                return new PrivateEndpointConnectionsPutOperation(Parent, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a PrivateEndpointConnection. Please note some properties can be set only during creation. </summary>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection associated with the Storage Account. </param>
        /// <param name="properties"> The private endpoint connection properties. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<PrivateEndpointConnectionsPutOperation> StartCreateOrUpdateAsync(string privateEndpointConnectionName, PrivateEndpointConnectionData properties, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PrivateEndpointConnectionContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                if (privateEndpointConnectionName == null)
                {
                    throw new ArgumentNullException(nameof(privateEndpointConnectionName));
                }
                if (properties == null)
                {
                    throw new ArgumentNullException(nameof(properties));
                }

                var originalResponse = await _restClient.PutAsync(Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, properties, cancellationToken: cancellationToken).ConfigureAwait(false);
                return new PrivateEndpointConnectionsPutOperation(Parent, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection associated with the Storage Account. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<PrivateEndpointConnection> Get(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PrivateEndpointConnectionContainer.Get");
            scope.Start();
            try
            {
                if (privateEndpointConnectionName == null)
                {
                    throw new ArgumentNullException(nameof(privateEndpointConnectionName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken: cancellationToken);
                return Response.FromValue(new PrivateEndpointConnection(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection associated with the Storage Account. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<PrivateEndpointConnection>> GetAsync(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PrivateEndpointConnectionContainer.Get");
            scope.Start();
            try
            {
                if (privateEndpointConnectionName == null)
                {
                    throw new ArgumentNullException(nameof(privateEndpointConnectionName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new PrivateEndpointConnection(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection associated with the Storage Account. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual PrivateEndpointConnection TryGet(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PrivateEndpointConnectionContainer.TryGet");
            scope.Start();
            try
            {
                if (privateEndpointConnectionName == null)
                {
                    throw new ArgumentNullException(nameof(privateEndpointConnectionName));
                }

                return Get(privateEndpointConnectionName, cancellationToken: cancellationToken).Value;
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
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection associated with the Storage Account. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<PrivateEndpointConnection> TryGetAsync(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PrivateEndpointConnectionContainer.TryGet");
            scope.Start();
            try
            {
                if (privateEndpointConnectionName == null)
                {
                    throw new ArgumentNullException(nameof(privateEndpointConnectionName));
                }

                return await GetAsync(privateEndpointConnectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection associated with the Storage Account. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual bool DoesExist(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PrivateEndpointConnectionContainer.DoesExist");
            scope.Start();
            try
            {
                if (privateEndpointConnectionName == null)
                {
                    throw new ArgumentNullException(nameof(privateEndpointConnectionName));
                }

                return TryGet(privateEndpointConnectionName, cancellationToken: cancellationToken) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection associated with the Storage Account. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<bool> DoesExistAsync(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PrivateEndpointConnectionContainer.DoesExist");
            scope.Start();
            try
            {
                if (privateEndpointConnectionName == null)
                {
                    throw new ArgumentNullException(nameof(privateEndpointConnectionName));
                }

                return await TryGetAsync(privateEndpointConnectionName, cancellationToken: cancellationToken).ConfigureAwait(false) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of PrivateEndpointConnection for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResourceExpanded> ListAsGenericResource(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PrivateEndpointConnectionContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(PrivateEndpointConnectionOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContext(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of PrivateEndpointConnection for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResourceExpanded> ListAsGenericResourceAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PrivateEndpointConnectionContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(PrivateEndpointConnectionOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContextAsync(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<ResourceGroupResourceIdentifier, PrivateEndpointConnection, PrivateEndpointConnectionData> Construct() { }
    }
}
