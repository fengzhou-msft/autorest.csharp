// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Sample
{
    /// <summary> A class representing the Image data model. </summary>
    public partial class ImageData : TrackedResource<ResourceGroupResourceIdentifier>
    {
        /// <summary> Initializes a new instance of ImageData. </summary>
        /// <param name="location"> The location. </param>
        public ImageData(Location location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of ImageData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="location"> The location. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="sourceVirtualMachine"> The source virtual machine from which Image is created. </param>
        /// <param name="storageProfile"> Specifies the storage settings for the virtual machine disks. </param>
        /// <param name="provisioningState"> The provisioning state. </param>
        /// <param name="hyperVGeneration"> Gets the HyperVGenerationType of the VirtualMachine created from the image. </param>
        internal ImageData(ResourceGroupResourceIdentifier id, string name, ResourceType type, Location location, IDictionary<string, string> tags, SubResource sourceVirtualMachine, ImageStorageProfile storageProfile, string provisioningState, HyperVGenerationTypes? hyperVGeneration) : base(id, name, type, location, tags)
        {
            SourceVirtualMachine = sourceVirtualMachine;
            StorageProfile = storageProfile;
            ProvisioningState = provisioningState;
            HyperVGeneration = hyperVGeneration;
        }

        /// <summary> The source virtual machine from which Image is created. </summary>
        public SubResource SourceVirtualMachine { get; set; }
        /// <summary> Specifies the storage settings for the virtual machine disks. </summary>
        public ImageStorageProfile StorageProfile { get; set; }
        /// <summary> The provisioning state. </summary>
        public string ProvisioningState { get; }
        /// <summary> Gets the HyperVGenerationType of the VirtualMachine created from the image. </summary>
        public HyperVGenerationTypes? HyperVGeneration { get; set; }
    }
}
