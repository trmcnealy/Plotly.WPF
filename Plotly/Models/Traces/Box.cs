

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Traces.Boxs;

using Stream = Plotly.Models.Traces.Boxs.Stream;

namespace Plotly.Models.Traces
{
    /// <summary>
    ///     The Box class.
    ///     Implements the <see cref="ITrace" />.
    /// </summary>
    
    [JsonConverter(typeof(PlotlyConverter))]
    [Serializable]
    public class Box : ITrace, IEquatable<Box>
    {
        /// <inheritdoc/>
        [JsonPropertyName(@"type")]
        public TraceTypeEnum? Type { get; } = TraceTypeEnum.Box;

        /// <summary>
        ///     Determines whether or not this trace is visible. If <c>legendonly</c>, the
        ///     trace is not drawn, but can appear as a legend item (provided that the legend
        ///     itself is visible).
        /// </summary>
        [JsonPropertyName(@"visible")]
        public VisibleEnum? Visible { get; set;} 

        /// <summary>
        ///     Determines whether or not an item corresponding to this trace is shown in
        ///     the legend.
        /// </summary>
        [JsonPropertyName(@"showlegend")]
        public bool? ShowLegend { get; set;} 

        /// <summary>
        ///     Sets the legend group for this trace. Traces part of the same legend group
        ///     hide/show at the same time when toggling legend items.
        /// </summary>
        [JsonPropertyName(@"legendgroup")]
        public string LegendGroup { get; set;} 

        /// <summary>
        ///     Sets the opacity of the trace.
        /// </summary>
        [JsonPropertyName(@"opacity")]
        public JsNumber? Opacity { get; set;} 

        /// <summary>
        ///     Assign an id to this trace, Use this to provide object constancy between
        ///     traces during animations and transitions.
        /// </summary>
        [JsonPropertyName(@"uid")]
        public string UId { get; set;} 

        /// <summary>
        ///     Assigns id labels to each datum. These ids for object constancy of data
        ///     points during animation. Should be an array of strings, not numbers or any
        ///     other type.
        /// </summary>
        [JsonPropertyName(@"ids")]
        public List<object> Ids { get; set;} 

        /// <summary>
        ///     Assigns extra data each datum. This may be useful when listening to hover,
        ///     click and selection events. Note that, <c>scatter</c> traces also appends
        ///     customdata items in the markers DOM elements
        /// </summary>
        [JsonPropertyName(@"customdata")]
        public List<object> CustomData { get; set;} 

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
        public object Meta { get; set;} 

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
        public List<object> MetaArray { get; set;} 

        /// <summary>
        ///     Array containing integer indices of selected points. Has an effect only
        ///     for traces that support selections. Note that an empty array means an empty
        ///     selection where the <c>unselected</c> are turned on for all points, whereas,
        ///     any other non-array values means no selection all where the <c>selected</c>
        ///     and <c>unselected</c> styles have no effect.
        /// </summary>
        [JsonPropertyName(@"selectedpoints")]
        public object SelectedPoints { get; set;} 

        /// <summary>
        ///     Determines which trace information appear on hover. If <c>none</c> or <c>skip</c>
        ///     are set, no information is displayed upon hovering. But, if <c>none</c>
        ///     is set, click and hover events are still fired.
        /// </summary>
        [JsonPropertyName(@"hoverinfo")]
        public HoverInfoFlag? HoverInfo { get; set;} 

        /// <summary>
        ///     Determines which trace information appear on hover. If <c>none</c> or <c>skip</c>
        ///     are set, no information is displayed upon hovering. But, if <c>none</c>
        ///     is set, click and hover events are still fired.
        /// </summary>
        [JsonPropertyName(@"hoverinfo")]
        [Array]
        public List<HoverInfoFlag?> HoverInfoArray { get; set;} 

        /// <summary>
        ///     Gets or sets the HoverLabel.
        /// </summary>
        [JsonPropertyName(@"hoverlabel")]
        public HoverLabel HoverLabel { get; set;} 

        /// <summary>
        ///     Gets or sets the Stream.
        /// </summary>
        [JsonPropertyName(@"stream")]
        public Stream Stream { get; set;} 

        /// <summary>
        ///     Gets or sets the Transforms.
        /// </summary>
        [JsonPropertyName(@"transforms")]
        public List<ITransform> Transforms { get; set;} 

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
        public object UiRevision { get; set;} 

        /// <summary>
        ///     Sets the y sample data or coordinates. See overview for more info.
        /// </summary>
        [JsonPropertyName(@"y")]
        public List<object> Y { get; set;} 

        /// <summary>
        ///     Sets the x sample data or coordinates. See overview for more info.
        /// </summary>
        [JsonPropertyName(@"x")]
        public List<object> X { get; set;} 

        /// <summary>
        ///     Sets the x coordinate for single-box traces or the starting coordinate for
        ///     multi-box traces set using q1/median/q3. See overview for more info.
        /// </summary>
        [JsonPropertyName(@"x0")]
        public object X0 { get; set;} 

        /// <summary>
        ///     Sets the y coordinate for single-box traces or the starting coordinate for
        ///     multi-box traces set using q1/median/q3. See overview for more info.
        /// </summary>
        [JsonPropertyName(@"y0")]
        public object Y0 { get; set;} 

        /// <summary>
        ///     Sets the x coordinate step for multi-box traces set using q1/median/q3.
        /// </summary>
        [JsonPropertyName(@"dx")]
        public JsNumber? DX { get; set;} 

        /// <summary>
        ///     Sets the y coordinate step for multi-box traces set using q1/median/q3.
        /// </summary>
        [JsonPropertyName(@"dy")]
        public JsNumber? Dy { get; set;} 

        /// <summary>
        ///     Sets the trace name. The trace name appear as the legend item and on hover.
        ///     For box traces, the name will also be used for the position coordinate,
        ///     if <c>x</c> and <c>x0</c> (<c>y</c> and <c>y0</c> if horizontal) are missing
        ///     and the position axis is categorical
        /// </summary>
        [JsonPropertyName(@"name")]
        public string Name { get; set;} 

        /// <summary>
        ///     Sets the Quartile 1 values. There should be as many items as the number
        ///     of boxes desired.
        /// </summary>
        [JsonPropertyName(@"q1")]
        public List<object> Q1 { get; set;} 

        /// <summary>
        ///     Sets the median values. There should be as many items as the number of boxes
        ///     desired.
        /// </summary>
        [JsonPropertyName(@"median")]
        public List<object> Median { get; set;} 

        /// <summary>
        ///     Sets the Quartile 3 values. There should be as many items as the number
        ///     of boxes desired.
        /// </summary>
        [JsonPropertyName(@"q3")]
        public List<object> Q3 { get; set;} 

        /// <summary>
        ///     Sets the lower fence values. There should be as many items as the number
        ///     of boxes desired. This attribute has effect only under the q1/median/q3
        ///     signature. If <c>lowerfence</c> is not provided but a sample (in <c>y</c>
        ///     or <c>x</c>) is set, we compute the lower as the last sample point below
        ///     1.5 times the IQR.
        /// </summary>
        [JsonPropertyName(@"lowerfence")]
        public List<object> LowerFence { get; set;} 

        /// <summary>
        ///     Sets the upper fence values. There should be as many items as the number
        ///     of boxes desired. This attribute has effect only under the q1/median/q3
        ///     signature. If <c>upperfence</c> is not provided but a sample (in <c>y</c>
        ///     or <c>x</c>) is set, we compute the lower as the last sample point above
        ///     1.5 times the IQR.
        /// </summary>
        [JsonPropertyName(@"upperfence")]
        public List<object> UpperFence { get; set;} 

        /// <summary>
        ///     Determines whether or not notches are drawn. Notches displays a confidence
        ///     interval around the median. We compute the confidence interval as median
        ///     +/- 1.57 * IQR / sqrt(N), where IQR is the interquartile range and N is
        ///     the sample size. If two boxes&#39; notches do not overlap there is 95% confidence
        ///     their medians differ. See https://sites.google.com/site/davidsstatistics/home/notched-box-plots
        ///     for more info. Defaults to <c>false</c> unless <c>notchwidth</c> or <c>notchspan</c>
        ///     is set.
        /// </summary>
        [JsonPropertyName(@"notched")]
        public bool? Notched { get; set;} 

        /// <summary>
        ///     Sets the width of the notches relative to the box&#39; width. For example,
        ///     with 0, the notches are as wide as the box(es).
        /// </summary>
        [JsonPropertyName(@"notchwidth")]
        public JsNumber? NotchWidth { get; set;} 

        /// <summary>
        ///     Sets the notch span from the boxes&#39; <c>median</c> values. There should
        ///     be as many items as the number of boxes desired. This attribute has effect
        ///     only under the q1/median/q3 signature. If <c>notchspan</c> is not provided
        ///     but a sample (in <c>y</c> or <c>x</c>) is set, we compute it as 1.57 * IQR
        ///     / sqrt(N), where N is the sample size.
        /// </summary>
        [JsonPropertyName(@"notchspan")]
        public List<object> NotchSpan { get; set;} 

        /// <summary>
        ///     If <c>outliers</c>, only the sample points lying outside the whiskers are
        ///     shown If <c>suspectedoutliers</c>, the outlier points are shown and points
        ///     either less than 4<c>Q1-3</c>Q3 or greater than 4<c>Q3-3</c>Q1 are highlighted
        ///     (see <c>outliercolor</c>) If <c>all</c>, all sample points are shown If
        ///     <c>false</c>, only the box(es) are shown with no sample points Defaults
        ///     to <c>suspectedoutliers</c> when <c>marker.outliercolor</c> or <c>marker.line.outliercolor</c>
        ///     is set. Defaults to <c>all</c> under the q1/median/q3 signature. Otherwise
        ///     defaults to <c>outliers</c>.
        /// </summary>
        [JsonPropertyName(@"boxpoints")]
        public BoxPointsEnum? BoxPoints { get; set;} 

        /// <summary>
        ///     Sets the amount of jitter in the sample points drawn. If <c>0</c>, the sample
        ///     points align along the distribution axis. If <c>1</c>, the sample points
        ///     are drawn in a random jitter of width equal to the width of the box(es).
        /// </summary>
        [JsonPropertyName(@"jitter")]
        public JsNumber? Jitter { get; set;} 

        /// <summary>
        ///     Sets the position of the sample points in relation to the box(es). If <c>0</c>,
        ///     the sample points are places over the center of the box(es). Positive (negative)
        ///     values correspond to positions to the right (left) for vertical boxes and
        ///     above (below) for horizontal boxes
        /// </summary>
        [JsonPropertyName(@"pointpos")]
        public JsNumber? PointPos { get; set;} 

        /// <summary>
        ///     If <c>true</c>, the mean of the box(es)&#39; underlying distribution is
        ///     drawn as a dashed line inside the box(es). If <c>sd</c> the standard deviation
        ///     is also drawn. Defaults to <c>true</c> when <c>mean</c> is set. Defaults
        ///     to <c>sd</c> when <c>sd</c> is set Otherwise defaults to <c>false</c>.
        /// </summary>
        [JsonPropertyName(@"boxmean")]
        public BoxMeanEnum? BoxMean { get; set;} 

        /// <summary>
        ///     Sets the mean values. There should be as many items as the number of boxes
        ///     desired. This attribute has effect only under the q1/median/q3 signature.
        ///     If <c>mean</c> is not provided but a sample (in <c>y</c> or <c>x</c>) is
        ///     set, we compute the mean for each box using the sample values.
        /// </summary>
        [JsonPropertyName(@"mean")]
        public List<object> Mean { get; set;} 

        /// <summary>
        ///     Sets the standard deviation values. There should be as many items as the
        ///     number of boxes desired. This attribute has effect only under the q1/median/q3
        ///     signature. If <c>sd</c> is not provided but a sample (in <c>y</c> or <c>x</c>)
        ///     is set, we compute the standard deviation for each box using the sample
        ///     values.
        /// </summary>
        [JsonPropertyName(@"sd")]
        public List<object> SD { get; set;} 

        /// <summary>
        ///     Sets the orientation of the box(es). If <c>v</c> (<c>h</c>), the distribution
        ///     is visualized along the vertical (horizontal).
        /// </summary>
        [JsonPropertyName(@"orientation")]
        public OrientationEnum? Orientation { get; set;} 

        /// <summary>
        ///     Sets the method used to compute the sample&#39;s Q1 and Q3 quartiles. The
        ///     <c>linear</c> method uses the 25th percentile for Q1 and 75th percentile
        ///     for Q3 as computed using method #10 (listed on http://www.amstat.org/publications/jse/v14n3/langford.html).
        ///     The <c>exclusive</c> method uses the median to divide the ordered dataset
        ///     into two halves if the sample is odd, it does not include the median in
        ///     either half - Q1 is then the median of the lower half and Q3 the median
        ///     of the upper half. The <c>inclusive</c> method also uses the median to divide
        ///     the ordered dataset into two halves but if the sample is odd, it includes
        ///     the median in both halves - Q1 is then the median of the lower half and
        ///     Q3 the median of the upper half.
        /// </summary>
        [JsonPropertyName(@"quartilemethod")]
        public QuartileMethodEnum? QuartileMethod { get; set;} 

        /// <summary>
        ///     Sets the width of the box in data coordinate If <c>0</c> (default value)
        ///     the width is automatically selected based on the positions of other box
        ///     traces in the same subplot.
        /// </summary>
        [JsonPropertyName(@"width")]
        public JsNumber? Width { get; set;} 

        /// <summary>
        ///     Gets or sets the Marker.
        /// </summary>
        [JsonPropertyName(@"marker")]
        public Marker Marker { get; set;} 

        /// <summary>
        ///     Gets or sets the Line.
        /// </summary>
        [JsonPropertyName(@"line")]
        public Line Line { get; set;} 

        /// <summary>
        ///     Sets the fill color. Defaults to a half-transparent variant of the line
        ///     color, marker color, or marker line color, whichever is available.
        /// </summary>
        [JsonPropertyName(@"fillcolor")]
        public object FillColor { get; set;} 

        /// <summary>
        ///     Sets the width of the whiskers relative to the box&#39; width. For example,
        ///     with 1, the whiskers are as wide as the box(es).
        /// </summary>
        [JsonPropertyName(@"whiskerwidth")]
        public JsNumber? WhiskerWidth { get; set;} 

        /// <summary>
        ///     Set several traces linked to the same position axis or matching axes to
        ///     the same offsetgroup where bars of the same position coordinate will line
        ///     up.
        /// </summary>
        [JsonPropertyName(@"offsetgroup")]
        public string OffsetGroup { get; set;} 

        /// <summary>
        ///     Set several traces linked to the same position axis or matching axes to
        ///     the same alignmentgroup. This controls whether bars compute their positional
        ///     range dependently or independently.
        /// </summary>
        [JsonPropertyName(@"alignmentgroup")]
        public string AlignmentGroup { get; set;} 

        /// <summary>
        ///     Gets or sets the Selected.
        /// </summary>
        [JsonPropertyName(@"selected")]
        public Selected Selected { get; set;} 

        /// <summary>
        ///     Gets or sets the Unselected.
        /// </summary>
        [JsonPropertyName(@"unselected")]
        public Unselected Unselected { get; set;} 

        /// <summary>
        ///     Sets the text elements associated with each sample value. If a single string,
        ///     the same string appears over all the data points. If an array of string,
        ///     the items are mapped in order to the this trace&#39;s (x,y) coordinates.
        ///     To be seen, trace <c>hoverinfo</c> must contain a <c>text</c> flag.
        /// </summary>
        [JsonPropertyName(@"text")]
        public string Text { get; set;} 

        /// <summary>
        ///     Sets the text elements associated with each sample value. If a single string,
        ///     the same string appears over all the data points. If an array of string,
        ///     the items are mapped in order to the this trace&#39;s (x,y) coordinates.
        ///     To be seen, trace <c>hoverinfo</c> must contain a <c>text</c> flag.
        /// </summary>
        [JsonPropertyName(@"text")]
        [Array]
        public List<string> TextArray { get; set;} 

        /// <summary>
        ///     Same as <c>text</c>.
        /// </summary>
        [JsonPropertyName(@"hovertext")]
        public string HoverText { get; set;} 

        /// <summary>
        ///     Same as <c>text</c>.
        /// </summary>
        [JsonPropertyName(@"hovertext")]
        [Array]
        public List<string> HoverTextArray { get; set;} 

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
        ///     that are &#39;arrayOk: true&#39;) are available.  Anything contained in
        ///     tag <c>&lt;extra&gt;</c> is displayed in the secondary box, for example
        ///     <c>&lt;extra&gt;{fullData.name}&lt;/extra&gt;</c>. To hide the secondary
        ///     box completely, use an empty tag <c>&lt;extra&gt;&lt;/extra&gt;</c>.
        /// </summary>
        [JsonPropertyName(@"hovertemplate")]
        public string HoverTemplate { get; set;} 

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
        ///     that are &#39;arrayOk: true&#39;) are available.  Anything contained in
        ///     tag <c>&lt;extra&gt;</c> is displayed in the secondary box, for example
        ///     <c>&lt;extra&gt;{fullData.name}&lt;/extra&gt;</c>. To hide the secondary
        ///     box completely, use an empty tag <c>&lt;extra&gt;&lt;/extra&gt;</c>.
        /// </summary>
        [JsonPropertyName(@"hovertemplate")]
        [Array]
        public List<string> HoverTemplateArray { get; set;} 

        /// <summary>
        ///     Do the hover effects highlight individual boxes  or sample points or both?
        /// </summary>
        [JsonPropertyName(@"hoveron")]
        public HoverOnFlag? HoverOn { get; set;} 

        /// <summary>
        ///     Sets the calendar system to use with <c>x</c> date data.
        /// </summary>
        [JsonPropertyName(@"xcalendar")]
        public XCalendarEnum? XCalendar { get; set;} 

        /// <summary>
        ///     Sets the calendar system to use with <c>y</c> date data.
        /// </summary>
        [JsonPropertyName(@"ycalendar")]
        public YCalendarEnum? YCalendar { get; set;} 

        /// <summary>
        ///     Sets a reference between this trace&#39;s x coordinates and a 2D cartesian
        ///     x axis. If <c>x</c> (the default value), the x coordinates refer to <c>layout.xaxis</c>.
        ///     If <c>x2</c>, the x coordinates refer to <c>layout.xaxis2</c>, and so on.
        /// </summary>
        [JsonPropertyName(@"xaxis")]
        public string XAxis { get; set;} 

        /// <summary>
        ///     Sets a reference between this trace&#39;s y coordinates and a 2D cartesian
        ///     y axis. If <c>y</c> (the default value), the y coordinates refer to <c>layout.yaxis</c>.
        ///     If <c>y2</c>, the y coordinates refer to <c>layout.yaxis2</c>, and so on.
        /// </summary>
        [JsonPropertyName(@"yaxis")]
        public string YAxis { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  ids .
        /// </summary>
        [JsonPropertyName(@"idssrc")]
        public string IdsSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  customdata .
        /// </summary>
        [JsonPropertyName(@"customdatasrc")]
        public string CustomDataSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  meta .
        /// </summary>
        [JsonPropertyName(@"metasrc")]
        public string MetaSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  hoverinfo .
        /// </summary>
        [JsonPropertyName(@"hoverinfosrc")]
        public string HoverInfoSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  y .
        /// </summary>
        [JsonPropertyName(@"ysrc")]
        public string YSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  x .
        /// </summary>
        [JsonPropertyName(@"xsrc")]
        public string XSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  q1 .
        /// </summary>
        [JsonPropertyName(@"q1src")]
        public string Q1Src { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  median .
        /// </summary>
        [JsonPropertyName(@"mediansrc")]
        public string MedianSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  q3 .
        /// </summary>
        [JsonPropertyName(@"q3src")]
        public string Q3Src { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  lowerfence .
        /// </summary>
        [JsonPropertyName(@"lowerfencesrc")]
        public string LowerFenceSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  upperfence .
        /// </summary>
        [JsonPropertyName(@"upperfencesrc")]
        public string UpperFenceSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  notchspan .
        /// </summary>
        [JsonPropertyName(@"notchspansrc")]
        public string NotchSpanSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  mean .
        /// </summary>
        [JsonPropertyName(@"meansrc")]
        public string MeanSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  sd .
        /// </summary>
        [JsonPropertyName(@"sdsrc")]
        public string SdSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  text .
        /// </summary>
        [JsonPropertyName(@"textsrc")]
        public string TextSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  hovertext .
        /// </summary>
        [JsonPropertyName(@"hovertextsrc")]
        public string HoverTextSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  hovertemplate .
        /// </summary>
        [JsonPropertyName(@"hovertemplatesrc")]
        public string HoverTemplateSrc { get; set;} 

        
        public override bool Equals(object obj)
        {
            if (!(obj is Box other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        
        public bool Equals([AllowNull] Box other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Type == other.Type &&
                    Type != null && other.Type != null &&
                    Type.Equals(other.Type)
                ) && 
                (
                    Visible == other.Visible &&
                    Visible != null && other.Visible != null &&
                    Visible.Equals(other.Visible)
                ) && 
                (
                    ShowLegend == other.ShowLegend &&
                    ShowLegend != null && other.ShowLegend != null &&
                    ShowLegend.Equals(other.ShowLegend)
                ) && 
                (
                    LegendGroup == other.LegendGroup &&
                    LegendGroup != null && other.LegendGroup != null &&
                    LegendGroup.Equals(other.LegendGroup)
                ) && 
                (
                    Opacity == other.Opacity &&
                    Opacity != null && other.Opacity != null &&
                    Opacity.Equals(other.Opacity)
                ) && 
                (
                    UId == other.UId &&
                    UId != null && other.UId != null &&
                    UId.Equals(other.UId)
                ) && 
                (
                    Equals(Ids, other.Ids) ||
                    Ids != null && other.Ids != null &&
                    Ids.SequenceEqual(other.Ids)
                ) &&
                (
                    Equals(CustomData, other.CustomData) ||
                    CustomData != null && other.CustomData != null &&
                    CustomData.SequenceEqual(other.CustomData)
                ) &&
                (
                    Meta == other.Meta &&
                    Meta != null && other.Meta != null &&
                    Meta.Equals(other.Meta)
                ) && 
                (
                    Equals(MetaArray, other.MetaArray) ||
                    MetaArray != null && other.MetaArray != null &&
                    MetaArray.SequenceEqual(other.MetaArray)
                ) &&
                (
                    SelectedPoints == other.SelectedPoints &&
                    SelectedPoints != null && other.SelectedPoints != null &&
                    SelectedPoints.Equals(other.SelectedPoints)
                ) && 
                (
                    HoverInfo == other.HoverInfo &&
                    HoverInfo != null && other.HoverInfo != null &&
                    HoverInfo.Equals(other.HoverInfo)
                ) && 
                (
                    Equals(HoverInfoArray, other.HoverInfoArray) ||
                    HoverInfoArray != null && other.HoverInfoArray != null &&
                    HoverInfoArray.SequenceEqual(other.HoverInfoArray)
                ) &&
                (
                    HoverLabel == other.HoverLabel &&
                    HoverLabel != null && other.HoverLabel != null &&
                    HoverLabel.Equals(other.HoverLabel)
                ) && 
                (
                    Stream == other.Stream &&
                    Stream != null && other.Stream != null &&
                    Stream.Equals(other.Stream)
                ) && 
                (
                    Equals(Transforms, other.Transforms) ||
                    Transforms != null && other.Transforms != null &&
                    Transforms.SequenceEqual(other.Transforms)
                ) &&
                (
                    UiRevision == other.UiRevision &&
                    UiRevision != null && other.UiRevision != null &&
                    UiRevision.Equals(other.UiRevision)
                ) && 
                (
                    Equals(Y, other.Y) ||
                    Y != null && other.Y != null &&
                    Y.SequenceEqual(other.Y)
                ) &&
                (
                    Equals(X, other.X) ||
                    X != null && other.X != null &&
                    X.SequenceEqual(other.X)
                ) &&
                (
                    X0 == other.X0 &&
                    X0 != null && other.X0 != null &&
                    X0.Equals(other.X0)
                ) && 
                (
                    Y0 == other.Y0 &&
                    Y0 != null && other.Y0 != null &&
                    Y0.Equals(other.Y0)
                ) && 
                (
                    DX == other.DX &&
                    DX != null && other.DX != null &&
                    DX.Equals(other.DX)
                ) && 
                (
                    Dy == other.Dy &&
                    Dy != null && other.Dy != null &&
                    Dy.Equals(other.Dy)
                ) && 
                (
                    Name == other.Name &&
                    Name != null && other.Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    Equals(Q1, other.Q1) ||
                    Q1 != null && other.Q1 != null &&
                    Q1.SequenceEqual(other.Q1)
                ) &&
                (
                    Equals(Median, other.Median) ||
                    Median != null && other.Median != null &&
                    Median.SequenceEqual(other.Median)
                ) &&
                (
                    Equals(Q3, other.Q3) ||
                    Q3 != null && other.Q3 != null &&
                    Q3.SequenceEqual(other.Q3)
                ) &&
                (
                    Equals(LowerFence, other.LowerFence) ||
                    LowerFence != null && other.LowerFence != null &&
                    LowerFence.SequenceEqual(other.LowerFence)
                ) &&
                (
                    Equals(UpperFence, other.UpperFence) ||
                    UpperFence != null && other.UpperFence != null &&
                    UpperFence.SequenceEqual(other.UpperFence)
                ) &&
                (
                    Notched == other.Notched &&
                    Notched != null && other.Notched != null &&
                    Notched.Equals(other.Notched)
                ) && 
                (
                    NotchWidth == other.NotchWidth &&
                    NotchWidth != null && other.NotchWidth != null &&
                    NotchWidth.Equals(other.NotchWidth)
                ) && 
                (
                    Equals(NotchSpan, other.NotchSpan) ||
                    NotchSpan != null && other.NotchSpan != null &&
                    NotchSpan.SequenceEqual(other.NotchSpan)
                ) &&
                (
                    BoxPoints == other.BoxPoints &&
                    BoxPoints != null && other.BoxPoints != null &&
                    BoxPoints.Equals(other.BoxPoints)
                ) && 
                (
                    Jitter == other.Jitter &&
                    Jitter != null && other.Jitter != null &&
                    Jitter.Equals(other.Jitter)
                ) && 
                (
                    PointPos == other.PointPos &&
                    PointPos != null && other.PointPos != null &&
                    PointPos.Equals(other.PointPos)
                ) && 
                (
                    BoxMean == other.BoxMean &&
                    BoxMean != null && other.BoxMean != null &&
                    BoxMean.Equals(other.BoxMean)
                ) && 
                (
                    Equals(Mean, other.Mean) ||
                    Mean != null && other.Mean != null &&
                    Mean.SequenceEqual(other.Mean)
                ) &&
                (
                    Equals(SD, other.SD) ||
                    SD != null && other.SD != null &&
                    SD.SequenceEqual(other.SD)
                ) &&
                (
                    Orientation == other.Orientation &&
                    Orientation != null && other.Orientation != null &&
                    Orientation.Equals(other.Orientation)
                ) && 
                (
                    QuartileMethod == other.QuartileMethod &&
                    QuartileMethod != null && other.QuartileMethod != null &&
                    QuartileMethod.Equals(other.QuartileMethod)
                ) && 
                (
                    Width == other.Width &&
                    Width != null && other.Width != null &&
                    Width.Equals(other.Width)
                ) && 
                (
                    Marker == other.Marker &&
                    Marker != null && other.Marker != null &&
                    Marker.Equals(other.Marker)
                ) && 
                (
                    Line == other.Line &&
                    Line != null && other.Line != null &&
                    Line.Equals(other.Line)
                ) && 
                (
                    FillColor == other.FillColor &&
                    FillColor != null && other.FillColor != null &&
                    FillColor.Equals(other.FillColor)
                ) && 
                (
                    WhiskerWidth == other.WhiskerWidth &&
                    WhiskerWidth != null && other.WhiskerWidth != null &&
                    WhiskerWidth.Equals(other.WhiskerWidth)
                ) && 
                (
                    OffsetGroup == other.OffsetGroup &&
                    OffsetGroup != null && other.OffsetGroup != null &&
                    OffsetGroup.Equals(other.OffsetGroup)
                ) && 
                (
                    AlignmentGroup == other.AlignmentGroup &&
                    AlignmentGroup != null && other.AlignmentGroup != null &&
                    AlignmentGroup.Equals(other.AlignmentGroup)
                ) && 
                (
                    Selected == other.Selected &&
                    Selected != null && other.Selected != null &&
                    Selected.Equals(other.Selected)
                ) && 
                (
                    Unselected == other.Unselected &&
                    Unselected != null && other.Unselected != null &&
                    Unselected.Equals(other.Unselected)
                ) && 
                (
                    Text == other.Text &&
                    Text != null && other.Text != null &&
                    Text.Equals(other.Text)
                ) && 
                (
                    Equals(TextArray, other.TextArray) ||
                    TextArray != null && other.TextArray != null &&
                    TextArray.SequenceEqual(other.TextArray)
                ) &&
                (
                    HoverText == other.HoverText &&
                    HoverText != null && other.HoverText != null &&
                    HoverText.Equals(other.HoverText)
                ) && 
                (
                    Equals(HoverTextArray, other.HoverTextArray) ||
                    HoverTextArray != null && other.HoverTextArray != null &&
                    HoverTextArray.SequenceEqual(other.HoverTextArray)
                ) &&
                (
                    HoverTemplate == other.HoverTemplate &&
                    HoverTemplate != null && other.HoverTemplate != null &&
                    HoverTemplate.Equals(other.HoverTemplate)
                ) && 
                (
                    Equals(HoverTemplateArray, other.HoverTemplateArray) ||
                    HoverTemplateArray != null && other.HoverTemplateArray != null &&
                    HoverTemplateArray.SequenceEqual(other.HoverTemplateArray)
                ) &&
                (
                    HoverOn == other.HoverOn &&
                    HoverOn != null && other.HoverOn != null &&
                    HoverOn.Equals(other.HoverOn)
                ) && 
                (
                    XCalendar == other.XCalendar &&
                    XCalendar != null && other.XCalendar != null &&
                    XCalendar.Equals(other.XCalendar)
                ) && 
                (
                    YCalendar == other.YCalendar &&
                    YCalendar != null && other.YCalendar != null &&
                    YCalendar.Equals(other.YCalendar)
                ) && 
                (
                    XAxis == other.XAxis &&
                    XAxis != null && other.XAxis != null &&
                    XAxis.Equals(other.XAxis)
                ) && 
                (
                    YAxis == other.YAxis &&
                    YAxis != null && other.YAxis != null &&
                    YAxis.Equals(other.YAxis)
                ) && 
                (
                    IdsSrc == other.IdsSrc &&
                    IdsSrc != null && other.IdsSrc != null &&
                    IdsSrc.Equals(other.IdsSrc)
                ) && 
                (
                    CustomDataSrc == other.CustomDataSrc &&
                    CustomDataSrc != null && other.CustomDataSrc != null &&
                    CustomDataSrc.Equals(other.CustomDataSrc)
                ) && 
                (
                    MetaSrc == other.MetaSrc &&
                    MetaSrc != null && other.MetaSrc != null &&
                    MetaSrc.Equals(other.MetaSrc)
                ) && 
                (
                    HoverInfoSrc == other.HoverInfoSrc &&
                    HoverInfoSrc != null && other.HoverInfoSrc != null &&
                    HoverInfoSrc.Equals(other.HoverInfoSrc)
                ) && 
                (
                    YSrc == other.YSrc &&
                    YSrc != null && other.YSrc != null &&
                    YSrc.Equals(other.YSrc)
                ) && 
                (
                    XSrc == other.XSrc &&
                    XSrc != null && other.XSrc != null &&
                    XSrc.Equals(other.XSrc)
                ) && 
                (
                    Q1Src == other.Q1Src &&
                    Q1Src != null && other.Q1Src != null &&
                    Q1Src.Equals(other.Q1Src)
                ) && 
                (
                    MedianSrc == other.MedianSrc &&
                    MedianSrc != null && other.MedianSrc != null &&
                    MedianSrc.Equals(other.MedianSrc)
                ) && 
                (
                    Q3Src == other.Q3Src &&
                    Q3Src != null && other.Q3Src != null &&
                    Q3Src.Equals(other.Q3Src)
                ) && 
                (
                    LowerFenceSrc == other.LowerFenceSrc &&
                    LowerFenceSrc != null && other.LowerFenceSrc != null &&
                    LowerFenceSrc.Equals(other.LowerFenceSrc)
                ) && 
                (
                    UpperFenceSrc == other.UpperFenceSrc &&
                    UpperFenceSrc != null && other.UpperFenceSrc != null &&
                    UpperFenceSrc.Equals(other.UpperFenceSrc)
                ) && 
                (
                    NotchSpanSrc == other.NotchSpanSrc &&
                    NotchSpanSrc != null && other.NotchSpanSrc != null &&
                    NotchSpanSrc.Equals(other.NotchSpanSrc)
                ) && 
                (
                    MeanSrc == other.MeanSrc &&
                    MeanSrc != null && other.MeanSrc != null &&
                    MeanSrc.Equals(other.MeanSrc)
                ) && 
                (
                    SdSrc == other.SdSrc &&
                    SdSrc != null && other.SdSrc != null &&
                    SdSrc.Equals(other.SdSrc)
                ) && 
                (
                    TextSrc == other.TextSrc &&
                    TextSrc != null && other.TextSrc != null &&
                    TextSrc.Equals(other.TextSrc)
                ) && 
                (
                    HoverTextSrc == other.HoverTextSrc &&
                    HoverTextSrc != null && other.HoverTextSrc != null &&
                    HoverTextSrc.Equals(other.HoverTextSrc)
                ) && 
                (
                    HoverTemplateSrc == other.HoverTemplateSrc &&
                    HoverTemplateSrc != null && other.HoverTemplateSrc != null &&
                    HoverTemplateSrc.Equals(other.HoverTemplateSrc)
                );
        }

        
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (Type != null) hashCode = hashCode * 59 + Type.GetHashCode();
                if (Visible != null) hashCode = hashCode * 59 + Visible.GetHashCode();
                if (ShowLegend != null) hashCode = hashCode * 59 + ShowLegend.GetHashCode();
                if (LegendGroup != null) hashCode = hashCode * 59 + LegendGroup.GetHashCode();
                if (Opacity != null) hashCode = hashCode * 59 + Opacity.GetHashCode();
                if (UId != null) hashCode = hashCode * 59 + UId.GetHashCode();
                if (Ids != null) hashCode = hashCode * 59 + Ids.GetHashCode();
                if (CustomData != null) hashCode = hashCode * 59 + CustomData.GetHashCode();
                if (Meta != null) hashCode = hashCode * 59 + Meta.GetHashCode();
                if (MetaArray != null) hashCode = hashCode * 59 + MetaArray.GetHashCode();
                if (SelectedPoints != null) hashCode = hashCode * 59 + SelectedPoints.GetHashCode();
                if (HoverInfo != null) hashCode = hashCode * 59 + HoverInfo.GetHashCode();
                if (HoverInfoArray != null) hashCode = hashCode * 59 + HoverInfoArray.GetHashCode();
                if (HoverLabel != null) hashCode = hashCode * 59 + HoverLabel.GetHashCode();
                if (Stream != null) hashCode = hashCode * 59 + Stream.GetHashCode();
                if (Transforms != null) hashCode = hashCode * 59 + Transforms.GetHashCode();
                if (UiRevision != null) hashCode = hashCode * 59 + UiRevision.GetHashCode();
                if (Y != null) hashCode = hashCode * 59 + Y.GetHashCode();
                if (X != null) hashCode = hashCode * 59 + X.GetHashCode();
                if (X0 != null) hashCode = hashCode * 59 + X0.GetHashCode();
                if (Y0 != null) hashCode = hashCode * 59 + Y0.GetHashCode();
                if (DX != null) hashCode = hashCode * 59 + DX.GetHashCode();
                if (Dy != null) hashCode = hashCode * 59 + Dy.GetHashCode();
                if (Name != null) hashCode = hashCode * 59 + Name.GetHashCode();
                if (Q1 != null) hashCode = hashCode * 59 + Q1.GetHashCode();
                if (Median != null) hashCode = hashCode * 59 + Median.GetHashCode();
                if (Q3 != null) hashCode = hashCode * 59 + Q3.GetHashCode();
                if (LowerFence != null) hashCode = hashCode * 59 + LowerFence.GetHashCode();
                if (UpperFence != null) hashCode = hashCode * 59 + UpperFence.GetHashCode();
                if (Notched != null) hashCode = hashCode * 59 + Notched.GetHashCode();
                if (NotchWidth != null) hashCode = hashCode * 59 + NotchWidth.GetHashCode();
                if (NotchSpan != null) hashCode = hashCode * 59 + NotchSpan.GetHashCode();
                if (BoxPoints != null) hashCode = hashCode * 59 + BoxPoints.GetHashCode();
                if (Jitter != null) hashCode = hashCode * 59 + Jitter.GetHashCode();
                if (PointPos != null) hashCode = hashCode * 59 + PointPos.GetHashCode();
                if (BoxMean != null) hashCode = hashCode * 59 + BoxMean.GetHashCode();
                if (Mean != null) hashCode = hashCode * 59 + Mean.GetHashCode();
                if (SD != null) hashCode = hashCode * 59 + SD.GetHashCode();
                if (Orientation != null) hashCode = hashCode * 59 + Orientation.GetHashCode();
                if (QuartileMethod != null) hashCode = hashCode * 59 + QuartileMethod.GetHashCode();
                if (Width != null) hashCode = hashCode * 59 + Width.GetHashCode();
                if (Marker != null) hashCode = hashCode * 59 + Marker.GetHashCode();
                if (Line != null) hashCode = hashCode * 59 + Line.GetHashCode();
                if (FillColor != null) hashCode = hashCode * 59 + FillColor.GetHashCode();
                if (WhiskerWidth != null) hashCode = hashCode * 59 + WhiskerWidth.GetHashCode();
                if (OffsetGroup != null) hashCode = hashCode * 59 + OffsetGroup.GetHashCode();
                if (AlignmentGroup != null) hashCode = hashCode * 59 + AlignmentGroup.GetHashCode();
                if (Selected != null) hashCode = hashCode * 59 + Selected.GetHashCode();
                if (Unselected != null) hashCode = hashCode * 59 + Unselected.GetHashCode();
                if (Text != null) hashCode = hashCode * 59 + Text.GetHashCode();
                if (TextArray != null) hashCode = hashCode * 59 + TextArray.GetHashCode();
                if (HoverText != null) hashCode = hashCode * 59 + HoverText.GetHashCode();
                if (HoverTextArray != null) hashCode = hashCode * 59 + HoverTextArray.GetHashCode();
                if (HoverTemplate != null) hashCode = hashCode * 59 + HoverTemplate.GetHashCode();
                if (HoverTemplateArray != null) hashCode = hashCode * 59 + HoverTemplateArray.GetHashCode();
                if (HoverOn != null) hashCode = hashCode * 59 + HoverOn.GetHashCode();
                if (XCalendar != null) hashCode = hashCode * 59 + XCalendar.GetHashCode();
                if (YCalendar != null) hashCode = hashCode * 59 + YCalendar.GetHashCode();
                if (XAxis != null) hashCode = hashCode * 59 + XAxis.GetHashCode();
                if (YAxis != null) hashCode = hashCode * 59 + YAxis.GetHashCode();
                if (IdsSrc != null) hashCode = hashCode * 59 + IdsSrc.GetHashCode();
                if (CustomDataSrc != null) hashCode = hashCode * 59 + CustomDataSrc.GetHashCode();
                if (MetaSrc != null) hashCode = hashCode * 59 + MetaSrc.GetHashCode();
                if (HoverInfoSrc != null) hashCode = hashCode * 59 + HoverInfoSrc.GetHashCode();
                if (YSrc != null) hashCode = hashCode * 59 + YSrc.GetHashCode();
                if (XSrc != null) hashCode = hashCode * 59 + XSrc.GetHashCode();
                if (Q1Src != null) hashCode = hashCode * 59 + Q1Src.GetHashCode();
                if (MedianSrc != null) hashCode = hashCode * 59 + MedianSrc.GetHashCode();
                if (Q3Src != null) hashCode = hashCode * 59 + Q3Src.GetHashCode();
                if (LowerFenceSrc != null) hashCode = hashCode * 59 + LowerFenceSrc.GetHashCode();
                if (UpperFenceSrc != null) hashCode = hashCode * 59 + UpperFenceSrc.GetHashCode();
                if (NotchSpanSrc != null) hashCode = hashCode * 59 + NotchSpanSrc.GetHashCode();
                if (MeanSrc != null) hashCode = hashCode * 59 + MeanSrc.GetHashCode();
                if (SdSrc != null) hashCode = hashCode * 59 + SdSrc.GetHashCode();
                if (TextSrc != null) hashCode = hashCode * 59 + TextSrc.GetHashCode();
                if (HoverTextSrc != null) hashCode = hashCode * 59 + HoverTextSrc.GetHashCode();
                if (HoverTemplateSrc != null) hashCode = hashCode * 59 + HoverTemplateSrc.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Box and the right Box.
        /// </summary>
        /// <param name="left">Left Box.</param>
        /// <param name="right">Right Box.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (Box left, Box right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Box and the right Box.
        /// </summary>
        /// <param name="left">Left Box.</param>
        /// <param name="right">Right Box.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (Box left, Box right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Box</returns>
        public Box DeepClone()
        {
            using MemoryStream ms = new();
            
            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;
            return JsonSerializer.DeserializeAsync<Box>(ms).Result;
        }
    }
}