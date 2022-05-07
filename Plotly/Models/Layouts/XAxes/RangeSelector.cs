using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Layouts.XAxes.RangeSelectors;

namespace Plotly.Models.Layouts.XAxes
{
    /// <summary>
    ///     The RangeSelector class.
    /// </summary>
    [Serializable]
    public class RangeSelector : IEquatable<RangeSelector>
    {
        /// <summary>
        ///     Determines whether or not this range selector is visible. Note that range
        ///     selectors are only available for x axes of <c>type</c> set to or auto-typed
        ///     to <c>date</c>.
        /// </summary>
        [JsonPropertyName(@"visible")]
        public bool? Visible { get; set; }

        /// <summary>
        ///     Gets or sets the Buttons.
        /// </summary>
        [JsonPropertyName(@"buttons")]
        public List<Button>? Buttons { get; set; }

        /// <summary>
        ///     Sets the x position (in normalized coordinates) of the range selector.
        /// </summary>
        [JsonPropertyName(@"x")]
        public JsNumber? X { get; set; }

        /// <summary>
        ///     Sets the range selector&#39;s horizontal position anchor. This anchor binds
        ///     the <c>x</c> position to the <c>left</c>, <c>center</c> or <c>right</c>
        ///     of the range selector.
        /// </summary>
        [JsonPropertyName(@"xanchor")]
        public XAnchorEnum? XAnchor { get; set; }

        /// <summary>
        ///     Sets the y position (in normalized coordinates) of the range selector.
        /// </summary>
        [JsonPropertyName(@"y")]
        public JsNumber? Y { get; set; }

        /// <summary>
        ///     Sets the range selector&#39;s vertical position anchor This anchor binds
        ///     the <c>y</c> position to the <c>top</c>, <c>middle</c> or <c>bottom</c>
        ///     of the range selector.
        /// </summary>
        [JsonPropertyName(@"yanchor")]
        public YAnchorEnum? YAnchor { get; set; }

        /// <summary>
        ///     Sets the font of the range selector button text.
        /// </summary>
        [JsonPropertyName(@"font")]
        public RangeSelectors.Font? Font { get; set; }

        /// <summary>
        ///     Sets the background color of the range selector buttons.
        /// </summary>
        [JsonPropertyName(@"bgcolor")]
        public object? BgColor { get; set; }

        /// <summary>
        ///     Sets the background color of the active range selector button.
        /// </summary>
        [JsonPropertyName(@"activecolor")]
        public object? ActiveColor { get; set; }

        /// <summary>
        ///     Sets the color of the border enclosing the range selector.
        /// </summary>
        [JsonPropertyName(@"bordercolor")]
        public object? BorderColor { get; set; }

        /// <summary>
        ///     Sets the width (in px) of the border enclosing the range selector.
        /// </summary>
        [JsonPropertyName(@"borderwidth")]
        public JsNumber? BorderWidth { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is RangeSelector other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] RangeSelector other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (Visible == other.Visible && Visible != null && other.Visible != null && Visible.Equals(other.Visible))                         &&
                   (Equals(Buttons, other.Buttons) || Buttons != null && other.Buttons != null && Buttons.SequenceEqual(other.Buttons))            &&
                   (X           == other.X           && X           != null && other.X           != null && X.Equals(other.X))                     &&
                   (XAnchor     == other.XAnchor     && XAnchor     != null && other.XAnchor     != null && XAnchor.Equals(other.XAnchor))         &&
                   (Y           == other.Y           && Y           != null && other.Y           != null && Y.Equals(other.Y))                     &&
                   (YAnchor     == other.YAnchor     && YAnchor     != null && other.YAnchor     != null && YAnchor.Equals(other.YAnchor))         &&
                   (Font        == other.Font        && Font        != null && other.Font        != null && Font.Equals(other.Font))               &&
                   (BgColor     == other.BgColor     && BgColor     != null && other.BgColor     != null && BgColor.Equals(other.BgColor))         &&
                   (ActiveColor == other.ActiveColor && ActiveColor != null && other.ActiveColor != null && ActiveColor.Equals(other.ActiveColor)) &&
                   (BorderColor == other.BorderColor && BorderColor != null && other.BorderColor != null && BorderColor.Equals(other.BorderColor)) &&
                   (BorderWidth == other.BorderWidth && BorderWidth != null && other.BorderWidth != null && BorderWidth.Equals(other.BorderWidth));
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;

                if(Visible != null)
                    hashCode = hashCode * 59 + Visible.GetHashCode();

                if(Buttons != null)
                    hashCode = hashCode * 59 + Buttons.GetHashCode();

                if(X != null)
                    hashCode = hashCode * 59 + X.GetHashCode();

                if(XAnchor != null)
                    hashCode = hashCode * 59 + XAnchor.GetHashCode();

                if(Y != null)
                    hashCode = hashCode * 59 + Y.GetHashCode();

                if(YAnchor != null)
                    hashCode = hashCode * 59 + YAnchor.GetHashCode();

                if(Font != null)
                    hashCode = hashCode * 59 + Font.GetHashCode();

                if(BgColor != null)
                    hashCode = hashCode * 59 + BgColor.GetHashCode();

                if(ActiveColor != null)
                    hashCode = hashCode * 59 + ActiveColor.GetHashCode();

                if(BorderColor != null)
                    hashCode = hashCode * 59 + BorderColor.GetHashCode();

                if(BorderWidth != null)
                    hashCode = hashCode * 59 + BorderWidth.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left RangeSelector and the right RangeSelector.
        /// </summary>
        /// <param name="left">Left RangeSelector.</param>
        /// <param name="right">Right RangeSelector.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(RangeSelector left,
                                       RangeSelector right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left RangeSelector and the right RangeSelector.
        /// </summary>
        /// <param name="left">Left RangeSelector.</param>
        /// <param name="right">Right RangeSelector.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(RangeSelector left,
                                       RangeSelector right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>RangeSelector</returns>
        public RangeSelector DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<RangeSelector>(ms).Result;
        }
    }
}
