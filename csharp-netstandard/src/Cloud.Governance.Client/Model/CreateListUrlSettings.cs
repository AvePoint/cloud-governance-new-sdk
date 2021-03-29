

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
    /// CreateListUrlSettings
    /// </summary>
    [DataContract(Name = "CreateListUrlSettings")]
    public partial class CreateListUrlSettings : IEquatable<CreateListUrlSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateListUrlSettings" /> class.
        /// </summary>
        /// <param name="enableContructUrl">enableContructUrl (default to false).</param>
        /// <param name="contructUrlSetting">contructUrlSetting.</param>
        /// <param name="enableUrlValidation">enableUrlValidation (default to false).</param>
        /// <param name="textValidationRule">textValidationRule.</param>
        public CreateListUrlSettings(bool enableContructUrl = false, ContructUrlSetting contructUrlSetting = default(ContructUrlSetting), bool enableUrlValidation = false, TextValidationRuleRef textValidationRule = default(TextValidationRuleRef))
        {
            this.EnableContructUrl = enableContructUrl;
            this.ContructUrlSetting = contructUrlSetting;
            this.EnableUrlValidation = enableUrlValidation;
            this.TextValidationRule = textValidationRule;
        }

        /// <summary>
        /// Gets or Sets EnableContructUrl
        /// </summary>
        [DataMember(Name = "enableContructUrl", EmitDefaultValue = false)]
        public bool EnableContructUrl { get; set; }

        /// <summary>
        /// Gets or Sets ContructUrlSetting
        /// </summary>
        [DataMember(Name = "contructUrlSetting", EmitDefaultValue = true)]
        public ContructUrlSetting ContructUrlSetting { get; set; }

        /// <summary>
        /// Gets or Sets EnableUrlValidation
        /// </summary>
        [DataMember(Name = "enableUrlValidation", EmitDefaultValue = false)]
        public bool EnableUrlValidation { get; set; }

        /// <summary>
        /// Gets or Sets TextValidationRule
        /// </summary>
        [DataMember(Name = "textValidationRule", EmitDefaultValue = true)]
        public TextValidationRuleRef TextValidationRule { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateListUrlSettings {\n");
            sb.Append("  EnableContructUrl: ").Append(EnableContructUrl).Append("\n");
            sb.Append("  ContructUrlSetting: ").Append(ContructUrlSetting).Append("\n");
            sb.Append("  EnableUrlValidation: ").Append(EnableUrlValidation).Append("\n");
            sb.Append("  TextValidationRule: ").Append(TextValidationRule).Append("\n");
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
            return this.Equals(input as CreateListUrlSettings);
        }

        /// <summary>
        /// Returns true if CreateListUrlSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateListUrlSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateListUrlSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EnableContructUrl == input.EnableContructUrl ||
                    this.EnableContructUrl.Equals(input.EnableContructUrl)
                ) && 
                (
                    this.ContructUrlSetting == input.ContructUrlSetting ||
                    (this.ContructUrlSetting != null &&
                    this.ContructUrlSetting.Equals(input.ContructUrlSetting))
                ) && 
                (
                    this.EnableUrlValidation == input.EnableUrlValidation ||
                    this.EnableUrlValidation.Equals(input.EnableUrlValidation)
                ) && 
                (
                    this.TextValidationRule == input.TextValidationRule ||
                    (this.TextValidationRule != null &&
                    this.TextValidationRule.Equals(input.TextValidationRule))
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
                hashCode = hashCode * 59 + this.EnableContructUrl.GetHashCode();
                if (this.ContructUrlSetting != null)
                    hashCode = hashCode * 59 + this.ContructUrlSetting.GetHashCode();
                hashCode = hashCode * 59 + this.EnableUrlValidation.GetHashCode();
                if (this.TextValidationRule != null)
                    hashCode = hashCode * 59 + this.TextValidationRule.GetHashCode();
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
