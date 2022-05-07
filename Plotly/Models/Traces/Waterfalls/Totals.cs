using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Traces.Waterfalls.Totalss;

namespace Plotly.Models.Traces.Waterfalls
{
    /// <summary>
    ///     The Totals class.
    /// </summary>
    [Serializable]
    public class Totals : IEquatable<Totals>
    {
        /// <summary>
        ///     Gets or sets the Marker.
        /// </summary>
        [JsonPropertyName(@"marker")]
        public Marker? Marker { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is Totals other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] Totals other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (Marker == other.Marker && Marker != null && other.Marker != null && Marker.Equals(other.Marker));
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;

                if(Marker != null)
                    hashCode = hashCode * 59 + Marker.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Totals and the right Totals.
        /// </summary>
        /// <param name="left">Left Totals.</param>
        /// <param name="right">Right Totals.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(Totals left,
                                       Totals right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Totals and the right Totals.
        /// </summary>
        /// <param name="left">Left Totals.</param>
        /// <param name="right">Right Totals.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(Totals left,
                                       Totals right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Totals</returns>
        public Totals DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<Totals>(ms).Result;
        }
    }
}
