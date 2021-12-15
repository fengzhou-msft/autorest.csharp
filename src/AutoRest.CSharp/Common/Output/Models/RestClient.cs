﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using AutoRest.CSharp.Common.Output.Builders;
using AutoRest.CSharp.Input;
using AutoRest.CSharp.Output.Models.Requests;
using AutoRest.CSharp.Output.Models.Responses;
using AutoRest.CSharp.Output.Models.Serialization;
using AutoRest.CSharp.Output.Models.Shared;
using AutoRest.CSharp.Output.Models.Types;
using AutoRest.CSharp.Utilities;
using Azure.Core;
using Request = AutoRest.CSharp.Output.Models.Requests.Request;
using StatusCodes = AutoRest.CSharp.Output.Models.Responses.StatusCodes;

namespace AutoRest.CSharp.Output.Models
{
    internal class RestClient : TypeProvider
    {
        private readonly CachedDictionary<ServiceRequest, RestClientMethod> _requestMethods;
        private readonly CachedDictionary<ServiceRequest, RestClientMethod> _nextPageRequestMethods;
        private RestClientMethod[]? _allMethods;

        protected RestClient(OperationGroup operationGroup, BuildContext context, string? clientName)
            : this(operationGroup, null, context, ClientBuilder.GetClientPrefix(clientName ?? operationGroup.Language.Default.Name, context), "Rest" + ClientBuilder.GetClientSuffix(context)) { }

        protected RestClient(OperationGroup operationGroup, IEnumerable<RequestParameter>? clientParameters, BuildContext context, string clientPrefix, string defaultClientSuffix) : base(context)
        {
            OperationGroup = operationGroup;
            Builder = new RestClientBuilder(operationGroup, context);

            _requestMethods = new CachedDictionary<ServiceRequest, RestClientMethod>(EnsureNormalMethods);
            _nextPageRequestMethods = new CachedDictionary<ServiceRequest, RestClientMethod>(EnsureGetNextPageMethods);

            Parameters = Builder.GetOrderedParameters();

            ClientPrefix = clientPrefix;
            DefaultName = clientPrefix + defaultClientSuffix;
        }

        protected RestClientBuilder Builder;
        internal OperationGroup OperationGroup { get; }
        public Parameter[] Parameters { get; }
        public RestClientMethod[] Methods => _allMethods ??= BuildAllMethods().ToArray();
        public string ClientPrefix { get; }
        protected override string DefaultName { get; }
        protected override string DefaultAccessibility { get; } = "internal";

        private IEnumerable<RestClientMethod> BuildAllMethods()
        {
            foreach (var operation in OperationGroup.Operations)
            {
                foreach (var serviceRequest in operation.Requests)
                {
                    RestClientMethod method = GetOperationMethod(serviceRequest);
                    yield return method;
                }
            }

            foreach (var operation in OperationGroup.Operations)
            {
                foreach (var serviceRequest in operation.Requests)
                {
                    // remove duplicates when GetNextPage method is not autogenerated
                    if (GetNextOperationMethod(serviceRequest) is { } nextOperationMethod &&
                        operation.Language.Default.Paging?.NextLinkOperation == null)
                    {
                        yield return nextOperationMethod;
                    }
                }
            }
        }

        protected virtual Dictionary<ServiceRequest, RestClientMethod> EnsureNormalMethods()
        {
            var requestMethods = new Dictionary<ServiceRequest, RestClientMethod>();

            foreach (var operation in OperationGroup.Operations)
            {
                foreach (var serviceRequest in operation.Requests)
                {
                    // See also LowLevelRestClient::EnsureNormalMethods if changing
                    if (!(serviceRequest.Protocol.Http is HttpRequest httpRequest))
                    {
                        continue;
                    }
                    requestMethods.Add(serviceRequest, Builder.BuildMethod(operation, httpRequest, serviceRequest.Parameters, null, "public", ShouldReturnNullOn404(operation)));
                }
            }

            return requestMethods;
        }

        protected virtual Func<string?, bool> ShouldReturnNullOn404(Operation operation)
        {
            return (responseBodyType) => false;
        }

        protected Dictionary<ServiceRequest, RestClientMethod> EnsureGetNextPageMethods()
        {
            var nextPageMethods = new Dictionary<ServiceRequest, RestClientMethod>();
            foreach (var operation in OperationGroup.Operations)
            {
                var paging = operation.Language.Default.Paging;
                if (paging == null)
                {
                    continue;
                }
                foreach (var serviceRequest in operation.Requests)
                {
                    RestClientMethod? nextMethod = null;
                    if (paging.NextLinkOperation != null)
                    {
                        nextMethod = GetOperationMethod(paging.NextLinkOperation.Requests.Single());
                    }
                    else if (paging.NextLinkName != null)
                    {
                        var method = GetOperationMethod(serviceRequest);
                        nextMethod = RestClientBuilder.BuildNextPageMethod(method);
                    }

                    if (nextMethod != null)
                    {
                        nextPageMethods.Add(serviceRequest, nextMethod);
                    }
                }
            }

            return nextPageMethods;
        }

        public RestClientMethod? GetNextOperationMethod(ServiceRequest request)
        {
            _nextPageRequestMethods.TryGetValue(request, out RestClientMethod? value);
            return value;
        }

        public RestClientMethod GetOperationMethod(ServiceRequest request)
        {
            return _requestMethods[request];
        }
    }
}
