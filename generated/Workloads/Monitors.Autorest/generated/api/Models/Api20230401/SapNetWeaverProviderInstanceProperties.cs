// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Models.Api20230401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Runtime.Extensions;

    /// <summary>Gets or sets the provider properties.</summary>
    public partial class SapNetWeaverProviderInstanceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Models.Api20230401.ISapNetWeaverProviderInstanceProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Models.Api20230401.ISapNetWeaverProviderInstancePropertiesInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Models.Api20230401.IProviderSpecificProperties"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Models.Api20230401.IProviderSpecificProperties __providerSpecificProperties = new Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Models.Api20230401.ProviderSpecificProperties();

        /// <summary>The provider type. For example, the value can be SapHana.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.PropertyOrigin.Inherited)]
        public string ProviderType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Models.Api20230401.IProviderSpecificPropertiesInternal)__providerSpecificProperties).ProviderType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Models.Api20230401.IProviderSpecificPropertiesInternal)__providerSpecificProperties).ProviderType = value ; }

        /// <summary>Backing field for <see cref="SapClientId" /> property.</summary>
        private string _sapClientId;

        /// <summary>Gets or sets the SAP Client ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.PropertyOrigin.Owned)]
        public string SapClientId { get => this._sapClientId; set => this._sapClientId = value; }

        /// <summary>Backing field for <see cref="SapHostFileEntry" /> property.</summary>
        private string[] _sapHostFileEntry;

        /// <summary>Gets or sets the list of HostFile Entries</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.PropertyOrigin.Owned)]
        public string[] SapHostFileEntry { get => this._sapHostFileEntry; set => this._sapHostFileEntry = value; }

        /// <summary>Backing field for <see cref="SapHostname" /> property.</summary>
        private string _sapHostname;

        /// <summary>Gets or sets the target virtual machine IP Address/FQDN.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.PropertyOrigin.Owned)]
        public string SapHostname { get => this._sapHostname; set => this._sapHostname = value; }

        /// <summary>Backing field for <see cref="SapInstanceNr" /> property.</summary>
        private string _sapInstanceNr;

        /// <summary>Gets or sets the instance number of SAP NetWeaver.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.PropertyOrigin.Owned)]
        public string SapInstanceNr { get => this._sapInstanceNr; set => this._sapInstanceNr = value; }

        /// <summary>Backing field for <see cref="SapPassword" /> property.</summary>
        private string _sapPassword;

        /// <summary>Sets the SAP password.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.PropertyOrigin.Owned)]
        public string SapPassword { get => this._sapPassword; set => this._sapPassword = value; }

        /// <summary>Backing field for <see cref="SapPasswordUri" /> property.</summary>
        private string _sapPasswordUri;

        /// <summary>Gets or sets the key vault URI to secret with the SAP password.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.PropertyOrigin.Owned)]
        public string SapPasswordUri { get => this._sapPasswordUri; set => this._sapPasswordUri = value; }

        /// <summary>Backing field for <see cref="SapPortNumber" /> property.</summary>
        private string _sapPortNumber;

        /// <summary>Gets or sets the SAP HTTP port number.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.PropertyOrigin.Owned)]
        public string SapPortNumber { get => this._sapPortNumber; set => this._sapPortNumber = value; }

        /// <summary>Backing field for <see cref="SapSid" /> property.</summary>
        private string _sapSid;

        /// <summary>Gets or sets the SAP System Identifier</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.PropertyOrigin.Owned)]
        public string SapSid { get => this._sapSid; set => this._sapSid = value; }

        /// <summary>Backing field for <see cref="SapUsername" /> property.</summary>
        private string _sapUsername;

        /// <summary>Gets or sets the SAP user name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.PropertyOrigin.Owned)]
        public string SapUsername { get => this._sapUsername; set => this._sapUsername = value; }

        /// <summary>Backing field for <see cref="SslCertificateUri" /> property.</summary>
        private string _sslCertificateUri;

        /// <summary>Gets or sets the blob URI to SSL certificate for the SAP system.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.PropertyOrigin.Owned)]
        public string SslCertificateUri { get => this._sslCertificateUri; set => this._sslCertificateUri = value; }

        /// <summary>Backing field for <see cref="SslPreference" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Support.SslPreference? _sslPreference;

        /// <summary>Gets or sets certificate preference if secure communication is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Support.SslPreference? SslPreference { get => this._sslPreference; set => this._sslPreference = value; }

        /// <summary>Creates an new <see cref="SapNetWeaverProviderInstanceProperties" /> instance.</summary>
        public SapNetWeaverProviderInstanceProperties()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__providerSpecificProperties), __providerSpecificProperties);
            await eventListener.AssertObjectIsValid(nameof(__providerSpecificProperties), __providerSpecificProperties);
        }
    }
    /// Gets or sets the provider properties.
    public partial interface ISapNetWeaverProviderInstanceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Models.Api20230401.IProviderSpecificProperties
    {
        /// <summary>Gets or sets the SAP Client ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the SAP Client ID.",
        SerializedName = @"sapClientId",
        PossibleTypes = new [] { typeof(string) })]
        string SapClientId { get; set; }
        /// <summary>Gets or sets the list of HostFile Entries</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the list of HostFile Entries",
        SerializedName = @"sapHostFileEntries",
        PossibleTypes = new [] { typeof(string) })]
        string[] SapHostFileEntry { get; set; }
        /// <summary>Gets or sets the target virtual machine IP Address/FQDN.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the target virtual machine IP Address/FQDN.",
        SerializedName = @"sapHostname",
        PossibleTypes = new [] { typeof(string) })]
        string SapHostname { get; set; }
        /// <summary>Gets or sets the instance number of SAP NetWeaver.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the instance number of SAP NetWeaver.",
        SerializedName = @"sapInstanceNr",
        PossibleTypes = new [] { typeof(string) })]
        string SapInstanceNr { get; set; }
        /// <summary>Sets the SAP password.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Sets the SAP password.",
        SerializedName = @"sapPassword",
        PossibleTypes = new [] { typeof(string) })]
        string SapPassword { get; set; }
        /// <summary>Gets or sets the key vault URI to secret with the SAP password.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the key vault URI to secret with the SAP password.",
        SerializedName = @"sapPasswordUri",
        PossibleTypes = new [] { typeof(string) })]
        string SapPasswordUri { get; set; }
        /// <summary>Gets or sets the SAP HTTP port number.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the SAP HTTP port number.",
        SerializedName = @"sapPortNumber",
        PossibleTypes = new [] { typeof(string) })]
        string SapPortNumber { get; set; }
        /// <summary>Gets or sets the SAP System Identifier</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the SAP System Identifier",
        SerializedName = @"sapSid",
        PossibleTypes = new [] { typeof(string) })]
        string SapSid { get; set; }
        /// <summary>Gets or sets the SAP user name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the SAP user name.",
        SerializedName = @"sapUsername",
        PossibleTypes = new [] { typeof(string) })]
        string SapUsername { get; set; }
        /// <summary>Gets or sets the blob URI to SSL certificate for the SAP system.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the blob URI to SSL certificate for the SAP system.",
        SerializedName = @"sslCertificateUri",
        PossibleTypes = new [] { typeof(string) })]
        string SslCertificateUri { get; set; }
        /// <summary>Gets or sets certificate preference if secure communication is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets certificate preference if secure communication is enabled.",
        SerializedName = @"sslPreference",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Support.SslPreference) })]
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Support.SslPreference? SslPreference { get; set; }

    }
    /// Gets or sets the provider properties.
    internal partial interface ISapNetWeaverProviderInstancePropertiesInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Models.Api20230401.IProviderSpecificPropertiesInternal
    {
        /// <summary>Gets or sets the SAP Client ID.</summary>
        string SapClientId { get; set; }
        /// <summary>Gets or sets the list of HostFile Entries</summary>
        string[] SapHostFileEntry { get; set; }
        /// <summary>Gets or sets the target virtual machine IP Address/FQDN.</summary>
        string SapHostname { get; set; }
        /// <summary>Gets or sets the instance number of SAP NetWeaver.</summary>
        string SapInstanceNr { get; set; }
        /// <summary>Sets the SAP password.</summary>
        string SapPassword { get; set; }
        /// <summary>Gets or sets the key vault URI to secret with the SAP password.</summary>
        string SapPasswordUri { get; set; }
        /// <summary>Gets or sets the SAP HTTP port number.</summary>
        string SapPortNumber { get; set; }
        /// <summary>Gets or sets the SAP System Identifier</summary>
        string SapSid { get; set; }
        /// <summary>Gets or sets the SAP user name.</summary>
        string SapUsername { get; set; }
        /// <summary>Gets or sets the blob URI to SSL certificate for the SAP system.</summary>
        string SslCertificateUri { get; set; }
        /// <summary>Gets or sets certificate preference if secure communication is enabled.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Monitors.Support.SslPreference? SslPreference { get; set; }

    }
}