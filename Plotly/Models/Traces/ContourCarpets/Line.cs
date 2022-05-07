using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Plotly.Models.Traces.ContourCarpets
{
    /// <summary>
    ///     The Line class.
    /// </summary>
    [Serializable]
    public class Line : IEquatable<Line>
    {
        /// <summary>
        ///     Sets the color of the contour level. Has no effect if <c>contours.coloring</c>
        ///     is set to <c>lines</c>.
        /// </summary>
        [JsonPropertyName(@"color")]
        public object? Color { get; set; }

        /// <summary>
        ///     Sets the contour line width in (in px) Defaults to <c>0.5</c> when <c>contours.type</c>
        ///     is <c>levels</c>. Defaults to <c>2</c> when <c>contour.type</c> is <c>constraint</c>.
        /// </summary>
        [JsonPropertyName(@"width")]
        public JsNumber? Width { get; set; }

        /// <summary>
        ///     Sets the dash style of lines. Set to a dash type string (<c>solid</c>, <c>dot</c>,
        ///     <c>dash</c>, <c>longdash</c>, <c>dashdot</c>, or <c>longdashdot</c>) or
        ///     a dash length list in px (eg <c>5px,10px,2px,2px</c>).
        /// </summary>
        [JsonPropertyName(@"dash")]
        public string? Dash { get; set; }

        /// <summary>
        ///     Sets the amount of smoothing for the contour lines, where <c>0</c> corresponds
        ///     to no smoothing.
        /// </summary>
        [JsonPropertyName(@"smoothing")]
        public JsNumber? Smoothing { get; set; }

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

            return (Color     == other.Color     && Color     != null && other.Color     != null && Color.Equals(other.Color)) &&
                   (Width     == other.Width     && Width     != null && other.Width     != null && Width.Equals(other.Width)) &&
                   (Dash      == other.Dash      && Dash      != null && other.Dash      != null && Dash.Equals(other.Dash))   &&
                   (Smoothing == other.Smoothing && Smoothing != null && other.Smoothing != null && Smoothing.Equals(other.Smoothing));
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

                if(Dash != null)
                    hashCode = hashCode * 59 + Dash.GetHashCode();

                if(Smoothing != null)
                    hashCode = hashCode * 59 + Smoothing.GetHashCode();

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
