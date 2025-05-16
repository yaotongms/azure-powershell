### Example 1:  Get extension metadata
```powershell
Get-AzConnectedExtensionMetadata -ExtensionType 'azuremonitorlinuxagent' -Publisher 'microsoft.azure.monitor' -Location eastus -Version '1.33.0'
```

```output
ExtensionType                : azuremonitorlinuxagent
Id                           : /subscriptions/b24cc8ee-df4f-48ac-94cf-46edf36b0fae/providers/Microsoft.HybridCompute/lo
                               cations/eastus/publishers/microsoft.azure.monitor/extensionTypes/azuremonitorlinuxagent/
                               versions/1.33.0
Name                         :
Publisher                    : microsoft.azure.monitor
ResourceGroupName            :
SystemDataCreatedAt          :
SystemDataCreatedBy          :
SystemDataCreatedByType      :
SystemDataLastModifiedAt     :
SystemDataLastModifiedBy     :
SystemDataLastModifiedByType :
Type                         :
Version                      : 1.33.0
```

Get extension metadata