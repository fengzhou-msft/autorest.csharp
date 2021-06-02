// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Resources
{
    /// <summary> A class representing the operations that can be performed over a specific DeploymentScript. </summary>
    public partial class DeploymentScriptOperations : SingletonOperationsBase<ResourceGroupResourceIdentifier, DeploymentScript>
    {
        /// <summary> Initializes a new instance of the <see cref="DeploymentScriptOperations"/> class for mocking. </summary>
        protected DeploymentScriptOperations()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DeploymentScriptOperations"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        protected internal DeploymentScriptOperations(ResourceOperationsBase options) : base(options)
        {
        }

        public static readonly ResourceType ResourceType = "Microsoft.Resources/deploymentScripts";
        protected override ResourceType ValidResourceType => ResourceType;
    }
}
