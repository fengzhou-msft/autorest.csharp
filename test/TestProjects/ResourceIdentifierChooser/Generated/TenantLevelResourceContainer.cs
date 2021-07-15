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
using Azure.ResourceManager.Core;

namespace ResourceIdentifierChooser
{
    /// <summary> A class representing collection of TenantLevelResource and their operations over a Tenant. </summary>
    public partial class TenantLevelResourceContainer : ResourceContainerBase<TenantResourceIdentifier, TenantLevelResource, TenantLevelResourceData>
    {
        /// <summary> Initializes a new instance of the <see cref="TenantLevelResourceContainer"/> class for mocking. </summary>
        protected TenantLevelResourceContainer()
        {
        }

        /// <summary> Initializes a new instance of TenantLevelResourceContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal TenantLevelResourceContainer(OperationsBase parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private TenantLevelResourcesRestOperations _restClient => new TenantLevelResourcesRestOperations(_clientDiagnostics, Pipeline, BaseUri);

        /// <summary> Typed Resource Identifier for the container. </summary>
        public new TenantResourceIdentifier Id => base.Id as TenantResourceIdentifier;

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceIdentifier.RootResourceIdentifier.ResourceType;

        // Container level operations.

        /// <summary> The operation to create or update a TenantLevelResource. Please note some properties can be set only during creation. </summary>
        /// <param name="tenantLevelResourcesName"> The String to use. </param>
        /// <param name="parameters"> The TenantLevelResource to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<TenantLevelResource> CreateOrUpdate(string tenantLevelResourcesName, TenantLevelResourceData parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TenantLevelResourceContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                if (tenantLevelResourcesName == null)
                {
                    throw new ArgumentNullException(nameof(tenantLevelResourcesName));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                return StartCreateOrUpdate(tenantLevelResourcesName, parameters, cancellationToken: cancellationToken).WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a TenantLevelResource. Please note some properties can be set only during creation. </summary>
        /// <param name="tenantLevelResourcesName"> The String to use. </param>
        /// <param name="parameters"> The TenantLevelResource to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<TenantLevelResource>> CreateOrUpdateAsync(string tenantLevelResourcesName, TenantLevelResourceData parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TenantLevelResourceContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                if (tenantLevelResourcesName == null)
                {
                    throw new ArgumentNullException(nameof(tenantLevelResourcesName));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                var operation = await StartCreateOrUpdateAsync(tenantLevelResourcesName, parameters, cancellationToken: cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a TenantLevelResource. Please note some properties can be set only during creation. </summary>
        /// <param name="tenantLevelResourcesName"> The String to use. </param>
        /// <param name="parameters"> The TenantLevelResource to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual TenantLevelResourcesPutOperation StartCreateOrUpdate(string tenantLevelResourcesName, TenantLevelResourceData parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TenantLevelResourceContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                if (tenantLevelResourcesName == null)
                {
                    throw new ArgumentNullException(nameof(tenantLevelResourcesName));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                var originalResponse = _restClient.Put(tenantLevelResourcesName, parameters, cancellationToken: cancellationToken);
                return new TenantLevelResourcesPutOperation(Parent, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a TenantLevelResource. Please note some properties can be set only during creation. </summary>
        /// <param name="tenantLevelResourcesName"> The String to use. </param>
        /// <param name="parameters"> The TenantLevelResource to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<TenantLevelResourcesPutOperation> StartCreateOrUpdateAsync(string tenantLevelResourcesName, TenantLevelResourceData parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TenantLevelResourceContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                if (tenantLevelResourcesName == null)
                {
                    throw new ArgumentNullException(nameof(tenantLevelResourcesName));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                var originalResponse = await _restClient.PutAsync(tenantLevelResourcesName, parameters, cancellationToken: cancellationToken).ConfigureAwait(false);
                return new TenantLevelResourcesPutOperation(Parent, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="tenantLevelResourcesName"> The String to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<TenantLevelResource> Get(string tenantLevelResourcesName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TenantLevelResourceContainer.Get");
            scope.Start();
            try
            {
                if (tenantLevelResourcesName == null)
                {
                    throw new ArgumentNullException(nameof(tenantLevelResourcesName));
                }

                var response = _restClient.Get(tenantLevelResourcesName, cancellationToken: cancellationToken);
                return Response.FromValue(new TenantLevelResource(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="tenantLevelResourcesName"> The String to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<TenantLevelResource>> GetAsync(string tenantLevelResourcesName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TenantLevelResourceContainer.Get");
            scope.Start();
            try
            {
                if (tenantLevelResourcesName == null)
                {
                    throw new ArgumentNullException(nameof(tenantLevelResourcesName));
                }

                var response = await _restClient.GetAsync(tenantLevelResourcesName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new TenantLevelResource(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="tenantLevelResourcesName"> The String to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual TenantLevelResource TryGet(string tenantLevelResourcesName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TenantLevelResourceContainer.TryGet");
            scope.Start();
            try
            {
                if (tenantLevelResourcesName == null)
                {
                    throw new ArgumentNullException(nameof(tenantLevelResourcesName));
                }

                return Get(tenantLevelResourcesName, cancellationToken: cancellationToken).Value;
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
        /// <param name="tenantLevelResourcesName"> The String to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<TenantLevelResource> TryGetAsync(string tenantLevelResourcesName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TenantLevelResourceContainer.TryGet");
            scope.Start();
            try
            {
                if (tenantLevelResourcesName == null)
                {
                    throw new ArgumentNullException(nameof(tenantLevelResourcesName));
                }

                return await GetAsync(tenantLevelResourcesName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <param name="tenantLevelResourcesName"> The String to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual bool DoesExist(string tenantLevelResourcesName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TenantLevelResourceContainer.DoesExist");
            scope.Start();
            try
            {
                if (tenantLevelResourcesName == null)
                {
                    throw new ArgumentNullException(nameof(tenantLevelResourcesName));
                }

                return TryGet(tenantLevelResourcesName, cancellationToken: cancellationToken) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="tenantLevelResourcesName"> The String to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<bool> DoesExistAsync(string tenantLevelResourcesName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TenantLevelResourceContainer.DoesExist");
            scope.Start();
            try
            {
                if (tenantLevelResourcesName == null)
                {
                    throw new ArgumentNullException(nameof(tenantLevelResourcesName));
                }

                return await TryGetAsync(tenantLevelResourcesName, cancellationToken: cancellationToken).ConfigureAwait(false) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of TenantLevelResource for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResourceExpanded> ListAsGenericResource(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TenantLevelResourceContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(TenantLevelResourceOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContext(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of TenantLevelResource for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResourceExpanded> ListAsGenericResourceAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TenantLevelResourceContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(TenantLevelResourceOperations.ResourceType);
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
        // public ArmBuilder<TenantResourceIdentifier, TenantLevelResource, TenantLevelResourceData> Construct() { }
    }
}
