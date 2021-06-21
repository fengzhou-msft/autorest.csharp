// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using System.Threading.Tasks;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.NewResources
{
    /// <summary> A Class representing a PolicySetDefinition along with the instance operations that can be performed on it. </summary>
    public class PolicySetDefinition : PolicySetDefinitionOperations
    {
        /// <summary> Initializes a new instance of the <see cref = "PolicySetDefinition"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal PolicySetDefinition(ResourceOperationsBase options, PolicySetDefinitionData resource) : base(options, resource.Id)
        {
            Data = resource;
        }

        /// <summary> Gets or sets the PolicySetDefinitionData. </summary>
        public PolicySetDefinitionData Data { get; private set; }

        /// <inheritdoc />
        protected override PolicySetDefinition GetResource(CancellationToken cancellation = default)
        {
            return this;
        }

        /// <inheritdoc />
        protected override Task<PolicySetDefinition> GetResourceAsync(CancellationToken cancellation = default)
        {
            return Task.FromResult(this);
        }
    }
}
