// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Management;
using Azure.ResourceManager.Resources.Models;
using MgmtScopeResource.Models;

namespace MgmtScopeResource
{
    /// <summary> A Class representing a DeploymentExtended along with the instance operations that can be performed on it. </summary>
    public partial class DeploymentExtended : ArmResource
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly DeploymentsRestOperations _restClient;
        private readonly DeploymentExtendedData _data;

        /// <summary> Initializes a new instance of the <see cref="DeploymentExtended"/> class for mocking. </summary>
        protected DeploymentExtended()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "DeploymentExtended"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal DeploymentExtended(ArmResource options, DeploymentExtendedData resource) : base(options, resource.Id)
        {
            HasData = true;
            _data = resource;
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new DeploymentsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Initializes a new instance of the <see cref="DeploymentExtended"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DeploymentExtended(ArmResource options, ResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new DeploymentsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Initializes a new instance of the <see cref="DeploymentExtended"/> class. </summary>
        /// <param name="clientOptions"> The client options to build client context. </param>
        /// <param name="credential"> The credential to build client context. </param>
        /// <param name="uri"> The uri to build client context. </param>
        /// <param name="pipeline"> The pipeline to build client context. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DeploymentExtended(ArmClientOptions clientOptions, TokenCredential credential, Uri uri, HttpPipeline pipeline, ResourceIdentifier id) : base(clientOptions, credential, uri, pipeline, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new DeploymentsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Resources/deployments";

        /// <summary> Gets the valid resource type for the operations. </summary>
        protected override ResourceType ValidResourceType => ResourceType;

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DeploymentExtendedData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        /// <summary> Gets a deployment. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<DeploymentExtended>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DeploymentExtended.Get");
            scope.Start();
            try
            {
                var response = await _restClient.GetAtScopeAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new DeploymentExtended(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a deployment. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DeploymentExtended> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DeploymentExtended.Get");
            scope.Start();
            try
            {
                var response = _restClient.GetAtScope(Id.Parent, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DeploymentExtended(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public async virtual Task<IEnumerable<Location>> GetAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public virtual IEnumerable<Location> GetAvailableLocations(CancellationToken cancellationToken = default)
        {
            return ListAvailableLocations(ResourceType, cancellationToken);
        }

        /// <summary> A template deployment that is currently running cannot be deleted. Deleting a template deployment removes the associated deployment operations. This is an asynchronous operation that returns a status of 202 until the template deployment is successfully deleted. The Location response header contains the URI that is used to obtain the status of the process. While the process is running, a call to the URI in the Location header returns a status of 202. When the process finishes, the URI in the Location header returns a status of 204 on success. If the asynchronous request failed, the URI in the Location header returns an error-level status code. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<DeploymentDeleteAtScopeOperation> DeleteAsync(bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DeploymentExtended.Delete");
            scope.Start();
            try
            {
                var response = await _restClient.DeleteAtScopeAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new DeploymentDeleteAtScopeOperation(_clientDiagnostics, Pipeline, _restClient.CreateDeleteAtScopeRequest(Id.Parent, Id.Name).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> A template deployment that is currently running cannot be deleted. Deleting a template deployment removes the associated deployment operations. This is an asynchronous operation that returns a status of 202 until the template deployment is successfully deleted. The Location response header contains the URI that is used to obtain the status of the process. While the process is running, a call to the URI in the Location header returns a status of 202. When the process finishes, the URI in the Location header returns a status of 204 on success. If the asynchronous request failed, the URI in the Location header returns an error-level status code. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual DeploymentDeleteAtScopeOperation Delete(bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DeploymentExtended.Delete");
            scope.Start();
            try
            {
                var response = _restClient.DeleteAtScope(Id.Parent, Id.Name, cancellationToken);
                var operation = new DeploymentDeleteAtScopeOperation(_clientDiagnostics, Pipeline, _restClient.CreateDeleteAtScopeRequest(Id.Parent, Id.Name).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Checks whether the deployment exists. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> CheckExistenceAtScopeAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DeploymentExtended.CheckExistenceAtScope");
            scope.Start();
            try
            {
                var response = await _restClient.CheckExistenceAtScopeAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Checks whether the deployment exists. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> CheckExistenceAtScope(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DeploymentExtended.CheckExistenceAtScope");
            scope.Start();
            try
            {
                var response = _restClient.CheckExistenceAtScope(Id.Parent, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> You can cancel a deployment only if the provisioningState is Accepted or Running. After the deployment is canceled, the provisioningState is set to Canceled. Canceling a template deployment stops the currently running template deployment and leaves the resources partially deployed. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> CancelAtScopeAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DeploymentExtended.CancelAtScope");
            scope.Start();
            try
            {
                var response = await _restClient.CancelAtScopeAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> You can cancel a deployment only if the provisioningState is Accepted or Running. After the deployment is canceled, the provisioningState is set to Canceled. Canceling a template deployment stops the currently running template deployment and leaves the resources partially deployed. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response CancelAtScope(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DeploymentExtended.CancelAtScope");
            scope.Start();
            try
            {
                var response = _restClient.CancelAtScope(Id.Parent, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Exports the template used for specified deployment. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DeploymentExportResult>> ExportTemplateAtScopeAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DeploymentExtended.ExportTemplateAtScope");
            scope.Start();
            try
            {
                var response = await _restClient.ExportTemplateAtScopeAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Exports the template used for specified deployment. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DeploymentExportResult> ExportTemplateAtScope(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DeploymentExtended.ExportTemplateAtScope");
            scope.Start();
            try
            {
                var response = _restClient.ExportTemplateAtScope(Id.Parent, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Calculate the hash of the given template. </summary>
        /// <param name="template"> The template provided to calculate hash. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="template"/> is null. </exception>
        public virtual async Task<Response<TemplateHashResult>> CalculateTemplateHashAsync(object template, CancellationToken cancellationToken = default)
        {
            if (template == null)
            {
                throw new ArgumentNullException(nameof(template));
            }

            using var scope = _clientDiagnostics.CreateScope("DeploymentExtended.CalculateTemplateHash");
            scope.Start();
            try
            {
                var response = await _restClient.CalculateTemplateHashAsync(template, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Calculate the hash of the given template. </summary>
        /// <param name="template"> The template provided to calculate hash. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="template"/> is null. </exception>
        public virtual Response<TemplateHashResult> CalculateTemplateHash(object template, CancellationToken cancellationToken = default)
        {
            if (template == null)
            {
                throw new ArgumentNullException(nameof(template));
            }

            using var scope = _clientDiagnostics.CreateScope("DeploymentExtended.CalculateTemplateHash");
            scope.Start();
            try
            {
                var response = _restClient.CalculateTemplateHash(template, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Validates whether the specified template is syntactically correct and will be accepted by Azure Resource Manager.. </summary>
        /// <param name="parameters"> Parameters to validate. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public async virtual Task<DeploymentValidateAtScopeOperation> ValidateAtScopeAsync(Deployment parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("DeploymentExtended.ValidateAtScope");
            scope.Start();
            try
            {
                var response = await _restClient.ValidateAtScopeAsync(Id.Parent, Id.Name, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new DeploymentValidateAtScopeOperation(_clientDiagnostics, Pipeline, _restClient.CreateValidateAtScopeRequest(Id.Parent, Id.Name, parameters).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Validates whether the specified template is syntactically correct and will be accepted by Azure Resource Manager.. </summary>
        /// <param name="parameters"> Parameters to validate. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual DeploymentValidateAtScopeOperation ValidateAtScope(Deployment parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("DeploymentExtended.ValidateAtScope");
            scope.Start();
            try
            {
                var response = _restClient.ValidateAtScope(Id.Parent, Id.Name, parameters, cancellationToken);
                var operation = new DeploymentValidateAtScopeOperation(_clientDiagnostics, Pipeline, _restClient.CreateValidateAtScopeRequest(Id.Parent, Id.Name, parameters).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Returns changes that will be made by the deployment if executed at the scope of the resource group. </summary>
        /// <param name="properties"> The deployment properties. </param>
        /// <param name="location"> The location to store the deployment data. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public async virtual Task<DeploymentWhatIfOperation> WhatIfAsync(DeploymentWhatIfProperties properties, string location = null, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            using var scope = _clientDiagnostics.CreateScope("DeploymentExtended.WhatIf");
            scope.Start();
            try
            {
                if (Id.TryGetResourceGroupName(out _))
                {
                    var response = await _restClient.WhatIfAsync(Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, properties, location, cancellationToken).ConfigureAwait(false);
                    var operation = new DeploymentWhatIfOperation(_clientDiagnostics, Pipeline, _restClient.CreateWhatIfRequest(Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, properties, location).Request, response);
                    if (waitForCompletion)
                        await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                    return operation;
                }
                else if (Id.TryGetSubscriptionId(out _))
                {
                    var response = await _restClient.WhatIfAtSubscriptionScopeAsync(Id.Parent.Name, Id.Name, properties, location, cancellationToken).ConfigureAwait(false);
                    var operation = new DeploymentWhatIfOperation(_clientDiagnostics, Pipeline, _restClient.CreateWhatIfAtSubscriptionScopeRequest(Id.Parent.Name, Id.Name, properties, location).Request, response);
                    if (waitForCompletion)
                        await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                    return operation;
                }
                else
                {
                    var parent = Id;
                    while (parent.Parent != ResourceIdentifier.RootResourceIdentifier)
                    {
                        parent = parent.Parent;
                    }
                    if (parent.ResourceType.Equals(ManagementGroup.ResourceType))
                    {
                        var response = await _restClient.WhatIfAtManagementGroupScopeAsync(Id.Parent.Name, Id.Name, properties, location, cancellationToken).ConfigureAwait(false);
                        var operation = new DeploymentWhatIfOperation(_clientDiagnostics, Pipeline, _restClient.CreateWhatIfAtManagementGroupScopeRequest(Id.Parent.Name, Id.Name, properties, location).Request, response);
                        if (waitForCompletion)
                            await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                        return operation;
                    }
                    else
                    {
                        var response = await _restClient.WhatIfAtTenantScopeAsync(Id.Name, properties, location, cancellationToken).ConfigureAwait(false);
                        var operation = new DeploymentWhatIfOperation(_clientDiagnostics, Pipeline, _restClient.CreateWhatIfAtTenantScopeRequest(Id.Name, properties, location).Request, response);
                        if (waitForCompletion)
                            await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                        return operation;
                    }
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Returns changes that will be made by the deployment if executed at the scope of the resource group. </summary>
        /// <param name="properties"> The deployment properties. </param>
        /// <param name="location"> The location to store the deployment data. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public virtual DeploymentWhatIfOperation WhatIf(DeploymentWhatIfProperties properties, string location = null, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            using var scope = _clientDiagnostics.CreateScope("DeploymentExtended.WhatIf");
            scope.Start();
            try
            {
                if (Id.TryGetResourceGroupName(out _))
                {
                    var response = _restClient.WhatIf(Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, properties, location, cancellationToken);
                    var operation = new DeploymentWhatIfOperation(_clientDiagnostics, Pipeline, _restClient.CreateWhatIfRequest(Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, properties, location).Request, response);
                    if (waitForCompletion)
                        operation.WaitForCompletion(cancellationToken);
                    return operation;
                }
                else if (Id.TryGetSubscriptionId(out _))
                {
                    var response = _restClient.WhatIfAtSubscriptionScope(Id.Parent.Name, Id.Name, properties, location, cancellationToken);
                    var operation = new DeploymentWhatIfOperation(_clientDiagnostics, Pipeline, _restClient.CreateWhatIfAtSubscriptionScopeRequest(Id.Parent.Name, Id.Name, properties, location).Request, response);
                    if (waitForCompletion)
                        operation.WaitForCompletion(cancellationToken);
                    return operation;
                }
                else
                {
                    var parent = Id;
                    while (parent.Parent != ResourceIdentifier.RootResourceIdentifier)
                    {
                        parent = parent.Parent;
                    }
                    if (parent.ResourceType.Equals(ManagementGroup.ResourceType))
                    {
                        var response = _restClient.WhatIfAtManagementGroupScope(Id.Parent.Name, Id.Name, properties, location, cancellationToken);
                        var operation = new DeploymentWhatIfOperation(_clientDiagnostics, Pipeline, _restClient.CreateWhatIfAtManagementGroupScopeRequest(Id.Parent.Name, Id.Name, properties, location).Request, response);
                        if (waitForCompletion)
                            operation.WaitForCompletion(cancellationToken);
                        return operation;
                    }
                    else
                    {
                        var response = _restClient.WhatIfAtTenantScope(Id.Name, properties, location, cancellationToken);
                        var operation = new DeploymentWhatIfOperation(_clientDiagnostics, Pipeline, _restClient.CreateWhatIfAtTenantScopeRequest(Id.Name, properties, location).Request, response);
                        if (waitForCompletion)
                            operation.WaitForCompletion(cancellationToken);
                        return operation;
                    }
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a list of DeploymentOperations in the DeploymentExtended. </summary>
        /// <returns> An object representing collection of DeploymentOperations and their operations over a DeploymentExtended. </returns>
        public DeploymentOperationContainer GetDeploymentOperations()
        {
            return new DeploymentOperationContainer(this);
        }
    }
}
