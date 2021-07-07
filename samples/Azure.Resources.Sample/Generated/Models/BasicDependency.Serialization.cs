// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Resources
{
    public partial class BasicDependency
    {
        internal static BasicDependency DeserializeBasicDependency(JsonElement element)
        {
            Optional<string> resourceType = default;
            Optional<string> resourceName = default;
            ResourceIdentifier id = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceType"))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceName"))
                {
                    resourceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
            }
            return new BasicDependency(id, resourceType.Value, resourceName.Value);
        }
    }
}
