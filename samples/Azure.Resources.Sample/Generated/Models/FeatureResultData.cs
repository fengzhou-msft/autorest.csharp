// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Resources
{
    /// <summary> A class representing the FeatureResult data model. </summary>
    public partial class FeatureResultData : Resource<SubscriptionResourceIdentifier>
    {
        /// <summary> Initializes a new instance of FeatureResultData. </summary>
        internal FeatureResultData()
        {
        }

        /// <summary> Initializes a new instance of FeatureResultData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="properties"> Properties of the previewed feature. </param>
        internal FeatureResultData(SubscriptionResourceIdentifier id, string name, ResourceType type, FeatureProperties properties) : base(id, name, type)
        {
            Properties = properties;
        }

        /// <summary> Properties of the previewed feature. </summary>
        public FeatureProperties Properties { get; }
    }
}
