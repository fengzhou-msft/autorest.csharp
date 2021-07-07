// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources
{
    public partial class ProviderExtendedLocation
    {
        internal static ProviderExtendedLocation DeserializeProviderExtendedLocation(JsonElement element)
        {
            Optional<string> location = default;
            Optional<string> type = default;
            Optional<IReadOnlyList<string>> extendedLocations = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("extendedLocations"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    extendedLocations = array;
                    continue;
                }
            }
            return new ProviderExtendedLocation(location.Value, type.Value, Optional.ToList(extendedLocations));
        }
    }
}
