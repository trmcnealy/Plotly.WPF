using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Plotly.Models.Traces.ScatterGeos
{
    /// <summary>
    ///     The Unselected class.
    /// </summary>
    [Serializable]
    public class Unselected : IEquatable<Unselected>
    {
        /// <summary>
        ///     Gets or sets the Marker.
        /// </summary>
        [JsonPropertyName(@"marker")]
        public Unselecteds.Marker Marker { get; set; }

        /// <summary>
        ///     Gets or sets the TextFont.
        /// </summary>
        [JsonPropertyName(@"textfont")]
        public Unselecteds.TextFont TextFont { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is Unselected other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] Unselected other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (Marker   == other.Marker   && Marker   != null && other.Marker   != null && Marker.Equals(other.Marker)) &&
                   (TextFont == other.TextFont && TextFont != null && other.TextFont != null && TextFont.Equals(other.TextFont));
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;

                if(Marker != null)
                    hashCode = hashCode * 59 + Marker.GetHashCode();

                if(TextFont != null)
                    hashCode = hashCode * 59 + TextFont.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Unselected and the right Unselected.
        /// </summary>
        /// <param name="left">Left Unselected.</param>
        /// <param name="right">Right Unselected.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(Unselected left,
                                       Unselected right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Unselected and the right Unselected.
        /// </summary>
        /// <param name="left">Left Unselected.</param>
        /// <param name="right">Right Unselected.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(Unselected left,
                                       Unselected right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Unselected</returns>
        public Unselected DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<Unselected>(ms).Result;
        }
    }
}
