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
using MgmtLRO.Models;

namespace MgmtLRO
{
    /// <summary> A class representing collection of Fake and their operations over its parent. </summary>
    public partial class FakeContainer : ArmContainer
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly FakesRestOperations _fakesRestClient;

        /// <summary> Initializes a new instance of the <see cref="FakeContainer"/> class for mocking. </summary>
        protected FakeContainer()
        {
        }

        /// <summary> Initializes a new instance of FakeContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal FakeContainer(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _fakesRestClient = new FakesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroup.ResourceType;

        // Container level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Fake/fakes/{fakeName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Fakes_CreateOrUpdate
        /// <summary> Create or update an fake. </summary>
        /// <param name="fakeName"> The name of the fake. </param>
        /// <param name="parameters"> Parameters supplied to the Create Availability Set operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual FakeCreateOrUpdateOperation StartCreateOrUpdate(string fakeName, FakeData parameters, bool waitForCompletion = false, CancellationToken cancellationToken = default)
        {
            if (fakeName == null)
            {
                throw new ArgumentNullException(nameof(fakeName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("FakeContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = _fakesRestClient.CreateOrUpdate(Id.ResourceGroupName, fakeName, parameters, cancellationToken);
                var operation = new FakeCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _fakesRestClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, fakeName, parameters).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Fake/fakes/{fakeName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Fakes_CreateOrUpdate
        /// <summary> Create or update an fake. </summary>
        /// <param name="fakeName"> The name of the fake. </param>
        /// <param name="parameters"> Parameters supplied to the Create Availability Set operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<FakeCreateOrUpdateOperation> StartCreateOrUpdateAsync(string fakeName, FakeData parameters, bool waitForCompletion = false, CancellationToken cancellationToken = default)
        {
            if (fakeName == null)
            {
                throw new ArgumentNullException(nameof(fakeName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("FakeContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _fakesRestClient.CreateOrUpdateAsync(Id.ResourceGroupName, fakeName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new FakeCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _fakesRestClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, fakeName, parameters).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Fake/fakes/{fakeName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Fakes_Get
        /// <summary> Retrieves information about an fake. </summary>
        /// <param name="fakeName"> The name of the fake. </param>
        /// <param name="expand"> May be used to expand the participants. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeName"/> is null. </exception>
        public virtual Response<Fake> Get(string fakeName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (fakeName == null)
            {
                throw new ArgumentNullException(nameof(fakeName));
            }

            using var scope = _clientDiagnostics.CreateScope("FakeContainer.Get");
            scope.Start();
            try
            {
                var response = _fakesRestClient.Get(Id.ResourceGroupName, fakeName, expand, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new Fake(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Fake/fakes/{fakeName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Fakes_Get
        /// <summary> Retrieves information about an fake. </summary>
        /// <param name="fakeName"> The name of the fake. </param>
        /// <param name="expand"> May be used to expand the participants. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeName"/> is null. </exception>
        public async virtual Task<Response<Fake>> GetAsync(string fakeName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (fakeName == null)
            {
                throw new ArgumentNullException(nameof(fakeName));
            }

            using var scope = _clientDiagnostics.CreateScope("FakeContainer.Get");
            scope.Start();
            try
            {
                var response = await _fakesRestClient.GetAsync(Id.ResourceGroupName, fakeName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new Fake(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="fakeName"> The name of the fake. </param>
        /// <param name="expand"> May be used to expand the participants. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeName"/> is null. </exception>
        public virtual Response<Fake> GetIfExists(string fakeName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (fakeName == null)
            {
                throw new ArgumentNullException(nameof(fakeName));
            }

            using var scope = _clientDiagnostics.CreateScope("FakeContainer.GetIfExists");
            scope.Start();
            try
            {
                var response = _fakesRestClient.Get(Id.ResourceGroupName, fakeName, expand, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<Fake>(null, response.GetRawResponse())
                    : Response.FromValue(new Fake(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="fakeName"> The name of the fake. </param>
        /// <param name="expand"> May be used to expand the participants. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeName"/> is null. </exception>
        public async virtual Task<Response<Fake>> GetIfExistsAsync(string fakeName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (fakeName == null)
            {
                throw new ArgumentNullException(nameof(fakeName));
            }

            using var scope = _clientDiagnostics.CreateScope("FakeContainer.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _fakesRestClient.GetAsync(Id.ResourceGroupName, fakeName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<Fake>(null, response.GetRawResponse())
                    : Response.FromValue(new Fake(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="fakeName"> The name of the fake. </param>
        /// <param name="expand"> May be used to expand the participants. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeName"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string fakeName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (fakeName == null)
            {
                throw new ArgumentNullException(nameof(fakeName));
            }

            using var scope = _clientDiagnostics.CreateScope("FakeContainer.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(fakeName, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="fakeName"> The name of the fake. </param>
        /// <param name="expand"> May be used to expand the participants. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeName"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string fakeName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (fakeName == null)
            {
                throw new ArgumentNullException(nameof(fakeName));
            }

            using var scope = _clientDiagnostics.CreateScope("FakeContainer.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(fakeName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Fake/fakes
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Fakes_List
        /// <summary> Lists all fakes in a resource group. </summary>
        /// <param name="requiredParam"> The expand expression to apply on the operation. </param>
        /// <param name="optionalParam"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="requiredParam"/> is null. </exception>
        public virtual Response<IReadOnlyList<Fake>> GetAll(string requiredParam, string optionalParam = null, CancellationToken cancellationToken = default)
        {
            if (requiredParam == null)
            {
                throw new ArgumentNullException(nameof(requiredParam));
            }

            using var scope = _clientDiagnostics.CreateScope("FakeContainer.GetAll");
            scope.Start();
            try
            {
                var response = _fakesRestClient.List(Id.ResourceGroupName, requiredParam, optionalParam, cancellationToken);
                return Response.FromValue(response.Value.Value.Select(value => new Fake(Parent, value)).ToArray() as IReadOnlyList<Fake>, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Fake/fakes
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Fakes_List
        /// <summary> Lists all fakes in a resource group. </summary>
        /// <param name="requiredParam"> The expand expression to apply on the operation. </param>
        /// <param name="optionalParam"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="requiredParam"/> is null. </exception>
        public async virtual Task<Response<IReadOnlyList<Fake>>> GetAllAsync(string requiredParam, string optionalParam = null, CancellationToken cancellationToken = default)
        {
            if (requiredParam == null)
            {
                throw new ArgumentNullException(nameof(requiredParam));
            }

            using var scope = _clientDiagnostics.CreateScope("FakeContainer.GetAll");
            scope.Start();
            try
            {
                var response = await _fakesRestClient.ListAsync(Id.ResourceGroupName, requiredParam, optionalParam, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value.Value.Select(value => new Fake(Parent, value)).ToArray() as IReadOnlyList<Fake>, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="Fake" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FakeContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(Fake.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="Fake" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FakeContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(Fake.ResourceType);
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
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, Fake, FakeData> Construct() { }
    }
}
