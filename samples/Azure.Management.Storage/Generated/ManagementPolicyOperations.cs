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
using Azure.ResourceManager.Core;

namespace Azure.Management.Storage
{
    /// <summary> A class representing the operations that can be performed over a specific ManagementPolicy. </summary>
    public partial class ManagementPolicyOperations : ResourceOperationsBase<ResourceGroupResourceIdentifier, ManagementPolicy>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private ManagementPoliciesRestOperations _restClient { get; }

        /// <summary> Initializes a new instance of the <see cref="ManagementPolicyOperations"/> class for mocking. </summary>
        protected ManagementPolicyOperations()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ManagementPolicyOperations"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        protected internal ManagementPolicyOperations(ResourceOperationsBase options, ResourceGroupResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new ManagementPoliciesRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);
        }

        public static readonly ResourceType ResourceType = "Microsoft.Storage/storageAccounts/managementPolicies";
        protected override ResourceType ValidResourceType => ResourceType;

        /// <inheritdoc />
        public async override Task<Response<ManagementPolicy>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagementPolicyOperations.Get");
            scope.Start();
            try
            {
                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new ManagementPolicy(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        public override Response<ManagementPolicy> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagementPolicyOperations.Get");
            scope.Start();
            try
            {
                var response = _restClient.Get(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return Response.FromValue(new ManagementPolicy(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of location that may take multiple service requests to iterate over. </returns>
        public async Task<IEnumerable<LocationData>> ListAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of location that may take multiple service requests to iterate over. </returns>
        public IEnumerable<LocationData> ListAvailableLocations(CancellationToken cancellationToken = default)
        {
            return ListAvailableLocations(ResourceType, cancellationToken);
        }

        /// <summary> Deletes the managementpolicy associated with the specified storage account. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> DeleteAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagementPolicyOperations.Delete");
            scope.Start();
            try
            {
                var operation = await StartDeleteAsync(cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the managementpolicy associated with the specified storage account. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Delete(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagementPolicyOperations.Delete");
            scope.Start();
            try
            {
                var operation = StartDelete(cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the managementpolicy associated with the specified storage account. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Operation> StartDeleteAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagementPolicyOperations.StartDelete");
            scope.Start();
            try
            {
                var response = await _restClient.DeleteAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return new ManagementPoliciesDeleteOperation(response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the managementpolicy associated with the specified storage account. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Operation StartDelete(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagementPolicyOperations.StartDelete");
            scope.Start();
            try
            {
                var response = _restClient.Delete(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return new ManagementPoliciesDeleteOperation(response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
