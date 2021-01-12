

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
    /// UrlSequentialNumberingSettings
    /// </summary>
    [DataContract(Name = "UrlSequentialNumberingSettings")]
    public partial class UrlSequentialNumberingSettings : IEquatable<UrlSequentialNumberingSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UrlSequentialNumberingSettings" /> class.
        /// </summary>
        /// <param name="prefix">prefix.</param>
        /// <param name="delimiter">delimiter.</param>
        /// <param name="sequenceNumber">sequenceNumber.</param>
        public UrlSequentialNumberingSettings(string prefix = default(string), string delimiter = default(string), string sequenceNumber = default(string))
        {
            this.Prefix = prefix;
            this.Delimiter = delimiter;
            this.SequenceNumber = sequenceNumber;
        }

        /// <summary>
        /// Gets or Sets Prefix
        /// </summary>
        [DataMember(Name = "prefix", EmitDefaultValue = true)]
        public string Prefix { get; set; }

        /// <summary>
        /// Gets or Sets Delimiter
        /// </summary>
        [DataMember(Name = "delimiter", EmitDefaultValue = true)]
        public string Delimiter { get; set; }

        /// <summary>
        /// Gets or Sets SequenceNumber
        /// </summary>
        [DataMember(Name = "sequenceNumber", EmitDefaultValue = true)]
        public string SequenceNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UrlSequentialNumberingSettings {\n");
            sb.Append("  Prefix: ").Append(Prefix).Append("\n");
            sb.Append("  Delimiter: ").Append(Delimiter).Append("\n");
            sb.Append("  SequenceNumber: ").Append(SequenceNumber).Append("\n");
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
            return this.Equals(input as UrlSequentialNumberingSettings);
        }

        /// <summary>
        /// Returns true if UrlSequentialNumberingSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of UrlSequentialNumberingSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UrlSequentialNumberingSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Prefix == input.Prefix ||
                    (this.Prefix != null &&
                    this.Prefix.Equals(input.Prefix))
                ) && 
                (
                    this.Delimiter == input.Delimiter ||
                    (this.Delimiter != null &&
                    this.Delimiter.Equals(input.Delimiter))
                ) && 
                (
                    this.SequenceNumber == input.SequenceNumber ||
                    (this.SequenceNumber != null &&
                    this.SequenceNumber.Equals(input.SequenceNumber))
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
                if (this.Prefix != null)
                    hashCode = hashCode * 59 + this.Prefix.GetHashCode();
                if (this.Delimiter != null)
                    hashCode = hashCode * 59 + this.Delimiter.GetHashCode();
                if (this.SequenceNumber != null)
                    hashCode = hashCode * 59 + this.SequenceNumber.GetHashCode();
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
