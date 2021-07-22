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

namespace Azure.Resources.Sample
{
    /// <summary> A class representing collection of JitRequestDefinition and their operations over a ResourceGroup. </summary>
    public partial class JitRequestDefinitionContainer : ResourceContainerBase<ResourceGroupResourceIdentifier, JitRequestDefinition, JitRequestDefinitionData>
    {
        /// <summary> Initializes a new instance of the <see cref="JitRequestDefinitionContainer"/> class for mocking. </summary>
        protected JitRequestDefinitionContainer()
        {
        }

        /// <summary> Initializes a new instance of JitRequestDefinitionContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal JitRequestDefinitionContainer(OperationsBase parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private JitRequestsRestOperations _restClient => new JitRequestsRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);

        /// <summary> Typed Resource Identifier for the container. </summary>
        public new ResourceGroupResourceIdentifier Id => base.Id as ResourceGroupResourceIdentifier;

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroupOperations.ResourceType;

        // Container level operations.

        /// <summary> Creates or updates the JIT request. </summary>
        /// <param name="jitRequestName"> The name of the JIT request. </param>
        /// <param name="parameters"> Parameters supplied to the update JIT request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jitRequestName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual Response<JitRequestDefinition> CreateOrUpdate(string jitRequestName, JitRequestDefinitionData parameters, CancellationToken cancellationToken = default)
        {
            if (jitRequestName == null)
            {
                throw new ArgumentNullException(nameof(jitRequestName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("JitRequestDefinitionContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = StartCreateOrUpdate(jitRequestName, parameters, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates the JIT request. </summary>
        /// <param name="jitRequestName"> The name of the JIT request. </param>
        /// <param name="parameters"> Parameters supplied to the update JIT request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jitRequestName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<Response<JitRequestDefinition>> CreateOrUpdateAsync(string jitRequestName, JitRequestDefinitionData parameters, CancellationToken cancellationToken = default)
        {
            if (jitRequestName == null)
            {
                throw new ArgumentNullException(nameof(jitRequestName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("JitRequestDefinitionContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = await StartCreateOrUpdateAsync(jitRequestName, parameters, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates the JIT request. </summary>
        /// <param name="jitRequestName"> The name of the JIT request. </param>
        /// <param name="parameters"> Parameters supplied to the update JIT request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jitRequestName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual JitRequestsCreateOrUpdateOperation StartCreateOrUpdate(string jitRequestName, JitRequestDefinitionData parameters, CancellationToken cancellationToken = default)
        {
            if (jitRequestName == null)
            {
                throw new ArgumentNullException(nameof(jitRequestName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("JitRequestDefinitionContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, jitRequestName, parameters, cancellationToken);
                return new JitRequestsCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, jitRequestName, parameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates the JIT request. </summary>
        /// <param name="jitRequestName"> The name of the JIT request. </param>
        /// <param name="parameters"> Parameters supplied to the update JIT request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jitRequestName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<JitRequestsCreateOrUpdateOperation> StartCreateOrUpdateAsync(string jitRequestName, JitRequestDefinitionData parameters, CancellationToken cancellationToken = default)
        {
            if (jitRequestName == null)
            {
                throw new ArgumentNullException(nameof(jitRequestName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("JitRequestDefinitionContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, jitRequestName, parameters, cancellationToken).ConfigureAwait(false);
                return new JitRequestsCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, jitRequestName, parameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="jitRequestName"> The name of the JIT request. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<JitRequestDefinition> Get(string jitRequestName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("JitRequestDefinitionContainer.Get");
            scope.Start();
            try
            {
                if (jitRequestName == null)
                {
                    throw new ArgumentNullException(nameof(jitRequestName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, jitRequestName, cancellationToken: cancellationToken);
                return Response.FromValue(new JitRequestDefinition(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="jitRequestName"> The name of the JIT request. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<JitRequestDefinition>> GetAsync(string jitRequestName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("JitRequestDefinitionContainer.Get");
            scope.Start();
            try
            {
                if (jitRequestName == null)
                {
                    throw new ArgumentNullException(nameof(jitRequestName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, jitRequestName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new JitRequestDefinition(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="jitRequestName"> The name of the JIT request. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual JitRequestDefinition TryGet(string jitRequestName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("JitRequestDefinitionContainer.TryGet");
            scope.Start();
            try
            {
                if (jitRequestName == null)
                {
                    throw new ArgumentNullException(nameof(jitRequestName));
                }

                return Get(jitRequestName, cancellationToken: cancellationToken).Value;
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
        /// <param name="jitRequestName"> The name of the JIT request. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<JitRequestDefinition> TryGetAsync(string jitRequestName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("JitRequestDefinitionContainer.TryGet");
            scope.Start();
            try
            {
                if (jitRequestName == null)
                {
                    throw new ArgumentNullException(nameof(jitRequestName));
                }

                return await GetAsync(jitRequestName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <param name="jitRequestName"> The name of the JIT request. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual bool DoesExist(string jitRequestName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("JitRequestDefinitionContainer.DoesExist");
            scope.Start();
            try
            {
                if (jitRequestName == null)
                {
                    throw new ArgumentNullException(nameof(jitRequestName));
                }

                return TryGet(jitRequestName, cancellationToken: cancellationToken) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="jitRequestName"> The name of the JIT request. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<bool> DoesExistAsync(string jitRequestName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("JitRequestDefinitionContainer.DoesExist");
            scope.Start();
            try
            {
                if (jitRequestName == null)
                {
                    throw new ArgumentNullException(nameof(jitRequestName));
                }

                return await TryGetAsync(jitRequestName, cancellationToken: cancellationToken).ConfigureAwait(false) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="JitRequestDefinition" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<ResourceManager.Core.GenericResourceExpanded> ListAsGenericResource(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("JitRequestDefinitionContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(JitRequestDefinitionOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContext(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="JitRequestDefinition" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<ResourceManager.Core.GenericResourceExpanded> ListAsGenericResourceAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("JitRequestDefinitionContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(JitRequestDefinitionOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContextAsync(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves all JIT requests within the subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<IReadOnlyList<JitRequestDefinition>>> ListBySubscriptionAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("JitRequestDefinitionContainer.ListBySubscription");
            scope.Start();
            try
            {
                var response = await _restClient.ListBySubscriptionAsync(cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value.Value.Select(data => new JitRequestDefinition(Parent, data)).ToArray() as IReadOnlyList<JitRequestDefinition>, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves all JIT requests within the subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<IReadOnlyList<JitRequestDefinition>> ListBySubscription(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("JitRequestDefinitionContainer.ListBySubscription");
            scope.Start();
            try
            {
                var response = _restClient.ListBySubscription(cancellationToken);
                return Response.FromValue(response.Value.Value.Select(data => new JitRequestDefinition(Parent, data)).ToArray() as IReadOnlyList<JitRequestDefinition>, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves all JIT requests within the resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<IReadOnlyList<JitRequestDefinition>>> ListByResourceGroupAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("JitRequestDefinitionContainer.ListByResourceGroup");
            scope.Start();
            try
            {
                var response = await _restClient.ListByResourceGroupAsync(Id.ResourceGroupName, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value.Value.Select(data => new JitRequestDefinition(Parent, data)).ToArray() as IReadOnlyList<JitRequestDefinition>, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves all JIT requests within the resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<IReadOnlyList<JitRequestDefinition>> ListByResourceGroup(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("JitRequestDefinitionContainer.ListByResourceGroup");
            scope.Start();
            try
            {
                var response = _restClient.ListByResourceGroup(Id.ResourceGroupName, cancellationToken);
                return Response.FromValue(response.Value.Value.Select(data => new JitRequestDefinition(Parent, data)).ToArray() as IReadOnlyList<JitRequestDefinition>, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<ResourceGroupResourceIdentifier, JitRequestDefinition, JitRequestDefinitionData> Construct() { }
    }
}
