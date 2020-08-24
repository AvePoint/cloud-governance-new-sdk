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
    /// Add&#x3D;1, Update&#x3D;2, Delete&#x3D;3, &lt;/br&gt;Login&#x3D;4, Logout&#x3D;5, Activate&#x3D;7, &lt;/br&gt;Deactivate&#x3D;8, Cancel&#x3D;9, Submit&#x3D;10, &lt;/br&gt;Approve&#x3D;11, Reject&#x3D;12, Import&#x3D;13, &lt;/br&gt;Export&#x3D;14, ContinueAccess&#x3D;15, Extend&#x3D;16, &lt;/br&gt;Archive&#x3D;17, Completed&#x3D;18, Apply&#x3D;19, &lt;/br&gt;ChangePolicy&#x3D;20, Remove&#x3D;21, Retried&#x3D;22, &lt;/br&gt;Skipped&#x3D;23, Reassigned&#x3D;24, Claim&#x3D;25, &lt;/br&gt;Decline&#x3D;26, SpecifyContact&#x3D;27, Send&#x3D;28, &lt;/br&gt;
    /// </summary>
    /// <value>Add&#x3D;1, Update&#x3D;2, Delete&#x3D;3, &lt;/br&gt;Login&#x3D;4, Logout&#x3D;5, Activate&#x3D;7, &lt;/br&gt;Deactivate&#x3D;8, Cancel&#x3D;9, Submit&#x3D;10, &lt;/br&gt;Approve&#x3D;11, Reject&#x3D;12, Import&#x3D;13, &lt;/br&gt;Export&#x3D;14, ContinueAccess&#x3D;15, Extend&#x3D;16, &lt;/br&gt;Archive&#x3D;17, Completed&#x3D;18, Apply&#x3D;19, &lt;/br&gt;ChangePolicy&#x3D;20, Remove&#x3D;21, Retried&#x3D;22, &lt;/br&gt;Skipped&#x3D;23, Reassigned&#x3D;24, Claim&#x3D;25, &lt;/br&gt;Decline&#x3D;26, SpecifyContact&#x3D;27, Send&#x3D;28, &lt;/br&gt;</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum EventAction
    {
        /// <summary>
        /// Enum Add for value: Add
        /// </summary>
        [EnumMember(Value = "Add")]
        Add = 1,

        /// <summary>
        /// Enum Update for value: Update
        /// </summary>
        [EnumMember(Value = "Update")]
        Update = 2,

        /// <summary>
        /// Enum Delete for value: Delete
        /// </summary>
        [EnumMember(Value = "Delete")]
        Delete = 3,

        /// <summary>
        /// Enum Login for value: Login
        /// </summary>
        [EnumMember(Value = "Login")]
        Login = 4,

        /// <summary>
        /// Enum Logout for value: Logout
        /// </summary>
        [EnumMember(Value = "Logout")]
        Logout = 5,

        /// <summary>
        /// Enum Activate for value: Activate
        /// </summary>
        [EnumMember(Value = "Activate")]
        Activate = 7,

        /// <summary>
        /// Enum Deactivate for value: Deactivate
        /// </summary>
        [EnumMember(Value = "Deactivate")]
        Deactivate = 8,

        /// <summary>
        /// Enum Cancel for value: Cancel
        /// </summary>
        [EnumMember(Value = "Cancel")]
        Cancel = 9,

        /// <summary>
        /// Enum Submit for value: Submit
        /// </summary>
        [EnumMember(Value = "Submit")]
        Submit = 10,

        /// <summary>
        /// Enum Approve for value: Approve
        /// </summary>
        [EnumMember(Value = "Approve")]
        Approve = 11,

        /// <summary>
        /// Enum Reject for value: Reject
        /// </summary>
        [EnumMember(Value = "Reject")]
        Reject = 12,

        /// <summary>
        /// Enum Import for value: Import
        /// </summary>
        [EnumMember(Value = "Import")]
        Import = 13,

        /// <summary>
        /// Enum Export for value: Export
        /// </summary>
        [EnumMember(Value = "Export")]
        Export = 14,

        /// <summary>
        /// Enum ContinueAccess for value: ContinueAccess
        /// </summary>
        [EnumMember(Value = "ContinueAccess")]
        ContinueAccess = 15,

        /// <summary>
        /// Enum Extend for value: Extend
        /// </summary>
        [EnumMember(Value = "Extend")]
        Extend = 16,

        /// <summary>
        /// Enum Archive for value: Archive
        /// </summary>
        [EnumMember(Value = "Archive")]
        Archive = 17,

        /// <summary>
        /// Enum Completed for value: Completed
        /// </summary>
        [EnumMember(Value = "Completed")]
        Completed = 18,

        /// <summary>
        /// Enum Apply for value: Apply
        /// </summary>
        [EnumMember(Value = "Apply")]
        Apply = 19,

        /// <summary>
        /// Enum ChangePolicy for value: ChangePolicy
        /// </summary>
        [EnumMember(Value = "ChangePolicy")]
        ChangePolicy = 20,

        /// <summary>
        /// Enum Remove for value: Remove
        /// </summary>
        [EnumMember(Value = "Remove")]
        Remove = 21,

        /// <summary>
        /// Enum Retried for value: Retried
        /// </summary>
        [EnumMember(Value = "Retried")]
        Retried = 22,

        /// <summary>
        /// Enum Skipped for value: Skipped
        /// </summary>
        [EnumMember(Value = "Skipped")]
        Skipped = 23,

        /// <summary>
        /// Enum Reassigned for value: Reassigned
        /// </summary>
        [EnumMember(Value = "Reassigned")]
        Reassigned = 24,

        /// <summary>
        /// Enum Claim for value: Claim
        /// </summary>
        [EnumMember(Value = "Claim")]
        Claim = 25,

        /// <summary>
        /// Enum Decline for value: Decline
        /// </summary>
        [EnumMember(Value = "Decline")]
        Decline = 26,

        /// <summary>
        /// Enum SpecifyContact for value: SpecifyContact
        /// </summary>
        [EnumMember(Value = "SpecifyContact")]
        SpecifyContact = 27,

        /// <summary>
        /// Enum Send for value: Send
        /// </summary>
        [EnumMember(Value = "Send")]
        Send = 28,

    }

}
