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
    /// None&#x3D;0, Extend&#x3D;1, Delete&#x3D;2, &lt;/br&gt;Archive&#x3D;3, Policy&#x3D;4, Unlock&#x3D;5, &lt;/br&gt;Continue&#x3D;6, Lock&#x3D;7, Quota&#x3D;8, &lt;/br&gt;
    /// </summary>
    /// <value>None&#x3D;0, Extend&#x3D;1, Delete&#x3D;2, &lt;/br&gt;Archive&#x3D;3, Policy&#x3D;4, Unlock&#x3D;5, &lt;/br&gt;Continue&#x3D;6, Lock&#x3D;7, Quota&#x3D;8, &lt;/br&gt;</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum LifecycleAction
    {
        /// <summary>
        /// Enum None for value: None
        /// </summary>
        [EnumMember(Value = "None")]
        None = 0,

        /// <summary>
        /// Enum Extend for value: Extend
        /// </summary>
        [EnumMember(Value = "Extend")]
        Extend = 1,

        /// <summary>
        /// Enum Delete for value: Delete
        /// </summary>
        [EnumMember(Value = "Delete")]
        Delete = 2,

        /// <summary>
        /// Enum Archive for value: Archive
        /// </summary>
        [EnumMember(Value = "Archive")]
        Archive = 3,

        /// <summary>
        /// Enum Policy for value: Policy
        /// </summary>
        [EnumMember(Value = "Policy")]
        Policy = 4,

        /// <summary>
        /// Enum Unlock for value: Unlock
        /// </summary>
        [EnumMember(Value = "Unlock")]
        Unlock = 5,

        /// <summary>
        /// Enum Continue for value: Continue
        /// </summary>
        [EnumMember(Value = "Continue")]
        Continue = 6,

        /// <summary>
        /// Enum Lock for value: Lock
        /// </summary>
        [EnumMember(Value = "Lock")]
        Lock = 7,

        /// <summary>
        /// Enum Quota for value: Quota
        /// </summary>
        [EnumMember(Value = "Quota")]
        Quota = 8,

    }

}
