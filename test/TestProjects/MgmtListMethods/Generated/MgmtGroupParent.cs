// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace MgmtListMethods
{
    /// <summary> A Class representing a MgmtGroupParent along with the instance operations that can be performed on it. </summary>
    public partial class MgmtGroupParent : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="MgmtGroupParent"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string groupId, string mgmtGroupParentName)
        {
            var resourceId = $"/providers/Microsoft.Management/managementGroups/{groupId}/mgmtGroupParents/{mgmtGroupParentName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _mgmtGroupParentClientDiagnostics;
        private readonly MgmtGroupParentsRestOperations _mgmtGroupParentRestClient;
        private readonly MgmtGroupParentData _data;

        /// <summary> Initializes a new instance of the <see cref="MgmtGroupParent"/> class for mocking. </summary>
        protected MgmtGroupParent()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "MgmtGroupParent"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal MgmtGroupParent(ArmClient client, MgmtGroupParentData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="MgmtGroupParent"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MgmtGroupParent(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _mgmtGroupParentClientDiagnostics = new ClientDiagnostics("MgmtListMethods", ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourceType, out string mgmtGroupParentApiVersion);
            _mgmtGroupParentRestClient = new MgmtGroupParentsRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, mgmtGroupParentApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Management/managementGroups/mgmtGroupParents";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual MgmtGroupParentData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Retrieves information.
        /// Request Path: /providers/Microsoft.Management/managementGroups/{groupId}/mgmtGroupParents/{mgmtGroupParentName}
        /// Operation Id: MgmtGroupParents_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<MgmtGroupParent>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _mgmtGroupParentClientDiagnostics.CreateScope("MgmtGroupParent.Get");
            scope.Start();
            try
            {
                var response = await _mgmtGroupParentRestClient.GetAsync(Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MgmtGroupParent(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves information.
        /// Request Path: /providers/Microsoft.Management/managementGroups/{groupId}/mgmtGroupParents/{mgmtGroupParentName}
        /// Operation Id: MgmtGroupParents_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<MgmtGroupParent> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _mgmtGroupParentClientDiagnostics.CreateScope("MgmtGroupParent.Get");
            scope.Start();
            try
            {
                var response = _mgmtGroupParentRestClient.Get(Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MgmtGroupParent(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// Request Path: /providers/Microsoft.Management/managementGroups/{groupId}/mgmtGroupParents/{mgmtGroupParentName}
        /// Operation Id: MgmtGroupParents_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual async Task<Response<MgmtGroupParent>> AddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _mgmtGroupParentClientDiagnostics.CreateScope("MgmtGroupParent.AddTag");
            scope.Start();
            try
            {
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.TagValues[key] = value;
                await TagResource.CreateOrUpdateAsync(true, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _mgmtGroupParentRestClient.GetAsync(Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new MgmtGroupParent(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// Request Path: /providers/Microsoft.Management/managementGroups/{groupId}/mgmtGroupParents/{mgmtGroupParentName}
        /// Operation Id: MgmtGroupParents_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual Response<MgmtGroupParent> AddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _mgmtGroupParentClientDiagnostics.CreateScope("MgmtGroupParent.AddTag");
            scope.Start();
            try
            {
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.TagValues[key] = value;
                TagResource.CreateOrUpdate(true, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _mgmtGroupParentRestClient.Get(Id.Parent.Name, Id.Name, cancellationToken);
                return Response.FromValue(new MgmtGroupParent(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// Request Path: /providers/Microsoft.Management/managementGroups/{groupId}/mgmtGroupParents/{mgmtGroupParentName}
        /// Operation Id: MgmtGroupParents_Get
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual async Task<Response<MgmtGroupParent>> SetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _mgmtGroupParentClientDiagnostics.CreateScope("MgmtGroupParent.SetTags");
            scope.Start();
            try
            {
                await TagResource.DeleteAsync(true, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.TagValues.ReplaceWith(tags);
                await TagResource.CreateOrUpdateAsync(true, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _mgmtGroupParentRestClient.GetAsync(Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new MgmtGroupParent(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// Request Path: /providers/Microsoft.Management/managementGroups/{groupId}/mgmtGroupParents/{mgmtGroupParentName}
        /// Operation Id: MgmtGroupParents_Get
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual Response<MgmtGroupParent> SetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _mgmtGroupParentClientDiagnostics.CreateScope("MgmtGroupParent.SetTags");
            scope.Start();
            try
            {
                TagResource.Delete(true, cancellationToken: cancellationToken);
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.TagValues.ReplaceWith(tags);
                TagResource.CreateOrUpdate(true, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _mgmtGroupParentRestClient.Get(Id.Parent.Name, Id.Name, cancellationToken);
                return Response.FromValue(new MgmtGroupParent(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// Request Path: /providers/Microsoft.Management/managementGroups/{groupId}/mgmtGroupParents/{mgmtGroupParentName}
        /// Operation Id: MgmtGroupParents_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual async Task<Response<MgmtGroupParent>> RemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _mgmtGroupParentClientDiagnostics.CreateScope("MgmtGroupParent.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.TagValues.Remove(key);
                await TagResource.CreateOrUpdateAsync(true, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _mgmtGroupParentRestClient.GetAsync(Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new MgmtGroupParent(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// Request Path: /providers/Microsoft.Management/managementGroups/{groupId}/mgmtGroupParents/{mgmtGroupParentName}
        /// Operation Id: MgmtGroupParents_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual Response<MgmtGroupParent> RemoveTag(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _mgmtGroupParentClientDiagnostics.CreateScope("MgmtGroupParent.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.TagValues.Remove(key);
                TagResource.CreateOrUpdate(true, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _mgmtGroupParentRestClient.Get(Id.Parent.Name, Id.Name, cancellationToken);
                return Response.FromValue(new MgmtGroupParent(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
