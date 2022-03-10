// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using MultipleInputFiles.Models;

namespace MultipleInputFiles
{
    internal partial class MultipleInputFilesRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly Source? _source;

        /// <summary> Initializes a new instance of MultipleInputFilesRestClient. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="source"> source - server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> is null. </exception>
        public MultipleInputFilesRestClient(HttpPipeline pipeline, Source? source = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _source = source ?? new Source("value1");
        }

        internal HttpMessage CreateOperation1Request(TestModel value)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw("https://", false);
            uri.AppendRaw(_source.Value.ToString(), true);
            uri.AppendRaw(".fakeendpoint.azure.com", false);
            uri.AppendPath("/operation1", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(value);
            request.Content = content;
            return message;
        }

        /// <param name="value"> The TestModel to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public async Task<Response> Operation1Async(TestModel value, CancellationToken cancellationToken = default)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            using var message = CreateOperation1Request(value);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <param name="value"> The TestModel to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Response Operation1(TestModel value, CancellationToken cancellationToken = default)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            using var message = CreateOperation1Request(value);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateOperation2Request(TestModel value)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw("https://", false);
            uri.AppendRaw(_source.Value.ToString(), true);
            uri.AppendRaw(".fakeendpoint.azure.com", false);
            uri.AppendPath("/operation2", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(value);
            request.Content = content;
            return message;
        }

        /// <param name="value"> The TestModel to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public async Task<Response> Operation2Async(TestModel value, CancellationToken cancellationToken = default)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            using var message = CreateOperation2Request(value);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <param name="value"> The TestModel to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Response Operation2(TestModel value, CancellationToken cancellationToken = default)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            using var message = CreateOperation2Request(value);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
