// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace MgmtLRO
{
    /// <summary> A class to add extension methods to Tenant. </summary>
    public static partial class TenantExtensions
    {
        #region Fake
        /// <summary> Gets an object representing a Fake along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="tenant"> The <see cref="Tenant" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="Fake" /> object. </returns>
        public static Fake GetFake(this Tenant tenant, ResourceIdentifier id)
        {
            return new Fake(tenant, id);
        }
        #endregion

        #region Bar
        /// <summary> Gets an object representing a Bar along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="tenant"> The <see cref="Tenant" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="Bar" /> object. </returns>
        public static Bar GetBar(this Tenant tenant, ResourceIdentifier id)
        {
            return new Bar(tenant, id);
        }
        #endregion
    }
}
