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

namespace TenantOnly
{
    /// <summary> A class representing collection of Agreement and their operations over its parent. </summary>
    public partial class AgreementCollection : ArmCollection, IEnumerable<Agreement>, IAsyncEnumerable<Agreement>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly AgreementsRestOperations _agreementsRestClient;

        /// <summary> Initializes a new instance of the <see cref="AgreementCollection"/> class for mocking. </summary>
        protected AgreementCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AgreementCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal AgreementCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _agreementsRestClient = new AgreementsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != BillingAccount.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, BillingAccount.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /providers/Microsoft.Billing/billingAccounts/{billingAccountName}/agreements/{agreementName}
        /// ContextualPath: /providers/Microsoft.Billing/billingAccounts/{billingAccountName}
        /// OperationId: Agreements_Get
        /// <summary> Gets an agreement by ID. </summary>
        /// <param name="agreementName"> The ID that uniquely identifies an agreement. </param>
        /// <param name="expand"> May be used to expand the participants. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="agreementName"/> is null. </exception>
        public virtual Response<Agreement> Get(string agreementName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (agreementName == null)
            {
                throw new ArgumentNullException(nameof(agreementName));
            }

            using var scope = _clientDiagnostics.CreateScope("AgreementCollection.Get");
            scope.Start();
            try
            {
                var response = _agreementsRestClient.Get(Id.Name, agreementName, expand, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new Agreement(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /providers/Microsoft.Billing/billingAccounts/{billingAccountName}/agreements/{agreementName}
        /// ContextualPath: /providers/Microsoft.Billing/billingAccounts/{billingAccountName}
        /// OperationId: Agreements_Get
        /// <summary> Gets an agreement by ID. </summary>
        /// <param name="agreementName"> The ID that uniquely identifies an agreement. </param>
        /// <param name="expand"> May be used to expand the participants. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="agreementName"/> is null. </exception>
        public async virtual Task<Response<Agreement>> GetAsync(string agreementName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (agreementName == null)
            {
                throw new ArgumentNullException(nameof(agreementName));
            }

            using var scope = _clientDiagnostics.CreateScope("AgreementCollection.Get");
            scope.Start();
            try
            {
                var response = await _agreementsRestClient.GetAsync(Id.Name, agreementName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new Agreement(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="agreementName"> The ID that uniquely identifies an agreement. </param>
        /// <param name="expand"> May be used to expand the participants. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="agreementName"/> is null. </exception>
        public virtual Response<Agreement> GetIfExists(string agreementName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (agreementName == null)
            {
                throw new ArgumentNullException(nameof(agreementName));
            }

            using var scope = _clientDiagnostics.CreateScope("AgreementCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _agreementsRestClient.Get(Id.Name, agreementName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<Agreement>(null, response.GetRawResponse());
                return Response.FromValue(new Agreement(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="agreementName"> The ID that uniquely identifies an agreement. </param>
        /// <param name="expand"> May be used to expand the participants. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="agreementName"/> is null. </exception>
        public async virtual Task<Response<Agreement>> GetIfExistsAsync(string agreementName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (agreementName == null)
            {
                throw new ArgumentNullException(nameof(agreementName));
            }

            using var scope = _clientDiagnostics.CreateScope("AgreementCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _agreementsRestClient.GetAsync(Id.Name, agreementName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<Agreement>(null, response.GetRawResponse());
                return Response.FromValue(new Agreement(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="agreementName"> The ID that uniquely identifies an agreement. </param>
        /// <param name="expand"> May be used to expand the participants. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="agreementName"/> is null. </exception>
        public virtual Response<bool> Exists(string agreementName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (agreementName == null)
            {
                throw new ArgumentNullException(nameof(agreementName));
            }

            using var scope = _clientDiagnostics.CreateScope("AgreementCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(agreementName, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="agreementName"> The ID that uniquely identifies an agreement. </param>
        /// <param name="expand"> May be used to expand the participants. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="agreementName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string agreementName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (agreementName == null)
            {
                throw new ArgumentNullException(nameof(agreementName));
            }

            using var scope = _clientDiagnostics.CreateScope("AgreementCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(agreementName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /providers/Microsoft.Billing/billingAccounts/{billingAccountName}/agreements
        /// ContextualPath: /providers/Microsoft.Billing/billingAccounts/{billingAccountName}
        /// OperationId: Agreements_List
        /// <summary> Gets an agreement by ID. </summary>
        /// <param name="expand"> May be used to expand the participants. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="Agreement" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<Agreement> GetAll(string expand = null, CancellationToken cancellationToken = default)
        {
            Page<Agreement> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AgreementCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _agreementsRestClient.List(Id.Name, expand, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Agreement(this, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// RequestPath: /providers/Microsoft.Billing/billingAccounts/{billingAccountName}/agreements
        /// ContextualPath: /providers/Microsoft.Billing/billingAccounts/{billingAccountName}
        /// OperationId: Agreements_List
        /// <summary> Gets an agreement by ID. </summary>
        /// <param name="expand"> May be used to expand the participants. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="Agreement" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<Agreement> GetAllAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<Agreement>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AgreementCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _agreementsRestClient.ListAsync(Id.Name, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Agreement(this, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        IEnumerator<Agreement> IEnumerable<Agreement>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<Agreement> IAsyncEnumerable<Agreement>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, Agreement, AgreementData> Construct() { }
    }
}
