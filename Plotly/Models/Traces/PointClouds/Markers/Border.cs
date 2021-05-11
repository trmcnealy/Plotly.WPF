using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Plotly.Models.Traces.PointClouds.Markers
{
    /// <summary>
    ///     The Border class.
    /// </summary>
    [Serializable]
    public class Border : IEquatable<Border>
    {
        /// <summary>
        ///     Sets the stroke color. It accepts a specific color. If the color is not
        ///     fully opaque and there are hundreds of thousands of points, it may cause
        ///     slower zooming and panning.
        /// </summary>
        [JsonPropertyName(@"color")]
        public object Color { get; set; }

        /// <summary>
        ///     Specifies what fraction of the marker area is covered with the border.
        /// </summary>
        [JsonPropertyName(@"arearatio")]
        public JsNumber? AreaRatio { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is Border other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] Border other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (Color     == other.Color     && Color     != null && other.Color     != null && Color.Equals(other.Color)) &&
                   (AreaRatio == other.AreaRatio && AreaRatio != null && other.AreaRatio != null && AreaRatio.Equals(other.AreaRatio));
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;

                if(Color != null)
                    hashCode = hashCode * 59 + Color.GetHashCode();

                if(AreaRatio != null)
                    hashCode = hashCode * 59 + AreaRatio.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Border and the right Border.
        /// </summary>
        /// <param name="left">Left Border.</param>
        /// <param name="right">Right Border.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(Border left,
                                       Border right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Border and the right Border.
        /// </summary>
        /// <param name="left">Left Border.</param>
        /// <param name="right">Right Border.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(Border left,
                                       Border right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Border</returns>
        public Border DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<Border>(ms).Result;
        }
    }
}
