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
    /// 
    /// </summary>
    [DataContract]
    public partial class JsonstatExtensionLink : IEquatable<JsonstatExtensionLink>
    {
        /// <summary>
        /// Gets or Sets Describedby
        /// </summary>
        [DataMember(Name="describedby", EmitDefaultValue=false)]
        public List<DimensionExtension> Describedby { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JsonstatExtensionLink {\n");
            sb.Append("  Describedby: ").Append(Describedby).Append("\n");
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
            return obj.GetType() == GetType() && Equals((JsonstatExtensionLink)obj);
        }

        /// <summary>
        /// Returns true if JsonstatExtensionLink instances are equal
        /// </summary>
        /// <param name="other">Instance of JsonstatExtensionLink to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JsonstatExtensionLink other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Describedby == other.Describedby ||
                    Describedby != null &&
                    other.Describedby != null &&
                    Describedby.SequenceEqual(other.Describedby)
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
                    if (Describedby != null)
                    hashCode = hashCode * 59 + Describedby.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(JsonstatExtensionLink left, JsonstatExtensionLink right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(JsonstatExtensionLink left, JsonstatExtensionLink right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
