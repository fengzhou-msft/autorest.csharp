// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class DeploymentScriptListResult
    {
        internal static DeploymentScriptListResult DeserializeDeploymentScriptListResult(JsonElement element)
        {
            Optional<IReadOnlyList<DeploymentScript>> value = default;
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
                    List<DeploymentScript> array = new List<DeploymentScript>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.());
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
            return new DeploymentScriptListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
