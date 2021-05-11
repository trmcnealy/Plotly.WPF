using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Traces.FunnelAreas.Markers;

namespace Plotly.Models.Traces.FunnelAreas
{
    /// <summary>
    ///     The Marker class.
    /// </summary>
    [Serializable]
    public class Marker : IEquatable<Marker>
    {
        /// <summary>
        ///     Sets the color of each sector. If not specified, the default trace color
        ///     set is used to pick the sector colors.
        /// </summary>
        [JsonPropertyName(@"colors")]
        public List<object> Colors { get; set; }

        /// <summary>
        ///     Gets or sets the Line.
        /// </summary>
        [JsonPropertyName(@"line")]
        public Line Line { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  colors .
        /// </summary>
        [JsonPropertyName(@"colorssrc")]
        public string ColorsSrc { get; set; }

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

            return (Equals(Colors, other.Colors) || Colors != null && other.Colors != null && Colors.SequenceEqual(other.Colors)) &&
                   (Line      == other.Line      && Line      != null && other.Line      != null && Line.Equals(other.Line))      &&
                   (ColorsSrc == other.ColorsSrc && ColorsSrc != null && other.ColorsSrc != null && ColorsSrc.Equals(other.ColorsSrc));
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;

                if(Colors != null)
                    hashCode = hashCode * 59 + Colors.GetHashCode();

                if(Line != null)
                    hashCode = hashCode * 59 + Line.GetHashCode();

                if(ColorsSrc != null)
                    hashCode = hashCode * 59 + ColorsSrc.GetHashCode();

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
