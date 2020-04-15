// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace xms_error_responses.Models
{
    public partial class PetAction
    {
        internal static PetAction DeserializePetAction(JsonElement element)
        {
            string actionResponse = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("actionResponse"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    actionResponse = property.Value.GetString();
                    continue;
                }
            }
            return new PetAction(actionResponse);
        }
    }
}
