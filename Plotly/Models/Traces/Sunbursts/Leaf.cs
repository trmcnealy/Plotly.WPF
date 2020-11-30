using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Plotly.Models.Traces.Sunbursts
{
    /// <summary>
    ///     The Leaf class.
    /// </summary>
    
    [Serializable]
    public class Leaf : IEquatable<Leaf>
    {
        /// <summary>
        ///     Sets the opacity of the leaves. With colorscale it is defaulted to 1; otherwise
        ///     it is defaulted to 0.7
        /// </summary>
        [JsonPropertyName(@"opacity")]
        public JsNumber? Opacity { get; set;} 

        
        public override bool Equals(object obj)
        {
            if (!(obj is Leaf other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        
        public bool Equals([AllowNull] Leaf other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Opacity == other.Opacity &&
                    Opacity != null && other.Opacity != null &&
                    Opacity.Equals(other.Opacity)
                );
        }

        
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (Opacity != null) hashCode = hashCode * 59 + Opacity.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Leaf and the right Leaf.
        /// </summary>
        /// <param name="left">Left Leaf.</param>
        /// <param name="right">Right Leaf.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (Leaf left, Leaf right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Leaf and the right Leaf.
        /// </summary>
        /// <param name="left">Left Leaf.</param>
        /// <param name="right">Right Leaf.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (Leaf left, Leaf right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Leaf</returns>
        public Leaf DeepClone()
        {
            using MemoryStream ms = new();
            
            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;
            return JsonSerializer.DeserializeAsync<Leaf>(ms).Result;
        }
    }
}