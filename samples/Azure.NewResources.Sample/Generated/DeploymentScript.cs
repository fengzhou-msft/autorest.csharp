// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.NewResources
{
    /// <summary> A Class representing a DeploymentScript along with the instance operations that can be performed on it. </summary>
    public class DeploymentScript : DeploymentScriptOperations
    {
        /// <summary> Initializes a new instance of the <see cref = "DeploymentScript"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal DeploymentScript(ResourceOperationsBase options, DeploymentScriptData resource) : base(options)
        {
            Data = resource;
        }

        /// <summary> Gets or sets the DeploymentScriptData. </summary>
        public DeploymentScriptData Data { get; private set; }
    }
}
