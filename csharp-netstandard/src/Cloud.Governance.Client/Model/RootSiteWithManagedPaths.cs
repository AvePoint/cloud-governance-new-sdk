

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
    /// RootSiteWithManagedPaths
    /// </summary>
    [DataContract(Name = "RootSiteWithManagedPaths")]
    public partial class RootSiteWithManagedPaths : IEquatable<RootSiteWithManagedPaths>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RootSiteWithManagedPaths" /> class.
        /// </summary>
        /// <param name="rootSite">rootSite.</param>
        /// <param name="managedPaths">managedPaths.</param>
        public RootSiteWithManagedPaths(string rootSite = default(string), List<string> managedPaths = default(List<string>))
        {
            this.RootSite = rootSite;
            this.ManagedPaths = managedPaths;
        }

        /// <summary>
        /// Gets or Sets RootSite
        /// </summary>
        [DataMember(Name = "rootSite", EmitDefaultValue = true)]
        public string RootSite { get; set; }

        /// <summary>
        /// Gets or Sets ManagedPaths
        /// </summary>
        [DataMember(Name = "managedPaths", EmitDefaultValue = true)]
        public List<string> ManagedPaths { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RootSiteWithManagedPaths {\n");
            sb.Append("  RootSite: ").Append(RootSite).Append("\n");
            sb.Append("  ManagedPaths: ").Append(ManagedPaths).Append("\n");
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
            return this.Equals(input as RootSiteWithManagedPaths);
        }

        /// <summary>
        /// Returns true if RootSiteWithManagedPaths instances are equal
        /// </summary>
        /// <param name="input">Instance of RootSiteWithManagedPaths to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RootSiteWithManagedPaths input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RootSite == input.RootSite ||
                    (this.RootSite != null &&
                    this.RootSite.Equals(input.RootSite))
                ) && 
                (
                    this.ManagedPaths == input.ManagedPaths ||
                    this.ManagedPaths != null &&
                    input.ManagedPaths != null &&
                    this.ManagedPaths.SequenceEqual(input.ManagedPaths)
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
                if (this.RootSite != null)
                    hashCode = hashCode * 59 + this.RootSite.GetHashCode();
                if (this.ManagedPaths != null)
                    hashCode = hashCode * 59 + this.ManagedPaths.GetHashCode();
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
