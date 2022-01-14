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
using Azure.ResourceManager.Core;
using MgmtExpandResourceTypes.Models;

namespace MgmtExpandResourceTypes
{
    /// <summary> A class representing collection of RecordSet and their operations over its parent. </summary>
    public partial class RecordSetNsCollection : ArmCollection, IEnumerable<RecordSetNs>, IAsyncEnumerable<RecordSetNs>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly RecordSetsRestOperations _recordSetsRestClient;

        /// <summary> Initializes a new instance of the <see cref="RecordSetNsCollection"/> class for mocking. </summary>
        protected RecordSetNsCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="RecordSetNsCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal RecordSetNsCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _recordSetsRestClient = new RecordSetsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != Zone.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, Zone.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsZones/{zoneName}/{recordType}/{relativeRecordSetName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsZones/{zoneName}
        /// OperationId: RecordSets_CreateOrUpdate
        /// <summary> Creates or updates a record set within a DNS zone. </summary>
        /// <param name="relativeRecordSetName"> The name of the record set, relative to the name of the zone. </param>
        /// <param name="parameters"> Parameters supplied to the CreateOrUpdate operation. </param>
        /// <param name="ifMatch"> The etag of the record set. Omit this value to always overwrite the current record set. Specify the last-seen etag value to prevent accidentally overwriting any concurrent changes. </param>
        /// <param name="ifNoneMatch"> Set to &apos;*&apos; to allow a new record set to be created, but to prevent updating an existing record set. Other values will be ignored. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="relativeRecordSetName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual RecordSetNsCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string relativeRecordSetName, RecordSetData parameters, string ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            if (relativeRecordSetName == null)
            {
                throw new ArgumentNullException(nameof(relativeRecordSetName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("RecordSetNsCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _recordSetsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, "NS".ToRecordType(), relativeRecordSetName, parameters, ifMatch, ifNoneMatch, cancellationToken);
                var operation = new RecordSetNsCreateOrUpdateOperation(Parent, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsZones/{zoneName}/{recordType}/{relativeRecordSetName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsZones/{zoneName}
        /// OperationId: RecordSets_CreateOrUpdate
        /// <summary> Creates or updates a record set within a DNS zone. </summary>
        /// <param name="relativeRecordSetName"> The name of the record set, relative to the name of the zone. </param>
        /// <param name="parameters"> Parameters supplied to the CreateOrUpdate operation. </param>
        /// <param name="ifMatch"> The etag of the record set. Omit this value to always overwrite the current record set. Specify the last-seen etag value to prevent accidentally overwriting any concurrent changes. </param>
        /// <param name="ifNoneMatch"> Set to &apos;*&apos; to allow a new record set to be created, but to prevent updating an existing record set. Other values will be ignored. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="relativeRecordSetName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<RecordSetNsCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string relativeRecordSetName, RecordSetData parameters, string ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            if (relativeRecordSetName == null)
            {
                throw new ArgumentNullException(nameof(relativeRecordSetName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("RecordSetNsCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _recordSetsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, "NS".ToRecordType(), relativeRecordSetName, parameters, ifMatch, ifNoneMatch, cancellationToken).ConfigureAwait(false);
                var operation = new RecordSetNsCreateOrUpdateOperation(Parent, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsZones/{zoneName}/{recordType}/{relativeRecordSetName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsZones/{zoneName}
        /// OperationId: RecordSets_Get
        /// <summary> Gets a record set. </summary>
        /// <param name="relativeRecordSetName"> The name of the record set, relative to the name of the zone. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="relativeRecordSetName"/> is null. </exception>
        public virtual Response<RecordSetNs> Get(string relativeRecordSetName, CancellationToken cancellationToken = default)
        {
            if (relativeRecordSetName == null)
            {
                throw new ArgumentNullException(nameof(relativeRecordSetName));
            }

            using var scope = _clientDiagnostics.CreateScope("RecordSetNsCollection.Get");
            scope.Start();
            try
            {
                var response = _recordSetsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, "NS".ToRecordType(), relativeRecordSetName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RecordSetNs(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsZones/{zoneName}/{recordType}/{relativeRecordSetName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsZones/{zoneName}
        /// OperationId: RecordSets_Get
        /// <summary> Gets a record set. </summary>
        /// <param name="relativeRecordSetName"> The name of the record set, relative to the name of the zone. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="relativeRecordSetName"/> is null. </exception>
        public async virtual Task<Response<RecordSetNs>> GetAsync(string relativeRecordSetName, CancellationToken cancellationToken = default)
        {
            if (relativeRecordSetName == null)
            {
                throw new ArgumentNullException(nameof(relativeRecordSetName));
            }

            using var scope = _clientDiagnostics.CreateScope("RecordSetNsCollection.Get");
            scope.Start();
            try
            {
                var response = await _recordSetsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, "NS".ToRecordType(), relativeRecordSetName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new RecordSetNs(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="relativeRecordSetName"> The name of the record set, relative to the name of the zone. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="relativeRecordSetName"/> is null. </exception>
        public virtual Response<RecordSetNs> GetIfExists(string relativeRecordSetName, CancellationToken cancellationToken = default)
        {
            if (relativeRecordSetName == null)
            {
                throw new ArgumentNullException(nameof(relativeRecordSetName));
            }

            using var scope = _clientDiagnostics.CreateScope("RecordSetNsCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _recordSetsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, "NS".ToRecordType(), relativeRecordSetName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<RecordSetNs>(null, response.GetRawResponse());
                return Response.FromValue(new RecordSetNs(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="relativeRecordSetName"> The name of the record set, relative to the name of the zone. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="relativeRecordSetName"/> is null. </exception>
        public async virtual Task<Response<RecordSetNs>> GetIfExistsAsync(string relativeRecordSetName, CancellationToken cancellationToken = default)
        {
            if (relativeRecordSetName == null)
            {
                throw new ArgumentNullException(nameof(relativeRecordSetName));
            }

            using var scope = _clientDiagnostics.CreateScope("RecordSetNsCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _recordSetsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, "NS".ToRecordType(), relativeRecordSetName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<RecordSetNs>(null, response.GetRawResponse());
                return Response.FromValue(new RecordSetNs(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="relativeRecordSetName"> The name of the record set, relative to the name of the zone. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="relativeRecordSetName"/> is null. </exception>
        public virtual Response<bool> Exists(string relativeRecordSetName, CancellationToken cancellationToken = default)
        {
            if (relativeRecordSetName == null)
            {
                throw new ArgumentNullException(nameof(relativeRecordSetName));
            }

            using var scope = _clientDiagnostics.CreateScope("RecordSetNsCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(relativeRecordSetName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="relativeRecordSetName"> The name of the record set, relative to the name of the zone. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="relativeRecordSetName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string relativeRecordSetName, CancellationToken cancellationToken = default)
        {
            if (relativeRecordSetName == null)
            {
                throw new ArgumentNullException(nameof(relativeRecordSetName));
            }

            using var scope = _clientDiagnostics.CreateScope("RecordSetNsCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(relativeRecordSetName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsZones/{zoneName}/{recordType}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsZones/{zoneName}
        /// OperationId: RecordSets_ListByType
        /// <summary> Lists the record sets of a specified type in a DNS zone. </summary>
        /// <param name="top"> The maximum number of record sets to return. If not specified, returns up to 100 record sets. </param>
        /// <param name="recordsetnamesuffix"> The suffix label of the record set name that has to be used to filter the record set enumerations. If this parameter is specified, Enumeration will return only records that end with .&lt;recordSetNameSuffix&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RecordSetNs" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RecordSetNs> GetAll(int? top = null, string recordsetnamesuffix = null, CancellationToken cancellationToken = default)
        {
            Page<RecordSetNs> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RecordSetNsCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _recordSetsRestClient.ListByType(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, "NS".ToRecordType(), top, recordsetnamesuffix, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new RecordSetNs(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<RecordSetNs> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RecordSetNsCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _recordSetsRestClient.ListByTypeNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, "NS".ToRecordType(), top, recordsetnamesuffix, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new RecordSetNs(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsZones/{zoneName}/{recordType}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/dnsZones/{zoneName}
        /// OperationId: RecordSets_ListByType
        /// <summary> Lists the record sets of a specified type in a DNS zone. </summary>
        /// <param name="top"> The maximum number of record sets to return. If not specified, returns up to 100 record sets. </param>
        /// <param name="recordsetnamesuffix"> The suffix label of the record set name that has to be used to filter the record set enumerations. If this parameter is specified, Enumeration will return only records that end with .&lt;recordSetNameSuffix&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RecordSetNs" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RecordSetNs> GetAllAsync(int? top = null, string recordsetnamesuffix = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<RecordSetNs>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RecordSetNsCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _recordSetsRestClient.ListByTypeAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, "NS".ToRecordType(), top, recordsetnamesuffix, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new RecordSetNs(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<RecordSetNs>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RecordSetNsCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _recordSetsRestClient.ListByTypeNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, "NS".ToRecordType(), top, recordsetnamesuffix, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new RecordSetNs(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<RecordSetNs> IEnumerable<RecordSetNs>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<RecordSetNs> IAsyncEnumerable<RecordSetNs>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, RecordSetNs, RecordSetData> Construct() { }
    }
}
