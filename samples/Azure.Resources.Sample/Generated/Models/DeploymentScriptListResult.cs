// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Resources.Sample
{
    /// <summary> List of deployment scripts. </summary>
    internal partial class DeploymentScriptListResult
    {
        /// <summary> Initializes a new instance of DeploymentScriptListResult. </summary>
        internal DeploymentScriptListResult()
        {
            Value = new ChangeTrackingList<DeploymentScriptData>();
        }

        /// <summary> Initializes a new instance of DeploymentScriptListResult. </summary>
        /// <param name="value"> An array of deployment scripts. </param>
        /// <param name="nextLink"> The URL to use for getting the next set of results. </param>
        internal DeploymentScriptListResult(IReadOnlyList<DeploymentScriptData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> An array of deployment scripts. </summary>
        public IReadOnlyList<DeploymentScriptData> Value { get; }
        /// <summary> The URL to use for getting the next set of results. </summary>
        public string NextLink { get; }
    }
}
