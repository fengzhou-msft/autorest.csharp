// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using SupersetInheritance;

namespace SupersetInheritance.Models
{
    internal partial class SupersetModel6ListResult
    {
        internal static SupersetModel6ListResult DeserializeSupersetModel6ListResult(JsonElement element)
        {
            Optional<IReadOnlyList<SupersetModel6Data>> value = default;
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
                    List<SupersetModel6Data> array = new List<SupersetModel6Data>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SupersetModel6Data.DeserializeSupersetModel6Data(item));
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
            return new SupersetModel6ListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
