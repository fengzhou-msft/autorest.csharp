// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using System.Threading.Tasks;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Resources
{
    /// <summary> A Class representing a ResourceLink along with the instance operations that can be performed on it. </summary>
    public class ResourceLink : ResourceLinkOperations
    {
        /// <summary> Initializes a new instance of the <see cref = "ResourceLink"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal ResourceLink(ResourceOperationsBase options, ResourceLinkData resource) : base(options, resource.Id)
        {
            Data = resource;
        }

        /// <summary> Gets or sets the ResourceLinkData. </summary>
        public ResourceLinkData Data { get; private set; }

        /// <inheritdoc />
        protected override ResourceLink GetResource(CancellationToken cancellation = default)
        {
            return this;
        }

        /// <inheritdoc />
        protected override Task<ResourceLink> GetResourceAsync(CancellationToken cancellation = default)
        {
            return Task.FromResult(this);
        }
    }
}
