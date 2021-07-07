// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Resources
{
    internal static partial class ResourceIdentityTypeExtensions
    {
        public static string ToSerialString(this ResourceIdentityType value) => value switch
        {
            ResourceIdentityType.SystemAssigned => "SystemAssigned",
            ResourceIdentityType.None => "None",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ResourceIdentityType value.")
        };

        public static ResourceIdentityType ToResourceIdentityType(this string value)
        {
            if (string.Equals(value, "SystemAssigned", StringComparison.InvariantCultureIgnoreCase)) return ResourceIdentityType.SystemAssigned;
            if (string.Equals(value, "None", StringComparison.InvariantCultureIgnoreCase)) return ResourceIdentityType.None;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ResourceIdentityType value.");
        }
    }
}
