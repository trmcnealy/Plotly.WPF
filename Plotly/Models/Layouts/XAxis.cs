using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Layouts.XAxes;

namespace Plotly.Models.Layouts
{
    /// <summary>
    ///     The XAxis class.
    /// </summary>
    [Serializable]
    public class XAxis : IEquatable<XAxis>
    {
        /// <summary>
        ///     A single toggle to hide the axis while preserving interaction like dragging.
        ///     Default is true when a cheater plot is present on the axis, otherwise false
        /// </summary>
        [JsonPropertyName(@"visible")]
        public bool? Visible { get; set; }

        /// <summary>
        ///     Sets default for all colors associated with this axis all at once: line,
        ///     font, tick, and grid colors. Grid color is lightened by blending this with
        ///     the plot background Individual pieces can override this.
        /// </summary>
        [JsonPropertyName(@"color")]
        public object Color { get; set; }

        /// <summary>
        ///     Gets or sets the Title.
        /// </summary>
        [JsonPropertyName(@"title")]
        public XAxes.Title Title { get; set; }

        /// <summary>
        ///     Sets the axis type. By default, plotly attempts to determined the axis type
        ///     by looking into the data of the traces that referenced the axis in question.
        /// </summary>
        [JsonPropertyName(@"type")]
        public TypeEnum? Type { get; set; }

        /// <summary>
        ///     Determines whether or not the range of this axis is computed in relation
        ///     to the input data. See <c>rangemode</c> for more info. If <c>range</c> is
        ///     provided, then <c>autorange</c> is set to <c>false</c>.
        /// </summary>
        [JsonPropertyName(@"autorange")]
        public AutoRangeEnum? AutoRange { get; set; }

        /// <summary>
        ///     If <c>normal</c>, the range is computed in relation to the extrema of the
        ///     input data. If <c>tozero</c>`, the range extends to 0, regardless of the
        ///     input data If <c>nonnegative</c>, the range is non-negative, regardless
        ///     of the input data. Applies only to linear axes.
        /// </summary>
        [JsonPropertyName(@"rangemode")]
        public RangeModeEnum? RangeMode { get; set; }

        /// <summary>
        ///     Sets the range of this axis. If the axis <c>type</c> is <c>log</c>, then
        ///     you must take the log of your desired range (e.g. to set the range from
        ///     1 to 100, set the range from 0 to 2). If the axis <c>type</c> is <c>date</c>,
        ///     it should be date strings, like date data, though Date objects and unix
        ///     milliseconds will be accepted and converted to strings. If the axis <c>type</c>
        ///     is <c>category</c>, it should be numbers, using the scale where each category
        ///     is assigned a serial number from zero in the order it appears.
        /// </summary>
        [JsonPropertyName(@"range")]
        public List<object> Range { get; set; }

        /// <summary>
        ///     Determines whether or not this axis is zoom-able. If true, then zoom is
        ///     disabled.
        /// </summary>
        [JsonPropertyName(@"fixedrange")]
        public bool? FixedRange { get; set; }

        /// <summary>
        ///     If set to another axis id (e.g. <c>x2</c>, <c>y</c>), the range of this
        ///     axis changes together with the range of the corresponding axis such that
        ///     the scale of pixels per unit is in a constant ratio. Both axes are still
        ///     zoomable, but when you zoom one, the other will zoom the same amount, keeping
        ///     a fixed midpoint. <c>constrain</c> and <c>constraintoward</c> determine
        ///     how we enforce the constraint. You can chain these, ie &#39;yaxis: {scaleanchor:
        ///     <c>x</c>}, xaxis2: {scaleanchor: <c>y</c>}&#39; but you can only link axes
        ///     of the same <c>type</c>. The linked axis can have the opposite letter (to
        ///     constrain the aspect ratio) or the same letter (to match scales across subplots).
        ///     Loops (&#39;yaxis: {scaleanchor: <c>x</c>}, xaxis: {scaleanchor: <c>y</c>}&#39;
        ///     or longer) are redundant and the last constraint encountered will be ignored
        ///     to avoid possible inconsistent constraints via <c>scaleratio</c>. Note that
        ///     setting axes simultaneously in both a <c>scaleanchor</c> and a <c>matches</c>
        ///     constraint is currently forbidden.
        /// </summary>
        [JsonPropertyName(@"scaleanchor")]
        public string ScaleAnchor { get; set; }

        /// <summary>
        ///     If this axis is linked to another by <c>scaleanchor</c>, this determines
        ///     the pixel to unit scale ratio. For example, if this value is 10, then every
        ///     unit on this axis spans 10 times the number of pixels as a unit on the linked
        ///     axis. Use this for example to create an elevation profile where the vertical
        ///     scale is exaggerated a fixed amount with respect to the horizontal.
        /// </summary>
        [JsonPropertyName(@"scaleratio")]
        public JsNumber? ScaleRatio { get; set; }

        /// <summary>
        ///     If this axis needs to be compressed (either due to its own <c>scaleanchor</c>
        ///     and <c>scaleratio</c> or those of the other axis), determines how that happens:
        ///     by increasing the <c>range</c> (default), or by decreasing the <c>domain</c>.
        /// </summary>
        [JsonPropertyName(@"constrain")]
        public ConstrainEnum? Constrain { get; set; }

        /// <summary>
        ///     If this axis needs to be compressed (either due to its own <c>scaleanchor</c>
        ///     and <c>scaleratio</c> or those of the other axis), determines which direction
        ///     we push the originally specified plot area. Options are <c>left</c>, <c>center</c>
        ///     (default), and <c>right</c> for x axes, and <c>top</c>, <c>middle</c> (default),
        ///     and <c>bottom</c> for y axes.
        /// </summary>
        [JsonPropertyName(@"constraintoward")]
        public ConstrainTowardEnum? ConstrainToward { get; set; }

        /// <summary>
        ///     If set to another axis id (e.g. <c>x2</c>, <c>y</c>), the range of this
        ///     axis will match the range of the corresponding axis in data-coordinates
        ///     space. Moreover, matching axes share auto-range values, category lists and
        ///     histogram auto-bins. Note that setting axes simultaneously in both a <c>scaleanchor</c>
        ///     and a <c>matches</c> constraint is currently forbidden. Moreover, note that
        ///     matching axes must have the same <c>type</c>.
        /// </summary>
        [JsonPropertyName(@"matches")]
        public string Matches { get; set; }

        /// <summary>
        ///     Gets or sets the RangeBreaks.
        /// </summary>
        [JsonPropertyName(@"rangebreaks")]
        public List<RangeBreak> RangeBreaks { get; set; }

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
        public object Tick0 { get; set; }

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
        public object DTick { get; set; }

        /// <summary>
        ///     Sets the values at which ticks on this axis appear. Only has an effect if
        ///     <c>tickmode</c> is set to <c>array</c>. Used with <c>ticktext</c>.
        /// </summary>
        [JsonPropertyName(@"tickvals")]
        public List<object> TickVals { get; set; }

        /// <summary>
        ///     Sets the text displayed at the ticks position via <c>tickvals</c>. Only
        ///     has an effect if <c>tickmode</c> is set to <c>array</c>. Used with <c>tickvals</c>.
        /// </summary>
        [JsonPropertyName(@"ticktext")]
        public List<object> TickText { get; set; }

        /// <summary>
        ///     Determines whether ticks are drawn or not. If **, this axis&#39; ticks are
        ///     not drawn. If <c>outside</c> (<c>inside</c>), this axis&#39; are drawn outside
        ///     (inside) the axis lines.
        /// </summary>
        [JsonPropertyName(@"ticks")]
        public TicksEnum? Ticks { get; set; }

        /// <summary>
        ///     Determines where ticks and grid lines are drawn with respect to their corresponding
        ///     tick labels. Only has an effect for axes of <c>type</c> <c>category</c>
        ///     or <c>multicategory</c>. When set to <c>boundaries</c>, ticks and grid lines
        ///     are drawn half a category to the left/bottom of labels.
        /// </summary>
        [JsonPropertyName(@"tickson")]
        public TickSonEnum? TickSon { get; set; }

        /// <summary>
        ///     Determines if the axis lines or/and ticks are mirrored to the opposite side
        ///     of the plotting area. If <c>true</c>, the axis lines are mirrored. If <c>ticks</c>,
        ///     the axis lines and ticks are mirrored. If <c>false</c>, mirroring is disable.
        ///     If <c>all</c>, axis lines are mirrored on all shared-axes subplots. If <c>allticks</c>,
        ///     axis lines and ticks are mirrored on all shared-axes subplots.
        /// </summary>
        [JsonPropertyName(@"mirror")]
        public MirrorEnum? Mirror { get; set; }

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
        public object TickColor { get; set; }

        /// <summary>
        ///     Determines whether or not the tick labels are drawn.
        /// </summary>
        [JsonPropertyName(@"showticklabels")]
        public bool? ShowTickLabels { get; set; }

        /// <summary>
        ///     Determines whether long tick labels automatically grow the figure margins.
        /// </summary>
        [JsonPropertyName(@"automargin")]
        public bool? AutoMargin { get; set; }

        /// <summary>
        ///     Determines whether or not spikes (aka droplines) are drawn for this axis.
        ///     Note: This only takes affect when hovermode = closest
        /// </summary>
        [JsonPropertyName(@"showspikes")]
        public bool? ShowSpikes { get; set; }

        /// <summary>
        ///     Sets the spike color. If undefined, will use the series color
        /// </summary>
        [JsonPropertyName(@"spikecolor")]
        public object SpikeColor { get; set; }

        /// <summary>
        ///     Sets the width (in px) of the zero line.
        /// </summary>
        [JsonPropertyName(@"spikethickness")]
        public JsNumber? SpikeThickness { get; set; }

        /// <summary>
        ///     Sets the dash style of lines. Set to a dash type string (<c>solid</c>, <c>dot</c>,
        ///     <c>dash</c>, <c>longdash</c>, <c>dashdot</c>, or <c>longdashdot</c>) or
        ///     a dash length list in px (eg <c>5px,10px,2px,2px</c>).
        /// </summary>
        [JsonPropertyName(@"spikedash")]
        public string SpikeDash { get; set; }

        /// <summary>
        ///     Determines the drawing mode for the spike line If <c>toaxis</c>, the line
        ///     is drawn from the data point to the axis the  series is plotted on. If <c>across</c>,
        ///     the line is drawn across the entire plot area, and supercedes <c>toaxis</c>.
        ///     If <c>marker</c>, then a marker dot is drawn on the axis the series is plotted
        ///     on
        /// </summary>
        [JsonPropertyName(@"spikemode")]
        public SpikeModeFlag? SpikeMode { get; set; }

        /// <summary>
        ///     Determines whether spikelines are stuck to the cursor or to the closest
        ///     datapoints.
        /// </summary>
        [JsonPropertyName(@"spikesnap")]
        public SpikeSnapEnum? SpikeSnap { get; set; }

        /// <summary>
        ///     Sets the tick font.
        /// </summary>
        [JsonPropertyName(@"tickfont")]
        public TickFont TickFont { get; set; }

        /// <summary>
        ///     Sets the angle of the tick labels with respect to the horizontal. For example,
        ///     a <c>tickangle</c> of -90 draws the tick labels vertically.
        /// </summary>
        [JsonPropertyName(@"tickangle")]
        public JsNumber? TickAngle { get; set; }

        /// <summary>
        ///     Sets a tick label prefix.
        /// </summary>
        [JsonPropertyName(@"tickprefix")]
        public string TickPrefix { get; set; }

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
        public string TickSuffix { get; set; }

        /// <summary>
        ///     Same as <c>showtickprefix</c> but for tick suffixes.
        /// </summary>
        [JsonPropertyName(@"showticksuffix")]
        public ShowTickSuffixEnum? ShowTickSuffix { get; set; }

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
        ///     Sets the tick label formatting rule using d3 formatting mini-languages which
        ///     are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        ///     And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format
        ///     We add one item to d3&#39;s date formatter: <c>%{n}f</c> for fractional
        ///     seconds with n digits. For example, &#39;2016-10-13 09:15:23.456&#39; with
        ///     tickformat <c>%H~%M~%S.%2f</c> would display <c>09~15~23.46</c>
        /// </summary>
        [JsonPropertyName(@"tickformat")]
        public string TickFormat { get; set; }

        /// <summary>
        ///     Gets or sets the TickFormatStops.
        /// </summary>
        [JsonPropertyName(@"tickformatstops")]
        public List<TickFormatStop> TickFormatStops { get; set; }

        /// <summary>
        ///     Sets the hover text formatting rule using d3 formatting mini-languages which
        ///     are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        ///     And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format
        ///     We add one item to d3&#39;s date formatter: <c>%{n}f</c> for fractional
        ///     seconds with n digits. For example, &#39;2016-10-13 09:15:23.456&#39; with
        ///     tickformat <c>%H~%M~%S.%2f</c> would display <c>09~15~23.46</c>
        /// </summary>
        [JsonPropertyName(@"hoverformat")]
        public string HoverFormat { get; set; }

        /// <summary>
        ///     Determines whether or not a line bounding this axis is drawn.
        /// </summary>
        [JsonPropertyName(@"showline")]
        public bool? ShowLine { get; set; }

        /// <summary>
        ///     Sets the axis line color.
        /// </summary>
        [JsonPropertyName(@"linecolor")]
        public object LineColor { get; set; }

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
        public object GridColor { get; set; }

        /// <summary>
        ///     Sets the width (in px) of the grid lines.
        /// </summary>
        [JsonPropertyName(@"gridwidth")]
        public JsNumber? GridWidth { get; set; }

        /// <summary>
        ///     Determines whether or not a line is drawn at along the 0 value of this axis.
        ///     If <c>true</c>, the zero line is drawn on top of the grid lines.
        /// </summary>
        [JsonPropertyName(@"zeroline")]
        public bool? ZeroLine { get; set; }

        /// <summary>
        ///     Sets the line color of the zero line.
        /// </summary>
        [JsonPropertyName(@"zerolinecolor")]
        public object ZeroLineColor { get; set; }

        /// <summary>
        ///     Sets the width (in px) of the zero line.
        /// </summary>
        [JsonPropertyName(@"zerolinewidth")]
        public JsNumber? ZeroLineWidth { get; set; }

        /// <summary>
        ///     Determines whether or not a dividers are drawn between the category levels
        ///     of this axis. Only has an effect on <c>multicategory</c> axes.
        /// </summary>
        [JsonPropertyName(@"showdividers")]
        public bool? ShowDividers { get; set; }

        /// <summary>
        ///     Sets the color of the dividers Only has an effect on <c>multicategory</c>
        ///     axes.
        /// </summary>
        [JsonPropertyName(@"dividercolor")]
        public object DividerColor { get; set; }

        /// <summary>
        ///     Sets the width (in px) of the dividers Only has an effect on <c>multicategory</c>
        ///     axes.
        /// </summary>
        [JsonPropertyName(@"dividerwidth")]
        public JsNumber? DividerWidth { get; set; }

        /// <summary>
        ///     If set to an opposite-letter axis id (e.g. <c>x2</c>, <c>y</c>), this axis
        ///     is bound to the corresponding opposite-letter axis. If set to <c>free</c>,
        ///     this axis&#39; position is determined by <c>position</c>.
        /// </summary>
        [JsonPropertyName(@"anchor")]
        public string Anchor { get; set; }

        /// <summary>
        ///     Determines whether a x (y) axis is positioned at the <c>bottom</c> (<c>left</c>)
        ///     or <c>top</c> (<c>right</c>) of the plotting area.
        /// </summary>
        [JsonPropertyName(@"side")]
        public SideEnum? Side { get; set; }

        /// <summary>
        ///     If set a same-letter axis id, this axis is overlaid on top of the corresponding
        ///     same-letter axis, with traces and axes visible for both axes. If <c>false</c>,
        ///     this axis does not overlay any same-letter axes. In this case, for axes
        ///     with overlapping domains only the highest-numbered axis will be visible.
        /// </summary>
        [JsonPropertyName(@"overlaying")]
        public string Overlaying { get; set; }

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
        ///     Sets the domain of this axis (in plot fraction).
        /// </summary>
        [JsonPropertyName(@"domain")]
        public List<object> Domain { get; set; }

        /// <summary>
        ///     Sets the position of this axis in the plotting space (in normalized coordinates).
        ///     Only has an effect if <c>anchor</c> is set to <c>free</c>.
        /// </summary>
        [JsonPropertyName(@"position")]
        public JsNumber? Position { get; set; }

        /// <summary>
        ///     Specifies the ordering logic for the case of categorical variables. By default,
        ///     plotly uses <c>trace</c>, which specifies the order that is present in the
        ///     data supplied. Set <c>categoryorder</c> to &#39;category ascending&#39;
        ///     or &#39;category descending&#39; if order should be determined by the alphanumerical
        ///     order of the category names. Set <c>categoryorder</c> to <c>array</c> to
        ///     derive the ordering from the attribute <c>categoryarray</c>. If a category
        ///     is not found in the <c>categoryarray</c> array, the sorting behavior for
        ///     that attribute will be identical to the <c>trace</c> mode. The unspecified
        ///     categories will follow the categories in <c>categoryarray</c>. Set <c>categoryorder</c>
        ///     to &#39;total ascending&#39; or &#39;total descending&#39; if order should
        ///     be determined by the numerical order of the values. Similarly, the order
        ///     can be determined by the min, max, sum, mean or median of all the values.
        /// </summary>
        [JsonPropertyName(@"categoryorder")]
        public CategoryOrderEnum? CategoryOrder { get; set; }

        /// <summary>
        ///     Sets the order in which categories on this axis appear. Only has an effect
        ///     if <c>categoryorder</c> is set to <c>array</c>. Used with <c>categoryorder</c>.
        /// </summary>
        [JsonPropertyName(@"categoryarray")]
        public List<object> CategoryArray { get; set; }

        /// <summary>
        ///     Controls persistence of user-driven changes in axis <c>range</c>, <c>autorange</c>,
        ///     and <c>title</c> if in &#39;editable: true&#39; configuration. Defaults
        ///     to <c>layout.uirevision</c>.
        /// </summary>
        [JsonPropertyName(@"uirevision")]
        public object UiRevision { get; set; }

        /// <summary>
        ///     Gets or sets the RangeSlider.
        /// </summary>
        [JsonPropertyName(@"rangeslider")]
        public RangeSlider RangeSlider { get; set; }

        /// <summary>
        ///     Gets or sets the RangeSelector.
        /// </summary>
        [JsonPropertyName(@"rangeselector")]
        public RangeSelector RangeSelector { get; set; }

        /// <summary>
        ///     Sets the calendar system to use for <c>range</c> and <c>tick0</c> if this
        ///     is a date axis. This does not set the calendar for interpreting data on
        ///     this axis, that&#39;s specified in the trace or via the global <c>layout.calendar</c>
        /// </summary>
        [JsonPropertyName(@"calendar")]
        public XAxes.CalendarEnum? Calendar { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  tickvals .
        /// </summary>
        [JsonPropertyName(@"tickvalssrc")]
        public string TickValsSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  ticktext .
        /// </summary>
        [JsonPropertyName(@"ticktextsrc")]
        public string TickTextSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  categoryarray .
        /// </summary>
        [JsonPropertyName(@"categoryarraysrc")]
        public string CategoryArraySrc { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is XAxis other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] XAxis other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (Visible   == other.Visible   && Visible   != null && other.Visible   != null && Visible.Equals(other.Visible))                                                      &&
                   (Color     == other.Color     && Color     != null && other.Color     != null && Color.Equals(other.Color))                                                          &&
                   (Title     == other.Title     && Title     != null && other.Title     != null && Title.Equals(other.Title))                                                          &&
                   (Type      == other.Type      && Type      != null && other.Type      != null && Type.Equals(other.Type))                                                            &&
                   (AutoRange == other.AutoRange && AutoRange != null && other.AutoRange != null && AutoRange.Equals(other.AutoRange))                                                  &&
                   (RangeMode == other.RangeMode && RangeMode != null && other.RangeMode != null && RangeMode.Equals(other.RangeMode))                                                  &&
                   (Equals(Range, other.Range) || Range != null && other.Range != null && Range.SequenceEqual(other.Range))                                                             &&
                   (FixedRange      == other.FixedRange      && FixedRange      != null && other.FixedRange      != null && FixedRange.Equals(other.FixedRange))                        &&
                   (ScaleAnchor     == other.ScaleAnchor     && ScaleAnchor     != null && other.ScaleAnchor     != null && ScaleAnchor.Equals(other.ScaleAnchor))                      &&
                   (ScaleRatio      == other.ScaleRatio      && ScaleRatio      != null && other.ScaleRatio      != null && ScaleRatio.Equals(other.ScaleRatio))                        &&
                   (Constrain       == other.Constrain       && Constrain       != null && other.Constrain       != null && Constrain.Equals(other.Constrain))                          &&
                   (ConstrainToward == other.ConstrainToward && ConstrainToward != null && other.ConstrainToward != null && ConstrainToward.Equals(other.ConstrainToward))              &&
                   (Matches         == other.Matches         && Matches         != null && other.Matches         != null && Matches.Equals(other.Matches))                              &&
                   (Equals(RangeBreaks, other.RangeBreaks) || RangeBreaks != null && other.RangeBreaks != null && RangeBreaks.SequenceEqual(other.RangeBreaks))                         &&
                   (TickMode == other.TickMode && TickMode != null && other.TickMode != null && TickMode.Equals(other.TickMode))                                                        &&
                   (NTicks   == other.NTicks   && NTicks   != null && other.NTicks   != null && NTicks.Equals(other.NTicks))                                                            &&
                   (Tick0    == other.Tick0    && Tick0    != null && other.Tick0    != null && Tick0.Equals(other.Tick0))                                                              &&
                   (DTick    == other.DTick    && DTick    != null && other.DTick    != null && DTick.Equals(other.DTick))                                                              &&
                   (Equals(TickVals, other.TickVals) || TickVals != null && other.TickVals != null && TickVals.SequenceEqual(other.TickVals))                                           &&
                   (Equals(TickText, other.TickText) || TickText != null && other.TickText != null && TickText.SequenceEqual(other.TickText))                                           &&
                   (Ticks             == other.Ticks             && Ticks             != null && other.Ticks             != null && Ticks.Equals(other.Ticks))                          &&
                   (TickSon           == other.TickSon           && TickSon           != null && other.TickSon           != null && TickSon.Equals(other.TickSon))                      &&
                   (Mirror            == other.Mirror            && Mirror            != null && other.Mirror            != null && Mirror.Equals(other.Mirror))                        &&
                   (TickleN           == other.TickleN           && TickleN           != null && other.TickleN           != null && TickleN.Equals(other.TickleN))                      &&
                   (TickWidth         == other.TickWidth         && TickWidth         != null && other.TickWidth         != null && TickWidth.Equals(other.TickWidth))                  &&
                   (TickColor         == other.TickColor         && TickColor         != null && other.TickColor         != null && TickColor.Equals(other.TickColor))                  &&
                   (ShowTickLabels    == other.ShowTickLabels    && ShowTickLabels    != null && other.ShowTickLabels    != null && ShowTickLabels.Equals(other.ShowTickLabels))        &&
                   (AutoMargin        == other.AutoMargin        && AutoMargin        != null && other.AutoMargin        != null && AutoMargin.Equals(other.AutoMargin))                &&
                   (ShowSpikes        == other.ShowSpikes        && ShowSpikes        != null && other.ShowSpikes        != null && ShowSpikes.Equals(other.ShowSpikes))                &&
                   (SpikeColor        == other.SpikeColor        && SpikeColor        != null && other.SpikeColor        != null && SpikeColor.Equals(other.SpikeColor))                &&
                   (SpikeThickness    == other.SpikeThickness    && SpikeThickness    != null && other.SpikeThickness    != null && SpikeThickness.Equals(other.SpikeThickness))        &&
                   (SpikeDash         == other.SpikeDash         && SpikeDash         != null && other.SpikeDash         != null && SpikeDash.Equals(other.SpikeDash))                  &&
                   (SpikeMode         == other.SpikeMode         && SpikeMode         != null && other.SpikeMode         != null && SpikeMode.Equals(other.SpikeMode))                  &&
                   (SpikeSnap         == other.SpikeSnap         && SpikeSnap         != null && other.SpikeSnap         != null && SpikeSnap.Equals(other.SpikeSnap))                  &&
                   (TickFont          == other.TickFont          && TickFont          != null && other.TickFont          != null && TickFont.Equals(other.TickFont))                    &&
                   (TickAngle         == other.TickAngle         && TickAngle         != null && other.TickAngle         != null && TickAngle.Equals(other.TickAngle))                  &&
                   (TickPrefix        == other.TickPrefix        && TickPrefix        != null && other.TickPrefix        != null && TickPrefix.Equals(other.TickPrefix))                &&
                   (ShowTickPrefix    == other.ShowTickPrefix    && ShowTickPrefix    != null && other.ShowTickPrefix    != null && ShowTickPrefix.Equals(other.ShowTickPrefix))        &&
                   (TickSuffix        == other.TickSuffix        && TickSuffix        != null && other.TickSuffix        != null && TickSuffix.Equals(other.TickSuffix))                &&
                   (ShowTickSuffix    == other.ShowTickSuffix    && ShowTickSuffix    != null && other.ShowTickSuffix    != null && ShowTickSuffix.Equals(other.ShowTickSuffix))        &&
                   (ShowExponent      == other.ShowExponent      && ShowExponent      != null && other.ShowExponent      != null && ShowExponent.Equals(other.ShowExponent))            &&
                   (ExponentFormat    == other.ExponentFormat    && ExponentFormat    != null && other.ExponentFormat    != null && ExponentFormat.Equals(other.ExponentFormat))        &&
                   (SeparateThousands == other.SeparateThousands && SeparateThousands != null && other.SeparateThousands != null && SeparateThousands.Equals(other.SeparateThousands))  &&
                   (TickFormat        == other.TickFormat        && TickFormat        != null && other.TickFormat        != null && TickFormat.Equals(other.TickFormat))                &&
                   (Equals(TickFormatStops, other.TickFormatStops) || TickFormatStops != null && other.TickFormatStops != null && TickFormatStops.SequenceEqual(other.TickFormatStops)) &&
                   (HoverFormat   == other.HoverFormat   && HoverFormat   != null && other.HoverFormat   != null && HoverFormat.Equals(other.HoverFormat))                              &&
                   (ShowLine      == other.ShowLine      && ShowLine      != null && other.ShowLine      != null && ShowLine.Equals(other.ShowLine))                                    &&
                   (LineColor     == other.LineColor     && LineColor     != null && other.LineColor     != null && LineColor.Equals(other.LineColor))                                  &&
                   (LineWidth     == other.LineWidth     && LineWidth     != null && other.LineWidth     != null && LineWidth.Equals(other.LineWidth))                                  &&
                   (ShowGrid      == other.ShowGrid      && ShowGrid      != null && other.ShowGrid      != null && ShowGrid.Equals(other.ShowGrid))                                    &&
                   (GridColor     == other.GridColor     && GridColor     != null && other.GridColor     != null && GridColor.Equals(other.GridColor))                                  &&
                   (GridWidth     == other.GridWidth     && GridWidth     != null && other.GridWidth     != null && GridWidth.Equals(other.GridWidth))                                  &&
                   (ZeroLine      == other.ZeroLine      && ZeroLine      != null && other.ZeroLine      != null && ZeroLine.Equals(other.ZeroLine))                                    &&
                   (ZeroLineColor == other.ZeroLineColor && ZeroLineColor != null && other.ZeroLineColor != null && ZeroLineColor.Equals(other.ZeroLineColor))                          &&
                   (ZeroLineWidth == other.ZeroLineWidth && ZeroLineWidth != null && other.ZeroLineWidth != null && ZeroLineWidth.Equals(other.ZeroLineWidth))                          &&
                   (ShowDividers  == other.ShowDividers  && ShowDividers  != null && other.ShowDividers  != null && ShowDividers.Equals(other.ShowDividers))                            &&
                   (DividerColor  == other.DividerColor  && DividerColor  != null && other.DividerColor  != null && DividerColor.Equals(other.DividerColor))                            &&
                   (DividerWidth  == other.DividerWidth  && DividerWidth  != null && other.DividerWidth  != null && DividerWidth.Equals(other.DividerWidth))                            &&
                   (Anchor        == other.Anchor        && Anchor        != null && other.Anchor        != null && Anchor.Equals(other.Anchor))                                        &&
                   (Side          == other.Side          && Side          != null && other.Side          != null && Side.Equals(other.Side))                                            &&
                   (Overlaying    == other.Overlaying    && Overlaying    != null && other.Overlaying    != null && Overlaying.Equals(other.Overlaying))                                &&
                   (Layer         == other.Layer         && Layer         != null && other.Layer         != null && Layer.Equals(other.Layer))                                          &&
                   (Equals(Domain, other.Domain) || Domain != null && other.Domain != null && Domain.SequenceEqual(other.Domain))                                                       &&
                   (Position      == other.Position      && Position      != null && other.Position      != null && Position.Equals(other.Position))                                    &&
                   (CategoryOrder == other.CategoryOrder && CategoryOrder != null && other.CategoryOrder != null && CategoryOrder.Equals(other.CategoryOrder))                          &&
                   (Equals(CategoryArray, other.CategoryArray) || CategoryArray != null && other.CategoryArray != null && CategoryArray.SequenceEqual(other.CategoryArray))             &&
                   (UiRevision       == other.UiRevision       && UiRevision       != null && other.UiRevision       != null && UiRevision.Equals(other.UiRevision))                    &&
                   (RangeSlider      == other.RangeSlider      && RangeSlider      != null && other.RangeSlider      != null && RangeSlider.Equals(other.RangeSlider))                  &&
                   (RangeSelector    == other.RangeSelector    && RangeSelector    != null && other.RangeSelector    != null && RangeSelector.Equals(other.RangeSelector))              &&
                   (Calendar         == other.Calendar         && Calendar         != null && other.Calendar         != null && Calendar.Equals(other.Calendar))                        &&
                   (TickValsSrc      == other.TickValsSrc      && TickValsSrc      != null && other.TickValsSrc      != null && TickValsSrc.Equals(other.TickValsSrc))                  &&
                   (TickTextSrc      == other.TickTextSrc      && TickTextSrc      != null && other.TickTextSrc      != null && TickTextSrc.Equals(other.TickTextSrc))                  &&
                   (CategoryArraySrc == other.CategoryArraySrc && CategoryArraySrc != null && other.CategoryArraySrc != null && CategoryArraySrc.Equals(other.CategoryArraySrc));
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;

                if(Visible != null)
                    hashCode = hashCode * 59 + Visible.GetHashCode();

                if(Color != null)
                    hashCode = hashCode * 59 + Color.GetHashCode();

                if(Title != null)
                    hashCode = hashCode * 59 + Title.GetHashCode();

                if(Type != null)
                    hashCode = hashCode * 59 + Type.GetHashCode();

                if(AutoRange != null)
                    hashCode = hashCode * 59 + AutoRange.GetHashCode();

                if(RangeMode != null)
                    hashCode = hashCode * 59 + RangeMode.GetHashCode();

                if(Range != null)
                    hashCode = hashCode * 59 + Range.GetHashCode();

                if(FixedRange != null)
                    hashCode = hashCode * 59 + FixedRange.GetHashCode();

                if(ScaleAnchor != null)
                    hashCode = hashCode * 59 + ScaleAnchor.GetHashCode();

                if(ScaleRatio != null)
                    hashCode = hashCode * 59 + ScaleRatio.GetHashCode();

                if(Constrain != null)
                    hashCode = hashCode * 59 + Constrain.GetHashCode();

                if(ConstrainToward != null)
                    hashCode = hashCode * 59 + ConstrainToward.GetHashCode();

                if(Matches != null)
                    hashCode = hashCode * 59 + Matches.GetHashCode();

                if(RangeBreaks != null)
                    hashCode = hashCode * 59 + RangeBreaks.GetHashCode();

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

                if(TickSon != null)
                    hashCode = hashCode * 59 + TickSon.GetHashCode();

                if(Mirror != null)
                    hashCode = hashCode * 59 + Mirror.GetHashCode();

                if(TickleN != null)
                    hashCode = hashCode * 59 + TickleN.GetHashCode();

                if(TickWidth != null)
                    hashCode = hashCode * 59 + TickWidth.GetHashCode();

                if(TickColor != null)
                    hashCode = hashCode * 59 + TickColor.GetHashCode();

                if(ShowTickLabels != null)
                    hashCode = hashCode * 59 + ShowTickLabels.GetHashCode();

                if(AutoMargin != null)
                    hashCode = hashCode * 59 + AutoMargin.GetHashCode();

                if(ShowSpikes != null)
                    hashCode = hashCode * 59 + ShowSpikes.GetHashCode();

                if(SpikeColor != null)
                    hashCode = hashCode * 59 + SpikeColor.GetHashCode();

                if(SpikeThickness != null)
                    hashCode = hashCode * 59 + SpikeThickness.GetHashCode();

                if(SpikeDash != null)
                    hashCode = hashCode * 59 + SpikeDash.GetHashCode();

                if(SpikeMode != null)
                    hashCode = hashCode * 59 + SpikeMode.GetHashCode();

                if(SpikeSnap != null)
                    hashCode = hashCode * 59 + SpikeSnap.GetHashCode();

                if(TickFont != null)
                    hashCode = hashCode * 59 + TickFont.GetHashCode();

                if(TickAngle != null)
                    hashCode = hashCode * 59 + TickAngle.GetHashCode();

                if(TickPrefix != null)
                    hashCode = hashCode * 59 + TickPrefix.GetHashCode();

                if(ShowTickPrefix != null)
                    hashCode = hashCode * 59 + ShowTickPrefix.GetHashCode();

                if(TickSuffix != null)
                    hashCode = hashCode * 59 + TickSuffix.GetHashCode();

                if(ShowTickSuffix != null)
                    hashCode = hashCode * 59 + ShowTickSuffix.GetHashCode();

                if(ShowExponent != null)
                    hashCode = hashCode * 59 + ShowExponent.GetHashCode();

                if(ExponentFormat != null)
                    hashCode = hashCode * 59 + ExponentFormat.GetHashCode();

                if(SeparateThousands != null)
                    hashCode = hashCode * 59 + SeparateThousands.GetHashCode();

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

                if(ZeroLine != null)
                    hashCode = hashCode * 59 + ZeroLine.GetHashCode();

                if(ZeroLineColor != null)
                    hashCode = hashCode * 59 + ZeroLineColor.GetHashCode();

                if(ZeroLineWidth != null)
                    hashCode = hashCode * 59 + ZeroLineWidth.GetHashCode();

                if(ShowDividers != null)
                    hashCode = hashCode * 59 + ShowDividers.GetHashCode();

                if(DividerColor != null)
                    hashCode = hashCode * 59 + DividerColor.GetHashCode();

                if(DividerWidth != null)
                    hashCode = hashCode * 59 + DividerWidth.GetHashCode();

                if(Anchor != null)
                    hashCode = hashCode * 59 + Anchor.GetHashCode();

                if(Side != null)
                    hashCode = hashCode * 59 + Side.GetHashCode();

                if(Overlaying != null)
                    hashCode = hashCode * 59 + Overlaying.GetHashCode();

                if(Layer != null)
                    hashCode = hashCode * 59 + Layer.GetHashCode();

                if(Domain != null)
                    hashCode = hashCode * 59 + Domain.GetHashCode();

                if(Position != null)
                    hashCode = hashCode * 59 + Position.GetHashCode();

                if(CategoryOrder != null)
                    hashCode = hashCode * 59 + CategoryOrder.GetHashCode();

                if(CategoryArray != null)
                    hashCode = hashCode * 59 + CategoryArray.GetHashCode();

                if(UiRevision != null)
                    hashCode = hashCode * 59 + UiRevision.GetHashCode();

                if(RangeSlider != null)
                    hashCode = hashCode * 59 + RangeSlider.GetHashCode();

                if(RangeSelector != null)
                    hashCode = hashCode * 59 + RangeSelector.GetHashCode();

                if(Calendar != null)
                    hashCode = hashCode * 59 + Calendar.GetHashCode();

                if(TickValsSrc != null)
                    hashCode = hashCode * 59 + TickValsSrc.GetHashCode();

                if(TickTextSrc != null)
                    hashCode = hashCode * 59 + TickTextSrc.GetHashCode();

                if(CategoryArraySrc != null)
                    hashCode = hashCode * 59 + CategoryArraySrc.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left XAxis and the right XAxis.
        /// </summary>
        /// <param name="left">Left XAxis.</param>
        /// <param name="right">Right XAxis.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(XAxis left,
                                       XAxis right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left XAxis and the right XAxis.
        /// </summary>
        /// <param name="left">Left XAxis.</param>
        /// <param name="right">Right XAxis.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(XAxis left,
                                       XAxis right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>XAxis</returns>
        public XAxis DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<XAxis>(ms).Result;
        }
    }
}
