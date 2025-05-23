// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Ssh.Helpers.HybridCompute.Models
{
    using System.Linq;

    /// <summary>
    /// Describes the status and behavior of a service.
    /// </summary>
    public partial class ServiceStatus
    {
        /// <summary>
        /// Initializes a new instance of the ServiceStatus class.
        /// </summary>
        public ServiceStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServiceStatus class.
        /// </summary>

        /// <param name="status">The current status of the service.
        /// </param>

        /// <param name="startupType">The behavior of the service when the Arc-enabled machine starts up.
        /// </param>
        public ServiceStatus(string status = default(string), string startupType = default(string))

        {
            this.Status = status;
            this.StartupType = startupType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the current status of the service.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "status")]
        public string Status {get; set; }

        /// <summary>
        /// Gets or sets the behavior of the service when the Arc-enabled machine
        /// starts up.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "startupType")]
        public string StartupType {get; set; }
    }
}