// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20230701Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.PowerShell;

    /// <summary>Represents the updatable properties of a DNS security rule.</summary>
    [System.ComponentModel.TypeConverter(typeof(DnsSecurityRulePatchPropertiesTypeConverter))]
    public partial class DnsSecurityRulePatchProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20230701Preview.DnsSecurityRulePatchProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20230701Preview.IDnsSecurityRulePatchProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20230701Preview.IDnsSecurityRulePatchProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new DnsSecurityRulePatchProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20230701Preview.DnsSecurityRulePatchProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20230701Preview.IDnsSecurityRulePatchProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20230701Preview.IDnsSecurityRulePatchProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new DnsSecurityRulePatchProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20230701Preview.DnsSecurityRulePatchProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal DnsSecurityRulePatchProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Action"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20230701Preview.IDnsSecurityRulePatchPropertiesInternal)this).Action = (Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20230701Preview.IDnsSecurityRuleAction) content.GetValueForProperty("Action",((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20230701Preview.IDnsSecurityRulePatchPropertiesInternal)this).Action, Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20230701Preview.DnsSecurityRuleActionTypeConverter.ConvertFrom);
            }
            if (content.Contains("DnsResolverDomainList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20230701Preview.IDnsSecurityRulePatchPropertiesInternal)this).DnsResolverDomainList = (Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20230701Preview.ISubResource[]) content.GetValueForProperty("DnsResolverDomainList",((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20230701Preview.IDnsSecurityRulePatchPropertiesInternal)this).DnsResolverDomainList, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20230701Preview.ISubResource>(__y, Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20230701Preview.SubResourceTypeConverter.ConvertFrom));
            }
            if (content.Contains("DnsSecurityRuleState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20230701Preview.IDnsSecurityRulePatchPropertiesInternal)this).DnsSecurityRuleState = (Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Support.DnsSecurityRuleState?) content.GetValueForProperty("DnsSecurityRuleState",((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20230701Preview.IDnsSecurityRulePatchPropertiesInternal)this).DnsSecurityRuleState, Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Support.DnsSecurityRuleState.CreateFrom);
            }
            if (content.Contains("Priority"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20230701Preview.IDnsSecurityRulePatchPropertiesInternal)this).Priority = (int?) content.GetValueForProperty("Priority",((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20230701Preview.IDnsSecurityRulePatchPropertiesInternal)this).Priority, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("ActionType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20230701Preview.IDnsSecurityRulePatchPropertiesInternal)this).ActionType = (Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Support.ActionType?) content.GetValueForProperty("ActionType",((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20230701Preview.IDnsSecurityRulePatchPropertiesInternal)this).ActionType, Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Support.ActionType.CreateFrom);
            }
            if (content.Contains("ActionBlockResponseCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20230701Preview.IDnsSecurityRulePatchPropertiesInternal)this).ActionBlockResponseCode = (Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Support.BlockResponseCode?) content.GetValueForProperty("ActionBlockResponseCode",((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20230701Preview.IDnsSecurityRulePatchPropertiesInternal)this).ActionBlockResponseCode, Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Support.BlockResponseCode.CreateFrom);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20230701Preview.DnsSecurityRulePatchProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal DnsSecurityRulePatchProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Action"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20230701Preview.IDnsSecurityRulePatchPropertiesInternal)this).Action = (Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20230701Preview.IDnsSecurityRuleAction) content.GetValueForProperty("Action",((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20230701Preview.IDnsSecurityRulePatchPropertiesInternal)this).Action, Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20230701Preview.DnsSecurityRuleActionTypeConverter.ConvertFrom);
            }
            if (content.Contains("DnsResolverDomainList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20230701Preview.IDnsSecurityRulePatchPropertiesInternal)this).DnsResolverDomainList = (Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20230701Preview.ISubResource[]) content.GetValueForProperty("DnsResolverDomainList",((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20230701Preview.IDnsSecurityRulePatchPropertiesInternal)this).DnsResolverDomainList, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20230701Preview.ISubResource>(__y, Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20230701Preview.SubResourceTypeConverter.ConvertFrom));
            }
            if (content.Contains("DnsSecurityRuleState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20230701Preview.IDnsSecurityRulePatchPropertiesInternal)this).DnsSecurityRuleState = (Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Support.DnsSecurityRuleState?) content.GetValueForProperty("DnsSecurityRuleState",((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20230701Preview.IDnsSecurityRulePatchPropertiesInternal)this).DnsSecurityRuleState, Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Support.DnsSecurityRuleState.CreateFrom);
            }
            if (content.Contains("Priority"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20230701Preview.IDnsSecurityRulePatchPropertiesInternal)this).Priority = (int?) content.GetValueForProperty("Priority",((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20230701Preview.IDnsSecurityRulePatchPropertiesInternal)this).Priority, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("ActionType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20230701Preview.IDnsSecurityRulePatchPropertiesInternal)this).ActionType = (Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Support.ActionType?) content.GetValueForProperty("ActionType",((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20230701Preview.IDnsSecurityRulePatchPropertiesInternal)this).ActionType, Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Support.ActionType.CreateFrom);
            }
            if (content.Contains("ActionBlockResponseCode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20230701Preview.IDnsSecurityRulePatchPropertiesInternal)this).ActionBlockResponseCode = (Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Support.BlockResponseCode?) content.GetValueForProperty("ActionBlockResponseCode",((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20230701Preview.IDnsSecurityRulePatchPropertiesInternal)this).ActionBlockResponseCode, Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Support.BlockResponseCode.CreateFrom);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="DnsSecurityRulePatchProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="DnsSecurityRulePatchProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20230701Preview.IDnsSecurityRulePatchProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Represents the updatable properties of a DNS security rule.
    [System.ComponentModel.TypeConverter(typeof(DnsSecurityRulePatchPropertiesTypeConverter))]
    public partial interface IDnsSecurityRulePatchProperties

    {

    }
}