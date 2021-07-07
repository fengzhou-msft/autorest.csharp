// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources
{
    public partial class PolicyDefinitionGroup : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName");
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(Category))
            {
                writer.WritePropertyName("category");
                writer.WriteStringValue(Category);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(AdditionalMetadataId))
            {
                writer.WritePropertyName("additionalMetadataId");
                writer.WriteStringValue(AdditionalMetadataId);
            }
            writer.WriteEndObject();
        }

        internal static PolicyDefinitionGroup DeserializePolicyDefinitionGroup(JsonElement element)
        {
            string name = default;
            Optional<string> displayName = default;
            Optional<string> category = default;
            Optional<string> description = default;
            Optional<string> additionalMetadataId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayName"))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("category"))
                {
                    category = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("additionalMetadataId"))
                {
                    additionalMetadataId = property.Value.GetString();
                    continue;
                }
            }
            return new PolicyDefinitionGroup(name, displayName.Value, category.Value, description.Value, additionalMetadataId.Value);
        }
    }
}
