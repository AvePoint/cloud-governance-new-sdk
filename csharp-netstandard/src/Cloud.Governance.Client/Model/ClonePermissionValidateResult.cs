

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
    /// ClonePermissionValidateResult
    /// </summary>
    [DataContract(Name = "ClonePermissionValidateResult")]
    public partial class ClonePermissionValidateResult : IEquatable<ClonePermissionValidateResult>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets MessageCode
        /// </summary>
        [DataMember(Name = "messageCode", EmitDefaultValue = false)]
        public MessageCode? MessageCode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClonePermissionValidateResult" /> class.
        /// </summary>
        /// <param name="siteId">siteId.</param>
        /// <param name="siteUrl">siteUrl.</param>
        /// <param name="isValid">isValid.</param>
        /// <param name="errorMessage">errorMessage.</param>
        /// <param name="messageCode">messageCode.</param>
        public ClonePermissionValidateResult(Guid siteId = default(Guid), string siteUrl = default(string), bool isValid = default(bool), string errorMessage = default(string), MessageCode? messageCode = default(MessageCode?))
        {
            this.SiteId = siteId;
            this.SiteUrl = siteUrl;
            this.IsValid = isValid;
            this.ErrorMessage = errorMessage;
            this.MessageCode = messageCode;
        }

        /// <summary>
        /// Gets or Sets SiteId
        /// </summary>
        [DataMember(Name = "siteId", EmitDefaultValue = false)]
        public Guid SiteId { get; set; }

        /// <summary>
        /// Gets or Sets SiteUrl
        /// </summary>
        [DataMember(Name = "siteUrl", EmitDefaultValue = true)]
        public string SiteUrl { get; set; }

        /// <summary>
        /// Gets or Sets IsValid
        /// </summary>
        [DataMember(Name = "isValid", EmitDefaultValue = false)]
        public bool IsValid { get; set; }

        /// <summary>
        /// Gets or Sets ErrorMessage
        /// </summary>
        [DataMember(Name = "errorMessage", EmitDefaultValue = true)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClonePermissionValidateResult {\n");
            sb.Append("  SiteId: ").Append(SiteId).Append("\n");
            sb.Append("  SiteUrl: ").Append(SiteUrl).Append("\n");
            sb.Append("  IsValid: ").Append(IsValid).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  MessageCode: ").Append(MessageCode).Append("\n");
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
            return this.Equals(input as ClonePermissionValidateResult);
        }

        /// <summary>
        /// Returns true if ClonePermissionValidateResult instances are equal
        /// </summary>
        /// <param name="input">Instance of ClonePermissionValidateResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClonePermissionValidateResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SiteId == input.SiteId ||
                    (this.SiteId != null &&
                    this.SiteId.Equals(input.SiteId))
                ) && 
                (
                    this.SiteUrl == input.SiteUrl ||
                    (this.SiteUrl != null &&
                    this.SiteUrl.Equals(input.SiteUrl))
                ) && 
                (
                    this.IsValid == input.IsValid ||
                    this.IsValid.Equals(input.IsValid)
                ) && 
                (
                    this.ErrorMessage == input.ErrorMessage ||
                    (this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(input.ErrorMessage))
                ) && 
                (
                    this.MessageCode == input.MessageCode ||
                    this.MessageCode.Equals(input.MessageCode)
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
                if (this.SiteId != null)
                    hashCode = hashCode * 59 + this.SiteId.GetHashCode();
                if (this.SiteUrl != null)
                    hashCode = hashCode * 59 + this.SiteUrl.GetHashCode();
                hashCode = hashCode * 59 + this.IsValid.GetHashCode();
                if (this.ErrorMessage != null)
                    hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                hashCode = hashCode * 59 + this.MessageCode.GetHashCode();
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
