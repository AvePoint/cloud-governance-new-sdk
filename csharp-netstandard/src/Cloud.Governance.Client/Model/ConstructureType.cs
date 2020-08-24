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
    /// Text&#x3D;0, Metadata&#x3D;1, Attribute&#x3D;2, &lt;/br&gt;
    /// </summary>
    /// <value>Text&#x3D;0, Metadata&#x3D;1, Attribute&#x3D;2, &lt;/br&gt;</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ConstructureType
    {
        /// <summary>
        /// Enum Text for value: Text
        /// </summary>
        [EnumMember(Value = "Text")]
        Text = 0,

        /// <summary>
        /// Enum Metadata for value: Metadata
        /// </summary>
        [EnumMember(Value = "Metadata")]
        Metadata = 1,

        /// <summary>
        /// Enum Attribute for value: Attribute
        /// </summary>
        [EnumMember(Value = "Attribute")]
        Attribute = 2,

    }

}
