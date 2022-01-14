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
using Azure.ResourceManager.Management;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    /// <summary> A class representing collection of PolicyDefinition and their operations over its parent. </summary>
    public partial class ManagementGroupPolicyDefinitionCollection : ArmCollection, IEnumerable<ManagementGroupPolicyDefinition>, IAsyncEnumerable<ManagementGroupPolicyDefinition>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly PolicyDefinitionsRestOperations _policyDefinitionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ManagementGroupPolicyDefinitionCollection"/> class for mocking. </summary>
        protected ManagementGroupPolicyDefinitionCollection()
        {
        }

        /// <summary> Initializes a new instance of ManagementGroupPolicyDefinitionCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal ManagementGroupPolicyDefinitionCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _policyDefinitionsRestClient = new PolicyDefinitionsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ManagementGroup.ResourceType;

        // Collection level operations.

        /// <summary> This operation creates or updates a policy definition in the given management group with the given name. </summary>
        /// <param name="policyDefinitionName"> The name of the policy definition to create. </param>
        /// <param name="parameters"> The policy definition properties. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="policyDefinitionName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual PolicyDefinitionCreateOrUpdateAtManagementGroupOperation CreateOrUpdate(string policyDefinitionName, PolicyDefinitionData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (policyDefinitionName == null)
            {
                throw new ArgumentNullException(nameof(policyDefinitionName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagementGroupPolicyDefinitionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _policyDefinitionsRestClient.CreateOrUpdateAtManagementGroup(Id.Name, policyDefinitionName, parameters, cancellationToken);
                var operation = new PolicyDefinitionCreateOrUpdateAtManagementGroupOperation(Parent, response);
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

        /// <summary> This operation creates or updates a policy definition in the given management group with the given name. </summary>
        /// <param name="policyDefinitionName"> The name of the policy definition to create. </param>
        /// <param name="parameters"> The policy definition properties. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="policyDefinitionName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<PolicyDefinitionCreateOrUpdateAtManagementGroupOperation> CreateOrUpdateAsync(string policyDefinitionName, PolicyDefinitionData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (policyDefinitionName == null)
            {
                throw new ArgumentNullException(nameof(policyDefinitionName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagementGroupPolicyDefinitionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _policyDefinitionsRestClient.CreateOrUpdateAtManagementGroupAsync(Id.Name, policyDefinitionName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new PolicyDefinitionCreateOrUpdateAtManagementGroupOperation(Parent, response);
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

        /// <summary> This operation retrieves the policy definition in the given management group with the given name. </summary>
        /// <param name="policyDefinitionName"> The name of the policy definition to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="policyDefinitionName"/> is null. </exception>
        public virtual Response<ManagementGroupPolicyDefinition> Get(string policyDefinitionName, CancellationToken cancellationToken = default)
        {
            if (policyDefinitionName == null)
            {
                throw new ArgumentNullException(nameof(policyDefinitionName));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagementGroupPolicyDefinitionCollection.Get");
            scope.Start();
            try
            {
                var response = _policyDefinitionsRestClient.GetAtManagementGroup(Id.Name, policyDefinitionName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagementGroupPolicyDefinition(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation retrieves the policy definition in the given management group with the given name. </summary>
        /// <param name="policyDefinitionName"> The name of the policy definition to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="policyDefinitionName"/> is null. </exception>
        public async virtual Task<Response<ManagementGroupPolicyDefinition>> GetAsync(string policyDefinitionName, CancellationToken cancellationToken = default)
        {
            if (policyDefinitionName == null)
            {
                throw new ArgumentNullException(nameof(policyDefinitionName));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagementGroupPolicyDefinitionCollection.Get");
            scope.Start();
            try
            {
                var response = await _policyDefinitionsRestClient.GetAtManagementGroupAsync(Id.Name, policyDefinitionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ManagementGroupPolicyDefinition(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="policyDefinitionName"> The name of the policy definition to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="policyDefinitionName"/> is null. </exception>
        public virtual Response<ManagementGroupPolicyDefinition> GetIfExists(string policyDefinitionName, CancellationToken cancellationToken = default)
        {
            if (policyDefinitionName == null)
            {
                throw new ArgumentNullException(nameof(policyDefinitionName));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagementGroupPolicyDefinitionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _policyDefinitionsRestClient.GetAtManagementGroup(Id.Name, policyDefinitionName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<ManagementGroupPolicyDefinition>(null, response.GetRawResponse())
                    : Response.FromValue(new ManagementGroupPolicyDefinition(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="policyDefinitionName"> The name of the policy definition to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="policyDefinitionName"/> is null. </exception>
        public async virtual Task<Response<ManagementGroupPolicyDefinition>> GetIfExistsAsync(string policyDefinitionName, CancellationToken cancellationToken = default)
        {
            if (policyDefinitionName == null)
            {
                throw new ArgumentNullException(nameof(policyDefinitionName));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagementGroupPolicyDefinitionCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _policyDefinitionsRestClient.GetAtManagementGroupAsync(Id.Name, policyDefinitionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<ManagementGroupPolicyDefinition>(null, response.GetRawResponse())
                    : Response.FromValue(new ManagementGroupPolicyDefinition(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="policyDefinitionName"> The name of the policy definition to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="policyDefinitionName"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string policyDefinitionName, CancellationToken cancellationToken = default)
        {
            if (policyDefinitionName == null)
            {
                throw new ArgumentNullException(nameof(policyDefinitionName));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagementGroupPolicyDefinitionCollection.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(policyDefinitionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="policyDefinitionName"> The name of the policy definition to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="policyDefinitionName"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string policyDefinitionName, CancellationToken cancellationToken = default)
        {
            if (policyDefinitionName == null)
            {
                throw new ArgumentNullException(nameof(policyDefinitionName));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagementGroupPolicyDefinitionCollection.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(policyDefinitionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation retrieves a list of all the policy definitions in a given management group that match the optional given $filter. Valid values for $filter are: &apos;atExactScope()&apos;, &apos;policyType -eq {value}&apos; or &apos;category eq &apos;{value}&apos;&apos;. If $filter is not provided, the unfiltered list includes all policy definitions associated with the management group, including those that apply directly or from management groups that contain the given management group. If $filter=atExactScope() is provided, the returned list only includes all policy definitions that at the given management group. If $filter=&apos;policyType -eq {value}&apos; is provided, the returned list only includes all policy definitions whose type match the {value}. Possible policyType values are NotSpecified, BuiltIn, Custom, and Static. If $filter=&apos;category -eq {value}&apos; is provided, the returned list only includes all policy definitions whose category match the {value}. </summary>
        /// <param name="filter"> The filter to apply on the operation. Valid values for $filter are: &apos;atExactScope()&apos;, &apos;policyType -eq {value}&apos; or &apos;category eq &apos;{value}&apos;&apos;. If $filter is not provided, no filtering is performed. If $filter=atExactScope() is provided, the returned list only includes all policy definitions that at the given scope. If $filter=&apos;policyType -eq {value}&apos; is provided, the returned list only includes all policy definitions whose type match the {value}. Possible policyType values are NotSpecified, BuiltIn, Custom, and Static. If $filter=&apos;category -eq {value}&apos; is provided, the returned list only includes all policy definitions whose category match the {value}. </param>
        /// <param name="top"> Maximum number of records to return. When the $top filter is not provided, it will return 500 records. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ManagementGroupPolicyDefinition" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ManagementGroupPolicyDefinition> GetAll(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            Page<ManagementGroupPolicyDefinition> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagementGroupPolicyDefinitionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _policyDefinitionsRestClient.ListByManagementGroup(Id.Name, filter, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagementGroupPolicyDefinition(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ManagementGroupPolicyDefinition> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagementGroupPolicyDefinitionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _policyDefinitionsRestClient.ListByManagementGroupNextPage(nextLink, Id.Name, filter, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagementGroupPolicyDefinition(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> This operation retrieves a list of all the policy definitions in a given management group that match the optional given $filter. Valid values for $filter are: &apos;atExactScope()&apos;, &apos;policyType -eq {value}&apos; or &apos;category eq &apos;{value}&apos;&apos;. If $filter is not provided, the unfiltered list includes all policy definitions associated with the management group, including those that apply directly or from management groups that contain the given management group. If $filter=atExactScope() is provided, the returned list only includes all policy definitions that at the given management group. If $filter=&apos;policyType -eq {value}&apos; is provided, the returned list only includes all policy definitions whose type match the {value}. Possible policyType values are NotSpecified, BuiltIn, Custom, and Static. If $filter=&apos;category -eq {value}&apos; is provided, the returned list only includes all policy definitions whose category match the {value}. </summary>
        /// <param name="filter"> The filter to apply on the operation. Valid values for $filter are: &apos;atExactScope()&apos;, &apos;policyType -eq {value}&apos; or &apos;category eq &apos;{value}&apos;&apos;. If $filter is not provided, no filtering is performed. If $filter=atExactScope() is provided, the returned list only includes all policy definitions that at the given scope. If $filter=&apos;policyType -eq {value}&apos; is provided, the returned list only includes all policy definitions whose type match the {value}. Possible policyType values are NotSpecified, BuiltIn, Custom, and Static. If $filter=&apos;category -eq {value}&apos; is provided, the returned list only includes all policy definitions whose category match the {value}. </param>
        /// <param name="top"> Maximum number of records to return. When the $top filter is not provided, it will return 500 records. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ManagementGroupPolicyDefinition" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ManagementGroupPolicyDefinition> GetAllAsync(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ManagementGroupPolicyDefinition>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagementGroupPolicyDefinitionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _policyDefinitionsRestClient.ListByManagementGroupAsync(Id.Name, filter, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagementGroupPolicyDefinition(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ManagementGroupPolicyDefinition>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagementGroupPolicyDefinitionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _policyDefinitionsRestClient.ListByManagementGroupNextPageAsync(nextLink, Id.Name, filter, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagementGroupPolicyDefinition(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<ManagementGroupPolicyDefinition> IEnumerable<ManagementGroupPolicyDefinition>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ManagementGroupPolicyDefinition> IAsyncEnumerable<ManagementGroupPolicyDefinition>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, ManagementGroupPolicyDefinition, PolicyDefinitionData> Construct() { }
    }
}
