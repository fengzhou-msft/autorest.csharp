// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Resources.Sample
{
    /// <summary> List of managed application definitions. </summary>
    internal partial class ApplicationDefinitionListResult
    {
        /// <summary> Initializes a new instance of ApplicationDefinitionListResult. </summary>
        internal ApplicationDefinitionListResult()
        {
            Value = new ChangeTrackingList<ApplicationDefinitionData>();
        }

        /// <summary> Initializes a new instance of ApplicationDefinitionListResult. </summary>
        /// <param name="value"> The array of managed application definitions. </param>
        /// <param name="nextLink"> The URL to use for getting the next set of results. </param>
        internal ApplicationDefinitionListResult(IReadOnlyList<ApplicationDefinitionData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The array of managed application definitions. </summary>
        public IReadOnlyList<ApplicationDefinitionData> Value { get; }
        /// <summary> The URL to use for getting the next set of results. </summary>
        public string NextLink { get; }
    }
}
