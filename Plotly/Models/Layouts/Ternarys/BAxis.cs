using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Layouts.Ternarys.BAxes;

namespace Plotly.Models.Layouts.Ternarys
{
    /// <summary>
    ///     The BAxis class.
    /// </summary>
    [Serializable]
    public class BAxis : IEquatable<BAxis>
    {
        /// <summary>
        ///     Gets or sets the Title.
        /// </summary>
        [JsonPropertyName(@"title")]
        public BAxes.Title? Title { get; set; }

        /// <summary>
        ///     Sets default for all colors associated with this axis all at once: line,
        ///     font, tick, and grid colors. Grid color is lightened by blending this with
        ///     the plot background Individual pieces can override this.
        /// </summary>
        [JsonPropertyName(@"color")]
        public object? Color { get; set; }

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
        ///     If <c>all</c>, all tick labels are displayed with a prefix. If <c>first</c>,
        ///     only the first tick is displayed with a prefix. If <c>last</c>, only the
        ///     last tick is displayed with a suffix. If <c>none</c>, tick prefixes are
        ///     hidden.
        /// </summary>
        [JsonPropertyName(@"showtickprefix")]
        public ShowTickPrefixEnum? ShowTickPrefix { get; set; }

        /// <summary>
        ///     Sets a tick label prefix.
        /// </summary>
        [JsonPropertyName(@"tickprefix")]
        public string? TickPrefix { get; set; }

        /// <summary>
        ///     Same as <c>showtickprefix</c> but for tick suffixes.
        /// </summary>
        [JsonPropertyName(@"showticksuffix")]
        public ShowTickSuffixEnum? ShowTickSuffix { get; set; }

        /// <summary>
        ///     Sets a tick label suffix.
        /// </summary>
        [JsonPropertyName(@"ticksuffix")]
        public string? TickSuffix { get; set; }

        /// <summary>
        ///     If <c>all</c>, all exponents are shown besides their significands. If <c>first</c>,
        ///     only the exponent of the first tick is shown. If <c>last</c>, only the exponent
        ///     of the last tick is shown. If <c>none</c>, no exponents appear.
        /// </summary>
        [JsonPropertyName(@"showexponent")]
        public ShowExponentEnum? ShowExponent { get; set; }

        /// <summary>
        ///     Determines a formatting rule for the tick exponents. For example, consider
        ///     the number 1,000,000,000. If <c>none</c>, it appears as 1,000,000,000. If
        ///     <c>e</c>, 1e+9. If <c>E</c>, 1E+9. If <c>power</c>, 1x10^9 (with 9 in a
        ///     super script). If <c>SI</c>, 1G. If <c>B</c>, 1B.
        /// </summary>
        [JsonPropertyName(@"exponentformat")]
        public ExponentFormatEnum? ExponentFormat { get; set; }

        /// <summary>
        ///     If <c>true</c>, even 4-digit integers are separated
        /// </summary>
        [JsonPropertyName(@"separatethousands")]
        public bool? SeparateThousands { get; set; }

        /// <summary>
        ///     Sets the tick font.
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
        ///     Sets the hover text formatting rule using d3 formatting mini-languages which
        ///     are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        ///     And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format
        ///     We add one item to d3&#39;s date formatter: <c>%{n}f</c> for fractional
        ///     seconds with n digits. For example, &#39;2016-10-13 09:15:23.456&#39; with
        ///     tickformat <c>%H~%M~%S.%2f</c> would display <c>09~15~23.46</c>
        /// </summary>
        [JsonPropertyName(@"hoverformat")]
        public string? HoverFormat { get; set; }

        /// <summary>
        ///     Determines whether or not a line bounding this axis is drawn.
        /// </summary>
        [JsonPropertyName(@"showline")]
        public bool? ShowLine { get; set; }

        /// <summary>
        ///     Sets the axis line color.
        /// </summary>
        [JsonPropertyName(@"linecolor")]
        public object? LineColor { get; set; }

        /// <summary>
        ///     Sets the width (in px) of the axis line.
        /// </summary>
        [JsonPropertyName(@"linewidth")]
        public JsNumber? LineWidth { get; set; }

        /// <summary>
        ///     Determines whether or not grid lines are drawn. If <c>true</c>, the grid
        ///     lines are drawn at every tick mark.
        /// </summary>
        [JsonPropertyName(@"showgrid")]
        public bool? ShowGrid { get; set; }

        /// <summary>
        ///     Sets the color of the grid lines.
        /// </summary>
        [JsonPropertyName(@"gridcolor")]
        public object? GridColor { get; set; }

        /// <summary>
        ///     Sets the width (in px) of the grid lines.
        /// </summary>
        [JsonPropertyName(@"gridwidth")]
        public JsNumber? GridWidth { get; set; }

        /// <summary>
        ///     Sets the layer on which this axis is displayed. If &#39;above traces&#39;,
        ///     this axis is displayed above all the subplot&#39;s traces If &#39;below
        ///     traces&#39;, this axis is displayed below all the subplot&#39;s traces,
        ///     but above the grid lines. Useful when used together with scatter-like traces
        ///     with <c>cliponaxis</c> set to <c>false</c> to show markers and/or text nodes
        ///     above this axis.
        /// </summary>
        [JsonPropertyName(@"layer")]
        public LayerEnum? Layer { get; set; }

        /// <summary>
        ///     Controls persistence of user-driven changes in axis <c>min</c>, and <c>title</c>
        ///     if in &#39;editable: true&#39; configuration. Defaults to <c>ternary&lt;N&gt;.uirevision</c>.
        /// </summary>
        [JsonPropertyName(@"uirevision")]
        public object? UiRevision { get; set; }

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
            if(!(obj is BAxis other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] BAxis other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (Title    == other.Title    && Title    != null && other.Title    != null && Title.Equals(other.Title))                                                              &&
                   (Color    == other.Color    && Color    != null && other.Color    != null && Color.Equals(other.Color))                                                              &&
                   (TickMode == other.TickMode && TickMode != null && other.TickMode != null && TickMode.Equals(other.TickMode))                                                        &&
                   (NTicks   == other.NTicks   && NTicks   != null && other.NTicks   != null && NTicks.Equals(other.NTicks))                                                            &&
                   (Tick0    == other.Tick0    && Tick0    != null && other.Tick0    != null && Tick0.Equals(other.Tick0))                                                              &&
                   (DTick    == other.DTick    && DTick    != null && other.DTick    != null && DTick.Equals(other.DTick))                                                              &&
                   (Equals(TickVals, other.TickVals) || TickVals != null && other.TickVals != null && TickVals.SequenceEqual(other.TickVals))                                           &&
                   (Equals(TickText, other.TickText) || TickText != null && other.TickText != null && TickText.SequenceEqual(other.TickText))                                           &&
                   (Ticks             == other.Ticks             && Ticks             != null && other.Ticks             != null && Ticks.Equals(other.Ticks))                          &&
                   (TickleN           == other.TickleN           && TickleN           != null && other.TickleN           != null && TickleN.Equals(other.TickleN))                      &&
                   (TickWidth         == other.TickWidth         && TickWidth         != null && other.TickWidth         != null && TickWidth.Equals(other.TickWidth))                  &&
                   (TickColor         == other.TickColor         && TickColor         != null && other.TickColor         != null && TickColor.Equals(other.TickColor))                  &&
                   (ShowTickLabels    == other.ShowTickLabels    && ShowTickLabels    != null && other.ShowTickLabels    != null && ShowTickLabels.Equals(other.ShowTickLabels))        &&
                   (ShowTickPrefix    == other.ShowTickPrefix    && ShowTickPrefix    != null && other.ShowTickPrefix    != null && ShowTickPrefix.Equals(other.ShowTickPrefix))        &&
                   (TickPrefix        == other.TickPrefix        && TickPrefix        != null && other.TickPrefix        != null && TickPrefix.Equals(other.TickPrefix))                &&
                   (ShowTickSuffix    == other.ShowTickSuffix    && ShowTickSuffix    != null && other.ShowTickSuffix    != null && ShowTickSuffix.Equals(other.ShowTickSuffix))        &&
                   (TickSuffix        == other.TickSuffix        && TickSuffix        != null && other.TickSuffix        != null && TickSuffix.Equals(other.TickSuffix))                &&
                   (ShowExponent      == other.ShowExponent      && ShowExponent      != null && other.ShowExponent      != null && ShowExponent.Equals(other.ShowExponent))            &&
                   (ExponentFormat    == other.ExponentFormat    && ExponentFormat    != null && other.ExponentFormat    != null && ExponentFormat.Equals(other.ExponentFormat))        &&
                   (SeparateThousands == other.SeparateThousands && SeparateThousands != null && other.SeparateThousands != null && SeparateThousands.Equals(other.SeparateThousands))  &&
                   (TickFont          == other.TickFont          && TickFont          != null && other.TickFont          != null && TickFont.Equals(other.TickFont))                    &&
                   (TickAngle         == other.TickAngle         && TickAngle         != null && other.TickAngle         != null && TickAngle.Equals(other.TickAngle))                  &&
                   (TickFormat        == other.TickFormat        && TickFormat        != null && other.TickFormat        != null && TickFormat.Equals(other.TickFormat))                &&
                   (Equals(TickFormatStops, other.TickFormatStops) || TickFormatStops != null && other.TickFormatStops != null && TickFormatStops.SequenceEqual(other.TickFormatStops)) &&
                   (HoverFormat == other.HoverFormat && HoverFormat != null && other.HoverFormat != null && HoverFormat.Equals(other.HoverFormat))                                      &&
                   (ShowLine    == other.ShowLine    && ShowLine    != null && other.ShowLine    != null && ShowLine.Equals(other.ShowLine))                                            &&
                   (LineColor   == other.LineColor   && LineColor   != null && other.LineColor   != null && LineColor.Equals(other.LineColor))                                          &&
                   (LineWidth   == other.LineWidth   && LineWidth   != null && other.LineWidth   != null && LineWidth.Equals(other.LineWidth))                                          &&
                   (ShowGrid    == other.ShowGrid    && ShowGrid    != null && other.ShowGrid    != null && ShowGrid.Equals(other.ShowGrid))                                            &&
                   (GridColor   == other.GridColor   && GridColor   != null && other.GridColor   != null && GridColor.Equals(other.GridColor))                                          &&
                   (GridWidth   == other.GridWidth   && GridWidth   != null && other.GridWidth   != null && GridWidth.Equals(other.GridWidth))                                          &&
                   (Layer       == other.Layer       && Layer       != null && other.Layer       != null && Layer.Equals(other.Layer))                                                  &&
                   (UiRevision  == other.UiRevision  && UiRevision  != null && other.UiRevision  != null && UiRevision.Equals(other.UiRevision))                                        &&
                   (TickValsSrc == other.TickValsSrc && TickValsSrc != null && other.TickValsSrc != null && TickValsSrc.Equals(other.TickValsSrc))                                      &&
                   (TickTextSrc == other.TickTextSrc && TickTextSrc != null && other.TickTextSrc != null && TickTextSrc.Equals(other.TickTextSrc));
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;

                if(Title != null)
                    hashCode = hashCode * 59 + Title.GetHashCode();

                if(Color != null)
                    hashCode = hashCode * 59 + Color.GetHashCode();

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

                if(ShowTickPrefix != null)
                    hashCode = hashCode * 59 + ShowTickPrefix.GetHashCode();

                if(TickPrefix != null)
                    hashCode = hashCode * 59 + TickPrefix.GetHashCode();

                if(ShowTickSuffix != null)
                    hashCode = hashCode * 59 + ShowTickSuffix.GetHashCode();

                if(TickSuffix != null)
                    hashCode = hashCode * 59 + TickSuffix.GetHashCode();

                if(ShowExponent != null)
                    hashCode = hashCode * 59 + ShowExponent.GetHashCode();

                if(ExponentFormat != null)
                    hashCode = hashCode * 59 + ExponentFormat.GetHashCode();

                if(SeparateThousands != null)
                    hashCode = hashCode * 59 + SeparateThousands.GetHashCode();

                if(TickFont != null)
                    hashCode = hashCode * 59 + TickFont.GetHashCode();

                if(TickAngle != null)
                    hashCode = hashCode * 59 + TickAngle.GetHashCode();

                if(TickFormat != null)
                    hashCode = hashCode * 59 + TickFormat.GetHashCode();

                if(TickFormatStops != null)
                    hashCode = hashCode * 59 + TickFormatStops.GetHashCode();

                if(HoverFormat != null)
                    hashCode = hashCode * 59 + HoverFormat.GetHashCode();

                if(ShowLine != null)
                    hashCode = hashCode * 59 + ShowLine.GetHashCode();

                if(LineColor != null)
                    hashCode = hashCode * 59 + LineColor.GetHashCode();

                if(LineWidth != null)
                    hashCode = hashCode * 59 + LineWidth.GetHashCode();

                if(ShowGrid != null)
                    hashCode = hashCode * 59 + ShowGrid.GetHashCode();

                if(GridColor != null)
                    hashCode = hashCode * 59 + GridColor.GetHashCode();

                if(GridWidth != null)
                    hashCode = hashCode * 59 + GridWidth.GetHashCode();

                if(Layer != null)
                    hashCode = hashCode * 59 + Layer.GetHashCode();

                if(UiRevision != null)
                    hashCode = hashCode * 59 + UiRevision.GetHashCode();

                if(TickValsSrc != null)
                    hashCode = hashCode * 59 + TickValsSrc.GetHashCode();

                if(TickTextSrc != null)
                    hashCode = hashCode * 59 + TickTextSrc.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left BAxis and the right BAxis.
        /// </summary>
        /// <param name="left">Left BAxis.</param>
        /// <param name="right">Right BAxis.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(BAxis left,
                                       BAxis right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left BAxis and the right BAxis.
        /// </summary>
        /// <param name="left">Left BAxis.</param>
        /// <param name="right">Right BAxis.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(BAxis left,
                                       BAxis right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>BAxis</returns>
        public BAxis DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<BAxis>(ms).Result;
        }
    }
}
