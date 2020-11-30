using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Plotly.Models.Traces.Scatter3Ds.Projections
{
    /// <summary>
    ///     The Z class.
    /// </summary>
    
    [Serializable]
    public class Z : IEquatable<Z>
    {
        /// <summary>
        ///     Sets whether or not projections are shown along the z axis.
        /// </summary>
        [JsonPropertyName(@"show")]
        public bool? Show { get; set;} 

        /// <summary>
        ///     Sets the projection color.
        /// </summary>
        [JsonPropertyName(@"opacity")]
        public JsNumber? Opacity { get; set;} 

        /// <summary>
        ///     Sets the scale factor determining the size of the projection marker points.
        /// </summary>
        [JsonPropertyName(@"scale")]
        public JsNumber? Scale { get; set;} 

        
        public override bool Equals(object obj)
        {
            if (!(obj is Z other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        
        public bool Equals([AllowNull] Z other)
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
                    Opacity == other.Opacity &&
                    Opacity != null && other.Opacity != null &&
                    Opacity.Equals(other.Opacity)
                ) && 
                (
                    Scale == other.Scale &&
                    Scale != null && other.Scale != null &&
                    Scale.Equals(other.Scale)
                );
        }

        
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (Show != null) hashCode = hashCode * 59 + Show.GetHashCode();
                if (Opacity != null) hashCode = hashCode * 59 + Opacity.GetHashCode();
                if (Scale != null) hashCode = hashCode * 59 + Scale.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Z and the right Z.
        /// </summary>
        /// <param name="left">Left Z.</param>
        /// <param name="right">Right Z.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (Z left, Z right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Z and the right Z.
        /// </summary>
        /// <param name="left">Left Z.</param>
        /// <param name="right">Right Z.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (Z left, Z right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Z</returns>
        public Z DeepClone()
        {
            using MemoryStream ms = new();
            
            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;
            return JsonSerializer.DeserializeAsync<Z>(ms).Result;
        }
    }
}