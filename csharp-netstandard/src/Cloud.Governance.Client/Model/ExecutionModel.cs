

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
    /// ExecutionModel
    /// </summary>
    [DataContract(Name = "ExecutionModel")]
    public partial class ExecutionModel : IEquatable<ExecutionModel>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets WebServiceAuthenticationType
        /// </summary>
        [DataMember(Name = "webServiceAuthenticationType", EmitDefaultValue = false)]
        public WebServiceAuthenticationType? WebServiceAuthenticationType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutionModel" /> class.
        /// </summary>
        /// <param name="enabled">enabled (default to false).</param>
        /// <param name="webServiceAddress">webServiceAddress.</param>
        /// <param name="webServiceAuthenticationType">webServiceAuthenticationType.</param>
        /// <param name="webServiceAppClientId">webServiceAppClientId.</param>
        /// <param name="methodName">methodName.</param>
        /// <param name="arguments">arguments.</param>
        public ExecutionModel(bool enabled = false, string webServiceAddress = default(string), WebServiceAuthenticationType? webServiceAuthenticationType = default(WebServiceAuthenticationType?), string webServiceAppClientId = default(string), string methodName = default(string), List<ExecutionParameter> arguments = default(List<ExecutionParameter>))
        {
            this.Enabled = enabled;
            this.WebServiceAddress = webServiceAddress;
            this.WebServiceAuthenticationType = webServiceAuthenticationType;
            this.WebServiceAppClientId = webServiceAppClientId;
            this.MethodName = methodName;
            this.Arguments = arguments;
        }

        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name = "enabled", EmitDefaultValue = false)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or Sets WebServiceAddress
        /// </summary>
        [DataMember(Name = "webServiceAddress", EmitDefaultValue = true)]
        public string WebServiceAddress { get; set; }

        /// <summary>
        /// Gets or Sets WebServiceAppClientId
        /// </summary>
        [DataMember(Name = "webServiceAppClientId", EmitDefaultValue = true)]
        public string WebServiceAppClientId { get; set; }

        /// <summary>
        /// Gets or Sets MethodName
        /// </summary>
        [DataMember(Name = "methodName", EmitDefaultValue = true)]
        public string MethodName { get; set; }

        /// <summary>
        /// Gets or Sets Arguments
        /// </summary>
        [DataMember(Name = "arguments", EmitDefaultValue = true)]
        public List<ExecutionParameter> Arguments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExecutionModel {\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  WebServiceAddress: ").Append(WebServiceAddress).Append("\n");
            sb.Append("  WebServiceAuthenticationType: ").Append(WebServiceAuthenticationType).Append("\n");
            sb.Append("  WebServiceAppClientId: ").Append(WebServiceAppClientId).Append("\n");
            sb.Append("  MethodName: ").Append(MethodName).Append("\n");
            sb.Append("  Arguments: ").Append(Arguments).Append("\n");
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
            return this.Equals(input as ExecutionModel);
        }

        /// <summary>
        /// Returns true if ExecutionModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ExecutionModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExecutionModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Enabled == input.Enabled ||
                    this.Enabled.Equals(input.Enabled)
                ) && 
                (
                    this.WebServiceAddress == input.WebServiceAddress ||
                    (this.WebServiceAddress != null &&
                    this.WebServiceAddress.Equals(input.WebServiceAddress))
                ) && 
                (
                    this.WebServiceAuthenticationType == input.WebServiceAuthenticationType ||
                    this.WebServiceAuthenticationType.Equals(input.WebServiceAuthenticationType)
                ) && 
                (
                    this.WebServiceAppClientId == input.WebServiceAppClientId ||
                    (this.WebServiceAppClientId != null &&
                    this.WebServiceAppClientId.Equals(input.WebServiceAppClientId))
                ) && 
                (
                    this.MethodName == input.MethodName ||
                    (this.MethodName != null &&
                    this.MethodName.Equals(input.MethodName))
                ) && 
                (
                    this.Arguments == input.Arguments ||
                    this.Arguments != null &&
                    input.Arguments != null &&
                    this.Arguments.SequenceEqual(input.Arguments)
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
                if (this.WebServiceAddress != null)
                    hashCode = hashCode * 59 + this.WebServiceAddress.GetHashCode();
                hashCode = hashCode * 59 + this.WebServiceAuthenticationType.GetHashCode();
                if (this.WebServiceAppClientId != null)
                    hashCode = hashCode * 59 + this.WebServiceAppClientId.GetHashCode();
                if (this.MethodName != null)
                    hashCode = hashCode * 59 + this.MethodName.GetHashCode();
                if (this.Arguments != null)
                    hashCode = hashCode * 59 + this.Arguments.GetHashCode();
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
