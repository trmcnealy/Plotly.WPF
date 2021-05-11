using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Plotly.Models.Traces.Violins.Markers
{
    /// <summary>
    ///     The Line class.
    /// </summary>
    [Serializable]
    public class Line : IEquatable<Line>
    {
        /// <summary>
        ///     Sets themarker.linecolor. It accepts either a specific color or an array
        ///     of numbers that are mapped to the colorscale relative to the max and min
        ///     values of the array or relative to <c>marker.line.cmin</c> and <c>marker.line.cmax</c>
        ///     if set.
        /// </summary>
        [JsonPropertyName(@"color")]
        public object Color { get; set; }

        /// <summary>
        ///     Sets the width (in px) of the lines bounding the marker points.
        /// </summary>
        [JsonPropertyName(@"width")]
        public JsNumber? Width { get; set; }

        /// <summary>
        ///     Sets the border line color of the outlier sample points. Defaults to marker.color
        /// </summary>
        [JsonPropertyName(@"outliercolor")]
        public object OutlierColor { get; set; }

        /// <summary>
        ///     Sets the border line width (in px) of the outlier sample points.
        /// </summary>
        [JsonPropertyName(@"outlierwidth")]
        public JsNumber? OutlierWidth { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is Line other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] Line other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (Color        == other.Color        && Color        != null && other.Color        != null && Color.Equals(other.Color))               &&
                   (Width        == other.Width        && Width        != null && other.Width        != null && Width.Equals(other.Width))               &&
                   (OutlierColor == other.OutlierColor && OutlierColor != null && other.OutlierColor != null && OutlierColor.Equals(other.OutlierColor)) &&
                   (OutlierWidth == other.OutlierWidth && OutlierWidth != null && other.OutlierWidth != null && OutlierWidth.Equals(other.OutlierWidth));
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;

                if(Color != null)
                    hashCode = hashCode * 59 + Color.GetHashCode();

                if(Width != null)
                    hashCode = hashCode * 59 + Width.GetHashCode();

                if(OutlierColor != null)
                    hashCode = hashCode * 59 + OutlierColor.GetHashCode();

                if(OutlierWidth != null)
                    hashCode = hashCode * 59 + OutlierWidth.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Line and the right Line.
        /// </summary>
        /// <param name="left">Left Line.</param>
        /// <param name="right">Right Line.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(Line left,
                                       Line right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Line and the right Line.
        /// </summary>
        /// <param name="left">Left Line.</param>
        /// <param name="right">Right Line.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(Line left,
                                       Line right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Line</returns>
        public Line DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<Line>(ms).Result;
        }
    }
}
