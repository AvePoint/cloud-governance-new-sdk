

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
    /// CustomMetadata
    /// </summary>
    [DataContract(Name = "CustomMetadata")]
    public partial class CustomMetadata : IEquatable<CustomMetadata>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public MetadataFieldType? Type { get; set; }
        /// <summary>
        /// Gets or Sets DisplayType
        /// </summary>
        [DataMember(Name = "displayType", EmitDefaultValue = false)]
        public DisplayInReportType? DisplayType { get; set; }
        /// <summary>
        /// Gets or Sets AssignBy
        /// </summary>
        [DataMember(Name = "assignBy", EmitDefaultValue = false)]
        public AssignBy? AssignBy { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomMetadata" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="type">type.</param>
        /// <param name="displayType">displayType.</param>
        /// <param name="assignBy">assignBy.</param>
        /// <param name="enableTextValidation">enableTextValidation.</param>
        /// <param name="textValidationRule">textValidationRule.</param>
        /// <param name="booleanMetadataSettings">booleanMetadataSettings.</param>
        /// <param name="termsMetadataSettings">termsMetadataSettings.</param>
        /// <param name="userMetadataSettings">userMetadataSettings.</param>
        /// <param name="userProfileMetadataSettings">userProfileMetadataSettings.</param>
        /// <param name="azureAdMetadataSettings">azureAdMetadataSettings.</param>
        /// <param name="choiceMetadataSettings">choiceMetadataSettings.</param>
        /// <param name="linkMetadataSettings">linkMetadataSettings.</param>
        /// <param name="singleLineOrMultipleLineMetadataSettings">singleLineOrMultipleLineMetadataSettings.</param>
        /// <param name="sharePointListMetadataSettings">sharePointListMetadataSettings.</param>
        public CustomMetadata(Guid id = default(Guid), string name = default(string), string description = default(string), MetadataFieldType? type = default(MetadataFieldType?), DisplayInReportType? displayType = default(DisplayInReportType?), AssignBy? assignBy = default(AssignBy?), bool enableTextValidation = default(bool), TextValidationRuleRef textValidationRule = default(TextValidationRuleRef), BooleanMetadataSettings booleanMetadataSettings = default(BooleanMetadataSettings), TermsMetadataSettings termsMetadataSettings = default(TermsMetadataSettings), UserMetadataSettings userMetadataSettings = default(UserMetadataSettings), UserProfileMetadataSettings userProfileMetadataSettings = default(UserProfileMetadataSettings), AzureAdMetadataSettings azureAdMetadataSettings = default(AzureAdMetadataSettings), ChoiceMetadataSettings choiceMetadataSettings = default(ChoiceMetadataSettings), LinkMetadataSettings linkMetadataSettings = default(LinkMetadataSettings), SingleLineOrMultipleLineMetadataSettings singleLineOrMultipleLineMetadataSettings = default(SingleLineOrMultipleLineMetadataSettings), SharePointListMetadataSettings sharePointListMetadataSettings = default(SharePointListMetadataSettings))
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Type = type;
            this.DisplayType = displayType;
            this.AssignBy = assignBy;
            this.EnableTextValidation = enableTextValidation;
            this.TextValidationRule = textValidationRule;
            this.BooleanMetadataSettings = booleanMetadataSettings;
            this.TermsMetadataSettings = termsMetadataSettings;
            this.UserMetadataSettings = userMetadataSettings;
            this.UserProfileMetadataSettings = userProfileMetadataSettings;
            this.AzureAdMetadataSettings = azureAdMetadataSettings;
            this.ChoiceMetadataSettings = choiceMetadataSettings;
            this.LinkMetadataSettings = linkMetadataSettings;
            this.SingleLineOrMultipleLineMetadataSettings = singleLineOrMultipleLineMetadataSettings;
            this.SharePointListMetadataSettings = sharePointListMetadataSettings;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets EnableTextValidation
        /// </summary>
        [DataMember(Name = "enableTextValidation", EmitDefaultValue = false)]
        public bool EnableTextValidation { get; set; }

        /// <summary>
        /// Gets or Sets TextValidationRule
        /// </summary>
        [DataMember(Name = "textValidationRule", EmitDefaultValue = true)]
        public TextValidationRuleRef TextValidationRule { get; set; }

        /// <summary>
        /// Gets or Sets BooleanMetadataSettings
        /// </summary>
        [DataMember(Name = "booleanMetadataSettings", EmitDefaultValue = true)]
        public BooleanMetadataSettings BooleanMetadataSettings { get; set; }

        /// <summary>
        /// Gets or Sets TermsMetadataSettings
        /// </summary>
        [DataMember(Name = "termsMetadataSettings", EmitDefaultValue = true)]
        public TermsMetadataSettings TermsMetadataSettings { get; set; }

        /// <summary>
        /// Gets or Sets UserMetadataSettings
        /// </summary>
        [DataMember(Name = "userMetadataSettings", EmitDefaultValue = true)]
        public UserMetadataSettings UserMetadataSettings { get; set; }

        /// <summary>
        /// Gets or Sets UserProfileMetadataSettings
        /// </summary>
        [DataMember(Name = "userProfileMetadataSettings", EmitDefaultValue = true)]
        public UserProfileMetadataSettings UserProfileMetadataSettings { get; set; }

        /// <summary>
        /// Gets or Sets AzureAdMetadataSettings
        /// </summary>
        [DataMember(Name = "azureAdMetadataSettings", EmitDefaultValue = true)]
        public AzureAdMetadataSettings AzureAdMetadataSettings { get; set; }

        /// <summary>
        /// Gets or Sets ChoiceMetadataSettings
        /// </summary>
        [DataMember(Name = "choiceMetadataSettings", EmitDefaultValue = true)]
        public ChoiceMetadataSettings ChoiceMetadataSettings { get; set; }

        /// <summary>
        /// Gets or Sets LinkMetadataSettings
        /// </summary>
        [DataMember(Name = "linkMetadataSettings", EmitDefaultValue = true)]
        public LinkMetadataSettings LinkMetadataSettings { get; set; }

        /// <summary>
        /// Gets or Sets SingleLineOrMultipleLineMetadataSettings
        /// </summary>
        [DataMember(Name = "singleLineOrMultipleLineMetadataSettings", EmitDefaultValue = true)]
        public SingleLineOrMultipleLineMetadataSettings SingleLineOrMultipleLineMetadataSettings { get; set; }

        /// <summary>
        /// Gets or Sets SharePointListMetadataSettings
        /// </summary>
        [DataMember(Name = "sharePointListMetadataSettings", EmitDefaultValue = true)]
        public SharePointListMetadataSettings SharePointListMetadataSettings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomMetadata {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  DisplayType: ").Append(DisplayType).Append("\n");
            sb.Append("  AssignBy: ").Append(AssignBy).Append("\n");
            sb.Append("  EnableTextValidation: ").Append(EnableTextValidation).Append("\n");
            sb.Append("  TextValidationRule: ").Append(TextValidationRule).Append("\n");
            sb.Append("  BooleanMetadataSettings: ").Append(BooleanMetadataSettings).Append("\n");
            sb.Append("  TermsMetadataSettings: ").Append(TermsMetadataSettings).Append("\n");
            sb.Append("  UserMetadataSettings: ").Append(UserMetadataSettings).Append("\n");
            sb.Append("  UserProfileMetadataSettings: ").Append(UserProfileMetadataSettings).Append("\n");
            sb.Append("  AzureAdMetadataSettings: ").Append(AzureAdMetadataSettings).Append("\n");
            sb.Append("  ChoiceMetadataSettings: ").Append(ChoiceMetadataSettings).Append("\n");
            sb.Append("  LinkMetadataSettings: ").Append(LinkMetadataSettings).Append("\n");
            sb.Append("  SingleLineOrMultipleLineMetadataSettings: ").Append(SingleLineOrMultipleLineMetadataSettings).Append("\n");
            sb.Append("  SharePointListMetadataSettings: ").Append(SharePointListMetadataSettings).Append("\n");
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
            return this.Equals(input as CustomMetadata);
        }

        /// <summary>
        /// Returns true if CustomMetadata instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomMetadata input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.DisplayType == input.DisplayType ||
                    this.DisplayType.Equals(input.DisplayType)
                ) && 
                (
                    this.AssignBy == input.AssignBy ||
                    this.AssignBy.Equals(input.AssignBy)
                ) && 
                (
                    this.EnableTextValidation == input.EnableTextValidation ||
                    this.EnableTextValidation.Equals(input.EnableTextValidation)
                ) && 
                (
                    this.TextValidationRule == input.TextValidationRule ||
                    (this.TextValidationRule != null &&
                    this.TextValidationRule.Equals(input.TextValidationRule))
                ) && 
                (
                    this.BooleanMetadataSettings == input.BooleanMetadataSettings ||
                    (this.BooleanMetadataSettings != null &&
                    this.BooleanMetadataSettings.Equals(input.BooleanMetadataSettings))
                ) && 
                (
                    this.TermsMetadataSettings == input.TermsMetadataSettings ||
                    (this.TermsMetadataSettings != null &&
                    this.TermsMetadataSettings.Equals(input.TermsMetadataSettings))
                ) && 
                (
                    this.UserMetadataSettings == input.UserMetadataSettings ||
                    (this.UserMetadataSettings != null &&
                    this.UserMetadataSettings.Equals(input.UserMetadataSettings))
                ) && 
                (
                    this.UserProfileMetadataSettings == input.UserProfileMetadataSettings ||
                    (this.UserProfileMetadataSettings != null &&
                    this.UserProfileMetadataSettings.Equals(input.UserProfileMetadataSettings))
                ) && 
                (
                    this.AzureAdMetadataSettings == input.AzureAdMetadataSettings ||
                    (this.AzureAdMetadataSettings != null &&
                    this.AzureAdMetadataSettings.Equals(input.AzureAdMetadataSettings))
                ) && 
                (
                    this.ChoiceMetadataSettings == input.ChoiceMetadataSettings ||
                    (this.ChoiceMetadataSettings != null &&
                    this.ChoiceMetadataSettings.Equals(input.ChoiceMetadataSettings))
                ) && 
                (
                    this.LinkMetadataSettings == input.LinkMetadataSettings ||
                    (this.LinkMetadataSettings != null &&
                    this.LinkMetadataSettings.Equals(input.LinkMetadataSettings))
                ) && 
                (
                    this.SingleLineOrMultipleLineMetadataSettings == input.SingleLineOrMultipleLineMetadataSettings ||
                    (this.SingleLineOrMultipleLineMetadataSettings != null &&
                    this.SingleLineOrMultipleLineMetadataSettings.Equals(input.SingleLineOrMultipleLineMetadataSettings))
                ) && 
                (
                    this.SharePointListMetadataSettings == input.SharePointListMetadataSettings ||
                    (this.SharePointListMetadataSettings != null &&
                    this.SharePointListMetadataSettings.Equals(input.SharePointListMetadataSettings))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                hashCode = hashCode * 59 + this.DisplayType.GetHashCode();
                hashCode = hashCode * 59 + this.AssignBy.GetHashCode();
                hashCode = hashCode * 59 + this.EnableTextValidation.GetHashCode();
                if (this.TextValidationRule != null)
                    hashCode = hashCode * 59 + this.TextValidationRule.GetHashCode();
                if (this.BooleanMetadataSettings != null)
                    hashCode = hashCode * 59 + this.BooleanMetadataSettings.GetHashCode();
                if (this.TermsMetadataSettings != null)
                    hashCode = hashCode * 59 + this.TermsMetadataSettings.GetHashCode();
                if (this.UserMetadataSettings != null)
                    hashCode = hashCode * 59 + this.UserMetadataSettings.GetHashCode();
                if (this.UserProfileMetadataSettings != null)
                    hashCode = hashCode * 59 + this.UserProfileMetadataSettings.GetHashCode();
                if (this.AzureAdMetadataSettings != null)
                    hashCode = hashCode * 59 + this.AzureAdMetadataSettings.GetHashCode();
                if (this.ChoiceMetadataSettings != null)
                    hashCode = hashCode * 59 + this.ChoiceMetadataSettings.GetHashCode();
                if (this.LinkMetadataSettings != null)
                    hashCode = hashCode * 59 + this.LinkMetadataSettings.GetHashCode();
                if (this.SingleLineOrMultipleLineMetadataSettings != null)
                    hashCode = hashCode * 59 + this.SingleLineOrMultipleLineMetadataSettings.GetHashCode();
                if (this.SharePointListMetadataSettings != null)
                    hashCode = hashCode * 59 + this.SharePointListMetadataSettings.GetHashCode();
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
