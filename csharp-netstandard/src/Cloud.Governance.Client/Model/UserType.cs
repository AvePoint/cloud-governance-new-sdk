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
    /// All&#x3D;0, User&#x3D;1, Group&#x3D;2, &lt;/br&gt;DistributionList&#x3D;3, UserAndGroup&#x3D;4
    /// </summary>
    /// <value>All&#x3D;0, User&#x3D;1, Group&#x3D;2, &lt;/br&gt;DistributionList&#x3D;3, UserAndGroup&#x3D;4</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum UserType
    {
        /// <summary>
        /// Enum All for value: All
        /// </summary>
        [EnumMember(Value = "All")]
        All = 0,

        /// <summary>
        /// Enum User for value: User
        /// </summary>
        [EnumMember(Value = "User")]
        User = 1,

        /// <summary>
        /// Enum Group for value: Group
        /// </summary>
        [EnumMember(Value = "Group")]
        Group = 2,

        /// <summary>
        /// Enum DistributionList for value: DistributionList
        /// </summary>
        [EnumMember(Value = "DistributionList")]
        DistributionList = 3,

        /// <summary>
        /// Enum UserAndGroup for value: UserAndGroup
        /// </summary>
        [EnumMember(Value = "UserAndGroup")]
        UserAndGroup = 4,

    }

}
