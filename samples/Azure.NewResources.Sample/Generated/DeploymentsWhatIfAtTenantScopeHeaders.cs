// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;

namespace Azure.ResourceManager.NewResources
{
    internal partial class DeploymentsWhatIfAtTenantScopeHeaders
    {
        private readonly Response _response;
        public DeploymentsWhatIfAtTenantScopeHeaders(Response response)
        {
            _response = response;
        }
        /// <summary> URL to get status of this long-running operation. </summary>
        public string Location => _response.Headers.TryGetValue("Location", out string value) ? value : null;
        /// <summary> Number of seconds to wait before polling for status. </summary>
        public string RetryAfter => _response.Headers.TryGetValue("Retry-After", out string value) ? value : null;
    }
}
