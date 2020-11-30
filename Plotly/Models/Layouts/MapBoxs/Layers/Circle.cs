using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Plotly.Models.Layouts.MapBoxs.Layers
{
    /// <summary>
    ///     The Circle class.
    /// </summary>
    
    [Serializable]
    public class Circle : IEquatable<Circle>
    {
        /// <summary>
        ///     Sets the circle radius (mapbox.layer.paint.circle-radius). Has an effect
        ///     only when <c>type</c> is set to <c>circle</c>.
        /// </summary>
        [JsonPropertyName(@"radius")]
        public JsNumber? Radius { get; set;} 

        
        public override bool Equals(object obj)
        {
            if (!(obj is Circle other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        
        public bool Equals([AllowNull] Circle other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Radius == other.Radius &&
                    Radius != null && other.Radius != null &&
                    Radius.Equals(other.Radius)
                );
        }

        
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (Radius != null) hashCode = hashCode * 59 + Radius.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Circle and the right Circle.
        /// </summary>
        /// <param name="left">Left Circle.</param>
        /// <param name="right">Right Circle.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (Circle left, Circle right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Circle and the right Circle.
        /// </summary>
        /// <param name="left">Left Circle.</param>
        /// <param name="right">Right Circle.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (Circle left, Circle right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Circle</returns>
        public Circle DeepClone()
        {
            using MemoryStream ms = new();
            
            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;
            return JsonSerializer.DeserializeAsync<Circle>(ms).Result;
        }
    }
}