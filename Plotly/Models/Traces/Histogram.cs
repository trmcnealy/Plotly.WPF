using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Traces.Histograms;

using Stream = Plotly.Models.Traces.Histograms.Stream;

namespace Plotly.Models.Traces
{
    /// <summary>
    ///     The Histogram class.
    ///     Implements the <see cref="ITrace" />.
    /// </summary>
    [JsonConverter(typeof(PlotlyConverter))]
    [Serializable]
    public class Histogram : ITrace, IEquatable<Histogram>
    {
        /// <inheritdoc/>
        [JsonPropertyName(@"type")]
        public TraceTypeEnum? Type { get; } = TraceTypeEnum.Histogram;

        /// <summary>
        ///     Determines whether or not this trace is visible. If <c>legendonly</c>, the
        ///     trace is not drawn, but can appear as a legend item (provided that the legend
        ///     itself is visible).
        /// </summary>
        [JsonPropertyName(@"visible")]
        public VisibleEnum? Visible { get; set; }

        /// <summary>
        ///     Determines whether or not an item corresponding to this trace is shown in
        ///     the legend.
        /// </summary>
        [JsonPropertyName(@"showlegend")]
        public bool? ShowLegend { get; set; }

        /// <summary>
        ///     Sets the legend group for this trace. Traces part of the same legend group
        ///     hide/show at the same time when toggling legend items.
        /// </summary>
        [JsonPropertyName(@"legendgroup")]
        public string? LegendGroup { get; set; }

        /// <summary>
        ///     Sets the opacity of the trace.
        /// </summary>
        [JsonPropertyName(@"opacity")]
        public JsNumber? Opacity { get; set; }

        /// <summary>
        ///     Sets the trace name. The trace name appear as the legend item and on hover.
        /// </summary>
        [JsonPropertyName(@"name")]
        public string? Name { get; set; }

        /// <summary>
        ///     Assign an id to this trace, Use this to provide object constancy between
        ///     traces during animations and transitions.
        /// </summary>
        [JsonPropertyName(@"uid")]
        public string? UId { get; set; }

        /// <summary>
        ///     Assigns id labels to each datum. These ids for object constancy of data
        ///     points during animation. Should be an array of strings, not numbers or any
        ///     other type.
        /// </summary>
        [JsonPropertyName(@"ids")]
        public List<object>? Ids { get; set; }

        /// <summary>
        ///     Assigns extra data each datum. This may be useful when listening to hover,
        ///     click and selection events. Note that, <c>scatter</c> traces also appends
        ///     customdata items in the markers DOM elements
        /// </summary>
        [JsonPropertyName(@"customdata")]
        public List<object>? CustomData { get; set; }

        /// <summary>
        ///     Assigns extra meta information associated with this trace that can be used
        ///     in various text attributes. Attributes such as trace <c>name</c>, graph,
        ///     axis and colorbar <c>title.text</c>, annotation <c>text</c> <c>rangeselector</c>,
        ///     <c>updatemenues</c> and <c>sliders</c> <c>label</c> text all support <c>meta</c>.
        ///     To access the trace <c>meta</c> values in an attribute in the same trace,
        ///     simply use <c>%{meta[i]}</c> where <c>i</c> is the index or key of the <c>meta</c>
        ///     item in question. To access trace <c>meta</c> in layout attributes, use
        ///     <c>%{data[n[.meta[i]}</c> where <c>i</c> is the index or key of the <c>meta</c>
        ///     and <c>n</c> is the trace index.
        /// </summary>
        [JsonPropertyName(@"meta")]
        public object? Meta { get; set; }

        /// <summary>
        ///     Assigns extra meta information associated with this trace that can be used
        ///     in various text attributes. Attributes such as trace <c>name</c>, graph,
        ///     axis and colorbar <c>title.text</c>, annotation <c>text</c> <c>rangeselector</c>,
        ///     <c>updatemenues</c> and <c>sliders</c> <c>label</c> text all support <c>meta</c>.
        ///     To access the trace <c>meta</c> values in an attribute in the same trace,
        ///     simply use <c>%{meta[i]}</c> where <c>i</c> is the index or key of the <c>meta</c>
        ///     item in question. To access trace <c>meta</c> in layout attributes, use
        ///     <c>%{data[n[.meta[i]}</c> where <c>i</c> is the index or key of the <c>meta</c>
        ///     and <c>n</c> is the trace index.
        /// </summary>
        [JsonPropertyName(@"meta")]
        [Array]
        public List<object>? MetaArray { get; set; }

        /// <summary>
        ///     Array containing integer indices of selected points. Has an effect only
        ///     for traces that support selections. Note that an empty array means an empty
        ///     selection where the <c>unselected</c> are turned on for all points, whereas,
        ///     any other non-array values means no selection all where the <c>selected</c>
        ///     and <c>unselected</c> styles have no effect.
        /// </summary>
        [JsonPropertyName(@"selectedpoints")]
        public object? SelectedPoints { get; set; }

        /// <summary>
        ///     Determines which trace information appear on hover. If <c>none</c> or <c>skip</c>
        ///     are set, no information is displayed upon hovering. But, if <c>none</c>
        ///     is set, click and hover events are still fired.
        /// </summary>
        [JsonPropertyName(@"hoverinfo")]
        public HoverInfoFlag? HoverInfo { get; set; }

        /// <summary>
        ///     Determines which trace information appear on hover. If <c>none</c> or <c>skip</c>
        ///     are set, no information is displayed upon hovering. But, if <c>none</c>
        ///     is set, click and hover events are still fired.
        /// </summary>
        [JsonPropertyName(@"hoverinfo")]
        [Array]
        public List<HoverInfoFlag?>? HoverInfoArray { get; set; }

        /// <summary>
        ///     Gets or sets the HoverLabel.
        /// </summary>
        [JsonPropertyName(@"hoverlabel")]
        public HoverLabel? HoverLabel { get; set; }

        /// <summary>
        ///     Gets or sets the Stream.
        /// </summary>
        [JsonPropertyName(@"stream")]
        public Stream? Stream { get; set; }

        /// <summary>
        ///     Gets or sets the Transforms.
        /// </summary>
        [JsonPropertyName(@"transforms")]
        public List<ITransform>? Transforms { get; set; }

        /// <summary>
        ///     Controls persistence of some user-driven changes to the trace: <c>constraintrange</c>
        ///     in <c>parcoords</c> traces, as well as some &#39;editable: true&#39; modifications
        ///     such as <c>name</c> and <c>colorbar.title</c>. Defaults to <c>layout.uirevision</c>.
        ///     Note that other user-driven trace attribute changes are controlled by <c>layout</c>
        ///     attributes: <c>trace.visible</c> is controlled by <c>layout.legend.uirevision</c>,
        ///     <c>selectedpoints</c> is controlled by <c>layout.selectionrevision</c>,
        ///     and <c>colorbar.(x|y)</c> (accessible with &#39;config: {editable: true}&#39;)
        ///     is controlled by <c>layout.editrevision</c>. Trace changes are tracked by
        ///     <c>uid</c>, which only falls back on trace index if no <c>uid</c> is provided.
        ///     So if your app can add/remove traces before the end of the <c>data</c> array,
        ///     such that the same trace has a different index, you can still preserve user-driven
        ///     changes if you give each trace a <c>uid</c> that stays with it as it moves.
        /// </summary>
        [JsonPropertyName(@"uirevision")]
        public object? UiRevision { get; set; }

        /// <summary>
        ///     Sets the sample data to be binned on the x axis.
        /// </summary>
        [JsonPropertyName(@"x")]
        public List<object>? X { get; set; }

        /// <summary>
        ///     Sets the sample data to be binned on the y axis.
        /// </summary>
        [JsonPropertyName(@"y")]
        public List<object>? Y { get; set; }

        /// <summary>
        ///     Sets hover text elements associated with each bar. If a single string, the
        ///     same string appears over all bars. If an array of string, the items are
        ///     mapped in order to the this trace&#39;s coordinates.
        /// </summary>
        [JsonPropertyName(@"text")]
        public string? Text { get; set; }

        /// <summary>
        ///     Sets hover text elements associated with each bar. If a single string, the
        ///     same string appears over all bars. If an array of string, the items are
        ///     mapped in order to the this trace&#39;s coordinates.
        /// </summary>
        [JsonPropertyName(@"text")]
        [Array]
        public List<string>? TextArray { get; set; }

        /// <summary>
        ///     Same as <c>text</c>.
        /// </summary>
        [JsonPropertyName(@"hovertext")]
        public string? HoverText { get; set; }

        /// <summary>
        ///     Same as <c>text</c>.
        /// </summary>
        [JsonPropertyName(@"hovertext")]
        [Array]
        public List<string>? HoverTextArray { get; set; }

        /// <summary>
        ///     Sets the orientation of the bars. With <c>v</c> (<c>h</c>), the value of
        ///     the each bar spans along the vertical (horizontal).
        /// </summary>
        [JsonPropertyName(@"orientation")]
        public OrientationEnum? Orientation { get; set; }

        /// <summary>
        ///     Specifies the binning function used for this histogram trace. If <c>count</c>,
        ///     the histogram values are computed by counting the number of values lying
        ///     inside each bin. If <c>sum</c>, <c>avg</c>, <c>min</c>, <c>max</c>, the
        ///     histogram values are computed using the sum, the average, the minimum or
        ///     the maximum of the values lying inside each bin respectively.
        /// </summary>
        [JsonPropertyName(@"histfunc")]
        public HistFuncEnum? HistFunc { get; set; }

        /// <summary>
        ///     Specifies the type of normalization used for this histogram trace. If *&#39;,
        ///     the span of each bar corresponds to the number of occurrences (i.e. the
        ///     number of data points lying inside the bins). If <c>percent</c> / <c>probability</c>,
        ///     the span of each bar corresponds to the percentage / fraction of occurrences
        ///     with respect to the total number of sample points (here, the sum of all
        ///     bin HEIGHTS equals 100% / 1). If <c>density</c>, the span of each bar corresponds
        ///     to the number of occurrences in a bin divided by the size of the bin interval
        ///     (here, the sum of all bin AREAS equals the total number of sample points).
        ///     If &#39;probability density*, the area of each bar corresponds to the probability
        ///     that an event will fall into the corresponding bin (here, the sum of all
        ///     bin AREAS equals 1).
        /// </summary>
        [JsonPropertyName(@"histnorm")]
        public HistNormEnum? HistNorm { get; set; }

        /// <summary>
        ///     Gets or sets the Cumulative.
        /// </summary>
        [JsonPropertyName(@"cumulative")]
        public Cumulative? Cumulative { get; set; }

        /// <summary>
        ///     Specifies the maximum number of desired bins. This value will be used in
        ///     an algorithm that will decide the optimal bin size such that the histogram
        ///     best visualizes the distribution of the data. Ignored if <c>xbins.size</c>
        ///     is provided.
        /// </summary>
        [JsonPropertyName(@"nbinsx")]
        public int? NBinsX { get; set; }

        /// <summary>
        ///     Gets or sets the XBins.
        /// </summary>
        [JsonPropertyName(@"xbins")]
        public XBins? XBins { get; set; }

        /// <summary>
        ///     Specifies the maximum number of desired bins. This value will be used in
        ///     an algorithm that will decide the optimal bin size such that the histogram
        ///     best visualizes the distribution of the data. Ignored if <c>ybins.size</c>
        ///     is provided.
        /// </summary>
        [JsonPropertyName(@"nbinsy")]
        public int? NBinsY { get; set; }

        /// <summary>
        ///     Gets or sets the YBins.
        /// </summary>
        [JsonPropertyName(@"ybins")]
        public YBins? YBins { get; set; }

        /// <summary>
        ///     Obsolete: since v1.42 each bin attribute is auto-determined separately and
        ///     <c>autobinx</c> is not needed. However, we accept &#39;autobinx: true&#39;
        ///     or <c>false</c> and will update <c>xbins</c> accordingly before deleting
        ///     <c>autobinx</c> from the trace.
        /// </summary>
        [JsonPropertyName(@"autobinx")]
        public bool? AutoBinX { get; set; }

        /// <summary>
        ///     Obsolete: since v1.42 each bin attribute is auto-determined separately and
        ///     <c>autobiny</c> is not needed. However, we accept &#39;autobiny: true&#39;
        ///     or <c>false</c> and will update <c>ybins</c> accordingly before deleting
        ///     <c>autobiny</c> from the trace.
        /// </summary>
        [JsonPropertyName(@"autobiny")]
        public bool? AutoBinY { get; set; }

        /// <summary>
        ///     Set a group of histogram traces which will have compatible bin settings.
        ///     Note that traces on the same subplot and with the same <c>orientation</c>
        ///     under <c>barmode</c> <c>stack</c>, <c>relative</c> and <c>group</c> are
        ///     forced into the same bingroup, Using <c>bingroup</c>, traces under <c>barmode</c>
        ///     <c>overlay</c> and on different axes (of the same axis type) can have compatible
        ///     bin settings. Note that histogram and histogram2d* trace can share the same
        ///     <c>bingroup</c>
        /// </summary>
        [JsonPropertyName(@"bingroup")]
        public string? BinGroup { get; set; }

        /// <summary>
        ///     Template string used for rendering the information that appear on hover
        ///     box. Note that this will override <c>hoverinfo</c>. Variables are inserted
        ///     using %{variable}, for example &quot;y: %{y}&quot;. Numbers are formatted
        ///     using d3-format&#39;s syntax %{variable:d3-format}, for example &quot;Price:
        ///     %{y:$.2f}&quot;. https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        ///     for details on the formatting syntax. Dates are formatted using d3-time-format&#39;s
        ///     syntax %{variable|d3-time-format}, for example &quot;Day: %{2019-01-01|%A}&quot;.
        ///     https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format
        ///     for details on the date formatting syntax. The variables available in <c>hovertemplate</c>
        ///     are the ones emitted as event data described at this link https://plotly.com/javascript/plotlyjs-events/#event-data.
        ///     Additionally, every attributes that can be specified per-point (the ones
        ///     that are &#39;arrayOk: true&#39;) are available. variable <c>binNumber</c>
        ///     Anything contained in tag <c>&lt;extra&gt;</c> is displayed in the secondary
        ///     box, for example <c>&lt;extra&gt;{fullData.name}&lt;/extra&gt;</c>. To hide
        ///     the secondary box completely, use an empty tag <c>&lt;extra&gt;&lt;/extra&gt;</c>.
        /// </summary>
        [JsonPropertyName(@"hovertemplate")]
        public string? HoverTemplate { get; set; }

        /// <summary>
        ///     Template string used for rendering the information that appear on hover
        ///     box. Note that this will override <c>hoverinfo</c>. Variables are inserted
        ///     using %{variable}, for example &quot;y: %{y}&quot;. Numbers are formatted
        ///     using d3-format&#39;s syntax %{variable:d3-format}, for example &quot;Price:
        ///     %{y:$.2f}&quot;. https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        ///     for details on the formatting syntax. Dates are formatted using d3-time-format&#39;s
        ///     syntax %{variable|d3-time-format}, for example &quot;Day: %{2019-01-01|%A}&quot;.
        ///     https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format
        ///     for details on the date formatting syntax. The variables available in <c>hovertemplate</c>
        ///     are the ones emitted as event data described at this link https://plotly.com/javascript/plotlyjs-events/#event-data.
        ///     Additionally, every attributes that can be specified per-point (the ones
        ///     that are &#39;arrayOk: true&#39;) are available. variable <c>binNumber</c>
        ///     Anything contained in tag <c>&lt;extra&gt;</c> is displayed in the secondary
        ///     box, for example <c>&lt;extra&gt;{fullData.name}&lt;/extra&gt;</c>. To hide
        ///     the secondary box completely, use an empty tag <c>&lt;extra&gt;&lt;/extra&gt;</c>.
        /// </summary>
        [JsonPropertyName(@"hovertemplate")]
        [Array]
        public List<string>? HoverTemplateArray { get; set; }

        /// <summary>
        ///     Gets or sets the Marker.
        /// </summary>
        [JsonPropertyName(@"marker")]
        public Marker? Marker { get; set; }

        /// <summary>
        ///     Set several traces linked to the same position axis or matching axes to
        ///     the same offsetgroup where bars of the same position coordinate will line
        ///     up.
        /// </summary>
        [JsonPropertyName(@"offsetgroup")]
        public string? OffsetGroup { get; set; }

        /// <summary>
        ///     Set several traces linked to the same position axis or matching axes to
        ///     the same alignmentgroup. This controls whether bars compute their positional
        ///     range dependently or independently.
        /// </summary>
        [JsonPropertyName(@"alignmentgroup")]
        public string? AlignmentGroup { get; set; }

        /// <summary>
        ///     Gets or sets the Selected.
        /// </summary>
        [JsonPropertyName(@"selected")]
        public Selected? Selected { get; set; }

        /// <summary>
        ///     Gets or sets the Unselected.
        /// </summary>
        [JsonPropertyName(@"unselected")]
        public Unselected? Unselected { get; set; }

        /// <summary>
        ///     Gets or sets the ErrorX.
        /// </summary>
        [JsonPropertyName(@"error_x")]
        public ErrorX? ErrorX { get; set; }

        /// <summary>
        ///     Gets or sets the ErrorY.
        /// </summary>
        [JsonPropertyName(@"error_y")]
        public ErrorY? ErrorY { get; set; }

        /// <summary>
        ///     Sets the calendar system to use with <c>x</c> date data.
        /// </summary>
        [JsonPropertyName(@"xcalendar")]
        public XCalendarEnum? XCalendar { get; set; }

        /// <summary>
        ///     Sets the calendar system to use with <c>y</c> date data.
        /// </summary>
        [JsonPropertyName(@"ycalendar")]
        public YCalendarEnum? YCalendar { get; set; }

        /// <summary>
        ///     Sets a reference between this trace&#39;s x coordinates and a 2D cartesian
        ///     x axis. If <c>x</c> (the default value), the x coordinates refer to <c>layout.xaxis</c>.
        ///     If <c>x2</c>, the x coordinates refer to <c>layout.xaxis2</c>, and so on.
        /// </summary>
        [JsonPropertyName(@"xaxis")]
        public string? XAxis { get; set; }

        /// <summary>
        ///     Sets a reference between this trace&#39;s y coordinates and a 2D cartesian
        ///     y axis. If <c>y</c> (the default value), the y coordinates refer to <c>layout.yaxis</c>.
        ///     If <c>y2</c>, the y coordinates refer to <c>layout.yaxis2</c>, and so on.
        /// </summary>
        [JsonPropertyName(@"yaxis")]
        public string? YAxis { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  ids .
        /// </summary>
        [JsonPropertyName(@"idssrc")]
        public string? IdsSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  customdata .
        /// </summary>
        [JsonPropertyName(@"customdatasrc")]
        public string? CustomDataSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  meta .
        /// </summary>
        [JsonPropertyName(@"metasrc")]
        public string? MetaSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  hoverinfo .
        /// </summary>
        [JsonPropertyName(@"hoverinfosrc")]
        public string? HoverInfoSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  x .
        /// </summary>
        [JsonPropertyName(@"xsrc")]
        public string? XSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  y .
        /// </summary>
        [JsonPropertyName(@"ysrc")]
        public string? YSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  text .
        /// </summary>
        [JsonPropertyName(@"textsrc")]
        public string? TextSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  hovertext .
        /// </summary>
        [JsonPropertyName(@"hovertextsrc")]
        public string? HoverTextSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  hovertemplate .
        /// </summary>
        [JsonPropertyName(@"hovertemplatesrc")]
        public string? HoverTemplateSrc { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is Histogram other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] Histogram other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (Type        == other.Type        && Type        != null && other.Type        != null && Type.Equals(other.Type))                                              &&
                   (Visible     == other.Visible     && Visible     != null && other.Visible     != null && Visible.Equals(other.Visible))                                        &&
                   (ShowLegend  == other.ShowLegend  && ShowLegend  != null && other.ShowLegend  != null && ShowLegend.Equals(other.ShowLegend))                                  &&
                   (LegendGroup == other.LegendGroup && LegendGroup != null && other.LegendGroup != null && LegendGroup.Equals(other.LegendGroup))                                &&
                   (Opacity     == other.Opacity     && Opacity     != null && other.Opacity     != null && Opacity.Equals(other.Opacity))                                        &&
                   (Name        == other.Name        && Name        != null && other.Name        != null && Name.Equals(other.Name))                                              &&
                   (UId         == other.UId         && UId         != null && other.UId         != null && UId.Equals(other.UId))                                                &&
                   (Equals(Ids,        other.Ids)        || Ids        != null && other.Ids        != null && Ids.SequenceEqual(other.Ids))                                       &&
                   (Equals(CustomData, other.CustomData) || CustomData != null && other.CustomData != null && CustomData.SequenceEqual(other.CustomData))                         &&
                   (Meta == other.Meta && Meta != null && other.Meta != null && Meta.Equals(other.Meta))                                                                          &&
                   (Equals(MetaArray, other.MetaArray) || MetaArray != null && other.MetaArray != null && MetaArray.SequenceEqual(other.MetaArray))                               &&
                   (SelectedPoints == other.SelectedPoints && SelectedPoints != null && other.SelectedPoints != null && SelectedPoints.Equals(other.SelectedPoints))              &&
                   (HoverInfo      == other.HoverInfo      && HoverInfo      != null && other.HoverInfo      != null && HoverInfo.Equals(other.HoverInfo))                        &&
                   (Equals(HoverInfoArray, other.HoverInfoArray) || HoverInfoArray != null && other.HoverInfoArray != null && HoverInfoArray.SequenceEqual(other.HoverInfoArray)) &&
                   (HoverLabel == other.HoverLabel && HoverLabel != null && other.HoverLabel != null && HoverLabel.Equals(other.HoverLabel))                                      &&
                   (Stream     == other.Stream     && Stream     != null && other.Stream     != null && Stream.Equals(other.Stream))                                              &&
                   (Equals(Transforms, other.Transforms) || Transforms != null && other.Transforms != null && Transforms.SequenceEqual(other.Transforms))                         &&
                   (UiRevision == other.UiRevision && UiRevision != null && other.UiRevision != null && UiRevision.Equals(other.UiRevision))                                      &&
                   (Equals(X, other.X) || X != null && other.X != null && X.SequenceEqual(other.X))                                                                               &&
                   (Equals(Y, other.Y) || Y != null && other.Y != null && Y.SequenceEqual(other.Y))                                                                               &&
                   (Text == other.Text && Text != null && other.Text != null && Text.Equals(other.Text))                                                                          &&
                   (Equals(TextArray, other.TextArray) || TextArray != null && other.TextArray != null && TextArray.SequenceEqual(other.TextArray))                               &&
                   (HoverText == other.HoverText && HoverText != null && other.HoverText != null && HoverText.Equals(other.HoverText))                                            &&
                   (Equals(HoverTextArray, other.HoverTextArray) || HoverTextArray != null && other.HoverTextArray != null && HoverTextArray.SequenceEqual(other.HoverTextArray)) &&
                   (Orientation   == other.Orientation   && Orientation   != null && other.Orientation   != null && Orientation.Equals(other.Orientation))                        &&
                   (HistFunc      == other.HistFunc      && HistFunc      != null && other.HistFunc      != null && HistFunc.Equals(other.HistFunc))                              &&
                   (HistNorm      == other.HistNorm      && HistNorm      != null && other.HistNorm      != null && HistNorm.Equals(other.HistNorm))                              &&
                   (Cumulative    == other.Cumulative    && Cumulative    != null && other.Cumulative    != null && Cumulative.Equals(other.Cumulative))                          &&
                   (NBinsX        == other.NBinsX        && NBinsX        != null && other.NBinsX        != null && NBinsX.Equals(other.NBinsX))                                  &&
                   (XBins         == other.XBins         && XBins         != null && other.XBins         != null && XBins.Equals(other.XBins))                                    &&
                   (NBinsY        == other.NBinsY        && NBinsY        != null && other.NBinsY        != null && NBinsY.Equals(other.NBinsY))                                  &&
                   (YBins         == other.YBins         && YBins         != null && other.YBins         != null && YBins.Equals(other.YBins))                                    &&
                   (AutoBinX      == other.AutoBinX      && AutoBinX      != null && other.AutoBinX      != null && AutoBinX.Equals(other.AutoBinX))                              &&
                   (AutoBinY      == other.AutoBinY      && AutoBinY      != null && other.AutoBinY      != null && AutoBinY.Equals(other.AutoBinY))                              &&
                   (BinGroup      == other.BinGroup      && BinGroup      != null && other.BinGroup      != null && BinGroup.Equals(other.BinGroup))                              &&
                   (HoverTemplate == other.HoverTemplate && HoverTemplate != null && other.HoverTemplate != null && HoverTemplate.Equals(other.HoverTemplate))                    &&
                   (Equals(HoverTemplateArray, other.HoverTemplateArray) ||
                    HoverTemplateArray != null && other.HoverTemplateArray != null && HoverTemplateArray.SequenceEqual(other.HoverTemplateArray))                            &&
                   (Marker           == other.Marker           && Marker           != null && other.Marker           != null && Marker.Equals(other.Marker))                 &&
                   (OffsetGroup      == other.OffsetGroup      && OffsetGroup      != null && other.OffsetGroup      != null && OffsetGroup.Equals(other.OffsetGroup))       &&
                   (AlignmentGroup   == other.AlignmentGroup   && AlignmentGroup   != null && other.AlignmentGroup   != null && AlignmentGroup.Equals(other.AlignmentGroup)) &&
                   (Selected         == other.Selected         && Selected         != null && other.Selected         != null && Selected.Equals(other.Selected))             &&
                   (Unselected       == other.Unselected       && Unselected       != null && other.Unselected       != null && Unselected.Equals(other.Unselected))         &&
                   (ErrorX           == other.ErrorX           && ErrorX           != null && other.ErrorX           != null && ErrorX.Equals(other.ErrorX))                 &&
                   (ErrorY           == other.ErrorY           && ErrorY           != null && other.ErrorY           != null && ErrorY.Equals(other.ErrorY))                 &&
                   (XCalendar        == other.XCalendar        && XCalendar        != null && other.XCalendar        != null && XCalendar.Equals(other.XCalendar))           &&
                   (YCalendar        == other.YCalendar        && YCalendar        != null && other.YCalendar        != null && YCalendar.Equals(other.YCalendar))           &&
                   (XAxis            == other.XAxis            && XAxis            != null && other.XAxis            != null && XAxis.Equals(other.XAxis))                   &&
                   (YAxis            == other.YAxis            && YAxis            != null && other.YAxis            != null && YAxis.Equals(other.YAxis))                   &&
                   (IdsSrc           == other.IdsSrc           && IdsSrc           != null && other.IdsSrc           != null && IdsSrc.Equals(other.IdsSrc))                 &&
                   (CustomDataSrc    == other.CustomDataSrc    && CustomDataSrc    != null && other.CustomDataSrc    != null && CustomDataSrc.Equals(other.CustomDataSrc))   &&
                   (MetaSrc          == other.MetaSrc          && MetaSrc          != null && other.MetaSrc          != null && MetaSrc.Equals(other.MetaSrc))               &&
                   (HoverInfoSrc     == other.HoverInfoSrc     && HoverInfoSrc     != null && other.HoverInfoSrc     != null && HoverInfoSrc.Equals(other.HoverInfoSrc))     &&
                   (XSrc             == other.XSrc             && XSrc             != null && other.XSrc             != null && XSrc.Equals(other.XSrc))                     &&
                   (YSrc             == other.YSrc             && YSrc             != null && other.YSrc             != null && YSrc.Equals(other.YSrc))                     &&
                   (TextSrc          == other.TextSrc          && TextSrc          != null && other.TextSrc          != null && TextSrc.Equals(other.TextSrc))               &&
                   (HoverTextSrc     == other.HoverTextSrc     && HoverTextSrc     != null && other.HoverTextSrc     != null && HoverTextSrc.Equals(other.HoverTextSrc))     &&
                   (HoverTemplateSrc == other.HoverTemplateSrc && HoverTemplateSrc != null && other.HoverTemplateSrc != null && HoverTemplateSrc.Equals(other.HoverTemplateSrc));
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;

                if(Type != null)
                    hashCode = hashCode * 59 + Type.GetHashCode();

                if(Visible != null)
                    hashCode = hashCode * 59 + Visible.GetHashCode();

                if(ShowLegend != null)
                    hashCode = hashCode * 59 + ShowLegend.GetHashCode();

                if(LegendGroup != null)
                    hashCode = hashCode * 59 + LegendGroup.GetHashCode();

                if(Opacity != null)
                    hashCode = hashCode * 59 + Opacity.GetHashCode();

                if(Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();

                if(UId != null)
                    hashCode = hashCode * 59 + UId.GetHashCode();

                if(Ids != null)
                    hashCode = hashCode * 59 + Ids.GetHashCode();

                if(CustomData != null)
                    hashCode = hashCode * 59 + CustomData.GetHashCode();

                if(Meta != null)
                    hashCode = hashCode * 59 + Meta.GetHashCode();

                if(MetaArray != null)
                    hashCode = hashCode * 59 + MetaArray.GetHashCode();

                if(SelectedPoints != null)
                    hashCode = hashCode * 59 + SelectedPoints.GetHashCode();

                if(HoverInfo != null)
                    hashCode = hashCode * 59 + HoverInfo.GetHashCode();

                if(HoverInfoArray != null)
                    hashCode = hashCode * 59 + HoverInfoArray.GetHashCode();

                if(HoverLabel != null)
                    hashCode = hashCode * 59 + HoverLabel.GetHashCode();

                if(Stream != null)
                    hashCode = hashCode * 59 + Stream.GetHashCode();

                if(Transforms != null)
                    hashCode = hashCode * 59 + Transforms.GetHashCode();

                if(UiRevision != null)
                    hashCode = hashCode * 59 + UiRevision.GetHashCode();

                if(X != null)
                    hashCode = hashCode * 59 + X.GetHashCode();

                if(Y != null)
                    hashCode = hashCode * 59 + Y.GetHashCode();

                if(Text != null)
                    hashCode = hashCode * 59 + Text.GetHashCode();

                if(TextArray != null)
                    hashCode = hashCode * 59 + TextArray.GetHashCode();

                if(HoverText != null)
                    hashCode = hashCode * 59 + HoverText.GetHashCode();

                if(HoverTextArray != null)
                    hashCode = hashCode * 59 + HoverTextArray.GetHashCode();

                if(Orientation != null)
                    hashCode = hashCode * 59 + Orientation.GetHashCode();

                if(HistFunc != null)
                    hashCode = hashCode * 59 + HistFunc.GetHashCode();

                if(HistNorm != null)
                    hashCode = hashCode * 59 + HistNorm.GetHashCode();

                if(Cumulative != null)
                    hashCode = hashCode * 59 + Cumulative.GetHashCode();

                if(NBinsX != null)
                    hashCode = hashCode * 59 + NBinsX.GetHashCode();

                if(XBins != null)
                    hashCode = hashCode * 59 + XBins.GetHashCode();

                if(NBinsY != null)
                    hashCode = hashCode * 59 + NBinsY.GetHashCode();

                if(YBins != null)
                    hashCode = hashCode * 59 + YBins.GetHashCode();

                if(AutoBinX != null)
                    hashCode = hashCode * 59 + AutoBinX.GetHashCode();

                if(AutoBinY != null)
                    hashCode = hashCode * 59 + AutoBinY.GetHashCode();

                if(BinGroup != null)
                    hashCode = hashCode * 59 + BinGroup.GetHashCode();

                if(HoverTemplate != null)
                    hashCode = hashCode * 59 + HoverTemplate.GetHashCode();

                if(HoverTemplateArray != null)
                    hashCode = hashCode * 59 + HoverTemplateArray.GetHashCode();

                if(Marker != null)
                    hashCode = hashCode * 59 + Marker.GetHashCode();

                if(OffsetGroup != null)
                    hashCode = hashCode * 59 + OffsetGroup.GetHashCode();

                if(AlignmentGroup != null)
                    hashCode = hashCode * 59 + AlignmentGroup.GetHashCode();

                if(Selected != null)
                    hashCode = hashCode * 59 + Selected.GetHashCode();

                if(Unselected != null)
                    hashCode = hashCode * 59 + Unselected.GetHashCode();

                if(ErrorX != null)
                    hashCode = hashCode * 59 + ErrorX.GetHashCode();

                if(ErrorY != null)
                    hashCode = hashCode * 59 + ErrorY.GetHashCode();

                if(XCalendar != null)
                    hashCode = hashCode * 59 + XCalendar.GetHashCode();

                if(YCalendar != null)
                    hashCode = hashCode * 59 + YCalendar.GetHashCode();

                if(XAxis != null)
                    hashCode = hashCode * 59 + XAxis.GetHashCode();

                if(YAxis != null)
                    hashCode = hashCode * 59 + YAxis.GetHashCode();

                if(IdsSrc != null)
                    hashCode = hashCode * 59 + IdsSrc.GetHashCode();

                if(CustomDataSrc != null)
                    hashCode = hashCode * 59 + CustomDataSrc.GetHashCode();

                if(MetaSrc != null)
                    hashCode = hashCode * 59 + MetaSrc.GetHashCode();

                if(HoverInfoSrc != null)
                    hashCode = hashCode * 59 + HoverInfoSrc.GetHashCode();

                if(XSrc != null)
                    hashCode = hashCode * 59 + XSrc.GetHashCode();

                if(YSrc != null)
                    hashCode = hashCode * 59 + YSrc.GetHashCode();

                if(TextSrc != null)
                    hashCode = hashCode * 59 + TextSrc.GetHashCode();

                if(HoverTextSrc != null)
                    hashCode = hashCode * 59 + HoverTextSrc.GetHashCode();

                if(HoverTemplateSrc != null)
                    hashCode = hashCode * 59 + HoverTemplateSrc.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Histogram and the right Histogram.
        /// </summary>
        /// <param name="left">Left Histogram.</param>
        /// <param name="right">Right Histogram.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(Histogram left,
                                       Histogram right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Histogram and the right Histogram.
        /// </summary>
        /// <param name="left">Left Histogram.</param>
        /// <param name="right">Right Histogram.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(Histogram left,
                                       Histogram right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Histogram</returns>
        public Histogram DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<Histogram>(ms).Result;
        }
    }
}
