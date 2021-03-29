

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
    /// UserProfileMetadataSettings
    /// </summary>
    [DataContract(Name = "UserProfileMetadataSettings")]
    public partial class UserProfileMetadataSettings : IEquatable<UserProfileMetadataSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserProfileMetadataSettings" /> class.
        /// </summary>
        /// <param name="adminCenter">adminCenter.</param>
        /// <param name="valueType">valueType.</param>
        /// <param name="enableValueSync">enableValueSync (default to false).</param>
        /// <param name="enableRoleValueSync">enableRoleValueSync (default to false).</param>
        /// <param name="value">Value of Lookup to SharePoint library/list metadata..</param>
        /// <param name="property">property.</param>
        /// <param name="allowReferenceAsRoleInApprovalProcess">allowReferenceAsRoleInApprovalProcess (default to false).</param>
        public UserProfileMetadataSettings(string adminCenter = default(string), string valueType = default(string), bool enableValueSync = false, bool enableRoleValueSync = false, LookupValue value = default(LookupValue), string property = default(string), bool allowReferenceAsRoleInApprovalProcess = false)
        {
            this.AdminCenter = adminCenter;
            this.ValueType = valueType;
            this.EnableValueSync = enableValueSync;
            this.EnableRoleValueSync = enableRoleValueSync;
            this.Value = value;
            this.Property = property;
            this.AllowReferenceAsRoleInApprovalProcess = allowReferenceAsRoleInApprovalProcess;
        }

        /// <summary>
        /// Gets or Sets AdminCenter
        /// </summary>
        [DataMember(Name = "adminCenter", EmitDefaultValue = true)]
        public string AdminCenter { get; set; }

        /// <summary>
        /// Gets or Sets ValueType
        /// </summary>
        [DataMember(Name = "valueType", EmitDefaultValue = true)]
        public string ValueType { get; set; }

        /// <summary>
        /// Gets or Sets EnableValueSync
        /// </summary>
        [DataMember(Name = "enableValueSync", EmitDefaultValue = false)]
        public bool EnableValueSync { get; set; }

        /// <summary>
        /// Gets or Sets EnableRoleValueSync
        /// </summary>
        [DataMember(Name = "enableRoleValueSync", EmitDefaultValue = false)]
        public bool EnableRoleValueSync { get; set; }

        /// <summary>
        /// Value of Lookup to SharePoint library/list metadata.
        /// </summary>
        /// <value>Value of Lookup to SharePoint library/list metadata.</value>
        [DataMember(Name = "value", EmitDefaultValue = true)]
        public LookupValue Value { get; set; }

        /// <summary>
        /// Gets or Sets Property
        /// </summary>
        [DataMember(Name = "property", EmitDefaultValue = true)]
        public string Property { get; set; }

        /// <summary>
        /// Gets or Sets AllowReferenceAsRoleInApprovalProcess
        /// </summary>
        [DataMember(Name = "allowReferenceAsRoleInApprovalProcess", EmitDefaultValue = false)]
        public bool AllowReferenceAsRoleInApprovalProcess { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserProfileMetadataSettings {\n");
            sb.Append("  AdminCenter: ").Append(AdminCenter).Append("\n");
            sb.Append("  ValueType: ").Append(ValueType).Append("\n");
            sb.Append("  EnableValueSync: ").Append(EnableValueSync).Append("\n");
            sb.Append("  EnableRoleValueSync: ").Append(EnableRoleValueSync).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Property: ").Append(Property).Append("\n");
            sb.Append("  AllowReferenceAsRoleInApprovalProcess: ").Append(AllowReferenceAsRoleInApprovalProcess).Append("\n");
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
            return this.Equals(input as UserProfileMetadataSettings);
        }

        /// <summary>
        /// Returns true if UserProfileMetadataSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of UserProfileMetadataSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserProfileMetadataSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AdminCenter == input.AdminCenter ||
                    (this.AdminCenter != null &&
                    this.AdminCenter.Equals(input.AdminCenter))
                ) && 
                (
                    this.ValueType == input.ValueType ||
                    (this.ValueType != null &&
                    this.ValueType.Equals(input.ValueType))
                ) && 
                (
                    this.EnableValueSync == input.EnableValueSync ||
                    this.EnableValueSync.Equals(input.EnableValueSync)
                ) && 
                (
                    this.EnableRoleValueSync == input.EnableRoleValueSync ||
                    this.EnableRoleValueSync.Equals(input.EnableRoleValueSync)
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.Property == input.Property ||
                    (this.Property != null &&
                    this.Property.Equals(input.Property))
                ) && 
                (
                    this.AllowReferenceAsRoleInApprovalProcess == input.AllowReferenceAsRoleInApprovalProcess ||
                    this.AllowReferenceAsRoleInApprovalProcess.Equals(input.AllowReferenceAsRoleInApprovalProcess)
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
                if (this.AdminCenter != null)
                    hashCode = hashCode * 59 + this.AdminCenter.GetHashCode();
                if (this.ValueType != null)
                    hashCode = hashCode * 59 + this.ValueType.GetHashCode();
                hashCode = hashCode * 59 + this.EnableValueSync.GetHashCode();
                hashCode = hashCode * 59 + this.EnableRoleValueSync.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Property != null)
                    hashCode = hashCode * 59 + this.Property.GetHashCode();
                hashCode = hashCode * 59 + this.AllowReferenceAsRoleInApprovalProcess.GetHashCode();
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
