// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ResourcesForCore.Models
{
    /// <summary> The resource type aliases definition. </summary>
    public partial class ResourceTypeAliases
    {
        /// <summary> Initializes a new instance of ResourceTypeAliases. </summary>
        internal ResourceTypeAliases()
        {
            Aliases = new ChangeTrackingList<Alias>();
        }

        /// <summary> Initializes a new instance of ResourceTypeAliases. </summary>
        /// <param name="resourceType"> The resource type name. </param>
        /// <param name="aliases"> The aliases for property names. </param>
        internal ResourceTypeAliases(string resourceType, IReadOnlyList<Alias> aliases)
        {
            ResourceType = resourceType;
            Aliases = aliases;
        }

        /// <summary> The resource type name. </summary>
        public string ResourceType { get; }
        /// <summary> The aliases for property names. </summary>
        public IReadOnlyList<Alias> Aliases { get; }
    }
}
