using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Layouts.Titles;

namespace Plotly.Models.Layouts
{
    /// <summary>
    ///     The Title class.
    /// </summary>
    [Serializable]
    public class Title : IEquatable<Title>
    {
        /// <summary>
        ///     Sets the plot&#39;s title. Note that before the existence of <c>title.text</c>,
        ///     the title&#39;s contents used to be defined as the <c>title</c> attribute
        ///     itself. This behavior has been deprecated.
        /// </summary>
        [JsonPropertyName(@"text")]
        public string Text { get; set; }

        /// <summary>
        ///     Sets the title font. Note that the title&#39;s font used to be customized
        ///     by the now deprecated <c>titlefont</c> attribute.
        /// </summary>
        [JsonPropertyName(@"font")]
        public Titles.Font Font { get; set; }

        /// <summary>
        ///     Sets the container <c>x</c> refers to. <c>container</c> spans the entire
        ///     <c>width</c> of the plot. <c>paper</c> refers to the width of the plotting
        ///     area only.
        /// </summary>
        [JsonPropertyName(@"xref")]
        public XRefEnum? XRef { get; set; }

        /// <summary>
        ///     Sets the container <c>y</c> refers to. <c>container</c> spans the entire
        ///     <c>height</c> of the plot. <c>paper</c> refers to the height of the plotting
        ///     area only.
        /// </summary>
        [JsonPropertyName(@"yref")]
        public YRefEnum? YRef { get; set; }

        /// <summary>
        ///     Sets the x position with respect to <c>xref</c> in normalized coordinates
        ///     from <c>0</c> (left) to <c>1</c> (right).
        /// </summary>
        [JsonPropertyName(@"x")]
        public JsNumber? X { get; set; }

        /// <summary>
        ///     Sets the y position with respect to <c>yref</c> in normalized coordinates
        ///     from <c>0</c> (bottom) to <c>1</c> (top). <c>auto</c> places the baseline
        ///     of the title onto the vertical center of the top margin.
        /// </summary>
        [JsonPropertyName(@"y")]
        public JsNumber? Y { get; set; }

        /// <summary>
        ///     Sets the title&#39;s horizontal alignment with respect to its x position.
        ///     <c>left</c> means that the title starts at x, <c>right</c> means that the
        ///     title ends at x and <c>center</c> means that the title&#39;s center is at
        ///     x. <c>auto</c> divides <c>xref</c> by three and calculates the <c>xanchor</c>
        ///     value automatically based on the value of <c>x</c>.
        /// </summary>
        [JsonPropertyName(@"xanchor")]
        public XAnchorEnum? XAnchor { get; set; }

        /// <summary>
        ///     Sets the title&#39;s vertical alignment with respect to its y position.
        ///     <c>top</c> means that the title&#39;s cap line is at y, <c>bottom</c> means
        ///     that the title&#39;s baseline is at y and <c>middle</c> means that the title&#39;s
        ///     midline is at y. <c>auto</c> divides <c>yref</c> by three and calculates
        ///     the <c>yanchor</c> value automatically based on the value of <c>y</c>.
        /// </summary>
        [JsonPropertyName(@"yanchor")]
        public YAnchorEnum? YAnchor { get; set; }

        /// <summary>
        ///     Sets the padding of the title. Each padding value only applies when the
        ///     corresponding <c>xanchor</c>/<c>yanchor</c> value is set accordingly. E.g.
        ///     for left padding to take effect, <c>xanchor</c> must be set to <c>left</c>.
        ///     The same rule applies if <c>xanchor</c>/<c>yanchor</c> is determined automatically.
        ///     Padding is muted if the respective anchor value is <c>middle</c>/<c>center</c>.
        /// </summary>
        [JsonPropertyName(@"pad")]
        public Pad Pad { get; set; }

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

            return (Text    == other.Text    && Text    != null && other.Text    != null && Text.Equals(other.Text))       &&
                   (Font    == other.Font    && Font    != null && other.Font    != null && Font.Equals(other.Font))       &&
                   (XRef    == other.XRef    && XRef    != null && other.XRef    != null && XRef.Equals(other.XRef))       &&
                   (YRef    == other.YRef    && YRef    != null && other.YRef    != null && YRef.Equals(other.YRef))       &&
                   (X       == other.X       && X       != null && other.X       != null && X.Equals(other.X))             &&
                   (Y       == other.Y       && Y       != null && other.Y       != null && Y.Equals(other.Y))             &&
                   (XAnchor == other.XAnchor && XAnchor != null && other.XAnchor != null && XAnchor.Equals(other.XAnchor)) &&
                   (YAnchor == other.YAnchor && YAnchor != null && other.YAnchor != null && YAnchor.Equals(other.YAnchor)) &&
                   (Pad     == other.Pad     && Pad     != null && other.Pad     != null && Pad.Equals(other.Pad));
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

                if(XRef != null)
                    hashCode = hashCode * 59 + XRef.GetHashCode();

                if(YRef != null)
                    hashCode = hashCode * 59 + YRef.GetHashCode();

                if(X != null)
                    hashCode = hashCode * 59 + X.GetHashCode();

                if(Y != null)
                    hashCode = hashCode * 59 + Y.GetHashCode();

                if(XAnchor != null)
                    hashCode = hashCode * 59 + XAnchor.GetHashCode();

                if(YAnchor != null)
                    hashCode = hashCode * 59 + YAnchor.GetHashCode();

                if(Pad != null)
                    hashCode = hashCode * 59 + Pad.GetHashCode();

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
