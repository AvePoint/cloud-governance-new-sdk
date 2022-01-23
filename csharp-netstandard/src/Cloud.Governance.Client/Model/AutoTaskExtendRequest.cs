

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
    /// AutoTaskExtendRequest
    /// </summary>
    [DataContract(Name = "AutoTaskExtendRequest")]
    public partial class AutoTaskExtendRequest : IEquatable<AutoTaskExtendRequest>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name = "action", EmitDefaultValue = false)]
        public LifecycleAction? Action { get; set; }
        /// <summary>
        /// Gets or Sets ExtendDurationType
        /// </summary>
        [DataMember(Name = "extendDurationType", EmitDefaultValue = false)]
        public ApiDurationType? ExtendDurationType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoTaskExtendRequest" /> class.
        /// </summary>
        /// <param name="action">action.</param>
        /// <param name="extendDuration">extendDuration (default to 0).</param>
        /// <param name="extendDurationType">extendDurationType.</param>
        /// <param name="taskId">taskId.</param>
        /// <param name="metadatas">metadatas.</param>
        /// <param name="comments">comments.</param>
        public AutoTaskExtendRequest(LifecycleAction? action = default(LifecycleAction?), int extendDuration = 0, ApiDurationType? extendDurationType = default(ApiDurationType?), Guid taskId = default(Guid), List<RequestMetadata> metadatas = default(List<RequestMetadata>), CommentsParam comments = default(CommentsParam))
        {
            this.Action = action;
            this.ExtendDuration = extendDuration;
            this.ExtendDurationType = extendDurationType;
            this.TaskId = taskId;
            this.Metadatas = metadatas;
            this.Comments = comments;
        }

        /// <summary>
        /// Gets or Sets ExtendDuration
        /// </summary>
        [DataMember(Name = "extendDuration", EmitDefaultValue = false)]
        public int ExtendDuration { get; set; }

        /// <summary>
        /// Gets or Sets TaskId
        /// </summary>
        [DataMember(Name = "taskId", EmitDefaultValue = false)]
        public Guid TaskId { get; set; }

        /// <summary>
        /// Gets or Sets Metadatas
        /// </summary>
        [DataMember(Name = "metadatas", EmitDefaultValue = true)]
        public List<RequestMetadata> Metadatas { get; set; }

        /// <summary>
        /// Gets or Sets Comments
        /// </summary>
        [DataMember(Name = "comments", EmitDefaultValue = true)]
        public CommentsParam Comments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AutoTaskExtendRequest {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  ExtendDuration: ").Append(ExtendDuration).Append("\n");
            sb.Append("  ExtendDurationType: ").Append(ExtendDurationType).Append("\n");
            sb.Append("  TaskId: ").Append(TaskId).Append("\n");
            sb.Append("  Metadatas: ").Append(Metadatas).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
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
            return this.Equals(input as AutoTaskExtendRequest);
        }

        /// <summary>
        /// Returns true if AutoTaskExtendRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AutoTaskExtendRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AutoTaskExtendRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Action == input.Action ||
                    this.Action.Equals(input.Action)
                ) && 
                (
                    this.ExtendDuration == input.ExtendDuration ||
                    this.ExtendDuration.Equals(input.ExtendDuration)
                ) && 
                (
                    this.ExtendDurationType == input.ExtendDurationType ||
                    this.ExtendDurationType.Equals(input.ExtendDurationType)
                ) && 
                (
                    this.TaskId == input.TaskId ||
                    (this.TaskId != null &&
                    this.TaskId.Equals(input.TaskId))
                ) && 
                (
                    this.Metadatas == input.Metadatas ||
                    this.Metadatas != null &&
                    input.Metadatas != null &&
                    this.Metadatas.SequenceEqual(input.Metadatas)
                ) && 
                (
                    this.Comments == input.Comments ||
                    (this.Comments != null &&
                    this.Comments.Equals(input.Comments))
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
                hashCode = hashCode * 59 + this.Action.GetHashCode();
                hashCode = hashCode * 59 + this.ExtendDuration.GetHashCode();
                hashCode = hashCode * 59 + this.ExtendDurationType.GetHashCode();
                if (this.TaskId != null)
                    hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                if (this.Metadatas != null)
                    hashCode = hashCode * 59 + this.Metadatas.GetHashCode();
                if (this.Comments != null)
                    hashCode = hashCode * 59 + this.Comments.GetHashCode();
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
