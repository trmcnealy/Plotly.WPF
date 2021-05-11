using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Layouts.Sliders;

namespace Plotly.Models.Layouts
{
    /// <summary>
    ///     The Slider class.
    /// </summary>
    [Serializable]
    public class Slider : IEquatable<Slider>
    {
        /// <summary>
        ///     Determines whether or not the slider is visible.
        /// </summary>
        [JsonPropertyName(@"visible")]
        public bool? Visible { get; set; }

        /// <summary>
        ///     Determines which button (by index starting from 0) is considered active.
        /// </summary>
        [JsonPropertyName(@"active")]
        public JsNumber? Active { get; set; }

        /// <summary>
        ///     Gets or sets the Steps.
        /// </summary>
        [JsonPropertyName(@"steps")]
        public List<Step> Steps { get; set; }

        /// <summary>
        ///     Determines whether this slider length is set in units of plot <c>fraction</c>
        ///     or in *pixels. Use <c>len</c> to set the value.
        /// </summary>
        [JsonPropertyName(@"lenmode")]
        public LenModeEnum? LenMode { get; set; }

        /// <summary>
        ///     Sets the length of the slider This measure excludes the padding of both
        ///     ends. That is, the slider&#39;s length is this length minus the padding
        ///     on both ends.
        /// </summary>
        [JsonPropertyName(@"len")]
        public JsNumber? Len { get; set; }

        /// <summary>
        ///     Sets the x position (in normalized coordinates) of the slider.
        /// </summary>
        [JsonPropertyName(@"x")]
        public JsNumber? X { get; set; }

        /// <summary>
        ///     Set the padding of the slider component along each side.
        /// </summary>
        [JsonPropertyName(@"pad")]
        public Pad Pad { get; set; }

        /// <summary>
        ///     Sets the slider&#39;s horizontal position anchor. This anchor binds the
        ///     <c>x</c> position to the <c>left</c>, <c>center</c> or <c>right</c> of the
        ///     range selector.
        /// </summary>
        [JsonPropertyName(@"xanchor")]
        public XAnchorEnum? XAnchor { get; set; }

        /// <summary>
        ///     Sets the y position (in normalized coordinates) of the slider.
        /// </summary>
        [JsonPropertyName(@"y")]
        public JsNumber? Y { get; set; }

        /// <summary>
        ///     Sets the slider&#39;s vertical position anchor This anchor binds the <c>y</c>
        ///     position to the <c>top</c>, <c>middle</c> or <c>bottom</c> of the range
        ///     selector.
        /// </summary>
        [JsonPropertyName(@"yanchor")]
        public YAnchorEnum? YAnchor { get; set; }

        /// <summary>
        ///     Gets or sets the Transition.
        /// </summary>
        [JsonPropertyName(@"transition")]
        public Sliders.Transition Transition { get; set; }

        /// <summary>
        ///     Gets or sets the CurrentValue.
        /// </summary>
        [JsonPropertyName(@"currentvalue")]
        public CurrentValue CurrentValue { get; set; }

        /// <summary>
        ///     Sets the font of the slider step labels.
        /// </summary>
        [JsonPropertyName(@"font")]
        public Sliders.Font Font { get; set; }

        /// <summary>
        ///     Sets the background color of the slider grip while dragging.
        /// </summary>
        [JsonPropertyName(@"activebgcolor")]
        public object ActiveBgColor { get; set; }

        /// <summary>
        ///     Sets the background color of the slider.
        /// </summary>
        [JsonPropertyName(@"bgcolor")]
        public object BgColor { get; set; }

        /// <summary>
        ///     Sets the color of the border enclosing the slider.
        /// </summary>
        [JsonPropertyName(@"bordercolor")]
        public object BorderColor { get; set; }

        /// <summary>
        ///     Sets the width (in px) of the border enclosing the slider.
        /// </summary>
        [JsonPropertyName(@"borderwidth")]
        public JsNumber? BorderWidth { get; set; }

        /// <summary>
        ///     Sets the length in pixels of step tick marks
        /// </summary>
        [JsonPropertyName(@"ticklen")]
        public JsNumber? TickleN { get; set; }

        /// <summary>
        ///     Sets the color of the border enclosing the slider.
        /// </summary>
        [JsonPropertyName(@"tickcolor")]
        public object TickColor { get; set; }

        /// <summary>
        ///     Sets the tick width (in px).
        /// </summary>
        [JsonPropertyName(@"tickwidth")]
        public JsNumber? TickWidth { get; set; }

        /// <summary>
        ///     Sets the length in pixels of minor step tick marks
        /// </summary>
        [JsonPropertyName(@"minorticklen")]
        public JsNumber? MinorTickLen { get; set; }

        /// <summary>
        ///     When used in a template, named items are created in the output figure in
        ///     addition to any items the figure already has in this array. You can modify
        ///     these items in the output figure by making your own item with <c>templateitemname</c>
        ///     matching this <c>name</c> alongside your modifications (including &#39;visible:
        ///     false&#39; or &#39;enabled: false&#39; to hide it). Has no effect outside
        ///     of a template.
        /// </summary>
        [JsonPropertyName(@"name")]
        public string Name { get; set; }

        /// <summary>
        ///     Used to refer to a named item in this array in the template. Named items
        ///     from the template will be created even without a matching item in the input
        ///     figure, but you can modify one by making an item with <c>templateitemname</c>
        ///     matching its <c>name</c>, alongside your modifications (including &#39;visible:
        ///     false&#39; or &#39;enabled: false&#39; to hide it). If there is no template
        ///     or no matching item, this item will be hidden unless you explicitly show
        ///     it with &#39;visible: true&#39;.
        /// </summary>
        [JsonPropertyName(@"templateitemname")]
        public string TemplateItemName { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is Slider other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] Slider other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (Visible == other.Visible && Visible != null && other.Visible != null && Visible.Equals(other.Visible))                                                 &&
                   (Active  == other.Active  && Active  != null && other.Active  != null && Active.Equals(other.Active))                                                   &&
                   (Equals(Steps, other.Steps) || Steps != null && other.Steps != null && Steps.SequenceEqual(other.Steps))                                                &&
                   (LenMode          == other.LenMode          && LenMode          != null && other.LenMode          != null && LenMode.Equals(other.LenMode))             &&
                   (Len              == other.Len              && Len              != null && other.Len              != null && Len.Equals(other.Len))                     &&
                   (X                == other.X                && X                != null && other.X                != null && X.Equals(other.X))                         &&
                   (Pad              == other.Pad              && Pad              != null && other.Pad              != null && Pad.Equals(other.Pad))                     &&
                   (XAnchor          == other.XAnchor          && XAnchor          != null && other.XAnchor          != null && XAnchor.Equals(other.XAnchor))             &&
                   (Y                == other.Y                && Y                != null && other.Y                != null && Y.Equals(other.Y))                         &&
                   (YAnchor          == other.YAnchor          && YAnchor          != null && other.YAnchor          != null && YAnchor.Equals(other.YAnchor))             &&
                   (Transition       == other.Transition       && Transition       != null && other.Transition       != null && Transition.Equals(other.Transition))       &&
                   (CurrentValue     == other.CurrentValue     && CurrentValue     != null && other.CurrentValue     != null && CurrentValue.Equals(other.CurrentValue))   &&
                   (Font             == other.Font             && Font             != null && other.Font             != null && Font.Equals(other.Font))                   &&
                   (ActiveBgColor    == other.ActiveBgColor    && ActiveBgColor    != null && other.ActiveBgColor    != null && ActiveBgColor.Equals(other.ActiveBgColor)) &&
                   (BgColor          == other.BgColor          && BgColor          != null && other.BgColor          != null && BgColor.Equals(other.BgColor))             &&
                   (BorderColor      == other.BorderColor      && BorderColor      != null && other.BorderColor      != null && BorderColor.Equals(other.BorderColor))     &&
                   (BorderWidth      == other.BorderWidth      && BorderWidth      != null && other.BorderWidth      != null && BorderWidth.Equals(other.BorderWidth))     &&
                   (TickleN          == other.TickleN          && TickleN          != null && other.TickleN          != null && TickleN.Equals(other.TickleN))             &&
                   (TickColor        == other.TickColor        && TickColor        != null && other.TickColor        != null && TickColor.Equals(other.TickColor))         &&
                   (TickWidth        == other.TickWidth        && TickWidth        != null && other.TickWidth        != null && TickWidth.Equals(other.TickWidth))         &&
                   (MinorTickLen     == other.MinorTickLen     && MinorTickLen     != null && other.MinorTickLen     != null && MinorTickLen.Equals(other.MinorTickLen))   &&
                   (Name             == other.Name             && Name             != null && other.Name             != null && Name.Equals(other.Name))                   &&
                   (TemplateItemName == other.TemplateItemName && TemplateItemName != null && other.TemplateItemName != null && TemplateItemName.Equals(other.TemplateItemName));
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;

                if(Visible != null)
                    hashCode = hashCode * 59 + Visible.GetHashCode();

                if(Active != null)
                    hashCode = hashCode * 59 + Active.GetHashCode();

                if(Steps != null)
                    hashCode = hashCode * 59 + Steps.GetHashCode();

                if(LenMode != null)
                    hashCode = hashCode * 59 + LenMode.GetHashCode();

                if(Len != null)
                    hashCode = hashCode * 59 + Len.GetHashCode();

                if(X != null)
                    hashCode = hashCode * 59 + X.GetHashCode();

                if(Pad != null)
                    hashCode = hashCode * 59 + Pad.GetHashCode();

                if(XAnchor != null)
                    hashCode = hashCode * 59 + XAnchor.GetHashCode();

                if(Y != null)
                    hashCode = hashCode * 59 + Y.GetHashCode();

                if(YAnchor != null)
                    hashCode = hashCode * 59 + YAnchor.GetHashCode();

                if(Transition != null)
                    hashCode = hashCode * 59 + Transition.GetHashCode();

                if(CurrentValue != null)
                    hashCode = hashCode * 59 + CurrentValue.GetHashCode();

                if(Font != null)
                    hashCode = hashCode * 59 + Font.GetHashCode();

                if(ActiveBgColor != null)
                    hashCode = hashCode * 59 + ActiveBgColor.GetHashCode();

                if(BgColor != null)
                    hashCode = hashCode * 59 + BgColor.GetHashCode();

                if(BorderColor != null)
                    hashCode = hashCode * 59 + BorderColor.GetHashCode();

                if(BorderWidth != null)
                    hashCode = hashCode * 59 + BorderWidth.GetHashCode();

                if(TickleN != null)
                    hashCode = hashCode * 59 + TickleN.GetHashCode();

                if(TickColor != null)
                    hashCode = hashCode * 59 + TickColor.GetHashCode();

                if(TickWidth != null)
                    hashCode = hashCode * 59 + TickWidth.GetHashCode();

                if(MinorTickLen != null)
                    hashCode = hashCode * 59 + MinorTickLen.GetHashCode();

                if(Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();

                if(TemplateItemName != null)
                    hashCode = hashCode * 59 + TemplateItemName.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Slider and the right Slider.
        /// </summary>
        /// <param name="left">Left Slider.</param>
        /// <param name="right">Right Slider.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(Slider left,
                                       Slider right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Slider and the right Slider.
        /// </summary>
        /// <param name="left">Left Slider.</param>
        /// <param name="right">Right Slider.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(Slider left,
                                       Slider right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Slider</returns>
        public Slider DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<Slider>(ms).Result;
        }
    }
}
