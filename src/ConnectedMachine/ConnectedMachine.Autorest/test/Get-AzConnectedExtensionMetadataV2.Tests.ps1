if(($null -eq $TestName) -or ($TestName -contains 'Get-AzConnectedExtensionMetadataV2'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Get-AzConnectedExtensionMetadataV2.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Get-AzConnectedExtensionMetadataV2' {
    It 'List' {
        $all = @(Get-AzConnectedExtensionMetadata -ExtensionType 'azuremonitorlinuxagent' -Publisher 'microsoft.azure.monitor' -Location $env.Location)
        $all | Should -Not -BeNullOrEmpty
    }

    It 'Get' {
        $all = @(Get-AzConnectedExtensionMetadata -ExtensionType 'azuremonitorlinuxagent' -Publisher 'microsoft.azure.monitor' -Location $env.Location -Version '1.33.0')
        $all | Should -Not -BeNullOrEmpty
    }
}