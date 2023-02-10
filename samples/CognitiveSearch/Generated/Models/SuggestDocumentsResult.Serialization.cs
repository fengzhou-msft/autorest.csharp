// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace CognitiveSearch.Models
{
    public partial class SuggestDocumentsResult
    {
        internal static SuggestDocumentsResult DeserializeSuggestDocumentsResult(JsonElement element)
        {
            IReadOnlyList<SuggestResult> value = default;
            Optional<double> searchCoverage = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<SuggestResult> array = new List<SuggestResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SuggestResult.DeserializeSuggestResult(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("@search.coverage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    searchCoverage = property.Value.GetDouble();
                    continue;
                }
            }
            return new SuggestDocumentsResult(value, Optional.ToNullable(searchCoverage));
        }
    }
}
