// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Resources.Sample
{
    public partial class ApplicationNotificationPolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("notificationEndpoints");
            writer.WriteStartArray();
            foreach (var item in NotificationEndpoints)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static ApplicationNotificationPolicy DeserializeApplicationNotificationPolicy(JsonElement element)
        {
            IList<ApplicationNotificationEndpoint> notificationEndpoints = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("notificationEndpoints"))
                {
                    List<ApplicationNotificationEndpoint> array = new List<ApplicationNotificationEndpoint>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ApplicationNotificationEndpoint.DeserializeApplicationNotificationEndpoint(item));
                    }
                    notificationEndpoints = array;
                    continue;
                }
            }
            return new ApplicationNotificationPolicy(notificationEndpoints);
        }
    }
}
