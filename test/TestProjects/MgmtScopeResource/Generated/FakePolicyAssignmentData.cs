// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using MgmtScopeResource.Models;

namespace MgmtScopeResource
{
    /// <summary> A class representing the FakePolicyAssignment data model. </summary>
    public partial class FakePolicyAssignmentData : ResourceData
    {
        /// <summary> Initializes a new instance of FakePolicyAssignmentData. </summary>
        public FakePolicyAssignmentData()
        {
            NotScopes = new ChangeTrackingList<string>();
            Parameters = new ChangeTrackingDictionary<string, ParameterValuesValue>();
            NonComplianceMessages = new ChangeTrackingList<NonComplianceMessage>();
        }

        /// <summary> Initializes a new instance of FakePolicyAssignmentData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> The location of the policy assignment. Only required when utilizing managed identity. </param>
        /// <param name="identity"> The managed identity associated with the policy assignment. </param>
        /// <param name="displayName"> The display name of the policy assignment. </param>
        /// <param name="policyDefinitionId"> The ID of the policy definition or policy set definition being assigned. </param>
        /// <param name="scope"> The scope for the policy assignment. </param>
        /// <param name="notScopes"> The policy&apos;s excluded scopes. </param>
        /// <param name="parameters"> The parameter values for the assigned policy rule. The keys are the parameter names. </param>
        /// <param name="description"> This message will be part of response in case of policy violation. </param>
        /// <param name="metadata"> The policy assignment metadata. Metadata is an open ended object and is typically a collection of key value pairs. </param>
        /// <param name="enforcementMode"> The policy assignment enforcement mode. Possible values are Default and DoNotEnforce. </param>
        /// <param name="nonComplianceMessages"> The messages that describe why a resource is non-compliant with the policy. </param>
        internal FakePolicyAssignmentData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string location, SystemAssignedServiceIdentity identity, string displayName, string policyDefinitionId, string scope, IList<string> notScopes, IDictionary<string, ParameterValuesValue> parameters, string description, BinaryData metadata, EnforcementMode? enforcementMode, IList<NonComplianceMessage> nonComplianceMessages) : base(id, name, resourceType, systemData)
        {
            Location = location;
            Identity = identity;
            DisplayName = displayName;
            PolicyDefinitionId = policyDefinitionId;
            Scope = scope;
            NotScopes = notScopes;
            Parameters = parameters;
            Description = description;
            Metadata = metadata;
            EnforcementMode = enforcementMode;
            NonComplianceMessages = nonComplianceMessages;
        }

        /// <summary> The location of the policy assignment. Only required when utilizing managed identity. </summary>
        public string Location { get; set; }
        /// <summary> The managed identity associated with the policy assignment. </summary>
        public SystemAssignedServiceIdentity Identity { get; set; }
        /// <summary> The display name of the policy assignment. </summary>
        public string DisplayName { get; set; }
        /// <summary> The ID of the policy definition or policy set definition being assigned. </summary>
        public string PolicyDefinitionId { get; set; }
        /// <summary> The scope for the policy assignment. </summary>
        public string Scope { get; }
        /// <summary> The policy&apos;s excluded scopes. </summary>
        public IList<string> NotScopes { get; }
        /// <summary> The parameter values for the assigned policy rule. The keys are the parameter names. </summary>
        public IDictionary<string, ParameterValuesValue> Parameters { get; }
        /// <summary> This message will be part of response in case of policy violation. </summary>
        public string Description { get; set; }
        /// <summary> The policy assignment metadata. Metadata is an open ended object and is typically a collection of key value pairs. </summary>
        public BinaryData Metadata { get; set; }
        /// <summary> The policy assignment enforcement mode. Possible values are Default and DoNotEnforce. </summary>
        public EnforcementMode? EnforcementMode { get; set; }
        /// <summary> The messages that describe why a resource is non-compliant with the policy. </summary>
        public IList<NonComplianceMessage> NonComplianceMessages { get; }
    }
}
