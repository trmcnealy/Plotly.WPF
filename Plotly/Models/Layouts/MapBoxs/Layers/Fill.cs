using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Plotly.Models.Layouts.MapBoxs.Layers
{
    /// <summary>
    ///     The Fill class.
    /// </summary>
    
    [Serializable]
    public class Fill : IEquatable<Fill>
    {
        /// <summary>
        ///     Sets the fill outline color (mapbox.layer.paint.fill-outline-color). Has
        ///     an effect only when <c>type</c> is set to <c>fill</c>.
        /// </summary>
        [JsonPropertyName(@"outlinecolor")]
        public object OutlineColor { get; set;} 

        
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
                    OutlineColor == other.OutlineColor &&
                    OutlineColor != null && other.OutlineColor != null &&
                    OutlineColor.Equals(other.OutlineColor)
                );
        }

        
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (OutlineColor != null) hashCode = hashCode * 59 + OutlineColor.GetHashCode();
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