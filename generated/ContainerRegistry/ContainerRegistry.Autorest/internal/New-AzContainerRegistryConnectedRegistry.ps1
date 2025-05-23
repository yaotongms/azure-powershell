
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Creates a connected registry for a container registry with the specified parameters.
.Description
Creates a connected registry for a container registry with the specified parameters.
.Example
{{ Add code here }}
.Example
{{ Add code here }}

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IConnectedRegistry
.Link
https://learn.microsoft.com/powershell/module/az.containerregistry/new-azcontainerregistryconnectedregistry
#>
function New-AzContainerRegistryConnectedRegistry {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IConnectedRegistry])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Alias('ConnectedRegistryName')]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Category('Path')]
    [System.String]
    # The name of the connected registry.
    ${Name},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Category('Path')]
    [System.String]
    # The name of the container registry.
    ${RegistryName},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    # The value must be an UUID.
    ${SubscriptionId},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Category('Body')]
    [System.String[]]
    # The list of the ACR token resource IDs used to authenticate clients to the connected registry.
    ${ClientTokenId},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.AuditLogStatus])]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.AuditLogStatus]
    # Indicates whether audit logs are enabled on the connected registry.
    ${LoggingAuditLogStatus},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.LogLevel])]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.LogLevel]
    # The verbosity of logs persisted on the connected registry.
    ${LoggingLogLevel},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.ConnectedRegistryMode])]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.ConnectedRegistryMode]
    # The mode of the connected registry resource that indicates the permissions of the registry.
    ${Mode},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Category('Body')]
    [System.String[]]
    # The list of notifications subscription information for the connected registry.
    ${NotificationsList},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Category('Body')]
    [System.String]
    # The resource ID of the parent to which the connected registry will be associated.
    ${ParentId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Category('Body')]
    [System.TimeSpan]
    # The period of time for which a message is available to sync before it is expired.
    # Specify the duration using the format P[n]Y[n]M[n]DT[n]H[n]M[n]S as per ISO8601.
    ${SyncPropertyMessageTtl},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Category('Body')]
    [System.String]
    # The cron expression indicating the schedule that the connected registry will sync with its parent.
    ${SyncPropertySchedule},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Category('Body')]
    [System.TimeSpan]
    # The time window during which sync is enabled for each schedule occurrence.
    # Specify the duration using the format P[n]Y[n]M[n]DT[n]H[n]M[n]S as per ISO8601.
    ${SyncPropertySyncWindow},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Category('Body')]
    [System.String]
    # The resource ID of the ACR token used to authenticate the connected registry to its parent during sync.
    ${SyncPropertyTokenId},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The DefaultProfile parameter is not functional.
    # Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName

        $mapping = @{
            CreateExpanded = 'Az.ContainerRegistry.private\New-AzContainerRegistryConnectedRegistry_CreateExpanded';
        }
        if (('CreateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $testPlayback = $false
            $PSBoundParameters['HttpPipelinePrepend'] | Foreach-Object { if ($_) { $testPlayback = $testPlayback -or ('Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.PipelineMock' -eq $_.Target.GetType().FullName -and 'Playback' -eq $_.Target.Mode) } }
            if ($testPlayback) {
                $PSBoundParameters['SubscriptionId'] = . (Join-Path $PSScriptRoot '..' 'utils' 'Get-SubscriptionIdTestSafe.ps1')
            } else {
                $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
            }
        }

        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {

        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {

        throw
    }

}
end {
    try {
        $steppablePipeline.End()

    } catch {

        throw
    }
} 
}
