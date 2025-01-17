// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Extensions;

    /// <summary>Defines the event properties.</summary>
    public partial class EventBase :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IEventBase,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IEventBaseInternal
    {

        /// <summary>Backing field for <see cref="Configuration" /> property.</summary>
        private string _configuration;

        /// <summary>
        /// Stringified JSON that contains connector-specific configuration for the event. For OPC UA, this could include configuration
        /// like, publishingInterval, samplingInterval, and queueSize.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        public string Configuration { get => this._configuration; set => this._configuration = value; }

        /// <summary>Internal Acessors for Topic</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ITopic Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IEventBaseInternal.Topic { get => (this._topic = this._topic ?? new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.Topic()); set { {_topic = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name of the event.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Notifier" /> property.</summary>
        private string _notifier;

        /// <summary>
        /// The address of the notifier of the event in the asset (e.g. URL) so that a client can access the event on the asset.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        public string Notifier { get => this._notifier; set => this._notifier = value; }

        /// <summary>Backing field for <see cref="Topic" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ITopic _topic;

        /// <summary>Object that describes the topic information for the specific event.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ITopic Topic { get => (this._topic = this._topic ?? new Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.Topic()); set => this._topic = value; }

        /// <summary>The topic path for messages published to an MQTT broker.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public string TopicPath { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ITopicInternal)Topic).Path; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ITopicInternal)Topic).Path = value ?? null; }

        /// <summary>
        /// When set to 'Keep', messages published to an MQTT broker will have the retain flag set. Default: 'Never'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PropertyOrigin.Inlined)]
        public string TopicRetain { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ITopicInternal)Topic).Retain; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ITopicInternal)Topic).Retain = value ?? null; }

        /// <summary>Creates an new <see cref="EventBase" /> instance.</summary>
        public EventBase()
        {

        }
    }
    /// Defines the event properties.
    public partial interface IEventBase :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Stringified JSON that contains connector-specific configuration for the event. For OPC UA, this could include configuration
        /// like, publishingInterval, samplingInterval, and queueSize.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Stringified JSON that contains connector-specific configuration for the event. For OPC UA, this could include configuration like, publishingInterval, samplingInterval, and queueSize.",
        SerializedName = @"eventConfiguration",
        PossibleTypes = new [] { typeof(string) })]
        string Configuration { get; set; }
        /// <summary>The name of the event.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the event.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>
        /// The address of the notifier of the event in the asset (e.g. URL) so that a client can access the event on the asset.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The address of the notifier of the event in the asset (e.g. URL) so that a client can access the event on the asset.",
        SerializedName = @"eventNotifier",
        PossibleTypes = new [] { typeof(string) })]
        string Notifier { get; set; }
        /// <summary>The topic path for messages published to an MQTT broker.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The topic path for messages published to an MQTT broker.",
        SerializedName = @"path",
        PossibleTypes = new [] { typeof(string) })]
        string TopicPath { get; set; }
        /// <summary>
        /// When set to 'Keep', messages published to an MQTT broker will have the retain flag set. Default: 'Never'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"When set to 'Keep', messages published to an MQTT broker will have the retain flag set. Default: 'Never'.",
        SerializedName = @"retain",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PSArgumentCompleterAttribute("Keep", "Never")]
        string TopicRetain { get; set; }

    }
    /// Defines the event properties.
    internal partial interface IEventBaseInternal

    {
        /// <summary>
        /// Stringified JSON that contains connector-specific configuration for the event. For OPC UA, this could include configuration
        /// like, publishingInterval, samplingInterval, and queueSize.
        /// </summary>
        string Configuration { get; set; }
        /// <summary>The name of the event.</summary>
        string Name { get; set; }
        /// <summary>
        /// The address of the notifier of the event in the asset (e.g. URL) so that a client can access the event on the asset.
        /// </summary>
        string Notifier { get; set; }
        /// <summary>Object that describes the topic information for the specific event.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.ITopic Topic { get; set; }
        /// <summary>The topic path for messages published to an MQTT broker.</summary>
        string TopicPath { get; set; }
        /// <summary>
        /// When set to 'Keep', messages published to an MQTT broker will have the retain flag set. Default: 'Never'.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.PSArgumentCompleterAttribute("Keep", "Never")]
        string TopicRetain { get; set; }

    }
}