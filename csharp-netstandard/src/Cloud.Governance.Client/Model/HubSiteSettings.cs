

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
    /// Hub site settings model
    /// </summary>
    [DataContract(Name = "HubSiteSettings")]
    public partial class HubSiteSettings : IEquatable<HubSiteSettings>, IValidatableObject
    {
        /// <summary>
        /// Set how to enable the hub site functionality. You can register the site collection as a hub site or associate the site collection with a hub site.
        /// </summary>
        /// <value>Set how to enable the hub site functionality. You can register the site collection as a hub site or associate the site collection with a hub site.</value>
        [DataMember(Name = "action", EmitDefaultValue = false)]
        public ConvertHubSiteActionType? Action { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="HubSiteSettings" /> class.
        /// </summary>
        /// <param name="enabled">Whether the hub site functionality is enabled. (default to false).</param>
        /// <param name="action">Set how to enable the hub site functionality. You can register the site collection as a hub site or associate the site collection with a hub site..</param>
        /// <param name="associatedHubSiteId">ID of the associated hub site.</param>
        /// <param name="associatedHubSiteTitle">Title of the associated hub site.</param>
        public HubSiteSettings(bool enabled = false, ConvertHubSiteActionType? action = default(ConvertHubSiteActionType?), Guid? associatedHubSiteId = default(Guid?), string associatedHubSiteTitle = default(string))
        {
            this.Enabled = enabled;
            this.Action = action;
            this.AssociatedHubSiteId = associatedHubSiteId;
            this.AssociatedHubSiteTitle = associatedHubSiteTitle;
        }

        /// <summary>
        /// Whether the hub site functionality is enabled.
        /// </summary>
        /// <value>Whether the hub site functionality is enabled.</value>
        [DataMember(Name = "enabled", EmitDefaultValue = false)]
        public bool Enabled { get; set; }

        /// <summary>
        /// ID of the associated hub site
        /// </summary>
        /// <value>ID of the associated hub site</value>
        [DataMember(Name = "associatedHubSiteId", EmitDefaultValue = true)]
        public Guid? AssociatedHubSiteId { get; set; }

        /// <summary>
        /// Title of the associated hub site
        /// </summary>
        /// <value>Title of the associated hub site</value>
        [DataMember(Name = "associatedHubSiteTitle", EmitDefaultValue = true)]
        public string AssociatedHubSiteTitle { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HubSiteSettings {\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  AssociatedHubSiteId: ").Append(AssociatedHubSiteId).Append("\n");
            sb.Append("  AssociatedHubSiteTitle: ").Append(AssociatedHubSiteTitle).Append("\n");
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
            return this.Equals(input as HubSiteSettings);
        }

        /// <summary>
        /// Returns true if HubSiteSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of HubSiteSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HubSiteSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Enabled == input.Enabled ||
                    this.Enabled.Equals(input.Enabled)
                ) && 
                (
                    this.Action == input.Action ||
                    this.Action.Equals(input.Action)
                ) && 
                (
                    this.AssociatedHubSiteId == input.AssociatedHubSiteId ||
                    (this.AssociatedHubSiteId != null &&
                    this.AssociatedHubSiteId.Equals(input.AssociatedHubSiteId))
                ) && 
                (
                    this.AssociatedHubSiteTitle == input.AssociatedHubSiteTitle ||
                    (this.AssociatedHubSiteTitle != null &&
                    this.AssociatedHubSiteTitle.Equals(input.AssociatedHubSiteTitle))
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
                hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.AssociatedHubSiteId != null)
                    hashCode = hashCode * 59 + this.AssociatedHubSiteId.GetHashCode();
                if (this.AssociatedHubSiteTitle != null)
                    hashCode = hashCode * 59 + this.AssociatedHubSiteTitle.GetHashCode();
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
