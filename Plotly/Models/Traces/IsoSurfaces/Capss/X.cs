using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Plotly.Models.Traces.IsoSurfaces.Capss
{
    /// <summary>
    ///     The X class.
    /// </summary>
    
    [Serializable]
    public class X : IEquatable<X>
    {
        /// <summary>
        ///     Sets the fill ratio of the <c>slices</c>. The default fill value of the
        ///     x <c>slices</c> is 1 meaning that they are entirely shaded. On the other
        ///     hand Applying a <c>fill</c> ratio less than one would allow the creation
        ///     of openings parallel to the edges.
        /// </summary>
        [JsonPropertyName(@"show")]
        public bool? Show { get; set;} 

        /// <summary>
        ///     Sets the fill ratio of the <c>caps</c>. The default fill value of the <c>caps</c>
        ///     is 1 meaning that they are entirely shaded. On the other hand Applying a
        ///     <c>fill</c> ratio less than one would allow the creation of openings parallel
        ///     to the edges.
        /// </summary>
        [JsonPropertyName(@"fill")]
        public JsNumber? Fill { get; set;} 

        
        public override bool Equals(object obj)
        {
            if (!(obj is X other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        
        public bool Equals([AllowNull] X other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Show == other.Show &&
                    Show != null && other.Show != null &&
                    Show.Equals(other.Show)
                ) && 
                (
                    Fill == other.Fill &&
                    Fill != null && other.Fill != null &&
                    Fill.Equals(other.Fill)
                );
        }

        
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (Show != null) hashCode = hashCode * 59 + Show.GetHashCode();
                if (Fill != null) hashCode = hashCode * 59 + Fill.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left X and the right X.
        /// </summary>
        /// <param name="left">Left X.</param>
        /// <param name="right">Right X.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (X left, X right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left X and the right X.
        /// </summary>
        /// <param name="left">Left X.</param>
        /// <param name="right">Right X.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (X left, X right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>X</returns>
        public X DeepClone()
        {
            using MemoryStream ms = new();
            
            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;
            return JsonSerializer.DeserializeAsync<X>(ms).Result;
        }
    }
}