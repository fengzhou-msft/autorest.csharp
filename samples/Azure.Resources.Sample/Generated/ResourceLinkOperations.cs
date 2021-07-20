// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;

namespace Azure.Resources.Sample
{
    /// <summary> A class representing the operations that can be performed over a specific ResourceLink. </summary>
    public partial class ResourceLinkOperations : ResourceOperationsBase<TenantResourceIdentifier, ResourceLink>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private ResourceLinksRestOperations _restClient { get; }

        /// <summary> Initializes a new instance of the <see cref="ResourceLinkOperations"/> class for mocking. </summary>
        protected ResourceLinkOperations()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceLinkOperations"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        protected internal ResourceLinkOperations(OperationsBase options, TenantResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new ResourceLinksRestOperations(_clientDiagnostics, Pipeline, BaseUri);
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Resources/links";
        /// <summary> Gets the valid resource type for the operations. </summary>
        protected override ResourceType ValidResourceType => ResourceType;

        /// <inheritdoc />
        public async override Task<Response<ResourceLink>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ResourceLinkOperations.Get");
            scope.Start();
            try
            {
                var response = await _restClient.GetAsync(Id, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new ResourceLink(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        public override Response<ResourceLink> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ResourceLinkOperations.Get");
            scope.Start();
            try
            {
                var response = _restClient.Get(Id, cancellationToken);
                return Response.FromValue(new ResourceLink(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public async Task<IEnumerable<Location>> ListAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public IEnumerable<Location> ListAvailableLocations(CancellationToken cancellationToken = default)
        {
            return ListAvailableLocations(ResourceType, cancellationToken);
        }

        /// <summary> Deletes a resource link with the specified ID. </summary>
        /// <param name="linkId"> The fully qualified ID of the resource link. Use the format, /subscriptions/{subscription-id}/resourceGroups/{resource-group-name}/{provider-namespace}/{resource-type}/{resource-name}/Microsoft.Resources/links/{link-name}. For example, /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myGroup/Microsoft.Web/sites/mySite/Microsoft.Resources/links/myLink. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkId"/> is null. </exception>
        public async Task<Response> DeleteAsync(ResourceIdentifier linkId, CancellationToken cancellationToken = default)
        {
            if (linkId == null)
            {
                throw new ArgumentNullException(nameof(linkId));
            }

            using var scope = _clientDiagnostics.CreateScope("ResourceLinkOperations.Delete");
            scope.Start();
            try
            {
                var operation = await StartDeleteAsync(linkId, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a resource link with the specified ID. </summary>
        /// <param name="linkId"> The fully qualified ID of the resource link. Use the format, /subscriptions/{subscription-id}/resourceGroups/{resource-group-name}/{provider-namespace}/{resource-type}/{resource-name}/Microsoft.Resources/links/{link-name}. For example, /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myGroup/Microsoft.Web/sites/mySite/Microsoft.Resources/links/myLink. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkId"/> is null. </exception>
        public Response Delete(ResourceIdentifier linkId, CancellationToken cancellationToken = default)
        {
            if (linkId == null)
            {
                throw new ArgumentNullException(nameof(linkId));
            }

            using var scope = _clientDiagnostics.CreateScope("ResourceLinkOperations.Delete");
            scope.Start();
            try
            {
                var operation = StartDelete(linkId, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a resource link with the specified ID. </summary>
        /// <param name="linkId"> The fully qualified ID of the resource link. Use the format, /subscriptions/{subscription-id}/resourceGroups/{resource-group-name}/{provider-namespace}/{resource-type}/{resource-name}/Microsoft.Resources/links/{link-name}. For example, /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myGroup/Microsoft.Web/sites/mySite/Microsoft.Resources/links/myLink. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkId"/> is null. </exception>
        public async Task<ResourceLinksDeleteOperation> StartDeleteAsync(ResourceIdentifier linkId, CancellationToken cancellationToken = default)
        {
            if (linkId == null)
            {
                throw new ArgumentNullException(nameof(linkId));
            }

            using var scope = _clientDiagnostics.CreateScope("ResourceLinkOperations.StartDelete");
            scope.Start();
            try
            {
                var response = await _restClient.DeleteAsync(linkId, cancellationToken).ConfigureAwait(false);
                return new ResourceLinksDeleteOperation(response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a resource link with the specified ID. </summary>
        /// <param name="linkId"> The fully qualified ID of the resource link. Use the format, /subscriptions/{subscription-id}/resourceGroups/{resource-group-name}/{provider-namespace}/{resource-type}/{resource-name}/Microsoft.Resources/links/{link-name}. For example, /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myGroup/Microsoft.Web/sites/mySite/Microsoft.Resources/links/myLink. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkId"/> is null. </exception>
        public ResourceLinksDeleteOperation StartDelete(ResourceIdentifier linkId, CancellationToken cancellationToken = default)
        {
            if (linkId == null)
            {
                throw new ArgumentNullException(nameof(linkId));
            }

            using var scope = _clientDiagnostics.CreateScope("ResourceLinkOperations.StartDelete");
            scope.Start();
            try
            {
                var response = _restClient.Delete(linkId, cancellationToken);
                return new ResourceLinksDeleteOperation(response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
