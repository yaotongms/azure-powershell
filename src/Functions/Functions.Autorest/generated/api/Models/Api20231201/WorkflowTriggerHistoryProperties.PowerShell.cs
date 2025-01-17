// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201
{
    using Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.PowerShell;

    /// <summary>The workflow trigger history properties.</summary>
    [System.ComponentModel.TypeConverter(typeof(WorkflowTriggerHistoryPropertiesTypeConverter))]
    public partial class WorkflowTriggerHistoryProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.WorkflowTriggerHistoryProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new WorkflowTriggerHistoryProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.WorkflowTriggerHistoryProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new WorkflowTriggerHistoryProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="WorkflowTriggerHistoryProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="WorkflowTriggerHistoryProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.SerializationMode.IncludeAll)?.ToString();

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.WorkflowTriggerHistoryProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal WorkflowTriggerHistoryProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Correlation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).Correlation = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ICorrelation) content.GetValueForProperty("Correlation",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).Correlation, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.CorrelationTypeConverter.ConvertFrom);
            }
            if (content.Contains("InputsLink"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).InputsLink = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IContentLink) content.GetValueForProperty("InputsLink",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).InputsLink, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ContentLinkTypeConverter.ConvertFrom);
            }
            if (content.Contains("OutputsLink"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).OutputsLink = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IContentLink) content.GetValueForProperty("OutputsLink",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).OutputsLink, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ContentLinkTypeConverter.ConvertFrom);
            }
            if (content.Contains("Run"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).Run = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IResourceReference) content.GetValueForProperty("Run",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).Run, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ResourceReferenceTypeConverter.ConvertFrom);
            }
            if (content.Contains("StartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).StartTime = (global::System.DateTime?) content.GetValueForProperty("StartTime",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).StartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("EndTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).EndTime = (global::System.DateTime?) content.GetValueForProperty("EndTime",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).EndTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ScheduledTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).ScheduledTime = (global::System.DateTime?) content.GetValueForProperty("ScheduledTime",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).ScheduledTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.WorkflowStatus?) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.WorkflowStatus.CreateFrom);
            }
            if (content.Contains("Code"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).Code = (string) content.GetValueForProperty("Code",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).Code, global::System.Convert.ToString);
            }
            if (content.Contains("Error"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).Error = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.IAny) content.GetValueForProperty("Error",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).Error, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.AnyTypeConverter.ConvertFrom);
            }
            if (content.Contains("TrackingId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).TrackingId = (string) content.GetValueForProperty("TrackingId",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).TrackingId, global::System.Convert.ToString);
            }
            if (content.Contains("Fired"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).Fired = (bool?) content.GetValueForProperty("Fired",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).Fired, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("InputLinkContentHash"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).InputLinkContentHash = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IContentHash) content.GetValueForProperty("InputLinkContentHash",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).InputLinkContentHash, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ContentHashTypeConverter.ConvertFrom);
            }
            if (content.Contains("OutputLinkContentHash"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).OutputLinkContentHash = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IContentHash) content.GetValueForProperty("OutputLinkContentHash",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).OutputLinkContentHash, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ContentHashTypeConverter.ConvertFrom);
            }
            if (content.Contains("CorrelationClientTrackingId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).CorrelationClientTrackingId = (string) content.GetValueForProperty("CorrelationClientTrackingId",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).CorrelationClientTrackingId, global::System.Convert.ToString);
            }
            if (content.Contains("InputLinkUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).InputLinkUri = (string) content.GetValueForProperty("InputLinkUri",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).InputLinkUri, global::System.Convert.ToString);
            }
            if (content.Contains("InputLinkContentVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).InputLinkContentVersion = (string) content.GetValueForProperty("InputLinkContentVersion",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).InputLinkContentVersion, global::System.Convert.ToString);
            }
            if (content.Contains("InputLinkContentSize"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).InputLinkContentSize = (long?) content.GetValueForProperty("InputLinkContentSize",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).InputLinkContentSize, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("InputLinkMetadata"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).InputLinkMetadata = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.IAny) content.GetValueForProperty("InputLinkMetadata",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).InputLinkMetadata, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.AnyTypeConverter.ConvertFrom);
            }
            if (content.Contains("InputsLinkContentHashAlgorithm"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).InputsLinkContentHashAlgorithm = (string) content.GetValueForProperty("InputsLinkContentHashAlgorithm",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).InputsLinkContentHashAlgorithm, global::System.Convert.ToString);
            }
            if (content.Contains("InputsLinkContentHashValue"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).InputsLinkContentHashValue = (string) content.GetValueForProperty("InputsLinkContentHashValue",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).InputsLinkContentHashValue, global::System.Convert.ToString);
            }
            if (content.Contains("OutputLinkUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).OutputLinkUri = (string) content.GetValueForProperty("OutputLinkUri",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).OutputLinkUri, global::System.Convert.ToString);
            }
            if (content.Contains("OutputLinkContentVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).OutputLinkContentVersion = (string) content.GetValueForProperty("OutputLinkContentVersion",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).OutputLinkContentVersion, global::System.Convert.ToString);
            }
            if (content.Contains("OutputLinkContentSize"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).OutputLinkContentSize = (long?) content.GetValueForProperty("OutputLinkContentSize",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).OutputLinkContentSize, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("OutputLinkMetadata"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).OutputLinkMetadata = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.IAny) content.GetValueForProperty("OutputLinkMetadata",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).OutputLinkMetadata, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.AnyTypeConverter.ConvertFrom);
            }
            if (content.Contains("OutputsLinkContentHashAlgorithm"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).OutputsLinkContentHashAlgorithm = (string) content.GetValueForProperty("OutputsLinkContentHashAlgorithm",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).OutputsLinkContentHashAlgorithm, global::System.Convert.ToString);
            }
            if (content.Contains("OutputsLinkContentHashValue"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).OutputsLinkContentHashValue = (string) content.GetValueForProperty("OutputsLinkContentHashValue",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).OutputsLinkContentHashValue, global::System.Convert.ToString);
            }
            if (content.Contains("RunId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).RunId = (string) content.GetValueForProperty("RunId",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).RunId, global::System.Convert.ToString);
            }
            if (content.Contains("RunName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).RunName = (string) content.GetValueForProperty("RunName",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).RunName, global::System.Convert.ToString);
            }
            if (content.Contains("RunType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).RunType = (string) content.GetValueForProperty("RunType",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).RunType, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.WorkflowTriggerHistoryProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal WorkflowTriggerHistoryProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Correlation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).Correlation = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ICorrelation) content.GetValueForProperty("Correlation",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).Correlation, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.CorrelationTypeConverter.ConvertFrom);
            }
            if (content.Contains("InputsLink"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).InputsLink = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IContentLink) content.GetValueForProperty("InputsLink",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).InputsLink, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ContentLinkTypeConverter.ConvertFrom);
            }
            if (content.Contains("OutputsLink"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).OutputsLink = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IContentLink) content.GetValueForProperty("OutputsLink",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).OutputsLink, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ContentLinkTypeConverter.ConvertFrom);
            }
            if (content.Contains("Run"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).Run = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IResourceReference) content.GetValueForProperty("Run",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).Run, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ResourceReferenceTypeConverter.ConvertFrom);
            }
            if (content.Contains("StartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).StartTime = (global::System.DateTime?) content.GetValueForProperty("StartTime",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).StartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("EndTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).EndTime = (global::System.DateTime?) content.GetValueForProperty("EndTime",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).EndTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ScheduledTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).ScheduledTime = (global::System.DateTime?) content.GetValueForProperty("ScheduledTime",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).ScheduledTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.WorkflowStatus?) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.WorkflowStatus.CreateFrom);
            }
            if (content.Contains("Code"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).Code = (string) content.GetValueForProperty("Code",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).Code, global::System.Convert.ToString);
            }
            if (content.Contains("Error"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).Error = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.IAny) content.GetValueForProperty("Error",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).Error, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.AnyTypeConverter.ConvertFrom);
            }
            if (content.Contains("TrackingId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).TrackingId = (string) content.GetValueForProperty("TrackingId",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).TrackingId, global::System.Convert.ToString);
            }
            if (content.Contains("Fired"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).Fired = (bool?) content.GetValueForProperty("Fired",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).Fired, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("InputLinkContentHash"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).InputLinkContentHash = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IContentHash) content.GetValueForProperty("InputLinkContentHash",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).InputLinkContentHash, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ContentHashTypeConverter.ConvertFrom);
            }
            if (content.Contains("OutputLinkContentHash"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).OutputLinkContentHash = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IContentHash) content.GetValueForProperty("OutputLinkContentHash",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).OutputLinkContentHash, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ContentHashTypeConverter.ConvertFrom);
            }
            if (content.Contains("CorrelationClientTrackingId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).CorrelationClientTrackingId = (string) content.GetValueForProperty("CorrelationClientTrackingId",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).CorrelationClientTrackingId, global::System.Convert.ToString);
            }
            if (content.Contains("InputLinkUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).InputLinkUri = (string) content.GetValueForProperty("InputLinkUri",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).InputLinkUri, global::System.Convert.ToString);
            }
            if (content.Contains("InputLinkContentVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).InputLinkContentVersion = (string) content.GetValueForProperty("InputLinkContentVersion",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).InputLinkContentVersion, global::System.Convert.ToString);
            }
            if (content.Contains("InputLinkContentSize"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).InputLinkContentSize = (long?) content.GetValueForProperty("InputLinkContentSize",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).InputLinkContentSize, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("InputLinkMetadata"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).InputLinkMetadata = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.IAny) content.GetValueForProperty("InputLinkMetadata",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).InputLinkMetadata, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.AnyTypeConverter.ConvertFrom);
            }
            if (content.Contains("InputsLinkContentHashAlgorithm"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).InputsLinkContentHashAlgorithm = (string) content.GetValueForProperty("InputsLinkContentHashAlgorithm",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).InputsLinkContentHashAlgorithm, global::System.Convert.ToString);
            }
            if (content.Contains("InputsLinkContentHashValue"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).InputsLinkContentHashValue = (string) content.GetValueForProperty("InputsLinkContentHashValue",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).InputsLinkContentHashValue, global::System.Convert.ToString);
            }
            if (content.Contains("OutputLinkUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).OutputLinkUri = (string) content.GetValueForProperty("OutputLinkUri",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).OutputLinkUri, global::System.Convert.ToString);
            }
            if (content.Contains("OutputLinkContentVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).OutputLinkContentVersion = (string) content.GetValueForProperty("OutputLinkContentVersion",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).OutputLinkContentVersion, global::System.Convert.ToString);
            }
            if (content.Contains("OutputLinkContentSize"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).OutputLinkContentSize = (long?) content.GetValueForProperty("OutputLinkContentSize",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).OutputLinkContentSize, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            if (content.Contains("OutputLinkMetadata"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).OutputLinkMetadata = (Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.IAny) content.GetValueForProperty("OutputLinkMetadata",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).OutputLinkMetadata, Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.AnyTypeConverter.ConvertFrom);
            }
            if (content.Contains("OutputsLinkContentHashAlgorithm"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).OutputsLinkContentHashAlgorithm = (string) content.GetValueForProperty("OutputsLinkContentHashAlgorithm",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).OutputsLinkContentHashAlgorithm, global::System.Convert.ToString);
            }
            if (content.Contains("OutputsLinkContentHashValue"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).OutputsLinkContentHashValue = (string) content.GetValueForProperty("OutputsLinkContentHashValue",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).OutputsLinkContentHashValue, global::System.Convert.ToString);
            }
            if (content.Contains("RunId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).RunId = (string) content.GetValueForProperty("RunId",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).RunId, global::System.Convert.ToString);
            }
            if (content.Contains("RunName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).RunName = (string) content.GetValueForProperty("RunName",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).RunName, global::System.Convert.ToString);
            }
            if (content.Contains("RunType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).RunType = (string) content.GetValueForProperty("RunType",((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryPropertiesInternal)this).RunType, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }
    }
    /// The workflow trigger history properties.
    [System.ComponentModel.TypeConverter(typeof(WorkflowTriggerHistoryPropertiesTypeConverter))]
    public partial interface IWorkflowTriggerHistoryProperties

    {

    }
}