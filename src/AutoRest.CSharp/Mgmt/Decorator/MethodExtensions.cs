﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text.RegularExpressions;
using AutoRest.CSharp.Generation.Types;
using AutoRest.CSharp.Input;
using AutoRest.CSharp.Mgmt.AutoRest;
using AutoRest.CSharp.Mgmt.Models;
using AutoRest.CSharp.Mgmt.Output;
using AutoRest.CSharp.Output.Models;
using AutoRest.CSharp.Output.Models.Requests;
using AutoRest.CSharp.Output.Models.Types;
using Azure;
using Azure.ResourceManager.Resources;

namespace AutoRest.CSharp.Mgmt.Decorator
{
    internal static class MethodExtensions
    {
        /// <summary>
        /// Return true if this operation is a list method. Also returns the itemType and a collection of <see cref="Segment"/> as the extra scope
        /// For instance, /subscriptions/{}/providers/M.F/fakes will give you an empty collection for extra scope
        /// /subscriptions/{}/providers/M.F/locations/{location}/fakes will give you a collection [locations] as extra scope
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="itemType">The type of the item in the collection</param>
        /// <param name="extraScope">A collection of segments, which represents the extra scope comparing to its contextual path.</param>
        /// <returns></returns>
        public static bool IsListMethod(this MgmtRestOperation operation, [MaybeNullWhen(false)] out CSharpType itemType, [MaybeNullWhen(false)] out IEnumerable<Segment> extraScope)
        {
            extraScope = null;
            if (IsListMethod(operation.Method, out itemType, out _))
            {
                // get the scope
                extraScope = Enumerable.Empty<Segment>();
                // the contextual request path must be the parent of the request path of this operation, therefore we just assert this is non-null
                // for instance we have operation path: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/locations/{location}/nonResourceChild
                // we will get "providers/Microsoft.Fake/locations/{location}/nonResourceChild"
                var diff = operation.ContextualPath.TrimParentFrom(operation.RequestPath)!;
                // remove the "providers" segment and its value
                // we will get "locations/{location}/nonResourceChild"
                diff = RemoveProviders(diff);
                // remove the last segment, which is the thing that we are listing
                // we will get "locations/{location}"
                diff = diff.SkipLast(1);
                // we only keep the "keys" which has even index
                // we will get "locations"
                extraScope = diff.Where((_, index) => index % 2 == 0);

                return true;
            }

            return false;
        }

        private static IEnumerable<Segment> RemoveProviders(IEnumerable<Segment> diff)
        {
            var index = diff.ToList().IndexOf(Segment.Providers);
            if (index < 0)
                return diff;

            // remove the providers segment and its value
            var result = new List<Segment>();
            result.AddRange(diff.Take(index));
            result.AddRange(diff.Skip(index + 2));
            return result;
        }

        public static bool IsListMethod(this RestClientMethod method, [MaybeNullWhen(false)] out CSharpType itemType, [MaybeNullWhen(false)] out CSharpType returnType)
        {
            itemType = null;
            returnType = method.ReturnType;
            if (returnType == null)
                return false;

            if (returnType.IsFrameworkType || returnType.Implementation is not SchemaObjectType)
            {
                if (returnType.FrameworkType == typeof(IReadOnlyList<>))
                {
                    itemType = returnType.Arguments[0];
                }
            }
            else
            {
                var schemaObject = (SchemaObjectType)returnType.Implementation;
                itemType = GetValueProperty(schemaObject)?.ValueType.Arguments.FirstOrDefault();
            }
            return itemType != null;
        }

        public static bool IsListMethod(this RestClientMethod method)
        {
            return IsListMethod(method, out var _, out var _);
        }


        private static ObjectTypeProperty? GetValueProperty(SchemaObjectType schemaObject)
        {
            return schemaObject.Properties.FirstOrDefault(p => p.Declaration.Name == "Value" &&
                p.Declaration.Type.IsFrameworkType && p.Declaration.Type.FrameworkType == typeof(IReadOnlyList<>));
        }

        /// <summary>
        /// Get the body type of a ClientMethod
        /// </summary>
        /// <param name="clientMethod">the ClientMethod</param>
        /// <returns>the body type of the ClientMethod</returns>
        public static CSharpType? GetBodyType(this ClientMethod clientMethod)
        {
            return clientMethod.RestClientMethod.ReturnType;
        }

        /// <summary>
        /// Get the proper return type of the ClientMethod considering the async status
        /// </summary>
        /// <param name="clientMethod">the ClientMethod</param>
        /// <param name="async">Is this method async?</param>
        /// <returns>the response type of the ClientMethod</returns>
        public static CSharpType GetResponseType(this ClientMethod clientMethod, bool async)
        {
            var bodyType = clientMethod.GetBodyType();
            var responseType = bodyType != null ? new CSharpType(typeof(Response<>), bodyType) : typeof(Response);
            return responseType.WrapAsync(async);
        }

        /// <summary>
        /// Get the proper return type of the PagingMethod considering the async status
        /// </summary>
        /// <param name="pagingMethod">the PagingMethod</param>
        /// <param name="async">Is this method async?</param>
        /// <returns>the response type of the PagingMethod</returns>
        public static CSharpType GetResponseType(this PagingMethod pagingMethod, bool async)
        {
            var pageType = pagingMethod.PagingResponse.ItemType;
            return pageType.WrapPageable(async);
        }

        ///// <summary>
        ///// Checks if parent exists in path parameters
        ///// </summary>
        ///// <param name="clientMethod">Rest client method</param>
        ///// <param name="parentResourceType">Parent resource type</param>
        //public static bool IsParentExistsInPathParamaters(this RestClientMethod clientMethod, string parentResourceType)
        //{
        //    var isParentExistsInPathParams = false;
        //    if (clientMethod.Operation?.Requests.FirstOrDefault().Protocol.Http is HttpRequest httpRequest)
        //    {
        //        if (clientMethod.Operation.AncestorResourceType() == ResourceTypeBuilder.Tenant)
        //        {
        //            return true;
        //        }
        //        // Example - "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/parents/{parentName}/subParents/{instanceId}/children"
        //        var fullPath = httpRequest.Path.ToLower();
        //        parentResourceType = parentResourceType.ToLower();

        //        // This will replace -
        //        // "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/parents/{parentName}/subParents/{instanceId}/children" with
        //        // "/subscriptions/resourceGroups/providers/Microsoft.Compute/parents/subParents/children" in order to find the parent
        //        var path = Regex.Replace(fullPath, @"\{[a-zA-Z]+\}\/", "");
        //        var isParentFound = path.IndexOf(parentResourceType);
        //        if (isParentFound != -1)
        //        {
        //            // Parent is found, now check if the parent exists in path parameters
        //            var parentArr = parentResourceType.Split('/');
        //            var fullPathArr = fullPath.Split('/');
        //            foreach (var parentSegment in parentArr)
        //            {
        //                var index = Array.IndexOf(fullPathArr, parentSegment);
        //                if (index + 1 < fullPathArr.Length && fullPathArr[index + 1].StartsWith('{'))
        //                {
        //                    char[] charsToTrim = { '{', '}' };
        //                    var parentParamName = fullPathArr[index + 1].Trim(charsToTrim);
        //                    isParentExistsInPathParams = clientMethod.Request.PathParameterSegments.Any(p => p.Value.Reference.Name.Equals(parentParamName, StringComparison.InvariantCultureIgnoreCase));
        //                    if (isParentExistsInPathParams)
        //                    {
        //                        break;
        //                    }
        //                }
        //            }
        //        }
        //    }

        //    return isParentExistsInPathParams;
        //}

        public static bool IsByIdMethod(this RestClientMethod clientMethod)
        {
            return clientMethod.Operation?.Requests.FirstOrDefault()?.Protocol.Http is HttpRequest httpRequest && clientMethod.Parameters.Count() > 0 && $"/{{{clientMethod.Parameters[0].Name}}}".Equals(httpRequest.Path);
        }

        public static bool IsPagingOperation(this MgmtClientOperation clientOperation, BuildContext<MgmtOutputLibrary> context)
        {
            return clientOperation.Any(restOperation => restOperation.IsPagingOperation(context));
        }

        public static bool IsLongRunningOperation(this MgmtClientOperation clientOperation)
        {
            return clientOperation.Any(restOperation => restOperation.IsLongRunningOperation());
        }

        public static bool IsLongRunningReallyLong(this MgmtClientOperation clientOperation)
        {
            return clientOperation.Any(restOperation => restOperation.IsLongRunningReallyLong());
        }

        public static bool IsPagingOperation(this MgmtRestOperation restOperation, BuildContext<MgmtOutputLibrary> context)
        {
            return restOperation.GetPagingMethod(context) != null;
        }

        public static PagingMethod? GetPagingMethod(this MgmtRestOperation restOperation, BuildContext<MgmtOutputLibrary> context)
        {
            if (context.Library.PagingMethods.TryGetValue(restOperation.Method, out var pagingMethod))
                return pagingMethod;

            return null;
        }

        public static bool IsLongRunningOperation(this MgmtRestOperation restOperation)
        {
            return restOperation.Operation.IsLongRunning;
        }

        public static bool IsLongRunningReallyLong(this MgmtRestOperation restOperation)
        {
            return restOperation.Operation.IsLongRunningReallyLong ?? false;
        }
    }
}
