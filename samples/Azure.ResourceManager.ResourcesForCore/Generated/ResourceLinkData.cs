// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.ResourcesForCore.Models;

namespace Azure.ResourceManager.ResourcesForCore
{
    /// <summary> A class representing the ResourceLink data model. </summary>
    public partial class ResourceLinkData : SubResource
    {
        /// <summary> Initializes a new instance of ResourceLinkData. </summary>
        public ResourceLinkData()
        {
        }

        /// <summary> Initializes a new instance of ResourceLinkData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name of the resource link. </param>
        /// <param name="type"> The resource link object. </param>
        /// <param name="properties"> Properties for resource link. </param>
        internal ResourceLinkData(string id, string name, object type, ResourceLinkProperties properties) : base(id)
        {
            Name = name;
            Type = type;
            Properties = properties;
        }

        /// <summary> The name of the resource link. </summary>
        public string Name { get; }
        /// <summary> The resource link object. </summary>
        public object Type { get; }
        /// <summary> Properties for resource link. </summary>
        public ResourceLinkProperties Properties { get; set; }
    }
}
