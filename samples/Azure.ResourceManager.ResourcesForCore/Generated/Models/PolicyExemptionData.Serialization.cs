// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.ResourcesForCore.Models;

namespace Azure.ResourceManager.ResourcesForCore
{
    public partial class PolicyExemptionData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            writer.WritePropertyName("policyAssignmentId");
            writer.WriteStringValue(PolicyAssignmentId);
            if (Optional.IsCollectionDefined(PolicyDefinitionReferenceIds))
            {
                writer.WritePropertyName("policyDefinitionReferenceIds");
                writer.WriteStartArray();
                foreach (var item in PolicyDefinitionReferenceIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("exemptionCategory");
            writer.WriteStringValue(ExemptionCategory.ToString());
            if (Optional.IsDefined(ExpiresOn))
            {
                writer.WritePropertyName("expiresOn");
                writer.WriteStringValue(ExpiresOn.Value, "O");
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName");
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Metadata))
            {
                writer.WritePropertyName("metadata");
                writer.WriteObjectValue(Metadata);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static PolicyExemptionData DeserializePolicyExemptionData(JsonElement element)
        {
            Optional<SystemData> systemData = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            string policyAssignmentId = default;
            Optional<IList<string>> policyDefinitionReferenceIds = default;
            ExemptionCategory exemptionCategory = default;
            Optional<DateTimeOffset> expiresOn = default;
            Optional<string> displayName = default;
            Optional<string> description = default;
            Optional<object> metadata = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = SystemData.DeserializeSystemData(property.Value);
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
                        if (property0.NameEquals("policyAssignmentId"))
                        {
                            policyAssignmentId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("policyDefinitionReferenceIds"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            policyDefinitionReferenceIds = array;
                            continue;
                        }
                        if (property0.NameEquals("exemptionCategory"))
                        {
                            exemptionCategory = new ExemptionCategory(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("expiresOn"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            expiresOn = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("displayName"))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("metadata"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            metadata = property0.Value.GetObject();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new PolicyExemptionData(id, name, type, systemData.Value, policyAssignmentId, Optional.ToList(policyDefinitionReferenceIds), exemptionCategory, Optional.ToNullable(expiresOn), displayName.Value, description.Value, metadata.Value);
        }
    }
}
