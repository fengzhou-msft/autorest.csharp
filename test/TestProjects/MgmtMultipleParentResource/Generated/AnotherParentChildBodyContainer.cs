// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using MgmtMultipleParentResource.Models;

namespace MgmtMultipleParentResource
{
    /// <summary> A class representing collection of ChildBody and their operations over its parent. </summary>
    public partial class AnotherParentChildBodyContainer : ArmContainer
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly AnotherChildrenRestOperations _anotherChildrenRestClient;

        /// <summary> Initializes a new instance of the <see cref="AnotherParentChildBodyContainer"/> class for mocking. </summary>
        protected AnotherParentChildBodyContainer()
        {
        }

        /// <summary> Initializes a new instance of AnotherParentChildBodyContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal AnotherParentChildBodyContainer(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _anotherChildrenRestClient = new AnotherChildrenRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => AnotherParent.ResourceType;

        // Container level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/anotherParents/{anotherName}/children/{childName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/anotherParents/{anotherName}
        /// OperationId: AnotherChildren_CreateOrUpdate
        /// <summary> The operation to create or update the run command. </summary>
        /// <param name="childName"> The name of the virtual machine run command. </param>
        /// <param name="childBody"> Parameters supplied to the Create Virtual Machine RunCommand operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="childName"/> or <paramref name="childBody"/> is null. </exception>
        public virtual AnotherChildCreateOrUpdateOperation CreateOrUpdate(string childName, ChildBodyData childBody, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (childName == null)
            {
                throw new ArgumentNullException(nameof(childName));
            }
            if (childBody == null)
            {
                throw new ArgumentNullException(nameof(childBody));
            }

            using var scope = _clientDiagnostics.CreateScope("AnotherParentChildBodyContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _anotherChildrenRestClient.CreateOrUpdate(Id.ResourceGroupName, Id.Name, childName, childBody, cancellationToken);
                var operation = new AnotherChildCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _anotherChildrenRestClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, childName, childBody).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/anotherParents/{anotherName}/children/{childName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/anotherParents/{anotherName}
        /// OperationId: AnotherChildren_CreateOrUpdate
        /// <summary> The operation to create or update the run command. </summary>
        /// <param name="childName"> The name of the virtual machine run command. </param>
        /// <param name="childBody"> Parameters supplied to the Create Virtual Machine RunCommand operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="childName"/> or <paramref name="childBody"/> is null. </exception>
        public async virtual Task<AnotherChildCreateOrUpdateOperation> CreateOrUpdateAsync(string childName, ChildBodyData childBody, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (childName == null)
            {
                throw new ArgumentNullException(nameof(childName));
            }
            if (childBody == null)
            {
                throw new ArgumentNullException(nameof(childBody));
            }

            using var scope = _clientDiagnostics.CreateScope("AnotherParentChildBodyContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _anotherChildrenRestClient.CreateOrUpdateAsync(Id.ResourceGroupName, Id.Name, childName, childBody, cancellationToken).ConfigureAwait(false);
                var operation = new AnotherChildCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _anotherChildrenRestClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, childName, childBody).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/anotherParents/{anotherName}/children/{childName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/anotherParents/{anotherName}
        /// OperationId: AnotherChildren_Get
        /// <summary> The operation to get the run command. </summary>
        /// <param name="childName"> The name of the virtual machine run command. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="childName"/> is null. </exception>
        public virtual Response<AnotherParentChildBody> Get(string childName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (childName == null)
            {
                throw new ArgumentNullException(nameof(childName));
            }

            using var scope = _clientDiagnostics.CreateScope("AnotherParentChildBodyContainer.Get");
            scope.Start();
            try
            {
                var response = _anotherChildrenRestClient.Get(Id.ResourceGroupName, Id.Name, childName, expand, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AnotherParentChildBody(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/anotherParents/{anotherName}/children/{childName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/anotherParents/{anotherName}
        /// OperationId: AnotherChildren_Get
        /// <summary> The operation to get the run command. </summary>
        /// <param name="childName"> The name of the virtual machine run command. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="childName"/> is null. </exception>
        public async virtual Task<Response<AnotherParentChildBody>> GetAsync(string childName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (childName == null)
            {
                throw new ArgumentNullException(nameof(childName));
            }

            using var scope = _clientDiagnostics.CreateScope("AnotherParentChildBodyContainer.Get");
            scope.Start();
            try
            {
                var response = await _anotherChildrenRestClient.GetAsync(Id.ResourceGroupName, Id.Name, childName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new AnotherParentChildBody(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="childName"> The name of the virtual machine run command. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="childName"/> is null. </exception>
        public virtual Response<AnotherParentChildBody> GetIfExists(string childName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (childName == null)
            {
                throw new ArgumentNullException(nameof(childName));
            }

            using var scope = _clientDiagnostics.CreateScope("AnotherParentChildBodyContainer.GetIfExists");
            scope.Start();
            try
            {
                var response = _anotherChildrenRestClient.Get(Id.ResourceGroupName, Id.Name, childName, expand, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<AnotherParentChildBody>(null, response.GetRawResponse())
                    : Response.FromValue(new AnotherParentChildBody(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="childName"> The name of the virtual machine run command. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="childName"/> is null. </exception>
        public async virtual Task<Response<AnotherParentChildBody>> GetIfExistsAsync(string childName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (childName == null)
            {
                throw new ArgumentNullException(nameof(childName));
            }

            using var scope = _clientDiagnostics.CreateScope("AnotherParentChildBodyContainer.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _anotherChildrenRestClient.GetAsync(Id.ResourceGroupName, Id.Name, childName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<AnotherParentChildBody>(null, response.GetRawResponse())
                    : Response.FromValue(new AnotherParentChildBody(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="childName"> The name of the virtual machine run command. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="childName"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string childName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (childName == null)
            {
                throw new ArgumentNullException(nameof(childName));
            }

            using var scope = _clientDiagnostics.CreateScope("AnotherParentChildBodyContainer.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(childName, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="childName"> The name of the virtual machine run command. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="childName"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string childName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (childName == null)
            {
                throw new ArgumentNullException(nameof(childName));
            }

            using var scope = _clientDiagnostics.CreateScope("AnotherParentChildBodyContainer.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(childName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/anotherParents/{anotherName}/children
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/anotherParents/{anotherName}
        /// OperationId: AnotherChildren_List
        /// <summary> The operation to get all run commands of a Virtual Machine. </summary>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AnotherParentChildBody" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AnotherParentChildBody> GetAll(string expand = null, CancellationToken cancellationToken = default)
        {
            Page<AnotherParentChildBody> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AnotherParentChildBodyContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _anotherChildrenRestClient.List(Id.ResourceGroupName, Id.Name, expand, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AnotherParentChildBody(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<AnotherParentChildBody> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AnotherParentChildBodyContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _anotherChildrenRestClient.ListNextPage(nextLink, Id.ResourceGroupName, Id.Name, expand, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AnotherParentChildBody(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/anotherParents/{anotherName}/children
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/anotherParents/{anotherName}
        /// OperationId: AnotherChildren_List
        /// <summary> The operation to get all run commands of a Virtual Machine. </summary>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AnotherParentChildBody" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AnotherParentChildBody> GetAllAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<AnotherParentChildBody>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AnotherParentChildBodyContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _anotherChildrenRestClient.ListAsync(Id.ResourceGroupName, Id.Name, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AnotherParentChildBody(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<AnotherParentChildBody>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AnotherParentChildBodyContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _anotherChildrenRestClient.ListNextPageAsync(nextLink, Id.ResourceGroupName, Id.Name, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AnotherParentChildBody(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, AnotherParentChildBody, ChildBodyData> Construct() { }
    }
}
