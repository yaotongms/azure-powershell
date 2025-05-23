// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Peering.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Extensions;

    /// <summary>The SKU that defines the tier and kind of the peering.</summary>
    public partial class PeeringSku :
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeeringSku,
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeeringSkuInternal
    {

        /// <summary>Backing field for <see cref="Family" /> property.</summary>
        private string _family;

        /// <summary>The family of the peering SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Origin(Microsoft.Azure.PowerShell.Cmdlets.Peering.PropertyOrigin.Owned)]
        public string Family { get => this._family; }

        /// <summary>Internal Acessors for Family</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeeringSkuInternal.Family { get => this._family; set { {_family = value;} } }

        /// <summary>Internal Acessors for Size</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeeringSkuInternal.Size { get => this._size; set { {_size = value;} } }

        /// <summary>Internal Acessors for Tier</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeeringSkuInternal.Tier { get => this._tier; set { {_tier = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name of the peering SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Origin(Microsoft.Azure.PowerShell.Cmdlets.Peering.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Size" /> property.</summary>
        private string _size;

        /// <summary>The size of the peering SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Origin(Microsoft.Azure.PowerShell.Cmdlets.Peering.PropertyOrigin.Owned)]
        public string Size { get => this._size; }

        /// <summary>Backing field for <see cref="Tier" /> property.</summary>
        private string _tier;

        /// <summary>The tier of the peering SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Origin(Microsoft.Azure.PowerShell.Cmdlets.Peering.PropertyOrigin.Owned)]
        public string Tier { get => this._tier; }

        /// <summary>Creates an new <see cref="PeeringSku" /> instance.</summary>
        public PeeringSku()
        {

        }
    }
    /// The SKU that defines the tier and kind of the peering.
    public partial interface IPeeringSku :
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.IJsonSerializable
    {
        /// <summary>The family of the peering SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The family of the peering SKU.",
        SerializedName = @"family",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Peering.PSArgumentCompleterAttribute("Direct", "Exchange")]
        string Family { get;  }
        /// <summary>The name of the peering SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the peering SKU.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>The size of the peering SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The size of the peering SKU.",
        SerializedName = @"size",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Peering.PSArgumentCompleterAttribute("Free", "Metered", "Unlimited")]
        string Size { get;  }
        /// <summary>The tier of the peering SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The tier of the peering SKU.",
        SerializedName = @"tier",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Peering.PSArgumentCompleterAttribute("Basic", "Premium")]
        string Tier { get;  }

    }
    /// The SKU that defines the tier and kind of the peering.
    internal partial interface IPeeringSkuInternal

    {
        /// <summary>The family of the peering SKU.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Peering.PSArgumentCompleterAttribute("Direct", "Exchange")]
        string Family { get; set; }
        /// <summary>The name of the peering SKU.</summary>
        string Name { get; set; }
        /// <summary>The size of the peering SKU.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Peering.PSArgumentCompleterAttribute("Free", "Metered", "Unlimited")]
        string Size { get; set; }
        /// <summary>The tier of the peering SKU.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Peering.PSArgumentCompleterAttribute("Basic", "Premium")]
        string Tier { get; set; }

    }
}