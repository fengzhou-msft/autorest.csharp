// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace BodyAndPath_LowLevel
{
    /// <summary> The BodyAndPath service client. </summary>
    public partial class BodyAndPathClient
    {
        private const string AuthorizationHeader = "Fake-Subscription-Key";
        private readonly AzureKeyCredential _keyCredential;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of BodyAndPathClient for mocking. </summary>
        protected BodyAndPathClient()
        {
        }

        /// <summary> Initializes a new instance of BodyAndPathClient. </summary>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="credential"/> is null. </exception>
        public BodyAndPathClient(AzureKeyCredential credential, Uri endpoint = null, BodyAndPathClientOptions options = null)
        {
            Argument.AssertNotNull(credential, nameof(credential));
            endpoint ??= new Uri("http://localhost:3000");
            options ??= new BodyAndPathClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options);
            _keyCredential = credential;
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), new HttpPipelinePolicy[] { new AzureKeyCredentialPolicy(_keyCredential, AuthorizationHeader) }, new ResponseClassifier());
            _endpoint = endpoint;
        }

        /// <summary> Resets products. </summary>
        /// <param name="itemName"> item name. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="itemName"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="itemName"/> is an empty string, and was expected to be non-empty. </exception>
        public virtual async Task<Response> CreateAsync(string itemName, RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(itemName, nameof(itemName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("BodyAndPathClient.Create");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateRequest(itemName, content, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Resets products. </summary>
        /// <param name="itemName"> item name. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="itemName"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="itemName"/> is an empty string, and was expected to be non-empty. </exception>
        public virtual Response Create(string itemName, RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(itemName, nameof(itemName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("BodyAndPathClient.Create");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateRequest(itemName, content, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Resets products. </summary>
        /// <param name="itemNameStream"> item name. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="contentType"> Upload file type. Allowed values: &quot;application/json&quot; | &quot;application/octet-stream&quot;. </param>
        /// <param name="excluded"> Excluded connection Ids. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="itemNameStream"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="itemNameStream"/> is an empty string, and was expected to be non-empty. </exception>
        public virtual async Task<Response> CreateStreamAsync(string itemNameStream, RequestContent content, ContentType contentType, IEnumerable<string> excluded = null, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(itemNameStream, nameof(itemNameStream));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("BodyAndPathClient.CreateStream");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateStreamRequest(itemNameStream, content, contentType, excluded, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Resets products. </summary>
        /// <param name="itemNameStream"> item name. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="contentType"> Upload file type. Allowed values: &quot;application/json&quot; | &quot;application/octet-stream&quot;. </param>
        /// <param name="excluded"> Excluded connection Ids. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="itemNameStream"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="itemNameStream"/> is an empty string, and was expected to be non-empty. </exception>
        public virtual Response CreateStream(string itemNameStream, RequestContent content, ContentType contentType, IEnumerable<string> excluded = null, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(itemNameStream, nameof(itemNameStream));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("BodyAndPathClient.CreateStream");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateStreamRequest(itemNameStream, content, contentType, excluded, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Resets products. </summary>
        /// <param name="enumName1"> The first name. Allowed values: &quot;current&quot; | &quot;default&quot;. </param>
        /// <param name="enumName2"> The second name. Allowed values: &quot;latest&quot;. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="enumName1"/>, <paramref name="enumName2"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="enumName1"/> or <paramref name="enumName2"/> is an empty string, and was expected to be non-empty. </exception>
        public virtual async Task<Response> CreateEnumAsync(string enumName1, string enumName2, RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(enumName1, nameof(enumName1));
            Argument.AssertNotNullOrEmpty(enumName2, nameof(enumName2));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("BodyAndPathClient.CreateEnum");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateEnumRequest(enumName1, enumName2, content, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Resets products. </summary>
        /// <param name="enumName1"> The first name. Allowed values: &quot;current&quot; | &quot;default&quot;. </param>
        /// <param name="enumName2"> The second name. Allowed values: &quot;latest&quot;. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="enumName1"/>, <paramref name="enumName2"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="enumName1"/> or <paramref name="enumName2"/> is an empty string, and was expected to be non-empty. </exception>
        public virtual Response CreateEnum(string enumName1, string enumName2, RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(enumName1, nameof(enumName1));
            Argument.AssertNotNullOrEmpty(enumName2, nameof(enumName2));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("BodyAndPathClient.CreateEnum");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateEnumRequest(enumName1, enumName2, content, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> List all. </summary>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        public virtual async Task<Response> GetBodyAndPathsAsync(RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("BodyAndPathClient.GetBodyAndPaths");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetBodyAndPathsRequest(context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> List all. </summary>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        public virtual Response GetBodyAndPaths(RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("BodyAndPathClient.GetBodyAndPaths");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetBodyAndPathsRequest(context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> List all products. </summary>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        public virtual async Task<Response> GetItemsAsync(RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("BodyAndPathClient.GetItems");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetItemsRequest(context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> List all products. </summary>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        public virtual Response GetItems(RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("BodyAndPathClient.GetItems");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetItemsRequest(context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="item3"> Expected to be the first parameter because of its position in the path. </param>
        /// <param name="item2"> Expected to be the second parameter because of its position in the path. &apos;item4&apos; in the path isn&apos;t a parameter, it is a static part of the path. </param>
        /// <param name="item4"> Expected to be the third parameter because it is a required query parameter. &apos;item4&apos; in the path isn&apos;t a parameter, it is a static part of the path. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="item5"> Expected to be the fifth parameter because it is an optional query parameter which goes after RequestContent. </param>
        /// <param name="item1"> Expected to be the sixth parameter because it is a query parameter and has a default value, so it is treated as optional despite &apos;required: true&apos;. &apos;item1&apos; in the path isn&apos;t a parameter, it is a static part of the path. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="item3"/>, <paramref name="item2"/>, <paramref name="item4"/> or <paramref name="item1"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="item3"/> or <paramref name="item2"/> is an empty string, and was expected to be non-empty. </exception>
        public virtual async Task<Response> UpdateAsync(string item3, string item2, string item4, RequestContent content, string item5 = null, string item1 = "value", RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(item3, nameof(item3));
            Argument.AssertNotNullOrEmpty(item2, nameof(item2));
            Argument.AssertNotNull(item4, nameof(item4));
            Argument.AssertNotNull(item1, nameof(item1));

            using var scope = ClientDiagnostics.CreateScope("BodyAndPathClient.Update");
            scope.Start();
            try
            {
                using HttpMessage message = CreateUpdateRequest(item3, item2, item4, content, item5, item1, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="item3"> Expected to be the first parameter because of its position in the path. </param>
        /// <param name="item2"> Expected to be the second parameter because of its position in the path. &apos;item4&apos; in the path isn&apos;t a parameter, it is a static part of the path. </param>
        /// <param name="item4"> Expected to be the third parameter because it is a required query parameter. &apos;item4&apos; in the path isn&apos;t a parameter, it is a static part of the path. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="item5"> Expected to be the fifth parameter because it is an optional query parameter which goes after RequestContent. </param>
        /// <param name="item1"> Expected to be the sixth parameter because it is a query parameter and has a default value, so it is treated as optional despite &apos;required: true&apos;. &apos;item1&apos; in the path isn&apos;t a parameter, it is a static part of the path. </param>
        /// <param name="context"> The request context, which can override default behaviors on the request on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="item3"/>, <paramref name="item2"/>, <paramref name="item4"/> or <paramref name="item1"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="item3"/> or <paramref name="item2"/> is an empty string, and was expected to be non-empty. </exception>
        public virtual Response Update(string item3, string item2, string item4, RequestContent content, string item5 = null, string item1 = "value", RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(item3, nameof(item3));
            Argument.AssertNotNullOrEmpty(item2, nameof(item2));
            Argument.AssertNotNull(item4, nameof(item4));
            Argument.AssertNotNull(item1, nameof(item1));

            using var scope = ClientDiagnostics.CreateScope("BodyAndPathClient.Update");
            scope.Start();
            try
            {
                using HttpMessage message = CreateUpdateRequest(item3, item2, item4, content, item5, item1, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateCreateRequest(string itemName, RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(itemName, true);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            message.ResponseClassifier = ResponseClassifier200.Instance;
            return message;
        }

        internal HttpMessage CreateCreateStreamRequest(string itemNameStream, RequestContent content, ContentType contentType, IEnumerable<string> excluded, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(itemNameStream, true);
            if (excluded != null)
            {
                foreach (var param in excluded)
                {
                    uri.AppendQuery("excluded", param, true);
                }
            }
            request.Uri = uri;
            request.Headers.Add("Content-Type", contentType.ToString());
            request.Content = content;
            message.ResponseClassifier = ResponseClassifier200.Instance;
            return message;
        }

        internal HttpMessage CreateCreateEnumRequest(string enumName1, string enumName2, RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(enumName1, true);
            uri.AppendPath("/", false);
            uri.AppendPath(enumName2, true);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            message.ResponseClassifier = ResponseClassifier200.Instance;
            return message;
        }

        internal HttpMessage CreateGetBodyAndPathsRequest(RequestContext context)
        {
            var message = _pipeline.CreateMessage(context);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/list", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.ResponseClassifier = ResponseClassifier200.Instance;
            return message;
        }

        internal HttpMessage CreateGetItemsRequest(RequestContext context)
        {
            var message = _pipeline.CreateMessage(context);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/listItems", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.ResponseClassifier = ResponseClassifier200.Instance;
            return message;
        }

        internal HttpMessage CreateUpdateRequest(string item3, string item2, string item4, RequestContent content, string item5, string item1, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/", false);
            uri.AppendPath(item3, true);
            uri.AppendPath("/item4/", false);
            uri.AppendPath(item2, true);
            uri.AppendPath("/item1", false);
            uri.AppendQuery("item4", item4, true);
            if (item5 != null)
            {
                uri.AppendQuery("item5", item5, true);
            }
            uri.AppendQuery("item1", item1, true);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            message.ResponseClassifier = ResponseClassifier200.Instance;
            return message;
        }

        private sealed class ResponseClassifier200 : ResponseClassifier
        {
            private static ResponseClassifier _instance;
            public static ResponseClassifier Instance => _instance ??= new ResponseClassifier200();
            public override bool IsErrorResponse(HttpMessage message)
            {
                return message.Response.Status switch
                {
                    200 => false,
                    _ => true
                };
            }
        }
    }
}
