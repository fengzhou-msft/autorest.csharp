// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources
{
    public partial class AliasPathMetadata
    {
        internal static AliasPathMetadata DeserializeAliasPathMetadata(JsonElement element)
        {
            Optional<AliasPathTokenType> type = default;
            Optional<AliasPathAttributes> attributes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type = new AliasPathTokenType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("attributes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    attributes = new AliasPathAttributes(property.Value.GetString());
                    continue;
                }
            }
            return new AliasPathMetadata(Optional.ToNullable(type), Optional.ToNullable(attributes));
        }
    }
}
