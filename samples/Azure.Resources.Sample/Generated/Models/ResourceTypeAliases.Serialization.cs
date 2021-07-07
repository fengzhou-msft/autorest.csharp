// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources
{
    public partial class ResourceTypeAliases
    {
        internal static ResourceTypeAliases DeserializeResourceTypeAliases(JsonElement element)
        {
            Optional<string> resourceType = default;
            Optional<IReadOnlyList<Alias>> aliases = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceType"))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("aliases"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<Alias> array = new List<Alias>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Alias.DeserializeAlias(item));
                    }
                    aliases = array;
                    continue;
                }
            }
            return new ResourceTypeAliases(resourceType.Value, Optional.ToList(aliases));
        }
    }
}
