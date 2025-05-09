// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Extensions;

    /// <summary>
    /// The vm resource properties that is currently being monitored by the Elastic monitor resource.
    /// </summary>
    public partial class VMResources :
        Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IVMResources,
        Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IVMResourcesInternal
    {

        /// <summary>Backing field for <see cref="VMResourceId" /> property.</summary>
        private string _vMResourceId;

        /// <summary>The ARM id of the VM resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Origin(Microsoft.Azure.PowerShell.Cmdlets.Elastic.PropertyOrigin.Owned)]
        public string VMResourceId { get => this._vMResourceId; set => this._vMResourceId = value; }

        /// <summary>Creates an new <see cref="VMResources" /> instance.</summary>
        public VMResources()
        {

        }
    }
    /// The vm resource properties that is currently being monitored by the Elastic monitor resource.
    public partial interface IVMResources :
        Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.IJsonSerializable
    {
        /// <summary>The ARM id of the VM resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The ARM id of the VM resource.",
        SerializedName = @"vmResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string VMResourceId { get; set; }

    }
    /// The vm resource properties that is currently being monitored by the Elastic monitor resource.
    internal partial interface IVMResourcesInternal

    {
        /// <summary>The ARM id of the VM resource.</summary>
        string VMResourceId { get; set; }

    }
}