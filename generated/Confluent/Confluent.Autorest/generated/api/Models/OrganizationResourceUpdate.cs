// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Confluent.Runtime.Extensions;

    /// <summary>Organization Resource update</summary>
    public partial class OrganizationResourceUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceUpdateInternal
    {

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceUpdateTags _tag;

        /// <summary>ARM resource tags</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Confluent.Origin(Microsoft.Azure.PowerShell.Cmdlets.Confluent.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceUpdateTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.OrganizationResourceUpdateTags()); set => this._tag = value; }

        /// <summary>Creates an new <see cref="OrganizationResourceUpdate" /> instance.</summary>
        public OrganizationResourceUpdate()
        {

        }
    }
    /// Organization Resource update
    public partial interface IOrganizationResourceUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.Confluent.Runtime.IJsonSerializable
    {
        /// <summary>ARM resource tags</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Confluent.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"ARM resource tags",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceUpdateTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceUpdateTags Tag { get; set; }

    }
    /// Organization Resource update
    internal partial interface IOrganizationResourceUpdateInternal

    {
        /// <summary>ARM resource tags</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Confluent.Models.IOrganizationResourceUpdateTags Tag { get; set; }

    }
}