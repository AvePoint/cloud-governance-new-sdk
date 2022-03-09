# WorkspaceSendCancelEmailParameter
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsSendCancelEmail** | **Boolean** |  | [optional] [default to $false]
**CancelEmailTemplateId** | **String** |  | [optional] 
**Workspace** | [**WorkspaceIdTypeModel[]**](WorkspaceIdTypeModel.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$WorkspaceSendCancelEmailParameter = New-Cloud.Governance.ClientWorkspaceSendCancelEmailParameter  -IsSendCancelEmail null `
 -CancelEmailTemplateId null `
 -Workspace null
```

- Convert the resource to JSON
```powershell
$WorkspaceSendCancelEmailParameter | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
