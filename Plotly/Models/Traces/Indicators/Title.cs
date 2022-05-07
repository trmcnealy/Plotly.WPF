using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Traces.Indicators.Titles;

namespace Plotly.Models.Traces.Indicators
{
    /// <summary>
    ///     The Title class.
    /// </summary>
    [Serializable]
    public class Title : IEquatable<Title>
    {
        /// <summary>
        ///     Sets the title of this indicator.
        /// </summary>
        [JsonPropertyName(@"text")]
        public string? Text { get; set; }

        /// <summary>
        ///     Sets the horizontal alignment of the title. It defaults to <c>center</c>
        ///     except for bullet charts for which it defaults to right.
        /// </summary>
        [JsonPropertyName(@"align")]
        public Titles.AlignEnum? Align { get; set; }

        /// <summary>
        ///     Set the font used to display the title
        /// </summary>
        [JsonPropertyName(@"font")]
        public Font? Font { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is Title other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] Title other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (Text  == other.Text  && Text  != null && other.Text  != null && Text.Equals(other.Text))   &&
                   (Align == other.Align && Align != null && other.Align != null && Align.Equals(other.Align)) &&
                   (Font  == other.Font  && Font  != null && other.Font  != null && Font.Equals(other.Font));
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;

                if(Text != null)
                    hashCode = hashCode * 59 + Text.GetHashCode();

                if(Align != null)
                    hashCode = hashCode * 59 + Align.GetHashCode();

                if(Font != null)
                    hashCode = hashCode * 59 + Font.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Title and the right Title.
        /// </summary>
        /// <param name="left">Left Title.</param>
        /// <param name="right">Right Title.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(Title left,
                                       Title right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Title and the right Title.
        /// </summary>
        /// <param name="left">Left Title.</param>
        /// <param name="right">Right Title.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(Title left,
                                       Title right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Title</returns>
        public Title? DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<Title>(ms).Result;
        }
    }
}
