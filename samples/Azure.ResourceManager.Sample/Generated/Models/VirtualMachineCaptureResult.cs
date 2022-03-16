// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sample.Models
{
    /// <summary> Output of virtual machine capture operation. </summary>
    public partial class VirtualMachineCaptureResult : SubResource
    {
        /// <summary> Initializes a new instance of VirtualMachineCaptureResult. </summary>
        public VirtualMachineCaptureResult()
        {
            Resources = new ChangeTrackingList<BinaryData>();
        }

        /// <summary> Initializes a new instance of VirtualMachineCaptureResult. </summary>
        /// <param name="id"> Resource Id. </param>
        /// <param name="schema"> the schema of the captured virtual machine. </param>
        /// <param name="contentVersion"> the version of the content. </param>
        /// <param name="parameters"> parameters of the captured virtual machine. </param>
        /// <param name="resources"> a list of resource items of the captured virtual machine. </param>
        internal VirtualMachineCaptureResult(string id, string schema, string contentVersion, BinaryData parameters, IReadOnlyList<BinaryData> resources) : base(id)
        {
            Schema = schema;
            ContentVersion = contentVersion;
            Parameters = parameters;
            Resources = resources;
        }

        /// <summary> the schema of the captured virtual machine. </summary>
        public string Schema { get; }
        /// <summary> the version of the content. </summary>
        public string ContentVersion { get; }
        /// <summary> parameters of the captured virtual machine. </summary>
        public BinaryData Parameters { get; }
        /// <summary> a list of resource items of the captured virtual machine. </summary>
        public IReadOnlyList<BinaryData> Resources { get; }
    }
}
