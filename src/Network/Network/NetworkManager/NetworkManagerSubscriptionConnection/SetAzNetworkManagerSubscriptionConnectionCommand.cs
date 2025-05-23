﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using AutoMapper;
using Microsoft.Azure.Commands.Network.Models;
using Microsoft.Azure.Commands.Network.Models.NetworkManager;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Commands.ResourceManager.Common.Tags;
using Microsoft.Azure.Management.Network;
using System;
using System.Management.Automation;
using MNM = Microsoft.Azure.Management.Network.Models;

namespace Microsoft.Azure.Commands.Network
{
    [Cmdlet("Set", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "NetworkManagerSubscriptionConnection", SupportsShouldProcess = true), OutputType(typeof(PSNetworkManagerConnection))]
    public class SetAzNetworkManagerSubscriptionConnection : NetworkManagerSubscriptionConnectionBaseCmdlet
    {
        [Parameter(
            Mandatory = true,
            ValueFromPipeline = true,
            HelpMessage = "The NetworkManagerSubscriptionConnection")]
        public PSNetworkManagerConnection InputObject { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "Run cmdlet in the background")]
        public SwitchParameter AsJob { get; set; }

        public override void Execute()
        {
            if (this.ShouldProcess(InputObject.Name, VerbsLifecycle.Restart))
            {
                base.Execute();

                if (!this.IsNetworkManagerSubscriptionConnectionPresent(this.InputObject.Name))
                {
                    throw new ArgumentException(string.Format(Microsoft.Azure.Commands.Network.Properties.Resources.ResourceNotFound, this.InputObject.Name));
                }

                // Map to the sdk object
                var networkManagerSubscriptionConnectionModel = NetworkResourceManagerProfile.Mapper.Map<MNM.NetworkManagerConnection>(this.InputObject);

                // Execute the PUT NetworkManagerSubscriptionConnection call
                this.NetworkManagerSubscriptionConnectionClient.CreateOrUpdate(this.InputObject.Name, networkManagerSubscriptionConnectionModel);
                var psNetworkManagerConnection = this.GetNetworkManagerSubscriptionConnection(this.InputObject.Name);
                WriteObject(psNetworkManagerConnection);
            }
        }
    }
}
