/*
 * PxApi
 *
 * This api lets you do 2 things; Find a table(Navigation) and use a table (Table).  _Table below is added to show how tables can be described in yml._  **Table contains status code this API may return** | Status code    | Description      | Reason                      | | - -- -- --        | - -- -- -- -- --      | - -- -- -- -- -- -- -- -- -- --       | | 200            | Success          | The endpoint has delivered response for the request                      | | 400            | Bad request      | If the request is not valid | | 403            | Forbidden        | number of cells exceed the API limit | | 404            | Not found        | If the URL in request does not exist | | 429            | Too many request | Requests exceed the API time limit. Large queries should be run in sequence | | 50X            | Internal Server Error | The service might be down | 
 *
 * The version of the OpenAPI document: 2.0
 * 
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace PCAxis.Serializers.JsonStat2.Model
{
    /// <summary>
    /// extension at root level
    /// </summary>
    [DataContract]
    public partial class ExtensionRoot : IEquatable<ExtensionRoot>
    {
        /// <summary>
        /// Describes if a note of a certain index is mandatory.
        /// </summary>
        /// <value>Describes if a note of a certain index is mandatory.</value>
        [DataMember(Name="noteMandatory", EmitDefaultValue=false)]
        public Dictionary<string, bool> NoteMandatory { get; set; }

        /// <summary>
        /// Gets or Sets Px
        /// </summary>
        [DataMember(Name="px", EmitDefaultValue=false)]
        public ExtensionRootPx Px { get; set; }

        /// <summary>
        /// Tag for table
        /// </summary>
        /// <value>Tag for table</value>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Table will no longer be updated
        /// </summary>
        /// <value>Table will no longer be updated</value>
        [DataMember(Name="discontinued", EmitDefaultValue=false)]
        public bool? Discontinued { get; set; }

        /// <summary>
        /// A list of contacts associated with the table.
        /// </summary>
        /// <value>A list of contacts associated with the table.</value>
        [DataMember(Name="contact", EmitDefaultValue=false)]
        public List<Contact> Contact { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExtensionRoot {\n");
            sb.Append("  NoteMandatory: ").Append(NoteMandatory).Append("\n");
            sb.Append("  Px: ").Append(Px).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Discontinued: ").Append(Discontinued).Append("\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
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
            return obj.GetType() == GetType() && Equals((ExtensionRoot)obj);
        }

        /// <summary>
        /// Returns true if ExtensionRoot instances are equal
        /// </summary>
        /// <param name="other">Instance of ExtensionRoot to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExtensionRoot other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    NoteMandatory == other.NoteMandatory ||
                    NoteMandatory != null &&
                    other.NoteMandatory != null &&
                    NoteMandatory.SequenceEqual(other.NoteMandatory)
                ) && 
                (
                    Px == other.Px ||
                    Px != null &&
                    Px.Equals(other.Px)
                ) && 
                (
                    Tags == other.Tags ||
                    Tags != null &&
                    other.Tags != null &&
                    Tags.SequenceEqual(other.Tags)
                ) && 
                (
                    Discontinued == other.Discontinued ||
                    Discontinued != null &&
                    Discontinued.Equals(other.Discontinued)
                ) && 
                (
                    Contact == other.Contact ||
                    Contact != null &&
                    other.Contact != null &&
                    Contact.SequenceEqual(other.Contact)
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
                    if (NoteMandatory != null)
                    hashCode = hashCode * 59 + NoteMandatory.GetHashCode();
                    if (Px != null)
                    hashCode = hashCode * 59 + Px.GetHashCode();
                    if (Tags != null)
                    hashCode = hashCode * 59 + Tags.GetHashCode();
                    if (Discontinued != null)
                    hashCode = hashCode * 59 + Discontinued.GetHashCode();
                    if (Contact != null)
                    hashCode = hashCode * 59 + Contact.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ExtensionRoot left, ExtensionRoot right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ExtensionRoot left, ExtensionRoot right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
