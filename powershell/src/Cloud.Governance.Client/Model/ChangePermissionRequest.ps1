#
# Cloud Governance Api
# Contact: support@avepoint.com
#

<#
ChangePermissionRequest<PSCustomObject>
#>

function New-ChangePermissionRequest {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${ObjectProperty},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${PermissionChangedType},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${IsManagedAllUsers},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${SelectedUsers},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Id},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ServiceId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Department},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Summary},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${NotesToApprovers},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${QuestionnaireId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${Metadatas}
    )

    Process {
        'Creating PSCustomObject: Cloud.Governance.Client => ChangePermissionRequest' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        if (!$Summary -and $Summary.length -gt 255) {
            throw "invalid value for 'Summary', the character length must be smaller than or equal to 255."
        }

        if (!$NotesToApprovers -and $NotesToApprovers.length -gt 1000) {
            throw "invalid value for 'NotesToApprovers', the character length must be smaller than or equal to 1000."
        }

        
        $PSO = [PSCustomObject]@{
            "ObjectProperty" = ${ObjectProperty}
            "PermissionChangedType" = ${PermissionChangedType}
            "IsManagedAllUsers" = ${IsManagedAllUsers}
            "SelectedUsers" = ${SelectedUsers}
            "Id" = ${Id}
            "ServiceId" = ${ServiceId}
            "Department" = ${Department}
            "Summary" = ${Summary}
            "NotesToApprovers" = ${NotesToApprovers}
            "QuestionnaireId" = ${QuestionnaireId}
            "Metadatas" = ${Metadatas}
        }

        return $PSO
    }
}

<#
ChangePermissionRequest<PSCustomObject>
#>
function ConvertFrom-JsonToChangePermissionRequest {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Cloud.Governance.Client => ChangePermissionRequest' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in ChangePermissionRequest
        $AllProperties = $("ObjectProperty", "PermissionChangedType", "IsManagedAllUsers", "SelectedUsers", "Id", "ServiceId", "Department", "Summary", "NotesToApprovers", "QuestionnaireId", "Metadatas", "TicketNumber", "Type", "TypeDescription", "Requester", "RequesterLoginName", "Status", "ProgressStatus", "ProgressStatusDescription", "SubmittedTime", "LastUpdated", "CreatedTime", "AssignTo", "FullPath")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ObjectProperty"))) { #optional property not found
            $ObjectProperty = $null
        } else {
            $ObjectProperty = $JsonParameters.PSobject.Properties["ObjectProperty"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PermissionChangedType"))) { #optional property not found
            $PermissionChangedType = $null
        } else {
            $PermissionChangedType = $JsonParameters.PSobject.Properties["PermissionChangedType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsManagedAllUsers"))) { #optional property not found
            $IsManagedAllUsers = $null
        } else {
            $IsManagedAllUsers = $JsonParameters.PSobject.Properties["IsManagedAllUsers"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SelectedUsers"))) { #optional property not found
            $SelectedUsers = $null
        } else {
            $SelectedUsers = $JsonParameters.PSobject.Properties["SelectedUsers"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Id"))) { #optional property not found
            $Id = $null
        } else {
            $Id = $JsonParameters.PSobject.Properties["Id"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ServiceId"))) { #optional property not found
            $ServiceId = $null
        } else {
            $ServiceId = $JsonParameters.PSobject.Properties["ServiceId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Department"))) { #optional property not found
            $Department = $null
        } else {
            $Department = $JsonParameters.PSobject.Properties["Department"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Summary"))) { #optional property not found
            $Summary = $null
        } else {
            $Summary = $JsonParameters.PSobject.Properties["Summary"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "NotesToApprovers"))) { #optional property not found
            $NotesToApprovers = $null
        } else {
            $NotesToApprovers = $JsonParameters.PSobject.Properties["NotesToApprovers"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "QuestionnaireId"))) { #optional property not found
            $QuestionnaireId = $null
        } else {
            $QuestionnaireId = $JsonParameters.PSobject.Properties["QuestionnaireId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Metadatas"))) { #optional property not found
            $Metadatas = $null
        } else {
            $Metadatas = $JsonParameters.PSobject.Properties["Metadatas"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TicketNumber"))) { #optional property not found
            $TicketNumber = $null
        } else {
            $TicketNumber = $JsonParameters.PSobject.Properties["TicketNumber"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Type"))) { #optional property not found
            $Type = $null
        } else {
            $Type = $JsonParameters.PSobject.Properties["Type"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TypeDescription"))) { #optional property not found
            $TypeDescription = $null
        } else {
            $TypeDescription = $JsonParameters.PSobject.Properties["TypeDescription"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Requester"))) { #optional property not found
            $Requester = $null
        } else {
            $Requester = $JsonParameters.PSobject.Properties["Requester"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "RequesterLoginName"))) { #optional property not found
            $RequesterLoginName = $null
        } else {
            $RequesterLoginName = $JsonParameters.PSobject.Properties["RequesterLoginName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Status"))) { #optional property not found
            $Status = $null
        } else {
            $Status = $JsonParameters.PSobject.Properties["Status"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ProgressStatus"))) { #optional property not found
            $ProgressStatus = $null
        } else {
            $ProgressStatus = $JsonParameters.PSobject.Properties["ProgressStatus"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ProgressStatusDescription"))) { #optional property not found
            $ProgressStatusDescription = $null
        } else {
            $ProgressStatusDescription = $JsonParameters.PSobject.Properties["ProgressStatusDescription"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SubmittedTime"))) { #optional property not found
            $SubmittedTime = $null
        } else {
            $SubmittedTime = $JsonParameters.PSobject.Properties["SubmittedTime"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LastUpdated"))) { #optional property not found
            $LastUpdated = $null
        } else {
            $LastUpdated = $JsonParameters.PSobject.Properties["LastUpdated"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "CreatedTime"))) { #optional property not found
            $CreatedTime = $null
        } else {
            $CreatedTime = $JsonParameters.PSobject.Properties["CreatedTime"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AssignTo"))) { #optional property not found
            $AssignTo = $null
        } else {
            $AssignTo = $JsonParameters.PSobject.Properties["AssignTo"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "FullPath"))) { #optional property not found
            $FullPath = $null
        } else {
            $FullPath = $JsonParameters.PSobject.Properties["FullPath"].value
        }

        $PSO = [PSCustomObject]@{
            "ObjectProperty" = ${ObjectProperty}
            "PermissionChangedType" = ${PermissionChangedType}
            "IsManagedAllUsers" = ${IsManagedAllUsers}
            "SelectedUsers" = ${SelectedUsers}
            "Id" = ${Id}
            "ServiceId" = ${ServiceId}
            "Department" = ${Department}
            "Summary" = ${Summary}
            "NotesToApprovers" = ${NotesToApprovers}
            "QuestionnaireId" = ${QuestionnaireId}
            "Metadatas" = ${Metadatas}
            "TicketNumber" = ${TicketNumber}
            "Type" = ${Type}
            "TypeDescription" = ${TypeDescription}
            "Requester" = ${Requester}
            "RequesterLoginName" = ${RequesterLoginName}
            "Status" = ${Status}
            "ProgressStatus" = ${ProgressStatus}
            "ProgressStatusDescription" = ${ProgressStatusDescription}
            "SubmittedTime" = ${SubmittedTime}
            "LastUpdated" = ${LastUpdated}
            "CreatedTime" = ${CreatedTime}
            "AssignTo" = ${AssignTo}
            "FullPath" = ${FullPath}
        }

        return $PSO
    }

}

