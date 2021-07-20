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
    /// <summary> A class representing the operations that can be performed over a specific PolicyDefinition. </summary>
    public partial class PolicyDefinitionOperations : ResourceOperationsBase<TenantResourceIdentifier, PolicyDefinition>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private PolicyDefinitionsRestOperations _restClient { get; }

        /// <summary> Initializes a new instance of the <see cref="PolicyDefinitionOperations"/> class for mocking. </summary>
        protected PolicyDefinitionOperations()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PolicyDefinitionOperations"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        protected internal PolicyDefinitionOperations(OperationsBase options, TenantResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new PolicyDefinitionsRestOperations(_clientDiagnostics, Pipeline, BaseUri);
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Authorization/policyDefinitions";
        /// <summary> Gets the valid resource type for the operations. </summary>
        protected override ResourceType ValidResourceType => ResourceType;

        /// <inheritdoc />
        public async override Task<Response<PolicyDefinition>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyDefinitionOperations.Get");
            scope.Start();
            try
            {
                var response = await _restClient.GetAsync(Id.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new PolicyDefinition(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        public override Response<PolicyDefinition> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyDefinitionOperations.Get");
            scope.Start();
            try
            {
                var response = _restClient.Get(Id.Name, Id.Name, cancellationToken);
                return Response.FromValue(new PolicyDefinition(this, response.Value), response.GetRawResponse());
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

        /// <summary> This operation deletes the policy definition in the given subscription with the given name. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> DeleteAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyDefinitionOperations.Delete");
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

        /// <summary> This operation deletes the policy definition in the given subscription with the given name. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Delete(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyDefinitionOperations.Delete");
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

        /// <summary> This operation deletes the policy definition in the given subscription with the given name. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<PolicyDefinitionsDeleteOperation> StartDeleteAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyDefinitionOperations.StartDelete");
            scope.Start();
            try
            {
                var response = await _restClient.DeleteAsync(Id.Name, Id.SubscriptionId, cancellationToken).ConfigureAwait(false);
                return new PolicyDefinitionsDeleteOperation(response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation deletes the policy definition in the given subscription with the given name. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public PolicyDefinitionsDeleteOperation StartDelete(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyDefinitionOperations.StartDelete");
            scope.Start();
            try
            {
                var response = _restClient.Delete(Id.Name, Id.SubscriptionId, cancellationToken);
                return new PolicyDefinitionsDeleteOperation(response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> This operation retrieves the built-in policy definition with the given name. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PolicyDefinitionData>> GetBuiltInAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyDefinitionOperations.GetBuiltIn");
            scope.Start();
            try
            {
                var response = await _restClient.GetBuiltInAsync(Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation retrieves the built-in policy definition with the given name. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PolicyDefinitionData> GetBuiltIn(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyDefinitionOperations.GetBuiltIn");
            scope.Start();
            try
            {
                var response = _restClient.GetBuiltIn(Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation deletes the policy definition in the given management group with the given name. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DeleteAtManagementGroupAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyDefinitionOperations.DeleteAtManagementGroup");
            scope.Start();
            try
            {
                var response = await _restClient.DeleteAtManagementGroupAsync(Id.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation deletes the policy definition in the given management group with the given name. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response DeleteAtManagementGroup(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyDefinitionOperations.DeleteAtManagementGroup");
            scope.Start();
            try
            {
                var response = _restClient.DeleteAtManagementGroup(Id.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation retrieves the policy definition in the given management group with the given name. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PolicyDefinitionData>> GetAtManagementGroupAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyDefinitionOperations.GetAtManagementGroup");
            scope.Start();
            try
            {
                var response = await _restClient.GetAtManagementGroupAsync(Id.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation retrieves the policy definition in the given management group with the given name. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PolicyDefinitionData> GetAtManagementGroup(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyDefinitionOperations.GetAtManagementGroup");
            scope.Start();
            try
            {
                var response = _restClient.GetAtManagementGroup(Id.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
