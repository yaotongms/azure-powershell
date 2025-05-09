// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Specifies ProxyAgent settings for the virtual machine or virtual
    /// machine scale set. Minimum api-version: 2023-09-01.
    /// </summary>
    public partial class ProxyAgentSettings
    {
        /// <summary>
        /// Initializes a new instance of the ProxyAgentSettings class.
        /// </summary>
        public ProxyAgentSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ProxyAgentSettings class.
        /// </summary>
        /// <param name="enabled">Specifies whether ProxyAgent feature should
        /// be enabled on the virtual machine or virtual machine scale
        /// set.</param>
        /// <param name="mode">Specifies the mode that ProxyAgent will execute
        /// on. Warning: this property has been deprecated, please specify
        /// 'mode' under particular hostendpoint setting. Possible values
        /// include: 'Audit', 'Enforce'</param>
        /// <param name="keyIncarnationId">Increase the value of this property
        /// allows users to reset the key used for securing communication
        /// channel between guest and host.</param>
        /// <param name="wireServer">Specifies the Wire Server endpoint
        /// settings while creating the virtual machine or virtual machine
        /// scale set. Minimum api-version: 2024-03-01.</param>
        /// <param name="imds">Specifies the IMDS endpoint settings while
        /// creating the virtual machine or virtual machine scale set. Minimum
        /// api-version: 2024-03-01.</param>
        public ProxyAgentSettings(bool? enabled = default(bool?), string mode = default(string), int? keyIncarnationId = default(int?), HostEndpointSettings wireServer = default(HostEndpointSettings), HostEndpointSettings imds = default(HostEndpointSettings))
        {
            Enabled = enabled;
            Mode = mode;
            KeyIncarnationId = keyIncarnationId;
            WireServer = wireServer;
            Imds = imds;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies whether ProxyAgent feature should be enabled
        /// on the virtual machine or virtual machine scale set.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or sets specifies the mode that ProxyAgent will execute on.
        /// Warning: this property has been deprecated, please specify 'mode'
        /// under particular hostendpoint setting. Possible values include:
        /// 'Audit', 'Enforce'
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        public string Mode { get; set; }

        /// <summary>
        /// Gets or sets increase the value of this property allows users to
        /// reset the key used for securing communication channel between guest
        /// and host.
        /// </summary>
        [JsonProperty(PropertyName = "keyIncarnationId")]
        public int? KeyIncarnationId { get; set; }

        /// <summary>
        /// Gets or sets specifies the Wire Server endpoint settings while
        /// creating the virtual machine or virtual machine scale set. Minimum
        /// api-version: 2024-03-01.
        /// </summary>
        [JsonProperty(PropertyName = "wireServer")]
        public HostEndpointSettings WireServer { get; set; }

        /// <summary>
        /// Gets or sets specifies the IMDS endpoint settings while creating
        /// the virtual machine or virtual machine scale set. Minimum
        /// api-version: 2024-03-01.
        /// </summary>
        [JsonProperty(PropertyName = "imds")]
        public HostEndpointSettings Imds { get; set; }

    }
}
