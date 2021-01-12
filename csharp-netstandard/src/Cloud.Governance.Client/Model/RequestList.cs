

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
    /// RequestList
    /// </summary>
    [DataContract(Name = "RequestList")]
    public partial class RequestList : IEquatable<RequestList>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ServiceType
        /// </summary>
        [DataMember(Name = "serviceType", EmitDefaultValue = false)]
        public ServiceType? ServiceType { get; set; }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public RequestProgressStatus? Status { get; set; }
        /// <summary>
        /// Gets or Sets ProcessStatus
        /// </summary>
        [DataMember(Name = "processStatus", EmitDefaultValue = false)]
        public ApiRequestProgressStatus? ProcessStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestList" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="serviceId">serviceId.</param>
        /// <param name="serviceName">serviceName.</param>
        /// <param name="serviceType">serviceType.</param>
        /// <param name="serviceTypeDescription">serviceTypeDescription.</param>
        /// <param name="ticketNumber">ticketNumber.</param>
        /// <param name="summary">summary.</param>
        /// <param name="status">status.</param>
        /// <param name="processStatus">processStatus.</param>
        /// <param name="statusDescription">statusDescription.</param>
        /// <param name="modified">modified.</param>
        /// <param name="submitStatus">submitStatus.</param>
        /// <param name="assigned">assigned.</param>
        /// <param name="serviceAdmin">serviceAdmin.</param>
        /// <param name="enabledCopy">enabledCopy.</param>
        /// <param name="questionnaireId">questionnaireId.</param>
        public RequestList(Guid id = default(Guid), Guid serviceId = default(Guid), string serviceName = default(string), ServiceType? serviceType = default(ServiceType?), string serviceTypeDescription = default(string), int ticketNumber = default(int), string summary = default(string), RequestProgressStatus? status = default(RequestProgressStatus?), ApiRequestProgressStatus? processStatus = default(ApiRequestProgressStatus?), string statusDescription = default(string), DateTime modified = default(DateTime), int submitStatus = default(int), string assigned = default(string), string serviceAdmin = default(string), bool enabledCopy = default(bool), Guid questionnaireId = default(Guid))
        {
            this.Id = id;
            this.ServiceId = serviceId;
            this.ServiceName = serviceName;
            this.ServiceType = serviceType;
            this.ServiceTypeDescription = serviceTypeDescription;
            this.TicketNumber = ticketNumber;
            this.Summary = summary;
            this.Status = status;
            this.ProcessStatus = processStatus;
            this.StatusDescription = statusDescription;
            this.Modified = modified;
            this.SubmitStatus = submitStatus;
            this.Assigned = assigned;
            this.ServiceAdmin = serviceAdmin;
            this.EnabledCopy = enabledCopy;
            this.QuestionnaireId = questionnaireId;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets ServiceId
        /// </summary>
        [DataMember(Name = "serviceId", EmitDefaultValue = false)]
        public Guid ServiceId { get; set; }

        /// <summary>
        /// Gets or Sets ServiceName
        /// </summary>
        [DataMember(Name = "serviceName", EmitDefaultValue = true)]
        public string ServiceName { get; set; }

        /// <summary>
        /// Gets or Sets ServiceTypeDescription
        /// </summary>
        [DataMember(Name = "serviceTypeDescription", EmitDefaultValue = true)]
        public string ServiceTypeDescription { get; set; }

        /// <summary>
        /// Gets or Sets TicketNumber
        /// </summary>
        [DataMember(Name = "ticketNumber", EmitDefaultValue = false)]
        public int TicketNumber { get; set; }

        /// <summary>
        /// Gets or Sets Summary
        /// </summary>
        [DataMember(Name = "summary", EmitDefaultValue = true)]
        public string Summary { get; set; }

        /// <summary>
        /// Gets or Sets StatusDescription
        /// </summary>
        [DataMember(Name = "statusDescription", EmitDefaultValue = true)]
        public string StatusDescription { get; set; }

        /// <summary>
        /// Gets or Sets Modified
        /// </summary>
        [DataMember(Name = "modified", EmitDefaultValue = false)]
        public DateTime Modified { get; set; }

        /// <summary>
        /// Gets or Sets SubmitStatus
        /// </summary>
        [DataMember(Name = "submitStatus", EmitDefaultValue = false)]
        public int SubmitStatus { get; set; }

        /// <summary>
        /// Gets or Sets Assigned
        /// </summary>
        [DataMember(Name = "assigned", EmitDefaultValue = true)]
        public string Assigned { get; set; }

        /// <summary>
        /// Gets or Sets ServiceAdmin
        /// </summary>
        [DataMember(Name = "serviceAdmin", EmitDefaultValue = true)]
        public string ServiceAdmin { get; set; }

        /// <summary>
        /// Gets or Sets EnabledCopy
        /// </summary>
        [DataMember(Name = "enabledCopy", EmitDefaultValue = false)]
        public bool EnabledCopy { get; set; }

        /// <summary>
        /// Gets or Sets QuestionnaireId
        /// </summary>
        [DataMember(Name = "questionnaireId", EmitDefaultValue = false)]
        public Guid QuestionnaireId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RequestList {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ServiceId: ").Append(ServiceId).Append("\n");
            sb.Append("  ServiceName: ").Append(ServiceName).Append("\n");
            sb.Append("  ServiceType: ").Append(ServiceType).Append("\n");
            sb.Append("  ServiceTypeDescription: ").Append(ServiceTypeDescription).Append("\n");
            sb.Append("  TicketNumber: ").Append(TicketNumber).Append("\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ProcessStatus: ").Append(ProcessStatus).Append("\n");
            sb.Append("  StatusDescription: ").Append(StatusDescription).Append("\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
            sb.Append("  SubmitStatus: ").Append(SubmitStatus).Append("\n");
            sb.Append("  Assigned: ").Append(Assigned).Append("\n");
            sb.Append("  ServiceAdmin: ").Append(ServiceAdmin).Append("\n");
            sb.Append("  EnabledCopy: ").Append(EnabledCopy).Append("\n");
            sb.Append("  QuestionnaireId: ").Append(QuestionnaireId).Append("\n");
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
            return this.Equals(input as RequestList);
        }

        /// <summary>
        /// Returns true if RequestList instances are equal
        /// </summary>
        /// <param name="input">Instance of RequestList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RequestList input)
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
                    this.ServiceId == input.ServiceId ||
                    (this.ServiceId != null &&
                    this.ServiceId.Equals(input.ServiceId))
                ) && 
                (
                    this.ServiceName == input.ServiceName ||
                    (this.ServiceName != null &&
                    this.ServiceName.Equals(input.ServiceName))
                ) && 
                (
                    this.ServiceType == input.ServiceType ||
                    this.ServiceType.Equals(input.ServiceType)
                ) && 
                (
                    this.ServiceTypeDescription == input.ServiceTypeDescription ||
                    (this.ServiceTypeDescription != null &&
                    this.ServiceTypeDescription.Equals(input.ServiceTypeDescription))
                ) && 
                (
                    this.TicketNumber == input.TicketNumber ||
                    this.TicketNumber.Equals(input.TicketNumber)
                ) && 
                (
                    this.Summary == input.Summary ||
                    (this.Summary != null &&
                    this.Summary.Equals(input.Summary))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.ProcessStatus == input.ProcessStatus ||
                    this.ProcessStatus.Equals(input.ProcessStatus)
                ) && 
                (
                    this.StatusDescription == input.StatusDescription ||
                    (this.StatusDescription != null &&
                    this.StatusDescription.Equals(input.StatusDescription))
                ) && 
                (
                    this.Modified == input.Modified ||
                    (this.Modified != null &&
                    this.Modified.Equals(input.Modified))
                ) && 
                (
                    this.SubmitStatus == input.SubmitStatus ||
                    this.SubmitStatus.Equals(input.SubmitStatus)
                ) && 
                (
                    this.Assigned == input.Assigned ||
                    (this.Assigned != null &&
                    this.Assigned.Equals(input.Assigned))
                ) && 
                (
                    this.ServiceAdmin == input.ServiceAdmin ||
                    (this.ServiceAdmin != null &&
                    this.ServiceAdmin.Equals(input.ServiceAdmin))
                ) && 
                (
                    this.EnabledCopy == input.EnabledCopy ||
                    this.EnabledCopy.Equals(input.EnabledCopy)
                ) && 
                (
                    this.QuestionnaireId == input.QuestionnaireId ||
                    (this.QuestionnaireId != null &&
                    this.QuestionnaireId.Equals(input.QuestionnaireId))
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
                if (this.ServiceId != null)
                    hashCode = hashCode * 59 + this.ServiceId.GetHashCode();
                if (this.ServiceName != null)
                    hashCode = hashCode * 59 + this.ServiceName.GetHashCode();
                hashCode = hashCode * 59 + this.ServiceType.GetHashCode();
                if (this.ServiceTypeDescription != null)
                    hashCode = hashCode * 59 + this.ServiceTypeDescription.GetHashCode();
                hashCode = hashCode * 59 + this.TicketNumber.GetHashCode();
                if (this.Summary != null)
                    hashCode = hashCode * 59 + this.Summary.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                hashCode = hashCode * 59 + this.ProcessStatus.GetHashCode();
                if (this.StatusDescription != null)
                    hashCode = hashCode * 59 + this.StatusDescription.GetHashCode();
                if (this.Modified != null)
                    hashCode = hashCode * 59 + this.Modified.GetHashCode();
                hashCode = hashCode * 59 + this.SubmitStatus.GetHashCode();
                if (this.Assigned != null)
                    hashCode = hashCode * 59 + this.Assigned.GetHashCode();
                if (this.ServiceAdmin != null)
                    hashCode = hashCode * 59 + this.ServiceAdmin.GetHashCode();
                hashCode = hashCode * 59 + this.EnabledCopy.GetHashCode();
                if (this.QuestionnaireId != null)
                    hashCode = hashCode * 59 + this.QuestionnaireId.GetHashCode();
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
