// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class ApplicationListResult
    {
        internal static ApplicationListResult DeserializeApplicationListResult(JsonElement element)
        {
            Optional<IReadOnlyList<Application>> value = default;
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
                    List<Application> array = new List<Application>();
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
            return new ApplicationListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
