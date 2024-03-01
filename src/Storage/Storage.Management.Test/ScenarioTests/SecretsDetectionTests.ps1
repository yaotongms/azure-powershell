# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.SYNOPSIS
Test secrets detection for storage account key
.DESCRIPTION
Smoke[Broken]Test
#>
function Test-StorageAccountKeyDetection
{
    $rgName = getAssetName

    try
    {
        $loc = "eastus"
        $stoName = "sto" + $rgName
        $stoType = "Standard_LRS"

        New-AzResourceGroup -Name $rgName -Location $loc
        
        New-AzStorageAccount -ResourceGroupName $rgName -Name $stoName -Location $loc -Type $stoType

        Invoke-Command -ScriptBlock { Get-AzStorageAccountKey -ResourceGroupName $rgName -Name $stoName } -WarningVariable warnings
        Assert-Match "The output .* may compromise security by showing the following secrets" $warnings
    }
    finally
    {
        # Cleanup
        Clean-ResourceGroup $rgName
    }
}
