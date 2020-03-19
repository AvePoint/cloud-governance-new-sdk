/* 
 * Cloud Governance Api
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Cloud.Governance.Client.Client.OpenAPIDateConverter;

namespace Cloud.Governance.Client.Model
{
    /// <summary>
    /// PermissionRecertification&#x3D;0, MetadataRecertification&#x3D;1, OwnershipRecertification&#x3D;2, &lt;/br&gt;
    /// </summary>
    /// <value>PermissionRecertification&#x3D;0, MetadataRecertification&#x3D;1, OwnershipRecertification&#x3D;2, &lt;/br&gt;</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum SiteRecertificationType
    {
        /// <summary>
        /// Enum PermissionRecertification for value: PermissionRecertification
        /// </summary>
        [EnumMember(Value = "PermissionRecertification")]
        PermissionRecertification = 1,

        /// <summary>
        /// Enum MetadataRecertification for value: MetadataRecertification
        /// </summary>
        [EnumMember(Value = "MetadataRecertification")]
        MetadataRecertification = 2,

        /// <summary>
        /// Enum OwnershipRecertification for value: OwnershipRecertification
        /// </summary>
        [EnumMember(Value = "OwnershipRecertification")]
        OwnershipRecertification = 3

    }

}