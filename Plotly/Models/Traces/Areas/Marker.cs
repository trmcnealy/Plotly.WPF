using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Traces.Areas.Markers;

namespace Plotly.Models.Traces.Areas
{
    /// <summary>
    ///     The Marker class.
    /// </summary>
    
    [JsonConverter(typeof(PlotlyConverter))]
    [Serializable]
    public class Marker : IEquatable<Marker>
    {
        /// <summary>
        ///     Area traces are deprecated! Please switch to the <c>barpolar</c> trace type.
        ///     Sets themarkercolor. It accepts either a specific color or an array of numbers
        ///     that are mapped to the colorscale relative to the max and min values of
        ///     the array or relative to <c>marker.cmin</c> and <c>marker.cmax</c> if set.
        /// </summary>
        [JsonPropertyName(@"color")]
        public object Color { get; set;} 

        /// <summary>
        ///     Area traces are deprecated! Please switch to the <c>barpolar</c> trace type.
        ///     Sets themarkercolor. It accepts either a specific color or an array of numbers
        ///     that are mapped to the colorscale relative to the max and min values of
        ///     the array or relative to <c>marker.cmin</c> and <c>marker.cmax</c> if set.
        /// </summary>
        [JsonPropertyName(@"color")]
        [Array]
        public List<object> ColorArray { get; set;} 

        /// <summary>
        ///     Area traces are deprecated! Please switch to the <c>barpolar</c> trace type.
        ///     Sets the marker size (in px).
        /// </summary>
        [JsonPropertyName(@"size")]
        public JsNumber? Size { get; set;} 

        /// <summary>
        ///     Area traces are deprecated! Please switch to the <c>barpolar</c> trace type.
        ///     Sets the marker size (in px).
        /// </summary>
        [JsonPropertyName(@"size")]
        [Array]
        public List<JsNumber?> SizeArray { get; set;} 

        /// <summary>
        ///     Area traces are deprecated! Please switch to the <c>barpolar</c> trace type.
        ///     Sets the marker symbol type. Adding 100 is equivalent to appending <c>-open</c>
        ///     to a symbol name. Adding 200 is equivalent to appending <c>-dot</c> to a
        ///     symbol name. Adding 300 is equivalent to appending <c>-open-dot</c> or <c>dot-open</c>
        ///     to a symbol name.
        /// </summary>
        [JsonPropertyName(@"symbol")]
        public SymbolEnum? Symbol { get; set;} 

        /// <summary>
        ///     Area traces are deprecated! Please switch to the <c>barpolar</c> trace type.
        ///     Sets the marker symbol type. Adding 100 is equivalent to appending <c>-open</c>
        ///     to a symbol name. Adding 200 is equivalent to appending <c>-dot</c> to a
        ///     symbol name. Adding 300 is equivalent to appending <c>-open-dot</c> or <c>dot-open</c>
        ///     to a symbol name.
        /// </summary>
        [JsonPropertyName(@"symbol")]
        [Array]
        public List<SymbolEnum?> SymbolArray { get; set;} 

        /// <summary>
        ///     Area traces are deprecated! Please switch to the <c>barpolar</c> trace type.
        ///     Sets the marker opacity.
        /// </summary>
        [JsonPropertyName(@"opacity")]
        public JsNumber? Opacity { get; set;} 

        /// <summary>
        ///     Area traces are deprecated! Please switch to the <c>barpolar</c> trace type.
        ///     Sets the marker opacity.
        /// </summary>
        [JsonPropertyName(@"opacity")]
        [Array]
        public List<JsNumber?> OpacityArray { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  color .
        /// </summary>
        [JsonPropertyName(@"colorsrc")]
        public string ColorSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  size .
        /// </summary>
        [JsonPropertyName(@"sizesrc")]
        public string SizeSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  symbol .
        /// </summary>
        [JsonPropertyName(@"symbolsrc")]
        public string SymbolSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  opacity .
        /// </summary>
        [JsonPropertyName(@"opacitysrc")]
        public string OpacitySrc { get; set;} 

        
        public override bool Equals(object obj)
        {
            if (!(obj is Marker other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        
        public bool Equals([AllowNull] Marker other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Color == other.Color &&
                    Color != null && other.Color != null &&
                    Color.Equals(other.Color)
                ) && 
                (
                    Equals(ColorArray, other.ColorArray) ||
                    ColorArray != null && other.ColorArray != null &&
                    ColorArray.SequenceEqual(other.ColorArray)
                ) &&
                (
                    Size == other.Size &&
                    Size != null && other.Size != null &&
                    Size.Equals(other.Size)
                ) && 
                (
                    Equals(SizeArray, other.SizeArray) ||
                    SizeArray != null && other.SizeArray != null &&
                    SizeArray.SequenceEqual(other.SizeArray)
                ) &&
                (
                    Symbol == other.Symbol &&
                    Symbol != null && other.Symbol != null &&
                    Symbol.Equals(other.Symbol)
                ) && 
                (
                    Equals(SymbolArray, other.SymbolArray) ||
                    SymbolArray != null && other.SymbolArray != null &&
                    SymbolArray.SequenceEqual(other.SymbolArray)
                ) &&
                (
                    Opacity == other.Opacity &&
                    Opacity != null && other.Opacity != null &&
                    Opacity.Equals(other.Opacity)
                ) && 
                (
                    Equals(OpacityArray, other.OpacityArray) ||
                    OpacityArray != null && other.OpacityArray != null &&
                    OpacityArray.SequenceEqual(other.OpacityArray)
                ) &&
                (
                    ColorSrc == other.ColorSrc &&
                    ColorSrc != null && other.ColorSrc != null &&
                    ColorSrc.Equals(other.ColorSrc)
                ) && 
                (
                    SizeSrc == other.SizeSrc &&
                    SizeSrc != null && other.SizeSrc != null &&
                    SizeSrc.Equals(other.SizeSrc)
                ) && 
                (
                    SymbolSrc == other.SymbolSrc &&
                    SymbolSrc != null && other.SymbolSrc != null &&
                    SymbolSrc.Equals(other.SymbolSrc)
                ) && 
                (
                    OpacitySrc == other.OpacitySrc &&
                    OpacitySrc != null && other.OpacitySrc != null &&
                    OpacitySrc.Equals(other.OpacitySrc)
                );
        }

        
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (Color != null) hashCode = hashCode * 59 + Color.GetHashCode();
                if (ColorArray != null) hashCode = hashCode * 59 + ColorArray.GetHashCode();
                if (Size != null) hashCode = hashCode * 59 + Size.GetHashCode();
                if (SizeArray != null) hashCode = hashCode * 59 + SizeArray.GetHashCode();
                if (Symbol != null) hashCode = hashCode * 59 + Symbol.GetHashCode();
                if (SymbolArray != null) hashCode = hashCode * 59 + SymbolArray.GetHashCode();
                if (Opacity != null) hashCode = hashCode * 59 + Opacity.GetHashCode();
                if (OpacityArray != null) hashCode = hashCode * 59 + OpacityArray.GetHashCode();
                if (ColorSrc != null) hashCode = hashCode * 59 + ColorSrc.GetHashCode();
                if (SizeSrc != null) hashCode = hashCode * 59 + SizeSrc.GetHashCode();
                if (SymbolSrc != null) hashCode = hashCode * 59 + SymbolSrc.GetHashCode();
                if (OpacitySrc != null) hashCode = hashCode * 59 + OpacitySrc.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Marker and the right Marker.
        /// </summary>
        /// <param name="left">Left Marker.</param>
        /// <param name="right">Right Marker.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (Marker left, Marker right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Marker and the right Marker.
        /// </summary>
        /// <param name="left">Left Marker.</param>
        /// <param name="right">Right Marker.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (Marker left, Marker right)
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