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

namespace Azure.ResourceManager.Resources
{
    /// <summary> Creates a deployment script. </summary>
    public partial class DeploymentScriptsCreateOperation : Operation<DeploymentScript>, IOperationSource<DeploymentScript>
    {
        private readonly OperationInternals<DeploymentScript> _operation;

        private readonly ResourceOperationsBase _operationBase;

        /// <summary> Initializes a new instance of DeploymentScriptsCreateOperation for mocking. </summary>
        protected DeploymentScriptsCreateOperation()
        {
        }

        internal DeploymentScriptsCreateOperation(ResourceOperationsBase operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<DeploymentScript>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "DeploymentScriptsCreateOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override DeploymentScript Value => _operation.Value;

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
        public override ValueTask<Response<DeploymentScript>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<DeploymentScript>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        DeploymentScript IOperationSource<DeploymentScript>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return new DeploymentScript(_operationBase, DeploymentScriptData.DeserializeDeploymentScriptData(document.RootElement));
        }

        async ValueTask<DeploymentScript> IOperationSource<DeploymentScript>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return new DeploymentScript(_operationBase, DeploymentScriptData.DeserializeDeploymentScriptData(document.RootElement));
        }
    }
}
