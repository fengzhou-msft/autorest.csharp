// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;

namespace Azure.Resources.Sample
{
    /// <summary> A Class representing a ApplicationDefinition along with the instance operations that can be performed on it. </summary>
    public class ApplicationDefinition : ApplicationDefinitionOperations
    {
        /// <summary> Initializes a new instance of the <see cref = "ApplicationDefinition"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal ApplicationDefinition(OperationsBase options, ApplicationDefinitionData resource) : base(options, resource.Id)
        {
            Data = resource;
        }

        /// <summary> Gets or sets the ApplicationDefinitionData. </summary>
        public ApplicationDefinitionData Data { get; private set; }
    }
}
