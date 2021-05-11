using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Plotly.Models.Layouts.Scenes.Annotations
{
    /// <summary>
    ///     The HoverLabel class.
    /// </summary>
    [Serializable]
    public class HoverLabel : IEquatable<HoverLabel>
    {
        /// <summary>
        ///     Sets the background color of the hover label. By default uses the annotation&#39;s
        ///     <c>bgcolor</c> made opaque, or white if it was transparent.
        /// </summary>
        [JsonPropertyName(@"bgcolor")]
        public object BgColor { get; set; }

        /// <summary>
        ///     Sets the border color of the hover label. By default uses either dark grey
        ///     or white, for maximum contrast with <c>hoverlabel.bgcolor</c>.
        /// </summary>
        [JsonPropertyName(@"bordercolor")]
        public object BorderColor { get; set; }

        /// <summary>
        ///     Sets the hover label text font. By default uses the global hover font and
        ///     size, with color from <c>hoverlabel.bordercolor</c>.
        /// </summary>
        [JsonPropertyName(@"font")]
        public HoverLabels.Font Font { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is HoverLabel other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] HoverLabel other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (BgColor     == other.BgColor     && BgColor     != null && other.BgColor     != null && BgColor.Equals(other.BgColor))         &&
                   (BorderColor == other.BorderColor && BorderColor != null && other.BorderColor != null && BorderColor.Equals(other.BorderColor)) &&
                   (Font        == other.Font        && Font        != null && other.Font        != null && Font.Equals(other.Font));
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;

                if(BgColor != null)
                    hashCode = hashCode * 59 + BgColor.GetHashCode();

                if(BorderColor != null)
                    hashCode = hashCode * 59 + BorderColor.GetHashCode();

                if(Font != null)
                    hashCode = hashCode * 59 + Font.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left HoverLabel and the right HoverLabel.
        /// </summary>
        /// <param name="left">Left HoverLabel.</param>
        /// <param name="right">Right HoverLabel.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(HoverLabel left,
                                       HoverLabel right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left HoverLabel and the right HoverLabel.
        /// </summary>
        /// <param name="left">Left HoverLabel.</param>
        /// <param name="right">Right HoverLabel.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(HoverLabel left,
                                       HoverLabel right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>HoverLabel</returns>
        public HoverLabel DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<HoverLabel>(ms).Result;
        }
    }
}
