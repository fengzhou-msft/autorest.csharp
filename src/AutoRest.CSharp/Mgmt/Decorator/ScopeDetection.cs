// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License

using System.Collections.Concurrent;
using System.Linq;
using AutoRest.CSharp.AutoRest.Plugins;
using AutoRest.CSharp.Input;

namespace AutoRest.CSharp.Mgmt.Decorator
{
    internal static class ScopeDetection
    {
        private static string[] ScopeKeywords = { "/{scope}"};

        private static ConcurrentDictionary<OperationGroup, bool> _valueCache = new ConcurrentDictionary<OperationGroup, bool>();

        public static bool IsScopeResource(this OperationGroup operationGroup)
        {
            if (_valueCache.TryGetValue(operationGroup, out var result))
                return result;

            result = IsScope(operationGroup);
            _valueCache.TryAdd(operationGroup, result);
            return result;
        }

        private static bool IsScope(OperationGroup operationGroup)
        {
            foreach (var operation in operationGroup.Operations)
            {
                // Check to see if any PUT operation path starts with Scope keywords
                if (operation.Requests.FirstOrDefault()?.Protocol.Http is HttpRequest httpRequest
                    && httpRequest.Method == HttpMethod.Put
                    && ScopeKeywords.Any(w => httpRequest.Path.StartsWith(w)))
                {
                    return true;
                }
            }
            return false;

            // If no match found, double check if operation group's resource has been set to singleton in config
            // return config.SingletonResource.Contains(operationGroup.Resource(config));
        }
    }
}
