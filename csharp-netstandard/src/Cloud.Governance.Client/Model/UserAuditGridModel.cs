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
    /// UserAuditGridModel
    /// </summary>
    [DataContract]
    public partial class UserAuditGridModel :  IEquatable<UserAuditGridModel>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Object
        /// </summary>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public EventObject? Object { get; set; }
        /// <summary>
        /// Gets or Sets ObjectType
        /// </summary>
        [DataMember(Name="objectType", EmitDefaultValue=false)]
        public EventObjectType? ObjectType { get; set; }
        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public EventAction? Action { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserAuditGridModel" /> class.
        /// </summary>
        /// <param name="_object">_object.</param>
        /// <param name="objectType">objectType.</param>
        /// <param name="instanceName">instanceName.</param>
        /// <param name="createdBy">createdBy.</param>
        /// <param name="created">created.</param>
        /// <param name="action">action.</param>
        public UserAuditGridModel(EventObject _object = default(EventObject), EventObjectType objectType = default(EventObjectType), string instanceName = default(string), string createdBy = default(string), DateTime created = default(DateTime), EventAction action = default(EventAction))
        {
            this.Object = _object;
            this.ObjectType = objectType;
            this.InstanceName = instanceName;
            this.CreatedBy = createdBy;
            this.Created = created;
            this.Action = action;
        }
        
        /// <summary>
        /// Gets or Sets ObjectDescription
        /// </summary>
        [DataMember(Name="objectDescription", EmitDefaultValue=true)]
        public string ObjectDescription { get; private set; }

        /// <summary>
        /// Gets or Sets ObjectTypeDescription
        /// </summary>
        [DataMember(Name="objectTypeDescription", EmitDefaultValue=true)]
        public string ObjectTypeDescription { get; private set; }

        /// <summary>
        /// Gets or Sets InstanceName
        /// </summary>
        [DataMember(Name="instanceName", EmitDefaultValue=true)]
        public string InstanceName { get; set; }

        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name="createdBy", EmitDefaultValue=true)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime Created { get; set; }

        /// <summary>
        /// Gets or Sets ActionDescription
        /// </summary>
        [DataMember(Name="actionDescription", EmitDefaultValue=true)]
        public string ActionDescription { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserAuditGridModel {\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  ObjectDescription: ").Append(ObjectDescription).Append("\n");
            sb.Append("  ObjectType: ").Append(ObjectType).Append("\n");
            sb.Append("  ObjectTypeDescription: ").Append(ObjectTypeDescription).Append("\n");
            sb.Append("  InstanceName: ").Append(InstanceName).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  ActionDescription: ").Append(ActionDescription).Append("\n");
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
            return this.Equals(input as UserAuditGridModel);
        }

        /// <summary>
        /// Returns true if UserAuditGridModel instances are equal
        /// </summary>
        /// <param name="input">Instance of UserAuditGridModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserAuditGridModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Object == input.Object ||
                    this.Object.Equals(input.Object)
                ) && 
                (
                    this.ObjectDescription == input.ObjectDescription ||
                    (this.ObjectDescription != null &&
                    this.ObjectDescription.Equals(input.ObjectDescription))
                ) && 
                (
                    this.ObjectType == input.ObjectType ||
                    this.ObjectType.Equals(input.ObjectType)
                ) && 
                (
                    this.ObjectTypeDescription == input.ObjectTypeDescription ||
                    (this.ObjectTypeDescription != null &&
                    this.ObjectTypeDescription.Equals(input.ObjectTypeDescription))
                ) && 
                (
                    this.InstanceName == input.InstanceName ||
                    (this.InstanceName != null &&
                    this.InstanceName.Equals(input.InstanceName))
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.Action == input.Action ||
                    this.Action.Equals(input.Action)
                ) && 
                (
                    this.ActionDescription == input.ActionDescription ||
                    (this.ActionDescription != null &&
                    this.ActionDescription.Equals(input.ActionDescription))
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
                hashCode = hashCode * 59 + this.Object.GetHashCode();
                if (this.ObjectDescription != null)
                    hashCode = hashCode * 59 + this.ObjectDescription.GetHashCode();
                hashCode = hashCode * 59 + this.ObjectType.GetHashCode();
                if (this.ObjectTypeDescription != null)
                    hashCode = hashCode * 59 + this.ObjectTypeDescription.GetHashCode();
                if (this.InstanceName != null)
                    hashCode = hashCode * 59 + this.InstanceName.GetHashCode();
                if (this.CreatedBy != null)
                    hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.ActionDescription != null)
                    hashCode = hashCode * 59 + this.ActionDescription.GetHashCode();
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