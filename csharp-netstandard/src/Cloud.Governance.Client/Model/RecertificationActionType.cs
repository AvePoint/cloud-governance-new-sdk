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
    /// None&#x3D;0, GroupMembership&#x3D;1, GroupPermission&#x3D;2, &lt;/br&gt;UserPermission&#x3D;4
    /// </summary>
    /// <value>None&#x3D;0, GroupMembership&#x3D;1, GroupPermission&#x3D;2, &lt;/br&gt;UserPermission&#x3D;4</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum RecertificationActionType
    {
        /// <summary>
        /// Enum None for value: None
        /// </summary>
        [EnumMember(Value = "None")]
        None = 0,

        /// <summary>
        /// Enum GroupMembership for value: GroupMembership
        /// </summary>
        [EnumMember(Value = "GroupMembership")]
        GroupMembership = 1,

        /// <summary>
        /// Enum GroupPermission for value: GroupPermission
        /// </summary>
        [EnumMember(Value = "GroupPermission")]
        GroupPermission = 2,

        /// <summary>
        /// Enum UserPermission for value: UserPermission
        /// </summary>
        [EnumMember(Value = "UserPermission")]
        UserPermission = 4,

    }

}
