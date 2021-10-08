// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Resources;

namespace MgmtExtensionResource
{
    /// <summary> A class to add extension methods to Subscription. </summary>
    public static partial class SubscriptionExtensions
    {
        #region PolicyDefinition
        /// <summary> Gets an object representing a PolicyDefinitionInSubscriptionContainer along with the instance operations that can be performed on it. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="PolicyDefinitionInSubscriptionContainer" /> object. </returns>
        public static PolicyDefinitionInSubscriptionContainer GetPolicyDefinitions(this Subscription subscription)
        {
            return new PolicyDefinitionInSubscriptionContainer(subscription);
        }
        #endregion
    }
}
