using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Traces.Volumes.ColorBars;

namespace Plotly.Models.Traces.Volumes
{
    /// <summary>
    ///     The ColorBar class.
    /// </summary>
    [Serializable]
    public class ColorBar : IEquatable<ColorBar>
    {
        /// <summary>
        ///     Determines whether this color bar&#39;s thickness (i.e. the measure in the
        ///     constant color direction) is set in units of plot <c>fraction</c> or in
        ///     <c>pixels</c>. Use <c>thickness</c> to set the value.
        /// </summary>
        [JsonPropertyName(@"thicknessmode")]
        public ThicknessModeEnum? ThicknessMode { get; set; }

        /// <summary>
        ///     Sets the thickness of the color bar This measure excludes the size of the
        ///     padding, ticks and labels.
        /// </summary>
        [JsonPropertyName(@"thickness")]
        public JsNumber? Thickness { get; set; }

        /// <summary>
        ///     Determines whether this color bar&#39;s length (i.e. the measure in the
        ///     color variation direction) is set in units of plot <c>fraction</c> or in
        ///     *pixels. Use <c>len</c> to set the value.
        /// </summary>
        [JsonPropertyName(@"lenmode")]
        public LenModeEnum? LenMode { get; set; }

        /// <summary>
        ///     Sets the length of the color bar This measure excludes the padding of both
        ///     ends. That is, the color bar length is this length minus the padding on
        ///     both ends.
        /// </summary>
        [JsonPropertyName(@"len")]
        public JsNumber? Len { get; set; }

        /// <summary>
        ///     Sets the x position of the color bar (in plot fraction).
        /// </summary>
        [JsonPropertyName(@"x")]
        public JsNumber? X { get; set; }

        /// <summary>
        ///     Sets this color bar&#39;s horizontal position anchor. This anchor binds
        ///     the <c>x</c> position to the <c>left</c>, <c>center</c> or <c>right</c>
        ///     of the color bar.
        /// </summary>
        [JsonPropertyName(@"xanchor")]
        public XAnchorEnum? XAnchor { get; set; }

        /// <summary>
        ///     Sets the amount of padding (in px) along the x direction.
        /// </summary>
        [JsonPropertyName(@"xpad")]
        public JsNumber? XPad { get; set; }

        /// <summary>
        ///     Sets the y position of the color bar (in plot fraction).
        /// </summary>
        [JsonPropertyName(@"y")]
        public JsNumber? Y { get; set; }

        /// <summary>
        ///     Sets this color bar&#39;s vertical position anchor This anchor binds the
        ///     <c>y</c> position to the <c>top</c>, <c>middle</c> or <c>bottom</c> of the
        ///     color bar.
        /// </summary>
        [JsonPropertyName(@"yanchor")]
        public YAnchorEnum? YAnchor { get; set; }

        /// <summary>
        ///     Sets the amount of padding (in px) along the y direction.
        /// </summary>
        [JsonPropertyName(@"ypad")]
        public JsNumber? YPad { get; set; }

        /// <summary>
        ///     Sets the axis line color.
        /// </summary>
        [JsonPropertyName(@"outlinecolor")]
        public object? OutlineColor { get; set; }

        /// <summary>
        ///     Sets the width (in px) of the axis line.
        /// </summary>
        [JsonPropertyName(@"outlinewidth")]
        public JsNumber? OutlineWidth { get; set; }

        /// <summary>
        ///     Sets the axis line color.
        /// </summary>
        [JsonPropertyName(@"bordercolor")]
        public object? BorderColor { get; set; }

        /// <summary>
        ///     Sets the width (in px) or the border enclosing this color bar.
        /// </summary>
        [JsonPropertyName(@"borderwidth")]
        public JsNumber? BorderWidth { get; set; }

        /// <summary>
        ///     Sets the color of padded area.
        /// </summary>
        [JsonPropertyName(@"bgcolor")]
        public object? BgColor { get; set; }

        /// <summary>
        ///     Sets the tick mode for this axis. If <c>auto</c>, the number of ticks is
        ///     set via <c>nticks</c>. If <c>linear</c>, the placement of the ticks is determined
        ///     by a starting position <c>tick0</c> and a tick step <c>dtick</c> (<c>linear</c>
        ///     is the default value if <c>tick0</c> and <c>dtick</c> are provided). If
        ///     <c>array</c>, the placement of the ticks is set via <c>tickvals</c> and
        ///     the tick text is <c>ticktext</c>. (<c>array</c> is the default value if
        ///     <c>tickvals</c> is provided).
        /// </summary>
        [JsonPropertyName(@"tickmode")]
        public TickModeEnum? TickMode { get; set; }

        /// <summary>
        ///     Specifies the maximum number of ticks for the particular axis. The actual
        ///     number of ticks will be chosen automatically to be less than or equal to
        ///     <c>nticks</c>. Has an effect only if <c>tickmode</c> is set to <c>auto</c>.
        /// </summary>
        [JsonPropertyName(@"nticks")]
        public int? NTicks { get; set; }

        /// <summary>
        ///     Sets the placement of the first tick on this axis. Use with <c>dtick</c>.
        ///     If the axis <c>type</c> is <c>log</c>, then you must take the log of your
        ///     starting tick (e.g. to set the starting tick to 100, set the <c>tick0</c>
        ///     to 2) except when <c>dtick</c>=<c>L&lt;f&gt;</c> (see <c>dtick</c> for more
        ///     info). If the axis <c>type</c> is <c>date</c>, it should be a date string,
        ///     like date data. If the axis <c>type</c> is <c>category</c>, it should be
        ///     a number, using the scale where each category is assigned a serial number
        ///     from zero in the order it appears.
        /// </summary>
        [JsonPropertyName(@"tick0")]
        public object? Tick0 { get; set; }

        /// <summary>
        ///     Sets the step in-between ticks on this axis. Use with <c>tick0</c>. Must
        ///     be a positive number, or special strings available to <c>log</c> and <c>date</c>
        ///     axes. If the axis <c>type</c> is <c>log</c>, then ticks are set every 10^(n*dtick)
        ///     where n is the tick number. For example, to set a tick mark at 1, 10, 100,
        ///     1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick
        ///     to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5),
        ///     or 0.69897000433. <c>log</c> has several special values; <c>L&lt;f&gt;</c>,
        ///     where <c>f</c> is a positive number, gives ticks linearly spaced in value
        ///     (but not position). For example <c>tick0</c> = 0.1, <c>dtick</c> = <c>L0.5</c>
        ///     will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small
        ///     digits between, use <c>D1</c> (all digits) or <c>D2</c> (only 2 and 5).
        ///     <c>tick0</c> is ignored for <c>D1</c> and <c>D2</c>. If the axis <c>type</c>
        ///     is <c>date</c>, then you must convert the time to milliseconds. For example,
        ///     to set the interval between ticks to one day, set <c>dtick</c> to 86400000.0.
        ///     <c>date</c> also has special values <c>M&lt;n&gt;</c> gives ticks spaced
        ///     by a number of months. <c>n</c> must be a positive integer. To set ticks
        ///     on the 15th of every third month, set <c>tick0</c> to <c>2000-01-15</c>
        ///     and <c>dtick</c> to <c>M3</c>. To set ticks every 4 years, set <c>dtick</c>
        ///     to <c>M48</c>
        /// </summary>
        [JsonPropertyName(@"dtick")]
        public object? DTick { get; set; }

        /// <summary>
        ///     Sets the values at which ticks on this axis appear. Only has an effect if
        ///     <c>tickmode</c> is set to <c>array</c>. Used with <c>ticktext</c>.
        /// </summary>
        [JsonPropertyName(@"tickvals")]
        public List<object>? TickVals { get; set; }

        /// <summary>
        ///     Sets the text displayed at the ticks position via <c>tickvals</c>. Only
        ///     has an effect if <c>tickmode</c> is set to <c>array</c>. Used with <c>tickvals</c>.
        /// </summary>
        [JsonPropertyName(@"ticktext")]
        public List<object>? TickText { get; set; }

        /// <summary>
        ///     Determines whether ticks are drawn or not. If **, this axis&#39; ticks are
        ///     not drawn. If <c>outside</c> (<c>inside</c>), this axis&#39; are drawn outside
        ///     (inside) the axis lines.
        /// </summary>
        [JsonPropertyName(@"ticks")]
        public TicksEnum? Ticks { get; set; }

        /// <summary>
        ///     Sets the tick length (in px).
        /// </summary>
        [JsonPropertyName(@"ticklen")]
        public JsNumber? TickleN { get; set; }

        /// <summary>
        ///     Sets the tick width (in px).
        /// </summary>
        [JsonPropertyName(@"tickwidth")]
        public JsNumber? TickWidth { get; set; }

        /// <summary>
        ///     Sets the tick color.
        /// </summary>
        [JsonPropertyName(@"tickcolor")]
        public object? TickColor { get; set; }

        /// <summary>
        ///     Determines whether or not the tick labels are drawn.
        /// </summary>
        [JsonPropertyName(@"showticklabels")]
        public bool? ShowTickLabels { get; set; }

        /// <summary>
        ///     Sets the color bar&#39;s tick label font
        /// </summary>
        [JsonPropertyName(@"tickfont")]
        public TickFont? TickFont { get; set; }

        /// <summary>
        ///     Sets the angle of the tick labels with respect to the horizontal. For example,
        ///     a <c>tickangle</c> of -90 draws the tick labels vertically.
        /// </summary>
        [JsonPropertyName(@"tickangle")]
        public JsNumber? TickAngle { get; set; }

        /// <summary>
        ///     Sets the tick label formatting rule using d3 formatting mini-languages which
        ///     are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        ///     And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format
        ///     We add one item to d3&#39;s date formatter: <c>%{n}f</c> for fractional
        ///     seconds with n digits. For example, &#39;2016-10-13 09:15:23.456&#39; with
        ///     tickformat <c>%H~%M~%S.%2f</c> would display <c>09~15~23.46</c>
        /// </summary>
        [JsonPropertyName(@"tickformat")]
        public string? TickFormat { get; set; }

        /// <summary>
        ///     Gets or sets the TickFormatStops.
        /// </summary>
        [JsonPropertyName(@"tickformatstops")]
        public List<TickFormatStop>? TickFormatStops { get; set; }

        /// <summary>
        ///     Sets a tick label prefix.
        /// </summary>
        [JsonPropertyName(@"tickprefix")]
        public string? TickPrefix { get; set; }

        /// <summary>
        ///     If <c>all</c>, all tick labels are displayed with a prefix. If <c>first</c>,
        ///     only the first tick is displayed with a prefix. If <c>last</c>, only the
        ///     last tick is displayed with a suffix. If <c>none</c>, tick prefixes are
        ///     hidden.
        /// </summary>
        [JsonPropertyName(@"showtickprefix")]
        public ShowTickPrefixEnum? ShowTickPrefix { get; set; }

        /// <summary>
        ///     Sets a tick label suffix.
        /// </summary>
        [JsonPropertyName(@"ticksuffix")]
        public string? TickSuffix { get; set; }

        /// <summary>
        ///     Same as <c>showtickprefix</c> but for tick suffixes.
        /// </summary>
        [JsonPropertyName(@"showticksuffix")]
        public ShowTickSuffixEnum? ShowTickSuffix { get; set; }

        /// <summary>
        ///     If <c>true</c>, even 4-digit integers are separated
        /// </summary>
        [JsonPropertyName(@"separatethousands")]
        public bool? SeparateThousands { get; set; }

        /// <summary>
        ///     Determines a formatting rule for the tick exponents. For example, consider
        ///     the number 1,000,000,000. If <c>none</c>, it appears as 1,000,000,000. If
        ///     <c>e</c>, 1e+9. If <c>E</c>, 1E+9. If <c>power</c>, 1x10^9 (with 9 in a
        ///     super script). If <c>SI</c>, 1G. If <c>B</c>, 1B.
        /// </summary>
        [JsonPropertyName(@"exponentformat")]
        public ExponentFormatEnum? ExponentFormat { get; set; }

        /// <summary>
        ///     If <c>all</c>, all exponents are shown besides their significands. If <c>first</c>,
        ///     only the exponent of the first tick is shown. If <c>last</c>, only the exponent
        ///     of the last tick is shown. If <c>none</c>, no exponents appear.
        /// </summary>
        [JsonPropertyName(@"showexponent")]
        public ShowExponentEnum? ShowExponent { get; set; }

        /// <summary>
        ///     Gets or sets the Title.
        /// </summary>
        [JsonPropertyName(@"title")]
        public Title? Title { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  tickvals .
        /// </summary>
        [JsonPropertyName(@"tickvalssrc")]
        public string? TickValsSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  ticktext .
        /// </summary>
        [JsonPropertyName(@"ticktextsrc")]
        public string? TickTextSrc { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is ColorBar other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] ColorBar other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (ThicknessMode == other.ThicknessMode && ThicknessMode != null && other.ThicknessMode != null && ThicknessMode.Equals(other.ThicknessMode))                          &&
                   (Thickness     == other.Thickness     && Thickness     != null && other.Thickness     != null && Thickness.Equals(other.Thickness))                                  &&
                   (LenMode       == other.LenMode       && LenMode       != null && other.LenMode       != null && LenMode.Equals(other.LenMode))                                      &&
                   (Len           == other.Len           && Len           != null && other.Len           != null && Len.Equals(other.Len))                                              &&
                   (X             == other.X             && X             != null && other.X             != null && X.Equals(other.X))                                                  &&
                   (XAnchor       == other.XAnchor       && XAnchor       != null && other.XAnchor       != null && XAnchor.Equals(other.XAnchor))                                      &&
                   (XPad          == other.XPad          && XPad          != null && other.XPad          != null && XPad.Equals(other.XPad))                                            &&
                   (Y             == other.Y             && Y             != null && other.Y             != null && Y.Equals(other.Y))                                                  &&
                   (YAnchor       == other.YAnchor       && YAnchor       != null && other.YAnchor       != null && YAnchor.Equals(other.YAnchor))                                      &&
                   (YPad          == other.YPad          && YPad          != null && other.YPad          != null && YPad.Equals(other.YPad))                                            &&
                   (OutlineColor  == other.OutlineColor  && OutlineColor  != null && other.OutlineColor  != null && OutlineColor.Equals(other.OutlineColor))                            &&
                   (OutlineWidth  == other.OutlineWidth  && OutlineWidth  != null && other.OutlineWidth  != null && OutlineWidth.Equals(other.OutlineWidth))                            &&
                   (BorderColor   == other.BorderColor   && BorderColor   != null && other.BorderColor   != null && BorderColor.Equals(other.BorderColor))                              &&
                   (BorderWidth   == other.BorderWidth   && BorderWidth   != null && other.BorderWidth   != null && BorderWidth.Equals(other.BorderWidth))                              &&
                   (BgColor       == other.BgColor       && BgColor       != null && other.BgColor       != null && BgColor.Equals(other.BgColor))                                      &&
                   (TickMode      == other.TickMode      && TickMode      != null && other.TickMode      != null && TickMode.Equals(other.TickMode))                                    &&
                   (NTicks        == other.NTicks        && NTicks        != null && other.NTicks        != null && NTicks.Equals(other.NTicks))                                        &&
                   (Tick0         == other.Tick0         && Tick0         != null && other.Tick0         != null && Tick0.Equals(other.Tick0))                                          &&
                   (DTick         == other.DTick         && DTick         != null && other.DTick         != null && DTick.Equals(other.DTick))                                          &&
                   (Equals(TickVals, other.TickVals) || TickVals != null && other.TickVals != null && TickVals.SequenceEqual(other.TickVals))                                           &&
                   (Equals(TickText, other.TickText) || TickText != null && other.TickText != null && TickText.SequenceEqual(other.TickText))                                           &&
                   (Ticks          == other.Ticks          && Ticks          != null && other.Ticks          != null && Ticks.Equals(other.Ticks))                                      &&
                   (TickleN        == other.TickleN        && TickleN        != null && other.TickleN        != null && TickleN.Equals(other.TickleN))                                  &&
                   (TickWidth      == other.TickWidth      && TickWidth      != null && other.TickWidth      != null && TickWidth.Equals(other.TickWidth))                              &&
                   (TickColor      == other.TickColor      && TickColor      != null && other.TickColor      != null && TickColor.Equals(other.TickColor))                              &&
                   (ShowTickLabels == other.ShowTickLabels && ShowTickLabels != null && other.ShowTickLabels != null && ShowTickLabels.Equals(other.ShowTickLabels))                    &&
                   (TickFont       == other.TickFont       && TickFont       != null && other.TickFont       != null && TickFont.Equals(other.TickFont))                                &&
                   (TickAngle      == other.TickAngle      && TickAngle      != null && other.TickAngle      != null && TickAngle.Equals(other.TickAngle))                              &&
                   (TickFormat     == other.TickFormat     && TickFormat     != null && other.TickFormat     != null && TickFormat.Equals(other.TickFormat))                            &&
                   (Equals(TickFormatStops, other.TickFormatStops) || TickFormatStops != null && other.TickFormatStops != null && TickFormatStops.SequenceEqual(other.TickFormatStops)) &&
                   (TickPrefix        == other.TickPrefix        && TickPrefix        != null && other.TickPrefix        != null && TickPrefix.Equals(other.TickPrefix))                &&
                   (ShowTickPrefix    == other.ShowTickPrefix    && ShowTickPrefix    != null && other.ShowTickPrefix    != null && ShowTickPrefix.Equals(other.ShowTickPrefix))        &&
                   (TickSuffix        == other.TickSuffix        && TickSuffix        != null && other.TickSuffix        != null && TickSuffix.Equals(other.TickSuffix))                &&
                   (ShowTickSuffix    == other.ShowTickSuffix    && ShowTickSuffix    != null && other.ShowTickSuffix    != null && ShowTickSuffix.Equals(other.ShowTickSuffix))        &&
                   (SeparateThousands == other.SeparateThousands && SeparateThousands != null && other.SeparateThousands != null && SeparateThousands.Equals(other.SeparateThousands))  &&
                   (ExponentFormat    == other.ExponentFormat    && ExponentFormat    != null && other.ExponentFormat    != null && ExponentFormat.Equals(other.ExponentFormat))        &&
                   (ShowExponent      == other.ShowExponent      && ShowExponent      != null && other.ShowExponent      != null && ShowExponent.Equals(other.ShowExponent))            &&
                   (Title             == other.Title             && Title             != null && other.Title             != null && Title.Equals(other.Title))                          &&
                   (TickValsSrc       == other.TickValsSrc       && TickValsSrc       != null && other.TickValsSrc       != null && TickValsSrc.Equals(other.TickValsSrc))              &&
                   (TickTextSrc       == other.TickTextSrc       && TickTextSrc       != null && other.TickTextSrc       != null && TickTextSrc.Equals(other.TickTextSrc));
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;

                if(ThicknessMode != null)
                    hashCode = hashCode * 59 + ThicknessMode.GetHashCode();

                if(Thickness != null)
                    hashCode = hashCode * 59 + Thickness.GetHashCode();

                if(LenMode != null)
                    hashCode = hashCode * 59 + LenMode.GetHashCode();

                if(Len != null)
                    hashCode = hashCode * 59 + Len.GetHashCode();

                if(X != null)
                    hashCode = hashCode * 59 + X.GetHashCode();

                if(XAnchor != null)
                    hashCode = hashCode * 59 + XAnchor.GetHashCode();

                if(XPad != null)
                    hashCode = hashCode * 59 + XPad.GetHashCode();

                if(Y != null)
                    hashCode = hashCode * 59 + Y.GetHashCode();

                if(YAnchor != null)
                    hashCode = hashCode * 59 + YAnchor.GetHashCode();

                if(YPad != null)
                    hashCode = hashCode * 59 + YPad.GetHashCode();

                if(OutlineColor != null)
                    hashCode = hashCode * 59 + OutlineColor.GetHashCode();

                if(OutlineWidth != null)
                    hashCode = hashCode * 59 + OutlineWidth.GetHashCode();

                if(BorderColor != null)
                    hashCode = hashCode * 59 + BorderColor.GetHashCode();

                if(BorderWidth != null)
                    hashCode = hashCode * 59 + BorderWidth.GetHashCode();

                if(BgColor != null)
                    hashCode = hashCode * 59 + BgColor.GetHashCode();

                if(TickMode != null)
                    hashCode = hashCode * 59 + TickMode.GetHashCode();

                if(NTicks != null)
                    hashCode = hashCode * 59 + NTicks.GetHashCode();

                if(Tick0 != null)
                    hashCode = hashCode * 59 + Tick0.GetHashCode();

                if(DTick != null)
                    hashCode = hashCode * 59 + DTick.GetHashCode();

                if(TickVals != null)
                    hashCode = hashCode * 59 + TickVals.GetHashCode();

                if(TickText != null)
                    hashCode = hashCode * 59 + TickText.GetHashCode();

                if(Ticks != null)
                    hashCode = hashCode * 59 + Ticks.GetHashCode();

                if(TickleN != null)
                    hashCode = hashCode * 59 + TickleN.GetHashCode();

                if(TickWidth != null)
                    hashCode = hashCode * 59 + TickWidth.GetHashCode();

                if(TickColor != null)
                    hashCode = hashCode * 59 + TickColor.GetHashCode();

                if(ShowTickLabels != null)
                    hashCode = hashCode * 59 + ShowTickLabels.GetHashCode();

                if(TickFont != null)
                    hashCode = hashCode * 59 + TickFont.GetHashCode();

                if(TickAngle != null)
                    hashCode = hashCode * 59 + TickAngle.GetHashCode();

                if(TickFormat != null)
                    hashCode = hashCode * 59 + TickFormat.GetHashCode();

                if(TickFormatStops != null)
                    hashCode = hashCode * 59 + TickFormatStops.GetHashCode();

                if(TickPrefix != null)
                    hashCode = hashCode * 59 + TickPrefix.GetHashCode();

                if(ShowTickPrefix != null)
                    hashCode = hashCode * 59 + ShowTickPrefix.GetHashCode();

                if(TickSuffix != null)
                    hashCode = hashCode * 59 + TickSuffix.GetHashCode();

                if(ShowTickSuffix != null)
                    hashCode = hashCode * 59 + ShowTickSuffix.GetHashCode();

                if(SeparateThousands != null)
                    hashCode = hashCode * 59 + SeparateThousands.GetHashCode();

                if(ExponentFormat != null)
                    hashCode = hashCode * 59 + ExponentFormat.GetHashCode();

                if(ShowExponent != null)
                    hashCode = hashCode * 59 + ShowExponent.GetHashCode();

                if(Title != null)
                    hashCode = hashCode * 59 + Title.GetHashCode();

                if(TickValsSrc != null)
                    hashCode = hashCode * 59 + TickValsSrc.GetHashCode();

                if(TickTextSrc != null)
                    hashCode = hashCode * 59 + TickTextSrc.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left ColorBar and the right ColorBar.
        /// </summary>
        /// <param name="left">Left ColorBar.</param>
        /// <param name="right">Right ColorBar.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(ColorBar left,
                                       ColorBar right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left ColorBar and the right ColorBar.
        /// </summary>
        /// <param name="left">Left ColorBar.</param>
        /// <param name="right">Right ColorBar.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(ColorBar left,
                                       ColorBar right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>ColorBar</returns>
        public ColorBar DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<ColorBar>(ms).Result;
        }
    }
}
