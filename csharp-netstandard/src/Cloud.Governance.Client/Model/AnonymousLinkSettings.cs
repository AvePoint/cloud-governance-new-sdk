

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
    /// AnonymousLinkSettings
    /// </summary>
    [DataContract(Name = "AnonymousLinkSettings")]
    public partial class AnonymousLinkSettings : IEquatable<AnonymousLinkSettings>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Permisssion
        /// </summary>
        [DataMember(Name = "permisssion", EmitDefaultValue = false)]
        public AnnoymouslinkPermissions? Permisssion { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AnonymousLinkSettings" /> class.
        /// </summary>
        /// <param name="permisssion">permisssion.</param>
        /// <param name="expirationDate">expirationDate.</param>
        public AnonymousLinkSettings(AnnoymouslinkPermissions? permisssion = default(AnnoymouslinkPermissions?), DateTime? expirationDate = default(DateTime?))
        {
            this.Permisssion = permisssion;
            this.ExpirationDate = expirationDate;
        }

        /// <summary>
        /// Gets or Sets ExpirationDate
        /// </summary>
        [DataMember(Name = "expirationDate", EmitDefaultValue = true)]
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnonymousLinkSettings {\n");
            sb.Append("  Permisssion: ").Append(Permisssion).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
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
            return this.Equals(input as AnonymousLinkSettings);
        }

        /// <summary>
        /// Returns true if AnonymousLinkSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of AnonymousLinkSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnonymousLinkSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Permisssion == input.Permisssion ||
                    this.Permisssion.Equals(input.Permisssion)
                ) && 
                (
                    this.ExpirationDate == input.ExpirationDate ||
                    (this.ExpirationDate != null &&
                    this.ExpirationDate.Equals(input.ExpirationDate))
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
                hashCode = hashCode * 59 + this.Permisssion.GetHashCode();
                if (this.ExpirationDate != null)
                    hashCode = hashCode * 59 + this.ExpirationDate.GetHashCode();
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
