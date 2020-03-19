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
    /// GlobalPersonalSettingModel
    /// </summary>
    [DataContract]
    public partial class GlobalPersonalSettingModel :  IEquatable<GlobalPersonalSettingModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalPersonalSettingModel" /> class.
        /// </summary>
        /// <param name="languageId">languageId.</param>
        /// <param name="timeZoneId">timeZoneId.</param>
        /// <param name="isAdjustDaylight">isAdjustDaylight.</param>
        public GlobalPersonalSettingModel(int languageId = default(int), int timeZoneId = default(int), bool isAdjustDaylight = default(bool))
        {
            this.LanguageId = languageId;
            this.TimeZoneId = timeZoneId;
            this.IsAdjustDaylight = isAdjustDaylight;
        }
        
        /// <summary>
        /// Gets or Sets LanguageId
        /// </summary>
        [DataMember(Name="languageId", EmitDefaultValue=false)]
        public int LanguageId { get; set; }

        /// <summary>
        /// Gets or Sets TimeZoneId
        /// </summary>
        [DataMember(Name="timeZoneId", EmitDefaultValue=false)]
        public int TimeZoneId { get; set; }

        /// <summary>
        /// Gets or Sets IsAdjustDaylight
        /// </summary>
        [DataMember(Name="isAdjustDaylight", EmitDefaultValue=false)]
        public bool IsAdjustDaylight { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GlobalPersonalSettingModel {\n");
            sb.Append("  LanguageId: ").Append(LanguageId).Append("\n");
            sb.Append("  TimeZoneId: ").Append(TimeZoneId).Append("\n");
            sb.Append("  IsAdjustDaylight: ").Append(IsAdjustDaylight).Append("\n");
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
            return this.Equals(input as GlobalPersonalSettingModel);
        }

        /// <summary>
        /// Returns true if GlobalPersonalSettingModel instances are equal
        /// </summary>
        /// <param name="input">Instance of GlobalPersonalSettingModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GlobalPersonalSettingModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LanguageId == input.LanguageId ||
                    this.LanguageId.Equals(input.LanguageId)
                ) && 
                (
                    this.TimeZoneId == input.TimeZoneId ||
                    this.TimeZoneId.Equals(input.TimeZoneId)
                ) && 
                (
                    this.IsAdjustDaylight == input.IsAdjustDaylight ||
                    this.IsAdjustDaylight.Equals(input.IsAdjustDaylight)
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
                hashCode = hashCode * 59 + this.LanguageId.GetHashCode();
                hashCode = hashCode * 59 + this.TimeZoneId.GetHashCode();
                hashCode = hashCode * 59 + this.IsAdjustDaylight.GetHashCode();
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
            // LanguageId (int) maximum
            if(this.LanguageId > (int)2147483647)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LanguageId, must be a value less than or equal to 2147483647.", new [] { "LanguageId" });
            }

            // LanguageId (int) minimum
            if(this.LanguageId < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LanguageId, must be a value greater than or equal to 0.", new [] { "LanguageId" });
            }

            // TimeZoneId (int) maximum
            if(this.TimeZoneId > (int)95)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TimeZoneId, must be a value less than or equal to 95.", new [] { "TimeZoneId" });
            }

            // TimeZoneId (int) minimum
            if(this.TimeZoneId < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TimeZoneId, must be a value greater than or equal to 0.", new [] { "TimeZoneId" });
            }

            yield break;
        }
    }

}