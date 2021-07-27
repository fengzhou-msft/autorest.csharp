// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources.Models;

namespace ExactMatchFlattenInheritance
{
    public partial class AzureResourceFlattenModel1Data : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Foo))
            {
                writer.WritePropertyName("foo");
                writer.WriteNumberValue(Foo.Value);
            }
            writer.WritePropertyName("tags");
            writer.WriteStartObject();
            foreach (var item in Tags)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteStringValue(item.Value);
            }
            writer.WriteEndObject();
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(FooPropertiesFoo))
            {
                writer.WritePropertyName("foo");
                writer.WriteStringValue(FooPropertiesFoo);
            }
            if (Optional.IsDefined(IdPropertiesId))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(IdPropertiesId);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static AzureResourceFlattenModel1Data DeserializeAzureResourceFlattenModel1Data(JsonElement element)
        {
            Optional<int> foo = default;
            IDictionary<string, string> tags = default;
            Location location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<string> foo0 = default;
            Optional<string> id0 = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("foo"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foo = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("foo"))
                        {
                            foo0 = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("id"))
                        {
                            id0 = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new AzureResourceFlattenModel1Data(id, name, type, location, tags, Optional.ToNullable(foo), foo0.Value, id0.Value);
        }
    }
}
