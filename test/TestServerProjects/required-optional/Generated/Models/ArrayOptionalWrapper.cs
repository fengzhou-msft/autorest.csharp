// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace required_optional.Models
{
    /// <summary> The ArrayOptionalWrapper. </summary>
    public partial class ArrayOptionalWrapper
    {
        /// <summary> Initializes a new instance of ArrayOptionalWrapper. </summary>
        public ArrayOptionalWrapper()
        {
        }

        /// <summary> Initializes a new instance of ArrayOptionalWrapper. </summary>
        /// <param name="value"> . </param>
        internal ArrayOptionalWrapper(IList<string> value)
        {
            Value = value;
        }

        public IList<string> Value { get; set; }
    }
}
