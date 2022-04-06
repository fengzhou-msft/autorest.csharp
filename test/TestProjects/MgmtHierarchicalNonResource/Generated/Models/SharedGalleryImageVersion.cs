// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace MgmtHierarchicalNonResource.Models
{
    /// <summary> Specifies information about the gallery image version that you want to create or update. </summary>
    public partial class SharedGalleryImageVersion : PirSharedGalleryResource
    {
        /// <summary> Initializes a new instance of SharedGalleryImageVersion. </summary>
        internal SharedGalleryImageVersion()
        {
        }

        /// <summary> Initializes a new instance of SharedGalleryImageVersion. </summary>
        /// <param name="name"> Resource name. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="uniqueId"> The unique id of this shared gallery. </param>
        /// <param name="publishedOn"> The published date of the gallery image version Definition. This property can be used for decommissioning purposes. This property is updatable. </param>
        /// <param name="endOfLifeOn"> The end of life date of the gallery image version Definition. This property can be used for decommissioning purposes. This property is updatable. </param>
        internal SharedGalleryImageVersion(string name, string location, string uniqueId, DateTimeOffset? publishedOn, DateTimeOffset? endOfLifeOn) : base(name, location, uniqueId)
        {
            PublishedOn = publishedOn;
            EndOfLifeOn = endOfLifeOn;
        }

        /// <summary> The published date of the gallery image version Definition. This property can be used for decommissioning purposes. This property is updatable. </summary>
        public DateTimeOffset? PublishedOn { get; }
        /// <summary> The end of life date of the gallery image version Definition. This property can be used for decommissioning purposes. This property is updatable. </summary>
        public DateTimeOffset? EndOfLifeOn { get; }
    }
}
