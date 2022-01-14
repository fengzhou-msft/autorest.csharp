// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Resources
{
    /// <summary> A class representing collection of PolicySetDefinition and their operations over its parent. </summary>
    public partial class TenantPolicySetDefinitionCollection : ArmCollection, IEnumerable<TenantPolicySetDefinition>, IAsyncEnumerable<TenantPolicySetDefinition>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly PolicySetDefinitionsRestOperations _policySetDefinitionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="TenantPolicySetDefinitionCollection"/> class for mocking. </summary>
        protected TenantPolicySetDefinitionCollection()
        {
        }

        /// <summary> Initializes a new instance of TenantPolicySetDefinitionCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal TenantPolicySetDefinitionCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _policySetDefinitionsRestClient = new PolicySetDefinitionsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => Tenant.ResourceType;

        // Collection level operations.

        /// <summary> This operation retrieves the built-in policy set definition with the given name. </summary>
        /// <param name="policySetDefinitionName"> The name of the policy set definition to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="policySetDefinitionName"/> is null. </exception>
        public virtual Response<TenantPolicySetDefinition> Get(string policySetDefinitionName, CancellationToken cancellationToken = default)
        {
            if (policySetDefinitionName == null)
            {
                throw new ArgumentNullException(nameof(policySetDefinitionName));
            }

            using var scope = _clientDiagnostics.CreateScope("TenantPolicySetDefinitionCollection.Get");
            scope.Start();
            try
            {
                var response = _policySetDefinitionsRestClient.GetBuiltIn(policySetDefinitionName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TenantPolicySetDefinition(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation retrieves the built-in policy set definition with the given name. </summary>
        /// <param name="policySetDefinitionName"> The name of the policy set definition to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="policySetDefinitionName"/> is null. </exception>
        public async virtual Task<Response<TenantPolicySetDefinition>> GetAsync(string policySetDefinitionName, CancellationToken cancellationToken = default)
        {
            if (policySetDefinitionName == null)
            {
                throw new ArgumentNullException(nameof(policySetDefinitionName));
            }

            using var scope = _clientDiagnostics.CreateScope("TenantPolicySetDefinitionCollection.Get");
            scope.Start();
            try
            {
                var response = await _policySetDefinitionsRestClient.GetBuiltInAsync(policySetDefinitionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new TenantPolicySetDefinition(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="policySetDefinitionName"> The name of the policy set definition to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="policySetDefinitionName"/> is null. </exception>
        public virtual Response<TenantPolicySetDefinition> GetIfExists(string policySetDefinitionName, CancellationToken cancellationToken = default)
        {
            if (policySetDefinitionName == null)
            {
                throw new ArgumentNullException(nameof(policySetDefinitionName));
            }

            using var scope = _clientDiagnostics.CreateScope("TenantPolicySetDefinitionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _policySetDefinitionsRestClient.GetBuiltIn(policySetDefinitionName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<TenantPolicySetDefinition>(null, response.GetRawResponse())
                    : Response.FromValue(new TenantPolicySetDefinition(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="policySetDefinitionName"> The name of the policy set definition to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="policySetDefinitionName"/> is null. </exception>
        public async virtual Task<Response<TenantPolicySetDefinition>> GetIfExistsAsync(string policySetDefinitionName, CancellationToken cancellationToken = default)
        {
            if (policySetDefinitionName == null)
            {
                throw new ArgumentNullException(nameof(policySetDefinitionName));
            }

            using var scope = _clientDiagnostics.CreateScope("TenantPolicySetDefinitionCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _policySetDefinitionsRestClient.GetBuiltInAsync(policySetDefinitionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<TenantPolicySetDefinition>(null, response.GetRawResponse())
                    : Response.FromValue(new TenantPolicySetDefinition(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="policySetDefinitionName"> The name of the policy set definition to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="policySetDefinitionName"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string policySetDefinitionName, CancellationToken cancellationToken = default)
        {
            if (policySetDefinitionName == null)
            {
                throw new ArgumentNullException(nameof(policySetDefinitionName));
            }

            using var scope = _clientDiagnostics.CreateScope("TenantPolicySetDefinitionCollection.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(policySetDefinitionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="policySetDefinitionName"> The name of the policy set definition to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="policySetDefinitionName"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string policySetDefinitionName, CancellationToken cancellationToken = default)
        {
            if (policySetDefinitionName == null)
            {
                throw new ArgumentNullException(nameof(policySetDefinitionName));
            }

            using var scope = _clientDiagnostics.CreateScope("TenantPolicySetDefinitionCollection.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(policySetDefinitionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation retrieves a list of all the built-in policy set definitions that match the optional given $filter. If $filter=&apos;category -eq {value}&apos; is provided, the returned list only includes all built-in policy set definitions whose category match the {value}. </summary>
        /// <param name="filter"> The filter to apply on the operation. Valid values for $filter are: &apos;atExactScope()&apos;, &apos;policyType -eq {value}&apos; or &apos;category eq &apos;{value}&apos;&apos;. If $filter is not provided, no filtering is performed. If $filter=atExactScope() is provided, the returned list only includes all policy set definitions that at the given scope. If $filter=&apos;policyType -eq {value}&apos; is provided, the returned list only includes all policy set definitions whose type match the {value}. Possible policyType values are NotSpecified, BuiltIn, Custom, and Static. If $filter=&apos;category -eq {value}&apos; is provided, the returned list only includes all policy set definitions whose category match the {value}. </param>
        /// <param name="top"> Maximum number of records to return. When the $top filter is not provided, it will return 500 records. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="TenantPolicySetDefinition" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<TenantPolicySetDefinition> GetAll(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            Page<TenantPolicySetDefinition> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("TenantPolicySetDefinitionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _policySetDefinitionsRestClient.ListBuiltIn(filter, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new TenantPolicySetDefinition(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<TenantPolicySetDefinition> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("TenantPolicySetDefinitionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _policySetDefinitionsRestClient.ListBuiltInNextPage(nextLink, filter, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new TenantPolicySetDefinition(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> This operation retrieves a list of all the built-in policy set definitions that match the optional given $filter. If $filter=&apos;category -eq {value}&apos; is provided, the returned list only includes all built-in policy set definitions whose category match the {value}. </summary>
        /// <param name="filter"> The filter to apply on the operation. Valid values for $filter are: &apos;atExactScope()&apos;, &apos;policyType -eq {value}&apos; or &apos;category eq &apos;{value}&apos;&apos;. If $filter is not provided, no filtering is performed. If $filter=atExactScope() is provided, the returned list only includes all policy set definitions that at the given scope. If $filter=&apos;policyType -eq {value}&apos; is provided, the returned list only includes all policy set definitions whose type match the {value}. Possible policyType values are NotSpecified, BuiltIn, Custom, and Static. If $filter=&apos;category -eq {value}&apos; is provided, the returned list only includes all policy set definitions whose category match the {value}. </param>
        /// <param name="top"> Maximum number of records to return. When the $top filter is not provided, it will return 500 records. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="TenantPolicySetDefinition" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<TenantPolicySetDefinition> GetAllAsync(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<TenantPolicySetDefinition>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("TenantPolicySetDefinitionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _policySetDefinitionsRestClient.ListBuiltInAsync(filter, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new TenantPolicySetDefinition(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<TenantPolicySetDefinition>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("TenantPolicySetDefinitionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _policySetDefinitionsRestClient.ListBuiltInNextPageAsync(nextLink, filter, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new TenantPolicySetDefinition(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<TenantPolicySetDefinition> IEnumerable<TenantPolicySetDefinition>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<TenantPolicySetDefinition> IAsyncEnumerable<TenantPolicySetDefinition>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, TenantPolicySetDefinition, PolicySetDefinitionData> Construct() { }
    }
}
