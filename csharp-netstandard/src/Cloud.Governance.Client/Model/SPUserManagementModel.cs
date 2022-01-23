

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
    /// SPUserManagementModel
    /// </summary>
    [DataContract(Name = "SPUserManagementModel")]
    public partial class SPUserManagementModel : IEquatable<SPUserManagementModel>, IValidatableObject
    {
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
        /// Initializes a new instance of the <see cref="SPUserManagementModel" /> class.
        /// </summary>
        /// <param name="identityName">identityName.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="isGroup">isGroup (default to false).</param>
        /// <param name="azureUserType">azureUserType.</param>
        /// <param name="action">action.</param>
        /// <param name="externalUserType">externalUserType.</param>
        /// <param name="email">email.</param>
        public SPUserManagementModel(string identityName = default(string), string displayName = default(string), bool isGroup = false, string azureUserType = default(string), ManagePermissionAction? action = default(ManagePermissionAction?), ExternalUserType? externalUserType = default(ExternalUserType?), string email = default(string))
        {
            this.IdentityName = identityName;
            this.DisplayName = displayName;
            this.IsGroup = isGroup;
            this.AzureUserType = azureUserType;
            this.Action = action;
            this.ExternalUserType = externalUserType;
            this.Email = email;
        }

        /// <summary>
        /// Gets or Sets IdentityName
        /// </summary>
        [DataMember(Name = "identityName", EmitDefaultValue = true)]
        public string IdentityName { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "displayName", EmitDefaultValue = true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets IsGroup
        /// </summary>
        [DataMember(Name = "isGroup", EmitDefaultValue = false)]
        public bool IsGroup { get; set; }

        /// <summary>
        /// Gets or Sets AzureUserType
        /// </summary>
        [DataMember(Name = "azureUserType", EmitDefaultValue = true)]
        public string AzureUserType { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name = "email", EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SPUserManagementModel {\n");
            sb.Append("  IdentityName: ").Append(IdentityName).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  IsGroup: ").Append(IsGroup).Append("\n");
            sb.Append("  AzureUserType: ").Append(AzureUserType).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  ExternalUserType: ").Append(ExternalUserType).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
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
            return this.Equals(input as SPUserManagementModel);
        }

        /// <summary>
        /// Returns true if SPUserManagementModel instances are equal
        /// </summary>
        /// <param name="input">Instance of SPUserManagementModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SPUserManagementModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IdentityName == input.IdentityName ||
                    (this.IdentityName != null &&
                    this.IdentityName.Equals(input.IdentityName))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.IsGroup == input.IsGroup ||
                    this.IsGroup.Equals(input.IsGroup)
                ) && 
                (
                    this.AzureUserType == input.AzureUserType ||
                    (this.AzureUserType != null &&
                    this.AzureUserType.Equals(input.AzureUserType))
                ) && 
                (
                    this.Action == input.Action ||
                    this.Action.Equals(input.Action)
                ) && 
                (
                    this.ExternalUserType == input.ExternalUserType ||
                    this.ExternalUserType.Equals(input.ExternalUserType)
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
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
                if (this.IdentityName != null)
                    hashCode = hashCode * 59 + this.IdentityName.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                hashCode = hashCode * 59 + this.IsGroup.GetHashCode();
                if (this.AzureUserType != null)
                    hashCode = hashCode * 59 + this.AzureUserType.GetHashCode();
                hashCode = hashCode * 59 + this.Action.GetHashCode();
                hashCode = hashCode * 59 + this.ExternalUserType.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
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
