using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Plotly.Models.Layouts.MapBoxs.Layers
{
    /// <summary>
    ///     The Line class.
    /// </summary>
    [Serializable]
    public class Line : IEquatable<Line>
    {
        /// <summary>
        ///     Sets the line width (mapbox.layer.paint.line-width). Has an effect only
        ///     when <c>type</c> is set to <c>line</c>.
        /// </summary>
        [JsonPropertyName(@"width")]
        public JsNumber? Width { get; set; }

        /// <summary>
        ///     Sets the length of dashes and gaps (mapbox.layer.paint.line-dasharray).
        ///     Has an effect only when <c>type</c> is set to <c>line</c>.
        /// </summary>
        [JsonPropertyName(@"dash")]
        public List<object> Dash { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  dash .
        /// </summary>
        [JsonPropertyName(@"dashsrc")]
        public string DashSrc { get; set; }

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

            return (Width == other.Width && Width != null && other.Width != null && Width.Equals(other.Width))        &&
                   (Equals(Dash, other.Dash) || Dash != null && other.Dash != null && Dash.SequenceEqual(other.Dash)) &&
                   (DashSrc == other.DashSrc && DashSrc != null && other.DashSrc != null && DashSrc.Equals(other.DashSrc));
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;

                if(Width != null)
                    hashCode = hashCode * 59 + Width.GetHashCode();

                if(Dash != null)
                    hashCode = hashCode * 59 + Dash.GetHashCode();

                if(DashSrc != null)
                    hashCode = hashCode * 59 + DashSrc.GetHashCode();

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
