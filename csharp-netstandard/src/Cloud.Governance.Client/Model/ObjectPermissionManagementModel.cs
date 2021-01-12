

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Cloud.Governance.Client.Client.OpenAPIDateConverter;

namespace Cloud.Governance.Client.Model
{
    /// <summary>
    /// ObjectPermissionManagementModel
    /// </summary>
    [DataContract(Name = "ObjectPermissionManagementModel")]
    public partial class ObjectPermissionManagementModel : IEquatable<ObjectPermissionManagementModel>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ObjectType
        /// </summary>
        [DataMember(Name = "objectType", EmitDefaultValue = false)]
        public SPPrincipalType? ObjectType { get; set; }
        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name = "action", EmitDefaultValue = false)]
        public ManagePermissionAction? Action { get; set; }
        /// <summary>
        /// Gets or Sets ExternalUserType
        /// </summary>
        [DataMember(Name = "externalUserType", EmitDefaultValue = false)]
        public ExternalUserType? ExternalUserType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectPermissionManagementModel" /> class.
        /// </summary>
        /// <param name="objectType">objectType.</param>
        /// <param name="objectInfo">objectInfo.</param>
        /// <param name="action">action.</param>
        /// <param name="permissions">permissions.</param>
        /// <param name="originalPermissions">originalPermissions.</param>
        /// <param name="externalUserType">externalUserType.</param>
        /// <param name="members">members.</param>
        /// <param name="grantPermissionSetting">grantPermissionSetting.</param>
        /// <param name="originalName">originalName.</param>
        public ObjectPermissionManagementModel(SPPrincipalType? objectType = default(SPPrincipalType?), ApiUser objectInfo = default(ApiUser), ManagePermissionAction? action = default(ManagePermissionAction?), List<string> permissions = default(List<string>), List<string> originalPermissions = default(List<string>), ExternalUserType? externalUserType = default(ExternalUserType?), List<SharingEnabledUser> members = default(List<SharingEnabledUser>), GrantPermissionModel grantPermissionSetting = default(GrantPermissionModel), string originalName = default(string))
        {
            this.ObjectType = objectType;
            this.ObjectInfo = objectInfo;
            this.Action = action;
            this.Permissions = permissions;
            this.OriginalPermissions = originalPermissions;
            this.ExternalUserType = externalUserType;
            this.Members = members;
            this.GrantPermissionSetting = grantPermissionSetting;
            this.OriginalName = originalName;
        }

        /// <summary>
        /// Gets or Sets ObjectInfo
        /// </summary>
        [DataMember(Name = "objectInfo", EmitDefaultValue = true)]
        public ApiUser ObjectInfo { get; set; }

        /// <summary>
        /// Gets or Sets Permissions
        /// </summary>
        [DataMember(Name = "permissions", EmitDefaultValue = true)]
        public List<string> Permissions { get; set; }

        /// <summary>
        /// Gets or Sets OriginalPermissions
        /// </summary>
        [DataMember(Name = "originalPermissions", EmitDefaultValue = true)]
        public List<string> OriginalPermissions { get; set; }

        /// <summary>
        /// Gets or Sets Members
        /// </summary>
        [DataMember(Name = "members", EmitDefaultValue = true)]
        public List<SharingEnabledUser> Members { get; set; }

        /// <summary>
        /// Gets or Sets GrantPermissionSetting
        /// </summary>
        [DataMember(Name = "grantPermissionSetting", EmitDefaultValue = true)]
        public GrantPermissionModel GrantPermissionSetting { get; set; }

        /// <summary>
        /// Gets or Sets OriginalName
        /// </summary>
        [DataMember(Name = "originalName", EmitDefaultValue = true)]
        public string OriginalName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ObjectPermissionManagementModel {\n");
            sb.Append("  ObjectType: ").Append(ObjectType).Append("\n");
            sb.Append("  ObjectInfo: ").Append(ObjectInfo).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
            sb.Append("  OriginalPermissions: ").Append(OriginalPermissions).Append("\n");
            sb.Append("  ExternalUserType: ").Append(ExternalUserType).Append("\n");
            sb.Append("  Members: ").Append(Members).Append("\n");
            sb.Append("  GrantPermissionSetting: ").Append(GrantPermissionSetting).Append("\n");
            sb.Append("  OriginalName: ").Append(OriginalName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ObjectPermissionManagementModel);
        }

        /// <summary>
        /// Returns true if ObjectPermissionManagementModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ObjectPermissionManagementModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ObjectPermissionManagementModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ObjectType == input.ObjectType ||
                    this.ObjectType.Equals(input.ObjectType)
                ) && 
                (
                    this.ObjectInfo == input.ObjectInfo ||
                    (this.ObjectInfo != null &&
                    this.ObjectInfo.Equals(input.ObjectInfo))
                ) && 
                (
                    this.Action == input.Action ||
                    this.Action.Equals(input.Action)
                ) && 
                (
                    this.Permissions == input.Permissions ||
                    this.Permissions != null &&
                    input.Permissions != null &&
                    this.Permissions.SequenceEqual(input.Permissions)
                ) && 
                (
                    this.OriginalPermissions == input.OriginalPermissions ||
                    this.OriginalPermissions != null &&
                    input.OriginalPermissions != null &&
                    this.OriginalPermissions.SequenceEqual(input.OriginalPermissions)
                ) && 
                (
                    this.ExternalUserType == input.ExternalUserType ||
                    this.ExternalUserType.Equals(input.ExternalUserType)
                ) && 
                (
                    this.Members == input.Members ||
                    this.Members != null &&
                    input.Members != null &&
                    this.Members.SequenceEqual(input.Members)
                ) && 
                (
                    this.GrantPermissionSetting == input.GrantPermissionSetting ||
                    (this.GrantPermissionSetting != null &&
                    this.GrantPermissionSetting.Equals(input.GrantPermissionSetting))
                ) && 
                (
                    this.OriginalName == input.OriginalName ||
                    (this.OriginalName != null &&
                    this.OriginalName.Equals(input.OriginalName))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = hashCode * 59 + this.ObjectType.GetHashCode();
                if (this.ObjectInfo != null)
                    hashCode = hashCode * 59 + this.ObjectInfo.GetHashCode();
                hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.Permissions != null)
                    hashCode = hashCode * 59 + this.Permissions.GetHashCode();
                if (this.OriginalPermissions != null)
                    hashCode = hashCode * 59 + this.OriginalPermissions.GetHashCode();
                hashCode = hashCode * 59 + this.ExternalUserType.GetHashCode();
                if (this.Members != null)
                    hashCode = hashCode * 59 + this.Members.GetHashCode();
                if (this.GrantPermissionSetting != null)
                    hashCode = hashCode * 59 + this.GrantPermissionSetting.GetHashCode();
                if (this.OriginalName != null)
                    hashCode = hashCode * 59 + this.OriginalName.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
