// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>The secrets related to a databox heavy job.</summary>
    public partial class DataBoxHeavyJobSecrets :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IDataBoxHeavyJobSecrets,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IDataBoxHeavyJobSecretsInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecrets"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecrets __jobSecrets = new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.JobSecrets();

        /// <summary>Gets or sets additional error info.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IAdditionalErrorInfo[] AdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)__jobSecrets).AdditionalInfo; }

        /// <summary>Backing field for <see cref="CabinetPodSecret" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IDataBoxHeavySecret[] _cabinetPodSecret;

        /// <summary>Contains the list of secret objects for a databox heavy job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IDataBoxHeavySecret[] CabinetPodSecret { get => this._cabinetPodSecret; }

        /// <summary>Error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)__jobSecrets).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)__jobSecrets).Code = value ?? null; }

        /// <summary>Dc Access Security Code for Customer Managed Shipping</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IDcAccessSecurityCode DcAccessSecurityCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)__jobSecrets).DcAccessSecurityCode; }

        /// <summary>Forward Dc access security code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string DcAccessSecurityCodeForwardDcAccessCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)__jobSecrets).DcAccessSecurityCodeForwardDcAccessCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)__jobSecrets).DcAccessSecurityCodeForwardDcAccessCode = value ?? null; }

        /// <summary>Reverse Dc access security code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string DcAccessSecurityCodeReverseDcAccessCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)__jobSecrets).DcAccessSecurityCodeReverseDcAccessCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)__jobSecrets).DcAccessSecurityCodeReverseDcAccessCode = value ?? null; }

        /// <summary>Gets or sets details for the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ICloudError[] Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)__jobSecrets).Detail; }

        /// <summary>Error while fetching the secrets.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ICloudError Error { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)__jobSecrets).Error; }

        /// <summary>The error message parsed from the body of the http error response.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)__jobSecrets).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)__jobSecrets).Message = value ?? null; }

        /// <summary>Internal Acessors for CabinetPodSecret</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IDataBoxHeavySecret[] Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IDataBoxHeavyJobSecretsInternal.CabinetPodSecret { get => this._cabinetPodSecret; set { {_cabinetPodSecret = value;} } }

        /// <summary>Internal Acessors for AdditionalInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IAdditionalErrorInfo[] Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal.AdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)__jobSecrets).AdditionalInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)__jobSecrets).AdditionalInfo = value; }

        /// <summary>Internal Acessors for DcAccessSecurityCode</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IDcAccessSecurityCode Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal.DcAccessSecurityCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)__jobSecrets).DcAccessSecurityCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)__jobSecrets).DcAccessSecurityCode = value; }

        /// <summary>Internal Acessors for Detail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ICloudError[] Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal.Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)__jobSecrets).Detail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)__jobSecrets).Detail = value; }

        /// <summary>Internal Acessors for Error</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ICloudError Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal.Error { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)__jobSecrets).Error; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)__jobSecrets).Error = value; }

        /// <summary>Gets or sets the target of the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string Target { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)__jobSecrets).Target; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)__jobSecrets).Target = value ?? null; }

        /// <summary>Used to indicate what type of job secrets object.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.ClassDiscriminator Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)__jobSecrets).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal)__jobSecrets).Type = value ; }

        /// <summary>Creates an new <see cref="DataBoxHeavyJobSecrets" /> instance.</summary>
        public DataBoxHeavyJobSecrets()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__jobSecrets), __jobSecrets);
            await eventListener.AssertObjectIsValid(nameof(__jobSecrets), __jobSecrets);
        }
    }
    /// The secrets related to a databox heavy job.
    public partial interface IDataBoxHeavyJobSecrets :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecrets
    {
        /// <summary>Contains the list of secret objects for a databox heavy job.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Contains the list of secret objects for a databox heavy job.",
        SerializedName = @"cabinetPodSecrets",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IDataBoxHeavySecret) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IDataBoxHeavySecret[] CabinetPodSecret { get;  }

    }
    /// The secrets related to a databox heavy job.
    internal partial interface IDataBoxHeavyJobSecretsInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IJobSecretsInternal
    {
        /// <summary>Contains the list of secret objects for a databox heavy job.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IDataBoxHeavySecret[] CabinetPodSecret { get; set; }

    }
}