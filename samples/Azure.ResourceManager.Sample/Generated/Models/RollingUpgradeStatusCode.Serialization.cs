// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Sample.Models
{
    internal static partial class RollingUpgradeStatusCodeExtensions
    {
        public static string ToSerialString(this RollingUpgradeStatusCode value) => value switch
        {
            RollingUpgradeStatusCode.RollingForward => "RollingForward",
            RollingUpgradeStatusCode.Cancelled => "Cancelled",
            RollingUpgradeStatusCode.Completed => "Completed",
            RollingUpgradeStatusCode.Faulted => "Faulted",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown RollingUpgradeStatusCode value.")
        };

        public static RollingUpgradeStatusCode ToRollingUpgradeStatusCode(this string value)
        {
            if (string.Equals(value, "RollingForward", StringComparison.InvariantCultureIgnoreCase)) return RollingUpgradeStatusCode.RollingForward;
            if (string.Equals(value, "Cancelled", StringComparison.InvariantCultureIgnoreCase)) return RollingUpgradeStatusCode.Cancelled;
            if (string.Equals(value, "Completed", StringComparison.InvariantCultureIgnoreCase)) return RollingUpgradeStatusCode.Completed;
            if (string.Equals(value, "Faulted", StringComparison.InvariantCultureIgnoreCase)) return RollingUpgradeStatusCode.Faulted;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown RollingUpgradeStatusCode value.");
        }
    }
}
