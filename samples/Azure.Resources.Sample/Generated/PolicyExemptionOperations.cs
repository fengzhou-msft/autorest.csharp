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
    /// <summary> A class representing the operations that can be performed over a specific PolicyExemption. </summary>
    public partial class PolicyExemptionOperations : ResourceOperationsBase<TenantResourceIdentifier, PolicyExemption>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private PolicyExemptionsRestOperations _restClient { get; }

        /// <summary> Initializes a new instance of the <see cref="PolicyExemptionOperations"/> class for mocking. </summary>
        protected PolicyExemptionOperations()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PolicyExemptionOperations"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        protected internal PolicyExemptionOperations(OperationsBase options, TenantResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new PolicyExemptionsRestOperations(_clientDiagnostics, Pipeline, BaseUri);
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Authorization/policyExemptions";
        /// <summary> Gets the valid resource type for the operations. </summary>
        protected override ResourceType ValidResourceType => ResourceType;

        /// <inheritdoc />
        public async override Task<Response<PolicyExemption>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyExemptionOperations.Get");
            scope.Start();
            try
            {
                var response = await _restClient.GetAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new PolicyExemption(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        public override Response<PolicyExemption> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyExemptionOperations.Get");
            scope.Start();
            try
            {
                var response = _restClient.Get(Id.Parent, Id.Name, cancellationToken);
                return Response.FromValue(new PolicyExemption(this, response.Value), response.GetRawResponse());
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

        /// <summary> This operation deletes a policy exemption, given its name and the scope it was created in. The scope of a policy exemption is the part of its ID preceding &apos;/providers/Microsoft.Authorization/policyExemptions/{policyExemptionName}&apos;. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> DeleteAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyExemptionOperations.Delete");
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

        /// <summary> This operation deletes a policy exemption, given its name and the scope it was created in. The scope of a policy exemption is the part of its ID preceding &apos;/providers/Microsoft.Authorization/policyExemptions/{policyExemptionName}&apos;. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Delete(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyExemptionOperations.Delete");
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

        /// <summary> This operation deletes a policy exemption, given its name and the scope it was created in. The scope of a policy exemption is the part of its ID preceding &apos;/providers/Microsoft.Authorization/policyExemptions/{policyExemptionName}&apos;. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<PolicyExemptionsDeleteOperation> StartDeleteAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyExemptionOperations.StartDelete");
            scope.Start();
            try
            {
                var response = await _restClient.DeleteAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                return new PolicyExemptionsDeleteOperation(response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation deletes a policy exemption, given its name and the scope it was created in. The scope of a policy exemption is the part of its ID preceding &apos;/providers/Microsoft.Authorization/policyExemptions/{policyExemptionName}&apos;. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public PolicyExemptionsDeleteOperation StartDelete(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyExemptionOperations.StartDelete");
            scope.Start();
            try
            {
                var response = _restClient.Delete(Id.Parent, Id.Name, cancellationToken);
                return new PolicyExemptionsDeleteOperation(response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
