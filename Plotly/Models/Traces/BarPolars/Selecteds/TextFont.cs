using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Plotly.Models.Traces.BarPolars.Selecteds
{
    /// <summary>
    ///     The TextFont class.
    /// </summary>
    [Serializable]
    public class TextFont : IEquatable<TextFont>
    {
        /// <summary>
        ///     Sets the text font color of selected points.
        /// </summary>
        [JsonPropertyName(@"color")]
        public object? Color { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is TextFont other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] TextFont other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (Color == other.Color && Color != null && other.Color != null && Color.Equals(other.Color));
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;

                if(Color != null)
                    hashCode = hashCode * 59 + Color.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left TextFont and the right TextFont.
        /// </summary>
        /// <param name="left">Left TextFont.</param>
        /// <param name="right">Right TextFont.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(TextFont left,
                                       TextFont right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left TextFont and the right TextFont.
        /// </summary>
        /// <param name="left">Left TextFont.</param>
        /// <param name="right">Right TextFont.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(TextFont left,
                                       TextFont right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>TextFont</returns>
        public TextFont DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<TextFont>(ms).Result;
        }
    }
}
