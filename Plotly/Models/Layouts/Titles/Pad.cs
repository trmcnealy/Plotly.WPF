using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Plotly.Models.Layouts.Titles
{
    /// <summary>
    ///     The Pad class.
    /// </summary>
    
    [Serializable]
    public class Pad : IEquatable<Pad>
    {
        /// <summary>
        ///     The amount of padding (in px) along the top of the component.
        /// </summary>
        [JsonPropertyName(@"t")]
        public JsNumber? T { get; set;} 

        /// <summary>
        ///     The amount of padding (in px) on the right side of the component.
        /// </summary>
        [JsonPropertyName(@"r")]
        public JsNumber? R { get; set;} 

        /// <summary>
        ///     The amount of padding (in px) along the bottom of the component.
        /// </summary>
        [JsonPropertyName(@"b")]
        public JsNumber? B { get; set;} 

        /// <summary>
        ///     The amount of padding (in px) on the left side of the component.
        /// </summary>
        [JsonPropertyName(@"l")]
        public JsNumber? L { get; set;} 

        
        public override bool Equals(object obj)
        {
            if (!(obj is Pad other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        
        public bool Equals([AllowNull] Pad other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    T == other.T &&
                    T != null && other.T != null &&
                    T.Equals(other.T)
                ) && 
                (
                    R == other.R &&
                    R != null && other.R != null &&
                    R.Equals(other.R)
                ) && 
                (
                    B == other.B &&
                    B != null && other.B != null &&
                    B.Equals(other.B)
                ) && 
                (
                    L == other.L &&
                    L != null && other.L != null &&
                    L.Equals(other.L)
                );
        }

        
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (T != null) hashCode = hashCode * 59 + T.GetHashCode();
                if (R != null) hashCode = hashCode * 59 + R.GetHashCode();
                if (B != null) hashCode = hashCode * 59 + B.GetHashCode();
                if (L != null) hashCode = hashCode * 59 + L.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Pad and the right Pad.
        /// </summary>
        /// <param name="left">Left Pad.</param>
        /// <param name="right">Right Pad.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (Pad left, Pad right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Pad and the right Pad.
        /// </summary>
        /// <param name="left">Left Pad.</param>
        /// <param name="right">Right Pad.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (Pad left, Pad right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Pad</returns>
        public Pad DeepClone()
        {
            using MemoryStream ms = new();
            
            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;
            return JsonSerializer.DeserializeAsync<Pad>(ms).Result;
        }
    }
}