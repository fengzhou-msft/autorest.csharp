// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Management.Storage;

namespace Azure.Management.Storage.Models
{
    internal partial class ObjectReplicationPolicies
    {
        internal static ObjectReplicationPolicies DeserializeObjectReplicationPolicies(JsonElement element)
        {
            Optional<IReadOnlyList<ObjectReplicationPolicyData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ObjectReplicationPolicyData> array = new List<ObjectReplicationPolicyData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ObjectReplicationPolicyData.DeserializeObjectReplicationPolicyData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new ObjectReplicationPolicies(Optional.ToList(value));
        }
    }
}
