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
    /// Moderate&#x3D;0, Strict&#x3D;1
    /// </summary>
    /// <value>Moderate&#x3D;0, Strict&#x3D;1</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum GiphyRatingType
    {
        /// <summary>
        /// Enum Moderate for value: Moderate
        /// </summary>
        [EnumMember(Value = "Moderate")]
        Moderate = 0,

        /// <summary>
        /// Enum Strict for value: Strict
        /// </summary>
        [EnumMember(Value = "Strict")]
        Strict = 1,

    }

}
