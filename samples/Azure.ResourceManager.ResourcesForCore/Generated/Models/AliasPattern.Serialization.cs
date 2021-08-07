// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ResourcesForCore.Models
{
    public partial class AliasPattern
    {
        internal static AliasPattern DeserializeAliasPattern(JsonElement element)
        {
            Optional<string> phrase = default;
            Optional<string> variable = default;
            Optional<AliasPatternType> type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("phrase"))
                {
                    phrase = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("variable"))
                {
                    variable = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type = property.Value.GetString().ToAliasPatternType();
                    continue;
                }
            }
            return new AliasPattern(phrase.Value, variable.Value, Optional.ToNullable(type));
        }
    }
}
