using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Traces.Violins;

using Stream = Plotly.Models.Traces.Violins.Stream;

namespace Plotly.Models.Traces
{
    /// <summary>
    ///     The Violin class.
    ///     Implements the <see cref="ITrace" />.
    /// </summary>
    [JsonConverter(typeof(PlotlyConverter))]
    [Serializable]
    public class Violin : ITrace, IEquatable<Violin>
    {
        /// <inheritdoc/>
        [JsonPropertyName(@"type")]
        public TraceTypeEnum? Type { get; } = TraceTypeEnum.Violin;

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
        public string LegendGroup { get; set; }

        /// <summary>
        ///     Sets the opacity of the trace.
        /// </summary>
        [JsonPropertyName(@"opacity")]
        public JsNumber? Opacity { get; set; }

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
        ///     Array containing integer indices of selected points. Has an effect only
        ///     for traces that support selections. Note that an empty array means an empty
        ///     selection where the <c>unselected</c> are turned on for all points, whereas,
        ///     any other non-array values means no selection all where the <c>selected</c>
        ///     and <c>unselected</c> styles have no effect.
        /// </summary>
        [JsonPropertyName(@"selectedpoints")]
        public object SelectedPoints { get; set; }

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
        ///     Sets the y sample data or coordinates. See overview for more info.
        /// </summary>
        [JsonPropertyName(@"y")]
        public List<object> Y { get; set; }

        /// <summary>
        ///     Sets the x sample data or coordinates. See overview for more info.
        /// </summary>
        [JsonPropertyName(@"x")]
        public List<object> X { get; set; }

        /// <summary>
        ///     Sets the x coordinate for single-box traces or the starting coordinate for
        ///     multi-box traces set using q1/median/q3. See overview for more info.
        /// </summary>
        [JsonPropertyName(@"x0")]
        public object X0 { get; set; }

        /// <summary>
        ///     Sets the y coordinate for single-box traces or the starting coordinate for
        ///     multi-box traces set using q1/median/q3. See overview for more info.
        /// </summary>
        [JsonPropertyName(@"y0")]
        public object Y0 { get; set; }

        /// <summary>
        ///     Sets the trace name. The trace name appear as the legend item and on hover.
        ///     For violin traces, the name will also be used for the position coordinate,
        ///     if <c>x</c> and <c>x0</c> (<c>y</c> and <c>y0</c> if horizontal) are missing
        ///     and the position axis is categorical. Note that the trace name is also used
        ///     as a default value for attribute <c>scalegroup</c> (please see its description
        ///     for details).
        /// </summary>
        [JsonPropertyName(@"name")]
        public string Name { get; set; }

        /// <summary>
        ///     Sets the orientation of the violin(s). If <c>v</c> (<c>h</c>), the distribution
        ///     is visualized along the vertical (horizontal).
        /// </summary>
        [JsonPropertyName(@"orientation")]
        public OrientationEnum? Orientation { get; set; }

        /// <summary>
        ///     Sets the bandwidth used to compute the kernel density estimate. By default,
        ///     the bandwidth is determined by Silverman&#39;s rule of thumb.
        /// </summary>
        [JsonPropertyName(@"bandwidth")]
        public JsNumber? Bandwidth { get; set; }

        /// <summary>
        ///     If there are multiple violins that should be sized according to to some
        ///     metric (see <c>scalemode</c>), link them by providing a non-empty group
        ///     id here shared by every trace in the same group. If a violin&#39;s <c>width</c>
        ///     is undefined, <c>scalegroup</c> will default to the trace&#39;s name. In
        ///     this case, violins with the same names will be linked together
        /// </summary>
        [JsonPropertyName(@"scalegroup")]
        public string ScaleGroup { get; set; }

        /// <summary>
        ///     Sets the metric by which the width of each violin is determined.<c>width</c>
        ///     means each violin has the same (max) width<c>count</c> means the violins
        ///     are scaled by the number of sample points makingup each violin.
        /// </summary>
        [JsonPropertyName(@"scalemode")]
        public ScaleModeEnum? ScaleMode { get; set; }

        /// <summary>
        ///     Sets the method by which the span in data space where the density function
        ///     will be computed. <c>soft</c> means the span goes from the sample&#39;s
        ///     minimum value minus two bandwidths to the sample&#39;s maximum value plus
        ///     two bandwidths. <c>hard</c> means the span goes from the sample&#39;s minimum
        ///     to its maximum value. For custom span settings, use mode <c>manual</c> and
        ///     fill in the <c>span</c> attribute.
        /// </summary>
        [JsonPropertyName(@"spanmode")]
        public SpanModeEnum? SpanMode { get; set; }

        /// <summary>
        ///     Sets the span in data space for which the density function will be computed.
        ///     Has an effect only when <c>spanmode</c> is set to <c>manual</c>.
        /// </summary>
        [JsonPropertyName(@"span")]
        public List<object> Span { get; set; }

        /// <summary>
        ///     Gets or sets the Line.
        /// </summary>
        [JsonPropertyName(@"line")]
        public Line Line { get; set; }

        /// <summary>
        ///     Sets the fill color. Defaults to a half-transparent variant of the line
        ///     color, marker color, or marker line color, whichever is available.
        /// </summary>
        [JsonPropertyName(@"fillcolor")]
        public object FillColor { get; set; }

        /// <summary>
        ///     If <c>outliers</c>, only the sample points lying outside the whiskers are
        ///     shown If <c>suspectedoutliers</c>, the outlier points are shown and points
        ///     either less than 4<c>Q1-3</c>Q3 or greater than 4<c>Q3-3</c>Q1 are highlighted
        ///     (see <c>outliercolor</c>) If <c>all</c>, all sample points are shown If
        ///     <c>false</c>, only the violins are shown with no sample points. Defaults
        ///     to <c>suspectedoutliers</c> when <c>marker.outliercolor</c> or <c>marker.line.outliercolor</c>
        ///     is set, otherwise defaults to <c>outliers</c>.
        /// </summary>
        [JsonPropertyName(@"points")]
        public PointsEnum? Points { get; set; }

        /// <summary>
        ///     Sets the amount of jitter in the sample points drawn. If <c>0</c>, the sample
        ///     points align along the distribution axis. If <c>1</c>, the sample points
        ///     are drawn in a random jitter of width equal to the width of the violins.
        /// </summary>
        [JsonPropertyName(@"jitter")]
        public JsNumber? Jitter { get; set; }

        /// <summary>
        ///     Sets the position of the sample points in relation to the violins. If <c>0</c>,
        ///     the sample points are places over the center of the violins. Positive (negative)
        ///     values correspond to positions to the right (left) for vertical violins
        ///     and above (below) for horizontal violins.
        /// </summary>
        [JsonPropertyName(@"pointpos")]
        public JsNumber? PointPos { get; set; }

        /// <summary>
        ///     Sets the width of the violin in data coordinates. If <c>0</c> (default value)
        ///     the width is automatically selected based on the positions of other violin
        ///     traces in the same subplot.
        /// </summary>
        [JsonPropertyName(@"width")]
        public JsNumber? Width { get; set; }

        /// <summary>
        ///     Gets or sets the Marker.
        /// </summary>
        [JsonPropertyName(@"marker")]
        public Marker Marker { get; set; }

        /// <summary>
        ///     Sets the text elements associated with each sample value. If a single string,
        ///     the same string appears over all the data points. If an array of string,
        ///     the items are mapped in order to the this trace&#39;s (x,y) coordinates.
        ///     To be seen, trace <c>hoverinfo</c> must contain a <c>text</c> flag.
        /// </summary>
        [JsonPropertyName(@"text")]
        public string Text { get; set; }

        /// <summary>
        ///     Sets the text elements associated with each sample value. If a single string,
        ///     the same string appears over all the data points. If an array of string,
        ///     the items are mapped in order to the this trace&#39;s (x,y) coordinates.
        ///     To be seen, trace <c>hoverinfo</c> must contain a <c>text</c> flag.
        /// </summary>
        [JsonPropertyName(@"text")]
        [Array]
        public List<string> TextArray { get; set; }

        /// <summary>
        ///     Same as <c>text</c>.
        /// </summary>
        [JsonPropertyName(@"hovertext")]
        public string HoverText { get; set; }

        /// <summary>
        ///     Same as <c>text</c>.
        /// </summary>
        [JsonPropertyName(@"hovertext")]
        [Array]
        public List<string> HoverTextArray { get; set; }

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
        ///     that are &#39;arrayOk: true&#39;) are available.  Anything contained in
        ///     tag <c>&lt;extra&gt;</c> is displayed in the secondary box, for example
        ///     <c>&lt;extra&gt;{fullData.name}&lt;/extra&gt;</c>. To hide the secondary
        ///     box completely, use an empty tag <c>&lt;extra&gt;&lt;/extra&gt;</c>.
        /// </summary>
        [JsonPropertyName(@"hovertemplate")]
        [Array]
        public List<string> HoverTemplateArray { get; set; }

        /// <summary>
        ///     Gets or sets the Box.
        /// </summary>
        [JsonPropertyName(@"box")]
        public Violins.Box Box { get; set; }

        /// <summary>
        ///     Gets or sets the MeanLine.
        /// </summary>
        [JsonPropertyName(@"meanline")]
        public MeanLine MeanLine { get; set; }

        /// <summary>
        ///     Determines on which side of the position value the density function making
        ///     up one half of a violin is plotted. Useful when comparing two violin traces
        ///     under <c>overlay</c> mode, where one trace has <c>side</c> set to <c>positive</c>
        ///     and the other to <c>negative</c>.
        /// </summary>
        [JsonPropertyName(@"side")]
        public SideEnum? Side { get; set; }

        /// <summary>
        ///     Set several traces linked to the same position axis or matching axes to
        ///     the same offsetgroup where bars of the same position coordinate will line
        ///     up.
        /// </summary>
        [JsonPropertyName(@"offsetgroup")]
        public string OffsetGroup { get; set; }

        /// <summary>
        ///     Set several traces linked to the same position axis or matching axes to
        ///     the same alignmentgroup. This controls whether bars compute their positional
        ///     range dependently or independently.
        /// </summary>
        [JsonPropertyName(@"alignmentgroup")]
        public string AlignmentGroup { get; set; }

        /// <summary>
        ///     Gets or sets the Selected.
        /// </summary>
        [JsonPropertyName(@"selected")]
        public Selected Selected { get; set; }

        /// <summary>
        ///     Gets or sets the Unselected.
        /// </summary>
        [JsonPropertyName(@"unselected")]
        public Unselected Unselected { get; set; }

        /// <summary>
        ///     Do the hover effects highlight individual violins or sample points or the
        ///     kernel density estimate or any combination of them?
        /// </summary>
        [JsonPropertyName(@"hoveron")]
        public HoverOnFlag? HoverOn { get; set; }

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
        ///     Sets the source reference on Chart Studio Cloud for  y .
        /// </summary>
        [JsonPropertyName(@"ysrc")]
        public string YSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  x .
        /// </summary>
        [JsonPropertyName(@"xsrc")]
        public string XSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  text .
        /// </summary>
        [JsonPropertyName(@"textsrc")]
        public string TextSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  hovertext .
        /// </summary>
        [JsonPropertyName(@"hovertextsrc")]
        public string HoverTextSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  hovertemplate .
        /// </summary>
        [JsonPropertyName(@"hovertemplatesrc")]
        public string HoverTemplateSrc { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is Violin other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] Violin other)
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
                   (Equals(Y, other.Y) || Y != null && other.Y != null && Y.SequenceEqual(other.Y))                                                                               &&
                   (Equals(X, other.X) || X != null && other.X != null && X.SequenceEqual(other.X))                                                                               &&
                   (X0          == other.X0          && X0          != null && other.X0          != null && X0.Equals(other.X0))                                                  &&
                   (Y0          == other.Y0          && Y0          != null && other.Y0          != null && Y0.Equals(other.Y0))                                                  &&
                   (Name        == other.Name        && Name        != null && other.Name        != null && Name.Equals(other.Name))                                              &&
                   (Orientation == other.Orientation && Orientation != null && other.Orientation != null && Orientation.Equals(other.Orientation))                                &&
                   (Bandwidth   == other.Bandwidth   && Bandwidth   != null && other.Bandwidth   != null && Bandwidth.Equals(other.Bandwidth))                                    &&
                   (ScaleGroup  == other.ScaleGroup  && ScaleGroup  != null && other.ScaleGroup  != null && ScaleGroup.Equals(other.ScaleGroup))                                  &&
                   (ScaleMode   == other.ScaleMode   && ScaleMode   != null && other.ScaleMode   != null && ScaleMode.Equals(other.ScaleMode))                                    &&
                   (SpanMode    == other.SpanMode    && SpanMode    != null && other.SpanMode    != null && SpanMode.Equals(other.SpanMode))                                      &&
                   (Equals(Span, other.Span) || Span != null && other.Span != null && Span.SequenceEqual(other.Span))                                                             &&
                   (Line      == other.Line      && Line      != null && other.Line      != null && Line.Equals(other.Line))                                                      &&
                   (FillColor == other.FillColor && FillColor != null && other.FillColor != null && FillColor.Equals(other.FillColor))                                            &&
                   (Points    == other.Points    && Points    != null && other.Points    != null && Points.Equals(other.Points))                                                  &&
                   (Jitter    == other.Jitter    && Jitter    != null && other.Jitter    != null && Jitter.Equals(other.Jitter))                                                  &&
                   (PointPos  == other.PointPos  && PointPos  != null && other.PointPos  != null && PointPos.Equals(other.PointPos))                                              &&
                   (Width     == other.Width     && Width     != null && other.Width     != null && Width.Equals(other.Width))                                                    &&
                   (Marker    == other.Marker    && Marker    != null && other.Marker    != null && Marker.Equals(other.Marker))                                                  &&
                   (Text      == other.Text      && Text      != null && other.Text      != null && Text.Equals(other.Text))                                                      &&
                   (Equals(TextArray, other.TextArray) || TextArray != null && other.TextArray != null && TextArray.SequenceEqual(other.TextArray))                               &&
                   (HoverText == other.HoverText && HoverText != null && other.HoverText != null && HoverText.Equals(other.HoverText))                                            &&
                   (Equals(HoverTextArray, other.HoverTextArray) || HoverTextArray != null && other.HoverTextArray != null && HoverTextArray.SequenceEqual(other.HoverTextArray)) &&
                   (HoverTemplate == other.HoverTemplate && HoverTemplate != null && other.HoverTemplate != null && HoverTemplate.Equals(other.HoverTemplate))                    &&
                   (Equals(HoverTemplateArray, other.HoverTemplateArray) ||
                    HoverTemplateArray != null && other.HoverTemplateArray != null && HoverTemplateArray.SequenceEqual(other.HoverTemplateArray))                            &&
                   (Box              == other.Box              && Box              != null && other.Box              != null && Box.Equals(other.Box))                       &&
                   (MeanLine         == other.MeanLine         && MeanLine         != null && other.MeanLine         != null && MeanLine.Equals(other.MeanLine))             &&
                   (Side             == other.Side             && Side             != null && other.Side             != null && Side.Equals(other.Side))                     &&
                   (OffsetGroup      == other.OffsetGroup      && OffsetGroup      != null && other.OffsetGroup      != null && OffsetGroup.Equals(other.OffsetGroup))       &&
                   (AlignmentGroup   == other.AlignmentGroup   && AlignmentGroup   != null && other.AlignmentGroup   != null && AlignmentGroup.Equals(other.AlignmentGroup)) &&
                   (Selected         == other.Selected         && Selected         != null && other.Selected         != null && Selected.Equals(other.Selected))             &&
                   (Unselected       == other.Unselected       && Unselected       != null && other.Unselected       != null && Unselected.Equals(other.Unselected))         &&
                   (HoverOn          == other.HoverOn          && HoverOn          != null && other.HoverOn          != null && HoverOn.Equals(other.HoverOn))               &&
                   (XAxis            == other.XAxis            && XAxis            != null && other.XAxis            != null && XAxis.Equals(other.XAxis))                   &&
                   (YAxis            == other.YAxis            && YAxis            != null && other.YAxis            != null && YAxis.Equals(other.YAxis))                   &&
                   (IdsSrc           == other.IdsSrc           && IdsSrc           != null && other.IdsSrc           != null && IdsSrc.Equals(other.IdsSrc))                 &&
                   (CustomDataSrc    == other.CustomDataSrc    && CustomDataSrc    != null && other.CustomDataSrc    != null && CustomDataSrc.Equals(other.CustomDataSrc))   &&
                   (MetaSrc          == other.MetaSrc          && MetaSrc          != null && other.MetaSrc          != null && MetaSrc.Equals(other.MetaSrc))               &&
                   (HoverInfoSrc     == other.HoverInfoSrc     && HoverInfoSrc     != null && other.HoverInfoSrc     != null && HoverInfoSrc.Equals(other.HoverInfoSrc))     &&
                   (YSrc             == other.YSrc             && YSrc             != null && other.YSrc             != null && YSrc.Equals(other.YSrc))                     &&
                   (XSrc             == other.XSrc             && XSrc             != null && other.XSrc             != null && XSrc.Equals(other.XSrc))                     &&
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

                if(Y != null)
                    hashCode = hashCode * 59 + Y.GetHashCode();

                if(X != null)
                    hashCode = hashCode * 59 + X.GetHashCode();

                if(X0 != null)
                    hashCode = hashCode * 59 + X0.GetHashCode();

                if(Y0 != null)
                    hashCode = hashCode * 59 + Y0.GetHashCode();

                if(Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();

                if(Orientation != null)
                    hashCode = hashCode * 59 + Orientation.GetHashCode();

                if(Bandwidth != null)
                    hashCode = hashCode * 59 + Bandwidth.GetHashCode();

                if(ScaleGroup != null)
                    hashCode = hashCode * 59 + ScaleGroup.GetHashCode();

                if(ScaleMode != null)
                    hashCode = hashCode * 59 + ScaleMode.GetHashCode();

                if(SpanMode != null)
                    hashCode = hashCode * 59 + SpanMode.GetHashCode();

                if(Span != null)
                    hashCode = hashCode * 59 + Span.GetHashCode();

                if(Line != null)
                    hashCode = hashCode * 59 + Line.GetHashCode();

                if(FillColor != null)
                    hashCode = hashCode * 59 + FillColor.GetHashCode();

                if(Points != null)
                    hashCode = hashCode * 59 + Points.GetHashCode();

                if(Jitter != null)
                    hashCode = hashCode * 59 + Jitter.GetHashCode();

                if(PointPos != null)
                    hashCode = hashCode * 59 + PointPos.GetHashCode();

                if(Width != null)
                    hashCode = hashCode * 59 + Width.GetHashCode();

                if(Marker != null)
                    hashCode = hashCode * 59 + Marker.GetHashCode();

                if(Text != null)
                    hashCode = hashCode * 59 + Text.GetHashCode();

                if(TextArray != null)
                    hashCode = hashCode * 59 + TextArray.GetHashCode();

                if(HoverText != null)
                    hashCode = hashCode * 59 + HoverText.GetHashCode();

                if(HoverTextArray != null)
                    hashCode = hashCode * 59 + HoverTextArray.GetHashCode();

                if(HoverTemplate != null)
                    hashCode = hashCode * 59 + HoverTemplate.GetHashCode();

                if(HoverTemplateArray != null)
                    hashCode = hashCode * 59 + HoverTemplateArray.GetHashCode();

                if(Box != null)
                    hashCode = hashCode * 59 + Box.GetHashCode();

                if(MeanLine != null)
                    hashCode = hashCode * 59 + MeanLine.GetHashCode();

                if(Side != null)
                    hashCode = hashCode * 59 + Side.GetHashCode();

                if(OffsetGroup != null)
                    hashCode = hashCode * 59 + OffsetGroup.GetHashCode();

                if(AlignmentGroup != null)
                    hashCode = hashCode * 59 + AlignmentGroup.GetHashCode();

                if(Selected != null)
                    hashCode = hashCode * 59 + Selected.GetHashCode();

                if(Unselected != null)
                    hashCode = hashCode * 59 + Unselected.GetHashCode();

                if(HoverOn != null)
                    hashCode = hashCode * 59 + HoverOn.GetHashCode();

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

                if(YSrc != null)
                    hashCode = hashCode * 59 + YSrc.GetHashCode();

                if(XSrc != null)
                    hashCode = hashCode * 59 + XSrc.GetHashCode();

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
        ///     Checks for equality of the left Violin and the right Violin.
        /// </summary>
        /// <param name="left">Left Violin.</param>
        /// <param name="right">Right Violin.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(Violin left,
                                       Violin right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Violin and the right Violin.
        /// </summary>
        /// <param name="left">Left Violin.</param>
        /// <param name="right">Right Violin.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(Violin left,
                                       Violin right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Violin</returns>
        public Violin DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<Violin>(ms).Result;
        }
    }
}
