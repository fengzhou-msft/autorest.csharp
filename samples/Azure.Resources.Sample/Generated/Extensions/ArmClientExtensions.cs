// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Resources
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public static partial class ArmClientExtensions
    {
        #region PolicyAssignment
        /// <summary> Gets an object representing a PolicyAssignmentContainer along with the instance operations that can be performed on it. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="PolicyAssignmentContainer" /> object. </returns>
        public static PolicyAssignmentContainer GetPolicyAssignmentContainer(this ArmClient armClient)
        {
            return armClient.GetContainer((options, credential, baseUri, pipeline) => new PolicyAssignmentContainer(options, credential, baseUri, pipeline));
        }
        #endregion
    }
}
