using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Plotly.Models.Traces.Volumes
{
    /// <summary>
    ///     The Contour class.
    /// </summary>
    
    [Serializable]
    public class Contour : IEquatable<Contour>
    {
        /// <summary>
        ///     Sets whether or not dynamic contours are shown on hover
        /// </summary>
        [JsonPropertyName(@"show")]
        public bool? Show { get; set;} 

        /// <summary>
        ///     Sets the color of the contour lines.
        /// </summary>
        [JsonPropertyName(@"color")]
        public object Color { get; set;} 

        /// <summary>
        ///     Sets the width of the contour lines.
        /// </summary>
        [JsonPropertyName(@"width")]
        public JsNumber? Width { get; set;} 

        
        public override bool Equals(object obj)
        {
            if (!(obj is Contour other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        
        public bool Equals([AllowNull] Contour other)
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
                    Color == other.Color &&
                    Color != null && other.Color != null &&
                    Color.Equals(other.Color)
                ) && 
                (
                    Width == other.Width &&
                    Width != null && other.Width != null &&
                    Width.Equals(other.Width)
                );
        }

        
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (Show != null) hashCode = hashCode * 59 + Show.GetHashCode();
                if (Color != null) hashCode = hashCode * 59 + Color.GetHashCode();
                if (Width != null) hashCode = hashCode * 59 + Width.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Contour and the right Contour.
        /// </summary>
        /// <param name="left">Left Contour.</param>
        /// <param name="right">Right Contour.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (Contour left, Contour right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Contour and the right Contour.
        /// </summary>
        /// <param name="left">Left Contour.</param>
        /// <param name="right">Right Contour.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (Contour left, Contour right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Contour</returns>
        public Contour DeepClone()
        {
            using MemoryStream ms = new();
            
            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;
            return JsonSerializer.DeserializeAsync<Contour>(ms).Result;
        }
    }
}