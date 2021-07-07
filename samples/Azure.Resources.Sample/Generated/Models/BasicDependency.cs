// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Resources
{
    /// <summary> Deployment dependency information. </summary>
    public partial class BasicDependency : SubResource<ResourceIdentifier>
    {
        /// <summary> Initializes a new instance of BasicDependency. </summary>
        internal BasicDependency()
        {
        }

        /// <summary> Initializes a new instance of BasicDependency. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="resourceType"> The dependency resource type. </param>
        /// <param name="resourceName"> The dependency resource name. </param>
        internal BasicDependency(string id, string resourceType, string resourceName) : base(id)
        {
            ResourceType = resourceType;
            ResourceName = resourceName;
        }

        /// <summary> The dependency resource type. </summary>
        public string ResourceType { get; }
        /// <summary> The dependency resource name. </summary>
        public string ResourceName { get; }
    }
}
