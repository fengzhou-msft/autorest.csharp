// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading.Tasks;
using Azure.ResourceManager.Core;

namespace MgmtSingleton
{
    /// <summary> A class representing the operations that can be performed over a specific SingletonResource. </summary>
    public partial class SingletonResourceOperations : SingletonOperationsBase<ResourceGroupResourceIdentifier, SingletonResource>
    {
        /// <summary> Initializes a new instance of the <see cref="SingletonResourceOperations"/> class for mocking. </summary>
        protected SingletonResourceOperations()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SingletonResourceOperations"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        protected internal SingletonResourceOperations(OperationsBase options) : base(options)
        {
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Billing/parentResources/singletonResources";
        /// <summary> Gets the valid resource type for the operations. </summary>
        protected override ResourceType ValidResourceType => ResourceType;
    }
}
