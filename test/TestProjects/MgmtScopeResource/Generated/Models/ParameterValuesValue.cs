// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace MgmtScopeResource.Models
{
    /// <summary> The value of a parameter. </summary>
    public partial class ParameterValuesValue
    {
        /// <summary> Initializes a new instance of ParameterValuesValue. </summary>
        public ParameterValuesValue()
        {
        }

        /// <summary> Initializes a new instance of ParameterValuesValue. </summary>
        /// <param name="value"> The value of the parameter. </param>
        internal ParameterValuesValue(BinaryData value)
        {
            Value = value;
        }

        /// <summary> The value of the parameter. </summary>
        public BinaryData Value { get; set; }
    }
}
