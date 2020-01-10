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
    /// Defines RequestStatusNullable
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum RequestStatusNullable
    {
        /// <summary>
        /// Enum Saved for value: Saved
        /// </summary>
        [EnumMember(Value = "Saved")]
        Saved = 1,

        /// <summary>
        /// Enum Submitted for value: Submitted
        /// </summary>
        [EnumMember(Value = "Submitted")]
        Submitted = 2

    }

}
