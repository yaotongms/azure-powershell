// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.PowerShell;

    /// <summary>Deployment settings payload</summary>
    [System.ComponentModel.TypeConverter(typeof(DeploymentSettingsTypeConverter))]
    public partial class DeploymentSettings
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.DeploymentSettings"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal DeploymentSettings(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ResourceRequest"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IDeploymentSettingsInternal)this).ResourceRequest = (Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IResourceRequests) content.GetValueForProperty("ResourceRequest",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IDeploymentSettingsInternal)this).ResourceRequest, Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.ResourceRequestsTypeConverter.ConvertFrom);
            }
            if (content.Contains("EnvironmentVariable"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IDeploymentSettingsInternal)this).EnvironmentVariable = (Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IDeploymentSettingsEnvironmentVariables) content.GetValueForProperty("EnvironmentVariable",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IDeploymentSettingsInternal)this).EnvironmentVariable, Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.DeploymentSettingsEnvironmentVariablesTypeConverter.ConvertFrom);
            }
            if (content.Contains("AddonConfig"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IDeploymentSettingsInternal)this).AddonConfig = (Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IDeploymentSettingsAddonConfigs) content.GetValueForProperty("AddonConfig",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IDeploymentSettingsInternal)this).AddonConfig, Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.DeploymentSettingsAddonConfigsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ResourceRequestCpu"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IDeploymentSettingsInternal)this).ResourceRequestCpu = (string) content.GetValueForProperty("ResourceRequestCpu",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IDeploymentSettingsInternal)this).ResourceRequestCpu, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceRequestMemory"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IDeploymentSettingsInternal)this).ResourceRequestMemory = (string) content.GetValueForProperty("ResourceRequestMemory",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IDeploymentSettingsInternal)this).ResourceRequestMemory, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.DeploymentSettings"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal DeploymentSettings(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ResourceRequest"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IDeploymentSettingsInternal)this).ResourceRequest = (Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IResourceRequests) content.GetValueForProperty("ResourceRequest",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IDeploymentSettingsInternal)this).ResourceRequest, Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.ResourceRequestsTypeConverter.ConvertFrom);
            }
            if (content.Contains("EnvironmentVariable"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IDeploymentSettingsInternal)this).EnvironmentVariable = (Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IDeploymentSettingsEnvironmentVariables) content.GetValueForProperty("EnvironmentVariable",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IDeploymentSettingsInternal)this).EnvironmentVariable, Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.DeploymentSettingsEnvironmentVariablesTypeConverter.ConvertFrom);
            }
            if (content.Contains("AddonConfig"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IDeploymentSettingsInternal)this).AddonConfig = (Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IDeploymentSettingsAddonConfigs) content.GetValueForProperty("AddonConfig",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IDeploymentSettingsInternal)this).AddonConfig, Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.DeploymentSettingsAddonConfigsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ResourceRequestCpu"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IDeploymentSettingsInternal)this).ResourceRequestCpu = (string) content.GetValueForProperty("ResourceRequestCpu",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IDeploymentSettingsInternal)this).ResourceRequestCpu, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceRequestMemory"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IDeploymentSettingsInternal)this).ResourceRequestMemory = (string) content.GetValueForProperty("ResourceRequestMemory",((Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IDeploymentSettingsInternal)this).ResourceRequestMemory, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.DeploymentSettings"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IDeploymentSettings" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IDeploymentSettings DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new DeploymentSettings(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.DeploymentSettings"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IDeploymentSettings" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IDeploymentSettings DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new DeploymentSettings(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="DeploymentSettings" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="DeploymentSettings" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Models.IDeploymentSettings FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.SpringCloud.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// Deployment settings payload
    [System.ComponentModel.TypeConverter(typeof(DeploymentSettingsTypeConverter))]
    public partial interface IDeploymentSettings

    {

    }
}