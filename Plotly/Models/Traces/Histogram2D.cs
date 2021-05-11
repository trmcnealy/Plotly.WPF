using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Traces.Histogram2Ds;

using Stream = Plotly.Models.Traces.Histogram2Ds.Stream;

namespace Plotly.Models.Traces
{
    /// <summary>
    ///     The Histogram2D class.
    ///     Implements the <see cref="ITrace" />.
    /// </summary>
    [JsonConverter(typeof(PlotlyConverter))]
    [Serializable]
    public class Histogram2D : ITrace, IEquatable<Histogram2D>
    {
        /// <inheritdoc/>
        [JsonPropertyName(@"type")]
        public TraceTypeEnum? Type { get; } = TraceTypeEnum.Histogram2D;

        /// <summary>
        ///     Determines whether or not this trace is visible. If <c>legendonly</c>, the
        ///     trace is not drawn, but can appear as a legend item (provided that the legend
        ///     itself is visible).
        /// </summary>
        [JsonPropertyName(@"visible")]
        public VisibleEnum? Visible { get; set; }

        /// <summary>
        ///     Sets the legend group for this trace. Traces part of the same legend group
        ///     hide/show at the same time when toggling legend items.
        /// </summary>
        [JsonPropertyName(@"legendgroup")]
        public string LegendGroup { get; set; }

        /// <summary>
        ///     Sets the opacity of the trace.
        /// </summary>
        [JsonPropertyName(@"opacity")]
        public JsNumber? Opacity { get; set; }

        /// <summary>
        ///     Sets the trace name. The trace name appear as the legend item and on hover.
        /// </summary>
        [JsonPropertyName(@"name")]
        public string Name { get; set; }

        /// <summary>
        ///     Assign an id to this trace, Use this to provide object constancy between
        ///     traces during animations and transitions.
        /// </summary>
        [JsonPropertyName(@"uid")]
        public string UId { get; set; }

        /// <summary>
        ///     Assigns id labels to each datum. These ids for object constancy of data
        ///     points during animation. Should be an array of strings, not numbers or any
        ///     other type.
        /// </summary>
        [JsonPropertyName(@"ids")]
        public List<object> Ids { get; set; }

        /// <summary>
        ///     Assigns extra data each datum. This may be useful when listening to hover,
        ///     click and selection events. Note that, <c>scatter</c> traces also appends
        ///     customdata items in the markers DOM elements
        /// </summary>
        [JsonPropertyName(@"customdata")]
        public List<object> CustomData { get; set; }

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
        public object Meta { get; set; }

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
        public List<object> MetaArray { get; set; }

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
        public List<HoverInfoFlag?> HoverInfoArray { get; set; }

        /// <summary>
        ///     Gets or sets the HoverLabel.
        /// </summary>
        [JsonPropertyName(@"hoverlabel")]
        public HoverLabel HoverLabel { get; set; }

        /// <summary>
        ///     Gets or sets the Stream.
        /// </summary>
        [JsonPropertyName(@"stream")]
        public Stream Stream { get; set; }

        /// <summary>
        ///     Gets or sets the Transforms.
        /// </summary>
        [JsonPropertyName(@"transforms")]
        public List<ITransform> Transforms { get; set; }

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
        public object UiRevision { get; set; }

        /// <summary>
        ///     Sets the sample data to be binned on the x axis.
        /// </summary>
        [JsonPropertyName(@"x")]
        public List<object> X { get; set; }

        /// <summary>
        ///     Sets the sample data to be binned on the y axis.
        /// </summary>
        [JsonPropertyName(@"y")]
        public List<object> Y { get; set; }

        /// <summary>
        ///     Sets the aggregation data.
        /// </summary>
        [JsonPropertyName(@"z")]
        public List<object> Z { get; set; }

        /// <summary>
        ///     Gets or sets the Marker.
        /// </summary>
        [JsonPropertyName(@"marker")]
        public Marker Marker { get; set; }

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
        ///     Specifies the binning function used for this histogram trace. If <c>count</c>,
        ///     the histogram values are computed by counting the number of values lying
        ///     inside each bin. If <c>sum</c>, <c>avg</c>, <c>min</c>, <c>max</c>, the
        ///     histogram values are computed using the sum, the average, the minimum or
        ///     the maximum of the values lying inside each bin respectively.
        /// </summary>
        [JsonPropertyName(@"histfunc")]
        public HistFuncEnum? HistFunc { get; set; }

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
        public XBins XBins { get; set; }

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
        public YBins YBins { get; set; }

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
        ///     Set the <c>xbingroup</c> and <c>ybingroup</c> default prefix For example,
        ///     setting a <c>bingroup</c> of <c>1</c> on two histogram2d traces will make
        ///     them their x-bins and y-bins match separately.
        /// </summary>
        [JsonPropertyName(@"bingroup")]
        public string BinGroup { get; set; }

        /// <summary>
        ///     Set a group of histogram traces which will have compatible x-bin settings.
        ///     Using <c>xbingroup</c>, histogram2d and histogram2dcontour traces  (on axes
        ///     of the same axis type) can have compatible x-bin settings. Note that the
        ///     same <c>xbingroup</c> value can be used to set (1D) histogram <c>bingroup</c>
        /// </summary>
        [JsonPropertyName(@"xbingroup")]
        public string XBinGroup { get; set; }

        /// <summary>
        ///     Set a group of histogram traces which will have compatible y-bin settings.
        ///     Using <c>ybingroup</c>, histogram2d and histogram2dcontour traces  (on axes
        ///     of the same axis type) can have compatible y-bin settings. Note that the
        ///     same <c>ybingroup</c> value can be used to set (1D) histogram <c>bingroup</c>
        /// </summary>
        [JsonPropertyName(@"ybingroup")]
        public string YBinGroup { get; set; }

        /// <summary>
        ///     Sets the horizontal gap (in pixels) between bricks.
        /// </summary>
        [JsonPropertyName(@"xgap")]
        public JsNumber? XGap { get; set; }

        /// <summary>
        ///     Sets the vertical gap (in pixels) between bricks.
        /// </summary>
        [JsonPropertyName(@"ygap")]
        public JsNumber? YGap { get; set; }

        /// <summary>
        ///     Picks a smoothing algorithm use to smooth <c>z</c> data.
        /// </summary>
        [JsonPropertyName(@"zsmooth")]
        public ZSmoothEnum? ZSmooth { get; set; }

        /// <summary>
        ///     Sets the hover text formatting rule using d3 formatting mini-languages which
        ///     are very similar to those in Python. See: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        /// </summary>
        [JsonPropertyName(@"zhoverformat")]
        public string ZHoverFormat { get; set; }

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
        ///     that are &#39;arrayOk: true&#39;) are available. variable <c>z</c> Anything
        ///     contained in tag <c>&lt;extra&gt;</c> is displayed in the secondary box,
        ///     for example <c>&lt;extra&gt;{fullData.name}&lt;/extra&gt;</c>. To hide the
        ///     secondary box completely, use an empty tag <c>&lt;extra&gt;&lt;/extra&gt;</c>.
        /// </summary>
        [JsonPropertyName(@"hovertemplate")]
        public string HoverTemplate { get; set; }

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
        ///     that are &#39;arrayOk: true&#39;) are available. variable <c>z</c> Anything
        ///     contained in tag <c>&lt;extra&gt;</c> is displayed in the secondary box,
        ///     for example <c>&lt;extra&gt;{fullData.name}&lt;/extra&gt;</c>. To hide the
        ///     secondary box completely, use an empty tag <c>&lt;extra&gt;&lt;/extra&gt;</c>.
        /// </summary>
        [JsonPropertyName(@"hovertemplate")]
        [Array]
        public List<string> HoverTemplateArray { get; set; }

        /// <summary>
        ///     Determines whether or not an item corresponding to this trace is shown in
        ///     the legend.
        /// </summary>
        [JsonPropertyName(@"showlegend")]
        public bool? ShowLegend { get; set; }

        /// <summary>
        ///     Determines whether or not the color domain is computed with respect to the
        ///     input data (here in <c>z</c>) or the bounds set in <c>zmin</c> and <c>zmax</c>
        ///      Defaults to <c>false</c> when <c>zmin</c> and <c>zmax</c> are set by the
        ///     user.
        /// </summary>
        [JsonPropertyName(@"zauto")]
        public bool? ZAuto { get; set; }

        /// <summary>
        ///     Sets the lower bound of the color domain. Value should have the same units
        ///     as in <c>z</c> and if set, <c>zmax</c> must be set as well.
        /// </summary>
        [JsonPropertyName(@"zmin")]
        public JsNumber? ZMin { get; set; }

        /// <summary>
        ///     Sets the upper bound of the color domain. Value should have the same units
        ///     as in <c>z</c> and if set, <c>zmin</c> must be set as well.
        /// </summary>
        [JsonPropertyName(@"zmax")]
        public JsNumber? ZMax { get; set; }

        /// <summary>
        ///     Sets the mid-point of the color domain by scaling <c>zmin</c> and/or <c>zmax</c>
        ///     to be equidistant to this point. Value should have the same units as in
        ///     <c>z</c>. Has no effect when <c>zauto</c> is <c>false</c>.
        /// </summary>
        [JsonPropertyName(@"zmid")]
        public JsNumber? ZMid { get; set; }

        /// <summary>
        ///     Sets the colorscale. The colorscale must be an array containing arrays mapping
        ///     a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string.
        ///     At minimum, a mapping for the lowest (0) and highest (1) values are required.
        ///     For example, &#39;[[0, <c>rgb(0,0,255)</c>], [1, <c>rgb(255,0,0)</c>]]&#39;.
        ///     To control the bounds of the colorscale in color space, use<c>zmin</c> and
        ///     <c>zmax</c>. Alternatively, <c>colorscale</c> may be a palette name string
        ///     of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
        /// </summary>
        [JsonPropertyName(@"colorscale")]
        public object ColorScale { get; set; }

        /// <summary>
        ///     Determines whether the colorscale is a default palette (&#39;autocolorscale:
        ///     true&#39;) or the palette determined by <c>colorscale</c>. In case <c>colorscale</c>
        ///     is unspecified or <c>autocolorscale</c> is true, the default  palette will
        ///     be chosen according to whether numbers in the <c>color</c> array are all
        ///     positive, all negative or mixed.
        /// </summary>
        [JsonPropertyName(@"autocolorscale")]
        public bool? AutoColorScale { get; set; }

        /// <summary>
        ///     Reverses the color mapping if true. If true, <c>zmin</c> will correspond
        ///     to the last color in the array and <c>zmax</c> will correspond to the first
        ///     color.
        /// </summary>
        [JsonPropertyName(@"reversescale")]
        public bool? ReverseScale { get; set; }

        /// <summary>
        ///     Determines whether or not a colorbar is displayed for this trace.
        /// </summary>
        [JsonPropertyName(@"showscale")]
        public bool? ShowScale { get; set; }

        /// <summary>
        ///     Gets or sets the ColorBar.
        /// </summary>
        [JsonPropertyName(@"colorbar")]
        public ColorBar ColorBar { get; set; }

        /// <summary>
        ///     Sets a reference to a shared color axis. References to these shared color
        ///     axes are <c>coloraxis</c>, <c>coloraxis2</c>, <c>coloraxis3</c>, etc. Settings
        ///     for these shared color axes are set in the layout, under <c>layout.coloraxis</c>,
        ///     <c>layout.coloraxis2</c>, etc. Note that multiple color scales can be linked
        ///     to the same color axis.
        /// </summary>
        [JsonPropertyName(@"coloraxis")]
        public string ColorAxis { get; set; }

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
        public string XAxis { get; set; }

        /// <summary>
        ///     Sets a reference between this trace&#39;s y coordinates and a 2D cartesian
        ///     y axis. If <c>y</c> (the default value), the y coordinates refer to <c>layout.yaxis</c>.
        ///     If <c>y2</c>, the y coordinates refer to <c>layout.yaxis2</c>, and so on.
        /// </summary>
        [JsonPropertyName(@"yaxis")]
        public string YAxis { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  ids .
        /// </summary>
        [JsonPropertyName(@"idssrc")]
        public string IdsSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  customdata .
        /// </summary>
        [JsonPropertyName(@"customdatasrc")]
        public string CustomDataSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  meta .
        /// </summary>
        [JsonPropertyName(@"metasrc")]
        public string MetaSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  hoverinfo .
        /// </summary>
        [JsonPropertyName(@"hoverinfosrc")]
        public string HoverInfoSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  x .
        /// </summary>
        [JsonPropertyName(@"xsrc")]
        public string XSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  y .
        /// </summary>
        [JsonPropertyName(@"ysrc")]
        public string YSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  z .
        /// </summary>
        [JsonPropertyName(@"zsrc")]
        public string ZSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  hovertemplate .
        /// </summary>
        [JsonPropertyName(@"hovertemplatesrc")]
        public string HoverTemplateSrc { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is Histogram2D other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] Histogram2D other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (Type        == other.Type        && Type        != null && other.Type        != null && Type.Equals(other.Type))                                              &&
                   (Visible     == other.Visible     && Visible     != null && other.Visible     != null && Visible.Equals(other.Visible))                                        &&
                   (LegendGroup == other.LegendGroup && LegendGroup != null && other.LegendGroup != null && LegendGroup.Equals(other.LegendGroup))                                &&
                   (Opacity     == other.Opacity     && Opacity     != null && other.Opacity     != null && Opacity.Equals(other.Opacity))                                        &&
                   (Name        == other.Name        && Name        != null && other.Name        != null && Name.Equals(other.Name))                                              &&
                   (UId         == other.UId         && UId         != null && other.UId         != null && UId.Equals(other.UId))                                                &&
                   (Equals(Ids,        other.Ids)        || Ids        != null && other.Ids        != null && Ids.SequenceEqual(other.Ids))                                       &&
                   (Equals(CustomData, other.CustomData) || CustomData != null && other.CustomData != null && CustomData.SequenceEqual(other.CustomData))                         &&
                   (Meta == other.Meta && Meta != null && other.Meta != null && Meta.Equals(other.Meta))                                                                          &&
                   (Equals(MetaArray, other.MetaArray) || MetaArray != null && other.MetaArray != null && MetaArray.SequenceEqual(other.MetaArray))                               &&
                   (HoverInfo == other.HoverInfo && HoverInfo != null && other.HoverInfo != null && HoverInfo.Equals(other.HoverInfo))                                            &&
                   (Equals(HoverInfoArray, other.HoverInfoArray) || HoverInfoArray != null && other.HoverInfoArray != null && HoverInfoArray.SequenceEqual(other.HoverInfoArray)) &&
                   (HoverLabel == other.HoverLabel && HoverLabel != null && other.HoverLabel != null && HoverLabel.Equals(other.HoverLabel))                                      &&
                   (Stream     == other.Stream     && Stream     != null && other.Stream     != null && Stream.Equals(other.Stream))                                              &&
                   (Equals(Transforms, other.Transforms) || Transforms != null && other.Transforms != null && Transforms.SequenceEqual(other.Transforms))                         &&
                   (UiRevision == other.UiRevision && UiRevision != null && other.UiRevision != null && UiRevision.Equals(other.UiRevision))                                      &&
                   (Equals(X, other.X) || X != null && other.X != null && X.SequenceEqual(other.X))                                                                               &&
                   (Equals(Y, other.Y) || Y != null && other.Y != null && Y.SequenceEqual(other.Y))                                                                               &&
                   (Equals(Z, other.Z) || Z != null && other.Z != null && Z.SequenceEqual(other.Z))                                                                               &&
                   (Marker        == other.Marker        && Marker        != null && other.Marker        != null && Marker.Equals(other.Marker))                                  &&
                   (HistNorm      == other.HistNorm      && HistNorm      != null && other.HistNorm      != null && HistNorm.Equals(other.HistNorm))                              &&
                   (HistFunc      == other.HistFunc      && HistFunc      != null && other.HistFunc      != null && HistFunc.Equals(other.HistFunc))                              &&
                   (NBinsX        == other.NBinsX        && NBinsX        != null && other.NBinsX        != null && NBinsX.Equals(other.NBinsX))                                  &&
                   (XBins         == other.XBins         && XBins         != null && other.XBins         != null && XBins.Equals(other.XBins))                                    &&
                   (NBinsY        == other.NBinsY        && NBinsY        != null && other.NBinsY        != null && NBinsY.Equals(other.NBinsY))                                  &&
                   (YBins         == other.YBins         && YBins         != null && other.YBins         != null && YBins.Equals(other.YBins))                                    &&
                   (AutoBinX      == other.AutoBinX      && AutoBinX      != null && other.AutoBinX      != null && AutoBinX.Equals(other.AutoBinX))                              &&
                   (AutoBinY      == other.AutoBinY      && AutoBinY      != null && other.AutoBinY      != null && AutoBinY.Equals(other.AutoBinY))                              &&
                   (BinGroup      == other.BinGroup      && BinGroup      != null && other.BinGroup      != null && BinGroup.Equals(other.BinGroup))                              &&
                   (XBinGroup     == other.XBinGroup     && XBinGroup     != null && other.XBinGroup     != null && XBinGroup.Equals(other.XBinGroup))                            &&
                   (YBinGroup     == other.YBinGroup     && YBinGroup     != null && other.YBinGroup     != null && YBinGroup.Equals(other.YBinGroup))                            &&
                   (XGap          == other.XGap          && XGap          != null && other.XGap          != null && XGap.Equals(other.XGap))                                      &&
                   (YGap          == other.YGap          && YGap          != null && other.YGap          != null && YGap.Equals(other.YGap))                                      &&
                   (ZSmooth       == other.ZSmooth       && ZSmooth       != null && other.ZSmooth       != null && ZSmooth.Equals(other.ZSmooth))                                &&
                   (ZHoverFormat  == other.ZHoverFormat  && ZHoverFormat  != null && other.ZHoverFormat  != null && ZHoverFormat.Equals(other.ZHoverFormat))                      &&
                   (HoverTemplate == other.HoverTemplate && HoverTemplate != null && other.HoverTemplate != null && HoverTemplate.Equals(other.HoverTemplate))                    &&
                   (Equals(HoverTemplateArray, other.HoverTemplateArray) ||
                    HoverTemplateArray != null && other.HoverTemplateArray != null && HoverTemplateArray.SequenceEqual(other.HoverTemplateArray))                            &&
                   (ShowLegend       == other.ShowLegend       && ShowLegend       != null && other.ShowLegend       != null && ShowLegend.Equals(other.ShowLegend))         &&
                   (ZAuto            == other.ZAuto            && ZAuto            != null && other.ZAuto            != null && ZAuto.Equals(other.ZAuto))                   &&
                   (ZMin             == other.ZMin             && ZMin             != null && other.ZMin             != null && ZMin.Equals(other.ZMin))                     &&
                   (ZMax             == other.ZMax             && ZMax             != null && other.ZMax             != null && ZMax.Equals(other.ZMax))                     &&
                   (ZMid             == other.ZMid             && ZMid             != null && other.ZMid             != null && ZMid.Equals(other.ZMid))                     &&
                   (ColorScale       == other.ColorScale       && ColorScale       != null && other.ColorScale       != null && ColorScale.Equals(other.ColorScale))         &&
                   (AutoColorScale   == other.AutoColorScale   && AutoColorScale   != null && other.AutoColorScale   != null && AutoColorScale.Equals(other.AutoColorScale)) &&
                   (ReverseScale     == other.ReverseScale     && ReverseScale     != null && other.ReverseScale     != null && ReverseScale.Equals(other.ReverseScale))     &&
                   (ShowScale        == other.ShowScale        && ShowScale        != null && other.ShowScale        != null && ShowScale.Equals(other.ShowScale))           &&
                   (ColorBar         == other.ColorBar         && ColorBar         != null && other.ColorBar         != null && ColorBar.Equals(other.ColorBar))             &&
                   (ColorAxis        == other.ColorAxis        && ColorAxis        != null && other.ColorAxis        != null && ColorAxis.Equals(other.ColorAxis))           &&
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
                   (ZSrc             == other.ZSrc             && ZSrc             != null && other.ZSrc             != null && ZSrc.Equals(other.ZSrc))                     &&
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

                if(Z != null)
                    hashCode = hashCode * 59 + Z.GetHashCode();

                if(Marker != null)
                    hashCode = hashCode * 59 + Marker.GetHashCode();

                if(HistNorm != null)
                    hashCode = hashCode * 59 + HistNorm.GetHashCode();

                if(HistFunc != null)
                    hashCode = hashCode * 59 + HistFunc.GetHashCode();

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

                if(XBinGroup != null)
                    hashCode = hashCode * 59 + XBinGroup.GetHashCode();

                if(YBinGroup != null)
                    hashCode = hashCode * 59 + YBinGroup.GetHashCode();

                if(XGap != null)
                    hashCode = hashCode * 59 + XGap.GetHashCode();

                if(YGap != null)
                    hashCode = hashCode * 59 + YGap.GetHashCode();

                if(ZSmooth != null)
                    hashCode = hashCode * 59 + ZSmooth.GetHashCode();

                if(ZHoverFormat != null)
                    hashCode = hashCode * 59 + ZHoverFormat.GetHashCode();

                if(HoverTemplate != null)
                    hashCode = hashCode * 59 + HoverTemplate.GetHashCode();

                if(HoverTemplateArray != null)
                    hashCode = hashCode * 59 + HoverTemplateArray.GetHashCode();

                if(ShowLegend != null)
                    hashCode = hashCode * 59 + ShowLegend.GetHashCode();

                if(ZAuto != null)
                    hashCode = hashCode * 59 + ZAuto.GetHashCode();

                if(ZMin != null)
                    hashCode = hashCode * 59 + ZMin.GetHashCode();

                if(ZMax != null)
                    hashCode = hashCode * 59 + ZMax.GetHashCode();

                if(ZMid != null)
                    hashCode = hashCode * 59 + ZMid.GetHashCode();

                if(ColorScale != null)
                    hashCode = hashCode * 59 + ColorScale.GetHashCode();

                if(AutoColorScale != null)
                    hashCode = hashCode * 59 + AutoColorScale.GetHashCode();

                if(ReverseScale != null)
                    hashCode = hashCode * 59 + ReverseScale.GetHashCode();

                if(ShowScale != null)
                    hashCode = hashCode * 59 + ShowScale.GetHashCode();

                if(ColorBar != null)
                    hashCode = hashCode * 59 + ColorBar.GetHashCode();

                if(ColorAxis != null)
                    hashCode = hashCode * 59 + ColorAxis.GetHashCode();

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

                if(ZSrc != null)
                    hashCode = hashCode * 59 + ZSrc.GetHashCode();

                if(HoverTemplateSrc != null)
                    hashCode = hashCode * 59 + HoverTemplateSrc.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Histogram2D and the right Histogram2D.
        /// </summary>
        /// <param name="left">Left Histogram2D.</param>
        /// <param name="right">Right Histogram2D.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(Histogram2D left,
                                       Histogram2D right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Histogram2D and the right Histogram2D.
        /// </summary>
        /// <param name="left">Left Histogram2D.</param>
        /// <param name="right">Right Histogram2D.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(Histogram2D left,
                                       Histogram2D right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Histogram2D</returns>
        public Histogram2D DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<Histogram2D>(ms).Result;
        }
    }
}
