using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Plotly.Models.Traces.Tables.Headers
{
    /// <summary>
    ///     The Line class.
    /// </summary>
    
    [JsonConverter(typeof(PlotlyConverter))]
    [Serializable]
    public class Line : IEquatable<Line>
    {
        /// <summary>
        ///     Gets or sets the Width.
        /// </summary>
        [JsonPropertyName(@"width")]
        public JsNumber? Width { get; set;} 

        /// <summary>
        ///     Gets or sets the Width.
        /// </summary>
        [JsonPropertyName(@"width")]
        [Array]
        public List<JsNumber?> WidthArray { get; set;} 

        /// <summary>
        ///     Gets or sets the Color.
        /// </summary>
        [JsonPropertyName(@"color")]
        public object Color { get; set;} 

        /// <summary>
        ///     Gets or sets the Color.
        /// </summary>
        [JsonPropertyName(@"color")]
        [Array]
        public List<object> ColorArray { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  width .
        /// </summary>
        [JsonPropertyName(@"widthsrc")]
        public string WidthSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  color .
        /// </summary>
        [JsonPropertyName(@"colorsrc")]
        public string ColorSrc { get; set;} 

        
        public override bool Equals(object obj)
        {
            if (!(obj is Line other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        
        public bool Equals([AllowNull] Line other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Width == other.Width &&
                    Width != null && other.Width != null &&
                    Width.Equals(other.Width)
                ) && 
                (
                    Equals(WidthArray, other.WidthArray) ||
                    WidthArray != null && other.WidthArray != null &&
                    WidthArray.SequenceEqual(other.WidthArray)
                ) &&
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
                    WidthSrc == other.WidthSrc &&
                    WidthSrc != null && other.WidthSrc != null &&
                    WidthSrc.Equals(other.WidthSrc)
                ) && 
                (
                    ColorSrc == other.ColorSrc &&
                    ColorSrc != null && other.ColorSrc != null &&
                    ColorSrc.Equals(other.ColorSrc)
                );
        }

        
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (Width != null) hashCode = hashCode * 59 + Width.GetHashCode();
                if (WidthArray != null) hashCode = hashCode * 59 + WidthArray.GetHashCode();
                if (Color != null) hashCode = hashCode * 59 + Color.GetHashCode();
                if (ColorArray != null) hashCode = hashCode * 59 + ColorArray.GetHashCode();
                if (WidthSrc != null) hashCode = hashCode * 59 + WidthSrc.GetHashCode();
                if (ColorSrc != null) hashCode = hashCode * 59 + ColorSrc.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Line and the right Line.
        /// </summary>
        /// <param name="left">Left Line.</param>
        /// <param name="right">Right Line.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (Line left, Line right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Line and the right Line.
        /// </summary>
        /// <param name="left">Left Line.</param>
        /// <param name="right">Right Line.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (Line left, Line right)
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