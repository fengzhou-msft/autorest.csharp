// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;
using TenantOnly.Models;

namespace TenantOnly
{
    /// <summary> A class representing collection of BillingAccount and their operations over a Tenant. </summary>
    public partial class BillingAccountContainer : ResourceContainer
    {
        /// <summary> Initializes a new instance of the <see cref="BillingAccountContainer"/> class for mocking. </summary>
        protected BillingAccountContainer()
        {
        }

        /// <summary> Initializes a new instance of BillingAccountContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal BillingAccountContainer(ResourceOperations parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private BillingAccountsRestOperations _restClient => new BillingAccountsRestOperations(_clientDiagnostics, Pipeline, BaseUri);

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceIdentifier.RootResourceIdentifier.ResourceType;

        // Container level operations.

        /// <summary> Updates the properties of a billing account. Currently, displayName and address can be updated. The operation is supported only for billing accounts with agreement type Microsoft Customer Agreement. </summary>
        /// <param name="billingAccountName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="parameters"> Request parameters that are provided to the update billing account operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual Response<BillingAccount> CreateOrUpdate(string billingAccountName, BillingAccountData parameters, CancellationToken cancellationToken = default)
        {
            if (billingAccountName == null)
            {
                throw new ArgumentNullException(nameof(billingAccountName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("BillingAccountContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = StartCreateOrUpdate(billingAccountName, parameters, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates the properties of a billing account. Currently, displayName and address can be updated. The operation is supported only for billing accounts with agreement type Microsoft Customer Agreement. </summary>
        /// <param name="billingAccountName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="parameters"> Request parameters that are provided to the update billing account operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<Response<BillingAccount>> CreateOrUpdateAsync(string billingAccountName, BillingAccountData parameters, CancellationToken cancellationToken = default)
        {
            if (billingAccountName == null)
            {
                throw new ArgumentNullException(nameof(billingAccountName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("BillingAccountContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = await StartCreateOrUpdateAsync(billingAccountName, parameters, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates the properties of a billing account. Currently, displayName and address can be updated. The operation is supported only for billing accounts with agreement type Microsoft Customer Agreement. </summary>
        /// <param name="billingAccountName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="parameters"> Request parameters that are provided to the update billing account operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual BillingAccountsCreateOperation StartCreateOrUpdate(string billingAccountName, BillingAccountData parameters, CancellationToken cancellationToken = default)
        {
            if (billingAccountName == null)
            {
                throw new ArgumentNullException(nameof(billingAccountName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("BillingAccountContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.Create(billingAccountName, parameters, cancellationToken);
                return new BillingAccountsCreateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateRequest(billingAccountName, parameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates the properties of a billing account. Currently, displayName and address can be updated. The operation is supported only for billing accounts with agreement type Microsoft Customer Agreement. </summary>
        /// <param name="billingAccountName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="parameters"> Request parameters that are provided to the update billing account operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<BillingAccountsCreateOperation> StartCreateOrUpdateAsync(string billingAccountName, BillingAccountData parameters, CancellationToken cancellationToken = default)
        {
            if (billingAccountName == null)
            {
                throw new ArgumentNullException(nameof(billingAccountName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("BillingAccountContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateAsync(billingAccountName, parameters, cancellationToken).ConfigureAwait(false);
                return new BillingAccountsCreateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateRequest(billingAccountName, parameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="billingAccountName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="expand"> May be used to expand the soldTo, invoice sections and billing profiles. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<BillingAccount> Get(string billingAccountName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BillingAccountContainer.Get");
            scope.Start();
            try
            {
                if (billingAccountName == null)
                {
                    throw new ArgumentNullException(nameof(billingAccountName));
                }

                var response = _restClient.Get(billingAccountName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BillingAccount(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="billingAccountName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="expand"> May be used to expand the soldTo, invoice sections and billing profiles. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<BillingAccount>> GetAsync(string billingAccountName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BillingAccountContainer.Get");
            scope.Start();
            try
            {
                if (billingAccountName == null)
                {
                    throw new ArgumentNullException(nameof(billingAccountName));
                }

                var response = await _restClient.GetAsync(billingAccountName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new BillingAccount(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="billingAccountName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="expand"> May be used to expand the soldTo, invoice sections and billing profiles. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<BillingAccount> GetIfExists(string billingAccountName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BillingAccountContainer.GetIfExists");
            scope.Start();
            try
            {
                if (billingAccountName == null)
                {
                    throw new ArgumentNullException(nameof(billingAccountName));
                }

                var response = _restClient.Get(billingAccountName, expand, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<BillingAccount>(null, response.GetRawResponse())
                    : Response.FromValue(new BillingAccount(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="billingAccountName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="expand"> May be used to expand the soldTo, invoice sections and billing profiles. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<BillingAccount>> GetIfExistsAsync(string billingAccountName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BillingAccountContainer.GetIfExists");
            scope.Start();
            try
            {
                if (billingAccountName == null)
                {
                    throw new ArgumentNullException(nameof(billingAccountName));
                }

                var response = await _restClient.GetAsync(billingAccountName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<BillingAccount>(null, response.GetRawResponse())
                    : Response.FromValue(new BillingAccount(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="billingAccountName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="expand"> May be used to expand the soldTo, invoice sections and billing profiles. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<bool> CheckIfExists(string billingAccountName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BillingAccountContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (billingAccountName == null)
                {
                    throw new ArgumentNullException(nameof(billingAccountName));
                }

                var response = GetIfExists(billingAccountName, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="billingAccountName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="expand"> May be used to expand the soldTo, invoice sections and billing profiles. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string billingAccountName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BillingAccountContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (billingAccountName == null)
                {
                    throw new ArgumentNullException(nameof(billingAccountName));
                }

                var response = await GetIfExistsAsync(billingAccountName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="BillingAccount" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResourceExpanded> GetAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BillingAccountContainer.GetAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(BillingAccountOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="BillingAccount" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResourceExpanded> GetAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BillingAccountContainer.GetAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(BillingAccountOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<ResourceIdentifier, BillingAccount, BillingAccountData> Construct() { }
    }
}
