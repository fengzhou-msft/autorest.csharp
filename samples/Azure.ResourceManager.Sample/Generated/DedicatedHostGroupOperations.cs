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
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Sample
{
    /// <summary> A class representing the operations that can be performed over a specific DedicatedHostGroup. </summary>
    public partial class DedicatedHostGroupOperations : ResourceOperationsBase<ResourceGroupResourceIdentifier, DedicatedHostGroup>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        internal DedicatedHostGroupsRestOperations RestClient { get; }

        /// <summary> Initializes a new instance of the <see cref="DedicatedHostGroupOperations"/> class for mocking. </summary>
        protected DedicatedHostGroupOperations()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DedicatedHostGroupOperations"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        protected internal DedicatedHostGroupOperations(ResourceOperationsBase options, ResourceGroupResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            RestClient = new DedicatedHostGroupsRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);
        }

        public static readonly ResourceType ResourceType = "Microsoft.Compute/hostGroups";
        protected override ResourceType ValidResourceType => ResourceType;

        /// <inheritdoc />
        public async override Task<Response<DedicatedHostGroup>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DedicatedHostGroupOperations.Get");
            scope.Start();
            try
            {
                var response = await RestClient.GetAsync(Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new DedicatedHostGroup(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        public override Response<DedicatedHostGroup> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DedicatedHostGroupOperations.Get");
            scope.Start();
            try
            {
                var response = RestClient.Get(Id.ResourceGroupName, Id.Name, cancellationToken);
                return Response.FromValue(new DedicatedHostGroup(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="P: System.Threading.CancellationToken.None" />. </param>
        /// <returns> A collection of location that may take multiple service requests to iterate over. </returns>
        public async Task<IEnumerable<LocationData>> ListAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="P: System.Threading.CancellationToken.None" />. </param>
        /// <returns> A collection of location that may take multiple service requests to iterate over. </returns>
        public IEnumerable<LocationData> ListAvailableLocations(CancellationToken cancellationToken = default)
        {
            return ListAvailableLocations(ResourceType, cancellationToken);
        }

        /// <summary> Delete a dedicated host group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response> DeleteAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DedicatedHostGroupOperations.Delete");
            scope.Start();
            try
            {
                var operation = await StartDeleteAsync(cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete a dedicated host group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Delete(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DedicatedHostGroupOperations.Delete");
            scope.Start();
            try
            {
                var operation = StartDelete(cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete a dedicated host group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Operation> StartDeleteAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DedicatedHostGroupOperations.StartDelete");
            scope.Start();
            try
            {
                var response = await RestClient.DeleteAsync(Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return new DedicatedHostGroupsDeleteOperation(response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete a dedicated host group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Operation StartDelete(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DedicatedHostGroupOperations.StartDelete");
            scope.Start();
            try
            {
                var response = RestClient.Delete(Id.ResourceGroupName, Id.Name, cancellationToken);
                return new DedicatedHostGroupsDeleteOperation(response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Add a tag to the current resource. </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tag added. </returns>
        public async Task<Response<DedicatedHostGroup>> AddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DedicatedHostGroupOperations.AddTag");
            scope.Start();
            try
            {
                var operation = await StartAddTagAsync(key, value, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Add a tag to the current resource. </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tag added. </returns>
        public Response<DedicatedHostGroup> AddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DedicatedHostGroupOperations.AddTag");
            scope.Start();
            try
            {
                var operation = StartAddTag(key, value, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Add a tag to the current resource. </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tag added. </returns>
        /// <remarks> <see href="https://azure.github.io/azure-sdk/dotnet_introduction.html#dotnet-longrunning">Details on long running operation object.</see>. </remarks>
        public async Task<DedicatedHostGroupsUpdateOperation> StartAddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            using var scope = _clientDiagnostics.CreateScope("DedicatedHostGroupOperations.StartAddTag");
            scope.Start();
            try
            {
                var resource = GetResource();
                var patchable = new DedicatedHostGroupUpdate();
                patchable.Tags.ReplaceWith(resource.Data.Tags);
                patchable.Tags[key] = value;
                var response = await RestClient.UpdateAsync(Id.ResourceGroupName, Id.Name, patchable, cancellationToken).ConfigureAwait(false);
                return new DedicatedHostGroupsUpdateOperation(this, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Add a tag to the current resource. </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tag added. </returns>
        /// <remarks> <see href="https://azure.github.io/azure-sdk/dotnet_introduction.html#dotnet-longrunning">Details on long running operation object.</see>. </remarks>
        public DedicatedHostGroupsUpdateOperation StartAddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            using var scope = _clientDiagnostics.CreateScope("DedicatedHostGroupOperations.StartAddTag");
            scope.Start();
            try
            {
                var resource = GetResource();
                var patchable = new DedicatedHostGroupUpdate();
                patchable.Tags.ReplaceWith(resource.Data.Tags);
                patchable.Tags[key] = value;
                var response = RestClient.Update(Id.ResourceGroupName, Id.Name, patchable, cancellationToken);
                return new DedicatedHostGroupsUpdateOperation(this, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Replace the tags on the resource with the given set. </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tags replaced. </returns>
        public async Task<Response<DedicatedHostGroup>> SetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DedicatedHostGroupOperations.SetTags");
            scope.Start();
            try
            {
                var operation = await StartSetTagsAsync(tags, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Replace the tags on the resource with the given set. </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tags replaced. </returns>
        public Response<DedicatedHostGroup> SetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DedicatedHostGroupOperations.SetTags");
            scope.Start();
            try
            {
                var operation = StartSetTags(tags, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Replace the tags on the resource with the given set. </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tags replaced. </returns>
        /// <remarks> <see href="https://azure.github.io/azure-sdk/dotnet_introduction.html#dotnet-longrunning">Details on long running operation object.</see>. </remarks>
        public async Task<DedicatedHostGroupsUpdateOperation> StartSetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            if (tags == null)
            {
                throw new ArgumentNullException(nameof(tags));
            }

            using var scope = _clientDiagnostics.CreateScope("DedicatedHostGroupOperations.StartSetTags");
            scope.Start();
            try
            {
                var patchable = new DedicatedHostGroupUpdate();
                patchable.Tags.ReplaceWith(tags);
                var response = await RestClient.UpdateAsync(Id.ResourceGroupName, Id.Name, patchable, cancellationToken).ConfigureAwait(false);
                return new DedicatedHostGroupsUpdateOperation(this, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Replace the tags on the resource with the given set. </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tags replaced. </returns>
        /// <remarks> <see href="https://azure.github.io/azure-sdk/dotnet_introduction.html#dotnet-longrunning">Details on long running operation object.</see>. </remarks>
        public DedicatedHostGroupsUpdateOperation StartSetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            if (tags == null)
            {
                throw new ArgumentNullException(nameof(tags));
            }

            using var scope = _clientDiagnostics.CreateScope("DedicatedHostGroupOperations.StartSetTags");
            scope.Start();
            try
            {
                var patchable = new DedicatedHostGroupUpdate();
                patchable.Tags.ReplaceWith(tags);
                var response = RestClient.Update(Id.ResourceGroupName, Id.Name, patchable, cancellationToken);
                return new DedicatedHostGroupsUpdateOperation(this, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Removes a tag by key from the resource. </summary>
        /// <param name="key"> The key of the tag to remove. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tag removed. </returns>
        public async Task<Response<DedicatedHostGroup>> RemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DedicatedHostGroupOperations.RemoveTag");
            scope.Start();
            try
            {
                var operation = await StartRemoveTagAsync(key, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Removes a tag by key from the resource. </summary>
        /// <param name="key"> The key of the tag to remove. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tag removed. </returns>
        public Response<DedicatedHostGroup> RemoveTag(string key, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DedicatedHostGroupOperations.RemoveTag");
            scope.Start();
            try
            {
                var operation = StartRemoveTag(key, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Removes a tag by key from the resource. </summary>
        /// <param name="key"> The key of the tag to remove. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tag removed. </returns>
        /// <remarks> <see href="https://azure.github.io/azure-sdk/dotnet_introduction.html#dotnet-longrunning">Details on long running operation object.</see>. </remarks>
        public async Task<DedicatedHostGroupsUpdateOperation> StartRemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            using var scope = _clientDiagnostics.CreateScope("DedicatedHostGroupOperations.StartRemoveTag");
            scope.Start();
            try
            {
                var resource = GetResource();
                var patchable = new DedicatedHostGroupUpdate();
                patchable.Tags.ReplaceWith(resource.Data.Tags);
                patchable.Tags.Remove(key);
                var response = await RestClient.UpdateAsync(Id.ResourceGroupName, Id.Name, patchable, cancellationToken).ConfigureAwait(false);
                return new DedicatedHostGroupsUpdateOperation(this, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Removes a tag by key from the resource. </summary>
        /// <param name="key"> The key of the tag to remove. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> The updated resource with the tag removed. </returns>
        /// <remarks> <see href="https://azure.github.io/azure-sdk/dotnet_introduction.html#dotnet-longrunning">Details on long running operation object.</see>. </remarks>
        public DedicatedHostGroupsUpdateOperation StartRemoveTag(string key, CancellationToken cancellationToken = default)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            using var scope = _clientDiagnostics.CreateScope("DedicatedHostGroupOperations.StartRemoveTag");
            scope.Start();
            try
            {
                var resource = GetResource();
                var patchable = new DedicatedHostGroupUpdate();
                patchable.Tags.ReplaceWith(resource.Data.Tags);
                patchable.Tags.Remove(key);
                var response = RestClient.Update(Id.ResourceGroupName, Id.Name, patchable, cancellationToken);
                return new DedicatedHostGroupsUpdateOperation(this, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a list of DedicatedHost in the DedicatedHostGroup. </summary>
        /// <returns> An object representing collection of DedicatedHosts and their operations over a DedicatedHostGroup. </returns>
        public DedicatedHostContainer GetDedicatedHosts()
        {
            return new DedicatedHostContainer(this);
        }
    }
}
