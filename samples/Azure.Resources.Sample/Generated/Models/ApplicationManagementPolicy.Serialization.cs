// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Resources.Sample
{
    public partial class ApplicationManagementPolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Mode))
            {
                writer.WritePropertyName("mode");
                writer.WriteStringValue(Mode.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static ApplicationManagementPolicy DeserializeApplicationManagementPolicy(JsonElement element)
        {
            Optional<ApplicationManagementMode> mode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("mode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    mode = new ApplicationManagementMode(property.Value.GetString());
                    continue;
                }
            }
            return new ApplicationManagementPolicy(Optional.ToNullable(mode));
        }
    }
}
