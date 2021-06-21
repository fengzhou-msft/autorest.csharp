// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using System.Threading.Tasks;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.NewResources
{
    /// <summary> A Class representing a PolicyAssignment along with the instance operations that can be performed on it. </summary>
    public class PolicyAssignment : PolicyAssignmentOperations
    {
        /// <summary> Initializes a new instance of the <see cref = "PolicyAssignment"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal PolicyAssignment(ResourceOperationsBase options, PolicyAssignmentData resource) : base(options, resource.Id)
        {
            Data = resource;
        }

        /// <summary> Gets or sets the PolicyAssignmentData. </summary>
        public PolicyAssignmentData Data { get; private set; }

        /// <inheritdoc />
        protected override PolicyAssignment GetResource(CancellationToken cancellation = default)
        {
            return this;
        }

        /// <inheritdoc />
        protected override Task<PolicyAssignment> GetResourceAsync(CancellationToken cancellation = default)
        {
            return Task.FromResult(this);
        }
    }
}
