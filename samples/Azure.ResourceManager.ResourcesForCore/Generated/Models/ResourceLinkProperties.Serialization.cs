// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ResourcesForCore.Models
{
    public partial class ResourceLinkProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("targetId");
            writer.WriteStringValue(TargetId);
            if (Optional.IsDefined(Notes))
            {
                writer.WritePropertyName("notes");
                writer.WriteStringValue(Notes);
            }
            writer.WriteEndObject();
        }

        internal static ResourceLinkProperties DeserializeResourceLinkProperties(JsonElement element)
        {
            Optional<string> sourceId = default;
            string targetId = default;
            Optional<string> notes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceId"))
                {
                    sourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetId"))
                {
                    targetId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("notes"))
                {
                    notes = property.Value.GetString();
                    continue;
                }
            }
            return new ResourceLinkProperties(sourceId.Value, targetId, notes.Value);
        }
    }
}
