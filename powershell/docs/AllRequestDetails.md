# AllRequestDetails
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LastApprovedTime** | **System.DateTime** |  | [optional] 
**CompletedTime** | **System.DateTime** |  | [optional] 
**Id** | **String** |  | [optional] 
**ServiceId** | **String** |  | [optional] 
**ServiceName** | **String** |  | [optional] 
**ServiceType** | [**ServiceType**](ServiceType.md) |  | [optional] 
**ServiceTypeDescription** | **String** |  | [optional] 
**CategoryName** | **String** |  | [optional] 
**ApprovalStageName** | **String** |  | [optional] 
**Participants** | **String** |  | [optional] 
**ParticipantDisplayName** | **String** |  | [optional] 
**TicketNumber** | **Int32** |  | [optional] [default to 0]
**Summary** | **String** |  | [optional] 
**Requester** | **String** |  | [optional] 
**RequesterDisplayName** | **String** |  | [optional] 
**DetailStatus** | [**RequestProgressStatus**](RequestProgressStatus.md) |  | [optional] 
**DetailStatusDescription** | **String** |  | [optional] 
**ProgressStatus** | [**ApiRequestProgressStatus**](ApiRequestProgressStatus.md) |  | [optional] 
**ProgressStatusDescription** | **String** |  | [optional] 
**Modified** | **System.DateTime** |  | [optional] 
**AssignTo** | **String** |  | [optional] 
**AssignToDisplayName** | **String** |  | [optional] 
**ServiceAdmin** | **String** |  | [optional] 
**ServiceAdminDisplayName** | **String** |  | [optional] 
**ObjectUrl** | **String** |  | [optional] 
**ObjectID** | **String** |  | [optional] 
**CreatedTime** | **String** |  | [optional] 
**HasSubRequest** | **Boolean** |  | [optional] [default to $false]

## Examples

- Prepare the resource
```powershell
$AllRequestDetails = New-Cloud.Governance.ClientAllRequestDetails  -LastApprovedTime null `
 -CompletedTime null `
 -Id null `
 -ServiceId null `
 -ServiceName null `
 -ServiceType null `
 -ServiceTypeDescription null `
 -CategoryName null `
 -ApprovalStageName null `
 -Participants null `
 -ParticipantDisplayName null `
 -TicketNumber null `
 -Summary null `
 -Requester null `
 -RequesterDisplayName null `
 -DetailStatus null `
 -DetailStatusDescription null `
 -ProgressStatus null `
 -ProgressStatusDescription null `
 -Modified null `
 -AssignTo null `
 -AssignToDisplayName null `
 -ServiceAdmin null `
 -ServiceAdminDisplayName null `
 -ObjectUrl null `
 -ObjectID null `
 -CreatedTime null `
 -HasSubRequest null
```

- Convert the resource to JSON
```powershell
$AllRequestDetails | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
