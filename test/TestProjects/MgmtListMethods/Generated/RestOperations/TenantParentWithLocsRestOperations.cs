// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;
using MgmtListMethods.Models;

namespace MgmtListMethods
{
    internal partial class TenantParentWithLocsRestOperations
    {
        private readonly string _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of TenantParentWithLocsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public TenantParentWithLocsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2020-06-01";
            _userAgent = Azure.ResourceManager.Core.HttpMessageUtilities.GetUserAgentName(this, applicationId);
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string tenantTestName, string tenantParentWithLocName, TenantParentWithLocData parameters)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Tenant/tenantTests/", false);
            uri.AppendPath(tenantTestName, true);
            uri.AppendPath("/tenantParentWithLocs/", false);
            uri.AppendPath(tenantParentWithLocName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(parameters);
            request.Content = content;
            message.SetProperty("SDKUserAgent", _userAgent);
            return message;
        }

        /// <summary> Create or update. </summary>
        /// <param name="tenantTestName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="tenantParentWithLocName"> Name. </param>
        /// <param name="parameters"> Parameters supplied to the Create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantTestName"/>, <paramref name="tenantParentWithLocName"/> or <paramref name="parameters"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="tenantTestName"/> or <paramref name="tenantParentWithLocName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<TenantParentWithLocData>> CreateOrUpdateAsync(string tenantTestName, string tenantParentWithLocName, TenantParentWithLocData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tenantTestName, nameof(tenantTestName));
            Argument.AssertNotNullOrEmpty(tenantParentWithLocName, nameof(tenantParentWithLocName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var message = CreateCreateOrUpdateRequest(tenantTestName, tenantParentWithLocName, parameters);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TenantParentWithLocData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = TenantParentWithLocData.DeserializeTenantParentWithLocData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Create or update. </summary>
        /// <param name="tenantTestName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="tenantParentWithLocName"> Name. </param>
        /// <param name="parameters"> Parameters supplied to the Create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantTestName"/>, <paramref name="tenantParentWithLocName"/> or <paramref name="parameters"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="tenantTestName"/> or <paramref name="tenantParentWithLocName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<TenantParentWithLocData> CreateOrUpdate(string tenantTestName, string tenantParentWithLocName, TenantParentWithLocData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tenantTestName, nameof(tenantTestName));
            Argument.AssertNotNullOrEmpty(tenantParentWithLocName, nameof(tenantParentWithLocName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var message = CreateCreateOrUpdateRequest(tenantTestName, tenantParentWithLocName, parameters);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TenantParentWithLocData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = TenantParentWithLocData.DeserializeTenantParentWithLocData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string tenantTestName, string tenantParentWithLocName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Tenant/tenantTests/", false);
            uri.AppendPath(tenantTestName, true);
            uri.AppendPath("/tenantParentWithLocs/", false);
            uri.AppendPath(tenantParentWithLocName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("SDKUserAgent", _userAgent);
            return message;
        }

        /// <summary> Retrieves information. </summary>
        /// <param name="tenantTestName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="tenantParentWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantTestName"/> or <paramref name="tenantParentWithLocName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="tenantTestName"/> or <paramref name="tenantParentWithLocName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<TenantParentWithLocData>> GetAsync(string tenantTestName, string tenantParentWithLocName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tenantTestName, nameof(tenantTestName));
            Argument.AssertNotNullOrEmpty(tenantParentWithLocName, nameof(tenantParentWithLocName));

            using var message = CreateGetRequest(tenantTestName, tenantParentWithLocName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TenantParentWithLocData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = TenantParentWithLocData.DeserializeTenantParentWithLocData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((TenantParentWithLocData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Retrieves information. </summary>
        /// <param name="tenantTestName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="tenantParentWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantTestName"/> or <paramref name="tenantParentWithLocName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="tenantTestName"/> or <paramref name="tenantParentWithLocName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<TenantParentWithLocData> Get(string tenantTestName, string tenantParentWithLocName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tenantTestName, nameof(tenantTestName));
            Argument.AssertNotNullOrEmpty(tenantParentWithLocName, nameof(tenantParentWithLocName));

            using var message = CreateGetRequest(tenantTestName, tenantParentWithLocName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TenantParentWithLocData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = TenantParentWithLocData.DeserializeTenantParentWithLocData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((TenantParentWithLocData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListRequest(string tenantTestName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Tenant/tenantTests/", false);
            uri.AppendPath(tenantTestName, true);
            uri.AppendPath("/tenantParentWithLocs", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("SDKUserAgent", _userAgent);
            return message;
        }

        /// <summary> Lists all in a resource group. </summary>
        /// <param name="tenantTestName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantTestName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="tenantTestName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<TenantParentWithLocListResult>> ListAsync(string tenantTestName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tenantTestName, nameof(tenantTestName));

            using var message = CreateListRequest(tenantTestName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TenantParentWithLocListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = TenantParentWithLocListResult.DeserializeTenantParentWithLocListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists all in a resource group. </summary>
        /// <param name="tenantTestName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantTestName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="tenantTestName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<TenantParentWithLocListResult> List(string tenantTestName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(tenantTestName, nameof(tenantTestName));

            using var message = CreateListRequest(tenantTestName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TenantParentWithLocListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = TenantParentWithLocListResult.DeserializeTenantParentWithLocListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string tenantTestName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("SDKUserAgent", _userAgent);
            return message;
        }

        /// <summary> Lists all in a resource group. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="tenantTestName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="tenantTestName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="tenantTestName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<TenantParentWithLocListResult>> ListNextPageAsync(string nextLink, string tenantTestName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(tenantTestName, nameof(tenantTestName));

            using var message = CreateListNextPageRequest(nextLink, tenantTestName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TenantParentWithLocListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = TenantParentWithLocListResult.DeserializeTenantParentWithLocListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists all in a resource group. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="tenantTestName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="tenantTestName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="tenantTestName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<TenantParentWithLocListResult> ListNextPage(string nextLink, string tenantTestName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(tenantTestName, nameof(tenantTestName));

            using var message = CreateListNextPageRequest(nextLink, tenantTestName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        TenantParentWithLocListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = TenantParentWithLocListResult.DeserializeTenantParentWithLocListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
