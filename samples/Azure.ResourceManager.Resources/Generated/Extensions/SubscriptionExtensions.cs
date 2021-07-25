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
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Resources
{
    /// <summary> A class to add extension methods to Subscription. </summary>
    public static partial class SubscriptionExtensions
    {
        #region PolicyDefinition
        /// <summary> Gets an object representing a PolicyDefinitionContainer along with the instance operations that can be performed on it. </summary>
        /// <param name="subscription"> The <see cref="SubscriptionOperations" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="PolicyDefinitionContainer" /> object. </returns>
        public static PolicyDefinitionContainer GetPolicyDefinitionContainer(this SubscriptionOperations subscription)
        {
            return new PolicyDefinitionContainer(subscription);
        }
        #endregion

        #region PolicySetDefinition
        /// <summary> Gets an object representing a PolicySetDefinitionContainer along with the instance operations that can be performed on it. </summary>
        /// <param name="subscription"> The <see cref="SubscriptionOperations" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="PolicySetDefinitionContainer" /> object. </returns>
        public static PolicySetDefinitionContainer GetPolicySetDefinitionContainer(this SubscriptionOperations subscription)
        {
            return new PolicySetDefinitionContainer(subscription);
        }
        #endregion

        #region DeploymentScript
        private static DeploymentScriptsRestOperations GetDeploymentScriptsRestOperations(ClientDiagnostics clientDiagnostics, TokenCredential credential, ArmClientOptions clientOptions, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            return new DeploymentScriptsRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint);
        }

        /// <summary> Lists the DeploymentScripts for this <see cref="SubscriptionOperations" />. </summary>
        /// <param name="subscription"> The <see cref="SubscriptionOperations" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<DeploymentScript> ListDeploymentScriptsAsync(this SubscriptionOperations subscription, CancellationToken cancellationToken = default)
        {
            return subscription.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                var restOperations = GetDeploymentScriptsRestOperations(clientDiagnostics, credential, options, pipeline, subscription.Id.SubscriptionId, baseUri);
                async Task<Page<DeploymentScript>> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.ListDeploymentScripts");
                    scope.Start();
                    try
                    {
                        var response = await restOperations.ListBySubscriptionAsync(cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value.Select(value => new DeploymentScript(subscription, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                async Task<Page<DeploymentScript>> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.ListDeploymentScripts");
                    scope.Start();
                    try
                    {
                        var response = await restOperations.ListBySubscriptionNextPageAsync(nextLink, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value.Select(value => new DeploymentScript(subscription, value)), response.Value.NextLink, response.GetRawResponse());
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

        /// <summary> Lists the DeploymentScripts for this <see cref="SubscriptionOperations" />. </summary>
        /// <param name="subscription"> The <see cref="SubscriptionOperations" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static Pageable<DeploymentScript> ListDeploymentScripts(this SubscriptionOperations subscription, CancellationToken cancellationToken = default)
        {
            return subscription.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                var restOperations = GetDeploymentScriptsRestOperations(clientDiagnostics, credential, options, pipeline, subscription.Id.SubscriptionId, baseUri);
                Page<DeploymentScript> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.ListDeploymentScripts");
                    scope.Start();
                    try
                    {
                        var response = restOperations.ListBySubscription(cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value.Select(value => new DeploymentScript(subscription, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                Page<DeploymentScript> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.ListDeploymentScripts");
                    scope.Start();
                    try
                    {
                        var response = restOperations.ListBySubscriptionNextPage(nextLink, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value.Select(value => new DeploymentScript(subscription, value)), response.Value.NextLink, response.GetRawResponse());
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

        /// <summary> Lists the DeploymentScripts for this <see cref="SubscriptionOperations" />. </summary>
        /// <param name="subscription"> The <see cref="SubscriptionOperations" /> instance the method will execute against. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> is null. </exception>
        public static AsyncPageable<DeploymentScript> ListDeploymentScriptsAsync(this SubscriptionOperations subscription, string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            return subscription.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                var restOperations = GetDeploymentScriptsRestOperations(clientDiagnostics, credential, options, pipeline, subscription.Id.SubscriptionId, baseUri);
                async Task<Page<DeploymentScript>> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.ListDeploymentScripts");
                    scope.Start();
                    try
                    {
                        var response = await restOperations.ListByResourceGroupAsync(resourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value.Select(value => new DeploymentScript(subscription, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                async Task<Page<DeploymentScript>> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.ListDeploymentScripts");
                    scope.Start();
                    try
                    {
                        var response = await restOperations.ListByResourceGroupNextPageAsync(nextLink, resourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value.Select(value => new DeploymentScript(subscription, value)), response.Value.NextLink, response.GetRawResponse());
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

        /// <summary> Lists the DeploymentScripts for this <see cref="SubscriptionOperations" />. </summary>
        /// <param name="subscription"> The <see cref="SubscriptionOperations" /> instance the method will execute against. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> is null. </exception>
        public static Pageable<DeploymentScript> ListDeploymentScripts(this SubscriptionOperations subscription, string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            return subscription.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                var restOperations = GetDeploymentScriptsRestOperations(clientDiagnostics, credential, options, pipeline, subscription.Id.SubscriptionId, baseUri);
                Page<DeploymentScript> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.ListDeploymentScripts");
                    scope.Start();
                    try
                    {
                        var response = restOperations.ListByResourceGroup(resourceGroupName, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value.Select(value => new DeploymentScript(subscription, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                Page<DeploymentScript> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.ListDeploymentScripts");
                    scope.Start();
                    try
                    {
                        var response = restOperations.ListByResourceGroupNextPage(nextLink, resourceGroupName, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value.Select(value => new DeploymentScript(subscription, value)), response.Value.NextLink, response.GetRawResponse());
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

        /// <summary> Filters the list of DeploymentScripts for a <see cref="SubscriptionOperations" /> represented as generic resources. </summary>
        /// <param name="subscription"> The <see cref="SubscriptionOperations" /> instance the method will execute against. </param>
        /// <param name="filter"> The string to filter the list. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<Core.GenericResourceExpanded> ListDeploymentScriptByNameAsync(this SubscriptionOperations subscription, string filter, string expand, int? top, CancellationToken cancellationToken = default)
        {
            ResourceFilterCollection filters = new(DeploymentScriptOperations.ResourceType);
            filters.SubstringFilter = filter;
            return ResourceListOperations.ListAtContextAsync(subscription, filters, expand, top, cancellationToken);
        }

        /// <summary> Filters the list of DeploymentScripts for a <see cref="SubscriptionOperations" /> represented as generic resources. </summary>
        /// <param name="subscription"> The <see cref="SubscriptionOperations" /> instance the method will execute against. </param>
        /// <param name="filter"> The string to filter the list. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static Pageable<Core.GenericResourceExpanded> ListDeploymentScriptByName(this SubscriptionOperations subscription, string filter, string expand, int? top, CancellationToken cancellationToken = default)
        {
            ResourceFilterCollection filters = new(DeploymentScriptOperations.ResourceType);
            filters.SubstringFilter = filter;
            return ResourceListOperations.ListAtContext(subscription, filters, expand, top, cancellationToken);
        }
        #endregion

        #region Application
        private static ApplicationsRestOperations GetApplicationsRestOperations(ClientDiagnostics clientDiagnostics, TokenCredential credential, ArmClientOptions clientOptions, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            return new ApplicationsRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint);
        }

        /// <summary> Lists the Applications for this <see cref="SubscriptionOperations" />. </summary>
        /// <param name="subscription"> The <see cref="SubscriptionOperations" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<Application> ListApplicationsAsync(this SubscriptionOperations subscription, CancellationToken cancellationToken = default)
        {
            return subscription.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                var restOperations = GetApplicationsRestOperations(clientDiagnostics, credential, options, pipeline, subscription.Id.SubscriptionId, baseUri);
                async Task<Page<Application>> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.ListApplications");
                    scope.Start();
                    try
                    {
                        var response = await restOperations.ListBySubscriptionAsync(cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value.Select(value => new Application(subscription, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                async Task<Page<Application>> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.ListApplications");
                    scope.Start();
                    try
                    {
                        var response = await restOperations.ListBySubscriptionNextPageAsync(nextLink, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value.Select(value => new Application(subscription, value)), response.Value.NextLink, response.GetRawResponse());
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

        /// <summary> Lists the Applications for this <see cref="SubscriptionOperations" />. </summary>
        /// <param name="subscription"> The <see cref="SubscriptionOperations" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static Pageable<Application> ListApplications(this SubscriptionOperations subscription, CancellationToken cancellationToken = default)
        {
            return subscription.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                var restOperations = GetApplicationsRestOperations(clientDiagnostics, credential, options, pipeline, subscription.Id.SubscriptionId, baseUri);
                Page<Application> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.ListApplications");
                    scope.Start();
                    try
                    {
                        var response = restOperations.ListBySubscription(cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value.Select(value => new Application(subscription, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                Page<Application> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.ListApplications");
                    scope.Start();
                    try
                    {
                        var response = restOperations.ListBySubscriptionNextPage(nextLink, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value.Select(value => new Application(subscription, value)), response.Value.NextLink, response.GetRawResponse());
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

        /// <summary> Filters the list of Applications for a <see cref="SubscriptionOperations" /> represented as generic resources. </summary>
        /// <param name="subscription"> The <see cref="SubscriptionOperations" /> instance the method will execute against. </param>
        /// <param name="filter"> The string to filter the list. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<Core.GenericResourceExpanded> ListApplicationByNameAsync(this SubscriptionOperations subscription, string filter, string expand, int? top, CancellationToken cancellationToken = default)
        {
            ResourceFilterCollection filters = new(ApplicationOperations.ResourceType);
            filters.SubstringFilter = filter;
            return ResourceListOperations.ListAtContextAsync(subscription, filters, expand, top, cancellationToken);
        }

        /// <summary> Filters the list of Applications for a <see cref="SubscriptionOperations" /> represented as generic resources. </summary>
        /// <param name="subscription"> The <see cref="SubscriptionOperations" /> instance the method will execute against. </param>
        /// <param name="filter"> The string to filter the list. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static Pageable<Core.GenericResourceExpanded> ListApplicationByName(this SubscriptionOperations subscription, string filter, string expand, int? top, CancellationToken cancellationToken = default)
        {
            ResourceFilterCollection filters = new(ApplicationOperations.ResourceType);
            filters.SubstringFilter = filter;
            return ResourceListOperations.ListAtContext(subscription, filters, expand, top, cancellationToken);
        }
        #endregion

        #region JitRequestDefinition
        private static JitRequestsRestOperations GetJitRequestsRestOperations(ClientDiagnostics clientDiagnostics, TokenCredential credential, ArmClientOptions clientOptions, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            return new JitRequestsRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint);
        }

        /// <summary> Retrieves all JIT requests within the subscription. </summary>
        /// <param name="subscription"> The <see cref="SubscriptionOperations" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public static async Task<Response<IReadOnlyList<JitRequestDefinition>>> ListJitRequestDefinitionsAsync(this SubscriptionOperations subscription, CancellationToken cancellationToken = default)
        {
            return await subscription.UseClientContext(async (baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                var restOperations = GetJitRequestsRestOperations(clientDiagnostics, credential, options, pipeline, subscription.Id.SubscriptionId, baseUri);
                using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.ListJitRequestDefinitions");
                scope.Start();
                try
                {
                    var response = await restOperations.ListBySubscriptionAsync(cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(response.Value.Value.Select(data => new JitRequestDefinition(subscription, data)).ToArray() as IReadOnlyList<JitRequestDefinition>, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            ).ConfigureAwait(false);
        }

        /// <summary> Retrieves all JIT requests within the subscription. </summary>
        /// <param name="subscription"> The <see cref="SubscriptionOperations" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public static Response<IReadOnlyList<JitRequestDefinition>> ListJitRequestDefinitions(this SubscriptionOperations subscription, CancellationToken cancellationToken = default)
        {
            return subscription.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                var restOperations = GetJitRequestsRestOperations(clientDiagnostics, credential, options, pipeline, subscription.Id.SubscriptionId, baseUri);
                using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.ListJitRequestDefinitions");
                scope.Start();
                try
                {
                    var response = restOperations.ListBySubscription(cancellationToken);
                    return Response.FromValue(response.Value.Value.Select(data => new JitRequestDefinition(subscription, data)).ToArray() as IReadOnlyList<JitRequestDefinition>, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            );
        }

        /// <summary> Filters the list of JitRequestDefinitions for a <see cref="SubscriptionOperations" /> represented as generic resources. </summary>
        /// <param name="subscription"> The <see cref="SubscriptionOperations" /> instance the method will execute against. </param>
        /// <param name="filter"> The string to filter the list. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<Core.GenericResourceExpanded> ListJitRequestDefinitionByNameAsync(this SubscriptionOperations subscription, string filter, string expand, int? top, CancellationToken cancellationToken = default)
        {
            ResourceFilterCollection filters = new(JitRequestDefinitionOperations.ResourceType);
            filters.SubstringFilter = filter;
            return ResourceListOperations.ListAtContextAsync(subscription, filters, expand, top, cancellationToken);
        }

        /// <summary> Filters the list of JitRequestDefinitions for a <see cref="SubscriptionOperations" /> represented as generic resources. </summary>
        /// <param name="subscription"> The <see cref="SubscriptionOperations" /> instance the method will execute against. </param>
        /// <param name="filter"> The string to filter the list. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static Pageable<Core.GenericResourceExpanded> ListJitRequestDefinitionByName(this SubscriptionOperations subscription, string filter, string expand, int? top, CancellationToken cancellationToken = default)
        {
            ResourceFilterCollection filters = new(JitRequestDefinitionOperations.ResourceType);
            filters.SubstringFilter = filter;
            return ResourceListOperations.ListAtContext(subscription, filters, expand, top, cancellationToken);
        }
        #endregion
    }
}
