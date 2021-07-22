// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;

namespace Azure.Management.Storage
{
    /// <summary> A class to add extension methods to ResourceGroup. </summary>
    public static partial class ResourceGroupExtensions
    {
        #region StorageAccount
        /// <summary> Gets an object representing a StorageAccountContainer along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroupOperations" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="StorageAccountContainer" /> object. </returns>
        public static StorageAccountContainer GetStorageAccounts(this ResourceGroupOperations resourceGroup)
        {
            return new StorageAccountContainer(resourceGroup);
        }
        #endregion
    }
}
