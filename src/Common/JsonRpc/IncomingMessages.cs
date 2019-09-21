﻿using System;
using System.Text.Json;
using System.Threading;
using AutoRest.CSharp.V3.Common.Utilities;
using Microsoft.Perks.JsonRPC;

namespace AutoRest.CSharp.V3.Common.JsonRpc
{
    internal delegate bool ProcessAction(Connection connection, string pluginName, string sessionId);

    internal static class IncomingMessages
    {
        public static string GetPluginNames(this IncomingRequest _, params string[] pluginNames) => pluginNames.ToJsonArray();

        public static string Process(this IncomingRequest request, Connection connection, ProcessAction processAction)
        {
            var parameters = request.Params.ToStringArray();
            var (pluginName, sessionId) = (parameters[0], parameters[1]);
            return processAction(connection, pluginName, sessionId).ToJsonBool();
        }

        public static string Shutdown(this IncomingRequest _, CancellationTokenSource tokenSource)
        {
            tokenSource.Cancel();
            return null;
        }

        public static T ParseResponseType<T>(string jsonResponse)
        {
            var element = jsonResponse.Parse();
            return typeof(T) switch
            {
                var t when t == typeof(string) => (T)(object)element.ToStringValue(),
                var t when t == typeof(string[]) => (T)(object)element.ToStringArray(),
                var t when t == typeof(int?) => (T)(object)element.ToNumber(),
                var t when t == typeof(bool?) => (T)(object)element.ToBoolean(),
                var t when t == typeof(JsonElement?) => (T)(object)element,
                _ => throw new NotSupportedException($"Type {typeof(T)} is not a supported response type.")
            };
        }
    }

    internal class IncomingRequest
    {
        public string JsonRpc { get; } = "2.0";
        public string Method { get; set; }
        public JsonElement? Params { get; set; }
        public string Id { get; set; }
    }

    internal class IncomingResponse
    {
        public string JsonRpc { get; } = "2.0";
        public string Result { get; set; }
        public string Id { get; set; }
    }
}
