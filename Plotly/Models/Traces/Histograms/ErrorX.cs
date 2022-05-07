using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Traces.Histograms.ErrorXs;

namespace Plotly.Models.Traces.Histograms
{
    /// <summary>
    ///     The ErrorX class.
    /// </summary>
    [Serializable]
    public class ErrorX : IEquatable<ErrorX>
    {
        /// <summary>
        ///     Determines whether or not this set of error bars is visible.
        /// </summary>
        [JsonPropertyName(@"visible")]
        public bool? Visible { get; set; }

        /// <summary>
        ///     Determines the rule used to generate the error bars. If *constant`, the
        ///     bar lengths are of a constant value. Set this constant in <c>value</c>.
        ///     If <c>percent</c>, the bar lengths correspond to a percentage of underlying
        ///     data. Set this percentage in <c>value</c>. If <c>sqrt</c>, the bar lengths
        ///     correspond to the sqaure of the underlying data. If <c>data</c>, the bar
        ///     lengths are set with data set <c>array</c>.
        /// </summary>
        [JsonPropertyName(@"type")]
        public TypeEnum? Type { get; set; }

        /// <summary>
        ///     Determines whether or not the error bars have the same length in both direction
        ///     (top/bottom for vertical bars, left/right for horizontal bars.
        /// </summary>
        [JsonPropertyName(@"symmetric")]
        public bool? Symmetric { get; set; }

        /// <summary>
        ///     Sets the data corresponding the length of each error bar. Values are plotted
        ///     relative to the underlying data.
        /// </summary>
        [JsonPropertyName(@"array")]
        public List<object>? Array { get; set; }

        /// <summary>
        ///     Sets the data corresponding the length of each error bar in the bottom (left)
        ///     direction for vertical (horizontal) bars Values are plotted relative to
        ///     the underlying data.
        /// </summary>
        [JsonPropertyName(@"arrayminus")]
        public List<object>? ArrayMinus { get; set; }

        /// <summary>
        ///     Sets the value of either the percentage (if <c>type</c> is set to <c>percent</c>)
        ///     or the constant (if <c>type</c> is set to <c>constant</c>) corresponding
        ///     to the lengths of the error bars.
        /// </summary>
        [JsonPropertyName(@"value")]
        public JsNumber? Value { get; set; }

        /// <summary>
        ///     Sets the value of either the percentage (if <c>type</c> is set to <c>percent</c>)
        ///     or the constant (if <c>type</c> is set to <c>constant</c>) corresponding
        ///     to the lengths of the error bars in the bottom (left) direction for vertical
        ///     (horizontal) bars
        /// </summary>
        [JsonPropertyName(@"valueminus")]
        public JsNumber? ValueMinus { get; set; }

        /// <summary>
        ///     Gets or sets the TraceRef.
        /// </summary>
        [JsonPropertyName(@"traceref")]
        public int? TraceRef { get; set; }

        /// <summary>
        ///     Gets or sets the TraceRefMinus.
        /// </summary>
        [JsonPropertyName(@"tracerefminus")]
        public int? TraceRefMinus { get; set; }

        /// <summary>
        ///     Gets or sets the CopyYStyle.
        /// </summary>
        [JsonPropertyName(@"copy_ystyle")]
        public bool? CopyYStyle { get; set; }

        /// <summary>
        ///     Sets the stoke color of the error bars.
        /// </summary>
        [JsonPropertyName(@"color")]
        public object? Color { get; set; }

        /// <summary>
        ///     Sets the thickness (in px) of the error bars.
        /// </summary>
        [JsonPropertyName(@"thickness")]
        public JsNumber? Thickness { get; set; }

        /// <summary>
        ///     Sets the width (in px) of the cross-bar at both ends of the error bars.
        /// </summary>
        [JsonPropertyName(@"width")]
        public JsNumber? Width { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  array .
        /// </summary>
        [JsonPropertyName(@"arraysrc")]
        public string? ArraySrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  arrayminus .
        /// </summary>
        [JsonPropertyName(@"arrayminussrc")]
        public string? ArrayMinusSrc { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is ErrorX other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] ErrorX other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (Visible   == other.Visible   && Visible   != null && other.Visible   != null && Visible.Equals(other.Visible))                             &&
                   (Type      == other.Type      && Type      != null && other.Type      != null && Type.Equals(other.Type))                                   &&
                   (Symmetric == other.Symmetric && Symmetric != null && other.Symmetric != null && Symmetric.Equals(other.Symmetric))                         &&
                   (Equals(Array,      other.Array)      || Array      != null && other.Array      != null && Array.SequenceEqual(other.Array))                &&
                   (Equals(ArrayMinus, other.ArrayMinus) || ArrayMinus != null && other.ArrayMinus != null && ArrayMinus.SequenceEqual(other.ArrayMinus))      &&
                   (Value         == other.Value         && Value         != null && other.Value         != null && Value.Equals(other.Value))                 &&
                   (ValueMinus    == other.ValueMinus    && ValueMinus    != null && other.ValueMinus    != null && ValueMinus.Equals(other.ValueMinus))       &&
                   (TraceRef      == other.TraceRef      && TraceRef      != null && other.TraceRef      != null && TraceRef.Equals(other.TraceRef))           &&
                   (TraceRefMinus == other.TraceRefMinus && TraceRefMinus != null && other.TraceRefMinus != null && TraceRefMinus.Equals(other.TraceRefMinus)) &&
                   (CopyYStyle    == other.CopyYStyle    && CopyYStyle    != null && other.CopyYStyle    != null && CopyYStyle.Equals(other.CopyYStyle))       &&
                   (Color         == other.Color         && Color         != null && other.Color         != null && Color.Equals(other.Color))                 &&
                   (Thickness     == other.Thickness     && Thickness     != null && other.Thickness     != null && Thickness.Equals(other.Thickness))         &&
                   (Width         == other.Width         && Width         != null && other.Width         != null && Width.Equals(other.Width))                 &&
                   (ArraySrc      == other.ArraySrc      && ArraySrc      != null && other.ArraySrc      != null && ArraySrc.Equals(other.ArraySrc))           &&
                   (ArrayMinusSrc == other.ArrayMinusSrc && ArrayMinusSrc != null && other.ArrayMinusSrc != null && ArrayMinusSrc.Equals(other.ArrayMinusSrc));
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;

                if(Visible != null)
                    hashCode = hashCode * 59 + Visible.GetHashCode();

                if(Type != null)
                    hashCode = hashCode * 59 + Type.GetHashCode();

                if(Symmetric != null)
                    hashCode = hashCode * 59 + Symmetric.GetHashCode();

                if(Array != null)
                    hashCode = hashCode * 59 + Array.GetHashCode();

                if(ArrayMinus != null)
                    hashCode = hashCode * 59 + ArrayMinus.GetHashCode();

                if(Value != null)
                    hashCode = hashCode * 59 + Value.GetHashCode();

                if(ValueMinus != null)
                    hashCode = hashCode * 59 + ValueMinus.GetHashCode();

                if(TraceRef != null)
                    hashCode = hashCode * 59 + TraceRef.GetHashCode();

                if(TraceRefMinus != null)
                    hashCode = hashCode * 59 + TraceRefMinus.GetHashCode();

                if(CopyYStyle != null)
                    hashCode = hashCode * 59 + CopyYStyle.GetHashCode();

                if(Color != null)
                    hashCode = hashCode * 59 + Color.GetHashCode();

                if(Thickness != null)
                    hashCode = hashCode * 59 + Thickness.GetHashCode();

                if(Width != null)
                    hashCode = hashCode * 59 + Width.GetHashCode();

                if(ArraySrc != null)
                    hashCode = hashCode * 59 + ArraySrc.GetHashCode();

                if(ArrayMinusSrc != null)
                    hashCode = hashCode * 59 + ArrayMinusSrc.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left ErrorX and the right ErrorX.
        /// </summary>
        /// <param name="left">Left ErrorX.</param>
        /// <param name="right">Right ErrorX.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(ErrorX left,
                                       ErrorX right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left ErrorX and the right ErrorX.
        /// </summary>
        /// <param name="left">Left ErrorX.</param>
        /// <param name="right">Right ErrorX.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(ErrorX left,
                                       ErrorX right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>ErrorX</returns>
        public ErrorX DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<ErrorX>(ms).Result;
        }
    }
}
