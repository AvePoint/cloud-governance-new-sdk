

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
    /// AzureAdMetadataSettings
    /// </summary>
    [DataContract(Name = "AzureAdMetadataSettings")]
    public partial class AzureAdMetadataSettings : IEquatable<AzureAdMetadataSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AzureAdMetadataSettings" /> class.
        /// </summary>
        /// <param name="office365Tenant">office365Tenant.</param>
        /// <param name="useBuiltInProperty">useBuiltInProperty (default to false).</param>
        /// <param name="value">Value of Lookup to SharePoint library/list metadata..</param>
        /// <param name="property">property.</param>
        /// <param name="allowReferenceAsRoleInApprovalProcess">allowReferenceAsRoleInApprovalProcess (default to false).</param>
        public AzureAdMetadataSettings(GuidModel office365Tenant = default(GuidModel), bool useBuiltInProperty = false, LookupValue value = default(LookupValue), string property = default(string), bool allowReferenceAsRoleInApprovalProcess = false)
        {
            this.Office365Tenant = office365Tenant;
            this.UseBuiltInProperty = useBuiltInProperty;
            this.Value = value;
            this.Property = property;
            this.AllowReferenceAsRoleInApprovalProcess = allowReferenceAsRoleInApprovalProcess;
        }

        /// <summary>
        /// Gets or Sets Office365Tenant
        /// </summary>
        [DataMember(Name = "office365Tenant", EmitDefaultValue = true)]
        public GuidModel Office365Tenant { get; set; }

        /// <summary>
        /// Gets or Sets UseBuiltInProperty
        /// </summary>
        [DataMember(Name = "useBuiltInProperty", EmitDefaultValue = false)]
        public bool UseBuiltInProperty { get; set; }

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
            sb.Append("class AzureAdMetadataSettings {\n");
            sb.Append("  Office365Tenant: ").Append(Office365Tenant).Append("\n");
            sb.Append("  UseBuiltInProperty: ").Append(UseBuiltInProperty).Append("\n");
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
            return this.Equals(input as AzureAdMetadataSettings);
        }

        /// <summary>
        /// Returns true if AzureAdMetadataSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of AzureAdMetadataSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AzureAdMetadataSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Office365Tenant == input.Office365Tenant ||
                    (this.Office365Tenant != null &&
                    this.Office365Tenant.Equals(input.Office365Tenant))
                ) && 
                (
                    this.UseBuiltInProperty == input.UseBuiltInProperty ||
                    this.UseBuiltInProperty.Equals(input.UseBuiltInProperty)
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
                if (this.Office365Tenant != null)
                    hashCode = hashCode * 59 + this.Office365Tenant.GetHashCode();
                hashCode = hashCode * 59 + this.UseBuiltInProperty.GetHashCode();
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
