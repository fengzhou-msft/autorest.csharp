// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace MgmtExtensionResource
{
    /// <summary> A class to add extension methods to Tenant. </summary>
    public static partial class TenantExtensions
    {
        #region PolicyDefinition
        /// <summary> Gets an object representing a PolicyDefinition along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="tenant"> The <see cref="Tenant" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PolicyDefinition" /> object. </returns>
        public static PolicyDefinition GetPolicyDefinition(this Tenant tenant, ResourceIdentifier id)
        {
            return new PolicyDefinition(tenant, id);
        }
        #endregion
    }
}
