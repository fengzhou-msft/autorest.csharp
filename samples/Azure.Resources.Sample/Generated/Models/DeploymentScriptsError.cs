// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Resources.Sample
{
    /// <summary> Deployment scripts error response. </summary>
    internal partial class DeploymentScriptsError
    {
        /// <summary> Initializes a new instance of DeploymentScriptsError. </summary>
        internal DeploymentScriptsError()
        {
        }

        /// <summary> Initializes a new instance of DeploymentScriptsError. </summary>
        /// <param name="error"> Common error response for all Azure Resource Manager APIs to return error details for failed operations. (This also follows the OData error response format.). </param>
        internal DeploymentScriptsError(ErrorResponse error)
        {
            Error = error;
        }

        /// <summary> Common error response for all Azure Resource Manager APIs to return error details for failed operations. (This also follows the OData error response format.). </summary>
        public ErrorResponse Error { get; }
    }
}
