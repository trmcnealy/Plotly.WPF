using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Traces.Indicators.Numbers;

namespace Plotly.Models.Traces.Indicators
{
    /// <summary>
    ///     The Number class.
    /// </summary>
    
    [Serializable]
    public class Number : IEquatable<Number>
    {
        /// <summary>
        ///     Sets the value formatting rule using d3 formatting mini-language which is
        ///     similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        /// </summary>
        [JsonPropertyName(@"valueformat")]
        public string ValueFormat { get; set;} 

        /// <summary>
        ///     Set the font used to display main number
        /// </summary>
        [JsonPropertyName(@"font")]
        public Font Font { get; set;} 

        /// <summary>
        ///     Sets a prefix appearing before the number.
        /// </summary>
        [JsonPropertyName(@"prefix")]
        public string Prefix { get; set;} 

        /// <summary>
        ///     Sets a suffix appearing next to the number.
        /// </summary>
        [JsonPropertyName(@"suffix")]
        public string Suffix { get; set;} 

        
        public override bool Equals(object obj)
        {
            if (!(obj is Number other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        
        public bool Equals([AllowNull] Number other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ValueFormat == other.ValueFormat &&
                    ValueFormat != null && other.ValueFormat != null &&
                    ValueFormat.Equals(other.ValueFormat)
                ) && 
                (
                    Font == other.Font &&
                    Font != null && other.Font != null &&
                    Font.Equals(other.Font)
                ) && 
                (
                    Prefix == other.Prefix &&
                    Prefix != null && other.Prefix != null &&
                    Prefix.Equals(other.Prefix)
                ) && 
                (
                    Suffix == other.Suffix &&
                    Suffix != null && other.Suffix != null &&
                    Suffix.Equals(other.Suffix)
                );
        }

        
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (ValueFormat != null) hashCode = hashCode * 59 + ValueFormat.GetHashCode();
                if (Font != null) hashCode = hashCode * 59 + Font.GetHashCode();
                if (Prefix != null) hashCode = hashCode * 59 + Prefix.GetHashCode();
                if (Suffix != null) hashCode = hashCode * 59 + Suffix.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Number and the right Number.
        /// </summary>
        /// <param name="left">Left Number.</param>
        /// <param name="right">Right Number.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (Number left, Number right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Number and the right Number.
        /// </summary>
        /// <param name="left">Left Number.</param>
        /// <param name="right">Right Number.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (Number left, Number right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Number</returns>
        public Number DeepClone()
        {
            using MemoryStream ms = new();
            
            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;
            return JsonSerializer.DeserializeAsync<Number>(ms).Result;
        }
    }
}