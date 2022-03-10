// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using url.Models;

namespace url
{
    /// <summary> The Paths service client. </summary>
    public partial class PathsClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal PathsRestClient RestClient { get; }

        /// <summary> Initializes a new instance of PathsClient for mocking. </summary>
        protected PathsClient()
        {
        }

        /// <summary> Initializes a new instance of PathsClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/> or <paramref name="pipeline"/> is null. </exception>
        internal PathsClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            RestClient = new PathsRestClient(pipeline, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Get true Boolean value on path. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> GetBooleanTrueAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PathsClient.GetBooleanTrue");
            scope.Start();
            try
            {
                return await RestClient.GetBooleanTrueAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get true Boolean value on path. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response GetBooleanTrue(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PathsClient.GetBooleanTrue");
            scope.Start();
            try
            {
                return RestClient.GetBooleanTrue(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get false Boolean value on path. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> GetBooleanFalseAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PathsClient.GetBooleanFalse");
            scope.Start();
            try
            {
                return await RestClient.GetBooleanFalseAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get false Boolean value on path. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response GetBooleanFalse(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PathsClient.GetBooleanFalse");
            scope.Start();
            try
            {
                return RestClient.GetBooleanFalse(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get &apos;1000000&apos; integer value. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> GetIntOneMillionAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PathsClient.GetIntOneMillion");
            scope.Start();
            try
            {
                return await RestClient.GetIntOneMillionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get &apos;1000000&apos; integer value. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response GetIntOneMillion(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PathsClient.GetIntOneMillion");
            scope.Start();
            try
            {
                return RestClient.GetIntOneMillion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get &apos;-1000000&apos; integer value. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> GetIntNegativeOneMillionAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PathsClient.GetIntNegativeOneMillion");
            scope.Start();
            try
            {
                return await RestClient.GetIntNegativeOneMillionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get &apos;-1000000&apos; integer value. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response GetIntNegativeOneMillion(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PathsClient.GetIntNegativeOneMillion");
            scope.Start();
            try
            {
                return RestClient.GetIntNegativeOneMillion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get &apos;10000000000&apos; 64 bit integer value. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> GetTenBillionAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PathsClient.GetTenBillion");
            scope.Start();
            try
            {
                return await RestClient.GetTenBillionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get &apos;10000000000&apos; 64 bit integer value. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response GetTenBillion(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PathsClient.GetTenBillion");
            scope.Start();
            try
            {
                return RestClient.GetTenBillion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get &apos;-10000000000&apos; 64 bit integer value. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> GetNegativeTenBillionAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PathsClient.GetNegativeTenBillion");
            scope.Start();
            try
            {
                return await RestClient.GetNegativeTenBillionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get &apos;-10000000000&apos; 64 bit integer value. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response GetNegativeTenBillion(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PathsClient.GetNegativeTenBillion");
            scope.Start();
            try
            {
                return RestClient.GetNegativeTenBillion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get &apos;1.034E+20&apos; numeric value. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> FloatScientificPositiveAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PathsClient.FloatScientificPositive");
            scope.Start();
            try
            {
                return await RestClient.FloatScientificPositiveAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get &apos;1.034E+20&apos; numeric value. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response FloatScientificPositive(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PathsClient.FloatScientificPositive");
            scope.Start();
            try
            {
                return RestClient.FloatScientificPositive(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get &apos;-1.034E-20&apos; numeric value. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> FloatScientificNegativeAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PathsClient.FloatScientificNegative");
            scope.Start();
            try
            {
                return await RestClient.FloatScientificNegativeAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get &apos;-1.034E-20&apos; numeric value. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response FloatScientificNegative(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PathsClient.FloatScientificNegative");
            scope.Start();
            try
            {
                return RestClient.FloatScientificNegative(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get &apos;9999999.999&apos; numeric value. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DoubleDecimalPositiveAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PathsClient.DoubleDecimalPositive");
            scope.Start();
            try
            {
                return await RestClient.DoubleDecimalPositiveAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get &apos;9999999.999&apos; numeric value. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response DoubleDecimalPositive(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PathsClient.DoubleDecimalPositive");
            scope.Start();
            try
            {
                return RestClient.DoubleDecimalPositive(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get &apos;-9999999.999&apos; numeric value. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DoubleDecimalNegativeAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PathsClient.DoubleDecimalNegative");
            scope.Start();
            try
            {
                return await RestClient.DoubleDecimalNegativeAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get &apos;-9999999.999&apos; numeric value. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response DoubleDecimalNegative(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PathsClient.DoubleDecimalNegative");
            scope.Start();
            try
            {
                return RestClient.DoubleDecimalNegative(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get &apos;啊齄丂狛狜隣郎隣兀﨩&apos; multi-byte string value. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> StringUnicodeAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PathsClient.StringUnicode");
            scope.Start();
            try
            {
                return await RestClient.StringUnicodeAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get &apos;啊齄丂狛狜隣郎隣兀﨩&apos; multi-byte string value. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response StringUnicode(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PathsClient.StringUnicode");
            scope.Start();
            try
            {
                return RestClient.StringUnicode(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get &apos;begin!*&apos;();:@ &amp;=+$,/?#[]end. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> StringUrlEncodedAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PathsClient.StringUrlEncoded");
            scope.Start();
            try
            {
                return await RestClient.StringUrlEncodedAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get &apos;begin!*&apos;();:@ &amp;=+$,/?#[]end. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response StringUrlEncoded(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PathsClient.StringUrlEncoded");
            scope.Start();
            try
            {
                return RestClient.StringUrlEncoded(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> https://tools.ietf.org/html/rfc3986#appendix-A &apos;path&apos; accept any &apos;pchar&apos; not encoded. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> StringUrlNonEncodedAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PathsClient.StringUrlNonEncoded");
            scope.Start();
            try
            {
                return await RestClient.StringUrlNonEncodedAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> https://tools.ietf.org/html/rfc3986#appendix-A &apos;path&apos; accept any &apos;pchar&apos; not encoded. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response StringUrlNonEncoded(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PathsClient.StringUrlNonEncoded");
            scope.Start();
            try
            {
                return RestClient.StringUrlNonEncoded(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get &apos;&apos;. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> StringEmptyAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PathsClient.StringEmpty");
            scope.Start();
            try
            {
                return await RestClient.StringEmptyAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get &apos;&apos;. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response StringEmpty(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PathsClient.StringEmpty");
            scope.Start();
            try
            {
                return RestClient.StringEmpty(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get null (should throw). </summary>
        /// <param name="stringPath"> null string value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> StringNullAsync(string stringPath, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PathsClient.StringNull");
            scope.Start();
            try
            {
                return await RestClient.StringNullAsync(stringPath, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get null (should throw). </summary>
        /// <param name="stringPath"> null string value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response StringNull(string stringPath, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PathsClient.StringNull");
            scope.Start();
            try
            {
                return RestClient.StringNull(stringPath, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get using uri with &apos;green color&apos; in path parameter. </summary>
        /// <param name="enumPath"> send the value green. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> EnumValidAsync(UriColor enumPath, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PathsClient.EnumValid");
            scope.Start();
            try
            {
                return await RestClient.EnumValidAsync(enumPath, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get using uri with &apos;green color&apos; in path parameter. </summary>
        /// <param name="enumPath"> send the value green. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response EnumValid(UriColor enumPath, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PathsClient.EnumValid");
            scope.Start();
            try
            {
                return RestClient.EnumValid(enumPath, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get null (should throw on the client before the request is sent on wire). </summary>
        /// <param name="enumPath"> send null should throw. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> EnumNullAsync(UriColor enumPath, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PathsClient.EnumNull");
            scope.Start();
            try
            {
                return await RestClient.EnumNullAsync(enumPath, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get null (should throw on the client before the request is sent on wire). </summary>
        /// <param name="enumPath"> send null should throw. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response EnumNull(UriColor enumPath, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PathsClient.EnumNull");
            scope.Start();
            try
            {
                return RestClient.EnumNull(enumPath, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get &apos;啊齄丂狛狜隣郎隣兀﨩&apos; multibyte value as utf-8 encoded byte array. </summary>
        /// <param name="bytePath"> &apos;啊齄丂狛狜隣郎隣兀﨩&apos; multibyte value as utf-8 encoded byte array. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> ByteMultiByteAsync(byte[] bytePath, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PathsClient.ByteMultiByte");
            scope.Start();
            try
            {
                return await RestClient.ByteMultiByteAsync(bytePath, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get &apos;啊齄丂狛狜隣郎隣兀﨩&apos; multibyte value as utf-8 encoded byte array. </summary>
        /// <param name="bytePath"> &apos;啊齄丂狛狜隣郎隣兀﨩&apos; multibyte value as utf-8 encoded byte array. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response ByteMultiByte(byte[] bytePath, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PathsClient.ByteMultiByte");
            scope.Start();
            try
            {
                return RestClient.ByteMultiByte(bytePath, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get &apos;&apos; as byte array. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> ByteEmptyAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PathsClient.ByteEmpty");
            scope.Start();
            try
            {
                return await RestClient.ByteEmptyAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get &apos;&apos; as byte array. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response ByteEmpty(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PathsClient.ByteEmpty");
            scope.Start();
            try
            {
                return RestClient.ByteEmpty(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get null as byte array (should throw). </summary>
        /// <param name="bytePath"> null as byte array (should throw). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> ByteNullAsync(byte[] bytePath, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PathsClient.ByteNull");
            scope.Start();
            try
            {
                return await RestClient.ByteNullAsync(bytePath, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get null as byte array (should throw). </summary>
        /// <param name="bytePath"> null as byte array (should throw). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response ByteNull(byte[] bytePath, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PathsClient.ByteNull");
            scope.Start();
            try
            {
                return RestClient.ByteNull(bytePath, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get &apos;2012-01-01&apos; as date. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DateValidAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PathsClient.DateValid");
            scope.Start();
            try
            {
                return await RestClient.DateValidAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get &apos;2012-01-01&apos; as date. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response DateValid(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PathsClient.DateValid");
            scope.Start();
            try
            {
                return RestClient.DateValid(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get null as date - this should throw or be unusable on the client side, depending on date representation. </summary>
        /// <param name="datePath"> null as date (should throw). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DateNullAsync(DateTimeOffset datePath, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PathsClient.DateNull");
            scope.Start();
            try
            {
                return await RestClient.DateNullAsync(datePath, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get null as date - this should throw or be unusable on the client side, depending on date representation. </summary>
        /// <param name="datePath"> null as date (should throw). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response DateNull(DateTimeOffset datePath, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PathsClient.DateNull");
            scope.Start();
            try
            {
                return RestClient.DateNull(datePath, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get &apos;2012-01-01T01:01:01Z&apos; as date-time. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DateTimeValidAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PathsClient.DateTimeValid");
            scope.Start();
            try
            {
                return await RestClient.DateTimeValidAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get &apos;2012-01-01T01:01:01Z&apos; as date-time. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response DateTimeValid(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PathsClient.DateTimeValid");
            scope.Start();
            try
            {
                return RestClient.DateTimeValid(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get null as date-time, should be disallowed or throw depending on representation of date-time. </summary>
        /// <param name="dateTimePath"> null as date-time. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DateTimeNullAsync(DateTimeOffset dateTimePath, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PathsClient.DateTimeNull");
            scope.Start();
            try
            {
                return await RestClient.DateTimeNullAsync(dateTimePath, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get null as date-time, should be disallowed or throw depending on representation of date-time. </summary>
        /// <param name="dateTimePath"> null as date-time. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response DateTimeNull(DateTimeOffset dateTimePath, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PathsClient.DateTimeNull");
            scope.Start();
            try
            {
                return RestClient.DateTimeNull(dateTimePath, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get &apos;lorem&apos; encoded value as &apos;bG9yZW0&apos; (base64url). </summary>
        /// <param name="base64UrlPath"> base64url encoded value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> Base64UrlAsync(byte[] base64UrlPath, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PathsClient.Base64Url");
            scope.Start();
            try
            {
                return await RestClient.Base64UrlAsync(base64UrlPath, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get &apos;lorem&apos; encoded value as &apos;bG9yZW0&apos; (base64url). </summary>
        /// <param name="base64UrlPath"> base64url encoded value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Base64Url(byte[] base64UrlPath, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PathsClient.Base64Url");
            scope.Start();
            try
            {
                return RestClient.Base64Url(base64UrlPath, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get an array of string [&apos;ArrayPath1&apos;, &apos;begin!*&apos;();:@ &amp;=+$,/?#[]end&apos; , null, &apos;&apos;] using the csv-array format. </summary>
        /// <param name="arrayPath"> an array of string [&apos;ArrayPath1&apos;, &apos;begin!*&apos;();:@ &amp;=+$,/?#[]end&apos; , null, &apos;&apos;] using the csv-array format. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> ArrayCsvInPathAsync(IEnumerable<string> arrayPath, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PathsClient.ArrayCsvInPath");
            scope.Start();
            try
            {
                return await RestClient.ArrayCsvInPathAsync(arrayPath, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get an array of string [&apos;ArrayPath1&apos;, &apos;begin!*&apos;();:@ &amp;=+$,/?#[]end&apos; , null, &apos;&apos;] using the csv-array format. </summary>
        /// <param name="arrayPath"> an array of string [&apos;ArrayPath1&apos;, &apos;begin!*&apos;();:@ &amp;=+$,/?#[]end&apos; , null, &apos;&apos;] using the csv-array format. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response ArrayCsvInPath(IEnumerable<string> arrayPath, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PathsClient.ArrayCsvInPath");
            scope.Start();
            try
            {
                return RestClient.ArrayCsvInPath(arrayPath, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get the date 2016-04-13 encoded value as &apos;1460505600&apos; (Unix time). </summary>
        /// <param name="unixTimeUrlPath"> Unix time encoded value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> UnixTimeUrlAsync(DateTimeOffset unixTimeUrlPath, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PathsClient.UnixTimeUrl");
            scope.Start();
            try
            {
                return await RestClient.UnixTimeUrlAsync(unixTimeUrlPath, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get the date 2016-04-13 encoded value as &apos;1460505600&apos; (Unix time). </summary>
        /// <param name="unixTimeUrlPath"> Unix time encoded value. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response UnixTimeUrl(DateTimeOffset unixTimeUrlPath, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PathsClient.UnixTimeUrl");
            scope.Start();
            try
            {
                return RestClient.UnixTimeUrl(unixTimeUrlPath, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
