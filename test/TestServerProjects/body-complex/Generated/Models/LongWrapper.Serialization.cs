// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace body_complex.Models
{
    public partial class LongWrapper : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Field1))
            {
                writer.WritePropertyName("field1"u8);
                writer.WriteNumberValue(Field1.Value);
            }
            if (Optional.IsDefined(Field2))
            {
                writer.WritePropertyName("field2"u8);
                writer.WriteNumberValue(Field2.Value);
            }
            writer.WriteEndObject();
        }

        internal static LongWrapper DeserializeLongWrapper(JsonElement element)
        {
            Optional<long> field1 = default;
            Optional<long> field2 = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("field1"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    field1 = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("field2"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    field2 = property.Value.GetInt64();
                    continue;
                }
            }
            return new LongWrapper(Optional.ToNullable(field1), Optional.ToNullable(field2));
        }
    }
}
