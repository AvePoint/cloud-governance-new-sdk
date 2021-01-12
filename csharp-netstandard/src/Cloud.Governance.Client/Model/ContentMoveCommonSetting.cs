

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
    /// ContentMoveCommonSetting
    /// </summary>
    [DataContract(Name = "ContentMoveCommonSetting")]
    public partial class ContentMoveCommonSetting : IEquatable<ContentMoveCommonSetting>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets DeleteType
        /// </summary>
        [DataMember(Name = "deleteType", EmitDefaultValue = false)]
        public DeleteType? DeleteType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentMoveCommonSetting" /> class.
        /// </summary>
        /// <param name="isIncludeVersions">isIncludeVersions.</param>
        /// <param name="isIncludeWorkflowDefinition">isIncludeWorkflowDefinition.</param>
        /// <param name="isDisableInformationRightsManagement">isDisableInformationRightsManagement.</param>
        /// <param name="isPreserveNullColumnValues">isPreserveNullColumnValues.</param>
        /// <param name="isKeepModifiedByAndModifiedTime">isKeepModifiedByAndModifiedTime.</param>
        /// <param name="profileMappings">profileMappings.</param>
        /// <param name="backupSettings">backupSettings.</param>
        /// <param name="conflictResolutionSettings">conflictResolutionSettings.</param>
        /// <param name="filterPolicy">filterPolicy.</param>
        /// <param name="deleteType">deleteType.</param>
        /// <param name="isDeleteCheckedFiles">isDeleteCheckedFiles.</param>
        public ContentMoveCommonSetting(bool isIncludeVersions = default(bool), bool isIncludeWorkflowDefinition = default(bool), bool isDisableInformationRightsManagement = default(bool), bool isPreserveNullColumnValues = default(bool), bool isKeepModifiedByAndModifiedTime = default(bool), ContentMoveProfileMappings profileMappings = default(ContentMoveProfileMappings), BackupEnvironmentSetting backupSettings = default(BackupEnvironmentSetting), ConflictResolutionSetting conflictResolutionSettings = default(ConflictResolutionSetting), GuidModel filterPolicy = default(GuidModel), DeleteType? deleteType = default(DeleteType?), bool isDeleteCheckedFiles = default(bool))
        {
            this.IsIncludeVersions = isIncludeVersions;
            this.IsIncludeWorkflowDefinition = isIncludeWorkflowDefinition;
            this.IsDisableInformationRightsManagement = isDisableInformationRightsManagement;
            this.IsPreserveNullColumnValues = isPreserveNullColumnValues;
            this.IsKeepModifiedByAndModifiedTime = isKeepModifiedByAndModifiedTime;
            this.ProfileMappings = profileMappings;
            this.BackupSettings = backupSettings;
            this.ConflictResolutionSettings = conflictResolutionSettings;
            this.FilterPolicy = filterPolicy;
            this.DeleteType = deleteType;
            this.IsDeleteCheckedFiles = isDeleteCheckedFiles;
        }

        /// <summary>
        /// Gets or Sets IsIncludeVersions
        /// </summary>
        [DataMember(Name = "isIncludeVersions", EmitDefaultValue = false)]
        public bool IsIncludeVersions { get; set; }

        /// <summary>
        /// Gets or Sets IsIncludeWorkflowDefinition
        /// </summary>
        [DataMember(Name = "isIncludeWorkflowDefinition", EmitDefaultValue = false)]
        public bool IsIncludeWorkflowDefinition { get; set; }

        /// <summary>
        /// Gets or Sets IsDisableInformationRightsManagement
        /// </summary>
        [DataMember(Name = "isDisableInformationRightsManagement", EmitDefaultValue = false)]
        public bool IsDisableInformationRightsManagement { get; set; }

        /// <summary>
        /// Gets or Sets IsPreserveNullColumnValues
        /// </summary>
        [DataMember(Name = "isPreserveNullColumnValues", EmitDefaultValue = false)]
        public bool IsPreserveNullColumnValues { get; set; }

        /// <summary>
        /// Gets or Sets IsKeepModifiedByAndModifiedTime
        /// </summary>
        [DataMember(Name = "isKeepModifiedByAndModifiedTime", EmitDefaultValue = false)]
        public bool IsKeepModifiedByAndModifiedTime { get; set; }

        /// <summary>
        /// Gets or Sets ProfileMappings
        /// </summary>
        [DataMember(Name = "profileMappings", EmitDefaultValue = true)]
        public ContentMoveProfileMappings ProfileMappings { get; set; }

        /// <summary>
        /// Gets or Sets BackupSettings
        /// </summary>
        [DataMember(Name = "backupSettings", EmitDefaultValue = true)]
        public BackupEnvironmentSetting BackupSettings { get; set; }

        /// <summary>
        /// Gets or Sets ConflictResolutionSettings
        /// </summary>
        [DataMember(Name = "conflictResolutionSettings", EmitDefaultValue = true)]
        public ConflictResolutionSetting ConflictResolutionSettings { get; set; }

        /// <summary>
        /// Gets or Sets FilterPolicy
        /// </summary>
        [DataMember(Name = "filterPolicy", EmitDefaultValue = true)]
        public GuidModel FilterPolicy { get; set; }

        /// <summary>
        /// Gets or Sets IsDeleteCheckedFiles
        /// </summary>
        [DataMember(Name = "isDeleteCheckedFiles", EmitDefaultValue = false)]
        public bool IsDeleteCheckedFiles { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContentMoveCommonSetting {\n");
            sb.Append("  IsIncludeVersions: ").Append(IsIncludeVersions).Append("\n");
            sb.Append("  IsIncludeWorkflowDefinition: ").Append(IsIncludeWorkflowDefinition).Append("\n");
            sb.Append("  IsDisableInformationRightsManagement: ").Append(IsDisableInformationRightsManagement).Append("\n");
            sb.Append("  IsPreserveNullColumnValues: ").Append(IsPreserveNullColumnValues).Append("\n");
            sb.Append("  IsKeepModifiedByAndModifiedTime: ").Append(IsKeepModifiedByAndModifiedTime).Append("\n");
            sb.Append("  ProfileMappings: ").Append(ProfileMappings).Append("\n");
            sb.Append("  BackupSettings: ").Append(BackupSettings).Append("\n");
            sb.Append("  ConflictResolutionSettings: ").Append(ConflictResolutionSettings).Append("\n");
            sb.Append("  FilterPolicy: ").Append(FilterPolicy).Append("\n");
            sb.Append("  DeleteType: ").Append(DeleteType).Append("\n");
            sb.Append("  IsDeleteCheckedFiles: ").Append(IsDeleteCheckedFiles).Append("\n");
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
            return this.Equals(input as ContentMoveCommonSetting);
        }

        /// <summary>
        /// Returns true if ContentMoveCommonSetting instances are equal
        /// </summary>
        /// <param name="input">Instance of ContentMoveCommonSetting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContentMoveCommonSetting input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsIncludeVersions == input.IsIncludeVersions ||
                    this.IsIncludeVersions.Equals(input.IsIncludeVersions)
                ) && 
                (
                    this.IsIncludeWorkflowDefinition == input.IsIncludeWorkflowDefinition ||
                    this.IsIncludeWorkflowDefinition.Equals(input.IsIncludeWorkflowDefinition)
                ) && 
                (
                    this.IsDisableInformationRightsManagement == input.IsDisableInformationRightsManagement ||
                    this.IsDisableInformationRightsManagement.Equals(input.IsDisableInformationRightsManagement)
                ) && 
                (
                    this.IsPreserveNullColumnValues == input.IsPreserveNullColumnValues ||
                    this.IsPreserveNullColumnValues.Equals(input.IsPreserveNullColumnValues)
                ) && 
                (
                    this.IsKeepModifiedByAndModifiedTime == input.IsKeepModifiedByAndModifiedTime ||
                    this.IsKeepModifiedByAndModifiedTime.Equals(input.IsKeepModifiedByAndModifiedTime)
                ) && 
                (
                    this.ProfileMappings == input.ProfileMappings ||
                    (this.ProfileMappings != null &&
                    this.ProfileMappings.Equals(input.ProfileMappings))
                ) && 
                (
                    this.BackupSettings == input.BackupSettings ||
                    (this.BackupSettings != null &&
                    this.BackupSettings.Equals(input.BackupSettings))
                ) && 
                (
                    this.ConflictResolutionSettings == input.ConflictResolutionSettings ||
                    (this.ConflictResolutionSettings != null &&
                    this.ConflictResolutionSettings.Equals(input.ConflictResolutionSettings))
                ) && 
                (
                    this.FilterPolicy == input.FilterPolicy ||
                    (this.FilterPolicy != null &&
                    this.FilterPolicy.Equals(input.FilterPolicy))
                ) && 
                (
                    this.DeleteType == input.DeleteType ||
                    this.DeleteType.Equals(input.DeleteType)
                ) && 
                (
                    this.IsDeleteCheckedFiles == input.IsDeleteCheckedFiles ||
                    this.IsDeleteCheckedFiles.Equals(input.IsDeleteCheckedFiles)
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
                hashCode = hashCode * 59 + this.IsIncludeVersions.GetHashCode();
                hashCode = hashCode * 59 + this.IsIncludeWorkflowDefinition.GetHashCode();
                hashCode = hashCode * 59 + this.IsDisableInformationRightsManagement.GetHashCode();
                hashCode = hashCode * 59 + this.IsPreserveNullColumnValues.GetHashCode();
                hashCode = hashCode * 59 + this.IsKeepModifiedByAndModifiedTime.GetHashCode();
                if (this.ProfileMappings != null)
                    hashCode = hashCode * 59 + this.ProfileMappings.GetHashCode();
                if (this.BackupSettings != null)
                    hashCode = hashCode * 59 + this.BackupSettings.GetHashCode();
                if (this.ConflictResolutionSettings != null)
                    hashCode = hashCode * 59 + this.ConflictResolutionSettings.GetHashCode();
                if (this.FilterPolicy != null)
                    hashCode = hashCode * 59 + this.FilterPolicy.GetHashCode();
                hashCode = hashCode * 59 + this.DeleteType.GetHashCode();
                hashCode = hashCode * 59 + this.IsDeleteCheckedFiles.GetHashCode();
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
