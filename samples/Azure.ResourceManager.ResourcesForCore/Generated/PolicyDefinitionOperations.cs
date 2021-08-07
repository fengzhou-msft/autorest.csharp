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
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Management;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.ResourcesForCore.Models;

namespace Azure.ResourceManager.ResourcesForCore
{
    /// <summary> A class representing the operations that can be performed over a specific PolicyDefinition. </summary>
    public partial class PolicyDefinitionOperations : ResourceOperations
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
        protected internal PolicyDefinitionOperations(ResourceOperations options, ResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new PolicyDefinitionsRestOperations(_clientDiagnostics, Pipeline, BaseUri);
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Authorization/policyDefinitions";
        /// <summary> Gets the valid resource type for the operations. </summary>
        protected override ResourceType ValidResourceType => ResourceType;

        /// <summary> This operation retrieves the policy definition in the given subscription with the given name. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<PolicyDefinition>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyDefinitionOperations.Get");
            scope.Start();
            try
            {
                if (Id.TryGetSubscriptionId(out _))
                {
                    var response = await _restClient.GetAsync(Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                    if (response.Value == null)
                        throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                    return Response.FromValue(new PolicyDefinition(this, response.Value), response.GetRawResponse());
                }
                else
                {
                    var parent = Id;
                    while (parent.Parent != ResourceIdentifier.RootResourceIdentifier)
                    {
                        parent = parent.Parent;
                    }
                    if (parent.ResourceType.Equals(ManagementGroupOperations.ResourceType))
                    {
                        var response = await _restClient.GetAtManagementGroupAsync(Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                        if (response.Value == null)
                            throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                        return Response.FromValue(new PolicyDefinition(this, response.Value), response.GetRawResponse());
                    }
                    else
                    {
                        var response = await _restClient.GetBuiltInAsync(Id.Name, cancellationToken).ConfigureAwait(false);
                        if (response.Value == null)
                            throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                        return Response.FromValue(new PolicyDefinition(this, response.Value), response.GetRawResponse());
                    }
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation retrieves the policy definition in the given subscription with the given name. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PolicyDefinition> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyDefinitionOperations.Get");
            scope.Start();
            try
            {
                if (Id.TryGetSubscriptionId(out _))
                {
                    var response = _restClient.Get(Id.Parent.Name, Id.Name, cancellationToken);
                    if (response.Value == null)
                        throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                    return Response.FromValue(new PolicyDefinition(this, response.Value), response.GetRawResponse());
                }
                else
                {
                    var parent = Id;
                    while (parent.Parent != ResourceIdentifier.RootResourceIdentifier)
                    {
                        parent = parent.Parent;
                    }
                    if (parent.ResourceType.Equals(ManagementGroupOperations.ResourceType))
                    {
                        var response = _restClient.GetAtManagementGroup(Id.Parent.Name, Id.Name, cancellationToken);
                        if (response.Value == null)
                            throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                        return Response.FromValue(new PolicyDefinition(this, response.Value), response.GetRawResponse());
                    }
                    else
                    {
                        var response = _restClient.GetBuiltIn(Id.Name, cancellationToken);
                        if (response.Value == null)
                            throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                        return Response.FromValue(new PolicyDefinition(this, response.Value), response.GetRawResponse());
                    }
                }
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
        public async virtual Task<IEnumerable<Location>> GetAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public virtual IEnumerable<Location> GetAvailableLocations(CancellationToken cancellationToken = default)
        {
            return ListAvailableLocations(ResourceType, cancellationToken);
        }

        /// <summary> This operation deletes the policy definition in the given subscription with the given name. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response> DeleteAsync(CancellationToken cancellationToken = default)
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
        public virtual Response Delete(CancellationToken cancellationToken = default)
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
        public async virtual Task<PolicyDefinitionsDeleteOperation> StartDeleteAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyDefinitionOperations.StartDelete");
            scope.Start();
            try
            {
                if (Id.TryGetSubscriptionId(out _))
                {
                    var response = await _restClient.DeleteAsync(Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                    return new PolicyDefinitionsDeleteOperation(response);
                }
                else
                {
                    var response = await _restClient.DeleteAtManagementGroupAsync(Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                    return new PolicyDefinitionsDeleteOperation(response);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation deletes the policy definition in the given subscription with the given name. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual PolicyDefinitionsDeleteOperation StartDelete(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyDefinitionOperations.StartDelete");
            scope.Start();
            try
            {
                if (Id.TryGetSubscriptionId(out _))
                {
                    var response = _restClient.Delete(Id.Parent.Name, Id.Name, cancellationToken);
                    return new PolicyDefinitionsDeleteOperation(response);
                }
                else
                {
                    var response = _restClient.DeleteAtManagementGroup(Id.Parent.Name, Id.Name, cancellationToken);
                    return new PolicyDefinitionsDeleteOperation(response);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
