// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace MgmtRenameRules
{
    /// <summary> A class to add extension methods to ResourceGroup. </summary>
    internal partial class ResourceGroupExtensionClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="ResourceGroupExtensionClient"/> class for mocking. </summary>
        protected ResourceGroupExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ResourceGroupExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of VirtualMachines in the VirtualMachine. </summary>
        /// <returns> An object representing collection of VirtualMachines and their operations over a VirtualMachine. </returns>
        public virtual VirtualMachineCollection GetVirtualMachines()
        {
            return GetCachedClient(Client => new VirtualMachineCollection(Client, Id));
        }

        /// <summary> Gets a collection of Images in the Image. </summary>
        /// <returns> An object representing collection of Images and their operations over a Image. </returns>
        public virtual ImageCollection GetImages()
        {
            return GetCachedClient(Client => new ImageCollection(Client, Id));
        }

        /// <summary> Gets a collection of VirtualMachineScaleSets in the VirtualMachineScaleSet. </summary>
        /// <returns> An object representing collection of VirtualMachineScaleSets and their operations over a VirtualMachineScaleSet. </returns>
        public virtual VirtualMachineScaleSetCollection GetVirtualMachineScaleSets()
        {
            return GetCachedClient(Client => new VirtualMachineScaleSetCollection(Client, Id));
        }
    }
}
