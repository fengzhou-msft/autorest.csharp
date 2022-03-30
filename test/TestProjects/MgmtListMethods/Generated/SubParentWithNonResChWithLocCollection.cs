// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace MgmtListMethods
{
    /// <summary>
    /// A class representing a collection of <see cref="SubParentWithNonResChWithLocResource" /> and their operations.
    /// Each <see cref="SubParentWithNonResChWithLocResource" /> in the collection will belong to the same instance of <see cref="SubscriptionResource" />.
    /// To get a <see cref="SubParentWithNonResChWithLocCollection" /> instance call the GetSubParentWithNonResChWithLocs method from an instance of <see cref="SubscriptionResource" />.
    /// </summary>
    public partial class SubParentWithNonResChWithLocCollection : ArmCollection, IEnumerable<SubParentWithNonResChWithLocResource>, IAsyncEnumerable<SubParentWithNonResChWithLocResource>
    {
        private readonly ClientDiagnostics _subParentWithNonResChWithLocClientDiagnostics;
        private readonly SubParentWithNonResChWithLocsRestOperations _subParentWithNonResChWithLocRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubParentWithNonResChWithLocCollection"/> class for mocking. </summary>
        protected SubParentWithNonResChWithLocCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubParentWithNonResChWithLocCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SubParentWithNonResChWithLocCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _subParentWithNonResChWithLocClientDiagnostics = new ClientDiagnostics("MgmtListMethods", SubParentWithNonResChWithLocResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SubParentWithNonResChWithLocResource.ResourceType, out string subParentWithNonResChWithLocApiVersion);
            _subParentWithNonResChWithLocRestClient = new SubParentWithNonResChWithLocsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, subParentWithNonResChWithLocApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SubscriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SubscriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.MgmtListMethods/subParentWithNonResChWithLocs/{subParentWithNonResChWithLocName}
        /// Operation Id: SubParentWithNonResChWithLocs_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="subParentWithNonResChWithLocName"> Name. </param>
        /// <param name="data"> Parameters supplied to the Create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subParentWithNonResChWithLocName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subParentWithNonResChWithLocName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SubParentWithNonResChWithLocResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string subParentWithNonResChWithLocName, SubParentWithNonResChWithLocData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subParentWithNonResChWithLocName, nameof(subParentWithNonResChWithLocName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _subParentWithNonResChWithLocClientDiagnostics.CreateScope("SubParentWithNonResChWithLocCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _subParentWithNonResChWithLocRestClient.CreateOrUpdateAsync(Id.SubscriptionId, subParentWithNonResChWithLocName, data, cancellationToken).ConfigureAwait(false);
                var operation = new MgmtListMethodsArmOperation<SubParentWithNonResChWithLocResource>(Response.FromValue(new SubParentWithNonResChWithLocResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or update.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.MgmtListMethods/subParentWithNonResChWithLocs/{subParentWithNonResChWithLocName}
        /// Operation Id: SubParentWithNonResChWithLocs_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="subParentWithNonResChWithLocName"> Name. </param>
        /// <param name="data"> Parameters supplied to the Create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subParentWithNonResChWithLocName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subParentWithNonResChWithLocName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SubParentWithNonResChWithLocResource> CreateOrUpdate(WaitUntil waitUntil, string subParentWithNonResChWithLocName, SubParentWithNonResChWithLocData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subParentWithNonResChWithLocName, nameof(subParentWithNonResChWithLocName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _subParentWithNonResChWithLocClientDiagnostics.CreateScope("SubParentWithNonResChWithLocCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _subParentWithNonResChWithLocRestClient.CreateOrUpdate(Id.SubscriptionId, subParentWithNonResChWithLocName, data, cancellationToken);
                var operation = new MgmtListMethodsArmOperation<SubParentWithNonResChWithLocResource>(Response.FromValue(new SubParentWithNonResChWithLocResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves information.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.MgmtListMethods/subParentWithNonResChWithLocs/{subParentWithNonResChWithLocName}
        /// Operation Id: SubParentWithNonResChWithLocs_Get
        /// </summary>
        /// <param name="subParentWithNonResChWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subParentWithNonResChWithLocName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subParentWithNonResChWithLocName"/> is null. </exception>
        public virtual async Task<Response<SubParentWithNonResChWithLocResource>> GetAsync(string subParentWithNonResChWithLocName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subParentWithNonResChWithLocName, nameof(subParentWithNonResChWithLocName));

            using var scope = _subParentWithNonResChWithLocClientDiagnostics.CreateScope("SubParentWithNonResChWithLocCollection.Get");
            scope.Start();
            try
            {
                var response = await _subParentWithNonResChWithLocRestClient.GetAsync(Id.SubscriptionId, subParentWithNonResChWithLocName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubParentWithNonResChWithLocResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves information.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.MgmtListMethods/subParentWithNonResChWithLocs/{subParentWithNonResChWithLocName}
        /// Operation Id: SubParentWithNonResChWithLocs_Get
        /// </summary>
        /// <param name="subParentWithNonResChWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subParentWithNonResChWithLocName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subParentWithNonResChWithLocName"/> is null. </exception>
        public virtual Response<SubParentWithNonResChWithLocResource> Get(string subParentWithNonResChWithLocName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subParentWithNonResChWithLocName, nameof(subParentWithNonResChWithLocName));

            using var scope = _subParentWithNonResChWithLocClientDiagnostics.CreateScope("SubParentWithNonResChWithLocCollection.Get");
            scope.Start();
            try
            {
                var response = _subParentWithNonResChWithLocRestClient.Get(Id.SubscriptionId, subParentWithNonResChWithLocName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubParentWithNonResChWithLocResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.MgmtListMethods/subParentWithNonResChWithLocs
        /// Operation Id: SubParentWithNonResChWithLocs_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SubParentWithNonResChWithLocResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SubParentWithNonResChWithLocResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SubParentWithNonResChWithLocResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _subParentWithNonResChWithLocClientDiagnostics.CreateScope("SubParentWithNonResChWithLocCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _subParentWithNonResChWithLocRestClient.ListAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SubParentWithNonResChWithLocResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SubParentWithNonResChWithLocResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _subParentWithNonResChWithLocClientDiagnostics.CreateScope("SubParentWithNonResChWithLocCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _subParentWithNonResChWithLocRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SubParentWithNonResChWithLocResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Lists all in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.MgmtListMethods/subParentWithNonResChWithLocs
        /// Operation Id: SubParentWithNonResChWithLocs_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SubParentWithNonResChWithLocResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SubParentWithNonResChWithLocResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SubParentWithNonResChWithLocResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _subParentWithNonResChWithLocClientDiagnostics.CreateScope("SubParentWithNonResChWithLocCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _subParentWithNonResChWithLocRestClient.List(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SubParentWithNonResChWithLocResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SubParentWithNonResChWithLocResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _subParentWithNonResChWithLocClientDiagnostics.CreateScope("SubParentWithNonResChWithLocCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _subParentWithNonResChWithLocRestClient.ListNextPage(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SubParentWithNonResChWithLocResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.MgmtListMethods/subParentWithNonResChWithLocs/{subParentWithNonResChWithLocName}
        /// Operation Id: SubParentWithNonResChWithLocs_Get
        /// </summary>
        /// <param name="subParentWithNonResChWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subParentWithNonResChWithLocName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subParentWithNonResChWithLocName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string subParentWithNonResChWithLocName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subParentWithNonResChWithLocName, nameof(subParentWithNonResChWithLocName));

            using var scope = _subParentWithNonResChWithLocClientDiagnostics.CreateScope("SubParentWithNonResChWithLocCollection.Exists");
            scope.Start();
            try
            {
                var response = await _subParentWithNonResChWithLocRestClient.GetAsync(Id.SubscriptionId, subParentWithNonResChWithLocName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.MgmtListMethods/subParentWithNonResChWithLocs/{subParentWithNonResChWithLocName}
        /// Operation Id: SubParentWithNonResChWithLocs_Get
        /// </summary>
        /// <param name="subParentWithNonResChWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subParentWithNonResChWithLocName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subParentWithNonResChWithLocName"/> is null. </exception>
        public virtual Response<bool> Exists(string subParentWithNonResChWithLocName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subParentWithNonResChWithLocName, nameof(subParentWithNonResChWithLocName));

            using var scope = _subParentWithNonResChWithLocClientDiagnostics.CreateScope("SubParentWithNonResChWithLocCollection.Exists");
            scope.Start();
            try
            {
                var response = _subParentWithNonResChWithLocRestClient.Get(Id.SubscriptionId, subParentWithNonResChWithLocName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SubParentWithNonResChWithLocResource> IEnumerable<SubParentWithNonResChWithLocResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SubParentWithNonResChWithLocResource> IAsyncEnumerable<SubParentWithNonResChWithLocResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
