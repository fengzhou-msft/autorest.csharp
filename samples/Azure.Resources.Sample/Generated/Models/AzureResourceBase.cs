// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Resources
{
    /// <summary> Common properties for all Azure resources. </summary>
    public partial class AzureResourceBase : SubResource<ResourceGroupResourceIdentifier>
    {
        /// <summary> Initializes a new instance of AzureResourceBase. </summary>
        public AzureResourceBase()
        {
        }

        /// <summary> Initializes a new instance of AzureResourceBase. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> Name of this resource. </param>
        /// <param name="type"> Type of this resource. </param>
        internal AzureResourceBase(string id, string name, string type) : base(id)
        {
            Name = name;
            Type = type;
        }

        /// <summary> Name of this resource. </summary>
        public string Name { get; }
        /// <summary> Type of this resource. </summary>
        public string Type { get; }
    }
}
