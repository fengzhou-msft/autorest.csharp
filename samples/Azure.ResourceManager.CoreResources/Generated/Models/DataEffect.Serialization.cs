// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CoreResources.Models
{
    public partial class DataEffect
    {
        internal static DataEffect DeserializeDataEffect(JsonElement element)
        {
            Optional<string> name = default;
            Optional<object> detailsSchema = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("detailsSchema"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    detailsSchema = property.Value.GetObject();
                    continue;
                }
            }
            return new DataEffect(name.Value, detailsSchema.Value);
        }
    }
}
