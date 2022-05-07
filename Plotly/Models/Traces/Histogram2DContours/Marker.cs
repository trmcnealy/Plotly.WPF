using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Plotly.Models.Traces.Histogram2DContours
{
    /// <summary>
    ///     The Marker class.
    /// </summary>
    [Serializable]
    public class Marker : IEquatable<Marker>
    {
        /// <summary>
        ///     Sets the aggregation data.
        /// </summary>
        [JsonPropertyName(@"color")]
        public List<object>? Color { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  color .
        /// </summary>
        [JsonPropertyName(@"colorsrc")]
        public string? ColorSrc { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is Marker other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] Marker other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (Equals(Color, other.Color) || Color != null && other.Color != null && Color.SequenceEqual(other.Color)) &&
                   (ColorSrc == other.ColorSrc && ColorSrc != null && other.ColorSrc != null && ColorSrc.Equals(other.ColorSrc));
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;

                if(Color != null)
                    hashCode = hashCode * 59 + Color.GetHashCode();

                if(ColorSrc != null)
                    hashCode = hashCode * 59 + ColorSrc.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Marker and the right Marker.
        /// </summary>
        /// <param name="left">Left Marker.</param>
        /// <param name="right">Right Marker.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(Marker left,
                                       Marker right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Marker and the right Marker.
        /// </summary>
        /// <param name="left">Left Marker.</param>
        /// <param name="right">Right Marker.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(Marker left,
                                       Marker right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Marker</returns>
        public Marker DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<Marker>(ms).Result;
        }
    }
}
