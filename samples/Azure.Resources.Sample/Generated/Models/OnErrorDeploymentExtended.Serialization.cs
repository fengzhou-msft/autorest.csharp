// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class OnErrorDeploymentExtended
    {
        internal static OnErrorDeploymentExtended DeserializeOnErrorDeploymentExtended(JsonElement element)
        {
            Optional<string> provisioningState = default;
            Optional<OnErrorDeploymentType> type = default;
            Optional<string> deploymentName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"))
                {
                    provisioningState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type = property.Value.();
                    continue;
                }
                if (property.NameEquals("deploymentName"))
                {
                    deploymentName = property.Value.GetString();
                    continue;
                }
            }
            return new OnErrorDeploymentExtended(provisioningState.Value, Optional.ToNullable(type), deploymentName.Value);
        }
    }
}
