// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;

namespace MgmtSingleton
{
    /// <summary> The Resource model definition. </summary>
    public partial class Resource : SubResource<ResourceGroupResourceIdentifier>
    {
        /// <summary> Initializes a new instance of Resource. </summary>
        public Resource()
        {
        }

        /// <summary> Initializes a new instance of Resource. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        internal Resource(string id, string name, string type) : base(id)
        {
            Name = name;
            Type = type;
        }

        /// <summary> Resource name. </summary>
        public string Name { get; }
        /// <summary> Resource type. </summary>
        public string Type { get; }
    }
}
