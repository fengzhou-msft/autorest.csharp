// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using AutoRest.CSharp.Input;

namespace AutoRest.CSharp.Mgmt.Decorator
{
    internal static class SchemaPropertyTracker
    {
        private static readonly ConcurrentDictionary<Schema, bool> _propertyCache = new ConcurrentDictionary<Schema, bool>();

        public static bool Contains(this Schema schema)
        {
            return _propertyCache.ContainsKey(schema);
        }

        public static void Add(this Schema schema)
        {
            _propertyCache.TryAdd(schema, true);
        }
    }
}
