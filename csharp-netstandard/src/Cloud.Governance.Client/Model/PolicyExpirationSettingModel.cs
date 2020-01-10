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
    /// PolicyExpirationSettingModel
    /// </summary>
    [DataContract]
    public partial class PolicyExpirationSettingModel :  IEquatable<PolicyExpirationSettingModel>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets DurationType
        /// </summary>
        [DataMember(Name="durationType", EmitDefaultValue=false)]
        public ApiDurationType? DurationType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyExpirationSettingModel" /> class.
        /// </summary>
        /// <param name="isEnabled">isEnabled.</param>
        /// <param name="duration">duration.</param>
        /// <param name="durationType">durationType.</param>
        public PolicyExpirationSettingModel(bool isEnabled = default(bool), int duration = default(int), ApiDurationType durationType = default(ApiDurationType))
        {
            this.IsEnabled = isEnabled;
            this.Duration = duration;
            this.DurationType = durationType;
        }
        
        /// <summary>
        /// Gets or Sets IsEnabled
        /// </summary>
        [DataMember(Name="isEnabled", EmitDefaultValue=false)]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Gets or Sets Duration
        /// </summary>
        [DataMember(Name="duration", EmitDefaultValue=false)]
        public int Duration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PolicyExpirationSettingModel {\n");
            sb.Append("  IsEnabled: ").Append(IsEnabled).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  DurationType: ").Append(DurationType).Append("\n");
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
            return this.Equals(input as PolicyExpirationSettingModel);
        }

        /// <summary>
        /// Returns true if PolicyExpirationSettingModel instances are equal
        /// </summary>
        /// <param name="input">Instance of PolicyExpirationSettingModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PolicyExpirationSettingModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsEnabled == input.IsEnabled ||
                    this.IsEnabled.Equals(input.IsEnabled)
                ) && 
                (
                    this.Duration == input.Duration ||
                    this.Duration.Equals(input.Duration)
                ) && 
                (
                    this.DurationType == input.DurationType ||
                    this.DurationType.Equals(input.DurationType)
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
                hashCode = hashCode * 59 + this.IsEnabled.GetHashCode();
                hashCode = hashCode * 59 + this.Duration.GetHashCode();
                hashCode = hashCode * 59 + this.DurationType.GetHashCode();
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
