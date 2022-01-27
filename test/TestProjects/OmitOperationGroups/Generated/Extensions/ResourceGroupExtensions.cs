// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.ResourceManager.Resources;
using OmitOperationGroups.Models;

namespace OmitOperationGroups
{
    /// <summary> A class to add extension methods to ResourceGroup. </summary>
    public static partial class ResourceGroupExtensions
    {
        #region Model2
        /// <summary> Gets an object representing a Model2Collection along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="Model2Collection" /> object. </returns>
        public static Model2Collection GetModel2s(this ResourceGroup resourceGroup)
        {
            return new Model2Collection(resourceGroup);
        }
        #endregion

        private static ResourceGroupExtensionClient GetExtensionClient(ResourceGroup resourceGroup)
        {
            return resourceGroup.GetCachedClient((armClient) =>
            {
                return new ResourceGroupExtensionClient(armClient, resourceGroup.Id);
            }
            );
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/model5s
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Model5s_List
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<Model5> GetModel5sAsync(this ResourceGroup resourceGroup, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(resourceGroup).GetModel5sAsync(cancellationToken);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/model5s
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Model5s_List
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static Pageable<Model5> GetModel5s(this ResourceGroup resourceGroup, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(resourceGroup).GetModel5s(cancellationToken);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/model5s/{model5sName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Model5s_CreateOrUpdate
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="model5SName"> The String to use. </param>
        /// <param name="parameters"> The Model5 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="System.ArgumentException"> <paramref name="model5SName"/> is empty. </exception>
        /// <exception cref="System.ArgumentNullException"> <paramref name="model5SName"/> or <paramref name="parameters"/> is null. </exception>
        public static async Task<Response<Model5>> CreateOrUpdateModel5Async(this ResourceGroup resourceGroup, string model5SName, Model5 parameters, CancellationToken cancellationToken = default)
        {
            return await GetExtensionClient(resourceGroup).CreateOrUpdateModel5Async(model5SName, parameters, cancellationToken).ConfigureAwait(false);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/model5s/{model5sName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Model5s_CreateOrUpdate
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="model5SName"> The String to use. </param>
        /// <param name="parameters"> The Model5 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="System.ArgumentException"> <paramref name="model5SName"/> is empty. </exception>
        /// <exception cref="System.ArgumentNullException"> <paramref name="model5SName"/> or <paramref name="parameters"/> is null. </exception>
        public static Response<Model5> CreateOrUpdateModel5(this ResourceGroup resourceGroup, string model5SName, Model5 parameters, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(resourceGroup).CreateOrUpdateModel5(model5SName, parameters, cancellationToken);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/model5s/{model5sName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Model5s_Get
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="model5SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="System.ArgumentException"> <paramref name="model5SName"/> is empty. </exception>
        /// <exception cref="System.ArgumentNullException"> <paramref name="model5SName"/> is null. </exception>
        public static async Task<Response<Model5>> GetModel5Async(this ResourceGroup resourceGroup, string model5SName, CancellationToken cancellationToken = default)
        {
            return await GetExtensionClient(resourceGroup).GetModel5Async(model5SName, cancellationToken).ConfigureAwait(false);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/model5s/{model5sName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Model5s_Get
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="model5SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="System.ArgumentException"> <paramref name="model5SName"/> is empty. </exception>
        /// <exception cref="System.ArgumentNullException"> <paramref name="model5SName"/> is null. </exception>
        public static Response<Model5> GetModel5(this ResourceGroup resourceGroup, string model5SName, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(resourceGroup).GetModel5(model5SName, cancellationToken);
        }
    }
}
