// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.ResourceManager.Core;

namespace Azure.Resources.Sample
{
    /// <summary> Resource information. </summary>
    public partial class GenericResource : TrackedResource<ResourceGroupResourceIdentifier>
    {
        /// <summary> Initializes a new instance of GenericResource. </summary>
        /// <param name="location"> The location. </param>
        public GenericResource(Location location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of GenericResource. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="location"> The location. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="managedBy"> ID of the resource that manages this resource. </param>
        /// <param name="sku"> The SKU of the resource. </param>
        internal GenericResource(ResourceGroupResourceIdentifier id, string name, ResourceType type, Location location, IDictionary<string, string> tags, string managedBy, Sku sku) : base(id, name, type, location, tags)
        {
            ManagedBy = managedBy;
            Sku = sku;
        }

        /// <summary> ID of the resource that manages this resource. </summary>
        public string ManagedBy { get; set; }
        /// <summary> The SKU of the resource. </summary>
        public Sku Sku { get; set; }
    }
}
