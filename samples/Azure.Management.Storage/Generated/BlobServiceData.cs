// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.Management.Storage.Models;
using Azure.ResourceManager.Models;

namespace Azure.Management.Storage
{
    /// <summary> A class representing the BlobService data model. </summary>
    public partial class BlobServiceData : ResourceData
    {
        /// <summary> Initializes a new instance of BlobServiceData. </summary>
        public BlobServiceData()
        {
        }

        /// <summary> Initializes a new instance of BlobServiceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="sku"> Sku name and tier. </param>
        /// <param name="cors"> Specifies CORS rules for the Blob service. You can include up to five CorsRule elements in the request. If no CorsRule elements are included in the request body, all CORS rules will be deleted, and CORS will be disabled for the Blob service. </param>
        /// <param name="defaultServiceVersion"> DefaultServiceVersion indicates the default version to use for requests to the Blob service if an incoming request’s version is not specified. Possible values include version 2008-10-27 and all more recent versions. </param>
        /// <param name="deleteRetentionPolicy"> The blob service properties for blob soft delete. </param>
        /// <param name="isVersioningEnabled"> Versioning is enabled if set to true. </param>
        /// <param name="automaticSnapshotPolicyEnabled"> Deprecated in favor of isVersioningEnabled property. </param>
        /// <param name="changeFeed"> The blob service properties for change feed events. </param>
        /// <param name="restorePolicy"> The blob service properties for blob restore policy. </param>
        /// <param name="containerDeleteRetentionPolicy"> The blob service properties for container soft delete. </param>
        /// <param name="lastAccessTimeTrackingPolicy"> The blob service property to configure last access time based tracking policy. </param>
        internal BlobServiceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, StorageSku sku, CorsRules cors, string defaultServiceVersion, DeleteRetentionPolicy deleteRetentionPolicy, bool? isVersioningEnabled, bool? automaticSnapshotPolicyEnabled, ChangeFeed changeFeed, RestorePolicyProperties restorePolicy, DeleteRetentionPolicy containerDeleteRetentionPolicy, LastAccessTimeTrackingPolicy lastAccessTimeTrackingPolicy) : base(id, name, resourceType, systemData)
        {
            Sku = sku;
            Cors = cors;
            DefaultServiceVersion = defaultServiceVersion;
            DeleteRetentionPolicy = deleteRetentionPolicy;
            IsVersioningEnabled = isVersioningEnabled;
            AutomaticSnapshotPolicyEnabled = automaticSnapshotPolicyEnabled;
            ChangeFeed = changeFeed;
            RestorePolicy = restorePolicy;
            ContainerDeleteRetentionPolicy = containerDeleteRetentionPolicy;
            LastAccessTimeTrackingPolicy = lastAccessTimeTrackingPolicy;
        }

        /// <summary> Sku name and tier. </summary>
        public StorageSku Sku { get; }
        /// <summary> Specifies CORS rules for the Blob service. You can include up to five CorsRule elements in the request. If no CorsRule elements are included in the request body, all CORS rules will be deleted, and CORS will be disabled for the Blob service. </summary>
        internal CorsRules Cors { get; set; }
        /// <summary> The List of CORS rules. You can include up to five CorsRule elements in the request. </summary>
        public IList<CorsRule> CorsRulesValue
        {
            get
            {
                if (Cors is null)
                    Cors = new CorsRules();
                return Cors.CorsRulesValue;
            }
        }

        /// <summary> DefaultServiceVersion indicates the default version to use for requests to the Blob service if an incoming request’s version is not specified. Possible values include version 2008-10-27 and all more recent versions. </summary>
        public string DefaultServiceVersion { get; set; }
        /// <summary> The blob service properties for blob soft delete. </summary>
        public DeleteRetentionPolicy DeleteRetentionPolicy { get; set; }
        /// <summary> Versioning is enabled if set to true. </summary>
        public bool? IsVersioningEnabled { get; set; }
        /// <summary> Deprecated in favor of isVersioningEnabled property. </summary>
        public bool? AutomaticSnapshotPolicyEnabled { get; set; }
        /// <summary> The blob service properties for change feed events. </summary>
        public ChangeFeed ChangeFeed { get; set; }
        /// <summary> The blob service properties for blob restore policy. </summary>
        public RestorePolicyProperties RestorePolicy { get; set; }
        /// <summary> The blob service properties for container soft delete. </summary>
        public DeleteRetentionPolicy ContainerDeleteRetentionPolicy { get; set; }
        /// <summary> The blob service property to configure last access time based tracking policy. </summary>
        public LastAccessTimeTrackingPolicy LastAccessTimeTrackingPolicy { get; set; }
    }
}
