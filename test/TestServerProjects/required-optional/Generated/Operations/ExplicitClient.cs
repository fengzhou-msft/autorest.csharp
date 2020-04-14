// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using required_optional.Models;

namespace required_optional
{
    public partial class ExplicitClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal ExplicitRestClient RestClient { get; }
        /// <summary> Initializes a new instance of ExplicitClient for mocking. </summary>
        protected ExplicitClient()
        {
        }
        /// <summary> Initializes a new instance of ExplicitClient. </summary>
        internal ExplicitClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string host = "http://localhost:3000")
        {
            RestClient = new ExplicitRestClient(clientDiagnostics, pipeline, host);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Test explicitly required integer. Please put null and the client library should throw before the request is sent. </summary>
        /// <param name="bodyParameter"> The Integer to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> PostRequiredIntegerParameterAsync(int bodyParameter, CancellationToken cancellationToken = default)
        {
            return await RestClient.PostRequiredIntegerParameterAsync(bodyParameter, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Test explicitly required integer. Please put null and the client library should throw before the request is sent. </summary>
        /// <param name="bodyParameter"> The Integer to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response PostRequiredIntegerParameter(int bodyParameter, CancellationToken cancellationToken = default)
        {
            return RestClient.PostRequiredIntegerParameter(bodyParameter, cancellationToken);
        }

        /// <summary> Test explicitly optional integer. Please put null. </summary>
        /// <param name="bodyParameter"> The Integer to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> PostOptionalIntegerParameterAsync(int? bodyParameter = null, CancellationToken cancellationToken = default)
        {
            return await RestClient.PostOptionalIntegerParameterAsync(bodyParameter, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Test explicitly optional integer. Please put null. </summary>
        /// <param name="bodyParameter"> The Integer to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response PostOptionalIntegerParameter(int? bodyParameter = null, CancellationToken cancellationToken = default)
        {
            return RestClient.PostOptionalIntegerParameter(bodyParameter, cancellationToken);
        }

        /// <summary> Test explicitly required integer. Please put a valid int-wrapper with &apos;value&apos; = null and the client library should throw before the request is sent. </summary>
        /// <param name="bodyParameter"> The IntWrapper to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> PostRequiredIntegerPropertyAsync(IntWrapper bodyParameter, CancellationToken cancellationToken = default)
        {
            return await RestClient.PostRequiredIntegerPropertyAsync(bodyParameter, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Test explicitly required integer. Please put a valid int-wrapper with &apos;value&apos; = null and the client library should throw before the request is sent. </summary>
        /// <param name="bodyParameter"> The IntWrapper to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response PostRequiredIntegerProperty(IntWrapper bodyParameter, CancellationToken cancellationToken = default)
        {
            return RestClient.PostRequiredIntegerProperty(bodyParameter, cancellationToken);
        }

        /// <summary> Test explicitly optional integer. Please put a valid int-wrapper with &apos;value&apos; = null. </summary>
        /// <param name="bodyParameter"> The IntOptionalWrapper to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> PostOptionalIntegerPropertyAsync(IntOptionalWrapper bodyParameter = null, CancellationToken cancellationToken = default)
        {
            return await RestClient.PostOptionalIntegerPropertyAsync(bodyParameter, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Test explicitly optional integer. Please put a valid int-wrapper with &apos;value&apos; = null. </summary>
        /// <param name="bodyParameter"> The IntOptionalWrapper to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response PostOptionalIntegerProperty(IntOptionalWrapper bodyParameter = null, CancellationToken cancellationToken = default)
        {
            return RestClient.PostOptionalIntegerProperty(bodyParameter, cancellationToken);
        }

        /// <summary> Test explicitly required integer. Please put a header &apos;headerParameter&apos; =&gt; null and the client library should throw before the request is sent. </summary>
        /// <param name="headerParameter"> The Integer to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> PostRequiredIntegerHeaderAsync(int headerParameter, CancellationToken cancellationToken = default)
        {
            return await RestClient.PostRequiredIntegerHeaderAsync(headerParameter, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Test explicitly required integer. Please put a header &apos;headerParameter&apos; =&gt; null and the client library should throw before the request is sent. </summary>
        /// <param name="headerParameter"> The Integer to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response PostRequiredIntegerHeader(int headerParameter, CancellationToken cancellationToken = default)
        {
            return RestClient.PostRequiredIntegerHeader(headerParameter, cancellationToken);
        }

        /// <summary> Test explicitly optional integer. Please put a header &apos;headerParameter&apos; =&gt; null. </summary>
        /// <param name="headerParameter"> The Integer to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> PostOptionalIntegerHeaderAsync(int? headerParameter = null, CancellationToken cancellationToken = default)
        {
            return await RestClient.PostOptionalIntegerHeaderAsync(headerParameter, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Test explicitly optional integer. Please put a header &apos;headerParameter&apos; =&gt; null. </summary>
        /// <param name="headerParameter"> The Integer to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response PostOptionalIntegerHeader(int? headerParameter = null, CancellationToken cancellationToken = default)
        {
            return RestClient.PostOptionalIntegerHeader(headerParameter, cancellationToken);
        }

        /// <summary> Test explicitly required string. Please put null and the client library should throw before the request is sent. </summary>
        /// <param name="bodyParameter"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> PostRequiredStringParameterAsync(string bodyParameter, CancellationToken cancellationToken = default)
        {
            return await RestClient.PostRequiredStringParameterAsync(bodyParameter, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Test explicitly required string. Please put null and the client library should throw before the request is sent. </summary>
        /// <param name="bodyParameter"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response PostRequiredStringParameter(string bodyParameter, CancellationToken cancellationToken = default)
        {
            return RestClient.PostRequiredStringParameter(bodyParameter, cancellationToken);
        }

        /// <summary> Test explicitly optional string. Please put null. </summary>
        /// <param name="bodyParameter"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> PostOptionalStringParameterAsync(string bodyParameter = null, CancellationToken cancellationToken = default)
        {
            return await RestClient.PostOptionalStringParameterAsync(bodyParameter, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Test explicitly optional string. Please put null. </summary>
        /// <param name="bodyParameter"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response PostOptionalStringParameter(string bodyParameter = null, CancellationToken cancellationToken = default)
        {
            return RestClient.PostOptionalStringParameter(bodyParameter, cancellationToken);
        }

        /// <summary> Test explicitly required string. Please put a valid string-wrapper with &apos;value&apos; = null and the client library should throw before the request is sent. </summary>
        /// <param name="bodyParameter"> The StringWrapper to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> PostRequiredStringPropertyAsync(StringWrapper bodyParameter, CancellationToken cancellationToken = default)
        {
            return await RestClient.PostRequiredStringPropertyAsync(bodyParameter, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Test explicitly required string. Please put a valid string-wrapper with &apos;value&apos; = null and the client library should throw before the request is sent. </summary>
        /// <param name="bodyParameter"> The StringWrapper to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response PostRequiredStringProperty(StringWrapper bodyParameter, CancellationToken cancellationToken = default)
        {
            return RestClient.PostRequiredStringProperty(bodyParameter, cancellationToken);
        }

        /// <summary> Test explicitly optional integer. Please put a valid string-wrapper with &apos;value&apos; = null. </summary>
        /// <param name="bodyParameter"> The StringOptionalWrapper to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> PostOptionalStringPropertyAsync(StringOptionalWrapper bodyParameter = null, CancellationToken cancellationToken = default)
        {
            return await RestClient.PostOptionalStringPropertyAsync(bodyParameter, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Test explicitly optional integer. Please put a valid string-wrapper with &apos;value&apos; = null. </summary>
        /// <param name="bodyParameter"> The StringOptionalWrapper to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response PostOptionalStringProperty(StringOptionalWrapper bodyParameter = null, CancellationToken cancellationToken = default)
        {
            return RestClient.PostOptionalStringProperty(bodyParameter, cancellationToken);
        }

        /// <summary> Test explicitly required string. Please put a header &apos;headerParameter&apos; =&gt; null and the client library should throw before the request is sent. </summary>
        /// <param name="headerParameter"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> PostRequiredStringHeaderAsync(string headerParameter, CancellationToken cancellationToken = default)
        {
            return await RestClient.PostRequiredStringHeaderAsync(headerParameter, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Test explicitly required string. Please put a header &apos;headerParameter&apos; =&gt; null and the client library should throw before the request is sent. </summary>
        /// <param name="headerParameter"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response PostRequiredStringHeader(string headerParameter, CancellationToken cancellationToken = default)
        {
            return RestClient.PostRequiredStringHeader(headerParameter, cancellationToken);
        }

        /// <summary> Test explicitly optional string. Please put a header &apos;headerParameter&apos; =&gt; null. </summary>
        /// <param name="bodyParameter"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> PostOptionalStringHeaderAsync(string bodyParameter = null, CancellationToken cancellationToken = default)
        {
            return await RestClient.PostOptionalStringHeaderAsync(bodyParameter, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Test explicitly optional string. Please put a header &apos;headerParameter&apos; =&gt; null. </summary>
        /// <param name="bodyParameter"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response PostOptionalStringHeader(string bodyParameter = null, CancellationToken cancellationToken = default)
        {
            return RestClient.PostOptionalStringHeader(bodyParameter, cancellationToken);
        }

        /// <summary> Test explicitly required complex object. Please put null and the client library should throw before the request is sent. </summary>
        /// <param name="bodyParameter"> The Product to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> PostRequiredClassParameterAsync(Product bodyParameter, CancellationToken cancellationToken = default)
        {
            return await RestClient.PostRequiredClassParameterAsync(bodyParameter, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Test explicitly required complex object. Please put null and the client library should throw before the request is sent. </summary>
        /// <param name="bodyParameter"> The Product to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response PostRequiredClassParameter(Product bodyParameter, CancellationToken cancellationToken = default)
        {
            return RestClient.PostRequiredClassParameter(bodyParameter, cancellationToken);
        }

        /// <summary> Test explicitly optional complex object. Please put null. </summary>
        /// <param name="bodyParameter"> The Product to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> PostOptionalClassParameterAsync(Product bodyParameter = null, CancellationToken cancellationToken = default)
        {
            return await RestClient.PostOptionalClassParameterAsync(bodyParameter, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Test explicitly optional complex object. Please put null. </summary>
        /// <param name="bodyParameter"> The Product to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response PostOptionalClassParameter(Product bodyParameter = null, CancellationToken cancellationToken = default)
        {
            return RestClient.PostOptionalClassParameter(bodyParameter, cancellationToken);
        }

        /// <summary> Test explicitly required complex object. Please put a valid class-wrapper with &apos;value&apos; = null and the client library should throw before the request is sent. </summary>
        /// <param name="bodyParameter"> The ClassWrapper to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> PostRequiredClassPropertyAsync(ClassWrapper bodyParameter, CancellationToken cancellationToken = default)
        {
            return await RestClient.PostRequiredClassPropertyAsync(bodyParameter, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Test explicitly required complex object. Please put a valid class-wrapper with &apos;value&apos; = null and the client library should throw before the request is sent. </summary>
        /// <param name="bodyParameter"> The ClassWrapper to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response PostRequiredClassProperty(ClassWrapper bodyParameter, CancellationToken cancellationToken = default)
        {
            return RestClient.PostRequiredClassProperty(bodyParameter, cancellationToken);
        }

        /// <summary> Test explicitly optional complex object. Please put a valid class-wrapper with &apos;value&apos; = null. </summary>
        /// <param name="bodyParameter"> The ClassOptionalWrapper to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> PostOptionalClassPropertyAsync(ClassOptionalWrapper bodyParameter = null, CancellationToken cancellationToken = default)
        {
            return await RestClient.PostOptionalClassPropertyAsync(bodyParameter, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Test explicitly optional complex object. Please put a valid class-wrapper with &apos;value&apos; = null. </summary>
        /// <param name="bodyParameter"> The ClassOptionalWrapper to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response PostOptionalClassProperty(ClassOptionalWrapper bodyParameter = null, CancellationToken cancellationToken = default)
        {
            return RestClient.PostOptionalClassProperty(bodyParameter, cancellationToken);
        }

        /// <summary> Test explicitly required array. Please put null and the client library should throw before the request is sent. </summary>
        /// <param name="bodyParameter"> The ArrayOfPostContentSchemaItem to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> PostRequiredArrayParameterAsync(IEnumerable<string> bodyParameter, CancellationToken cancellationToken = default)
        {
            return await RestClient.PostRequiredArrayParameterAsync(bodyParameter, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Test explicitly required array. Please put null and the client library should throw before the request is sent. </summary>
        /// <param name="bodyParameter"> The ArrayOfPostContentSchemaItem to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response PostRequiredArrayParameter(IEnumerable<string> bodyParameter, CancellationToken cancellationToken = default)
        {
            return RestClient.PostRequiredArrayParameter(bodyParameter, cancellationToken);
        }

        /// <summary> Test explicitly optional array. Please put null. </summary>
        /// <param name="bodyParameter"> The ArrayOfString to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> PostOptionalArrayParameterAsync(IEnumerable<string> bodyParameter = null, CancellationToken cancellationToken = default)
        {
            return await RestClient.PostOptionalArrayParameterAsync(bodyParameter, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Test explicitly optional array. Please put null. </summary>
        /// <param name="bodyParameter"> The ArrayOfString to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response PostOptionalArrayParameter(IEnumerable<string> bodyParameter = null, CancellationToken cancellationToken = default)
        {
            return RestClient.PostOptionalArrayParameter(bodyParameter, cancellationToken);
        }

        /// <summary> Test explicitly required array. Please put a valid array-wrapper with &apos;value&apos; = null and the client library should throw before the request is sent. </summary>
        /// <param name="bodyParameter"> The ArrayWrapper to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> PostRequiredArrayPropertyAsync(ArrayWrapper bodyParameter, CancellationToken cancellationToken = default)
        {
            return await RestClient.PostRequiredArrayPropertyAsync(bodyParameter, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Test explicitly required array. Please put a valid array-wrapper with &apos;value&apos; = null and the client library should throw before the request is sent. </summary>
        /// <param name="bodyParameter"> The ArrayWrapper to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response PostRequiredArrayProperty(ArrayWrapper bodyParameter, CancellationToken cancellationToken = default)
        {
            return RestClient.PostRequiredArrayProperty(bodyParameter, cancellationToken);
        }

        /// <summary> Test explicitly optional array. Please put a valid array-wrapper with &apos;value&apos; = null. </summary>
        /// <param name="bodyParameter"> The ArrayOptionalWrapper to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> PostOptionalArrayPropertyAsync(ArrayOptionalWrapper bodyParameter = null, CancellationToken cancellationToken = default)
        {
            return await RestClient.PostOptionalArrayPropertyAsync(bodyParameter, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Test explicitly optional array. Please put a valid array-wrapper with &apos;value&apos; = null. </summary>
        /// <param name="bodyParameter"> The ArrayOptionalWrapper to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response PostOptionalArrayProperty(ArrayOptionalWrapper bodyParameter = null, CancellationToken cancellationToken = default)
        {
            return RestClient.PostOptionalArrayProperty(bodyParameter, cancellationToken);
        }

        /// <summary> Test explicitly required array. Please put a header &apos;headerParameter&apos; =&gt; null and the client library should throw before the request is sent. </summary>
        /// <param name="headerParameter"> The ArrayOfPost0ItemsItem to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> PostRequiredArrayHeaderAsync(IEnumerable<string> headerParameter, CancellationToken cancellationToken = default)
        {
            return await RestClient.PostRequiredArrayHeaderAsync(headerParameter, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Test explicitly required array. Please put a header &apos;headerParameter&apos; =&gt; null and the client library should throw before the request is sent. </summary>
        /// <param name="headerParameter"> The ArrayOfPost0ItemsItem to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response PostRequiredArrayHeader(IEnumerable<string> headerParameter, CancellationToken cancellationToken = default)
        {
            return RestClient.PostRequiredArrayHeader(headerParameter, cancellationToken);
        }

        /// <summary> Test explicitly optional integer. Please put a header &apos;headerParameter&apos; =&gt; null. </summary>
        /// <param name="headerParameter"> The ArrayOfString to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> PostOptionalArrayHeaderAsync(IEnumerable<string> headerParameter = null, CancellationToken cancellationToken = default)
        {
            return await RestClient.PostOptionalArrayHeaderAsync(headerParameter, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Test explicitly optional integer. Please put a header &apos;headerParameter&apos; =&gt; null. </summary>
        /// <param name="headerParameter"> The ArrayOfString to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response PostOptionalArrayHeader(IEnumerable<string> headerParameter = null, CancellationToken cancellationToken = default)
        {
            return RestClient.PostOptionalArrayHeader(headerParameter, cancellationToken);
        }
    }
}
