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
    /// 
    /// </summary>
    [DataContract]
    public class CodeListMetadata : IEquatable<CodeListMetadata>
    {
        /// <summary>
        /// The identiyer for the codelist
        /// </summary>
        /// <value>The identiyer for the codelist</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The textual name  for the codelist.
        /// </summary>
        /// <value>The textual name  for the codelist.</value>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public List<Link> Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CodeListMetadata {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
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
            return obj.GetType() == GetType() && Equals((CodeListMetadata)obj);
        }

        /// <summary>
        /// Returns true if CodeListMetadata instances are equal
        /// </summary>
        /// <param name="other">Instance of CodeListMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CodeListMetadata other)
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
                    Label == other.Label ||
                    Label != null &&
                    Label.Equals(other.Label)
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
                    if (Label != null)
                    hashCode = hashCode * 59 + Label.GetHashCode();
                    if (Links != null)
                    hashCode = hashCode * 59 + Links.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(CodeListMetadata left, CodeListMetadata right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CodeListMetadata left, CodeListMetadata right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
