// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace ExactMatchFlattenInheritance
{
    /// <summary> A class representing the CustomModel3 data model. </summary>
    public partial class CustomModel3Data : WritableResourceData
    {
        /// <summary> Initializes a new instance of CustomModel3Data. </summary>
        public CustomModel3Data()
        {
        }

        /// <summary> Initializes a new instance of CustomModel3Data. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="foo"></param>
        internal CustomModel3Data(ResourceIdentifier id, string name, ResourceType? resourceType, SystemData systemData, string foo) : base(id, name, resourceType, systemData)
        {
            Foo = foo;
        }

        /// <summary> Gets or sets the foo. </summary>
        public string Foo { get; set; }
    }
}
