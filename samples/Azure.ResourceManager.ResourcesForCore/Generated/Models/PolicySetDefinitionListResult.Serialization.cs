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
    internal partial class PolicySetDefinitionListResult
    {
        internal static PolicySetDefinitionListResult DeserializePolicySetDefinitionListResult(JsonElement element)
        {
            Optional<IReadOnlyList<PolicySetDefinitionData>> value = default;
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
                    List<PolicySetDefinitionData> array = new List<PolicySetDefinitionData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PolicySetDefinitionData.DeserializePolicySetDefinitionData(item));
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
            return new PolicySetDefinitionListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
