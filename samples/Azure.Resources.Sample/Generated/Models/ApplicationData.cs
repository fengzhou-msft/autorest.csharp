// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Resources
{
    /// <summary> A class representing the Application data model. </summary>
    public partial class ApplicationData : GenericResourceAutoGenerated
    {
        /// <summary> Initializes a new instance of ApplicationData. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="kind"> The kind of the managed application. Allowed values are MarketPlace and ServiceCatalog. </param>
        /// <param name="managedResourceGroupId"> The managed resource group Id. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="kind"/> or <paramref name="managedResourceGroupId"/> is null. </exception>
        public ApplicationData(LocationData location, string kind, string managedResourceGroupId) : base(location)
        {
            if (kind == null)
            {
                throw new ArgumentNullException(nameof(kind));
            }
            if (managedResourceGroupId == null)
            {
                throw new ArgumentNullException(nameof(managedResourceGroupId));
            }

            Kind = kind;
            ManagedResourceGroupId = managedResourceGroupId;
        }

        /// <summary> Initializes a new instance of ApplicationData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="location"> The location. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="managedBy"> ID of the resource that manages this resource. </param>
        /// <param name="sku"> The SKU of the resource. </param>
        /// <param name="identity"> The identity of the resource. </param>
        /// <param name="plan"> The plan information. </param>
        /// <param name="kind"> The kind of the managed application. Allowed values are MarketPlace and ServiceCatalog. </param>
        /// <param name="managedResourceGroupId"> The managed resource group Id. </param>
        /// <param name="applicationDefinitionId"> The fully qualified path of managed application definition Id. </param>
        /// <param name="parameters"> Name and value pairs that define the managed application parameters. It can be a JObject or a well formed JSON string. </param>
        /// <param name="outputs"> Name and value pairs that define the managed application outputs. </param>
        /// <param name="provisioningState"> The managed application provisioning state. </param>
        internal ApplicationData(ResourceGroupResourceIdentifier id, string name, ResourceType type, LocationData location, IDictionary<string, string> tags, string managedBy, SkuAutoGenerated sku, IdentityAutoGenerated2 identity, PlanAutoGenerated plan, string kind, string managedResourceGroupId, string applicationDefinitionId, object parameters, object outputs, ProvisioningState? provisioningState) : base(id, name, type, location, tags, managedBy, sku, identity)
        {
            Plan = plan;
            Kind = kind;
            ManagedResourceGroupId = managedResourceGroupId;
            ApplicationDefinitionId = applicationDefinitionId;
            Parameters = parameters;
            Outputs = outputs;
            ProvisioningState = provisioningState;
        }

        /// <summary> The plan information. </summary>
        public PlanAutoGenerated Plan { get; set; }
        /// <summary> The kind of the managed application. Allowed values are MarketPlace and ServiceCatalog. </summary>
        public string Kind { get; set; }
        /// <summary> The managed resource group Id. </summary>
        public string ManagedResourceGroupId { get; set; }
        /// <summary> The fully qualified path of managed application definition Id. </summary>
        public string ApplicationDefinitionId { get; set; }
        /// <summary> Name and value pairs that define the managed application parameters. It can be a JObject or a well formed JSON string. </summary>
        public object Parameters { get; set; }
        /// <summary> Name and value pairs that define the managed application outputs. </summary>
        public object Outputs { get; }
        /// <summary> The managed application provisioning state. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}
