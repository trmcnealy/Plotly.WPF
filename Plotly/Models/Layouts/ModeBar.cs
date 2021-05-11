using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Layouts.ModeBars;

namespace Plotly.Models.Layouts
{
    /// <summary>
    ///     The ModeBar class.
    /// </summary>
    [Serializable]
    public class ModeBar : IEquatable<ModeBar>
    {
        /// <summary>
        ///     Sets the orientation of the modebar.
        /// </summary>
        [JsonPropertyName(@"orientation")]
        public OrientationEnum? Orientation { get; set; }

        /// <summary>
        ///     Sets the background color of the modebar.
        /// </summary>
        [JsonPropertyName(@"bgcolor")]
        public object BgColor { get; set; }

        /// <summary>
        ///     Sets the color of the icons in the modebar.
        /// </summary>
        [JsonPropertyName(@"color")]
        public object Color { get; set; }

        /// <summary>
        ///     Sets the color of the active or hovered on icons in the modebar.
        /// </summary>
        [JsonPropertyName(@"activecolor")]
        public object ActiveColor { get; set; }

        /// <summary>
        ///     Controls persistence of user-driven changes related to the modebar, including
        ///     <c>hovermode</c>, <c>dragmode</c>, and <c>showspikes</c> at both the root
        ///     level and inside subplots. Defaults to <c>layout.uirevision</c>.
        /// </summary>
        [JsonPropertyName(@"uirevision")]
        public object UiRevision { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is ModeBar other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] ModeBar other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (Orientation == other.Orientation && Orientation != null && other.Orientation != null && Orientation.Equals(other.Orientation)) &&
                   (BgColor     == other.BgColor     && BgColor     != null && other.BgColor     != null && BgColor.Equals(other.BgColor))         &&
                   (Color       == other.Color       && Color       != null && other.Color       != null && Color.Equals(other.Color))             &&
                   (ActiveColor == other.ActiveColor && ActiveColor != null && other.ActiveColor != null && ActiveColor.Equals(other.ActiveColor)) &&
                   (UiRevision  == other.UiRevision  && UiRevision  != null && other.UiRevision  != null && UiRevision.Equals(other.UiRevision));
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;

                if(Orientation != null)
                    hashCode = hashCode * 59 + Orientation.GetHashCode();

                if(BgColor != null)
                    hashCode = hashCode * 59 + BgColor.GetHashCode();

                if(Color != null)
                    hashCode = hashCode * 59 + Color.GetHashCode();

                if(ActiveColor != null)
                    hashCode = hashCode * 59 + ActiveColor.GetHashCode();

                if(UiRevision != null)
                    hashCode = hashCode * 59 + UiRevision.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left ModeBar and the right ModeBar.
        /// </summary>
        /// <param name="left">Left ModeBar.</param>
        /// <param name="right">Right ModeBar.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(ModeBar left,
                                       ModeBar right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left ModeBar and the right ModeBar.
        /// </summary>
        /// <param name="left">Left ModeBar.</param>
        /// <param name="right">Right ModeBar.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(ModeBar left,
                                       ModeBar right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>ModeBar</returns>
        public ModeBar DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<ModeBar>(ms).Result;
        }
    }
}
