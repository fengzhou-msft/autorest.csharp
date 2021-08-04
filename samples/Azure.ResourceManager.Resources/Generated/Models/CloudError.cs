// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> An error response for a resource management request. </summary>
    internal partial class CloudError
    {
        /// <summary> Initializes a new instance of CloudError. </summary>
        internal CloudError()
        {
        }

        /// <summary> Initializes a new instance of CloudError. </summary>
        /// <param name="errorResponse"> Common error response for all Azure Resource Manager APIs to return error details for failed operations. (This also follows the OData error response format.). </param>
        internal CloudError(ErrorResponse errorResponse)
        {
            ErrorResponse = errorResponse;
        }

        /// <summary> Common error response for all Azure Resource Manager APIs to return error details for failed operations. (This also follows the OData error response format.). </summary>
        public ErrorResponse ErrorResponse { get; }
    }
}
