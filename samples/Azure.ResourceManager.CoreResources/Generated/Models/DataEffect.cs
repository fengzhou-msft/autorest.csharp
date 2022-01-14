// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> The data effect definition. </summary>
    public partial class DataEffect
    {
        /// <summary> Initializes a new instance of DataEffect. </summary>
        internal DataEffect()
        {
        }

        /// <summary> Initializes a new instance of DataEffect. </summary>
        /// <param name="name"> The data effect name. </param>
        /// <param name="detailsSchema"> The data effect details schema. </param>
        internal DataEffect(string name, object detailsSchema)
        {
            Name = name;
            DetailsSchema = detailsSchema;
        }

        /// <summary> The data effect name. </summary>
        public string Name { get; }
        /// <summary> The data effect details schema. </summary>
        public object DetailsSchema { get; }
    }
}
