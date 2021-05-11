using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Traces.Surfaces.Contourss.Zs;

namespace Plotly.Models.Traces.Surfaces.Contourss
{
    /// <summary>
    ///     The Z class.
    /// </summary>
    [Serializable]
    public class Z : IEquatable<Z>
    {
        /// <summary>
        ///     Determines whether or not contour lines about the z dimension are drawn.
        /// </summary>
        [JsonPropertyName(@"show")]
        public bool? Show { get; set; }

        /// <summary>
        ///     Sets the starting contour level value. Must be less than <c>contours.end</c>
        /// </summary>
        [JsonPropertyName(@"start")]
        public JsNumber? Start { get; set; }

        /// <summary>
        ///     Sets the end contour level value. Must be more than <c>contours.start</c>
        /// </summary>
        [JsonPropertyName(@"end")]
        public JsNumber? End { get; set; }

        /// <summary>
        ///     Sets the step between each contour level. Must be positive.
        /// </summary>
        [JsonPropertyName(@"size")]
        public JsNumber? Size { get; set; }

        /// <summary>
        ///     Gets or sets the Project.
        /// </summary>
        [JsonPropertyName(@"project")]
        public Project Project { get; set; }

        /// <summary>
        ///     Sets the color of the contour lines.
        /// </summary>
        [JsonPropertyName(@"color")]
        public object Color { get; set; }

        /// <summary>
        ///     An alternate to <c>color</c>. Determines whether or not the contour lines
        ///     are colored using the trace <c>colorscale</c>.
        /// </summary>
        [JsonPropertyName(@"usecolormap")]
        public bool? UseColorMap { get; set; }

        /// <summary>
        ///     Sets the width of the contour lines.
        /// </summary>
        [JsonPropertyName(@"width")]
        public JsNumber? Width { get; set; }

        /// <summary>
        ///     Determines whether or not contour lines about the z dimension are highlighted
        ///     on hover.
        /// </summary>
        [JsonPropertyName(@"highlight")]
        public bool? Highlight { get; set; }

        /// <summary>
        ///     Sets the color of the highlighted contour lines.
        /// </summary>
        [JsonPropertyName(@"highlightcolor")]
        public object HighlightColor { get; set; }

        /// <summary>
        ///     Sets the width of the highlighted contour lines.
        /// </summary>
        [JsonPropertyName(@"highlightwidth")]
        public JsNumber? HighlightWidth { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is Z other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] Z other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (Show           == other.Show           && Show           != null && other.Show           != null && Show.Equals(other.Show))                     &&
                   (Start          == other.Start          && Start          != null && other.Start          != null && Start.Equals(other.Start))                   &&
                   (End            == other.End            && End            != null && other.End            != null && End.Equals(other.End))                       &&
                   (Size           == other.Size           && Size           != null && other.Size           != null && Size.Equals(other.Size))                     &&
                   (Project        == other.Project        && Project        != null && other.Project        != null && Project.Equals(other.Project))               &&
                   (Color          == other.Color          && Color          != null && other.Color          != null && Color.Equals(other.Color))                   &&
                   (UseColorMap    == other.UseColorMap    && UseColorMap    != null && other.UseColorMap    != null && UseColorMap.Equals(other.UseColorMap))       &&
                   (Width          == other.Width          && Width          != null && other.Width          != null && Width.Equals(other.Width))                   &&
                   (Highlight      == other.Highlight      && Highlight      != null && other.Highlight      != null && Highlight.Equals(other.Highlight))           &&
                   (HighlightColor == other.HighlightColor && HighlightColor != null && other.HighlightColor != null && HighlightColor.Equals(other.HighlightColor)) &&
                   (HighlightWidth == other.HighlightWidth && HighlightWidth != null && other.HighlightWidth != null && HighlightWidth.Equals(other.HighlightWidth));
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;

                if(Show != null)
                    hashCode = hashCode * 59 + Show.GetHashCode();

                if(Start != null)
                    hashCode = hashCode * 59 + Start.GetHashCode();

                if(End != null)
                    hashCode = hashCode * 59 + End.GetHashCode();

                if(Size != null)
                    hashCode = hashCode * 59 + Size.GetHashCode();

                if(Project != null)
                    hashCode = hashCode * 59 + Project.GetHashCode();

                if(Color != null)
                    hashCode = hashCode * 59 + Color.GetHashCode();

                if(UseColorMap != null)
                    hashCode = hashCode * 59 + UseColorMap.GetHashCode();

                if(Width != null)
                    hashCode = hashCode * 59 + Width.GetHashCode();

                if(Highlight != null)
                    hashCode = hashCode * 59 + Highlight.GetHashCode();

                if(HighlightColor != null)
                    hashCode = hashCode * 59 + HighlightColor.GetHashCode();

                if(HighlightWidth != null)
                    hashCode = hashCode * 59 + HighlightWidth.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Z and the right Z.
        /// </summary>
        /// <param name="left">Left Z.</param>
        /// <param name="right">Right Z.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(Z left,
                                       Z right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Z and the right Z.
        /// </summary>
        /// <param name="left">Left Z.</param>
        /// <param name="right">Right Z.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(Z left,
                                       Z right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Z</returns>
        public Z DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<Z>(ms).Result;
        }
    }
}
