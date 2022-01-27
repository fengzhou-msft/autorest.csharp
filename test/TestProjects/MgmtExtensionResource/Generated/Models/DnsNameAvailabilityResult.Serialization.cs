// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace MgmtExtensionResource.Models
{
    public partial class DnsNameAvailabilityResult
    {
        internal static DnsNameAvailabilityResult DeserializeDnsNameAvailabilityResult(JsonElement element)
        {
            Optional<bool> available = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("available"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    available = property.Value.GetBoolean();
                    continue;
                }
            }
            return new DnsNameAvailabilityResult(Optional.ToNullable(available));
        }
    }
}
