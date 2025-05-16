---
external help file:
Module Name: Az.ConnectedMachine
online version: https://learn.microsoft.com/powershell/module/az.connectedmachine/get-azconnectedextensionmetadatav2
schema: 2.0.0
---

# Get-AzConnectedExtensionMetadataV2

## SYNOPSIS
Gets an Extension Metadata based on location, publisher, extensionType and version

## SYNTAX

### List (Default)
```
Get-AzConnectedExtensionMetadataV2 -ExtensionType <String> -Location <String> -Publisher <String>
 [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### Get
```
Get-AzConnectedExtensionMetadataV2 -ExtensionType <String> -Location <String> -Publisher <String>
 -Version <String> [-DefaultProfile <PSObject>] [<CommonParameters>]
```

## DESCRIPTION
Gets an Extension Metadata based on location, publisher, extensionType and version

## EXAMPLES

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

## PARAMETERS

### -DefaultProfile
The DefaultProfile parameter is not functional.
Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.

```yaml
Type: System.Management.Automation.PSObject
Parameter Sets: (All)
Aliases: AzureRMContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExtensionType
The extensionType of the Extension being received.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Location
The name of Azure region.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Publisher
The publisher of the Extension being received.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Version
The version of the Extension being received.

```yaml
Type: System.String
Parameter Sets: Get
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IExtensionValueV2

## NOTES

## RELATED LINKS

