// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Communication.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Communication.Runtime.Extensions;

    /// <summary>Parameters describes the request to regenerate access keys</summary>
    public partial class RegenerateKeyParameters :
        Microsoft.Azure.PowerShell.Cmdlets.Communication.Models.IRegenerateKeyParameters,
        Microsoft.Azure.PowerShell.Cmdlets.Communication.Models.IRegenerateKeyParametersInternal
    {

        /// <summary>Backing field for <see cref="KeyType" /> property.</summary>
        private string _keyType;

        /// <summary>
        /// The keyType to regenerate. Must be either 'primary' or 'secondary'(case-insensitive).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Communication.Origin(Microsoft.Azure.PowerShell.Cmdlets.Communication.PropertyOrigin.Owned)]
        public string KeyType { get => this._keyType; set => this._keyType = value; }

        /// <summary>Creates an new <see cref="RegenerateKeyParameters" /> instance.</summary>
        public RegenerateKeyParameters()
        {

        }
    }
    /// Parameters describes the request to regenerate access keys
    public partial interface IRegenerateKeyParameters :
        Microsoft.Azure.PowerShell.Cmdlets.Communication.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The keyType to regenerate. Must be either 'primary' or 'secondary'(case-insensitive).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Communication.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The keyType to regenerate. Must be either 'primary' or 'secondary'(case-insensitive).",
        SerializedName = @"keyType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Communication.PSArgumentCompleterAttribute("Primary", "Secondary")]
        string KeyType { get; set; }

    }
    /// Parameters describes the request to regenerate access keys
    internal partial interface IRegenerateKeyParametersInternal

    {
        /// <summary>
        /// The keyType to regenerate. Must be either 'primary' or 'secondary'(case-insensitive).
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Communication.PSArgumentCompleterAttribute("Primary", "Secondary")]
        string KeyType { get; set; }

    }
}