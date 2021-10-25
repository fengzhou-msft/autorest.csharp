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
using Azure.Management.Storage.Models;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;

namespace Azure.Management.Storage
{
    /// <summary> A class to add extension methods to Subscription. </summary>
    public static partial class SubscriptionExtensions
    {
        private static SkusRestOperations GetSkusRestOperations(ClientDiagnostics clientDiagnostics, TokenCredential credential, ArmClientOptions clientOptions, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            return new SkusRestOperations(clientDiagnostics, pipeline, clientOptions, subscriptionId, endpoint);
        }

        private static StorageAccountsRestOperations GetStorageAccountsRestOperations(ClientDiagnostics clientDiagnostics, TokenCredential credential, ArmClientOptions clientOptions, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            return new StorageAccountsRestOperations(clientDiagnostics, pipeline, clientOptions, subscriptionId, endpoint);
        }

        private static UsagesRestOperations GetUsagesRestOperations(ClientDiagnostics clientDiagnostics, TokenCredential credential, ArmClientOptions clientOptions, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            return new UsagesRestOperations(clientDiagnostics, pipeline, clientOptions, subscriptionId, endpoint);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Storage/skus
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: Skus_List
        /// <summary> Lists the SkuInformations for this <see cref="Subscription" />. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<SkuInformation> GetSkusAsync(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return subscription.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                var restOperations = GetSkusRestOperations(clientDiagnostics, credential, options, pipeline, subscription.Id.SubscriptionId, baseUri);
                async Task<Page<SkuInformation>> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetSkus");
                    scope.Start();
                    try
                    {
                        var response = await restOperations.ListAsync(cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
            }
            );
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Storage/skus
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: Skus_List
        /// <summary> Lists the SkuInformations for this <see cref="Subscription" />. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static Pageable<SkuInformation> GetSkus(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return subscription.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                var restOperations = GetSkusRestOperations(clientDiagnostics, credential, options, pipeline, subscription.Id.SubscriptionId, baseUri);
                Page<SkuInformation> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetSkus");
                    scope.Start();
                    try
                    {
                        var response = restOperations.List(cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
            }
            );
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Storage/checkNameAvailability
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: StorageAccounts_CheckNameAvailability
        /// <summary> Checks that the storage account name is valid and is not already in use. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public static async Task<Response<CheckNameAvailabilityResult>> CheckNameAvailabilityStorageAccountAsync(this Subscription subscription, StorageAccountCheckNameAvailabilityParameters accountName, CancellationToken cancellationToken = default)
        {
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }

            return await subscription.UseClientContext(async (baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.CheckNameAvailabilityStorageAccount");
                scope.Start();
                try
                {
                    var restOperations = GetStorageAccountsRestOperations(clientDiagnostics, credential, options, pipeline, subscription.Id.SubscriptionId, baseUri);
                    var response = await restOperations.CheckNameAvailabilityAsync(accountName, cancellationToken).ConfigureAwait(false);
                    return response;
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            ).ConfigureAwait(false);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Storage/checkNameAvailability
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: StorageAccounts_CheckNameAvailability
        /// <summary> Checks that the storage account name is valid and is not already in use. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="accountName"> The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public static Response<CheckNameAvailabilityResult> CheckNameAvailabilityStorageAccount(this Subscription subscription, StorageAccountCheckNameAvailabilityParameters accountName, CancellationToken cancellationToken = default)
        {
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }

            return subscription.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.CheckNameAvailabilityStorageAccount");
                scope.Start();
                try
                {
                    var restOperations = GetStorageAccountsRestOperations(clientDiagnostics, credential, options, pipeline, subscription.Id.SubscriptionId, baseUri);
                    var response = restOperations.CheckNameAvailability(accountName, cancellationToken);
                    return response;
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            );
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Storage/storageAccounts
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: StorageAccounts_List
        /// <summary> Lists the StorageAccounts for this <see cref="Subscription" />. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<StorageAccount> GetStorageAccountsAsync(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return subscription.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                var restOperations = GetStorageAccountsRestOperations(clientDiagnostics, credential, options, pipeline, subscription.Id.SubscriptionId, baseUri);
                async Task<Page<StorageAccount>> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetStorageAccounts");
                    scope.Start();
                    try
                    {
                        var response = await restOperations.ListAsync(cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value.Select(value => new StorageAccount(subscription, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                async Task<Page<StorageAccount>> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetStorageAccounts");
                    scope.Start();
                    try
                    {
                        var response = await restOperations.ListNextPageAsync(nextLink, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value.Select(value => new StorageAccount(subscription, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
            }
            );
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Storage/storageAccounts
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: StorageAccounts_List
        /// <summary> Lists the StorageAccounts for this <see cref="Subscription" />. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static Pageable<StorageAccount> GetStorageAccounts(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return subscription.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                var restOperations = GetStorageAccountsRestOperations(clientDiagnostics, credential, options, pipeline, subscription.Id.SubscriptionId, baseUri);
                Page<StorageAccount> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetStorageAccounts");
                    scope.Start();
                    try
                    {
                        var response = restOperations.List(cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value.Select(value => new StorageAccount(subscription, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                Page<StorageAccount> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetStorageAccounts");
                    scope.Start();
                    try
                    {
                        var response = restOperations.ListNextPage(nextLink, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value.Select(value => new StorageAccount(subscription, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
            }
            );
        }

        /// <summary> Filters the list of StorageAccounts for a <see cref="Subscription" /> represented as generic resources. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="filter"> The string to filter the list. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<GenericResource> GetStorageAccountByNameAsync(this Subscription subscription, string filter, string expand, int? top, CancellationToken cancellationToken = default)
        {
            ResourceFilterCollection filters = new(StorageAccount.ResourceType);
            filters.SubstringFilter = filter;
            return ResourceListOperations.GetAtContextAsync(subscription, filters, expand, top, cancellationToken);
        }

        /// <summary> Filters the list of StorageAccounts for a <see cref="Subscription" /> represented as generic resources. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="filter"> The string to filter the list. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static Pageable<GenericResource> GetStorageAccountByName(this Subscription subscription, string filter, string expand, int? top, CancellationToken cancellationToken = default)
        {
            ResourceFilterCollection filters = new(StorageAccount.ResourceType);
            filters.SubstringFilter = filter;
            return ResourceListOperations.GetAtContext(subscription, filters, expand, top, cancellationToken);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Storage/locations/{location}/usages
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: Usages_ListByLocation
        /// <summary> Lists the Usages for this <see cref="Subscription" />. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="location"> The location of the Azure Storage resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        public static AsyncPageable<Usage> GetByLocationUsagesAsync(this Subscription subscription, string location, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }

            return subscription.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                var restOperations = GetUsagesRestOperations(clientDiagnostics, credential, options, pipeline, subscription.Id.SubscriptionId, baseUri);
                async Task<Page<Usage>> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetByLocationUsages");
                    scope.Start();
                    try
                    {
                        var response = await restOperations.ListByLocationAsync(location, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
            }
            );
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Storage/locations/{location}/usages
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: Usages_ListByLocation
        /// <summary> Lists the Usages for this <see cref="Subscription" />. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="location"> The location of the Azure Storage resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        public static Pageable<Usage> GetByLocationUsages(this Subscription subscription, string location, CancellationToken cancellationToken = default)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }

            return subscription.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                var restOperations = GetUsagesRestOperations(clientDiagnostics, credential, options, pipeline, subscription.Id.SubscriptionId, baseUri);
                Page<Usage> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetByLocationUsages");
                    scope.Start();
                    try
                    {
                        var response = restOperations.ListByLocation(location, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
            }
            );
        }
    }
}
