// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Resources
{
    /// <summary> A class representing the operations that can be performed over a specific PolicyAssignment. </summary>
    public partial class PolicyAssignmentOperations : OperationsBase
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private PolicyAssignmentsRestOperations _restClient { get; }

        /// <summary> Initializes a new instance of the <see cref="PolicyAssignmentOperations"/> class for mocking. </summary>
        protected PolicyAssignmentOperations()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PolicyAssignmentOperations"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        protected internal PolicyAssignmentOperations(OperationsBase options, TenantResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new PolicyAssignmentsRestOperations(_clientDiagnostics, Pipeline, BaseUri);
        }

        public static readonly ResourceType ResourceType = "Microsoft.Authorization/policyAssignments";
        protected override ResourceType ValidResourceType => ResourceType;

        /// <summary> This operation retrieves a single policy assignment, given its name and the scope it was created at. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<PolicyAssignment>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyAssignmentOperations.Get");
            scope.Start();
            try
            {
                var response = await _restClient.GetAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new PolicyAssignment(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation retrieves a single policy assignment, given its name and the scope it was created at. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<PolicyAssignment> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyAssignmentOperations.Get");
            scope.Start();
            try
            {
                var response = _restClient.Get(Id.Parent, Id.Name, cancellationToken);
                return Response.FromValue(new PolicyAssignment(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation deletes a policy assignment, given its name and the scope it was created in. The scope of a policy assignment is the part of its ID preceding &apos;/providers/Microsoft.Authorization/policyAssignments/{policyAssignmentName}&apos;. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<PolicyAssignmentData>> DeleteAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyAssignmentOperations.Delete");
            scope.Start();
            try
            {
                var operation = await StartDeleteAsync(cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation deletes a policy assignment, given its name and the scope it was created in. The scope of a policy assignment is the part of its ID preceding &apos;/providers/Microsoft.Authorization/policyAssignments/{policyAssignmentName}&apos;. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<PolicyAssignmentData> Delete(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyAssignmentOperations.Delete");
            scope.Start();
            try
            {
                var operation = StartDelete(cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation deletes a policy assignment, given its name and the scope it was created in. The scope of a policy assignment is the part of its ID preceding &apos;/providers/Microsoft.Authorization/policyAssignments/{policyAssignmentName}&apos;. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<PolicyAssignmentsDeleteOperation> StartDeleteAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyAssignmentOperations.StartDelete");
            scope.Start();
            try
            {
                var response = await _restClient.DeleteAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                return new PolicyAssignmentsDeleteOperation(response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation deletes a policy assignment, given its name and the scope it was created in. The scope of a policy assignment is the part of its ID preceding &apos;/providers/Microsoft.Authorization/policyAssignments/{policyAssignmentName}&apos;. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public PolicyAssignmentsDeleteOperation StartDelete(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyAssignmentOperations.StartDelete");
            scope.Start();
            try
            {
                var response = _restClient.Delete(Id.Parent, Id.Name, cancellationToken);
                return new PolicyAssignmentsDeleteOperation(response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> This operation deletes the policy with the given ID. Policy assignment IDs have this format: &apos;{scope}/providers/Microsoft.Authorization/policyAssignments/{policyAssignmentName}&apos;. Valid formats for {scope} are: &apos;/providers/Microsoft.Management/managementGroups/{managementGroup}&apos; (management group), &apos;/subscriptions/{subscriptionId}&apos; (subscription), &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}&apos; (resource group), or &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/[{parentResourcePath}/]{resourceType}/{resourceName}&apos; (resource). </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PolicyAssignmentData>> DeleteByIdAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyAssignmentOperations.DeleteById");
            scope.Start();
            try
            {
                var response = await _restClient.DeleteByIdAsync(Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> This operation deletes the policy with the given ID. Policy assignment IDs have this format: &apos;{scope}/providers/Microsoft.Authorization/policyAssignments/{policyAssignmentName}&apos;. Valid formats for {scope} are: &apos;/providers/Microsoft.Management/managementGroups/{managementGroup}&apos; (management group), &apos;/subscriptions/{subscriptionId}&apos; (subscription), &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}&apos; (resource group), or &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/[{parentResourcePath}/]{resourceType}/{resourceName}&apos; (resource). </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PolicyAssignmentData> DeleteById(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyAssignmentOperations.DeleteById");
            scope.Start();
            try
            {
                var response = _restClient.DeleteById(Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation retrieves the policy assignment with the given ID. Policy assignment IDs have this format: &apos;{scope}/providers/Microsoft.Authorization/policyAssignments/{policyAssignmentName}&apos;. Valid scopes are: management group (format: &apos;/providers/Microsoft.Management/managementGroups/{managementGroup}&apos;), subscription (format: &apos;/subscriptions/{subscriptionId}&apos;), resource group (format: &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}&apos;, or resource (format: &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/[{parentResourcePath}/]{resourceType}/{resourceName}&apos;. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PolicyAssignmentData>> GetByIdAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyAssignmentOperations.GetById");
            scope.Start();
            try
            {
                var response = await _restClient.GetByIdAsync(Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation retrieves the policy assignment with the given ID. Policy assignment IDs have this format: &apos;{scope}/providers/Microsoft.Authorization/policyAssignments/{policyAssignmentName}&apos;. Valid scopes are: management group (format: &apos;/providers/Microsoft.Management/managementGroups/{managementGroup}&apos;), subscription (format: &apos;/subscriptions/{subscriptionId}&apos;), resource group (format: &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}&apos;, or resource (format: &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/[{parentResourcePath}/]{resourceType}/{resourceName}&apos;. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PolicyAssignmentData> GetById(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PolicyAssignmentOperations.GetById");
            scope.Start();
            try
            {
                var response = _restClient.GetById(Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
