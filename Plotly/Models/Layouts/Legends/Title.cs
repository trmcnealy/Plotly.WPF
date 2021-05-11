using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Layouts.Legends.Titles;

namespace Plotly.Models.Layouts.Legends
{
    /// <summary>
    ///     The Title class.
    /// </summary>
    [Serializable]
    public class Title : IEquatable<Title>
    {
        /// <summary>
        ///     Sets the title of the legend.
        /// </summary>
        [JsonPropertyName(@"text")]
        public string Text { get; set; }

        /// <summary>
        ///     Sets this legend&#39;s title font.
        /// </summary>
        [JsonPropertyName(@"font")]
        public Titles.Font Font { get; set; }

        /// <summary>
        ///     Determines the location of legend&#39;s title with respect to the legend
        ///     items. Defaulted to <c>top</c> with <c>orientation</c> is <c>h</c>. Defaulted
        ///     to <c>left</c> with <c>orientation</c> is <c>v</c>. The &#39;top left&#39;
        ///     options could be used to expand legend area in both x and y sides.
        /// </summary>
        [JsonPropertyName(@"side")]
        public SideEnum? Side { get; set; }

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

            return (Text == other.Text && Text != null && other.Text != null && Text.Equals(other.Text)) &&
                   (Font == other.Font && Font != null && other.Font != null && Font.Equals(other.Font)) &&
                   (Side == other.Side && Side != null && other.Side != null && Side.Equals(other.Side));
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;

                if(Text != null)
                    hashCode = hashCode * 59 + Text.GetHashCode();

                if(Font != null)
                    hashCode = hashCode * 59 + Font.GetHashCode();

                if(Side != null)
                    hashCode = hashCode * 59 + Side.GetHashCode();

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
        public Title DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<Title>(ms).Result;
        }
    }
}
