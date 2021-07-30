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
using MgmtMultipleParentResource.Models;

namespace MgmtMultipleParentResource
{
    internal partial class AnotherChildrenRestOperations
    {
        private string subscriptionId;
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of AnotherChildrenRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="apiVersion"/> is null. </exception>
        public AnotherChildrenRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null, string apiVersion = "2021-03-01")
        {
            this.subscriptionId = subscriptionId ?? throw new ArgumentNullException(nameof(subscriptionId));
            this.endpoint = endpoint ?? new Uri("https://management.azure.com");
            this.apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string resourceGroupName, string anotherName, string childName, ChildBodyData childBody)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Compute/anotherParents/", false);
            uri.AppendPath(anotherName, true);
            uri.AppendPath("/children/", false);
            uri.AppendPath(childName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json, text/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(childBody);
            request.Content = content;
            return message;
        }

        /// <summary> The operation to create or update the run command. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="anotherName"> The name of the virtual machine where the run command should be created or updated. </param>
        /// <param name="childName"> The name of the virtual machine run command. </param>
        /// <param name="childBody"> Parameters supplied to the Create Virtual Machine RunCommand operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="anotherName"/>, <paramref name="childName"/>, or <paramref name="childBody"/> is null. </exception>
        public async Task<Response> CreateOrUpdateAsync(string resourceGroupName, string anotherName, string childName, ChildBodyData childBody, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (anotherName == null)
            {
                throw new ArgumentNullException(nameof(anotherName));
            }
            if (childName == null)
            {
                throw new ArgumentNullException(nameof(childName));
            }
            if (childBody == null)
            {
                throw new ArgumentNullException(nameof(childBody));
            }

            using var message = CreateCreateOrUpdateRequest(resourceGroupName, anotherName, childName, childBody);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> The operation to create or update the run command. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="anotherName"> The name of the virtual machine where the run command should be created or updated. </param>
        /// <param name="childName"> The name of the virtual machine run command. </param>
        /// <param name="childBody"> Parameters supplied to the Create Virtual Machine RunCommand operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="anotherName"/>, <paramref name="childName"/>, or <paramref name="childBody"/> is null. </exception>
        public Response CreateOrUpdate(string resourceGroupName, string anotherName, string childName, ChildBodyData childBody, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (anotherName == null)
            {
                throw new ArgumentNullException(nameof(anotherName));
            }
            if (childName == null)
            {
                throw new ArgumentNullException(nameof(childName));
            }
            if (childBody == null)
            {
                throw new ArgumentNullException(nameof(childBody));
            }

            using var message = CreateCreateOrUpdateRequest(resourceGroupName, anotherName, childName, childBody);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateUpdateRequest(string resourceGroupName, string anotherName, string childName, ChildBodyUpdate childBody)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Compute/anotherParents/", false);
            uri.AppendPath(anotherName, true);
            uri.AppendPath("/children/", false);
            uri.AppendPath(childName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json, text/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(childBody);
            request.Content = content;
            return message;
        }

        /// <summary> The operation to update the run command. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="anotherName"> The name of the virtual machine where the run command should be updated. </param>
        /// <param name="childName"> The name of the virtual machine run command. </param>
        /// <param name="childBody"> Parameters supplied to the Update Virtual Machine RunCommand operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="anotherName"/>, <paramref name="childName"/>, or <paramref name="childBody"/> is null. </exception>
        public async Task<Response> UpdateAsync(string resourceGroupName, string anotherName, string childName, ChildBodyUpdate childBody, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (anotherName == null)
            {
                throw new ArgumentNullException(nameof(anotherName));
            }
            if (childName == null)
            {
                throw new ArgumentNullException(nameof(childName));
            }
            if (childBody == null)
            {
                throw new ArgumentNullException(nameof(childBody));
            }

            using var message = CreateUpdateRequest(resourceGroupName, anotherName, childName, childBody);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> The operation to update the run command. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="anotherName"> The name of the virtual machine where the run command should be updated. </param>
        /// <param name="childName"> The name of the virtual machine run command. </param>
        /// <param name="childBody"> Parameters supplied to the Update Virtual Machine RunCommand operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="anotherName"/>, <paramref name="childName"/>, or <paramref name="childBody"/> is null. </exception>
        public Response Update(string resourceGroupName, string anotherName, string childName, ChildBodyUpdate childBody, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (anotherName == null)
            {
                throw new ArgumentNullException(nameof(anotherName));
            }
            if (childName == null)
            {
                throw new ArgumentNullException(nameof(childName));
            }
            if (childBody == null)
            {
                throw new ArgumentNullException(nameof(childBody));
            }

            using var message = CreateUpdateRequest(resourceGroupName, anotherName, childName, childBody);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string resourceGroupName, string anotherName, string childName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Compute/anotherParents/", false);
            uri.AppendPath(anotherName, true);
            uri.AppendPath("/children/", false);
            uri.AppendPath(childName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json, text/json");
            return message;
        }

        /// <summary> The operation to delete the run command. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="anotherName"> The name of the virtual machine where the run command should be deleted. </param>
        /// <param name="childName"> The name of the virtual machine run command. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="anotherName"/>, or <paramref name="childName"/> is null. </exception>
        public async Task<Response> DeleteAsync(string resourceGroupName, string anotherName, string childName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (anotherName == null)
            {
                throw new ArgumentNullException(nameof(anotherName));
            }
            if (childName == null)
            {
                throw new ArgumentNullException(nameof(childName));
            }

            using var message = CreateDeleteRequest(resourceGroupName, anotherName, childName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> The operation to delete the run command. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="anotherName"> The name of the virtual machine where the run command should be deleted. </param>
        /// <param name="childName"> The name of the virtual machine run command. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="anotherName"/>, or <paramref name="childName"/> is null. </exception>
        public Response Delete(string resourceGroupName, string anotherName, string childName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (anotherName == null)
            {
                throw new ArgumentNullException(nameof(anotherName));
            }
            if (childName == null)
            {
                throw new ArgumentNullException(nameof(childName));
            }

            using var message = CreateDeleteRequest(resourceGroupName, anotherName, childName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string resourceGroupName, string anotherName, string childName, string expand)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Compute/anotherParents/", false);
            uri.AppendPath(anotherName, true);
            uri.AppendPath("/children/", false);
            uri.AppendPath(childName, true);
            if (expand != null)
            {
                uri.AppendQuery("$expand", expand, true);
            }
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json, text/json");
            return message;
        }

        /// <summary> The operation to get the run command. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="anotherName"> The name of the virtual machine containing the run command. </param>
        /// <param name="childName"> The name of the virtual machine run command. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="anotherName"/>, or <paramref name="childName"/> is null. </exception>
        public async Task<Response<ChildBodyData>> GetAsync(string resourceGroupName, string anotherName, string childName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (anotherName == null)
            {
                throw new ArgumentNullException(nameof(anotherName));
            }
            if (childName == null)
            {
                throw new ArgumentNullException(nameof(childName));
            }

            using var message = CreateGetRequest(resourceGroupName, anotherName, childName, expand);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ChildBodyData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ChildBodyData.DeserializeChildBodyData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ChildBodyData)null, message.Response);
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> The operation to get the run command. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="anotherName"> The name of the virtual machine containing the run command. </param>
        /// <param name="childName"> The name of the virtual machine run command. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="anotherName"/>, or <paramref name="childName"/> is null. </exception>
        public Response<ChildBodyData> Get(string resourceGroupName, string anotherName, string childName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (anotherName == null)
            {
                throw new ArgumentNullException(nameof(anotherName));
            }
            if (childName == null)
            {
                throw new ArgumentNullException(nameof(childName));
            }

            using var message = CreateGetRequest(resourceGroupName, anotherName, childName, expand);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ChildBodyData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ChildBodyData.DeserializeChildBodyData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ChildBodyData)null, message.Response);
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetAllRequest(string resourceGroupName, string anotherName, string expand)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Compute/anotherParents/", false);
            uri.AppendPath(anotherName, true);
            uri.AppendPath("/children", false);
            if (expand != null)
            {
                uri.AppendQuery("$expand", expand, true);
            }
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json, text/json");
            return message;
        }

        /// <summary> The operation to get all run commands of a Virtual Machine. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="anotherName"> The name of the virtual machine containing the run command. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="anotherName"/> is null. </exception>
        public async Task<Response<ChildBodiesListResult>> GetAllAsync(string resourceGroupName, string anotherName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (anotherName == null)
            {
                throw new ArgumentNullException(nameof(anotherName));
            }

            using var message = CreateGetAllRequest(resourceGroupName, anotherName, expand);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ChildBodiesListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ChildBodiesListResult.DeserializeChildBodiesListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> The operation to get all run commands of a Virtual Machine. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="anotherName"> The name of the virtual machine containing the run command. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="anotherName"/> is null. </exception>
        public Response<ChildBodiesListResult> GetAll(string resourceGroupName, string anotherName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (anotherName == null)
            {
                throw new ArgumentNullException(nameof(anotherName));
            }

            using var message = CreateGetAllRequest(resourceGroupName, anotherName, expand);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ChildBodiesListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ChildBodiesListResult.DeserializeChildBodiesListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetAllNextPageRequest(string nextLink, string resourceGroupName, string anotherName, string expand)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json, text/json");
            return message;
        }

        /// <summary> The operation to get all run commands of a Virtual Machine. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="anotherName"> The name of the virtual machine containing the run command. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="resourceGroupName"/>, or <paramref name="anotherName"/> is null. </exception>
        public async Task<Response<ChildBodiesListResult>> GetAllNextPageAsync(string nextLink, string resourceGroupName, string anotherName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (anotherName == null)
            {
                throw new ArgumentNullException(nameof(anotherName));
            }

            using var message = CreateGetAllNextPageRequest(nextLink, resourceGroupName, anotherName, expand);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ChildBodiesListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ChildBodiesListResult.DeserializeChildBodiesListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> The operation to get all run commands of a Virtual Machine. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="anotherName"> The name of the virtual machine containing the run command. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="resourceGroupName"/>, or <paramref name="anotherName"/> is null. </exception>
        public Response<ChildBodiesListResult> GetAllNextPage(string nextLink, string resourceGroupName, string anotherName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (anotherName == null)
            {
                throw new ArgumentNullException(nameof(anotherName));
            }

            using var message = CreateGetAllNextPageRequest(nextLink, resourceGroupName, anotherName, expand);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ChildBodiesListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ChildBodiesListResult.DeserializeChildBodiesListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
