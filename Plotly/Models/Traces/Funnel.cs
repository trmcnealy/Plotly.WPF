using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Traces.Funnels;

using Stream = Plotly.Models.Traces.Funnels.Stream;

namespace Plotly.Models.Traces
{
    /// <summary>
    ///     The Funnel class.
    ///     Implements the <see cref="ITrace" />.
    /// </summary>
    [JsonConverter(typeof(PlotlyConverter))]
    [Serializable]
    public class Funnel : ITrace, IEquatable<Funnel>
    {
        /// <inheritdoc/>
        [JsonPropertyName(@"type")]
        public TraceTypeEnum? Type { get; } = TraceTypeEnum.Funnel;

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
        ///     Sets the x coordinates.
        /// </summary>
        [JsonPropertyName(@"x")]
        public List<object>? X { get; set; }

        /// <summary>
        ///     Alternate to <c>x</c>. Builds a linear space of x coordinates. Use with
        ///     <c>dx</c> where <c>x0</c> is the starting coordinate and <c>dx</c> the step.
        /// </summary>
        [JsonPropertyName(@"x0")]
        public object? X0 { get; set; }

        /// <summary>
        ///     Sets the x coordinate step. See <c>x0</c> for more info.
        /// </summary>
        [JsonPropertyName(@"dx")]
        public JsNumber? DX { get; set; }

        /// <summary>
        ///     Sets the y coordinates.
        /// </summary>
        [JsonPropertyName(@"y")]
        public List<object>? Y { get; set; }

        /// <summary>
        ///     Alternate to <c>y</c>. Builds a linear space of y coordinates. Use with
        ///     <c>dy</c> where <c>y0</c> is the starting coordinate and <c>dy</c> the step.
        /// </summary>
        [JsonPropertyName(@"y0")]
        public object? Y0 { get; set; }

        /// <summary>
        ///     Sets the y coordinate step. See <c>y0</c> for more info.
        /// </summary>
        [JsonPropertyName(@"dy")]
        public JsNumber? Dy { get; set; }

        /// <summary>
        ///     Sets hover text elements associated with each (x,y) pair. If a single string,
        ///     the same string appears over all the data points. If an array of string,
        ///     the items are mapped in order to the this trace&#39;s (x,y) coordinates.
        ///     To be seen, trace <c>hoverinfo</c> must contain a <c>text</c> flag.
        /// </summary>
        [JsonPropertyName(@"hovertext")]
        public string? HoverText { get; set; }

        /// <summary>
        ///     Sets hover text elements associated with each (x,y) pair. If a single string,
        ///     the same string appears over all the data points. If an array of string,
        ///     the items are mapped in order to the this trace&#39;s (x,y) coordinates.
        ///     To be seen, trace <c>hoverinfo</c> must contain a <c>text</c> flag.
        /// </summary>
        [JsonPropertyName(@"hovertext")]
        [Array]
        public List<string>? HoverTextArray { get; set; }

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
        ///     that are &#39;arrayOk: true&#39;) are available. variables <c>percentInitial</c>,
        ///     <c>percentPrevious</c> and <c>percentTotal</c>. Anything contained in tag
        ///     <c>&lt;extra&gt;</c> is displayed in the secondary box, for example <c>&lt;extra&gt;{fullData.name}&lt;/extra&gt;</c>.
        ///     To hide the secondary box completely, use an empty tag <c>&lt;extra&gt;&lt;/extra&gt;</c>.
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
        ///     that are &#39;arrayOk: true&#39;) are available. variables <c>percentInitial</c>,
        ///     <c>percentPrevious</c> and <c>percentTotal</c>. Anything contained in tag
        ///     <c>&lt;extra&gt;</c> is displayed in the secondary box, for example <c>&lt;extra&gt;{fullData.name}&lt;/extra&gt;</c>.
        ///     To hide the secondary box completely, use an empty tag <c>&lt;extra&gt;&lt;/extra&gt;</c>.
        /// </summary>
        [JsonPropertyName(@"hovertemplate")]
        [Array]
        public List<string>? HoverTemplateArray { get; set; }

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
        ///     Determines which trace information appear on the graph. In the case of having
        ///     multiple funnels, percentages &amp; totals are computed separately (per
        ///     trace).
        /// </summary>
        [JsonPropertyName(@"textinfo")]
        public TextInfoFlag? TextInfo { get; set; }

        /// <summary>
        ///     Template string used for rendering the information text that appear on points.
        ///     Note that this will override <c>textinfo</c>. Variables are inserted using
        ///     %{variable}, for example &quot;y: %{y}&quot;. Numbers are formatted using
        ///     d3-format&#39;s syntax %{variable:d3-format}, for example &quot;Price: %{y:$.2f}&quot;.
        ///     https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        ///     for details on the formatting syntax. Dates are formatted using d3-time-format&#39;s
        ///     syntax %{variable|d3-time-format}, for example &quot;Day: %{2019-01-01|%A}&quot;.
        ///     https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format
        ///     for details on the date formatting syntax. Every attributes that can be
        ///     specified per-point (the ones that are &#39;arrayOk: true&#39;) are available.
        ///     variables <c>percentInitial</c>, <c>percentPrevious</c>, <c>percentTotal</c>,
        ///     <c>label</c> and <c>value</c>.
        /// </summary>
        [JsonPropertyName(@"texttemplate")]
        public string? TextTemplate { get; set; }

        /// <summary>
        ///     Template string used for rendering the information text that appear on points.
        ///     Note that this will override <c>textinfo</c>. Variables are inserted using
        ///     %{variable}, for example &quot;y: %{y}&quot;. Numbers are formatted using
        ///     d3-format&#39;s syntax %{variable:d3-format}, for example &quot;Price: %{y:$.2f}&quot;.
        ///     https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        ///     for details on the formatting syntax. Dates are formatted using d3-time-format&#39;s
        ///     syntax %{variable|d3-time-format}, for example &quot;Day: %{2019-01-01|%A}&quot;.
        ///     https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format
        ///     for details on the date formatting syntax. Every attributes that can be
        ///     specified per-point (the ones that are &#39;arrayOk: true&#39;) are available.
        ///     variables <c>percentInitial</c>, <c>percentPrevious</c>, <c>percentTotal</c>,
        ///     <c>label</c> and <c>value</c>.
        /// </summary>
        [JsonPropertyName(@"texttemplate")]
        [Array]
        public List<string>? TextTemplateArray { get; set; }

        /// <summary>
        ///     Sets text elements associated with each (x,y) pair. If a single string,
        ///     the same string appears over all the data points. If an array of string,
        ///     the items are mapped in order to the this trace&#39;s (x,y) coordinates.
        ///     If trace <c>hoverinfo</c> contains a <c>text</c> flag and <c>hovertext</c>
        ///     is not set, these elements will be seen in the hover labels.
        /// </summary>
        [JsonPropertyName(@"text")]
        public string? Text { get; set; }

        /// <summary>
        ///     Sets text elements associated with each (x,y) pair. If a single string,
        ///     the same string appears over all the data points. If an array of string,
        ///     the items are mapped in order to the this trace&#39;s (x,y) coordinates.
        ///     If trace <c>hoverinfo</c> contains a <c>text</c> flag and <c>hovertext</c>
        ///     is not set, these elements will be seen in the hover labels.
        /// </summary>
        [JsonPropertyName(@"text")]
        [Array]
        public List<string>? TextArray { get; set; }

        /// <summary>
        ///     Specifies the location of the <c>text</c>. <c>inside</c> positions <c>text</c>
        ///     inside, next to the bar end (rotated and scaled if needed). <c>outside</c>
        ///     positions <c>text</c> outside, next to the bar end (scaled if needed), unless
        ///     there is another bar stacked on this one, then the text gets pushed inside.
        ///     <c>auto</c> tries to position <c>text</c> inside the bar, but if the bar
        ///     is too small and no bar is stacked on this one the text is moved outside.
        /// </summary>
        [JsonPropertyName(@"textposition")]
        public TextPositionEnum? TextPosition { get; set; }

        /// <summary>
        ///     Specifies the location of the <c>text</c>. <c>inside</c> positions <c>text</c>
        ///     inside, next to the bar end (rotated and scaled if needed). <c>outside</c>
        ///     positions <c>text</c> outside, next to the bar end (scaled if needed), unless
        ///     there is another bar stacked on this one, then the text gets pushed inside.
        ///     <c>auto</c> tries to position <c>text</c> inside the bar, but if the bar
        ///     is too small and no bar is stacked on this one the text is moved outside.
        /// </summary>
        [JsonPropertyName(@"textposition")]
        [Array]
        public List<TextPositionEnum?>? TextPositionArray { get; set; }

        /// <summary>
        ///     Determines if texts are kept at center or start/end points in <c>textposition</c>
        ///     <c>inside</c> mode.
        /// </summary>
        [JsonPropertyName(@"insidetextanchor")]
        public InsideTextAnchorEnum? InsideTextAnchor { get; set; }

        /// <summary>
        ///     Sets the angle of the tick labels with respect to the bar. For example,
        ///     a <c>tickangle</c> of -90 draws the tick labels vertically. With <c>auto</c>
        ///     the texts may automatically be rotated to fit with the maximum size in bars.
        /// </summary>
        [JsonPropertyName(@"textangle")]
        public JsNumber? TextAngle { get; set; }

        /// <summary>
        ///     Sets the font used for <c>text</c>.
        /// </summary>
        [JsonPropertyName(@"textfont")]
        public TextFont? TextFont { get; set; }

        /// <summary>
        ///     Sets the font used for <c>text</c> lying inside the bar.
        /// </summary>
        [JsonPropertyName(@"insidetextfont")]
        public InsideTextFont? InsideTextFont { get; set; }

        /// <summary>
        ///     Sets the font used for <c>text</c> lying outside the bar.
        /// </summary>
        [JsonPropertyName(@"outsidetextfont")]
        public OutsideTextFont? OutsideTextFont { get; set; }

        /// <summary>
        ///     Constrain the size of text inside or outside a bar to be no larger than
        ///     the bar itself.
        /// </summary>
        [JsonPropertyName(@"constraintext")]
        public ConstrainTextEnum? ConstrainText { get; set; }

        /// <summary>
        ///     Determines whether the text nodes are clipped about the subplot axes. To
        ///     show the text nodes above axis lines and tick labels, make sure to set <c>xaxis.layer</c>
        ///     and <c>yaxis.layer</c> to &#39;below traces&#39;.
        /// </summary>
        [JsonPropertyName(@"cliponaxis")]
        public bool? ClipOnAxis { get; set; }

        /// <summary>
        ///     Sets the orientation of the funnels. With <c>v</c> (<c>h</c>), the value
        ///     of the each bar spans along the vertical (horizontal). By default funnels
        ///     are tend to be oriented horizontally; unless only <c>y</c> array is presented
        ///     or orientation is set to <c>v</c>. Also regarding graphs including only
        ///     <c>horizontal</c> funnels, <c>autorange</c> on the <c>y-axis</c> are set
        ///     to <c>reversed</c>.
        /// </summary>
        [JsonPropertyName(@"orientation")]
        public OrientationEnum? Orientation { get; set; }

        /// <summary>
        ///     Shifts the position where the bar is drawn (in position axis units). In
        ///     <c>group</c> barmode, traces that set <c>offset</c> will be excluded and
        ///     drawn in <c>overlay</c> mode instead.
        /// </summary>
        [JsonPropertyName(@"offset")]
        public JsNumber? Offset { get; set; }

        /// <summary>
        ///     Sets the bar width (in position axis units).
        /// </summary>
        [JsonPropertyName(@"width")]
        public JsNumber? Width { get; set; }

        /// <summary>
        ///     Gets or sets the Marker.
        /// </summary>
        [JsonPropertyName(@"marker")]
        public Marker? Marker { get; set; }

        /// <summary>
        ///     Gets or sets the Connector.
        /// </summary>
        [JsonPropertyName(@"connector")]
        public Connector? Connector { get; set; }

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
        ///     Sets the source reference on Chart Studio Cloud for  hovertext .
        /// </summary>
        [JsonPropertyName(@"hovertextsrc")]
        public string? HoverTextSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  hovertemplate .
        /// </summary>
        [JsonPropertyName(@"hovertemplatesrc")]
        public string? HoverTemplateSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  hoverinfo .
        /// </summary>
        [JsonPropertyName(@"hoverinfosrc")]
        public string? HoverInfoSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  texttemplate .
        /// </summary>
        [JsonPropertyName(@"texttemplatesrc")]
        public string? TextTemplateSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  text .
        /// </summary>
        [JsonPropertyName(@"textsrc")]
        public string? TextSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  textposition .
        /// </summary>
        [JsonPropertyName(@"textpositionsrc")]
        public string? TextPositionSrc { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is Funnel other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] Funnel other)
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
                   (HoverLabel     == other.HoverLabel     && HoverLabel     != null && other.HoverLabel     != null && HoverLabel.Equals(other.HoverLabel))                      &&
                   (Stream         == other.Stream         && Stream         != null && other.Stream         != null && Stream.Equals(other.Stream))                              &&
                   (Equals(Transforms, other.Transforms) || Transforms != null && other.Transforms != null && Transforms.SequenceEqual(other.Transforms))                         &&
                   (UiRevision == other.UiRevision && UiRevision != null && other.UiRevision != null && UiRevision.Equals(other.UiRevision))                                      &&
                   (Equals(X, other.X) || X != null && other.X != null && X.SequenceEqual(other.X))                                                                               &&
                   (X0 == other.X0 && X0 != null && other.X0 != null && X0.Equals(other.X0))                                                                                      &&
                   (DX == other.DX && DX != null && other.DX != null && DX.Equals(other.DX))                                                                                      &&
                   (Equals(Y, other.Y) || Y != null && other.Y != null && Y.SequenceEqual(other.Y))                                                                               &&
                   (Y0        == other.Y0        && Y0        != null && other.Y0        != null && Y0.Equals(other.Y0))                                                          &&
                   (Dy        == other.Dy        && Dy        != null && other.Dy        != null && Dy.Equals(other.Dy))                                                          &&
                   (HoverText == other.HoverText && HoverText != null && other.HoverText != null && HoverText.Equals(other.HoverText))                                            &&
                   (Equals(HoverTextArray, other.HoverTextArray) || HoverTextArray != null && other.HoverTextArray != null && HoverTextArray.SequenceEqual(other.HoverTextArray)) &&
                   (HoverTemplate == other.HoverTemplate && HoverTemplate != null && other.HoverTemplate != null && HoverTemplate.Equals(other.HoverTemplate))                    &&
                   (Equals(HoverTemplateArray, other.HoverTemplateArray) ||
                    HoverTemplateArray != null && other.HoverTemplateArray != null && HoverTemplateArray.SequenceEqual(other.HoverTemplateArray))                                                   &&
                   (HoverInfo == other.HoverInfo && HoverInfo != null && other.HoverInfo != null && HoverInfo.Equals(other.HoverInfo))                                                              &&
                   (Equals(HoverInfoArray, other.HoverInfoArray) || HoverInfoArray != null && other.HoverInfoArray != null && HoverInfoArray.SequenceEqual(other.HoverInfoArray))                   &&
                   (TextInfo     == other.TextInfo     && TextInfo     != null && other.TextInfo     != null && TextInfo.Equals(other.TextInfo))                                                    &&
                   (TextTemplate == other.TextTemplate && TextTemplate != null && other.TextTemplate != null && TextTemplate.Equals(other.TextTemplate))                                            &&
                   (Equals(TextTemplateArray, other.TextTemplateArray) || TextTemplateArray != null && other.TextTemplateArray != null && TextTemplateArray.SequenceEqual(other.TextTemplateArray)) &&
                   (Text == other.Text && Text != null && other.Text != null && Text.Equals(other.Text))                                                                                            &&
                   (Equals(TextArray, other.TextArray) || TextArray != null && other.TextArray != null && TextArray.SequenceEqual(other.TextArray))                                                 &&
                   (TextPosition == other.TextPosition && TextPosition != null && other.TextPosition != null && TextPosition.Equals(other.TextPosition))                                            &&
                   (Equals(TextPositionArray, other.TextPositionArray) || TextPositionArray != null && other.TextPositionArray != null && TextPositionArray.SequenceEqual(other.TextPositionArray)) &&
                   (InsideTextAnchor == other.InsideTextAnchor && InsideTextAnchor != null && other.InsideTextAnchor != null && InsideTextAnchor.Equals(other.InsideTextAnchor))                    &&
                   (TextAngle        == other.TextAngle        && TextAngle        != null && other.TextAngle        != null && TextAngle.Equals(other.TextAngle))                                  &&
                   (TextFont         == other.TextFont         && TextFont         != null && other.TextFont         != null && TextFont.Equals(other.TextFont))                                    &&
                   (InsideTextFont   == other.InsideTextFont   && InsideTextFont   != null && other.InsideTextFont   != null && InsideTextFont.Equals(other.InsideTextFont))                        &&
                   (OutsideTextFont  == other.OutsideTextFont  && OutsideTextFont  != null && other.OutsideTextFont  != null && OutsideTextFont.Equals(other.OutsideTextFont))                      &&
                   (ConstrainText    == other.ConstrainText    && ConstrainText    != null && other.ConstrainText    != null && ConstrainText.Equals(other.ConstrainText))                          &&
                   (ClipOnAxis       == other.ClipOnAxis       && ClipOnAxis       != null && other.ClipOnAxis       != null && ClipOnAxis.Equals(other.ClipOnAxis))                                &&
                   (Orientation      == other.Orientation      && Orientation      != null && other.Orientation      != null && Orientation.Equals(other.Orientation))                              &&
                   (Offset           == other.Offset           && Offset           != null && other.Offset           != null && Offset.Equals(other.Offset))                                        &&
                   (Width            == other.Width            && Width            != null && other.Width            != null && Width.Equals(other.Width))                                          &&
                   (Marker           == other.Marker           && Marker           != null && other.Marker           != null && Marker.Equals(other.Marker))                                        &&
                   (Connector        == other.Connector        && Connector        != null && other.Connector        != null && Connector.Equals(other.Connector))                                  &&
                   (OffsetGroup      == other.OffsetGroup      && OffsetGroup      != null && other.OffsetGroup      != null && OffsetGroup.Equals(other.OffsetGroup))                              &&
                   (AlignmentGroup   == other.AlignmentGroup   && AlignmentGroup   != null && other.AlignmentGroup   != null && AlignmentGroup.Equals(other.AlignmentGroup))                        &&
                   (XAxis            == other.XAxis            && XAxis            != null && other.XAxis            != null && XAxis.Equals(other.XAxis))                                          &&
                   (YAxis            == other.YAxis            && YAxis            != null && other.YAxis            != null && YAxis.Equals(other.YAxis))                                          &&
                   (IdsSrc           == other.IdsSrc           && IdsSrc           != null && other.IdsSrc           != null && IdsSrc.Equals(other.IdsSrc))                                        &&
                   (CustomDataSrc    == other.CustomDataSrc    && CustomDataSrc    != null && other.CustomDataSrc    != null && CustomDataSrc.Equals(other.CustomDataSrc))                          &&
                   (MetaSrc          == other.MetaSrc          && MetaSrc          != null && other.MetaSrc          != null && MetaSrc.Equals(other.MetaSrc))                                      &&
                   (XSrc             == other.XSrc             && XSrc             != null && other.XSrc             != null && XSrc.Equals(other.XSrc))                                            &&
                   (YSrc             == other.YSrc             && YSrc             != null && other.YSrc             != null && YSrc.Equals(other.YSrc))                                            &&
                   (HoverTextSrc     == other.HoverTextSrc     && HoverTextSrc     != null && other.HoverTextSrc     != null && HoverTextSrc.Equals(other.HoverTextSrc))                            &&
                   (HoverTemplateSrc == other.HoverTemplateSrc && HoverTemplateSrc != null && other.HoverTemplateSrc != null && HoverTemplateSrc.Equals(other.HoverTemplateSrc))                    &&
                   (HoverInfoSrc     == other.HoverInfoSrc     && HoverInfoSrc     != null && other.HoverInfoSrc     != null && HoverInfoSrc.Equals(other.HoverInfoSrc))                            &&
                   (TextTemplateSrc  == other.TextTemplateSrc  && TextTemplateSrc  != null && other.TextTemplateSrc  != null && TextTemplateSrc.Equals(other.TextTemplateSrc))                      &&
                   (TextSrc          == other.TextSrc          && TextSrc          != null && other.TextSrc          != null && TextSrc.Equals(other.TextSrc))                                      &&
                   (TextPositionSrc  == other.TextPositionSrc  && TextPositionSrc  != null && other.TextPositionSrc  != null && TextPositionSrc.Equals(other.TextPositionSrc));
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

                if(X0 != null)
                    hashCode = hashCode * 59 + X0.GetHashCode();

                if(DX != null)
                    hashCode = hashCode * 59 + DX.GetHashCode();

                if(Y != null)
                    hashCode = hashCode * 59 + Y.GetHashCode();

                if(Y0 != null)
                    hashCode = hashCode * 59 + Y0.GetHashCode();

                if(Dy != null)
                    hashCode = hashCode * 59 + Dy.GetHashCode();

                if(HoverText != null)
                    hashCode = hashCode * 59 + HoverText.GetHashCode();

                if(HoverTextArray != null)
                    hashCode = hashCode * 59 + HoverTextArray.GetHashCode();

                if(HoverTemplate != null)
                    hashCode = hashCode * 59 + HoverTemplate.GetHashCode();

                if(HoverTemplateArray != null)
                    hashCode = hashCode * 59 + HoverTemplateArray.GetHashCode();

                if(HoverInfo != null)
                    hashCode = hashCode * 59 + HoverInfo.GetHashCode();

                if(HoverInfoArray != null)
                    hashCode = hashCode * 59 + HoverInfoArray.GetHashCode();

                if(TextInfo != null)
                    hashCode = hashCode * 59 + TextInfo.GetHashCode();

                if(TextTemplate != null)
                    hashCode = hashCode * 59 + TextTemplate.GetHashCode();

                if(TextTemplateArray != null)
                    hashCode = hashCode * 59 + TextTemplateArray.GetHashCode();

                if(Text != null)
                    hashCode = hashCode * 59 + Text.GetHashCode();

                if(TextArray != null)
                    hashCode = hashCode * 59 + TextArray.GetHashCode();

                if(TextPosition != null)
                    hashCode = hashCode * 59 + TextPosition.GetHashCode();

                if(TextPositionArray != null)
                    hashCode = hashCode * 59 + TextPositionArray.GetHashCode();

                if(InsideTextAnchor != null)
                    hashCode = hashCode * 59 + InsideTextAnchor.GetHashCode();

                if(TextAngle != null)
                    hashCode = hashCode * 59 + TextAngle.GetHashCode();

                if(TextFont != null)
                    hashCode = hashCode * 59 + TextFont.GetHashCode();

                if(InsideTextFont != null)
                    hashCode = hashCode * 59 + InsideTextFont.GetHashCode();

                if(OutsideTextFont != null)
                    hashCode = hashCode * 59 + OutsideTextFont.GetHashCode();

                if(ConstrainText != null)
                    hashCode = hashCode * 59 + ConstrainText.GetHashCode();

                if(ClipOnAxis != null)
                    hashCode = hashCode * 59 + ClipOnAxis.GetHashCode();

                if(Orientation != null)
                    hashCode = hashCode * 59 + Orientation.GetHashCode();

                if(Offset != null)
                    hashCode = hashCode * 59 + Offset.GetHashCode();

                if(Width != null)
                    hashCode = hashCode * 59 + Width.GetHashCode();

                if(Marker != null)
                    hashCode = hashCode * 59 + Marker.GetHashCode();

                if(Connector != null)
                    hashCode = hashCode * 59 + Connector.GetHashCode();

                if(OffsetGroup != null)
                    hashCode = hashCode * 59 + OffsetGroup.GetHashCode();

                if(AlignmentGroup != null)
                    hashCode = hashCode * 59 + AlignmentGroup.GetHashCode();

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

                if(XSrc != null)
                    hashCode = hashCode * 59 + XSrc.GetHashCode();

                if(YSrc != null)
                    hashCode = hashCode * 59 + YSrc.GetHashCode();

                if(HoverTextSrc != null)
                    hashCode = hashCode * 59 + HoverTextSrc.GetHashCode();

                if(HoverTemplateSrc != null)
                    hashCode = hashCode * 59 + HoverTemplateSrc.GetHashCode();

                if(HoverInfoSrc != null)
                    hashCode = hashCode * 59 + HoverInfoSrc.GetHashCode();

                if(TextTemplateSrc != null)
                    hashCode = hashCode * 59 + TextTemplateSrc.GetHashCode();

                if(TextSrc != null)
                    hashCode = hashCode * 59 + TextSrc.GetHashCode();

                if(TextPositionSrc != null)
                    hashCode = hashCode * 59 + TextPositionSrc.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Funnel and the right Funnel.
        /// </summary>
        /// <param name="left">Left Funnel.</param>
        /// <param name="right">Right Funnel.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(Funnel left,
                                       Funnel right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Funnel and the right Funnel.
        /// </summary>
        /// <param name="left">Left Funnel.</param>
        /// <param name="right">Right Funnel.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(Funnel left,
                                       Funnel right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Funnel</returns>
        public Funnel DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<Funnel>(ms).Result;
        }
    }
}
