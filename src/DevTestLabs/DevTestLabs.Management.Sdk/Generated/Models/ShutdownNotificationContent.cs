// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.DevTestLabs.Models
{
    using System.Linq;

    /// <summary>
    /// The contents of a shutdown notification. Webhooks can use this type to
    /// deserialize the request body when they get notified of an imminent
    /// shutdown.
    /// </summary>
    public partial class ShutdownNotificationContent
    {
        /// <summary>
        /// Initializes a new instance of the ShutdownNotificationContent class.
        /// </summary>
        public ShutdownNotificationContent()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ShutdownNotificationContent class.
        /// </summary>

        /// <param name="skipUrl">The URL to skip auto-shutdown.
        /// </param>

        /// <param name="delayUrl60">The URL to delay shutdown by 60 minutes.
        /// </param>

        /// <param name="delayUrl120">The URL to delay shutdown by 2 hours.
        /// </param>

        /// <param name="vmName">The virtual machine to be shut down.
        /// </param>

        /// <param name="guid">The GUID for the virtual machine to be shut down.
        /// </param>

        /// <param name="owner">The owner of the virtual machine.
        /// </param>

        /// <param name="eventType">The event for which a notification will be sent.
        /// </param>

        /// <param name="text">The text for the notification.
        /// </param>

        /// <param name="subscriptionId">The subscription ID for the schedule.
        /// </param>

        /// <param name="resourceGroupName">The resource group name for the schedule.
        /// </param>

        /// <param name="labName">The lab for the schedule.
        /// </param>
        public ShutdownNotificationContent(string skipUrl = default(string), string delayUrl60 = default(string), string delayUrl120 = default(string), string vmName = default(string), string guid = default(string), string owner = default(string), string eventType = default(string), string text = default(string), string subscriptionId = default(string), string resourceGroupName = default(string), string labName = default(string))

        {
            this.SkipUrl = skipUrl;
            this.DelayUrl60 = delayUrl60;
            this.DelayUrl120 = delayUrl120;
            this.VMName = vmName;
            this.Guid = guid;
            this.Owner = owner;
            this.EventType = eventType;
            this.Text = text;
            this.SubscriptionId = subscriptionId;
            this.ResourceGroupName = resourceGroupName;
            this.LabName = labName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the URL to skip auto-shutdown.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "skipUrl")]
        public string SkipUrl {get; set; }

        /// <summary>
        /// Gets or sets the URL to delay shutdown by 60 minutes.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "delayUrl60")]
        public string DelayUrl60 {get; set; }

        /// <summary>
        /// Gets or sets the URL to delay shutdown by 2 hours.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "delayUrl120")]
        public string DelayUrl120 {get; set; }

        /// <summary>
        /// Gets or sets the virtual machine to be shut down.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "vmName")]
        public string VMName {get; set; }

        /// <summary>
        /// Gets or sets the GUID for the virtual machine to be shut down.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "guid")]
        public string Guid {get; set; }

        /// <summary>
        /// Gets or sets the owner of the virtual machine.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "owner")]
        public string Owner {get; set; }

        /// <summary>
        /// Gets or sets the event for which a notification will be sent.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "eventType")]
        public string EventType {get; set; }

        /// <summary>
        /// Gets or sets the text for the notification.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "text")]
        public string Text {get; set; }

        /// <summary>
        /// Gets or sets the subscription ID for the schedule.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "subscriptionId")]
        public string SubscriptionId {get; set; }

        /// <summary>
        /// Gets or sets the resource group name for the schedule.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "resourceGroupName")]
        public string ResourceGroupName {get; set; }

        /// <summary>
        /// Gets or sets the lab for the schedule.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "labName")]
        public string LabName {get; set; }
    }
}