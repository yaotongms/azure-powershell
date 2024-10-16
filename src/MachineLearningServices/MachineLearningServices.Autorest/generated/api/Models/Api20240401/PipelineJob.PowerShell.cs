// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401
{
    using Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.PowerShell;

    /// <summary>Pipeline Job definition: defines generic to MFE attributes.</summary>
    [System.ComponentModel.TypeConverter(typeof(PipelineJobTypeConverter))]
    public partial class PipelineJob
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.PipelineJob"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IPipelineJob"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IPipelineJob DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new PipelineJob(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.PipelineJob"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IPipelineJob"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IPipelineJob DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new PipelineJob(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="PipelineJob" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="PipelineJob" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IPipelineJob FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.PipelineJob"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal PipelineJob(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Input"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IPipelineJobInternal)this).Input = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IPipelineJobInputs) content.GetValueForProperty("Input",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IPipelineJobInternal)this).Input, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.PipelineJobInputsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Job"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IPipelineJobInternal)this).Job = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IPipelineJobJobs) content.GetValueForProperty("Job",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IPipelineJobInternal)this).Job, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.PipelineJobJobsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Output"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IPipelineJobInternal)this).Output = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IPipelineJobOutputs) content.GetValueForProperty("Output",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IPipelineJobInternal)this).Output, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.PipelineJobOutputsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Setting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IPipelineJobInternal)this).Setting = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IAny) content.GetValueForProperty("Setting",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IPipelineJobInternal)this).Setting, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.AnyTypeConverter.ConvertFrom);
            }
            if (content.Contains("SourceJobId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IPipelineJobInternal)this).SourceJobId = (string) content.GetValueForProperty("SourceJobId",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IPipelineJobInternal)this).SourceJobId, global::System.Convert.ToString);
            }
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IResourceBaseInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IResourceBaseInternal)this).Description, global::System.Convert.ToString);
            }
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IResourceBaseInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IResourceBaseProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IResourceBaseInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ResourceBasePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IResourceBaseInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IResourceBaseTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IResourceBaseInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ResourceBaseTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("NotificationSettingEmailOn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IJobBasePropertiesInternal)this).NotificationSettingEmailOn = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.EmailNotificationEnableType[]) content.GetValueForProperty("NotificationSettingEmailOn",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IJobBasePropertiesInternal)this).NotificationSettingEmailOn, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.EmailNotificationEnableType>(__y, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.EmailNotificationEnableType.CreateFrom));
            }
            if (content.Contains("NotificationSettingEmail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IJobBasePropertiesInternal)this).NotificationSettingEmail = (string[]) content.GetValueForProperty("NotificationSettingEmail",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IJobBasePropertiesInternal)this).NotificationSettingEmail, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("NotificationSettingWebhook"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IJobBasePropertiesInternal)this).NotificationSettingWebhook = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.INotificationSettingWebhooks) content.GetValueForProperty("NotificationSettingWebhook",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IJobBasePropertiesInternal)this).NotificationSettingWebhook, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.NotificationSettingWebhooksTypeConverter.ConvertFrom);
            }
            if (content.Contains("IdentityType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IJobBasePropertiesInternal)this).IdentityType = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.IdentityConfigurationType) content.GetValueForProperty("IdentityType",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IJobBasePropertiesInternal)this).IdentityType, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.IdentityConfigurationType.CreateFrom);
            }
            if (content.Contains("Identity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IJobBasePropertiesInternal)this).Identity = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IIdentityConfiguration) content.GetValueForProperty("Identity",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IJobBasePropertiesInternal)this).Identity, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IdentityConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("NotificationSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IJobBasePropertiesInternal)this).NotificationSetting = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.INotificationSetting) content.GetValueForProperty("NotificationSetting",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IJobBasePropertiesInternal)this).NotificationSetting, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.NotificationSettingTypeConverter.ConvertFrom);
            }
            if (content.Contains("ComponentId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IJobBasePropertiesInternal)this).ComponentId = (string) content.GetValueForProperty("ComponentId",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IJobBasePropertiesInternal)this).ComponentId, global::System.Convert.ToString);
            }
            if (content.Contains("ComputeId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IJobBasePropertiesInternal)this).ComputeId = (string) content.GetValueForProperty("ComputeId",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IJobBasePropertiesInternal)this).ComputeId, global::System.Convert.ToString);
            }
            if (content.Contains("DisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IJobBasePropertiesInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IJobBasePropertiesInternal)this).DisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("ExperimentName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IJobBasePropertiesInternal)this).ExperimentName = (string) content.GetValueForProperty("ExperimentName",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IJobBasePropertiesInternal)this).ExperimentName, global::System.Convert.ToString);
            }
            if (content.Contains("IsArchived"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IJobBasePropertiesInternal)this).IsArchived = (bool?) content.GetValueForProperty("IsArchived",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IJobBasePropertiesInternal)this).IsArchived, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("JobType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IJobBasePropertiesInternal)this).JobType = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.JobType) content.GetValueForProperty("JobType",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IJobBasePropertiesInternal)this).JobType, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.JobType.CreateFrom);
            }
            if (content.Contains("Service"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IJobBasePropertiesInternal)this).Service = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IJobBaseServices) content.GetValueForProperty("Service",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IJobBasePropertiesInternal)this).Service, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.JobBaseServicesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IJobBasePropertiesInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.JobStatus?) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IJobBasePropertiesInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.JobStatus.CreateFrom);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.PipelineJob"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal PipelineJob(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Input"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IPipelineJobInternal)this).Input = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IPipelineJobInputs) content.GetValueForProperty("Input",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IPipelineJobInternal)this).Input, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.PipelineJobInputsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Job"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IPipelineJobInternal)this).Job = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IPipelineJobJobs) content.GetValueForProperty("Job",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IPipelineJobInternal)this).Job, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.PipelineJobJobsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Output"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IPipelineJobInternal)this).Output = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IPipelineJobOutputs) content.GetValueForProperty("Output",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IPipelineJobInternal)this).Output, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.PipelineJobOutputsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Setting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IPipelineJobInternal)this).Setting = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IAny) content.GetValueForProperty("Setting",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IPipelineJobInternal)this).Setting, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.AnyTypeConverter.ConvertFrom);
            }
            if (content.Contains("SourceJobId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IPipelineJobInternal)this).SourceJobId = (string) content.GetValueForProperty("SourceJobId",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IPipelineJobInternal)this).SourceJobId, global::System.Convert.ToString);
            }
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IResourceBaseInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IResourceBaseInternal)this).Description, global::System.Convert.ToString);
            }
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IResourceBaseInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IResourceBaseProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IResourceBaseInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ResourceBasePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IResourceBaseInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IResourceBaseTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IResourceBaseInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ResourceBaseTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("NotificationSettingEmailOn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IJobBasePropertiesInternal)this).NotificationSettingEmailOn = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.EmailNotificationEnableType[]) content.GetValueForProperty("NotificationSettingEmailOn",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IJobBasePropertiesInternal)this).NotificationSettingEmailOn, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.EmailNotificationEnableType>(__y, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.EmailNotificationEnableType.CreateFrom));
            }
            if (content.Contains("NotificationSettingEmail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IJobBasePropertiesInternal)this).NotificationSettingEmail = (string[]) content.GetValueForProperty("NotificationSettingEmail",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IJobBasePropertiesInternal)this).NotificationSettingEmail, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("NotificationSettingWebhook"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IJobBasePropertiesInternal)this).NotificationSettingWebhook = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.INotificationSettingWebhooks) content.GetValueForProperty("NotificationSettingWebhook",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IJobBasePropertiesInternal)this).NotificationSettingWebhook, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.NotificationSettingWebhooksTypeConverter.ConvertFrom);
            }
            if (content.Contains("IdentityType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IJobBasePropertiesInternal)this).IdentityType = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.IdentityConfigurationType) content.GetValueForProperty("IdentityType",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IJobBasePropertiesInternal)this).IdentityType, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.IdentityConfigurationType.CreateFrom);
            }
            if (content.Contains("Identity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IJobBasePropertiesInternal)this).Identity = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IIdentityConfiguration) content.GetValueForProperty("Identity",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IJobBasePropertiesInternal)this).Identity, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IdentityConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("NotificationSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IJobBasePropertiesInternal)this).NotificationSetting = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.INotificationSetting) content.GetValueForProperty("NotificationSetting",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IJobBasePropertiesInternal)this).NotificationSetting, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.NotificationSettingTypeConverter.ConvertFrom);
            }
            if (content.Contains("ComponentId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IJobBasePropertiesInternal)this).ComponentId = (string) content.GetValueForProperty("ComponentId",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IJobBasePropertiesInternal)this).ComponentId, global::System.Convert.ToString);
            }
            if (content.Contains("ComputeId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IJobBasePropertiesInternal)this).ComputeId = (string) content.GetValueForProperty("ComputeId",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IJobBasePropertiesInternal)this).ComputeId, global::System.Convert.ToString);
            }
            if (content.Contains("DisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IJobBasePropertiesInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IJobBasePropertiesInternal)this).DisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("ExperimentName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IJobBasePropertiesInternal)this).ExperimentName = (string) content.GetValueForProperty("ExperimentName",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IJobBasePropertiesInternal)this).ExperimentName, global::System.Convert.ToString);
            }
            if (content.Contains("IsArchived"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IJobBasePropertiesInternal)this).IsArchived = (bool?) content.GetValueForProperty("IsArchived",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IJobBasePropertiesInternal)this).IsArchived, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("JobType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IJobBasePropertiesInternal)this).JobType = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.JobType) content.GetValueForProperty("JobType",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IJobBasePropertiesInternal)this).JobType, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.JobType.CreateFrom);
            }
            if (content.Contains("Service"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IJobBasePropertiesInternal)this).Service = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IJobBaseServices) content.GetValueForProperty("Service",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IJobBasePropertiesInternal)this).Service, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.JobBaseServicesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IJobBasePropertiesInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.JobStatus?) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IJobBasePropertiesInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.JobStatus.CreateFrom);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Pipeline Job definition: defines generic to MFE attributes.
    [System.ComponentModel.TypeConverter(typeof(PipelineJobTypeConverter))]
    public partial interface IPipelineJob

    {

    }
}