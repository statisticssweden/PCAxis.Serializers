/*
 * PxApi
 *
 * This api lets you do 2 things; Find a table(Navigation) and use a table (Table).  _Table below is added to show how tables can be described in yml._  **Table contains status code this API may return** | Status code    | Description      | Reason                      | | - -- -- --        | - -- -- -- -- --      | - -- -- -- -- -- -- -- -- -- --       | | 200            | Success          | The endpoint has delivered response for the request                      | | 400            | Bad request      | If the request is not valid | | 404            | Not found        | If the URL in request does not exist | | 429            | Too many request | Number of requests has surpassed the threshold                            | 
 *
 * The version of the OpenAPI document: 2.0
 * 
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using PCAxis.OpenAPILib.Converters;

namespace PCAxis.OpenAPILib.Models
{ 
    /// <summary>
    /// Folder item
    /// </summary>
    [DataContract]
    public partial class Folder : IEquatable<Folder>
    {
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public string? Id { get; set; }

        /// <summary>
        /// One of heading, table, folder or folder-information
        /// </summary>
        /// <value>One of heading, table, folder or folder-information</value>
        [DataMember(Name="objectType", EmitDefaultValue=false)]
        public string ObjectType { get; set; }

        /// <summary>
        /// Display text
        /// </summary>
        /// <value>Display text</value>
        [DataMember(Name="label", EmitDefaultValue=true)]
        public string? Label { get; set; }

        /// <summary>
        /// Longer text describing node.
        /// </summary>
        /// <value>Longer text describing node.</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string? Description { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name="tags", EmitDefaultValue=true)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Gets or Sets FolderContents
        /// </summary>
        [DataMember(Name="folderContents", EmitDefaultValue=true)]
        public List<FolderContentItem> FolderContents { get; set; }

        /// <summary>
        /// Links to ...
        /// </summary>
        /// <value>Links to ...</value>
        [DataMember(Name="links", EmitDefaultValue=true)]
        public List<Link> Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Folder {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ObjectType: ").Append(ObjectType).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  FolderContents: ").Append(FolderContents).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((Folder)obj);
        }

        /// <summary>
        /// Returns true if Folder instances are equal
        /// </summary>
        /// <param name="other">Instance of Folder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Folder other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    ObjectType == other.ObjectType ||
                    ObjectType != null &&
                    ObjectType.Equals(other.ObjectType)
                ) && 
                (
                    Label == other.Label ||
                    Label != null &&
                    Label.Equals(other.Label)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    Tags == other.Tags ||
                    Tags != null &&
                    other.Tags != null &&
                    Tags.SequenceEqual(other.Tags)
                ) && 
                (
                    FolderContents == other.FolderContents ||
                    FolderContents != null &&
                    other.FolderContents != null &&
                    FolderContents.SequenceEqual(other.FolderContents)
                ) && 
                (
                    Links == other.Links ||
                    Links != null &&
                    other.Links != null &&
                    Links.SequenceEqual(other.Links)
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
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (ObjectType != null)
                    hashCode = hashCode * 59 + ObjectType.GetHashCode();
                    if (Label != null)
                    hashCode = hashCode * 59 + Label.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (Tags != null)
                    hashCode = hashCode * 59 + Tags.GetHashCode();
                    if (FolderContents != null)
                    hashCode = hashCode * 59 + FolderContents.GetHashCode();
                    if (Links != null)
                    hashCode = hashCode * 59 + Links.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Folder left, Folder right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Folder left, Folder right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
