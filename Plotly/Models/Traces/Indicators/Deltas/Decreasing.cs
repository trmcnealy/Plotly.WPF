using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Plotly.Models.Traces.Indicators.Deltas
{
    /// <summary>
    ///     The Decreasing class.
    /// </summary>
    [Serializable]
    public class Decreasing : IEquatable<Decreasing>
    {
        /// <summary>
        ///     Sets the symbol to display for increasing value
        /// </summary>
        [JsonPropertyName(@"symbol")]
        public string? Symbol { get; set; }

        /// <summary>
        ///     Sets the color for increasing value.
        /// </summary>
        [JsonPropertyName(@"color")]
        public object? Color { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is Decreasing other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] Decreasing other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (Symbol == other.Symbol && Symbol != null && other.Symbol != null && Symbol.Equals(other.Symbol)) &&
                   (Color  == other.Color  && Color  != null && other.Color  != null && Color.Equals(other.Color));
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;

                if(Symbol != null)
                    hashCode = hashCode * 59 + Symbol.GetHashCode();

                if(Color != null)
                    hashCode = hashCode * 59 + Color.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Decreasing and the right Decreasing.
        /// </summary>
        /// <param name="left">Left Decreasing.</param>
        /// <param name="right">Right Decreasing.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(Decreasing left,
                                       Decreasing right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Decreasing and the right Decreasing.
        /// </summary>
        /// <param name="left">Left Decreasing.</param>
        /// <param name="right">Right Decreasing.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(Decreasing left,
                                       Decreasing right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Decreasing</returns>
        public Decreasing DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<Decreasing>(ms).Result;
        }
    }
}
