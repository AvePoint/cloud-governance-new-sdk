

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
    /// RequestMetadata
    /// </summary>
    [DataContract(Name = "RequestMetadata")]
    public partial class RequestMetadata : IEquatable<RequestMetadata>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public MetadataFieldType? Type { get; set; }

        /// <summary>
        /// Returns false as Type should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeType()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name = "action", EmitDefaultValue = false)]
        public MetadataActionType? Action { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestMetadata" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="booleanValue">booleanValue.</param>
        /// <param name="singleLineOrMultipleLineValue">singleLineOrMultipleLineValue.</param>
        /// <param name="upsOrAzureAdValue">upsOrAzureAdValue.</param>
        /// <param name="termsValue">termsValue.</param>
        /// <param name="userValue">userValue.</param>
        /// <param name="linkValue">linkValue.</param>
        /// <param name="choiceValue">choiceValue.</param>
        /// <param name="lookupListValue">lookupListValue.</param>
        /// <param name="value">value.</param>
        /// <param name="action">action.</param>
        public RequestMetadata(Guid id = default(Guid), string name = default(string), bool? booleanValue = default(bool?), string singleLineOrMultipleLineValue = default(string), LookupValue upsOrAzureAdValue = default(LookupValue), TermsValue termsValue = default(TermsValue), List<ApiUser> userValue = default(List<ApiUser>), LinkValue linkValue = default(LinkValue), List<string> choiceValue = default(List<string>), LookupListValue lookupListValue = default(LookupListValue), string value = default(string), MetadataActionType? action = default(MetadataActionType?))
        {
            this.Id = id;
            this.Name = name;
            this.BooleanValue = booleanValue;
            this.SingleLineOrMultipleLineValue = singleLineOrMultipleLineValue;
            this.UpsOrAzureAdValue = upsOrAzureAdValue;
            this.TermsValue = termsValue;
            this.UserValue = userValue;
            this.LinkValue = linkValue;
            this.ChoiceValue = choiceValue;
            this.LookupListValue = lookupListValue;
            this.Value = value;
            this.Action = action;
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
        /// Gets or Sets BooleanValue
        /// </summary>
        [DataMember(Name = "booleanValue", EmitDefaultValue = true)]
        public bool? BooleanValue { get; set; }

        /// <summary>
        /// Gets or Sets SingleLineOrMultipleLineValue
        /// </summary>
        [DataMember(Name = "singleLineOrMultipleLineValue", EmitDefaultValue = true)]
        public string SingleLineOrMultipleLineValue { get; set; }

        /// <summary>
        /// Gets or Sets UpsOrAzureAdValue
        /// </summary>
        [DataMember(Name = "upsOrAzureAdValue", EmitDefaultValue = true)]
        public LookupValue UpsOrAzureAdValue { get; set; }

        /// <summary>
        /// Gets or Sets TermsValue
        /// </summary>
        [DataMember(Name = "termsValue", EmitDefaultValue = true)]
        public TermsValue TermsValue { get; set; }

        /// <summary>
        /// Gets or Sets UserValue
        /// </summary>
        [DataMember(Name = "userValue", EmitDefaultValue = true)]
        public List<ApiUser> UserValue { get; set; }

        /// <summary>
        /// Gets or Sets LinkValue
        /// </summary>
        [DataMember(Name = "linkValue", EmitDefaultValue = true)]
        public LinkValue LinkValue { get; set; }

        /// <summary>
        /// Gets or Sets ChoiceValue
        /// </summary>
        [DataMember(Name = "choiceValue", EmitDefaultValue = true)]
        public List<string> ChoiceValue { get; set; }

        /// <summary>
        /// Gets or Sets LookupListValue
        /// </summary>
        [DataMember(Name = "lookupListValue", EmitDefaultValue = true)]
        public LookupListValue LookupListValue { get; set; }

        /// <summary>
        /// Gets or Sets ValueString
        /// </summary>
        [DataMember(Name = "valueString", EmitDefaultValue = true)]
        public string ValueString { get; private set; }

        /// <summary>
        /// Returns false as ValueString should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeValueString()
        {
            return false;
        }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = true)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RequestMetadata {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  BooleanValue: ").Append(BooleanValue).Append("\n");
            sb.Append("  SingleLineOrMultipleLineValue: ").Append(SingleLineOrMultipleLineValue).Append("\n");
            sb.Append("  UpsOrAzureAdValue: ").Append(UpsOrAzureAdValue).Append("\n");
            sb.Append("  TermsValue: ").Append(TermsValue).Append("\n");
            sb.Append("  UserValue: ").Append(UserValue).Append("\n");
            sb.Append("  LinkValue: ").Append(LinkValue).Append("\n");
            sb.Append("  ChoiceValue: ").Append(ChoiceValue).Append("\n");
            sb.Append("  LookupListValue: ").Append(LookupListValue).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ValueString: ").Append(ValueString).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
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
            return this.Equals(input as RequestMetadata);
        }

        /// <summary>
        /// Returns true if RequestMetadata instances are equal
        /// </summary>
        /// <param name="input">Instance of RequestMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RequestMetadata input)
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
                    this.BooleanValue == input.BooleanValue ||
                    (this.BooleanValue != null &&
                    this.BooleanValue.Equals(input.BooleanValue))
                ) && 
                (
                    this.SingleLineOrMultipleLineValue == input.SingleLineOrMultipleLineValue ||
                    (this.SingleLineOrMultipleLineValue != null &&
                    this.SingleLineOrMultipleLineValue.Equals(input.SingleLineOrMultipleLineValue))
                ) && 
                (
                    this.UpsOrAzureAdValue == input.UpsOrAzureAdValue ||
                    (this.UpsOrAzureAdValue != null &&
                    this.UpsOrAzureAdValue.Equals(input.UpsOrAzureAdValue))
                ) && 
                (
                    this.TermsValue == input.TermsValue ||
                    (this.TermsValue != null &&
                    this.TermsValue.Equals(input.TermsValue))
                ) && 
                (
                    this.UserValue == input.UserValue ||
                    this.UserValue != null &&
                    input.UserValue != null &&
                    this.UserValue.SequenceEqual(input.UserValue)
                ) && 
                (
                    this.LinkValue == input.LinkValue ||
                    (this.LinkValue != null &&
                    this.LinkValue.Equals(input.LinkValue))
                ) && 
                (
                    this.ChoiceValue == input.ChoiceValue ||
                    this.ChoiceValue != null &&
                    input.ChoiceValue != null &&
                    this.ChoiceValue.SequenceEqual(input.ChoiceValue)
                ) && 
                (
                    this.LookupListValue == input.LookupListValue ||
                    (this.LookupListValue != null &&
                    this.LookupListValue.Equals(input.LookupListValue))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.ValueString == input.ValueString ||
                    (this.ValueString != null &&
                    this.ValueString.Equals(input.ValueString))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.Action == input.Action ||
                    this.Action.Equals(input.Action)
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
                if (this.BooleanValue != null)
                    hashCode = hashCode * 59 + this.BooleanValue.GetHashCode();
                if (this.SingleLineOrMultipleLineValue != null)
                    hashCode = hashCode * 59 + this.SingleLineOrMultipleLineValue.GetHashCode();
                if (this.UpsOrAzureAdValue != null)
                    hashCode = hashCode * 59 + this.UpsOrAzureAdValue.GetHashCode();
                if (this.TermsValue != null)
                    hashCode = hashCode * 59 + this.TermsValue.GetHashCode();
                if (this.UserValue != null)
                    hashCode = hashCode * 59 + this.UserValue.GetHashCode();
                if (this.LinkValue != null)
                    hashCode = hashCode * 59 + this.LinkValue.GetHashCode();
                if (this.ChoiceValue != null)
                    hashCode = hashCode * 59 + this.ChoiceValue.GetHashCode();
                if (this.LookupListValue != null)
                    hashCode = hashCode * 59 + this.LookupListValue.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ValueString != null)
                    hashCode = hashCode * 59 + this.ValueString.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                hashCode = hashCode * 59 + this.Action.GetHashCode();
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
