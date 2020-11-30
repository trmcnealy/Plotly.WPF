using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Plotly.Models.Traces.Tables.Cellss
{
    /// <summary>
    ///     The Fill class.
    /// </summary>
    
    [JsonConverter(typeof(PlotlyConverter))]
    [Serializable]
    public class Fill : IEquatable<Fill>
    {
        /// <summary>
        ///     Sets the cell fill color. It accepts either a specific color or an array
        ///     of colors or a 2D array of colors.
        /// </summary>
        [JsonPropertyName(@"color")]
        public object Color { get; set;} 

        /// <summary>
        ///     Sets the cell fill color. It accepts either a specific color or an array
        ///     of colors or a 2D array of colors.
        /// </summary>
        [JsonPropertyName(@"color")]
        [Array]
        public List<object> ColorArray { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  color .
        /// </summary>
        [JsonPropertyName(@"colorsrc")]
        public string ColorSrc { get; set;} 

        
        public override bool Equals(object obj)
        {
            if (!(obj is Fill other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        
        public bool Equals([AllowNull] Fill other)
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
                if (Color != null) hashCode = hashCode * 59 + Color.GetHashCode();
                if (ColorArray != null) hashCode = hashCode * 59 + ColorArray.GetHashCode();
                if (ColorSrc != null) hashCode = hashCode * 59 + ColorSrc.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Fill and the right Fill.
        /// </summary>
        /// <param name="left">Left Fill.</param>
        /// <param name="right">Right Fill.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (Fill left, Fill right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Fill and the right Fill.
        /// </summary>
        /// <param name="left">Left Fill.</param>
        /// <param name="right">Right Fill.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (Fill left, Fill right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Fill</returns>
        public Fill DeepClone()
        {
            using MemoryStream ms = new();
            
            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;
            return JsonSerializer.DeserializeAsync<Fill>(ms).Result;
        }
    }
}