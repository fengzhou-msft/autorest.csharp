// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;

namespace Azure.Resources.Sample
{
    /// <summary> A Class representing a JitRequestDefinition along with the instance operations that can be performed on it. </summary>
    public class JitRequestDefinition : JitRequestDefinitionOperations
    {
        /// <summary> Initializes a new instance of the <see cref = "JitRequestDefinition"/> class for mocking. </summary>
        protected JitRequestDefinition() : base()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "JitRequestDefinition"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal JitRequestDefinition(OperationsBase options, JitRequestDefinitionData resource) : base(options, resource.Id)
        {
            Data = resource;
        }

        /// <summary> Gets or sets the JitRequestDefinitionData. </summary>
        public virtual JitRequestDefinitionData Data { get; private set; }
    }
}
