// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Sample
{
    /// <summary> A class to add extension methods to ResourceGroup. </summary>
    public static partial class ResourceGroupExtensions
    {
        #region AvailabilitySet
        /// <summary> Gets an object representing a AvailabilitySetContainer along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroupOperations" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="AvailabilitySetContainer" /> object. </returns>
        public static AvailabilitySetContainer GetAvailabilitySets(this ResourceGroupOperations resourceGroup)
        {
            return new AvailabilitySetContainer(resourceGroup);
        }
        #endregion

        #region ProximityPlacementGroup
        /// <summary> Gets an object representing a ProximityPlacementGroupContainer along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroupOperations" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="ProximityPlacementGroupContainer" /> object. </returns>
        public static ProximityPlacementGroupContainer GetProximityPlacementGroups(this ResourceGroupOperations resourceGroup)
        {
            return new ProximityPlacementGroupContainer(resourceGroup);
        }
        #endregion

        #region DedicatedHostGroup
        /// <summary> Gets an object representing a DedicatedHostGroupContainer along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroupOperations" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="DedicatedHostGroupContainer" /> object. </returns>
        public static DedicatedHostGroupContainer GetDedicatedHostGroups(this ResourceGroupOperations resourceGroup)
        {
            return new DedicatedHostGroupContainer(resourceGroup);
        }
        #endregion

        #region SshPublicKey
        /// <summary> Gets an object representing a SshPublicKeyContainer along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroupOperations" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="SshPublicKeyContainer" /> object. </returns>
        public static SshPublicKeyContainer GetSshPublicKeys(this ResourceGroupOperations resourceGroup)
        {
            return new SshPublicKeyContainer(resourceGroup);
        }
        #endregion

        #region VirtualMachine
        /// <summary> Gets an object representing a VirtualMachineContainer along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroupOperations" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="VirtualMachineContainer" /> object. </returns>
        public static VirtualMachineContainer GetVirtualMachines(this ResourceGroupOperations resourceGroup)
        {
            return new VirtualMachineContainer(resourceGroup);
        }
        #endregion

        #region Image
        /// <summary> Gets an object representing a ImageContainer along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroupOperations" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="ImageContainer" /> object. </returns>
        public static ImageContainer GetImages(this ResourceGroupOperations resourceGroup)
        {
            return new ImageContainer(resourceGroup);
        }
        #endregion

        #region VirtualMachineScaleSet
        /// <summary> Gets an object representing a VirtualMachineScaleSetContainer along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroupOperations" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="VirtualMachineScaleSetContainer" /> object. </returns>
        public static VirtualMachineScaleSetContainer GetVirtualMachineScaleSets(this ResourceGroupOperations resourceGroup)
        {
            return new VirtualMachineScaleSetContainer(resourceGroup);
        }
        #endregion
    }
}
