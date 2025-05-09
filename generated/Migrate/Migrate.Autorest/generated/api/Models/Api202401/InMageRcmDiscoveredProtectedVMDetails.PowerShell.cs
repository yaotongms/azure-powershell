// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401
{
    using Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.PowerShell;

    /// <summary>InMageRcm discovered protected VM details.</summary>
    [System.ComponentModel.TypeConverter(typeof(InMageRcmDiscoveredProtectedVMDetailsTypeConverter))]
    public partial class InMageRcmDiscoveredProtectedVMDetails
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.InMageRcmDiscoveredProtectedVMDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IInMageRcmDiscoveredProtectedVMDetails"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IInMageRcmDiscoveredProtectedVMDetails DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new InMageRcmDiscoveredProtectedVMDetails(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.InMageRcmDiscoveredProtectedVMDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IInMageRcmDiscoveredProtectedVMDetails"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IInMageRcmDiscoveredProtectedVMDetails DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new InMageRcmDiscoveredProtectedVMDetails(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="InMageRcmDiscoveredProtectedVMDetails" />, deserializing the content from a json
        /// string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>
        /// an instance of the <see cref="InMageRcmDiscoveredProtectedVMDetails" /> model class.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IInMageRcmDiscoveredProtectedVMDetails FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.InMageRcmDiscoveredProtectedVMDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal InMageRcmDiscoveredProtectedVMDetails(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("VCenterId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IInMageRcmDiscoveredProtectedVMDetailsInternal)this).VCenterId = (string) content.GetValueForProperty("VCenterId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IInMageRcmDiscoveredProtectedVMDetailsInternal)this).VCenterId, global::System.Convert.ToString);
            }
            if (content.Contains("VCenterFqdn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IInMageRcmDiscoveredProtectedVMDetailsInternal)this).VCenterFqdn = (string) content.GetValueForProperty("VCenterFqdn",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IInMageRcmDiscoveredProtectedVMDetailsInternal)this).VCenterFqdn, global::System.Convert.ToString);
            }
            if (content.Contains("Datastore"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IInMageRcmDiscoveredProtectedVMDetailsInternal)this).Datastore = (string[]) content.GetValueForProperty("Datastore",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IInMageRcmDiscoveredProtectedVMDetailsInternal)this).Datastore, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("IPAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IInMageRcmDiscoveredProtectedVMDetailsInternal)this).IPAddress = (string[]) content.GetValueForProperty("IPAddress",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IInMageRcmDiscoveredProtectedVMDetailsInternal)this).IPAddress, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("VmwareToolsStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IInMageRcmDiscoveredProtectedVMDetailsInternal)this).VmwareToolsStatus = (string) content.GetValueForProperty("VmwareToolsStatus",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IInMageRcmDiscoveredProtectedVMDetailsInternal)this).VmwareToolsStatus, global::System.Convert.ToString);
            }
            if (content.Contains("PowerStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IInMageRcmDiscoveredProtectedVMDetailsInternal)this).PowerStatus = (string) content.GetValueForProperty("PowerStatus",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IInMageRcmDiscoveredProtectedVMDetailsInternal)this).PowerStatus, global::System.Convert.ToString);
            }
            if (content.Contains("VMFqdn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IInMageRcmDiscoveredProtectedVMDetailsInternal)this).VMFqdn = (string) content.GetValueForProperty("VMFqdn",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IInMageRcmDiscoveredProtectedVMDetailsInternal)this).VMFqdn, global::System.Convert.ToString);
            }
            if (content.Contains("OSName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IInMageRcmDiscoveredProtectedVMDetailsInternal)this).OSName = (string) content.GetValueForProperty("OSName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IInMageRcmDiscoveredProtectedVMDetailsInternal)this).OSName, global::System.Convert.ToString);
            }
            if (content.Contains("CreatedTimestamp"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IInMageRcmDiscoveredProtectedVMDetailsInternal)this).CreatedTimestamp = (global::System.DateTime?) content.GetValueForProperty("CreatedTimestamp",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IInMageRcmDiscoveredProtectedVMDetailsInternal)this).CreatedTimestamp, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("UpdatedTimestamp"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IInMageRcmDiscoveredProtectedVMDetailsInternal)this).UpdatedTimestamp = (global::System.DateTime?) content.GetValueForProperty("UpdatedTimestamp",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IInMageRcmDiscoveredProtectedVMDetailsInternal)this).UpdatedTimestamp, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("IsDeleted"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IInMageRcmDiscoveredProtectedVMDetailsInternal)this).IsDeleted = (bool?) content.GetValueForProperty("IsDeleted",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IInMageRcmDiscoveredProtectedVMDetailsInternal)this).IsDeleted, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("LastDiscoveryTimeInUtc"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IInMageRcmDiscoveredProtectedVMDetailsInternal)this).LastDiscoveryTimeInUtc = (global::System.DateTime?) content.GetValueForProperty("LastDiscoveryTimeInUtc",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IInMageRcmDiscoveredProtectedVMDetailsInternal)this).LastDiscoveryTimeInUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.InMageRcmDiscoveredProtectedVMDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal InMageRcmDiscoveredProtectedVMDetails(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("VCenterId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IInMageRcmDiscoveredProtectedVMDetailsInternal)this).VCenterId = (string) content.GetValueForProperty("VCenterId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IInMageRcmDiscoveredProtectedVMDetailsInternal)this).VCenterId, global::System.Convert.ToString);
            }
            if (content.Contains("VCenterFqdn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IInMageRcmDiscoveredProtectedVMDetailsInternal)this).VCenterFqdn = (string) content.GetValueForProperty("VCenterFqdn",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IInMageRcmDiscoveredProtectedVMDetailsInternal)this).VCenterFqdn, global::System.Convert.ToString);
            }
            if (content.Contains("Datastore"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IInMageRcmDiscoveredProtectedVMDetailsInternal)this).Datastore = (string[]) content.GetValueForProperty("Datastore",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IInMageRcmDiscoveredProtectedVMDetailsInternal)this).Datastore, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("IPAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IInMageRcmDiscoveredProtectedVMDetailsInternal)this).IPAddress = (string[]) content.GetValueForProperty("IPAddress",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IInMageRcmDiscoveredProtectedVMDetailsInternal)this).IPAddress, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("VmwareToolsStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IInMageRcmDiscoveredProtectedVMDetailsInternal)this).VmwareToolsStatus = (string) content.GetValueForProperty("VmwareToolsStatus",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IInMageRcmDiscoveredProtectedVMDetailsInternal)this).VmwareToolsStatus, global::System.Convert.ToString);
            }
            if (content.Contains("PowerStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IInMageRcmDiscoveredProtectedVMDetailsInternal)this).PowerStatus = (string) content.GetValueForProperty("PowerStatus",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IInMageRcmDiscoveredProtectedVMDetailsInternal)this).PowerStatus, global::System.Convert.ToString);
            }
            if (content.Contains("VMFqdn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IInMageRcmDiscoveredProtectedVMDetailsInternal)this).VMFqdn = (string) content.GetValueForProperty("VMFqdn",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IInMageRcmDiscoveredProtectedVMDetailsInternal)this).VMFqdn, global::System.Convert.ToString);
            }
            if (content.Contains("OSName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IInMageRcmDiscoveredProtectedVMDetailsInternal)this).OSName = (string) content.GetValueForProperty("OSName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IInMageRcmDiscoveredProtectedVMDetailsInternal)this).OSName, global::System.Convert.ToString);
            }
            if (content.Contains("CreatedTimestamp"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IInMageRcmDiscoveredProtectedVMDetailsInternal)this).CreatedTimestamp = (global::System.DateTime?) content.GetValueForProperty("CreatedTimestamp",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IInMageRcmDiscoveredProtectedVMDetailsInternal)this).CreatedTimestamp, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("UpdatedTimestamp"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IInMageRcmDiscoveredProtectedVMDetailsInternal)this).UpdatedTimestamp = (global::System.DateTime?) content.GetValueForProperty("UpdatedTimestamp",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IInMageRcmDiscoveredProtectedVMDetailsInternal)this).UpdatedTimestamp, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("IsDeleted"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IInMageRcmDiscoveredProtectedVMDetailsInternal)this).IsDeleted = (bool?) content.GetValueForProperty("IsDeleted",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IInMageRcmDiscoveredProtectedVMDetailsInternal)this).IsDeleted, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("LastDiscoveryTimeInUtc"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IInMageRcmDiscoveredProtectedVMDetailsInternal)this).LastDiscoveryTimeInUtc = (global::System.DateTime?) content.GetValueForProperty("LastDiscoveryTimeInUtc",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IInMageRcmDiscoveredProtectedVMDetailsInternal)this).LastDiscoveryTimeInUtc, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// InMageRcm discovered protected VM details.
    [System.ComponentModel.TypeConverter(typeof(InMageRcmDiscoveredProtectedVMDetailsTypeConverter))]
    public partial interface IInMageRcmDiscoveredProtectedVMDetails

    {

    }
}