

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
    /// TaskHookMessage
    /// </summary>
    [DataContract(Name = "TaskHookMessage")]
    public partial class TaskHookMessage : IEquatable<TaskHookMessage>, IValidatableObject
    {
        /// <summary>
        /// Type enum of service that is used to submit this request
        /// </summary>
        /// <value>Type enum of service that is used to submit this request</value>
        [DataMember(Name = "serviceTypeEnum", EmitDefaultValue = false)]
        public ServiceType? ServiceTypeEnum { get; set; }
        /// <summary>
        /// Event type that being triggered, available values and corresponding messages:    RequestSubmitted,RequestCompleted,RequestCancelled - -- -&gt; RequestHookMessage  TaskCreated,TaskApproved,TaskRejected,ErrorTaskCreated,TaskRetried,TaskSkipped - -- -&gt; TaskHookMessage  RenewalSuccess RenewalException,RenewalOverdue - -- -&gt; RenewalTaskHookMessage  FullyAutoImportSuccess,ConfirmDetailSuccess - -- -&gt; AutoImportProcessHookMessage  ElectionCompleted,ElectionOverdue - --&gt; ElectionHookMessage  LifecycleInactiveTaskCreated,LifecycleLeaseTaskCreated - -- -&gt; ElectionOverdue
        /// </summary>
        /// <value>Event type that being triggered, available values and corresponding messages:    RequestSubmitted,RequestCompleted,RequestCancelled - -- -&gt; RequestHookMessage  TaskCreated,TaskApproved,TaskRejected,ErrorTaskCreated,TaskRetried,TaskSkipped - -- -&gt; TaskHookMessage  RenewalSuccess RenewalException,RenewalOverdue - -- -&gt; RenewalTaskHookMessage  FullyAutoImportSuccess,ConfirmDetailSuccess - -- -&gt; AutoImportProcessHookMessage  ElectionCompleted,ElectionOverdue - --&gt; ElectionHookMessage  LifecycleInactiveTaskCreated,LifecycleLeaseTaskCreated - -- -&gt; ElectionOverdue</value>
        [DataMember(Name = "triggerType", EmitDefaultValue = false)]
        public TriggerType? TriggerType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskHookMessage" /> class.
        /// </summary>
        /// <param name="taskId">Unique ID of the task.</param>
        /// <param name="taskLink">Link of the task.</param>
        /// <param name="assigneeDisplayName">Display name of the task assignee.</param>
        /// <param name="assigneeIdentityName">User principal name of the task assignee.</param>
        /// <param name="approverDisplayName">Display name of the task assignee.</param>
        /// <param name="approverIdentityName">User principal name of the task assignee.</param>
        /// <param name="message">Task comments or error message.</param>
        /// <param name="requestId">Ticket number of the request (default to 0).</param>
        /// <param name="requestGuid">Unique ID of the request.</param>
        /// <param name="requesterIdentityName">User principal name of the requester.</param>
        /// <param name="requester">Display name of the requester.</param>
        /// <param name="serviceType">Type of service that is used to submit this request.</param>
        /// <param name="serviceTypeEnum">Type enum of service that is used to submit this request.</param>
        /// <param name="triggerType">Event type that being triggered, available values and corresponding messages:    RequestSubmitted,RequestCompleted,RequestCancelled - -- -&gt; RequestHookMessage  TaskCreated,TaskApproved,TaskRejected,ErrorTaskCreated,TaskRetried,TaskSkipped - -- -&gt; TaskHookMessage  RenewalSuccess RenewalException,RenewalOverdue - -- -&gt; RenewalTaskHookMessage  FullyAutoImportSuccess,ConfirmDetailSuccess - -- -&gt; AutoImportProcessHookMessage  ElectionCompleted,ElectionOverdue - --&gt; ElectionHookMessage  LifecycleInactiveTaskCreated,LifecycleLeaseTaskCreated - -- -&gt; ElectionOverdue.</param>
        /// <param name="triggerTime">Time that the webhook is triggered.</param>
        /// <param name="objectUrl">URL of the workspace.</param>
        /// <param name="objectId">The unique ID of the workspace.</param>
        /// <param name="summary">Request or task summary.</param>
        public TaskHookMessage(Guid? taskId = default(Guid?), string taskLink = default(string), string assigneeDisplayName = default(string), string assigneeIdentityName = default(string), string approverDisplayName = default(string), string approverIdentityName = default(string), string message = default(string), int requestId = 0, Guid? requestGuid = default(Guid?), string requesterIdentityName = default(string), string requester = default(string), string serviceType = default(string), ServiceType? serviceTypeEnum = default(ServiceType?), TriggerType? triggerType = default(TriggerType?), DateTime triggerTime = default(DateTime), string objectUrl = default(string), Guid? objectId = default(Guid?), string summary = default(string))
        {
            this.TaskId = taskId;
            this.TaskLink = taskLink;
            this.AssigneeDisplayName = assigneeDisplayName;
            this.AssigneeIdentityName = assigneeIdentityName;
            this.ApproverDisplayName = approverDisplayName;
            this.ApproverIdentityName = approverIdentityName;
            this.Message = message;
            this.RequestId = requestId;
            this.RequestGuid = requestGuid;
            this.RequesterIdentityName = requesterIdentityName;
            this.Requester = requester;
            this.ServiceType = serviceType;
            this.ServiceTypeEnum = serviceTypeEnum;
            this.TriggerType = triggerType;
            this.TriggerTime = triggerTime;
            this.ObjectUrl = objectUrl;
            this.ObjectId = objectId;
            this.Summary = summary;
        }

        /// <summary>
        /// Unique ID of the task
        /// </summary>
        /// <value>Unique ID of the task</value>
        [DataMember(Name = "taskId", EmitDefaultValue = true)]
        public Guid? TaskId { get; set; }

        /// <summary>
        /// Link of the task
        /// </summary>
        /// <value>Link of the task</value>
        [DataMember(Name = "taskLink", EmitDefaultValue = true)]
        public string TaskLink { get; set; }

        /// <summary>
        /// Display name of the task assignee
        /// </summary>
        /// <value>Display name of the task assignee</value>
        [DataMember(Name = "assigneeDisplayName", EmitDefaultValue = true)]
        public string AssigneeDisplayName { get; set; }

        /// <summary>
        /// User principal name of the task assignee
        /// </summary>
        /// <value>User principal name of the task assignee</value>
        [DataMember(Name = "assigneeIdentityName", EmitDefaultValue = true)]
        public string AssigneeIdentityName { get; set; }

        /// <summary>
        /// Display name of the task assignee
        /// </summary>
        /// <value>Display name of the task assignee</value>
        [DataMember(Name = "approverDisplayName", EmitDefaultValue = true)]
        public string ApproverDisplayName { get; set; }

        /// <summary>
        /// User principal name of the task assignee
        /// </summary>
        /// <value>User principal name of the task assignee</value>
        [DataMember(Name = "approverIdentityName", EmitDefaultValue = true)]
        public string ApproverIdentityName { get; set; }

        /// <summary>
        /// Task comments or error message
        /// </summary>
        /// <value>Task comments or error message</value>
        [DataMember(Name = "message", EmitDefaultValue = true)]
        public string Message { get; set; }

        /// <summary>
        /// Ticket number of the request
        /// </summary>
        /// <value>Ticket number of the request</value>
        [DataMember(Name = "requestId", EmitDefaultValue = false)]
        public int RequestId { get; set; }

        /// <summary>
        /// Unique ID of the request
        /// </summary>
        /// <value>Unique ID of the request</value>
        [DataMember(Name = "requestGuid", EmitDefaultValue = true)]
        public Guid? RequestGuid { get; set; }

        /// <summary>
        /// User principal name of the requester
        /// </summary>
        /// <value>User principal name of the requester</value>
        [DataMember(Name = "requesterIdentityName", EmitDefaultValue = true)]
        public string RequesterIdentityName { get; set; }

        /// <summary>
        /// Display name of the requester
        /// </summary>
        /// <value>Display name of the requester</value>
        [DataMember(Name = "requester", EmitDefaultValue = true)]
        public string Requester { get; set; }

        /// <summary>
        /// Type of service that is used to submit this request
        /// </summary>
        /// <value>Type of service that is used to submit this request</value>
        [DataMember(Name = "serviceType", EmitDefaultValue = true)]
        public string ServiceType { get; set; }

        /// <summary>
        /// Time that the webhook is triggered
        /// </summary>
        /// <value>Time that the webhook is triggered</value>
        [DataMember(Name = "triggerTime", EmitDefaultValue = false)]
        public DateTime TriggerTime { get; set; }

        /// <summary>
        /// URL of the workspace
        /// </summary>
        /// <value>URL of the workspace</value>
        [DataMember(Name = "objectUrl", EmitDefaultValue = true)]
        public string ObjectUrl { get; set; }

        /// <summary>
        /// The unique ID of the workspace
        /// </summary>
        /// <value>The unique ID of the workspace</value>
        [DataMember(Name = "objectId", EmitDefaultValue = true)]
        public Guid? ObjectId { get; set; }

        /// <summary>
        /// Request or task summary
        /// </summary>
        /// <value>Request or task summary</value>
        [DataMember(Name = "summary", EmitDefaultValue = true)]
        public string Summary { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskHookMessage {\n");
            sb.Append("  TaskId: ").Append(TaskId).Append("\n");
            sb.Append("  TaskLink: ").Append(TaskLink).Append("\n");
            sb.Append("  AssigneeDisplayName: ").Append(AssigneeDisplayName).Append("\n");
            sb.Append("  AssigneeIdentityName: ").Append(AssigneeIdentityName).Append("\n");
            sb.Append("  ApproverDisplayName: ").Append(ApproverDisplayName).Append("\n");
            sb.Append("  ApproverIdentityName: ").Append(ApproverIdentityName).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
            sb.Append("  RequestGuid: ").Append(RequestGuid).Append("\n");
            sb.Append("  RequesterIdentityName: ").Append(RequesterIdentityName).Append("\n");
            sb.Append("  Requester: ").Append(Requester).Append("\n");
            sb.Append("  ServiceType: ").Append(ServiceType).Append("\n");
            sb.Append("  ServiceTypeEnum: ").Append(ServiceTypeEnum).Append("\n");
            sb.Append("  TriggerType: ").Append(TriggerType).Append("\n");
            sb.Append("  TriggerTime: ").Append(TriggerTime).Append("\n");
            sb.Append("  ObjectUrl: ").Append(ObjectUrl).Append("\n");
            sb.Append("  ObjectId: ").Append(ObjectId).Append("\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
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
            return this.Equals(input as TaskHookMessage);
        }

        /// <summary>
        /// Returns true if TaskHookMessage instances are equal
        /// </summary>
        /// <param name="input">Instance of TaskHookMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskHookMessage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TaskId == input.TaskId ||
                    (this.TaskId != null &&
                    this.TaskId.Equals(input.TaskId))
                ) && 
                (
                    this.TaskLink == input.TaskLink ||
                    (this.TaskLink != null &&
                    this.TaskLink.Equals(input.TaskLink))
                ) && 
                (
                    this.AssigneeDisplayName == input.AssigneeDisplayName ||
                    (this.AssigneeDisplayName != null &&
                    this.AssigneeDisplayName.Equals(input.AssigneeDisplayName))
                ) && 
                (
                    this.AssigneeIdentityName == input.AssigneeIdentityName ||
                    (this.AssigneeIdentityName != null &&
                    this.AssigneeIdentityName.Equals(input.AssigneeIdentityName))
                ) && 
                (
                    this.ApproverDisplayName == input.ApproverDisplayName ||
                    (this.ApproverDisplayName != null &&
                    this.ApproverDisplayName.Equals(input.ApproverDisplayName))
                ) && 
                (
                    this.ApproverIdentityName == input.ApproverIdentityName ||
                    (this.ApproverIdentityName != null &&
                    this.ApproverIdentityName.Equals(input.ApproverIdentityName))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.RequestId == input.RequestId ||
                    this.RequestId.Equals(input.RequestId)
                ) && 
                (
                    this.RequestGuid == input.RequestGuid ||
                    (this.RequestGuid != null &&
                    this.RequestGuid.Equals(input.RequestGuid))
                ) && 
                (
                    this.RequesterIdentityName == input.RequesterIdentityName ||
                    (this.RequesterIdentityName != null &&
                    this.RequesterIdentityName.Equals(input.RequesterIdentityName))
                ) && 
                (
                    this.Requester == input.Requester ||
                    (this.Requester != null &&
                    this.Requester.Equals(input.Requester))
                ) && 
                (
                    this.ServiceType == input.ServiceType ||
                    (this.ServiceType != null &&
                    this.ServiceType.Equals(input.ServiceType))
                ) && 
                (
                    this.ServiceTypeEnum == input.ServiceTypeEnum ||
                    this.ServiceTypeEnum.Equals(input.ServiceTypeEnum)
                ) && 
                (
                    this.TriggerType == input.TriggerType ||
                    this.TriggerType.Equals(input.TriggerType)
                ) && 
                (
                    this.TriggerTime == input.TriggerTime ||
                    (this.TriggerTime != null &&
                    this.TriggerTime.Equals(input.TriggerTime))
                ) && 
                (
                    this.ObjectUrl == input.ObjectUrl ||
                    (this.ObjectUrl != null &&
                    this.ObjectUrl.Equals(input.ObjectUrl))
                ) && 
                (
                    this.ObjectId == input.ObjectId ||
                    (this.ObjectId != null &&
                    this.ObjectId.Equals(input.ObjectId))
                ) && 
                (
                    this.Summary == input.Summary ||
                    (this.Summary != null &&
                    this.Summary.Equals(input.Summary))
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
                if (this.TaskId != null)
                    hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                if (this.TaskLink != null)
                    hashCode = hashCode * 59 + this.TaskLink.GetHashCode();
                if (this.AssigneeDisplayName != null)
                    hashCode = hashCode * 59 + this.AssigneeDisplayName.GetHashCode();
                if (this.AssigneeIdentityName != null)
                    hashCode = hashCode * 59 + this.AssigneeIdentityName.GetHashCode();
                if (this.ApproverDisplayName != null)
                    hashCode = hashCode * 59 + this.ApproverDisplayName.GetHashCode();
                if (this.ApproverIdentityName != null)
                    hashCode = hashCode * 59 + this.ApproverIdentityName.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                if (this.RequestGuid != null)
                    hashCode = hashCode * 59 + this.RequestGuid.GetHashCode();
                if (this.RequesterIdentityName != null)
                    hashCode = hashCode * 59 + this.RequesterIdentityName.GetHashCode();
                if (this.Requester != null)
                    hashCode = hashCode * 59 + this.Requester.GetHashCode();
                if (this.ServiceType != null)
                    hashCode = hashCode * 59 + this.ServiceType.GetHashCode();
                hashCode = hashCode * 59 + this.ServiceTypeEnum.GetHashCode();
                hashCode = hashCode * 59 + this.TriggerType.GetHashCode();
                if (this.TriggerTime != null)
                    hashCode = hashCode * 59 + this.TriggerTime.GetHashCode();
                if (this.ObjectUrl != null)
                    hashCode = hashCode * 59 + this.ObjectUrl.GetHashCode();
                if (this.ObjectId != null)
                    hashCode = hashCode * 59 + this.ObjectId.GetHashCode();
                if (this.Summary != null)
                    hashCode = hashCode * 59 + this.Summary.GetHashCode();
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