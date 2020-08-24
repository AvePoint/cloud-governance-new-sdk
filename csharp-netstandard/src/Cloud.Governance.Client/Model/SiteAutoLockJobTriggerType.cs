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
    /// AutomaticLock&#x3D;0, AutomaticLockReminder&#x3D;1, AdditionalAction&#x3D;2, &lt;/br&gt;AdditionalActionWarningReminder&#x3D;3
    /// </summary>
    /// <value>AutomaticLock&#x3D;0, AutomaticLockReminder&#x3D;1, AdditionalAction&#x3D;2, &lt;/br&gt;AdditionalActionWarningReminder&#x3D;3</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum SiteAutoLockJobTriggerType
    {
        /// <summary>
        /// Enum AutomaticLock for value: AutomaticLock
        /// </summary>
        [EnumMember(Value = "AutomaticLock")]
        AutomaticLock = 0,

        /// <summary>
        /// Enum AutomaticLockReminder for value: AutomaticLockReminder
        /// </summary>
        [EnumMember(Value = "AutomaticLockReminder")]
        AutomaticLockReminder = 1,

        /// <summary>
        /// Enum AdditionalAction for value: AdditionalAction
        /// </summary>
        [EnumMember(Value = "AdditionalAction")]
        AdditionalAction = 2,

        /// <summary>
        /// Enum AdditionalActionWarningReminder for value: AdditionalActionWarningReminder
        /// </summary>
        [EnumMember(Value = "AdditionalActionWarningReminder")]
        AdditionalActionWarningReminder = 3,

    }

}
