// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Runtime.PowerShell;

    /// <summary>Details of VM Resource having Dynatrace OneAgent installed</summary>
    [System.ComponentModel.TypeConverter(typeof(VMInfoTypeConverter))]
    public partial class VMInfo
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.VMInfo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.IVMInfo" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.IVMInfo DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new VMInfo(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.VMInfo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.IVMInfo" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.IVMInfo DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new VMInfo(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="VMInfo" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="VMInfo" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.IVMInfo FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Runtime.SerializationMode.IncludeAll)?.ToString();

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

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.VMInfo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal VMInfo(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.IVMInfoInternal)this).ResourceId = (string) content.GetValueForProperty("ResourceId",((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.IVMInfoInternal)this).ResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("Version"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.IVMInfoInternal)this).Version = (string) content.GetValueForProperty("Version",((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.IVMInfoInternal)this).Version, global::System.Convert.ToString);
            }
            if (content.Contains("MonitoringType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.IVMInfoInternal)this).MonitoringType = (string) content.GetValueForProperty("MonitoringType",((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.IVMInfoInternal)this).MonitoringType, global::System.Convert.ToString);
            }
            if (content.Contains("AutoUpdateSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.IVMInfoInternal)this).AutoUpdateSetting = (string) content.GetValueForProperty("AutoUpdateSetting",((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.IVMInfoInternal)this).AutoUpdateSetting, global::System.Convert.ToString);
            }
            if (content.Contains("UpdateStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.IVMInfoInternal)this).UpdateStatus = (string) content.GetValueForProperty("UpdateStatus",((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.IVMInfoInternal)this).UpdateStatus, global::System.Convert.ToString);
            }
            if (content.Contains("AvailabilityState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.IVMInfoInternal)this).AvailabilityState = (string) content.GetValueForProperty("AvailabilityState",((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.IVMInfoInternal)this).AvailabilityState, global::System.Convert.ToString);
            }
            if (content.Contains("LogModule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.IVMInfoInternal)this).LogModule = (string) content.GetValueForProperty("LogModule",((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.IVMInfoInternal)this).LogModule, global::System.Convert.ToString);
            }
            if (content.Contains("HostGroup"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.IVMInfoInternal)this).HostGroup = (string) content.GetValueForProperty("HostGroup",((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.IVMInfoInternal)this).HostGroup, global::System.Convert.ToString);
            }
            if (content.Contains("HostName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.IVMInfoInternal)this).HostName = (string) content.GetValueForProperty("HostName",((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.IVMInfoInternal)this).HostName, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.VMInfo"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal VMInfo(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.IVMInfoInternal)this).ResourceId = (string) content.GetValueForProperty("ResourceId",((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.IVMInfoInternal)this).ResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("Version"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.IVMInfoInternal)this).Version = (string) content.GetValueForProperty("Version",((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.IVMInfoInternal)this).Version, global::System.Convert.ToString);
            }
            if (content.Contains("MonitoringType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.IVMInfoInternal)this).MonitoringType = (string) content.GetValueForProperty("MonitoringType",((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.IVMInfoInternal)this).MonitoringType, global::System.Convert.ToString);
            }
            if (content.Contains("AutoUpdateSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.IVMInfoInternal)this).AutoUpdateSetting = (string) content.GetValueForProperty("AutoUpdateSetting",((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.IVMInfoInternal)this).AutoUpdateSetting, global::System.Convert.ToString);
            }
            if (content.Contains("UpdateStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.IVMInfoInternal)this).UpdateStatus = (string) content.GetValueForProperty("UpdateStatus",((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.IVMInfoInternal)this).UpdateStatus, global::System.Convert.ToString);
            }
            if (content.Contains("AvailabilityState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.IVMInfoInternal)this).AvailabilityState = (string) content.GetValueForProperty("AvailabilityState",((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.IVMInfoInternal)this).AvailabilityState, global::System.Convert.ToString);
            }
            if (content.Contains("LogModule"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.IVMInfoInternal)this).LogModule = (string) content.GetValueForProperty("LogModule",((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.IVMInfoInternal)this).LogModule, global::System.Convert.ToString);
            }
            if (content.Contains("HostGroup"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.IVMInfoInternal)this).HostGroup = (string) content.GetValueForProperty("HostGroup",((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.IVMInfoInternal)this).HostGroup, global::System.Convert.ToString);
            }
            if (content.Contains("HostName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.IVMInfoInternal)this).HostName = (string) content.GetValueForProperty("HostName",((Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.IVMInfoInternal)this).HostName, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }
    }
    /// Details of VM Resource having Dynatrace OneAgent installed
    [System.ComponentModel.TypeConverter(typeof(VMInfoTypeConverter))]
    public partial interface IVMInfo

    {

    }
}