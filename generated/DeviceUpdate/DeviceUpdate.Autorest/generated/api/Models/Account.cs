// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Extensions;

    /// <summary>Device Update account details.</summary>
    public partial class Account :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IAccount,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IAccountInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.ITrackedResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.ITrackedResource __trackedResource = new Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.TrackedResource();

        /// <summary>API host name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.DoNotFormat]
        public string HostName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IAccountPropertiesInternal)Property).HostName; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.DoNotFormat]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IResourceInternal)__trackedResource).Id; }

        /// <summary>Backing field for <see cref="Identity" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IManagedServiceIdentity _identity;

        /// <summary>The type of identity used for the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.DoNotFormat]
        internal Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IManagedServiceIdentity Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.ManagedServiceIdentity()); set => this._identity = value; }

        /// <summary>
        /// The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.DoNotFormat]
        public string IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IManagedServiceIdentityInternal)Identity).PrincipalId; }

        /// <summary>
        /// The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.DoNotFormat]
        public string IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IManagedServiceIdentityInternal)Identity).TenantId; }

        /// <summary>
        /// Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.DoNotFormat]
        public string IdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IManagedServiceIdentityInternal)Identity).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IManagedServiceIdentityInternal)Identity).Type = value ?? null; }

        /// <summary>
        /// The set of user assigned identities associated with the resource. The userAssignedIdentities dictionary keys will be ARM
        /// resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}.
        /// The dictionary values can be empty objects ({}) in requests.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IUserAssignedIdentities IdentityUserAssignedIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IManagedServiceIdentityInternal)Identity).UserAssignedIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IManagedServiceIdentityInternal)Identity).UserAssignedIdentity = value ?? null /* model class */; }

        /// <summary>The geo-location where the resource lives</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.FormatTable(Index = 1)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.ITrackedResourceInternal)__trackedResource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.ITrackedResourceInternal)__trackedResource).Location = value ?? null; }

        /// <summary>Device Update account primary and failover location details</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.DoNotFormat]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.ILocation> Locations { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IAccountPropertiesInternal)Property).Location; }

        /// <summary>Internal Acessors for HostName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IAccountInternal.HostName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IAccountPropertiesInternal)Property).HostName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IAccountPropertiesInternal)Property).HostName = value; }

        /// <summary>Internal Acessors for Identity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IManagedServiceIdentity Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IAccountInternal.Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.ManagedServiceIdentity()); set { {_identity = value;} } }

        /// <summary>Internal Acessors for IdentityPrincipalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IAccountInternal.IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IManagedServiceIdentityInternal)Identity).PrincipalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IManagedServiceIdentityInternal)Identity).PrincipalId = value; }

        /// <summary>Internal Acessors for IdentityTenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IAccountInternal.IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IManagedServiceIdentityInternal)Identity).TenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IManagedServiceIdentityInternal)Identity).TenantId = value; }

        /// <summary>Internal Acessors for Locations</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.ILocation> Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IAccountInternal.Locations { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IAccountPropertiesInternal)Property).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IAccountPropertiesInternal)Property).Location = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IAccountProperties Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IAccountInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.AccountProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IAccountInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IAccountPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IAccountPropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IResourceInternal)__trackedResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IResourceInternal)__trackedResource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IResourceInternal)__trackedResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IResourceInternal)__trackedResource).Name = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IResourceInternal)__trackedResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IResourceInternal)__trackedResource).SystemData = value; }

        /// <summary>Internal Acessors for SystemDataCreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IResourceInternal.SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IResourceInternal)__trackedResource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IResourceInternal)__trackedResource).SystemDataCreatedAt = value; }

        /// <summary>Internal Acessors for SystemDataCreatedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IResourceInternal.SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IResourceInternal)__trackedResource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IResourceInternal)__trackedResource).SystemDataCreatedBy = value; }

        /// <summary>Internal Acessors for SystemDataCreatedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IResourceInternal.SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IResourceInternal)__trackedResource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IResourceInternal)__trackedResource).SystemDataCreatedByType = value; }

        /// <summary>Internal Acessors for SystemDataLastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IResourceInternal.SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedAt = value; }

        /// <summary>Internal Acessors for SystemDataLastModifiedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IResourceInternal.SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedBy = value; }

        /// <summary>Internal Acessors for SystemDataLastModifiedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IResourceInternal.SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedByType = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IResourceInternal)__trackedResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IResourceInternal)__trackedResource).Type = value; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.FormatTable(Index = 0)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IResourceInternal)__trackedResource).Name; }

        /// <summary>List of private endpoint connections associated with the account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.DoNotFormat]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IPrivateEndpointConnection> PrivateEndpointConnection { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IAccountPropertiesInternal)Property).PrivateEndpointConnection; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IAccountPropertiesInternal)Property).PrivateEndpointConnection = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IAccountProperties _property;

        /// <summary>Device Update account properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.DoNotFormat]
        internal Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IAccountProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.AccountProperties()); set => this._property = value; }

        /// <summary>Provisioning state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.DoNotFormat]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IAccountPropertiesInternal)Property).ProvisioningState; }

        /// <summary>Whether or not public network access is allowed for the account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.DoNotFormat]
        public string PublicNetworkAccess { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IAccountPropertiesInternal)Property).PublicNetworkAccess; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IAccountPropertiesInternal)Property).PublicNetworkAccess = value ?? null; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.FormatTable(Index = 3)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>Device Update Sku</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.FormatTable(Index = 2)]
        public string Sku { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IAccountPropertiesInternal)Property).Sku; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IAccountPropertiesInternal)Property).Sku = value ?? null; }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.DoNotFormat]
        internal Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IResourceInternal)__trackedResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IResourceInternal)__trackedResource).SystemData = value ?? null /* model class */; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.DoNotFormat]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IResourceInternal)__trackedResource).SystemDataCreatedAt; }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.DoNotFormat]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IResourceInternal)__trackedResource).SystemDataCreatedBy; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.DoNotFormat]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IResourceInternal)__trackedResource).SystemDataCreatedByType; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.DoNotFormat]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedAt; }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.DoNotFormat]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedBy; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.DoNotFormat]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IResourceInternal)__trackedResource).SystemDataLastModifiedByType; }

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.ITrackedResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.ITrackedResourceInternal)__trackedResource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.ITrackedResourceInternal)__trackedResource).Tag = value ?? null /* model class */; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.DoNotFormat]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IResourceInternal)__trackedResource).Type; }

        /// <summary>Creates an new <see cref="Account" /> instance.</summary>
        public Account()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__trackedResource), __trackedResource);
            await eventListener.AssertObjectIsValid(nameof(__trackedResource), __trackedResource);
        }
    }
    /// Device Update account details.
    public partial interface IAccount :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.ITrackedResource
    {
        /// <summary>API host name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"API host name.",
        SerializedName = @"hostName",
        PossibleTypes = new [] { typeof(string) })]
        string HostName { get;  }
        /// <summary>
        /// The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.",
        SerializedName = @"principalId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityPrincipalId { get;  }
        /// <summary>
        /// The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity.",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityTenantId { get;  }
        /// <summary>
        /// Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed).",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PSArgumentCompleterAttribute("None", "SystemAssigned", "UserAssigned", "SystemAssigned,UserAssigned")]
        string IdentityType { get; set; }
        /// <summary>
        /// The set of user assigned identities associated with the resource. The userAssignedIdentities dictionary keys will be ARM
        /// resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}.
        /// The dictionary values can be empty objects ({}) in requests.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The set of user assigned identities associated with the resource. The userAssignedIdentities dictionary keys will be ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}. The dictionary values can be empty objects ({}) in requests.",
        SerializedName = @"userAssignedIdentities",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IUserAssignedIdentities) })]
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IUserAssignedIdentities IdentityUserAssignedIdentity { get; set; }
        /// <summary>Device Update account primary and failover location details</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Device Update account primary and failover location details",
        SerializedName = @"locations",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.ILocation) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.ILocation> Locations { get;  }
        /// <summary>List of private endpoint connections associated with the account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of private endpoint connections associated with the account.",
        SerializedName = @"privateEndpointConnections",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IPrivateEndpointConnection) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IPrivateEndpointConnection> PrivateEndpointConnection { get; set; }
        /// <summary>Provisioning state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Provisioning state.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PSArgumentCompleterAttribute("Succeeded", "Deleted", "Failed", "Canceled", "Accepted", "Creating")]
        string ProvisioningState { get;  }
        /// <summary>Whether or not public network access is allowed for the account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Whether or not public network access is allowed for the account.",
        SerializedName = @"publicNetworkAccess",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string PublicNetworkAccess { get; set; }
        /// <summary>Device Update Sku</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Device Update Sku",
        SerializedName = @"sku",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PSArgumentCompleterAttribute("Free", "Standard")]
        string Sku { get; set; }

    }
    /// Device Update account details.
    internal partial interface IAccountInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.ITrackedResourceInternal
    {
        /// <summary>API host name.</summary>
        string HostName { get; set; }
        /// <summary>The type of identity used for the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IManagedServiceIdentity Identity { get; set; }
        /// <summary>
        /// The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        string IdentityPrincipalId { get; set; }
        /// <summary>
        /// The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity.
        /// </summary>
        string IdentityTenantId { get; set; }
        /// <summary>
        /// Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed).
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PSArgumentCompleterAttribute("None", "SystemAssigned", "UserAssigned", "SystemAssigned,UserAssigned")]
        string IdentityType { get; set; }
        /// <summary>
        /// The set of user assigned identities associated with the resource. The userAssignedIdentities dictionary keys will be ARM
        /// resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}.
        /// The dictionary values can be empty objects ({}) in requests.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IUserAssignedIdentities IdentityUserAssignedIdentity { get; set; }
        /// <summary>Device Update account primary and failover location details</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.ILocation> Locations { get; set; }
        /// <summary>List of private endpoint connections associated with the account.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IPrivateEndpointConnection> PrivateEndpointConnection { get; set; }
        /// <summary>Device Update account properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IAccountProperties Property { get; set; }
        /// <summary>Provisioning state.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PSArgumentCompleterAttribute("Succeeded", "Deleted", "Failed", "Canceled", "Accepted", "Creating")]
        string ProvisioningState { get; set; }
        /// <summary>Whether or not public network access is allowed for the account.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string PublicNetworkAccess { get; set; }
        /// <summary>Device Update Sku</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.PSArgumentCompleterAttribute("Free", "Standard")]
        string Sku { get; set; }

    }
}