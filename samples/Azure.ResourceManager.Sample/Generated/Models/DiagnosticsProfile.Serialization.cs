// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sample.Models
{
    internal partial class DiagnosticsProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(BootDiagnostics))
            {
                writer.WritePropertyName("bootDiagnostics"u8);
                writer.WriteObjectValue(BootDiagnostics);
            }
            writer.WriteEndObject();
        }

        internal static DiagnosticsProfile DeserializeDiagnosticsProfile(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<BootDiagnostics> bootDiagnostics = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("bootDiagnostics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    bootDiagnostics = BootDiagnostics.DeserializeBootDiagnostics(property.Value);
                    continue;
                }
            }
            return new DiagnosticsProfile(bootDiagnostics.Value);
        }
    }
}
