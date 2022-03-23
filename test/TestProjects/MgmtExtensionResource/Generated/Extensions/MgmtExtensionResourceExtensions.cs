// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Management;
using Azure.ResourceManager.Resources;
using MgmtExtensionResource.Models;

namespace MgmtExtensionResource
{
    /// <summary> A class to add extension methods to MgmtExtensionResource. </summary>
    public static partial class MgmtExtensionResourceExtensions
    {
        private static TenantResourceExtensionClient GetExtensionClient(TenantResource tenantResource)
        {
            return tenantResource.GetCachedClient((client) =>
            {
                return new TenantResourceExtensionClient(client, tenantResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of BuiltInPolicyDefinitionResources in the TenantResource. </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of BuiltInPolicyDefinitionResources and their operations over a BuiltInPolicyDefinitionResource. </returns>
        public static BuiltInPolicyDefinitionCollection GetBuiltInPolicyDefinitions(this TenantResource tenantResource)
        {
            return GetExtensionClient(tenantResource).GetBuiltInPolicyDefinitions();
        }

        /// <summary>
        /// This operation retrieves the built-in policy definition with the given name.
        /// Request Path: /providers/Microsoft.Authorization/policyDefinitions/{policyDefinitionName}
        /// Operation Id: PolicyDefinitions_GetBuiltIn
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="policyDefinitionName"> The name of the built-in policy definition to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyDefinitionName"/> is null. </exception>
        public static async Task<Response<BuiltInPolicyDefinitionResource>> GetBuiltInPolicyDefinitionAsync(this TenantResource tenantResource, string policyDefinitionName, CancellationToken cancellationToken = default)
        {
            return await tenantResource.GetBuiltInPolicyDefinitions().GetAsync(policyDefinitionName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// This operation retrieves the built-in policy definition with the given name.
        /// Request Path: /providers/Microsoft.Authorization/policyDefinitions/{policyDefinitionName}
        /// Operation Id: PolicyDefinitions_GetBuiltIn
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="policyDefinitionName"> The name of the built-in policy definition to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyDefinitionName"/> is null. </exception>
        public static Response<BuiltInPolicyDefinitionResource> GetBuiltInPolicyDefinition(this TenantResource tenantResource, string policyDefinitionName, CancellationToken cancellationToken = default)
        {
            return tenantResource.GetBuiltInPolicyDefinitions().Get(policyDefinitionName, cancellationToken);
        }

        private static SubscriptionResourceExtensionClient GetExtensionClient(SubscriptionResource subscriptionResource)
        {
            return subscriptionResource.GetCachedClient((client) =>
            {
                return new SubscriptionResourceExtensionClient(client, subscriptionResource.Id);
            }
            );
        }

        /// <summary> Gets an object representing a SubSingletonResource along with the instance operations that can be performed on it in the SubscriptionResource. </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="SubSingletonResource" /> object. </returns>
        public static SubSingletonResource GetSubSingleton(this SubscriptionResource subscriptionResource)
        {
            return GetExtensionClient(subscriptionResource).GetSubSingleton();
        }

        /// <summary> Gets a collection of SubscriptionPolicyDefinitionResources in the SubscriptionResource. </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of SubscriptionPolicyDefinitionResources and their operations over a SubscriptionPolicyDefinitionResource. </returns>
        public static SubscriptionPolicyDefinitionCollection GetSubscriptionPolicyDefinitions(this SubscriptionResource subscriptionResource)
        {
            return GetExtensionClient(subscriptionResource).GetSubscriptionPolicyDefinitions();
        }

        /// <summary>
        /// This operation retrieves the policy definition in the given subscription with the given name.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Authorization/policyDefinitions/{policyDefinitionName}
        /// Operation Id: PolicyDefinitions_Get
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="policyDefinitionName"> The name of the policy definition to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyDefinitionName"/> is null. </exception>
        public static async Task<Response<SubscriptionPolicyDefinitionResource>> GetSubscriptionPolicyDefinitionAsync(this SubscriptionResource subscriptionResource, string policyDefinitionName, CancellationToken cancellationToken = default)
        {
            return await GetSubscriptionPolicyDefinitions(subscriptionResource).GetAsync(policyDefinitionName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// This operation retrieves the policy definition in the given subscription with the given name.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Authorization/policyDefinitions/{policyDefinitionName}
        /// Operation Id: PolicyDefinitions_Get
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="policyDefinitionName"> The name of the policy definition to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyDefinitionName"/> is null. </exception>
        public static Response<SubscriptionPolicyDefinitionResource> GetSubscriptionPolicyDefinition(this SubscriptionResource subscriptionResource, string policyDefinitionName, CancellationToken cancellationToken = default)
        {
            return GetSubscriptionPolicyDefinitions(subscriptionResource).Get(policyDefinitionName, cancellationToken);
        }

        /// <summary>
        /// Checks whether a domain name in the cloudapp.azure.com zone is available for use.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Network/locations/{location}/CheckDnsNameAvailability
        /// Operation Id: CheckDnsNameAvailability
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location of the domain name. </param>
        /// <param name="domainNameLabel"> The domain name to be verified. It must conform to the following regular expression: ^[a-z][a-z0-9-]{1,61}[a-z0-9]$. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="domainNameLabel"/> is null. </exception>
        public static async Task<Response<DnsNameAvailabilityResult>> CheckDnsNameAvailabilityAsync(this SubscriptionResource subscriptionResource, string location, string domainNameLabel, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));
            Argument.AssertNotNull(domainNameLabel, nameof(domainNameLabel));

            return await GetExtensionClient(subscriptionResource).CheckDnsNameAvailabilityAsync(location, domainNameLabel, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Checks whether a domain name in the cloudapp.azure.com zone is available for use.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Network/locations/{location}/CheckDnsNameAvailability
        /// Operation Id: CheckDnsNameAvailability
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location of the domain name. </param>
        /// <param name="domainNameLabel"> The domain name to be verified. It must conform to the following regular expression: ^[a-z][a-z0-9-]{1,61}[a-z0-9]$. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="domainNameLabel"/> is null. </exception>
        public static Response<DnsNameAvailabilityResult> CheckDnsNameAvailability(this SubscriptionResource subscriptionResource, string location, string domainNameLabel, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));
            Argument.AssertNotNull(domainNameLabel, nameof(domainNameLabel));

            return GetExtensionClient(subscriptionResource).CheckDnsNameAvailability(location, domainNameLabel, cancellationToken);
        }

        /// <summary>
        /// Description for Validate information for a certificate order.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.OrphanedPost/validateSomething
        /// Operation Id: OrphanedPost_ValidateSomething
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="validateSomethingOptions"> Information to validate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="validateSomethingOptions"/> is null. </exception>
        public static async Task<Response> ValidateSomethingOrphanedPostAsync(this SubscriptionResource subscriptionResource, ValidateSomethingOptions validateSomethingOptions, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(validateSomethingOptions, nameof(validateSomethingOptions));

            return await GetExtensionClient(subscriptionResource).ValidateSomethingOrphanedPostAsync(validateSomethingOptions, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Description for Validate information for a certificate order.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.OrphanedPost/validateSomething
        /// Operation Id: OrphanedPost_ValidateSomething
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="validateSomethingOptions"> Information to validate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="validateSomethingOptions"/> is null. </exception>
        public static Response ValidateSomethingOrphanedPost(this SubscriptionResource subscriptionResource, ValidateSomethingOptions validateSomethingOptions, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(validateSomethingOptions, nameof(validateSomethingOptions));

            return GetExtensionClient(subscriptionResource).ValidateSomethingOrphanedPost(validateSomethingOptions, cancellationToken);
        }

        private static ManagementGroupResourceExtensionClient GetExtensionClient(ManagementGroupResource managementGroupResource)
        {
            return managementGroupResource.GetCachedClient((client) =>
            {
                return new ManagementGroupResourceExtensionClient(client, managementGroupResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of ManagementGroupPolicyDefinitionResources in the ManagementGroupResource. </summary>
        /// <param name="managementGroupResource"> The <see cref="ManagementGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of ManagementGroupPolicyDefinitionResources and their operations over a ManagementGroupPolicyDefinitionResource. </returns>
        public static ManagementGroupPolicyDefinitionCollection GetManagementGroupPolicyDefinitions(this ManagementGroupResource managementGroupResource)
        {
            return GetExtensionClient(managementGroupResource).GetManagementGroupPolicyDefinitions();
        }

        /// <summary>
        /// This operation retrieves the policy definition in the given management group with the given name.
        /// Request Path: /providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Authorization/policyDefinitions/{policyDefinitionName}
        /// Operation Id: PolicyDefinitions_GetAtManagementGroup
        /// </summary>
        /// <param name="managementGroupResource"> The <see cref="ManagementGroupResource" /> instance the method will execute against. </param>
        /// <param name="policyDefinitionName"> The name of the policy definition to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyDefinitionName"/> is null. </exception>
        public static async Task<Response<ManagementGroupPolicyDefinitionResource>> GetManagementGroupPolicyDefinitionAsync(this ManagementGroupResource managementGroupResource, string policyDefinitionName, CancellationToken cancellationToken = default)
        {
            return await managementGroupResource.GetManagementGroupPolicyDefinitions().GetAsync(policyDefinitionName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// This operation retrieves the policy definition in the given management group with the given name.
        /// Request Path: /providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Authorization/policyDefinitions/{policyDefinitionName}
        /// Operation Id: PolicyDefinitions_GetAtManagementGroup
        /// </summary>
        /// <param name="managementGroupResource"> The <see cref="ManagementGroupResource" /> instance the method will execute against. </param>
        /// <param name="policyDefinitionName"> The name of the policy definition to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="policyDefinitionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="policyDefinitionName"/> is null. </exception>
        public static Response<ManagementGroupPolicyDefinitionResource> GetManagementGroupPolicyDefinition(this ManagementGroupResource managementGroupResource, string policyDefinitionName, CancellationToken cancellationToken = default)
        {
            return managementGroupResource.GetManagementGroupPolicyDefinitions().Get(policyDefinitionName, cancellationToken);
        }

        #region SubSingletonResource
        /// <summary>
        /// Gets an object representing a <see cref="SubSingletonResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SubSingletonResource.CreateResourceIdentifier" /> to create a <see cref="SubSingletonResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SubSingletonResource" /> object. </returns>
        public static SubSingletonResource GetSubSingletonResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                SubSingletonResource.ValidateResourceId(id);
                return new SubSingletonResource(client, id);
            }
            );
        }
        #endregion

        #region SubscriptionPolicyDefinitionResource
        /// <summary>
        /// Gets an object representing a <see cref="SubscriptionPolicyDefinitionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SubscriptionPolicyDefinitionResource.CreateResourceIdentifier" /> to create a <see cref="SubscriptionPolicyDefinitionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SubscriptionPolicyDefinitionResource" /> object. </returns>
        public static SubscriptionPolicyDefinitionResource GetSubscriptionPolicyDefinitionResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                SubscriptionPolicyDefinitionResource.ValidateResourceId(id);
                return new SubscriptionPolicyDefinitionResource(client, id);
            }
            );
        }
        #endregion

        #region BuiltInPolicyDefinitionResource
        /// <summary>
        /// Gets an object representing a <see cref="BuiltInPolicyDefinitionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="BuiltInPolicyDefinitionResource.CreateResourceIdentifier" /> to create a <see cref="BuiltInPolicyDefinitionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="BuiltInPolicyDefinitionResource" /> object. </returns>
        public static BuiltInPolicyDefinitionResource GetBuiltInPolicyDefinitionResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                BuiltInPolicyDefinitionResource.ValidateResourceId(id);
                return new BuiltInPolicyDefinitionResource(client, id);
            }
            );
        }
        #endregion

        #region ManagementGroupPolicyDefinitionResource
        /// <summary>
        /// Gets an object representing a <see cref="ManagementGroupPolicyDefinitionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ManagementGroupPolicyDefinitionResource.CreateResourceIdentifier" /> to create a <see cref="ManagementGroupPolicyDefinitionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ManagementGroupPolicyDefinitionResource" /> object. </returns>
        public static ManagementGroupPolicyDefinitionResource GetManagementGroupPolicyDefinitionResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ManagementGroupPolicyDefinitionResource.ValidateResourceId(id);
                return new ManagementGroupPolicyDefinitionResource(client, id);
            }
            );
        }
        #endregion
    }
}
