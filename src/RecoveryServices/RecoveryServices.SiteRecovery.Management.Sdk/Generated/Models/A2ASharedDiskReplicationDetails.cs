// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using System.Linq;

    /// <summary>
    /// A2A provider specific settings.
    /// </summary>
    [Newtonsoft.Json.JsonObject("A2A")]
    public partial class A2ASharedDiskReplicationDetails : SharedDiskReplicationProviderSpecificSettings
    {
        /// <summary>
        /// Initializes a new instance of the A2ASharedDiskReplicationDetails class.
        /// </summary>
        public A2ASharedDiskReplicationDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the A2ASharedDiskReplicationDetails class.
        /// </summary>

        /// <param name="managementId">The management Id.
        /// </param>

        /// <param name="unprotectedDisks">The list of unprotected disks.
        /// </param>

        /// <param name="protectedManagedDisks">The list of protected managed disks.
        /// </param>

        /// <param name="primaryFabricLocation">Primary fabric location.
        /// </param>

        /// <param name="recoveryFabricLocation">The recovery fabric location.
        /// </param>

        /// <param name="failoverRecoveryPointId">The recovery point id to which the Virtual node was failed over.
        /// </param>

        /// <param name="monitoringPercentageCompletion">The percentage of the monitoring job. The type of the monitoring job is
        /// defined by MonitoringJobType property.
        /// </param>

        /// <param name="monitoringJobType">The type of the monitoring job. The progress is contained in
        /// MonitoringPercentageCompletion property.
        /// </param>

        /// <param name="rpoInSeconds">The last RPO value in seconds.
        /// </param>

        /// <param name="lastRpoCalculatedTime">The time (in UTC) when the last RPO value was calculated by Protection
        /// Service.
        /// </param>

        /// <param name="sharedDiskIrErrors">The IR Errors.
        /// </param>
        public A2ASharedDiskReplicationDetails(string managementId = default(string), System.Collections.Generic.IList<A2AUnprotectedDiskDetails> unprotectedDisks = default(System.Collections.Generic.IList<A2AUnprotectedDiskDetails>), System.Collections.Generic.IList<A2AProtectedManagedDiskDetails> protectedManagedDisks = default(System.Collections.Generic.IList<A2AProtectedManagedDiskDetails>), string primaryFabricLocation = default(string), string recoveryFabricLocation = default(string), string failoverRecoveryPointId = default(string), int? monitoringPercentageCompletion = default(int?), string monitoringJobType = default(string), long? rpoInSeconds = default(long?), System.DateTime? lastRpoCalculatedTime = default(System.DateTime?), System.Collections.Generic.IList<A2ASharedDiskIRErrorDetails> sharedDiskIrErrors = default(System.Collections.Generic.IList<A2ASharedDiskIRErrorDetails>))

        {
            this.ManagementId = managementId;
            this.UnprotectedDisks = unprotectedDisks;
            this.ProtectedManagedDisks = protectedManagedDisks;
            this.PrimaryFabricLocation = primaryFabricLocation;
            this.RecoveryFabricLocation = recoveryFabricLocation;
            this.FailoverRecoveryPointId = failoverRecoveryPointId;
            this.MonitoringPercentageCompletion = monitoringPercentageCompletion;
            this.MonitoringJobType = monitoringJobType;
            this.RpoInSeconds = rpoInSeconds;
            this.LastRpoCalculatedTime = lastRpoCalculatedTime;
            this.SharedDiskIrErrors = sharedDiskIrErrors;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the management Id.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "managementId")]
        public string ManagementId {get; set; }

        /// <summary>
        /// Gets or sets the list of unprotected disks.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "unprotectedDisks")]
        public System.Collections.Generic.IList<A2AUnprotectedDiskDetails> UnprotectedDisks {get; set; }

        /// <summary>
        /// Gets or sets the list of protected managed disks.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "protectedManagedDisks")]
        public System.Collections.Generic.IList<A2AProtectedManagedDiskDetails> ProtectedManagedDisks {get; set; }

        /// <summary>
        /// Gets or sets primary fabric location.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "primaryFabricLocation")]
        public string PrimaryFabricLocation {get; set; }

        /// <summary>
        /// Gets or sets the recovery fabric location.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "recoveryFabricLocation")]
        public string RecoveryFabricLocation {get; set; }

        /// <summary>
        /// Gets or sets the recovery point id to which the Virtual node was failed
        /// over.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "failoverRecoveryPointId")]
        public string FailoverRecoveryPointId {get; set; }

        /// <summary>
        /// Gets or sets the percentage of the monitoring job. The type of the
        /// monitoring job is defined by MonitoringJobType property.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "monitoringPercentageCompletion")]
        public int? MonitoringPercentageCompletion {get; set; }

        /// <summary>
        /// Gets or sets the type of the monitoring job. The progress is contained in
        /// MonitoringPercentageCompletion property.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "monitoringJobType")]
        public string MonitoringJobType {get; set; }

        /// <summary>
        /// Gets or sets the last RPO value in seconds.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "rpoInSeconds")]
        public long? RpoInSeconds {get; set; }

        /// <summary>
        /// Gets or sets the time (in UTC) when the last RPO value was calculated by
        /// Protection Service.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "lastRpoCalculatedTime")]
        public System.DateTime? LastRpoCalculatedTime {get; set; }

        /// <summary>
        /// Gets or sets the IR Errors.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "sharedDiskIRErrors")]
        public System.Collections.Generic.IList<A2ASharedDiskIRErrorDetails> SharedDiskIrErrors {get; set; }
    }
}