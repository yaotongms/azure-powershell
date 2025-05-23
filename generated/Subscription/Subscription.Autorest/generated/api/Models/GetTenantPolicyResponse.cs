// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Subscription.Runtime.Extensions;

    /// <summary>Tenant policy Information.</summary>
    public partial class GetTenantPolicyResponse :
        Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.IGetTenantPolicyResponse,
        Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.IGetTenantPolicyResponseInternal
    {

        /// <summary>Blocks the entering of subscriptions into user's tenant.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Origin(Microsoft.Azure.PowerShell.Cmdlets.Subscription.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.FormatTable(Index = 2)]
        public bool? BlockSubscriptionsIntoTenant { get => ((Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.ITenantPolicyInternal)Property).BlockSubscriptionsIntoTenant; set => ((Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.ITenantPolicyInternal)Property).BlockSubscriptionsIntoTenant = value ?? default(bool); }

        /// <summary>Blocks the leaving of subscriptions from user's tenant.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Origin(Microsoft.Azure.PowerShell.Cmdlets.Subscription.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.FormatTable(Index = 3)]
        public bool? BlockSubscriptionsLeavingTenant { get => ((Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.ITenantPolicyInternal)Property).BlockSubscriptionsLeavingTenant; set => ((Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.ITenantPolicyInternal)Property).BlockSubscriptionsLeavingTenant = value ?? default(bool); }

        /// <summary>
        /// List of user objectIds that are exempted from the set subscription tenant policies for the user's tenant.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Origin(Microsoft.Azure.PowerShell.Cmdlets.Subscription.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.DoNotFormat]
        public System.Collections.Generic.List<string> ExemptedPrincipal { get => ((Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.ITenantPolicyInternal)Property).ExemptedPrincipal; set => ((Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.ITenantPolicyInternal)Property).ExemptedPrincipal = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Policy Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Origin(Microsoft.Azure.PowerShell.Cmdlets.Subscription.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.DoNotFormat]
        public string Id { get => this._id; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.IGetTenantPolicyResponseInternal.Id { get => this._id; set { {_id = value;} } }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.IGetTenantPolicyResponseInternal.Name { get => this._name; set { {_name = value;} } }

        /// <summary>Internal Acessors for PolicyId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.IGetTenantPolicyResponseInternal.PolicyId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.ITenantPolicyInternal)Property).PolicyId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.ITenantPolicyInternal)Property).PolicyId = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.ITenantPolicy Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.IGetTenantPolicyResponseInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.TenantPolicy()); set { {_property = value;} } }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.IGetTenantPolicyResponseInternal.SystemData { get => (this._systemData = this._systemData ?? new Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.SystemData()); set { {_systemData = value;} } }

        /// <summary>Internal Acessors for SystemDataCreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.IGetTenantPolicyResponseInternal.SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.ISystemDataInternal)SystemData).CreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.ISystemDataInternal)SystemData).CreatedAt = value; }

        /// <summary>Internal Acessors for SystemDataCreatedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.IGetTenantPolicyResponseInternal.SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.ISystemDataInternal)SystemData).CreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.ISystemDataInternal)SystemData).CreatedBy = value; }

        /// <summary>Internal Acessors for SystemDataCreatedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.IGetTenantPolicyResponseInternal.SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.ISystemDataInternal)SystemData).CreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.ISystemDataInternal)SystemData).CreatedByType = value; }

        /// <summary>Internal Acessors for SystemDataLastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.IGetTenantPolicyResponseInternal.SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.ISystemDataInternal)SystemData).LastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.ISystemDataInternal)SystemData).LastModifiedAt = value; }

        /// <summary>Internal Acessors for SystemDataLastModifiedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.IGetTenantPolicyResponseInternal.SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.ISystemDataInternal)SystemData).LastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.ISystemDataInternal)SystemData).LastModifiedBy = value; }

        /// <summary>Internal Acessors for SystemDataLastModifiedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.IGetTenantPolicyResponseInternal.SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.ISystemDataInternal)SystemData).LastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.ISystemDataInternal)SystemData).LastModifiedByType = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.IGetTenantPolicyResponseInternal.Type { get => this._type; set { {_type = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Policy name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Origin(Microsoft.Azure.PowerShell.Cmdlets.Subscription.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.FormatTable(Index = 0)]
        public string Name { get => this._name; }

        /// <summary>Policy Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Origin(Microsoft.Azure.PowerShell.Cmdlets.Subscription.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.FormatTable(Index = 1)]
        public string PolicyId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.ITenantPolicyInternal)Property).PolicyId; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.ITenantPolicy _property;

        /// <summary>Tenant policy properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Origin(Microsoft.Azure.PowerShell.Cmdlets.Subscription.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.DoNotFormat]
        internal Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.ITenantPolicy Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.TenantPolicy()); set => this._property = value; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Origin(Microsoft.Azure.PowerShell.Cmdlets.Subscription.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.DoNotFormat]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>Backing field for <see cref="SystemData" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.ISystemData _systemData;

        /// <summary>Metadata pertaining to creation and last modification of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Origin(Microsoft.Azure.PowerShell.Cmdlets.Subscription.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.DoNotFormat]
        internal Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.ISystemData SystemData { get => (this._systemData = this._systemData ?? new Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.SystemData()); }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Origin(Microsoft.Azure.PowerShell.Cmdlets.Subscription.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.DoNotFormat]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.ISystemDataInternal)SystemData).CreatedAt; }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Origin(Microsoft.Azure.PowerShell.Cmdlets.Subscription.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.DoNotFormat]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.ISystemDataInternal)SystemData).CreatedBy; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Origin(Microsoft.Azure.PowerShell.Cmdlets.Subscription.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.DoNotFormat]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.ISystemDataInternal)SystemData).CreatedByType; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Origin(Microsoft.Azure.PowerShell.Cmdlets.Subscription.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.DoNotFormat]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.ISystemDataInternal)SystemData).LastModifiedAt; }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Origin(Microsoft.Azure.PowerShell.Cmdlets.Subscription.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.DoNotFormat]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.ISystemDataInternal)SystemData).LastModifiedBy; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Origin(Microsoft.Azure.PowerShell.Cmdlets.Subscription.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.DoNotFormat]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.ISystemDataInternal)SystemData).LastModifiedByType; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>Resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Origin(Microsoft.Azure.PowerShell.Cmdlets.Subscription.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.DoNotFormat]
        public string Type { get => this._type; }

        /// <summary>Creates an new <see cref="GetTenantPolicyResponse" /> instance.</summary>
        public GetTenantPolicyResponse()
        {

        }
    }
    /// Tenant policy Information.
    public partial interface IGetTenantPolicyResponse :
        Microsoft.Azure.PowerShell.Cmdlets.Subscription.Runtime.IJsonSerializable
    {
        /// <summary>Blocks the entering of subscriptions into user's tenant.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Blocks the entering of subscriptions into user's tenant.",
        SerializedName = @"blockSubscriptionsIntoTenant",
        PossibleTypes = new [] { typeof(bool) })]
        bool? BlockSubscriptionsIntoTenant { get; set; }
        /// <summary>Blocks the leaving of subscriptions from user's tenant.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Blocks the leaving of subscriptions from user's tenant.",
        SerializedName = @"blockSubscriptionsLeavingTenant",
        PossibleTypes = new [] { typeof(bool) })]
        bool? BlockSubscriptionsLeavingTenant { get; set; }
        /// <summary>
        /// List of user objectIds that are exempted from the set subscription tenant policies for the user's tenant.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of user objectIds that are exempted from the set subscription tenant policies for the user's tenant.",
        SerializedName = @"exemptedPrincipals",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> ExemptedPrincipal { get; set; }
        /// <summary>Policy Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Policy Id.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get;  }
        /// <summary>Policy name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Policy name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get;  }
        /// <summary>Policy Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Policy Id.",
        SerializedName = @"policyId",
        PossibleTypes = new [] { typeof(string) })]
        string PolicyId { get;  }
        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The timestamp of resource creation (UTC).",
        SerializedName = @"createdAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? SystemDataCreatedAt { get;  }
        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The identity that created the resource.",
        SerializedName = @"createdBy",
        PossibleTypes = new [] { typeof(string) })]
        string SystemDataCreatedBy { get;  }
        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The type of identity that created the resource.",
        SerializedName = @"createdByType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Subscription.PSArgumentCompleterAttribute("User", "Application", "ManagedIdentity", "Key")]
        string SystemDataCreatedByType { get;  }
        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The timestamp of resource last modification (UTC)",
        SerializedName = @"lastModifiedAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? SystemDataLastModifiedAt { get;  }
        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The identity that last modified the resource.",
        SerializedName = @"lastModifiedBy",
        PossibleTypes = new [] { typeof(string) })]
        string SystemDataLastModifiedBy { get;  }
        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The type of identity that last modified the resource.",
        SerializedName = @"lastModifiedByType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Subscription.PSArgumentCompleterAttribute("User", "Application", "ManagedIdentity", "Key")]
        string SystemDataLastModifiedByType { get;  }
        /// <summary>Resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Resource type.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get;  }

    }
    /// Tenant policy Information.
    internal partial interface IGetTenantPolicyResponseInternal

    {
        /// <summary>Blocks the entering of subscriptions into user's tenant.</summary>
        bool? BlockSubscriptionsIntoTenant { get; set; }
        /// <summary>Blocks the leaving of subscriptions from user's tenant.</summary>
        bool? BlockSubscriptionsLeavingTenant { get; set; }
        /// <summary>
        /// List of user objectIds that are exempted from the set subscription tenant policies for the user's tenant.
        /// </summary>
        System.Collections.Generic.List<string> ExemptedPrincipal { get; set; }
        /// <summary>Policy Id.</summary>
        string Id { get; set; }
        /// <summary>Policy name.</summary>
        string Name { get; set; }
        /// <summary>Policy Id.</summary>
        string PolicyId { get; set; }
        /// <summary>Tenant policy properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.ITenantPolicy Property { get; set; }
        /// <summary>Metadata pertaining to creation and last modification of the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.ISystemData SystemData { get; set; }
        /// <summary>The timestamp of resource creation (UTC).</summary>
        global::System.DateTime? SystemDataCreatedAt { get; set; }
        /// <summary>The identity that created the resource.</summary>
        string SystemDataCreatedBy { get; set; }
        /// <summary>The type of identity that created the resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Subscription.PSArgumentCompleterAttribute("User", "Application", "ManagedIdentity", "Key")]
        string SystemDataCreatedByType { get; set; }
        /// <summary>The timestamp of resource last modification (UTC)</summary>
        global::System.DateTime? SystemDataLastModifiedAt { get; set; }
        /// <summary>The identity that last modified the resource.</summary>
        string SystemDataLastModifiedBy { get; set; }
        /// <summary>The type of identity that last modified the resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Subscription.PSArgumentCompleterAttribute("User", "Application", "ManagedIdentity", "Key")]
        string SystemDataLastModifiedByType { get; set; }
        /// <summary>Resource type.</summary>
        string Type { get; set; }

    }
}