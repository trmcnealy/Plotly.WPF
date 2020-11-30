using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Traces.Carpets.AAxes;

namespace Plotly.Models.Traces.Carpets
{
    /// <summary>
    ///     The AAxis class.
    /// </summary>
    
    [Serializable]
    public class AAxis : IEquatable<AAxis>
    {
        /// <summary>
        ///     Sets default for all colors associated with this axis all at once: line,
        ///     font, tick, and grid colors. Grid color is lightened by blending this with
        ///     the plot background Individual pieces can override this.
        /// </summary>
        [JsonPropertyName(@"color")]
        public object Color { get; set;} 

        /// <summary>
        ///     Gets or sets the Smoothing.
        /// </summary>
        [JsonPropertyName(@"smoothing")]
        public JsNumber? Smoothing { get; set;} 

        /// <summary>
        ///     Gets or sets the Title.
        /// </summary>
        [JsonPropertyName(@"title")]
        public Title Title { get; set;} 

        /// <summary>
        ///     Sets the axis type. By default, plotly attempts to determined the axis type
        ///     by looking into the data of the traces that referenced the axis in question.
        /// </summary>
        [JsonPropertyName(@"type")]
        public TypeEnum? Type { get; set;} 

        /// <summary>
        ///     Determines whether or not the range of this axis is computed in relation
        ///     to the input data. See <c>rangemode</c> for more info. If <c>range</c> is
        ///     provided, then <c>autorange</c> is set to <c>false</c>.
        /// </summary>
        [JsonPropertyName(@"autorange")]
        public AutoRangeEnum? AutoRange { get; set;} 

        /// <summary>
        ///     If <c>normal</c>, the range is computed in relation to the extrema of the
        ///     input data. If <c>tozero</c>`, the range extends to 0, regardless of the
        ///     input data If <c>nonnegative</c>, the range is non-negative, regardless
        ///     of the input data.
        /// </summary>
        [JsonPropertyName(@"rangemode")]
        public RangeModeEnum? RangeMode { get; set;} 

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
        public List<object> Range { get; set;} 

        /// <summary>
        ///     Determines whether or not this axis is zoom-able. If true, then zoom is
        ///     disabled.
        /// </summary>
        [JsonPropertyName(@"fixedrange")]
        public bool? FixedRange { get; set;} 

        /// <summary>
        ///     Gets or sets the CheaterType.
        /// </summary>
        [JsonPropertyName(@"cheatertype")]
        public CheaterTypeEnum? CheaterType { get; set;} 

        /// <summary>
        ///     Gets or sets the TickMode.
        /// </summary>
        [JsonPropertyName(@"tickmode")]
        public TickModeEnum? TickMode { get; set;} 

        /// <summary>
        ///     Specifies the maximum number of ticks for the particular axis. The actual
        ///     number of ticks will be chosen automatically to be less than or equal to
        ///     <c>nticks</c>. Has an effect only if <c>tickmode</c> is set to <c>auto</c>.
        /// </summary>
        [JsonPropertyName(@"nticks")]
        public int? NTicks { get; set;} 

        /// <summary>
        ///     Sets the values at which ticks on this axis appear. Only has an effect if
        ///     <c>tickmode</c> is set to <c>array</c>. Used with <c>ticktext</c>.
        /// </summary>
        [JsonPropertyName(@"tickvals")]
        public List<object> TickVals { get; set;} 

        /// <summary>
        ///     Sets the text displayed at the ticks position via <c>tickvals</c>. Only
        ///     has an effect if <c>tickmode</c> is set to <c>array</c>. Used with <c>tickvals</c>.
        /// </summary>
        [JsonPropertyName(@"ticktext")]
        public List<object> TickText { get; set;} 

        /// <summary>
        ///     Determines whether axis labels are drawn on the low side, the high side,
        ///     both, or neither side of the axis.
        /// </summary>
        [JsonPropertyName(@"showticklabels")]
        public ShowTickLabelsEnum? ShowTickLabels { get; set;} 

        /// <summary>
        ///     Sets the tick font.
        /// </summary>
        [JsonPropertyName(@"tickfont")]
        public TickFont TickFont { get; set;} 

        /// <summary>
        ///     Sets the angle of the tick labels with respect to the horizontal. For example,
        ///     a <c>tickangle</c> of -90 draws the tick labels vertically.
        /// </summary>
        [JsonPropertyName(@"tickangle")]
        public JsNumber? TickAngle { get; set;} 

        /// <summary>
        ///     Sets a tick label prefix.
        /// </summary>
        [JsonPropertyName(@"tickprefix")]
        public string TickPrefix { get; set;} 

        /// <summary>
        ///     If <c>all</c>, all tick labels are displayed with a prefix. If <c>first</c>,
        ///     only the first tick is displayed with a prefix. If <c>last</c>, only the
        ///     last tick is displayed with a suffix. If <c>none</c>, tick prefixes are
        ///     hidden.
        /// </summary>
        [JsonPropertyName(@"showtickprefix")]
        public ShowTickPrefixEnum? ShowTickPrefix { get; set;} 

        /// <summary>
        ///     Sets a tick label suffix.
        /// </summary>
        [JsonPropertyName(@"ticksuffix")]
        public string TickSuffix { get; set;} 

        /// <summary>
        ///     Same as <c>showtickprefix</c> but for tick suffixes.
        /// </summary>
        [JsonPropertyName(@"showticksuffix")]
        public ShowTickSuffixEnum? ShowTickSuffix { get; set;} 

        /// <summary>
        ///     If <c>all</c>, all exponents are shown besides their significands. If <c>first</c>,
        ///     only the exponent of the first tick is shown. If <c>last</c>, only the exponent
        ///     of the last tick is shown. If <c>none</c>, no exponents appear.
        /// </summary>
        [JsonPropertyName(@"showexponent")]
        public ShowExponentEnum? ShowExponent { get; set;} 

        /// <summary>
        ///     Determines a formatting rule for the tick exponents. For example, consider
        ///     the number 1,000,000,000. If <c>none</c>, it appears as 1,000,000,000. If
        ///     <c>e</c>, 1e+9. If <c>E</c>, 1E+9. If <c>power</c>, 1x10^9 (with 9 in a
        ///     super script). If <c>SI</c>, 1G. If <c>B</c>, 1B.
        /// </summary>
        [JsonPropertyName(@"exponentformat")]
        public ExponentFormatEnum? ExponentFormat { get; set;} 

        /// <summary>
        ///     If <c>true</c>, even 4-digit integers are separated
        /// </summary>
        [JsonPropertyName(@"separatethousands")]
        public bool? SeparateThousands { get; set;} 

        /// <summary>
        ///     Sets the tick label formatting rule using d3 formatting mini-languages which
        ///     are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        ///     And for dates see:  We add one item to d3&#39;s date formatter: <c>%{n}f</c>
        ///     for fractional seconds with n digits. For example, &#39;2016-10-13 09:15:23.456&#39;
        ///     with tickformat <c>%H~%M~%S.%2f</c> would display <c>09~15~23.46</c>
        /// </summary>
        [JsonPropertyName(@"tickformat")]
        public string TickFormat { get; set;} 

        /// <summary>
        ///     Gets or sets the TickFormatStops.
        /// </summary>
        [JsonPropertyName(@"tickformatstops")]
        public List<TickFormatStop> TickFormatStops { get; set;} 

        /// <summary>
        ///     Specifies the ordering logic for the case of categorical variables. By default,
        ///     plotly uses <c>trace</c>, which specifies the order that is present in the
        ///     data supplied. Set <c>categoryorder</c> to &#39;category ascending&#39;
        ///     or &#39;category descending&#39; if order should be determined by the alphanumerical
        ///     order of the category names. Set <c>categoryorder</c> to <c>array</c> to
        ///     derive the ordering from the attribute <c>categoryarray</c>. If a category
        ///     is not found in the <c>categoryarray</c> array, the sorting behavior for
        ///     that attribute will be identical to the <c>trace</c> mode. The unspecified
        ///     categories will follow the categories in <c>categoryarray</c>.
        /// </summary>
        [JsonPropertyName(@"categoryorder")]
        public CategoryOrderEnum? CategoryOrder { get; set;} 

        /// <summary>
        ///     Sets the order in which categories on this axis appear. Only has an effect
        ///     if <c>categoryorder</c> is set to <c>array</c>. Used with <c>categoryorder</c>.
        /// </summary>
        [JsonPropertyName(@"categoryarray")]
        public List<object> CategoryArray { get; set;} 

        /// <summary>
        ///     Extra padding between label and the axis
        /// </summary>
        [JsonPropertyName(@"labelpadding")]
        public int? LabelPadding { get; set;} 

        /// <summary>
        ///     Sets a axis label prefix.
        /// </summary>
        [JsonPropertyName(@"labelprefix")]
        public string LabelPrefix { get; set;} 

        /// <summary>
        ///     Sets a axis label suffix.
        /// </summary>
        [JsonPropertyName(@"labelsuffix")]
        public string LabelSuffix { get; set;} 

        /// <summary>
        ///     Determines whether or not a line bounding this axis is drawn.
        /// </summary>
        [JsonPropertyName(@"showline")]
        public bool? ShowLine { get; set;} 

        /// <summary>
        ///     Sets the axis line color.
        /// </summary>
        [JsonPropertyName(@"linecolor")]
        public object LineColor { get; set;} 

        /// <summary>
        ///     Sets the width (in px) of the axis line.
        /// </summary>
        [JsonPropertyName(@"linewidth")]
        public JsNumber? LineWidth { get; set;} 

        /// <summary>
        ///     Sets the axis line color.
        /// </summary>
        [JsonPropertyName(@"gridcolor")]
        public object GridColor { get; set;} 

        /// <summary>
        ///     Sets the width (in px) of the axis line.
        /// </summary>
        [JsonPropertyName(@"gridwidth")]
        public JsNumber? GridWidth { get; set;} 

        /// <summary>
        ///     Determines whether or not grid lines are drawn. If <c>true</c>, the grid
        ///     lines are drawn at every tick mark.
        /// </summary>
        [JsonPropertyName(@"showgrid")]
        public bool? ShowGrid { get; set;} 

        /// <summary>
        ///     Sets the number of minor grid ticks per major grid tick
        /// </summary>
        [JsonPropertyName(@"minorgridcount")]
        public int? MinorGridCount { get; set;} 

        /// <summary>
        ///     Sets the width (in px) of the grid lines.
        /// </summary>
        [JsonPropertyName(@"minorgridwidth")]
        public JsNumber? MinorGridWidth { get; set;} 

        /// <summary>
        ///     Sets the color of the grid lines.
        /// </summary>
        [JsonPropertyName(@"minorgridcolor")]
        public object MinorGridColor { get; set;} 

        /// <summary>
        ///     Determines whether or not a line is drawn at along the starting value of
        ///     this axis. If <c>true</c>, the start line is drawn on top of the grid lines.
        /// </summary>
        [JsonPropertyName(@"startline")]
        public bool? StartLine { get; set;} 

        /// <summary>
        ///     Sets the line color of the start line.
        /// </summary>
        [JsonPropertyName(@"startlinecolor")]
        public object StartLineColor { get; set;} 

        /// <summary>
        ///     Sets the width (in px) of the start line.
        /// </summary>
        [JsonPropertyName(@"startlinewidth")]
        public JsNumber? StartLineWidth { get; set;} 

        /// <summary>
        ///     Determines whether or not a line is drawn at along the final value of this
        ///     axis. If <c>true</c>, the end line is drawn on top of the grid lines.
        /// </summary>
        [JsonPropertyName(@"endline")]
        public bool? EndLine { get; set;} 

        /// <summary>
        ///     Sets the width (in px) of the end line.
        /// </summary>
        [JsonPropertyName(@"endlinewidth")]
        public JsNumber? EndlineWidth { get; set;} 

        /// <summary>
        ///     Sets the line color of the end line.
        /// </summary>
        [JsonPropertyName(@"endlinecolor")]
        public object EndlineColor { get; set;} 

        /// <summary>
        ///     The starting index of grid lines along the axis
        /// </summary>
        [JsonPropertyName(@"tick0")]
        public JsNumber? Tick0 { get; set;} 

        /// <summary>
        ///     The stride between grid lines along the axis
        /// </summary>
        [JsonPropertyName(@"dtick")]
        public JsNumber? DTick { get; set;} 

        /// <summary>
        ///     The starting index of grid lines along the axis
        /// </summary>
        [JsonPropertyName(@"arraytick0")]
        public int? ArrayTick0 { get; set;} 

        /// <summary>
        ///     The stride between grid lines along the axis
        /// </summary>
        [JsonPropertyName(@"arraydtick")]
        public int? ArrayDTick { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  tickvals .
        /// </summary>
        [JsonPropertyName(@"tickvalssrc")]
        public string TickValsSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  ticktext .
        /// </summary>
        [JsonPropertyName(@"ticktextsrc")]
        public string TickTextSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  categoryarray .
        /// </summary>
        [JsonPropertyName(@"categoryarraysrc")]
        public string CategoryArraySrc { get; set;} 

        
        public override bool Equals(object obj)
        {
            if (!(obj is AAxis other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        
        public bool Equals([AllowNull] AAxis other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Color == other.Color &&
                    Color != null && other.Color != null &&
                    Color.Equals(other.Color)
                ) && 
                (
                    Smoothing == other.Smoothing &&
                    Smoothing != null && other.Smoothing != null &&
                    Smoothing.Equals(other.Smoothing)
                ) && 
                (
                    Title == other.Title &&
                    Title != null && other.Title != null &&
                    Title.Equals(other.Title)
                ) && 
                (
                    Type == other.Type &&
                    Type != null && other.Type != null &&
                    Type.Equals(other.Type)
                ) && 
                (
                    AutoRange == other.AutoRange &&
                    AutoRange != null && other.AutoRange != null &&
                    AutoRange.Equals(other.AutoRange)
                ) && 
                (
                    RangeMode == other.RangeMode &&
                    RangeMode != null && other.RangeMode != null &&
                    RangeMode.Equals(other.RangeMode)
                ) && 
                (
                    Equals(Range, other.Range) ||
                    Range != null && other.Range != null &&
                    Range.SequenceEqual(other.Range)
                ) &&
                (
                    FixedRange == other.FixedRange &&
                    FixedRange != null && other.FixedRange != null &&
                    FixedRange.Equals(other.FixedRange)
                ) && 
                (
                    CheaterType == other.CheaterType &&
                    CheaterType != null && other.CheaterType != null &&
                    CheaterType.Equals(other.CheaterType)
                ) && 
                (
                    TickMode == other.TickMode &&
                    TickMode != null && other.TickMode != null &&
                    TickMode.Equals(other.TickMode)
                ) && 
                (
                    NTicks == other.NTicks &&
                    NTicks != null && other.NTicks != null &&
                    NTicks.Equals(other.NTicks)
                ) && 
                (
                    Equals(TickVals, other.TickVals) ||
                    TickVals != null && other.TickVals != null &&
                    TickVals.SequenceEqual(other.TickVals)
                ) &&
                (
                    Equals(TickText, other.TickText) ||
                    TickText != null && other.TickText != null &&
                    TickText.SequenceEqual(other.TickText)
                ) &&
                (
                    ShowTickLabels == other.ShowTickLabels &&
                    ShowTickLabels != null && other.ShowTickLabels != null &&
                    ShowTickLabels.Equals(other.ShowTickLabels)
                ) && 
                (
                    TickFont == other.TickFont &&
                    TickFont != null && other.TickFont != null &&
                    TickFont.Equals(other.TickFont)
                ) && 
                (
                    TickAngle == other.TickAngle &&
                    TickAngle != null && other.TickAngle != null &&
                    TickAngle.Equals(other.TickAngle)
                ) && 
                (
                    TickPrefix == other.TickPrefix &&
                    TickPrefix != null && other.TickPrefix != null &&
                    TickPrefix.Equals(other.TickPrefix)
                ) && 
                (
                    ShowTickPrefix == other.ShowTickPrefix &&
                    ShowTickPrefix != null && other.ShowTickPrefix != null &&
                    ShowTickPrefix.Equals(other.ShowTickPrefix)
                ) && 
                (
                    TickSuffix == other.TickSuffix &&
                    TickSuffix != null && other.TickSuffix != null &&
                    TickSuffix.Equals(other.TickSuffix)
                ) && 
                (
                    ShowTickSuffix == other.ShowTickSuffix &&
                    ShowTickSuffix != null && other.ShowTickSuffix != null &&
                    ShowTickSuffix.Equals(other.ShowTickSuffix)
                ) && 
                (
                    ShowExponent == other.ShowExponent &&
                    ShowExponent != null && other.ShowExponent != null &&
                    ShowExponent.Equals(other.ShowExponent)
                ) && 
                (
                    ExponentFormat == other.ExponentFormat &&
                    ExponentFormat != null && other.ExponentFormat != null &&
                    ExponentFormat.Equals(other.ExponentFormat)
                ) && 
                (
                    SeparateThousands == other.SeparateThousands &&
                    SeparateThousands != null && other.SeparateThousands != null &&
                    SeparateThousands.Equals(other.SeparateThousands)
                ) && 
                (
                    TickFormat == other.TickFormat &&
                    TickFormat != null && other.TickFormat != null &&
                    TickFormat.Equals(other.TickFormat)
                ) && 
                (
                    Equals(TickFormatStops, other.TickFormatStops) ||
                    TickFormatStops != null && other.TickFormatStops != null &&
                    TickFormatStops.SequenceEqual(other.TickFormatStops)
                ) &&
                (
                    CategoryOrder == other.CategoryOrder &&
                    CategoryOrder != null && other.CategoryOrder != null &&
                    CategoryOrder.Equals(other.CategoryOrder)
                ) && 
                (
                    Equals(CategoryArray, other.CategoryArray) ||
                    CategoryArray != null && other.CategoryArray != null &&
                    CategoryArray.SequenceEqual(other.CategoryArray)
                ) &&
                (
                    LabelPadding == other.LabelPadding &&
                    LabelPadding != null && other.LabelPadding != null &&
                    LabelPadding.Equals(other.LabelPadding)
                ) && 
                (
                    LabelPrefix == other.LabelPrefix &&
                    LabelPrefix != null && other.LabelPrefix != null &&
                    LabelPrefix.Equals(other.LabelPrefix)
                ) && 
                (
                    LabelSuffix == other.LabelSuffix &&
                    LabelSuffix != null && other.LabelSuffix != null &&
                    LabelSuffix.Equals(other.LabelSuffix)
                ) && 
                (
                    ShowLine == other.ShowLine &&
                    ShowLine != null && other.ShowLine != null &&
                    ShowLine.Equals(other.ShowLine)
                ) && 
                (
                    LineColor == other.LineColor &&
                    LineColor != null && other.LineColor != null &&
                    LineColor.Equals(other.LineColor)
                ) && 
                (
                    LineWidth == other.LineWidth &&
                    LineWidth != null && other.LineWidth != null &&
                    LineWidth.Equals(other.LineWidth)
                ) && 
                (
                    GridColor == other.GridColor &&
                    GridColor != null && other.GridColor != null &&
                    GridColor.Equals(other.GridColor)
                ) && 
                (
                    GridWidth == other.GridWidth &&
                    GridWidth != null && other.GridWidth != null &&
                    GridWidth.Equals(other.GridWidth)
                ) && 
                (
                    ShowGrid == other.ShowGrid &&
                    ShowGrid != null && other.ShowGrid != null &&
                    ShowGrid.Equals(other.ShowGrid)
                ) && 
                (
                    MinorGridCount == other.MinorGridCount &&
                    MinorGridCount != null && other.MinorGridCount != null &&
                    MinorGridCount.Equals(other.MinorGridCount)
                ) && 
                (
                    MinorGridWidth == other.MinorGridWidth &&
                    MinorGridWidth != null && other.MinorGridWidth != null &&
                    MinorGridWidth.Equals(other.MinorGridWidth)
                ) && 
                (
                    MinorGridColor == other.MinorGridColor &&
                    MinorGridColor != null && other.MinorGridColor != null &&
                    MinorGridColor.Equals(other.MinorGridColor)
                ) && 
                (
                    StartLine == other.StartLine &&
                    StartLine != null && other.StartLine != null &&
                    StartLine.Equals(other.StartLine)
                ) && 
                (
                    StartLineColor == other.StartLineColor &&
                    StartLineColor != null && other.StartLineColor != null &&
                    StartLineColor.Equals(other.StartLineColor)
                ) && 
                (
                    StartLineWidth == other.StartLineWidth &&
                    StartLineWidth != null && other.StartLineWidth != null &&
                    StartLineWidth.Equals(other.StartLineWidth)
                ) && 
                (
                    EndLine == other.EndLine &&
                    EndLine != null && other.EndLine != null &&
                    EndLine.Equals(other.EndLine)
                ) && 
                (
                    EndlineWidth == other.EndlineWidth &&
                    EndlineWidth != null && other.EndlineWidth != null &&
                    EndlineWidth.Equals(other.EndlineWidth)
                ) && 
                (
                    EndlineColor == other.EndlineColor &&
                    EndlineColor != null && other.EndlineColor != null &&
                    EndlineColor.Equals(other.EndlineColor)
                ) && 
                (
                    Tick0 == other.Tick0 &&
                    Tick0 != null && other.Tick0 != null &&
                    Tick0.Equals(other.Tick0)
                ) && 
                (
                    DTick == other.DTick &&
                    DTick != null && other.DTick != null &&
                    DTick.Equals(other.DTick)
                ) && 
                (
                    ArrayTick0 == other.ArrayTick0 &&
                    ArrayTick0 != null && other.ArrayTick0 != null &&
                    ArrayTick0.Equals(other.ArrayTick0)
                ) && 
                (
                    ArrayDTick == other.ArrayDTick &&
                    ArrayDTick != null && other.ArrayDTick != null &&
                    ArrayDTick.Equals(other.ArrayDTick)
                ) && 
                (
                    TickValsSrc == other.TickValsSrc &&
                    TickValsSrc != null && other.TickValsSrc != null &&
                    TickValsSrc.Equals(other.TickValsSrc)
                ) && 
                (
                    TickTextSrc == other.TickTextSrc &&
                    TickTextSrc != null && other.TickTextSrc != null &&
                    TickTextSrc.Equals(other.TickTextSrc)
                ) && 
                (
                    CategoryArraySrc == other.CategoryArraySrc &&
                    CategoryArraySrc != null && other.CategoryArraySrc != null &&
                    CategoryArraySrc.Equals(other.CategoryArraySrc)
                );
        }

        
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (Color != null) hashCode = hashCode * 59 + Color.GetHashCode();
                if (Smoothing != null) hashCode = hashCode * 59 + Smoothing.GetHashCode();
                if (Title != null) hashCode = hashCode * 59 + Title.GetHashCode();
                if (Type != null) hashCode = hashCode * 59 + Type.GetHashCode();
                if (AutoRange != null) hashCode = hashCode * 59 + AutoRange.GetHashCode();
                if (RangeMode != null) hashCode = hashCode * 59 + RangeMode.GetHashCode();
                if (Range != null) hashCode = hashCode * 59 + Range.GetHashCode();
                if (FixedRange != null) hashCode = hashCode * 59 + FixedRange.GetHashCode();
                if (CheaterType != null) hashCode = hashCode * 59 + CheaterType.GetHashCode();
                if (TickMode != null) hashCode = hashCode * 59 + TickMode.GetHashCode();
                if (NTicks != null) hashCode = hashCode * 59 + NTicks.GetHashCode();
                if (TickVals != null) hashCode = hashCode * 59 + TickVals.GetHashCode();
                if (TickText != null) hashCode = hashCode * 59 + TickText.GetHashCode();
                if (ShowTickLabels != null) hashCode = hashCode * 59 + ShowTickLabels.GetHashCode();
                if (TickFont != null) hashCode = hashCode * 59 + TickFont.GetHashCode();
                if (TickAngle != null) hashCode = hashCode * 59 + TickAngle.GetHashCode();
                if (TickPrefix != null) hashCode = hashCode * 59 + TickPrefix.GetHashCode();
                if (ShowTickPrefix != null) hashCode = hashCode * 59 + ShowTickPrefix.GetHashCode();
                if (TickSuffix != null) hashCode = hashCode * 59 + TickSuffix.GetHashCode();
                if (ShowTickSuffix != null) hashCode = hashCode * 59 + ShowTickSuffix.GetHashCode();
                if (ShowExponent != null) hashCode = hashCode * 59 + ShowExponent.GetHashCode();
                if (ExponentFormat != null) hashCode = hashCode * 59 + ExponentFormat.GetHashCode();
                if (SeparateThousands != null) hashCode = hashCode * 59 + SeparateThousands.GetHashCode();
                if (TickFormat != null) hashCode = hashCode * 59 + TickFormat.GetHashCode();
                if (TickFormatStops != null) hashCode = hashCode * 59 + TickFormatStops.GetHashCode();
                if (CategoryOrder != null) hashCode = hashCode * 59 + CategoryOrder.GetHashCode();
                if (CategoryArray != null) hashCode = hashCode * 59 + CategoryArray.GetHashCode();
                if (LabelPadding != null) hashCode = hashCode * 59 + LabelPadding.GetHashCode();
                if (LabelPrefix != null) hashCode = hashCode * 59 + LabelPrefix.GetHashCode();
                if (LabelSuffix != null) hashCode = hashCode * 59 + LabelSuffix.GetHashCode();
                if (ShowLine != null) hashCode = hashCode * 59 + ShowLine.GetHashCode();
                if (LineColor != null) hashCode = hashCode * 59 + LineColor.GetHashCode();
                if (LineWidth != null) hashCode = hashCode * 59 + LineWidth.GetHashCode();
                if (GridColor != null) hashCode = hashCode * 59 + GridColor.GetHashCode();
                if (GridWidth != null) hashCode = hashCode * 59 + GridWidth.GetHashCode();
                if (ShowGrid != null) hashCode = hashCode * 59 + ShowGrid.GetHashCode();
                if (MinorGridCount != null) hashCode = hashCode * 59 + MinorGridCount.GetHashCode();
                if (MinorGridWidth != null) hashCode = hashCode * 59 + MinorGridWidth.GetHashCode();
                if (MinorGridColor != null) hashCode = hashCode * 59 + MinorGridColor.GetHashCode();
                if (StartLine != null) hashCode = hashCode * 59 + StartLine.GetHashCode();
                if (StartLineColor != null) hashCode = hashCode * 59 + StartLineColor.GetHashCode();
                if (StartLineWidth != null) hashCode = hashCode * 59 + StartLineWidth.GetHashCode();
                if (EndLine != null) hashCode = hashCode * 59 + EndLine.GetHashCode();
                if (EndlineWidth != null) hashCode = hashCode * 59 + EndlineWidth.GetHashCode();
                if (EndlineColor != null) hashCode = hashCode * 59 + EndlineColor.GetHashCode();
                if (Tick0 != null) hashCode = hashCode * 59 + Tick0.GetHashCode();
                if (DTick != null) hashCode = hashCode * 59 + DTick.GetHashCode();
                if (ArrayTick0 != null) hashCode = hashCode * 59 + ArrayTick0.GetHashCode();
                if (ArrayDTick != null) hashCode = hashCode * 59 + ArrayDTick.GetHashCode();
                if (TickValsSrc != null) hashCode = hashCode * 59 + TickValsSrc.GetHashCode();
                if (TickTextSrc != null) hashCode = hashCode * 59 + TickTextSrc.GetHashCode();
                if (CategoryArraySrc != null) hashCode = hashCode * 59 + CategoryArraySrc.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left AAxis and the right AAxis.
        /// </summary>
        /// <param name="left">Left AAxis.</param>
        /// <param name="right">Right AAxis.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (AAxis left, AAxis right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left AAxis and the right AAxis.
        /// </summary>
        /// <param name="left">Left AAxis.</param>
        /// <param name="right">Right AAxis.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (AAxis left, AAxis right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>AAxis</returns>
        public AAxis DeepClone()
        {
            using MemoryStream ms = new();
            
            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;
            return JsonSerializer.DeserializeAsync<AAxis>(ms).Result;
        }
    }
}