// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ResourcesForCore;

namespace Azure.ResourceManager.ResourcesForCore.Models
{
    internal partial class PolicyDefinitionListResult
    {
        internal static PolicyDefinitionListResult DeserializePolicyDefinitionListResult(JsonElement element)
        {
            Optional<IReadOnlyList<PolicyDefinitionData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<PolicyDefinitionData> array = new List<PolicyDefinitionData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PolicyDefinitionData.DeserializePolicyDefinitionData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new PolicyDefinitionListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
