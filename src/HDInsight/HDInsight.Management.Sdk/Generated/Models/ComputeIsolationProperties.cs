// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.HDInsight.Models
{
    using System.Linq;

    /// <summary>
    /// The compute isolation properties.
    /// </summary>
    public partial class ComputeIsolationProperties
    {
        /// <summary>
        /// Initializes a new instance of the ComputeIsolationProperties class.
        /// </summary>
        public ComputeIsolationProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ComputeIsolationProperties class.
        /// </summary>

        /// <param name="enableComputeIsolation">The flag indicates whether enable compute isolation or not.
        /// </param>

        /// <param name="hostSku">The host sku.
        /// </param>
        public ComputeIsolationProperties(bool? enableComputeIsolation = default(bool?), string hostSku = default(string))

        {
            this.EnableComputeIsolation = enableComputeIsolation;
            this.HostSku = hostSku;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the flag indicates whether enable compute isolation or not.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "enableComputeIsolation")]
        public bool? EnableComputeIsolation {get; set; }

        /// <summary>
        /// Gets or sets the host sku.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "hostSku")]
        public string HostSku {get; set; }
    }
}