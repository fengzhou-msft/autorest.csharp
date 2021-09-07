// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System.Collections.Concurrent;
using System.Collections.Generic;
using AutoRest.CSharp.Input;

namespace AutoRest.CSharp.Mgmt.Decorator
{
    internal static class OperationHttpMethodMapper
    {
        private static ConcurrentDictionary<OperationGroup, Dictionary<HttpMethod, List<ServiceRequest>>> _valueCache = new ConcurrentDictionary<OperationGroup, Dictionary<HttpMethod, List<ServiceRequest>>>();
        private static ConcurrentDictionary<OperationGroup, Dictionary<HttpMethod, List<ServiceResponse>>> _responseValueCache = new ConcurrentDictionary<OperationGroup, Dictionary<HttpMethod, List<ServiceResponse>>>();

        public static Dictionary<HttpMethod, List<ServiceRequest>> OperationHttpMethodMapping(this OperationGroup operationGroup)
        {
            Dictionary<HttpMethod, List<ServiceRequest>>? result;
            if (_valueCache.TryGetValue(operationGroup, out result))
                return result;

            (result, _) = MapHttpMethodToOperation(operationGroup);
            _valueCache.TryAdd(operationGroup, result);
            return result;
        }

        private static (Dictionary<HttpMethod, List<ServiceRequest>> RequestMapping, Dictionary<HttpMethod, List<ServiceResponse>> ResponseMapping) MapHttpMethodToOperation(OperationGroup operationsGroup)
        {
            var result = new Dictionary<HttpMethod, List<ServiceRequest>>();
            var responseResult = new Dictionary<HttpMethod, List<ServiceResponse>>();
            foreach (var operation in operationsGroup.Operations)
            {
                foreach (var serviceRequest in operation.Requests)
                {
                    if (serviceRequest.Protocol.Http is HttpRequest httpRequest)
                    {
                        List<ServiceRequest>? list;
                        if (!result.TryGetValue(httpRequest.Method, out list))
                        {
                            list = new List<ServiceRequest>();
                            result.Add(httpRequest.Method, list);
                        }
                        list.Add(serviceRequest);

                        foreach (var serviceResponse in operation.Responses)
                        {
                            if (serviceResponse.Protocol.Http is HttpResponse httpResponse)
                            {
                                List<ServiceResponse>? resList;
                                if (!responseResult.TryGetValue(httpRequest.Method, out resList))
                                {
                                    resList = new List<ServiceResponse>();
                                    responseResult.Add(httpRequest.Method, resList);
                                }
                                resList.Add(serviceResponse);
                            }
                        }
                    }
                }
            }
            return (result, responseResult);
        }

        public static Dictionary<HttpMethod, List<ServiceResponse>> OperationHttpMethodResponseMapping(this OperationGroup operationGroup)
        {
            Dictionary<HttpMethod, List<ServiceResponse>>? result;
            if (_responseValueCache.TryGetValue(operationGroup, out result))
                return result;

            (_, result) = MapHttpMethodToOperation(operationGroup);
            _responseValueCache.TryAdd(operationGroup, result);
            return result;
        }
    }
}
