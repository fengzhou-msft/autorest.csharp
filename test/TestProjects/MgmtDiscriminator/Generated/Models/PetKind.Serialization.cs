// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace MgmtDiscriminator.Models
{
    internal static partial class PetKindExtensions
    {
        public static string ToSerialString(this PetKind value) => value switch
        {
            PetKind.Cat => "Cat",
            PetKind.Dog => "Dog",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown PetKind value.")
        };

        public static PetKind ToPetKind(this string value)
        {
            if (string.Equals(value, "Cat", StringComparison.InvariantCultureIgnoreCase)) return PetKind.Cat;
            if (string.Equals(value, "Dog", StringComparison.InvariantCultureIgnoreCase)) return PetKind.Dog;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown PetKind value.");
        }
    }
}
