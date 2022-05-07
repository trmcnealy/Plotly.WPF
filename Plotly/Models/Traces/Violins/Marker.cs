using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Traces.Violins.Markers;

namespace Plotly.Models.Traces.Violins
{
    /// <summary>
    ///     The Marker class.
    /// </summary>
    [Serializable]
    public class Marker : IEquatable<Marker>
    {
        /// <summary>
        ///     Sets the color of the outlier sample points.
        /// </summary>
        [JsonPropertyName(@"outliercolor")]
        public object? OutlierColor { get; set; }

        /// <summary>
        ///     Sets the marker symbol type. Adding 100 is equivalent to appending <c>-open</c>
        ///     to a symbol name. Adding 200 is equivalent to appending <c>-dot</c> to a
        ///     symbol name. Adding 300 is equivalent to appending <c>-open-dot</c> or <c>dot-open</c>
        ///     to a symbol name.
        /// </summary>
        [JsonPropertyName(@"symbol")]
        public SymbolEnum? Symbol { get; set; }

        /// <summary>
        ///     Sets the marker opacity.
        /// </summary>
        [JsonPropertyName(@"opacity")]
        public JsNumber? Opacity { get; set; }

        /// <summary>
        ///     Sets the marker size (in px).
        /// </summary>
        [JsonPropertyName(@"size")]
        public JsNumber? Size { get; set; }

        /// <summary>
        ///     Sets themarkercolor. It accepts either a specific color or an array of numbers
        ///     that are mapped to the colorscale relative to the max and min values of
        ///     the array or relative to <c>marker.cmin</c> and <c>marker.cmax</c> if set.
        /// </summary>
        [JsonPropertyName(@"color")]
        public object? Color { get; set; }

        /// <summary>
        ///     Gets or sets the Line.
        /// </summary>
        [JsonPropertyName(@"line")]
        public Markers.Line? Line { get; set; }

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

            return (OutlierColor == other.OutlierColor && OutlierColor != null && other.OutlierColor != null && OutlierColor.Equals(other.OutlierColor)) &&
                   (Symbol       == other.Symbol       && Symbol       != null && other.Symbol       != null && Symbol.Equals(other.Symbol))             &&
                   (Opacity      == other.Opacity      && Opacity      != null && other.Opacity      != null && Opacity.Equals(other.Opacity))           &&
                   (Size         == other.Size         && Size         != null && other.Size         != null && Size.Equals(other.Size))                 &&
                   (Color        == other.Color        && Color        != null && other.Color        != null && Color.Equals(other.Color))               &&
                   (Line         == other.Line         && Line         != null && other.Line         != null && Line.Equals(other.Line));
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;

                if(OutlierColor != null)
                    hashCode = hashCode * 59 + OutlierColor.GetHashCode();

                if(Symbol != null)
                    hashCode = hashCode * 59 + Symbol.GetHashCode();

                if(Opacity != null)
                    hashCode = hashCode * 59 + Opacity.GetHashCode();

                if(Size != null)
                    hashCode = hashCode * 59 + Size.GetHashCode();

                if(Color != null)
                    hashCode = hashCode * 59 + Color.GetHashCode();

                if(Line != null)
                    hashCode = hashCode * 59 + Line.GetHashCode();

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
