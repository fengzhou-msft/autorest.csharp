// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Resources
{
    /// <summary> A class representing the ManagementLockObject data model. </summary>
    public partial class ManagementLockObjectData : Resource<ResourceGroupResourceIdentifier>
    {
        /// <summary> Initializes a new instance of ManagementLockObjectData. </summary>
        /// <param name="level"> The level of the lock. Possible values are: NotSpecified, CanNotDelete, ReadOnly. CanNotDelete means authorized users are able to read and modify the resources, but not delete. ReadOnly means authorized users can only read from a resource, but they can&apos;t modify or delete it. </param>
        public ManagementLockObjectData(LockLevel level)
        {
            Level = level;
            Owners = new ChangeTrackingList<ManagementLockOwner>();
        }

        /// <summary> Initializes a new instance of ManagementLockObjectData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="level"> The level of the lock. Possible values are: NotSpecified, CanNotDelete, ReadOnly. CanNotDelete means authorized users are able to read and modify the resources, but not delete. ReadOnly means authorized users can only read from a resource, but they can&apos;t modify or delete it. </param>
        /// <param name="notes"> Notes about the lock. Maximum of 512 characters. </param>
        /// <param name="owners"> The owners of the lock. </param>
        internal ManagementLockObjectData(ResourceGroupResourceIdentifier id, string name, ResourceType type, LockLevel level, string notes, IList<ManagementLockOwner> owners) : base(id, name, type)
        {
            Level = level;
            Notes = notes;
            Owners = owners;
        }

        /// <summary> The level of the lock. Possible values are: NotSpecified, CanNotDelete, ReadOnly. CanNotDelete means authorized users are able to read and modify the resources, but not delete. ReadOnly means authorized users can only read from a resource, but they can&apos;t modify or delete it. </summary>
        public LockLevel Level { get; set; }
        /// <summary> Notes about the lock. Maximum of 512 characters. </summary>
        public string Notes { get; set; }
        /// <summary> The owners of the lock. </summary>
        public IList<ManagementLockOwner> Owners { get; }
    }
}
