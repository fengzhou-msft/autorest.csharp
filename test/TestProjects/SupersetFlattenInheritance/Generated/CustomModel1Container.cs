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
    /// <summary> A class representing collection of CustomModel1 and their operations over a ResourceGroup. </summary>
    public partial class CustomModel1Container : ArmContainer
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly CustomModel1SRestOperations _restClient;

        /// <summary> Initializes a new instance of the <see cref="CustomModel1Container"/> class for mocking. </summary>
        protected CustomModel1Container()
        {
        }

        /// <summary> Initializes a new instance of CustomModel1Container class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal CustomModel1Container(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new CustomModel1SRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroup.ResourceType;

        // Container level operations.

        /// <param name="customModel1SName"> The String to use. </param>
        /// <param name="parameters"> The CustomModel1 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="customModel1SName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual Response<CustomModel1> CreateOrUpdate(string customModel1SName, CustomModel1Data parameters, CancellationToken cancellationToken = default)
        {
            if (customModel1SName == null)
            {
                throw new ArgumentNullException(nameof(customModel1SName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("CustomModel1Container.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = StartCreateOrUpdate(customModel1SName, parameters, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="customModel1SName"> The String to use. </param>
        /// <param name="parameters"> The CustomModel1 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="customModel1SName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<Response<CustomModel1>> CreateOrUpdateAsync(string customModel1SName, CustomModel1Data parameters, CancellationToken cancellationToken = default)
        {
            if (customModel1SName == null)
            {
                throw new ArgumentNullException(nameof(customModel1SName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("CustomModel1Container.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = await StartCreateOrUpdateAsync(customModel1SName, parameters, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="customModel1SName"> The String to use. </param>
        /// <param name="parameters"> The CustomModel1 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="customModel1SName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual CustomModel1PutOperation StartCreateOrUpdate(string customModel1SName, CustomModel1Data parameters, CancellationToken cancellationToken = default)
        {
            if (customModel1SName == null)
            {
                throw new ArgumentNullException(nameof(customModel1SName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("CustomModel1Container.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.Put(Id.ResourceGroupName, customModel1SName, parameters, cancellationToken);
                return new CustomModel1PutOperation(Parent, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="customModel1SName"> The String to use. </param>
        /// <param name="parameters"> The CustomModel1 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="customModel1SName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<CustomModel1PutOperation> StartCreateOrUpdateAsync(string customModel1SName, CustomModel1Data parameters, CancellationToken cancellationToken = default)
        {
            if (customModel1SName == null)
            {
                throw new ArgumentNullException(nameof(customModel1SName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("CustomModel1Container.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.PutAsync(Id.ResourceGroupName, customModel1SName, parameters, cancellationToken).ConfigureAwait(false);
                return new CustomModel1PutOperation(Parent, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="customModel1SName"> The String to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<CustomModel1> Get(string customModel1SName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CustomModel1Container.Get");
            scope.Start();
            try
            {
                if (customModel1SName == null)
                {
                    throw new ArgumentNullException(nameof(customModel1SName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, customModel1SName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CustomModel1(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="customModel1SName"> The String to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<CustomModel1>> GetAsync(string customModel1SName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CustomModel1Container.Get");
            scope.Start();
            try
            {
                if (customModel1SName == null)
                {
                    throw new ArgumentNullException(nameof(customModel1SName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, customModel1SName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new CustomModel1(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="customModel1SName"> The String to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<CustomModel1> GetIfExists(string customModel1SName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CustomModel1Container.GetIfExists");
            scope.Start();
            try
            {
                if (customModel1SName == null)
                {
                    throw new ArgumentNullException(nameof(customModel1SName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, customModel1SName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<CustomModel1>(null, response.GetRawResponse())
                    : Response.FromValue(new CustomModel1(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="customModel1SName"> The String to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<CustomModel1>> GetIfExistsAsync(string customModel1SName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CustomModel1Container.GetIfExists");
            scope.Start();
            try
            {
                if (customModel1SName == null)
                {
                    throw new ArgumentNullException(nameof(customModel1SName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, customModel1SName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<CustomModel1>(null, response.GetRawResponse())
                    : Response.FromValue(new CustomModel1(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="customModel1SName"> The String to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<bool> CheckIfExists(string customModel1SName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CustomModel1Container.CheckIfExists");
            scope.Start();
            try
            {
                if (customModel1SName == null)
                {
                    throw new ArgumentNullException(nameof(customModel1SName));
                }

                var response = GetIfExists(customModel1SName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="customModel1SName"> The String to use. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string customModel1SName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CustomModel1Container.CheckIfExists");
            scope.Start();
            try
            {
                if (customModel1SName == null)
                {
                    throw new ArgumentNullException(nameof(customModel1SName));
                }

                var response = await GetIfExistsAsync(customModel1SName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="CustomModel1" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CustomModel1Container.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(CustomModel1.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="CustomModel1" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("CustomModel1Container.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(CustomModel1.ResourceType);
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
        // public ArmBuilder<ResourceIdentifier, CustomModel1, CustomModel1Data> Construct() { }
    }
}
