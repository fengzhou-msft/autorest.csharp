// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using System.Threading.Tasks;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Resources
{
    /// <summary> A Class representing a ResourceGroup along with the instance operations that can be performed on it. </summary>
    public class ResourceGroup : ResourceGroupOperations
    {
        /// <summary> Initializes a new instance of the <see cref = "ResourceGroup"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal ResourceGroup(ResourceOperationsBase options, ResourceGroupData resource) : base(options, resource.Id)
        {
            Data = resource;
        }

        /// <summary> Gets or sets the ResourceGroupData. </summary>
        public ResourceGroupData Data { get; private set; }

        /// <inheritdoc />
        protected override ResourceGroup GetResource(CancellationToken cancellation = default)
        {
            return this;
        }

        /// <inheritdoc />
        protected override Task<ResourceGroup> GetResourceAsync(CancellationToken cancellation = default)
        {
            return Task.FromResult(this);
        }
    }
}
