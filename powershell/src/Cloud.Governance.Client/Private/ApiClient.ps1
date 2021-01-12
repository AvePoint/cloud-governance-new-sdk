#
# Cloud Governance Api
# Contact: support@avepoint.com
#

function Invoke-ApiClient {
    [OutputType('System.Collections.Hashtable')]
    [CmdletBinding()]
    Param(
        [Parameter(Mandatory)]
        [string]$Uri,
        [Parameter(Mandatory)]
        [AllowEmptyCollection()]
        [string[]]$Accepts,
        [Parameter(Mandatory)]
        [AllowEmptyCollection()]
        [string[]]$ContentTypes,
        [Parameter(Mandatory)]
        [hashtable]$HeaderParameters,
        [Parameter(Mandatory)]
        [hashtable]$FormParameters,
        [Parameter(Mandatory)]
        [hashtable]$QueryParameters,
        [Parameter(Mandatory)]
        [hashtable]$CookieParameters,
        [Parameter(Mandatory)]
        [AllowEmptyString()]
        [string]$Body,
        [Parameter(Mandatory)]
        [string]$Method,
        [Parameter(Mandatory)]
        [AllowEmptyString()]
        [string]$ReturnType,
        [Parameter(Mandatory)]
        [bool]$IsBodyNullable
    )

    'Calling method: Invoke-ApiClient' | Write-Debug
    $PSBoundParameters | Out-DebugParameter | Write-Debug

    $Configuration = Get-Configuration
    $RequestUri = $Configuration["BaseUrl"] + $Uri
    $SkipCertificateCheck = $Configuration["SkipCertificateCheck"]

    # cookie parameters
    foreach ($Parameter in $CookieParameters.GetEnumerator()) {
        if ($Parameter.Name -eq "cookieAuth") {
            $HeaderParameters["Cookie"] = $Parameter.Value
        } else {
            $HeaderParameters[$Parameter.Name] = $Parameter.Value
        }
    }
    if ($CookieParameters -and $CookieParameters.Count -gt 1) {
        Write-Warning "Multipe cookie parameters found. Curently only the first one is supported/used"
    }

    # accept, content-type headers
    $Accept = SelectHeaders -Headers $Accepts
    if ($Accept) {
        $HeaderParameters['Accept'] = $Accept
    }
    $HeaderParameters["Accept-Encoding"]="gzip, deflate"
    $HeaderParameters["X-CLOUD-GOVERNANCE-JSONCONTRACT"]="PascalCase"
    $HeaderParameters["User-Agent"]="(sdk/powershell/4.1.10)"
    $ContentType= SelectHeaders -Headers $ContentTypes
    if ($ContentType) {
        $HeaderParameters['Content-Type'] = $ContentType
    }

    # add default headers if any
    foreach ($header in $Configuration["DefaultHeaders"].GetEnumerator()) {
        $HeaderParameters[$header.Name] = $header.Value
    }


    # constrcut URL query string
    $HttpValues = [System.Web.HttpUtility]::ParseQueryString([String]::Empty)
    foreach ($Parameter in $QueryParameters.GetEnumerator()) {
        if ($Parameter.Value.Count -gt 1) { // array
            foreach ($Value in $Parameter.Value) {
                $HttpValues.Add($Parameter.Key + '[]', $Value)
            }
        } else {
            $HttpValues.Add($Parameter.Key,$Parameter.Value)
        }
    }
    # Build the request and load it with the query string.
    $UriBuilder = [System.UriBuilder]($RequestUri)
    $UriBuilder.Query = $HttpValues.ToString()

    # include form parameters in the request body
    if ($FormParameters -and $FormParameters.Count -gt 0) {
        $RequestBody = $FormParameters
    }

    if ($Body -or $IsBodyNullable) {
        $RequestBody = $Body
        if ([string]::IsNullOrEmpty($RequestBody) -and $IsBodyNullable -eq $true) {
            $RequestBody = "null"
        }
    }

    if ($SkipCertificateCheck -eq $true) {
        if ($Configuration["Proxy"] -eq $null) {
            # skip certification check, no proxy
            $Response = Invoke-WebRequest -Uri $UriBuilder.Uri `
                                      -Method $Method `
                                      -Headers $HeaderParameters `
                                      -Body $RequestBody `
                                      -ErrorAction Stop `
                                      -UseBasicParsing `
                                      -SkipCertificateCheck
        } else {
            # skip certification check, use proxy
            $Response = Invoke-WebRequest -Uri $UriBuilder.Uri `
                                      -Method $Method `
                                      -Headers $HeaderParameters `
                                      -Body $RequestBody `
                                      -ErrorAction Stop `
                                      -UseBasicParsing `
                                      -SkipCertificateCheck `
                                      -Proxy $Configuration["Proxy"].GetProxy($UriBuilder.Uri) `
                                      -ProxyUseDefaultCredentials
        }
    } else {
        if ($Configuration["Proxy"] -eq $null) {
            # perform certification check, no proxy
            $Response = Invoke-WebRequest -Uri $UriBuilder.Uri `
                                      -Method $Method `
                                      -Headers $HeaderParameters `
                                      -Body $RequestBody `
                                      -ErrorAction Stop `
                                      -UseBasicParsing
        } else {
            # perform certification check, use proxy
            $Response = Invoke-WebRequest -Uri $UriBuilder.Uri `
                                      -Method $Method `
                                      -Headers $HeaderParameters `
                                      -Body $RequestBody `
                                      -ErrorAction Stop `
                                      -UseBasicParsing `
                                      -Proxy $Configuration["Proxy"].GetProxy($UriBuilder.Uri) `
                                      -ProxyUseDefaultCredentials
        }
    }

    return @{
        Response = DeserializeResponse -Response $Response -ReturnType $ReturnType -ContentTypes $Response.Headers["Content-Type"]
        StatusCode = $Response.StatusCode
        Headers = $Response.Headers
    }
}

# Select JSON MIME if present, otherwise choose the first one if available
function SelectHeaders {
    Param(
        [Parameter(Mandatory)]
        [AllowEmptyCollection()]
        [String[]]$Headers
    )

    foreach ($Header in $Headers) {
        if (IsJsonMIME -MIME $Header) {
            return $Header
        }
    }

    if (!($Headers) -or $Headers.Count -eq 0) {
        return $null
    } else {
        return $Headers[0] # return the first one
    }
}

function IsJsonMIME {
    Param(
        [Parameter(Mandatory)]
        [string]$MIME
    )

    if ($MIME -match "(?i)^(application/json|[^;/ \t]+/[^;/ \t]+[+]json)[ \t]*(;.*)?$") {
        return $true
    } else {
        return $false
    }
}

function DeserializeResponse {
    Param(
        [Parameter(Mandatory)]
        [AllowEmptyString()]
        [string]$ReturnType,
        [Parameter(Mandatory)]
        [AllowEmptyString()]
        [string]$Response,
        [Parameter(Mandatory)]
        [AllowEmptyCollection()]
        [string[]]$ContentTypes
    )

    If ([string]::IsNullOrEmpty($ReturnType) -and $ContentTypes.Count -eq 0) { # void response
        return $Response
    } Elseif ($ReturnType -match '\[\]$') { # array
        return ConvertFrom-Json $Response
    } Elseif (@("String", "Boolean", "System.DateTime") -contains $ReturnType) { # string, boolean ,datetime
        return $Response
    } Else { # others (e.g. model, file)
        if ($ContentTypes) {
            $ContentType = $null
            if ($ContentTypes.Count -gt 1) {
                $ContentType = SelectHeaders -Headers $ContentTypes
            } else {
                $ContentType = $ContentTypes[0]
            }

            if (IsJsonMIME -MIME $ContentType) { # JSON
                return ConvertFrom-Json $Response
            } else { # XML, file, etc
                return $Response
            }
        } else { # no content type in response header, returning raw response
            return $Response
        }
    }
}
