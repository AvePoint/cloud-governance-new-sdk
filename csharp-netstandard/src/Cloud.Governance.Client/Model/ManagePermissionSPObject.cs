

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
    /// ManagePermissionSPObject
    /// </summary>
    [DataContract(Name = "ManagePermissionSPObject")]
    public partial class ManagePermissionSPObject : IEquatable<ManagePermissionSPObject>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ParentNodeType
        /// </summary>
        [DataMember(Name = "parentNodeType", EmitDefaultValue = false)]
        public NodeType? ParentNodeType { get; set; }
        /// <summary>
        /// Gets or Sets InheritNodeType
        /// </summary>
        [DataMember(Name = "inheritNodeType", EmitDefaultValue = false)]
        public NodeType? InheritNodeType { get; set; }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public NodeType? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ManagePermissionSPObject" /> class.
        /// </summary>
        /// <param name="parentUrl">parentUrl.</param>
        /// <param name="parentNodeType">parentNodeType.</param>
        /// <param name="siteUrl">siteUrl.</param>
        /// <param name="webUrl">webUrl.</param>
        /// <param name="primaryAdministrator">primaryAdministrator.</param>
        /// <param name="primaryContact">primaryContact.</param>
        /// <param name="secondaryContact">secondaryContact.</param>
        /// <param name="temporaryGroupTitle">temporaryGroupTitle.</param>
        /// <param name="webId">webId.</param>
        /// <param name="siteId">siteId.</param>
        /// <param name="webServerRelativeUrl">webServerRelativeUrl.</param>
        /// <param name="listTitle">listTitle.</param>
        /// <param name="topInheritUrl">topInheritUrl.</param>
        /// <param name="inheritNodeType">inheritNodeType.</param>
        /// <param name="isInheritedPermission">isInheritedPermission (default to false).</param>
        /// <param name="id">id.</param>
        /// <param name="title">title.</param>
        /// <param name="fullUrl">fullUrl.</param>
        /// <param name="type">type.</param>
        public ManagePermissionSPObject(string parentUrl = default(string), NodeType? parentNodeType = default(NodeType?), string siteUrl = default(string), string webUrl = default(string), ApiUser primaryAdministrator = default(ApiUser), ApiUser primaryContact = default(ApiUser), ApiUser secondaryContact = default(ApiUser), string temporaryGroupTitle = default(string), Guid webId = default(Guid), Guid siteId = default(Guid), string webServerRelativeUrl = default(string), string listTitle = default(string), string topInheritUrl = default(string), NodeType? inheritNodeType = default(NodeType?), bool isInheritedPermission = false, Guid id = default(Guid), string title = default(string), string fullUrl = default(string), NodeType? type = default(NodeType?))
        {
            this.ParentUrl = parentUrl;
            this.ParentNodeType = parentNodeType;
            this.SiteUrl = siteUrl;
            this.WebUrl = webUrl;
            this.PrimaryAdministrator = primaryAdministrator;
            this.PrimaryContact = primaryContact;
            this.SecondaryContact = secondaryContact;
            this.TemporaryGroupTitle = temporaryGroupTitle;
            this.WebId = webId;
            this.SiteId = siteId;
            this.WebServerRelativeUrl = webServerRelativeUrl;
            this.ListTitle = listTitle;
            this.TopInheritUrl = topInheritUrl;
            this.InheritNodeType = inheritNodeType;
            this.IsInheritedPermission = isInheritedPermission;
            this.Id = id;
            this.Title = title;
            this.FullUrl = fullUrl;
            this.Type = type;
        }

        /// <summary>
        /// Gets or Sets ParentUrl
        /// </summary>
        [DataMember(Name = "parentUrl", EmitDefaultValue = true)]
        public string ParentUrl { get; set; }

        /// <summary>
        /// Gets or Sets SiteUrl
        /// </summary>
        [DataMember(Name = "siteUrl", EmitDefaultValue = true)]
        public string SiteUrl { get; set; }

        /// <summary>
        /// Gets or Sets WebUrl
        /// </summary>
        [DataMember(Name = "webUrl", EmitDefaultValue = true)]
        public string WebUrl { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryAdministrator
        /// </summary>
        [DataMember(Name = "primaryAdministrator", EmitDefaultValue = true)]
        public ApiUser PrimaryAdministrator { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryContact
        /// </summary>
        [DataMember(Name = "primaryContact", EmitDefaultValue = true)]
        public ApiUser PrimaryContact { get; set; }

        /// <summary>
        /// Gets or Sets SecondaryContact
        /// </summary>
        [DataMember(Name = "secondaryContact", EmitDefaultValue = true)]
        public ApiUser SecondaryContact { get; set; }

        /// <summary>
        /// Gets or Sets TemporaryGroupTitle
        /// </summary>
        [DataMember(Name = "temporaryGroupTitle", EmitDefaultValue = true)]
        public string TemporaryGroupTitle { get; set; }

        /// <summary>
        /// Gets or Sets WebId
        /// </summary>
        [DataMember(Name = "webId", EmitDefaultValue = false)]
        public Guid WebId { get; set; }

        /// <summary>
        /// Gets or Sets SiteId
        /// </summary>
        [DataMember(Name = "siteId", EmitDefaultValue = false)]
        public Guid SiteId { get; set; }

        /// <summary>
        /// Gets or Sets WebServerRelativeUrl
        /// </summary>
        [DataMember(Name = "webServerRelativeUrl", EmitDefaultValue = true)]
        public string WebServerRelativeUrl { get; set; }

        /// <summary>
        /// Gets or Sets ListTitle
        /// </summary>
        [DataMember(Name = "listTitle", EmitDefaultValue = true)]
        public string ListTitle { get; set; }

        /// <summary>
        /// Gets or Sets TopInheritUrl
        /// </summary>
        [DataMember(Name = "topInheritUrl", EmitDefaultValue = true)]
        public string TopInheritUrl { get; set; }

        /// <summary>
        /// Gets or Sets IsInheritedPermission
        /// </summary>
        [DataMember(Name = "isInheritedPermission", EmitDefaultValue = false)]
        public bool IsInheritedPermission { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets FullUrl
        /// </summary>
        [DataMember(Name = "fullUrl", EmitDefaultValue = true)]
        public string FullUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ManagePermissionSPObject {\n");
            sb.Append("  ParentUrl: ").Append(ParentUrl).Append("\n");
            sb.Append("  ParentNodeType: ").Append(ParentNodeType).Append("\n");
            sb.Append("  SiteUrl: ").Append(SiteUrl).Append("\n");
            sb.Append("  WebUrl: ").Append(WebUrl).Append("\n");
            sb.Append("  PrimaryAdministrator: ").Append(PrimaryAdministrator).Append("\n");
            sb.Append("  PrimaryContact: ").Append(PrimaryContact).Append("\n");
            sb.Append("  SecondaryContact: ").Append(SecondaryContact).Append("\n");
            sb.Append("  TemporaryGroupTitle: ").Append(TemporaryGroupTitle).Append("\n");
            sb.Append("  WebId: ").Append(WebId).Append("\n");
            sb.Append("  SiteId: ").Append(SiteId).Append("\n");
            sb.Append("  WebServerRelativeUrl: ").Append(WebServerRelativeUrl).Append("\n");
            sb.Append("  ListTitle: ").Append(ListTitle).Append("\n");
            sb.Append("  TopInheritUrl: ").Append(TopInheritUrl).Append("\n");
            sb.Append("  InheritNodeType: ").Append(InheritNodeType).Append("\n");
            sb.Append("  IsInheritedPermission: ").Append(IsInheritedPermission).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  FullUrl: ").Append(FullUrl).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as ManagePermissionSPObject);
        }

        /// <summary>
        /// Returns true if ManagePermissionSPObject instances are equal
        /// </summary>
        /// <param name="input">Instance of ManagePermissionSPObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ManagePermissionSPObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ParentUrl == input.ParentUrl ||
                    (this.ParentUrl != null &&
                    this.ParentUrl.Equals(input.ParentUrl))
                ) && 
                (
                    this.ParentNodeType == input.ParentNodeType ||
                    this.ParentNodeType.Equals(input.ParentNodeType)
                ) && 
                (
                    this.SiteUrl == input.SiteUrl ||
                    (this.SiteUrl != null &&
                    this.SiteUrl.Equals(input.SiteUrl))
                ) && 
                (
                    this.WebUrl == input.WebUrl ||
                    (this.WebUrl != null &&
                    this.WebUrl.Equals(input.WebUrl))
                ) && 
                (
                    this.PrimaryAdministrator == input.PrimaryAdministrator ||
                    (this.PrimaryAdministrator != null &&
                    this.PrimaryAdministrator.Equals(input.PrimaryAdministrator))
                ) && 
                (
                    this.PrimaryContact == input.PrimaryContact ||
                    (this.PrimaryContact != null &&
                    this.PrimaryContact.Equals(input.PrimaryContact))
                ) && 
                (
                    this.SecondaryContact == input.SecondaryContact ||
                    (this.SecondaryContact != null &&
                    this.SecondaryContact.Equals(input.SecondaryContact))
                ) && 
                (
                    this.TemporaryGroupTitle == input.TemporaryGroupTitle ||
                    (this.TemporaryGroupTitle != null &&
                    this.TemporaryGroupTitle.Equals(input.TemporaryGroupTitle))
                ) && 
                (
                    this.WebId == input.WebId ||
                    (this.WebId != null &&
                    this.WebId.Equals(input.WebId))
                ) && 
                (
                    this.SiteId == input.SiteId ||
                    (this.SiteId != null &&
                    this.SiteId.Equals(input.SiteId))
                ) && 
                (
                    this.WebServerRelativeUrl == input.WebServerRelativeUrl ||
                    (this.WebServerRelativeUrl != null &&
                    this.WebServerRelativeUrl.Equals(input.WebServerRelativeUrl))
                ) && 
                (
                    this.ListTitle == input.ListTitle ||
                    (this.ListTitle != null &&
                    this.ListTitle.Equals(input.ListTitle))
                ) && 
                (
                    this.TopInheritUrl == input.TopInheritUrl ||
                    (this.TopInheritUrl != null &&
                    this.TopInheritUrl.Equals(input.TopInheritUrl))
                ) && 
                (
                    this.InheritNodeType == input.InheritNodeType ||
                    this.InheritNodeType.Equals(input.InheritNodeType)
                ) && 
                (
                    this.IsInheritedPermission == input.IsInheritedPermission ||
                    this.IsInheritedPermission.Equals(input.IsInheritedPermission)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.FullUrl == input.FullUrl ||
                    (this.FullUrl != null &&
                    this.FullUrl.Equals(input.FullUrl))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                if (this.ParentUrl != null)
                    hashCode = hashCode * 59 + this.ParentUrl.GetHashCode();
                hashCode = hashCode * 59 + this.ParentNodeType.GetHashCode();
                if (this.SiteUrl != null)
                    hashCode = hashCode * 59 + this.SiteUrl.GetHashCode();
                if (this.WebUrl != null)
                    hashCode = hashCode * 59 + this.WebUrl.GetHashCode();
                if (this.PrimaryAdministrator != null)
                    hashCode = hashCode * 59 + this.PrimaryAdministrator.GetHashCode();
                if (this.PrimaryContact != null)
                    hashCode = hashCode * 59 + this.PrimaryContact.GetHashCode();
                if (this.SecondaryContact != null)
                    hashCode = hashCode * 59 + this.SecondaryContact.GetHashCode();
                if (this.TemporaryGroupTitle != null)
                    hashCode = hashCode * 59 + this.TemporaryGroupTitle.GetHashCode();
                if (this.WebId != null)
                    hashCode = hashCode * 59 + this.WebId.GetHashCode();
                if (this.SiteId != null)
                    hashCode = hashCode * 59 + this.SiteId.GetHashCode();
                if (this.WebServerRelativeUrl != null)
                    hashCode = hashCode * 59 + this.WebServerRelativeUrl.GetHashCode();
                if (this.ListTitle != null)
                    hashCode = hashCode * 59 + this.ListTitle.GetHashCode();
                if (this.TopInheritUrl != null)
                    hashCode = hashCode * 59 + this.TopInheritUrl.GetHashCode();
                hashCode = hashCode * 59 + this.InheritNodeType.GetHashCode();
                hashCode = hashCode * 59 + this.IsInheritedPermission.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.FullUrl != null)
                    hashCode = hashCode * 59 + this.FullUrl.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
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
