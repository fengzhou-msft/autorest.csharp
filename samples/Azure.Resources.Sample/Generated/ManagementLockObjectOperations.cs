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
    /// <summary> A class representing the operations that can be performed over a specific ManagementLockObject. </summary>
    public partial class ManagementLockObjectOperations : ResourceOperationsBase<TenantResourceIdentifier, ManagementLockObject>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private ManagementLocksRestOperations _restClient { get; }

        /// <summary> Initializes a new instance of the <see cref="ManagementLockObjectOperations"/> class for mocking. </summary>
        protected ManagementLockObjectOperations()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ManagementLockObjectOperations"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        protected internal ManagementLockObjectOperations(OperationsBase options, TenantResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new ManagementLocksRestOperations(_clientDiagnostics, Pipeline, BaseUri);
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Authorization/locks";
        /// <summary> Gets the valid resource type for the operations. </summary>
        protected override ResourceType ValidResourceType => ResourceType;

        /// <inheritdoc />
        public async override Task<Response<ManagementLockObject>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagementLockObjectOperations.GetByScope");
            scope.Start();
            try
            {
                var response = await _restClient.GetByScopeAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new ManagementLockObject(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        public override Response<ManagementLockObject> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagementLockObjectOperations.GetByScope");
            scope.Start();
            try
            {
                var response = _restClient.GetByScope(Id.Parent, Id.Name, cancellationToken);
                return Response.FromValue(new ManagementLockObject(this, response.Value), response.GetRawResponse());
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

        /// <summary> Delete a management lock by scope. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> DeleteByScopeAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagementLockObjectOperations.DeleteByScope");
            scope.Start();
            try
            {
                var operation = await StartDeleteByScopeAsync(cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete a management lock by scope. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response DeleteByScope(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagementLockObjectOperations.DeleteByScope");
            scope.Start();
            try
            {
                var operation = StartDeleteByScope(cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete a management lock by scope. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<ManagementLocksDeleteByScopeOperation> StartDeleteByScopeAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagementLockObjectOperations.StartDeleteByScope");
            scope.Start();
            try
            {
                var response = await _restClient.DeleteByScopeAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                return new ManagementLocksDeleteByScopeOperation(response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete a management lock by scope. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public ManagementLocksDeleteByScopeOperation StartDeleteByScope(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagementLockObjectOperations.StartDeleteByScope");
            scope.Start();
            try
            {
                var response = _restClient.DeleteByScope(Id.Parent, Id.Name, cancellationToken);
                return new ManagementLocksDeleteByScopeOperation(response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
