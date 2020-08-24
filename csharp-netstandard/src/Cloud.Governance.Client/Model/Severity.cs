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
    /// Trivial&#x3D;1, Minor&#x3D;2, Normal&#x3D;3, &lt;/br&gt;Major&#x3D;4, Critical&#x3D;5
    /// </summary>
    /// <value>Trivial&#x3D;1, Minor&#x3D;2, Normal&#x3D;3, &lt;/br&gt;Major&#x3D;4, Critical&#x3D;5</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum Severity
    {
        /// <summary>
        /// Enum Trivial for value: Trivial
        /// </summary>
        [EnumMember(Value = "Trivial")]
        Trivial = 1,

        /// <summary>
        /// Enum Minor for value: Minor
        /// </summary>
        [EnumMember(Value = "Minor")]
        Minor = 2,

        /// <summary>
        /// Enum Normal for value: Normal
        /// </summary>
        [EnumMember(Value = "Normal")]
        Normal = 3,

        /// <summary>
        /// Enum Major for value: Major
        /// </summary>
        [EnumMember(Value = "Major")]
        Major = 4,

        /// <summary>
        /// Enum Critical for value: Critical
        /// </summary>
        [EnumMember(Value = "Critical")]
        Critical = 5,

    }

}
