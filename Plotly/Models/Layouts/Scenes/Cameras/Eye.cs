using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Plotly.Models.Layouts.Scenes.Cameras
{
    /// <summary>
    ///     The Eye class.
    /// </summary>
    
    [Serializable]
    public class Eye : IEquatable<Eye>
    {
        /// <summary>
        ///     Gets or sets the X.
        /// </summary>
        [JsonPropertyName(@"x")]
        public JsNumber? X { get; set;} 

        /// <summary>
        ///     Gets or sets the Y.
        /// </summary>
        [JsonPropertyName(@"y")]
        public JsNumber? Y { get; set;} 

        /// <summary>
        ///     Gets or sets the Z.
        /// </summary>
        [JsonPropertyName(@"z")]
        public JsNumber? Z { get; set;} 

        
        public override bool Equals(object obj)
        {
            if (!(obj is Eye other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        
        public bool Equals([AllowNull] Eye other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    X == other.X &&
                    X != null && other.X != null &&
                    X.Equals(other.X)
                ) && 
                (
                    Y == other.Y &&
                    Y != null && other.Y != null &&
                    Y.Equals(other.Y)
                ) && 
                (
                    Z == other.Z &&
                    Z != null && other.Z != null &&
                    Z.Equals(other.Z)
                );
        }

        
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (X != null) hashCode = hashCode * 59 + X.GetHashCode();
                if (Y != null) hashCode = hashCode * 59 + Y.GetHashCode();
                if (Z != null) hashCode = hashCode * 59 + Z.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Eye and the right Eye.
        /// </summary>
        /// <param name="left">Left Eye.</param>
        /// <param name="right">Right Eye.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (Eye left, Eye right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Eye and the right Eye.
        /// </summary>
        /// <param name="left">Left Eye.</param>
        /// <param name="right">Right Eye.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (Eye left, Eye right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Eye</returns>
        public Eye DeepClone()
        {
            using MemoryStream ms = new();
            
            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;
            return JsonSerializer.DeserializeAsync<Eye>(ms).Result;
        }
    }
}