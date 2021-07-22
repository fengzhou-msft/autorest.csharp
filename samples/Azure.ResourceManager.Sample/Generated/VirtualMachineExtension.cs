// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Sample
{
    /// <summary> A Class representing a VirtualMachineExtension along with the instance operations that can be performed on it. </summary>
    public class VirtualMachineExtension : VirtualMachineExtensionOperations
    {
        /// <summary> Initializes a new instance of the <see cref = "VirtualMachineExtension"/> class for mocking. </summary>
        protected VirtualMachineExtension() : base()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "VirtualMachineExtension"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal VirtualMachineExtension(OperationsBase options, VirtualMachineExtensionData resource) : base(options, resource.Id)
        {
            Data = resource;
        }

        /// <summary> Gets or sets the VirtualMachineExtensionData. </summary>
        public virtual VirtualMachineExtensionData Data { get; private set; }
    }
}
