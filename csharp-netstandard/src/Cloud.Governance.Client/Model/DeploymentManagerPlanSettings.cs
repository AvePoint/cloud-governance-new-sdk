

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
    /// DeploymentManagerPlanSettings
    /// </summary>
    [DataContract(Name = "DeploymentManagerPlanSettings")]
    public partial class DeploymentManagerPlanSettings : IEquatable<DeploymentManagerPlanSettings>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets AssignBy
        /// </summary>
        [DataMember(Name = "assignBy", EmitDefaultValue = false)]
        public AssignBy? AssignBy { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentManagerPlanSettings" /> class.
        /// </summary>
        /// <param name="enabled">enabled.</param>
        /// <param name="plans">plans.</param>
        /// <param name="assignBy">assignBy.</param>
        /// <param name="_default">_default.</param>
        public DeploymentManagerPlanSettings(bool enabled = default(bool), List<string> plans = default(List<string>), AssignBy? assignBy = default(AssignBy?), string _default = default(string))
        {
            this.Enabled = enabled;
            this.Plans = plans;
            this.AssignBy = assignBy;
            this.Default = _default;
        }

        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name = "enabled", EmitDefaultValue = false)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or Sets Plans
        /// </summary>
        [DataMember(Name = "plans", EmitDefaultValue = true)]
        public List<string> Plans { get; set; }

        /// <summary>
        /// Gets or Sets Default
        /// </summary>
        [DataMember(Name = "default", EmitDefaultValue = true)]
        public string Default { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeploymentManagerPlanSettings {\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Plans: ").Append(Plans).Append("\n");
            sb.Append("  AssignBy: ").Append(AssignBy).Append("\n");
            sb.Append("  Default: ").Append(Default).Append("\n");
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
            return this.Equals(input as DeploymentManagerPlanSettings);
        }

        /// <summary>
        /// Returns true if DeploymentManagerPlanSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of DeploymentManagerPlanSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeploymentManagerPlanSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Enabled == input.Enabled ||
                    this.Enabled.Equals(input.Enabled)
                ) && 
                (
                    this.Plans == input.Plans ||
                    this.Plans != null &&
                    input.Plans != null &&
                    this.Plans.SequenceEqual(input.Plans)
                ) && 
                (
                    this.AssignBy == input.AssignBy ||
                    this.AssignBy.Equals(input.AssignBy)
                ) && 
                (
                    this.Default == input.Default ||
                    (this.Default != null &&
                    this.Default.Equals(input.Default))
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
                hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.Plans != null)
                    hashCode = hashCode * 59 + this.Plans.GetHashCode();
                hashCode = hashCode * 59 + this.AssignBy.GetHashCode();
                if (this.Default != null)
                    hashCode = hashCode * 59 + this.Default.GetHashCode();
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
