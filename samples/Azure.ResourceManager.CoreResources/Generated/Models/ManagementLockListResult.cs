// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.CoreResources;

namespace Azure.ResourceManager.CoreResources.Models
{
    /// <summary> The list of locks. </summary>
    internal partial class ManagementLockListResult
    {
        /// <summary> Initializes a new instance of ManagementLockListResult. </summary>
        internal ManagementLockListResult()
        {
            Value = new ChangeTrackingList<ManagementLockObjectData>();
        }

        /// <summary> Initializes a new instance of ManagementLockListResult. </summary>
        /// <param name="value"> The list of locks. </param>
        /// <param name="nextLink"> The URL to use for getting the next set of results. </param>
        internal ManagementLockListResult(IReadOnlyList<ManagementLockObjectData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of locks. </summary>
        public IReadOnlyList<ManagementLockObjectData> Value { get; }
        /// <summary> The URL to use for getting the next set of results. </summary>
        public string NextLink { get; }
    }
}
