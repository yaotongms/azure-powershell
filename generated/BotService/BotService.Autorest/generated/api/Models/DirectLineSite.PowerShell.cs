// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.BotService.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.PowerShell;

    /// <summary>A site for the Direct Line channel</summary>
    [System.ComponentModel.TypeConverter(typeof(DirectLineSiteTypeConverter))]
    public partial class DirectLineSite
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.DirectLineSite"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IDirectLineSite" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IDirectLineSite DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new DirectLineSite(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.DirectLineSite"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IDirectLineSite" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IDirectLineSite DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new DirectLineSite(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.DirectLineSite"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal DirectLineSite(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Key"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal)this).Key = (string) content.GetValueForProperty("Key",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal)this).Key, global::System.Convert.ToString);
            }
            if (content.Contains("Key2"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal)this).Key2 = (string) content.GetValueForProperty("Key2",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal)this).Key2, global::System.Convert.ToString);
            }
            if (content.Contains("IsEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal)this).IsEnabled = (bool) content.GetValueForProperty("IsEnabled",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal)this).IsEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IsTokenEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal)this).IsTokenEnabled = (bool?) content.GetValueForProperty("IsTokenEnabled",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal)this).IsTokenEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IsEndpointParametersEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal)this).IsEndpointParametersEnabled = (bool?) content.GetValueForProperty("IsEndpointParametersEnabled",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal)this).IsEndpointParametersEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IsDetailedLoggingEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal)this).IsDetailedLoggingEnabled = (bool?) content.GetValueForProperty("IsDetailedLoggingEnabled",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal)this).IsDetailedLoggingEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IsBlockUserUploadEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal)this).IsBlockUserUploadEnabled = (bool?) content.GetValueForProperty("IsBlockUserUploadEnabled",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal)this).IsBlockUserUploadEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IsNoStorageEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal)this).IsNoStorageEnabled = (bool?) content.GetValueForProperty("IsNoStorageEnabled",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal)this).IsNoStorageEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ETag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal)this).ETag = (string) content.GetValueForProperty("ETag",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal)this).ETag, global::System.Convert.ToString);
            }
            if (content.Contains("AppId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal)this).AppId = (string) content.GetValueForProperty("AppId",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal)this).AppId, global::System.Convert.ToString);
            }
            if (content.Contains("IsV1Enabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal)this).IsV1Enabled = (bool?) content.GetValueForProperty("IsV1Enabled",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal)this).IsV1Enabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IsV3Enabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal)this).IsV3Enabled = (bool?) content.GetValueForProperty("IsV3Enabled",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal)this).IsV3Enabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IsSecureSiteEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal)this).IsSecureSiteEnabled = (bool?) content.GetValueForProperty("IsSecureSiteEnabled",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal)this).IsSecureSiteEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("TrustedOrigin"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal)this).TrustedOrigin = (System.Collections.Generic.List<string>) content.GetValueForProperty("TrustedOrigin",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal)this).TrustedOrigin, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("IsWebchatPreviewEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal)this).IsWebchatPreviewEnabled = (bool?) content.GetValueForProperty("IsWebchatPreviewEnabled",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal)this).IsWebchatPreviewEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.DirectLineSite"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal DirectLineSite(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Key"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal)this).Key = (string) content.GetValueForProperty("Key",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal)this).Key, global::System.Convert.ToString);
            }
            if (content.Contains("Key2"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal)this).Key2 = (string) content.GetValueForProperty("Key2",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal)this).Key2, global::System.Convert.ToString);
            }
            if (content.Contains("IsEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal)this).IsEnabled = (bool) content.GetValueForProperty("IsEnabled",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal)this).IsEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IsTokenEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal)this).IsTokenEnabled = (bool?) content.GetValueForProperty("IsTokenEnabled",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal)this).IsTokenEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IsEndpointParametersEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal)this).IsEndpointParametersEnabled = (bool?) content.GetValueForProperty("IsEndpointParametersEnabled",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal)this).IsEndpointParametersEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IsDetailedLoggingEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal)this).IsDetailedLoggingEnabled = (bool?) content.GetValueForProperty("IsDetailedLoggingEnabled",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal)this).IsDetailedLoggingEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IsBlockUserUploadEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal)this).IsBlockUserUploadEnabled = (bool?) content.GetValueForProperty("IsBlockUserUploadEnabled",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal)this).IsBlockUserUploadEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IsNoStorageEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal)this).IsNoStorageEnabled = (bool?) content.GetValueForProperty("IsNoStorageEnabled",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal)this).IsNoStorageEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("ETag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal)this).ETag = (string) content.GetValueForProperty("ETag",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal)this).ETag, global::System.Convert.ToString);
            }
            if (content.Contains("AppId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal)this).AppId = (string) content.GetValueForProperty("AppId",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal)this).AppId, global::System.Convert.ToString);
            }
            if (content.Contains("IsV1Enabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal)this).IsV1Enabled = (bool?) content.GetValueForProperty("IsV1Enabled",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal)this).IsV1Enabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IsV3Enabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal)this).IsV3Enabled = (bool?) content.GetValueForProperty("IsV3Enabled",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal)this).IsV3Enabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IsSecureSiteEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal)this).IsSecureSiteEnabled = (bool?) content.GetValueForProperty("IsSecureSiteEnabled",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal)this).IsSecureSiteEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("TrustedOrigin"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal)this).TrustedOrigin = (System.Collections.Generic.List<string>) content.GetValueForProperty("TrustedOrigin",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal)this).TrustedOrigin, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("IsWebchatPreviewEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal)this).IsWebchatPreviewEnabled = (bool?) content.GetValueForProperty("IsWebchatPreviewEnabled",((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal)this).IsWebchatPreviewEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="DirectLineSite" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="DirectLineSite" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.IDirectLineSite FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// A site for the Direct Line channel
    [System.ComponentModel.TypeConverter(typeof(DirectLineSiteTypeConverter))]
    public partial interface IDirectLineSite

    {

    }
}