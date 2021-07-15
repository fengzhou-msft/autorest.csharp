// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Sample
{
    /// <summary> A Class representing a ProximityPlacementGroup along with the instance operations that can be performed on it. </summary>
    public class ProximityPlacementGroup : ProximityPlacementGroupOperations
    {
        /// <summary> Initializes a new instance of the <see cref = "ProximityPlacementGroup"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal ProximityPlacementGroup(OperationsBase options, ProximityPlacementGroupData resource) : base(options, resource.Id)
        {
            Data = resource;
        }

        /// <summary> Gets or sets the ProximityPlacementGroupData. </summary>
        public ProximityPlacementGroupData Data { get; private set; }
    }
}
