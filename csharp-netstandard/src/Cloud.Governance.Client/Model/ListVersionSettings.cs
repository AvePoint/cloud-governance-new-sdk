

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
    /// ListVersionSettings
    /// </summary>
    [DataContract(Name = "ListVersionSettings")]
    public partial class ListVersionSettings : IEquatable<ListVersionSettings>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ListType
        /// </summary>
        [DataMember(Name = "listType", EmitDefaultValue = false)]
        public ListType? ListType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListVersionSettings" /> class.
        /// </summary>
        /// <param name="listType">listType.</param>
        /// <param name="enableMajorVersions">enableMajorVersions (default to false).</param>
        /// <param name="enableMajorAndMinorVersions">enableMajorAndMinorVersions (default to false).</param>
        /// <param name="enableMajorVersionLimit">enableMajorVersionLimit (default to false).</param>
        /// <param name="majorVersionLimit">majorVersionLimit (default to 0).</param>
        /// <param name="enableMinorVersionLimit">enableMinorVersionLimit (default to false).</param>
        /// <param name="minorVersionsLimit">minorVersionsLimit (default to 0).</param>
        /// <param name="requireContentApproval">requireContentApproval (default to false).</param>
        public ListVersionSettings(ListType? listType = default(ListType?), bool enableMajorVersions = false, bool enableMajorAndMinorVersions = false, bool enableMajorVersionLimit = false, int majorVersionLimit = 0, bool enableMinorVersionLimit = false, int minorVersionsLimit = 0, bool requireContentApproval = false)
        {
            this.ListType = listType;
            this.EnableMajorVersions = enableMajorVersions;
            this.EnableMajorAndMinorVersions = enableMajorAndMinorVersions;
            this.EnableMajorVersionLimit = enableMajorVersionLimit;
            this.MajorVersionLimit = majorVersionLimit;
            this.EnableMinorVersionLimit = enableMinorVersionLimit;
            this.MinorVersionsLimit = minorVersionsLimit;
            this.RequireContentApproval = requireContentApproval;
        }

        /// <summary>
        /// Gets or Sets EnableMajorVersions
        /// </summary>
        [DataMember(Name = "enableMajorVersions", EmitDefaultValue = false)]
        public bool EnableMajorVersions { get; set; }

        /// <summary>
        /// Gets or Sets EnableMajorAndMinorVersions
        /// </summary>
        [DataMember(Name = "enableMajorAndMinorVersions", EmitDefaultValue = false)]
        public bool EnableMajorAndMinorVersions { get; set; }

        /// <summary>
        /// Gets or Sets EnableMajorVersionLimit
        /// </summary>
        [DataMember(Name = "enableMajorVersionLimit", EmitDefaultValue = false)]
        public bool EnableMajorVersionLimit { get; set; }

        /// <summary>
        /// Gets or Sets MajorVersionLimit
        /// </summary>
        [DataMember(Name = "majorVersionLimit", EmitDefaultValue = false)]
        public int MajorVersionLimit { get; set; }

        /// <summary>
        /// Gets or Sets EnableMinorVersionLimit
        /// </summary>
        [DataMember(Name = "enableMinorVersionLimit", EmitDefaultValue = false)]
        public bool EnableMinorVersionLimit { get; set; }

        /// <summary>
        /// Gets or Sets MinorVersionsLimit
        /// </summary>
        [DataMember(Name = "minorVersionsLimit", EmitDefaultValue = false)]
        public int MinorVersionsLimit { get; set; }

        /// <summary>
        /// Gets or Sets RequireContentApproval
        /// </summary>
        [DataMember(Name = "requireContentApproval", EmitDefaultValue = false)]
        public bool RequireContentApproval { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListVersionSettings {\n");
            sb.Append("  ListType: ").Append(ListType).Append("\n");
            sb.Append("  EnableMajorVersions: ").Append(EnableMajorVersions).Append("\n");
            sb.Append("  EnableMajorAndMinorVersions: ").Append(EnableMajorAndMinorVersions).Append("\n");
            sb.Append("  EnableMajorVersionLimit: ").Append(EnableMajorVersionLimit).Append("\n");
            sb.Append("  MajorVersionLimit: ").Append(MajorVersionLimit).Append("\n");
            sb.Append("  EnableMinorVersionLimit: ").Append(EnableMinorVersionLimit).Append("\n");
            sb.Append("  MinorVersionsLimit: ").Append(MinorVersionsLimit).Append("\n");
            sb.Append("  RequireContentApproval: ").Append(RequireContentApproval).Append("\n");
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
            return this.Equals(input as ListVersionSettings);
        }

        /// <summary>
        /// Returns true if ListVersionSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of ListVersionSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListVersionSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ListType == input.ListType ||
                    this.ListType.Equals(input.ListType)
                ) && 
                (
                    this.EnableMajorVersions == input.EnableMajorVersions ||
                    this.EnableMajorVersions.Equals(input.EnableMajorVersions)
                ) && 
                (
                    this.EnableMajorAndMinorVersions == input.EnableMajorAndMinorVersions ||
                    this.EnableMajorAndMinorVersions.Equals(input.EnableMajorAndMinorVersions)
                ) && 
                (
                    this.EnableMajorVersionLimit == input.EnableMajorVersionLimit ||
                    this.EnableMajorVersionLimit.Equals(input.EnableMajorVersionLimit)
                ) && 
                (
                    this.MajorVersionLimit == input.MajorVersionLimit ||
                    this.MajorVersionLimit.Equals(input.MajorVersionLimit)
                ) && 
                (
                    this.EnableMinorVersionLimit == input.EnableMinorVersionLimit ||
                    this.EnableMinorVersionLimit.Equals(input.EnableMinorVersionLimit)
                ) && 
                (
                    this.MinorVersionsLimit == input.MinorVersionsLimit ||
                    this.MinorVersionsLimit.Equals(input.MinorVersionsLimit)
                ) && 
                (
                    this.RequireContentApproval == input.RequireContentApproval ||
                    this.RequireContentApproval.Equals(input.RequireContentApproval)
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
                hashCode = hashCode * 59 + this.ListType.GetHashCode();
                hashCode = hashCode * 59 + this.EnableMajorVersions.GetHashCode();
                hashCode = hashCode * 59 + this.EnableMajorAndMinorVersions.GetHashCode();
                hashCode = hashCode * 59 + this.EnableMajorVersionLimit.GetHashCode();
                hashCode = hashCode * 59 + this.MajorVersionLimit.GetHashCode();
                hashCode = hashCode * 59 + this.EnableMinorVersionLimit.GetHashCode();
                hashCode = hashCode * 59 + this.MinorVersionsLimit.GetHashCode();
                hashCode = hashCode * 59 + this.RequireContentApproval.GetHashCode();
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
