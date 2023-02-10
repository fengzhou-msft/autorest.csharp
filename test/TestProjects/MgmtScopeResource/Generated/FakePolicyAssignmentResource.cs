// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace MgmtScopeResource
{
    /// <summary>
    /// A Class representing a FakePolicyAssignment along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="FakePolicyAssignmentResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetFakePolicyAssignmentResource method.
    /// Otherwise you can get one from its parent resource <see cref="ArmResource" /> using the GetFakePolicyAssignment method.
    /// </summary>
    public partial class FakePolicyAssignmentResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="FakePolicyAssignmentResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string scope, string policyAssignmentName)
        {
            var resourceId = $"{scope}/providers/Microsoft.Authorization/policyAssignments/{policyAssignmentName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _fakePolicyAssignmentClientDiagnostics;
        private readonly FakePolicyAssignmentsRestOperations _fakePolicyAssignmentRestClient;
        private readonly FakePolicyAssignmentData _data;

        /// <summary> Initializes a new instance of the <see cref="FakePolicyAssignmentResource"/> class for mocking. </summary>
        protected FakePolicyAssignmentResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "FakePolicyAssignmentResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal FakePolicyAssignmentResource(ArmClient client, FakePolicyAssignmentData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="FakePolicyAssignmentResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal FakePolicyAssignmentResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _fakePolicyAssignmentClientDiagnostics = new ClientDiagnostics("MgmtScopeResource", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string fakePolicyAssignmentApiVersion);
            _fakePolicyAssignmentRestClient = new FakePolicyAssignmentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, fakePolicyAssignmentApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Authorization/policyAssignments";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual FakePolicyAssignmentData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// This operation retrieves a single policy assignment, given its name and the scope it was created at.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/policyAssignments/{policyAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FakePolicyAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<FakePolicyAssignmentResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _fakePolicyAssignmentClientDiagnostics.CreateScope("FakePolicyAssignmentResource.Get");
            scope.Start();
            try
            {
                var response = await _fakePolicyAssignmentRestClient.GetAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FakePolicyAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This operation retrieves a single policy assignment, given its name and the scope it was created at.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/policyAssignments/{policyAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FakePolicyAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<FakePolicyAssignmentResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _fakePolicyAssignmentClientDiagnostics.CreateScope("FakePolicyAssignmentResource.Get");
            scope.Start();
            try
            {
                var response = _fakePolicyAssignmentRestClient.Get(Id.Parent, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FakePolicyAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This operation deletes a policy assignment, given its name and the scope it was created in. The scope of a policy assignment is the part of its ID preceding &apos;/providers/Microsoft.Authorization/policyAssignments/{policyAssignmentName}&apos;.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/policyAssignments/{policyAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FakePolicyAssignments_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation<FakePolicyAssignmentResource>> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _fakePolicyAssignmentClientDiagnostics.CreateScope("FakePolicyAssignmentResource.Delete");
            scope.Start();
            try
            {
                var response = await _fakePolicyAssignmentRestClient.DeleteAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new MgmtScopeResourceArmOperation<FakePolicyAssignmentResource>(Response.FromValue(new FakePolicyAssignmentResource(Client, response), response.GetRawResponse()));
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
        /// This operation deletes a policy assignment, given its name and the scope it was created in. The scope of a policy assignment is the part of its ID preceding &apos;/providers/Microsoft.Authorization/policyAssignments/{policyAssignmentName}&apos;.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/policyAssignments/{policyAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FakePolicyAssignments_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation<FakePolicyAssignmentResource> Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _fakePolicyAssignmentClientDiagnostics.CreateScope("FakePolicyAssignmentResource.Delete");
            scope.Start();
            try
            {
                var response = _fakePolicyAssignmentRestClient.Delete(Id.Parent, Id.Name, cancellationToken);
                var operation = new MgmtScopeResourceArmOperation<FakePolicyAssignmentResource>(Response.FromValue(new FakePolicyAssignmentResource(Client, response), response.GetRawResponse()));
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
        ///  This operation creates or updates a policy assignment with the given scope and name. Policy assignments apply to all resources contained within their scope. For example, when you assign a policy at resource group scope, that policy applies to all resources in the group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/policyAssignments/{policyAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FakePolicyAssignments_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters for the policy assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<FakePolicyAssignmentResource>> UpdateAsync(WaitUntil waitUntil, FakePolicyAssignmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _fakePolicyAssignmentClientDiagnostics.CreateScope("FakePolicyAssignmentResource.Update");
            scope.Start();
            try
            {
                var response = await _fakePolicyAssignmentRestClient.CreateAsync(Id.Parent, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new MgmtScopeResourceArmOperation<FakePolicyAssignmentResource>(Response.FromValue(new FakePolicyAssignmentResource(Client, response), response.GetRawResponse()));
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
        ///  This operation creates or updates a policy assignment with the given scope and name. Policy assignments apply to all resources contained within their scope. For example, when you assign a policy at resource group scope, that policy applies to all resources in the group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/policyAssignments/{policyAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FakePolicyAssignments_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters for the policy assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<FakePolicyAssignmentResource> Update(WaitUntil waitUntil, FakePolicyAssignmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _fakePolicyAssignmentClientDiagnostics.CreateScope("FakePolicyAssignmentResource.Update");
            scope.Start();
            try
            {
                var response = _fakePolicyAssignmentRestClient.Create(Id.Parent, Id.Name, data, cancellationToken);
                var operation = new MgmtScopeResourceArmOperation<FakePolicyAssignmentResource>(Response.FromValue(new FakePolicyAssignmentResource(Client, response), response.GetRawResponse()));
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
    }
}
