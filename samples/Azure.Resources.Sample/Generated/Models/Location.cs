// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Location information. </summary>
    public partial class Location
    {
        /// <summary> Initializes a new instance of Location. </summary>
        internal Location()
        {
        }

        /// <summary> The fully qualified ID of the location. For example, /subscriptions/00000000-0000-0000-0000-000000000000/locations/westus. </summary>
        public string Id { get; }
        /// <summary> The subscription ID. </summary>
        public string SubscriptionId { get; }
        /// <summary> The location name. </summary>
        public string Name { get; }
        /// <summary> The location type. </summary>
        public LocationType? Type { get; }
        /// <summary> The display name of the location. </summary>
        public string DisplayName { get; }
        /// <summary> The display name of the location and its region. </summary>
        public string RegionalDisplayName { get; }
        /// <summary> Metadata of the location, such as lat/long, paired region, and others. </summary>
        public LocationMetadata Metadata { get; }
    }
}
