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
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;

namespace MgmtParamOrdering
{
    /// <summary> A class representing collection of VirtualMachineExtensionImage and their operations over its parent. </summary>
    public partial class VirtualMachineExtensionImageContainer : ArmContainer
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly VirtualMachineExtensionImagesRestOperations _virtualMachineExtensionImagesRestClient;

        /// <summary> Initializes a new instance of the <see cref="VirtualMachineExtensionImageContainer"/> class for mocking. </summary>
        protected VirtualMachineExtensionImageContainer()
        {
        }

        /// <summary> Initializes a new instance of VirtualMachineExtensionImageContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal VirtualMachineExtensionImageContainer(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _virtualMachineExtensionImagesRestClient = new VirtualMachineExtensionImagesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => Subscription.ResourceType;

        // Container level operations.

        /// <summary> Gets a virtual machine extension image. </summary>
        /// <param name="location"> The name of a supported Azure region. </param>
        /// <param name="publisherName"> The String to use. </param>
        /// <param name="type"> The String to use. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/>, <paramref name="publisherName"/>, <paramref name="type"/>, or <paramref name="version"/> is null. </exception>
        public virtual Response<VirtualMachineExtensionImage> Get(string location, string publisherName, string type, string version, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (publisherName == null)
            {
                throw new ArgumentNullException(nameof(publisherName));
            }
            if (type == null)
            {
                throw new ArgumentNullException(nameof(type));
            }
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineExtensionImageContainer.Get");
            scope.Start();
            try
            {
                var response = _virtualMachineExtensionImagesRestClient.Get(location, publisherName, type, version, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualMachineExtensionImage(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a virtual machine extension image. </summary>
        /// <param name="location"> The name of a supported Azure region. </param>
        /// <param name="publisherName"> The String to use. </param>
        /// <param name="type"> The String to use. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/>, <paramref name="publisherName"/>, <paramref name="type"/>, or <paramref name="version"/> is null. </exception>
        public async virtual Task<Response<VirtualMachineExtensionImage>> GetAsync(string location, string publisherName, string type, string version, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (publisherName == null)
            {
                throw new ArgumentNullException(nameof(publisherName));
            }
            if (type == null)
            {
                throw new ArgumentNullException(nameof(type));
            }
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineExtensionImageContainer.Get");
            scope.Start();
            try
            {
                var response = await _virtualMachineExtensionImagesRestClient.GetAsync(location, publisherName, type, version, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new VirtualMachineExtensionImage(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="location"> The name of a supported Azure region. </param>
        /// <param name="publisherName"> The String to use. </param>
        /// <param name="type"> The String to use. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/>, <paramref name="publisherName"/>, <paramref name="type"/>, or <paramref name="version"/> is null. </exception>
        public virtual Response<VirtualMachineExtensionImage> GetIfExists(string location, string publisherName, string type, string version, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (publisherName == null)
            {
                throw new ArgumentNullException(nameof(publisherName));
            }
            if (type == null)
            {
                throw new ArgumentNullException(nameof(type));
            }
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineExtensionImageContainer.GetIfExists");
            scope.Start();
            try
            {
                var response = _virtualMachineExtensionImagesRestClient.Get(location, publisherName, type, version, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<VirtualMachineExtensionImage>(null, response.GetRawResponse())
                    : Response.FromValue(new VirtualMachineExtensionImage(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="location"> The name of a supported Azure region. </param>
        /// <param name="publisherName"> The String to use. </param>
        /// <param name="type"> The String to use. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/>, <paramref name="publisherName"/>, <paramref name="type"/>, or <paramref name="version"/> is null. </exception>
        public async virtual Task<Response<VirtualMachineExtensionImage>> GetIfExistsAsync(string location, string publisherName, string type, string version, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (publisherName == null)
            {
                throw new ArgumentNullException(nameof(publisherName));
            }
            if (type == null)
            {
                throw new ArgumentNullException(nameof(type));
            }
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineExtensionImageContainer.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _virtualMachineExtensionImagesRestClient.GetAsync(location, publisherName, type, version, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<VirtualMachineExtensionImage>(null, response.GetRawResponse())
                    : Response.FromValue(new VirtualMachineExtensionImage(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="location"> The name of a supported Azure region. </param>
        /// <param name="publisherName"> The String to use. </param>
        /// <param name="type"> The String to use. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/>, <paramref name="publisherName"/>, <paramref name="type"/>, or <paramref name="version"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string location, string publisherName, string type, string version, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (publisherName == null)
            {
                throw new ArgumentNullException(nameof(publisherName));
            }
            if (type == null)
            {
                throw new ArgumentNullException(nameof(type));
            }
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineExtensionImageContainer.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(location, publisherName, type, version, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="location"> The name of a supported Azure region. </param>
        /// <param name="publisherName"> The String to use. </param>
        /// <param name="type"> The String to use. </param>
        /// <param name="version"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/>, <paramref name="publisherName"/>, <paramref name="type"/>, or <paramref name="version"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string location, string publisherName, string type, string version, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (publisherName == null)
            {
                throw new ArgumentNullException(nameof(publisherName));
            }
            if (type == null)
            {
                throw new ArgumentNullException(nameof(type));
            }
            if (version == null)
            {
                throw new ArgumentNullException(nameof(version));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineExtensionImageContainer.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(location, publisherName, type, version, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a list of virtual machine extension image types. </summary>
        /// <param name="location"> The name of a supported Azure region. </param>
        /// <param name="publisherName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="publisherName"/> is null. </exception>
        public virtual Response<IReadOnlyList<VirtualMachineExtensionImage>> GetAll(string location, string publisherName, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (publisherName == null)
            {
                throw new ArgumentNullException(nameof(publisherName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineExtensionImageContainer.GetAll");
            scope.Start();
            try
            {
                var response = _virtualMachineExtensionImagesRestClient.GetTypes(location, publisherName, cancellationToken);
                return Response.FromValue(response.Value.Select(value => new VirtualMachineExtensionImage(Parent, value)).ToArray() as IReadOnlyList<VirtualMachineExtensionImage>, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a list of virtual machine extension image types. </summary>
        /// <param name="location"> The name of a supported Azure region. </param>
        /// <param name="publisherName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="publisherName"/> is null. </exception>
        public async virtual Task<Response<IReadOnlyList<VirtualMachineExtensionImage>>> GetAllAsync(string location, string publisherName, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (publisherName == null)
            {
                throw new ArgumentNullException(nameof(publisherName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineExtensionImageContainer.GetAll");
            scope.Start();
            try
            {
                var response = await _virtualMachineExtensionImagesRestClient.GetTypesAsync(location, publisherName, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value.Select(value => new VirtualMachineExtensionImage(Parent, value)).ToArray() as IReadOnlyList<VirtualMachineExtensionImage>, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a list of virtual machine extension image versions. </summary>
        /// <param name="location"> The name of a supported Azure region. </param>
        /// <param name="publisherName"> The String to use. </param>
        /// <param name="type"> The String to use. </param>
        /// <param name="filter"> The filter to apply on the operation. </param>
        /// <param name="top"> The Integer to use. </param>
        /// <param name="orderby"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/>, <paramref name="publisherName"/>, or <paramref name="type"/> is null. </exception>
        public virtual Response<IReadOnlyList<VirtualMachineExtensionImage>> GetAll(string location, string publisherName, string type, string filter = null, int? top = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (publisherName == null)
            {
                throw new ArgumentNullException(nameof(publisherName));
            }
            if (type == null)
            {
                throw new ArgumentNullException(nameof(type));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineExtensionImageContainer.GetAll");
            scope.Start();
            try
            {
                var response = _virtualMachineExtensionImagesRestClient.GetVersions(location, publisherName, type, filter, top, orderby, cancellationToken);
                return Response.FromValue(response.Value.Select(value => new VirtualMachineExtensionImage(Parent, value)).ToArray() as IReadOnlyList<VirtualMachineExtensionImage>, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a list of virtual machine extension image versions. </summary>
        /// <param name="location"> The name of a supported Azure region. </param>
        /// <param name="publisherName"> The String to use. </param>
        /// <param name="type"> The String to use. </param>
        /// <param name="filter"> The filter to apply on the operation. </param>
        /// <param name="top"> The Integer to use. </param>
        /// <param name="orderby"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/>, <paramref name="publisherName"/>, or <paramref name="type"/> is null. </exception>
        public async virtual Task<Response<IReadOnlyList<VirtualMachineExtensionImage>>> GetAllAsync(string location, string publisherName, string type, string filter = null, int? top = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
            if (publisherName == null)
            {
                throw new ArgumentNullException(nameof(publisherName));
            }
            if (type == null)
            {
                throw new ArgumentNullException(nameof(type));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualMachineExtensionImageContainer.GetAll");
            scope.Start();
            try
            {
                var response = await _virtualMachineExtensionImagesRestClient.GetVersionsAsync(location, publisherName, type, filter, top, orderby, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value.Select(value => new VirtualMachineExtensionImage(Parent, value)).ToArray() as IReadOnlyList<VirtualMachineExtensionImage>, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="VirtualMachineExtensionImage" /> for this subscription represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualMachineExtensionImageContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(VirtualMachineExtensionImage.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as Subscription, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="VirtualMachineExtensionImage" /> for this subscription represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualMachineExtensionImageContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(VirtualMachineExtensionImage.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as Subscription, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, VirtualMachineExtensionImage, VirtualMachineExtensionImageData> Construct() { }
    }
}
