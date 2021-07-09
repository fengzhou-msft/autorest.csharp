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

namespace Azure.ResourceManager.Sample
{
    /// <summary> Update an dedicated host . </summary>
    public partial class DedicatedHostsUpdateOperation : Operation<DedicatedHost>, IOperationSource<DedicatedHost>
    {
        private readonly OperationInternals<DedicatedHost> _operation;

        private readonly OperationsBase _operationBase;

        /// <summary> Initializes a new instance of DedicatedHostsUpdateOperation for mocking. </summary>
        protected DedicatedHostsUpdateOperation()
        {
        }

        internal DedicatedHostsUpdateOperation(OperationsBase operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<DedicatedHost>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "DedicatedHostsUpdateOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override DedicatedHost Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<DedicatedHost>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<DedicatedHost>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        DedicatedHost IOperationSource<DedicatedHost>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return new DedicatedHost(_operationBase, DedicatedHostData.DeserializeDedicatedHostData(document.RootElement));
        }

        async ValueTask<DedicatedHost> IOperationSource<DedicatedHost>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return new DedicatedHost(_operationBase, DedicatedHostData.DeserializeDedicatedHostData(document.RootElement));
        }
    }
}
