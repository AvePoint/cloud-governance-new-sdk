# ChangeSiteSettingValidateResult
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SiteUrl** | **String** |  | [optional] 
**SiteId** | **String** |  | [optional] 
**SiteTitle** | **String** |  | [optional] 
**SiteDescription** | **String** |  | [optional] 
**IsEnableChangeHubSite** | **Boolean** |  | [optional] 
**IsModernSite** | **Boolean** |  | [optional] 
**IsHubSite** | **Boolean** |  | [optional] 
**AssociatedHubSiteId** | **String** |  | [optional] 
**Metadatas** | [**CustomMetadata[]**](CustomMetadata.md) |  | [optional] 
**PrimaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] 
**SecondaryContact** | [**ApiUser**](ApiUser.md) |  | [optional] 
**PrimaryAdministrator** | [**ApiUser**](ApiUser.md) |  | [optional] 
**IsValid** | **Boolean** |  | [optional] 
**ErrorMessage** | **String** |  | [optional] 
**MessageCode** | [**MessageCode**](MessageCode.md) |  | [optional] 

## Examples

- Prepare the resource
```powershell
$ChangeSiteSettingValidateResult = New-Cloud.Governance.ClientChangeSiteSettingValidateResult  -SiteUrl null `
 -SiteId null `
 -SiteTitle null `
 -SiteDescription null `
 -IsEnableChangeHubSite null `
 -IsModernSite null `
 -IsHubSite null `
 -AssociatedHubSiteId null `
 -Metadatas null `
 -PrimaryContact null `
 -SecondaryContact null `
 -PrimaryAdministrator null `
 -IsValid null `
 -ErrorMessage null `
 -MessageCode null
```

- Convert the resource to JSON
```powershell
$ChangeSiteSettingValidateResult | ConvertTo-JSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
