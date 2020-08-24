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
    /// Site&#x3D;0, Web&#x3D;1
    /// </summary>
    /// <value>Site&#x3D;0, Web&#x3D;1</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum MySiteType
    {
        /// <summary>
        /// Enum Site for value: Site
        /// </summary>
        [EnumMember(Value = "Site")]
        Site = 0,

        /// <summary>
        /// Enum Web for value: Web
        /// </summary>
        [EnumMember(Value = "Web")]
        Web = 1,

    }

}
