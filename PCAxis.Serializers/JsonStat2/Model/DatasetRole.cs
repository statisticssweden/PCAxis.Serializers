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
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Serializers.JsonStat2.Model
{ 
    /// <summary>
    /// Specification on json-stat.org -&gt; [here](https://json-stat.org/full/#role)
    /// </summary>
    [DataContract]
    public partial class DatasetRole : IEquatable<DatasetRole>
    {
        /// <summary>
        /// Gets or Sets Time
        /// </summary>
        [DataMember(Name="time", EmitDefaultValue=false)]
        public List<string> Time { get; set; }

        /// <summary>
        /// Gets or Sets Geo
        /// </summary>
        [DataMember(Name="geo", EmitDefaultValue=false)]
        public List<string> Geo { get; set; }

        /// <summary>
        /// Gets or Sets Metric
        /// </summary>
        [DataMember(Name="metric", EmitDefaultValue=false)]
        public List<string> Metric { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DatasetRole {\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  Geo: ").Append(Geo).Append("\n");
            sb.Append("  Metric: ").Append(Metric).Append("\n");
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
            return obj.GetType() == GetType() && Equals((DatasetRole)obj);
        }

        /// <summary>
        /// Returns true if DatasetRole instances are equal
        /// </summary>
        /// <param name="other">Instance of DatasetRole to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DatasetRole other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Time == other.Time ||
                    Time != null &&
                    other.Time != null &&
                    Time.SequenceEqual(other.Time)
                ) && 
                (
                    Geo == other.Geo ||
                    Geo != null &&
                    other.Geo != null &&
                    Geo.SequenceEqual(other.Geo)
                ) && 
                (
                    Metric == other.Metric ||
                    Metric != null &&
                    other.Metric != null &&
                    Metric.SequenceEqual(other.Metric)
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
                    if (Time != null)
                    hashCode = hashCode * 59 + Time.GetHashCode();
                    if (Geo != null)
                    hashCode = hashCode * 59 + Geo.GetHashCode();
                    if (Metric != null)
                    hashCode = hashCode * 59 + Metric.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(DatasetRole left, DatasetRole right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(DatasetRole left, DatasetRole right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
