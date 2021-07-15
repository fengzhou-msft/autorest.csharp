// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;

namespace ExactMatchFlattenInheritance
{
    /// <summary> A Class representing a CustomModel2 along with the instance operations that can be performed on it. </summary>
    public class CustomModel2 : CustomModel2Operations
    {
        /// <summary> Initializes a new instance of the <see cref = "CustomModel2"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal CustomModel2(OperationsBase options, CustomModel2Data resource) : base(options, resource.Id)
        {
            Data = resource;
        }

        /// <summary> Gets or sets the CustomModel2Data. </summary>
        public CustomModel2Data Data { get; private set; }
    }
}
