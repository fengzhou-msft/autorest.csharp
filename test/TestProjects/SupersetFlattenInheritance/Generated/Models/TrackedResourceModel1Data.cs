// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.ResourceManager.Core;

namespace SupersetFlattenInheritance
{
    /// <summary> A class representing the TrackedResourceModel1 data model. </summary>
    public partial class TrackedResourceModel1Data : TrackedResource<ResourceGroupResourceIdentifier>
    {
        /// <summary> Initializes a new instance of TrackedResourceModel1Data. </summary>
        /// <param name="location"> The location. </param>
        public TrackedResourceModel1Data(Location location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of TrackedResourceModel1Data. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="location"> The location. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="foo"> . </param>
        internal TrackedResourceModel1Data(ResourceGroupResourceIdentifier id, string name, ResourceType type, Location location, IDictionary<string, string> tags, string foo) : base(id, name, type, location, tags)
        {
            Foo = foo;
        }

        public string Foo { get; set; }
    }
}
