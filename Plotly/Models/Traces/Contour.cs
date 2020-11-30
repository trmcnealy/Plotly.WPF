

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Traces.Contours;

using Stream = Plotly.Models.Traces.Contours.Stream;

namespace Plotly.Models.Traces
{
    /// <summary>
    ///     The Contour class.
    ///     Implements the <see cref="ITrace" />.
    /// </summary>
    
    [JsonConverter(typeof(PlotlyConverter))]
    [Serializable]
    public class Contour : ITrace, IEquatable<Contour>
    {
        /// <inheritdoc/>
        [JsonPropertyName(@"type")]
        public TraceTypeEnum? Type { get; } = TraceTypeEnum.Contour;

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
        ///     Sets the trace name. The trace name appear as the legend item and on hover.
        /// </summary>
        [JsonPropertyName(@"name")]
        public string Name { get; set;} 

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
        ///     Sets the z data.
        /// </summary>
        [JsonPropertyName(@"z")]
        public List<object> Z { get; set;} 

        /// <summary>
        ///     Sets the x coordinates.
        /// </summary>
        [JsonPropertyName(@"x")]
        public List<object> X { get; set;} 

        /// <summary>
        ///     Alternate to <c>x</c>. Builds a linear space of x coordinates. Use with
        ///     <c>dx</c> where <c>x0</c> is the starting coordinate and <c>dx</c> the step.
        /// </summary>
        [JsonPropertyName(@"x0")]
        public object X0 { get; set;} 

        /// <summary>
        ///     Sets the x coordinate step. See <c>x0</c> for more info.
        /// </summary>
        [JsonPropertyName(@"dx")]
        public JsNumber? DX { get; set;} 

        /// <summary>
        ///     Sets the y coordinates.
        /// </summary>
        [JsonPropertyName(@"y")]
        public List<object> Y { get; set;} 

        /// <summary>
        ///     Alternate to <c>y</c>. Builds a linear space of y coordinates. Use with
        ///     <c>dy</c> where <c>y0</c> is the starting coordinate and <c>dy</c> the step.
        /// </summary>
        [JsonPropertyName(@"y0")]
        public object Y0 { get; set;} 

        /// <summary>
        ///     Sets the y coordinate step. See <c>y0</c> for more info.
        /// </summary>
        [JsonPropertyName(@"dy")]
        public JsNumber? Dy { get; set;} 

        /// <summary>
        ///     Sets the text elements associated with each z value.
        /// </summary>
        [JsonPropertyName(@"text")]
        public List<object> Text { get; set;} 

        /// <summary>
        ///     Same as <c>text</c>.
        /// </summary>
        [JsonPropertyName(@"hovertext")]
        public List<object> HoverText { get; set;} 

        /// <summary>
        ///     Transposes the z data.
        /// </summary>
        [JsonPropertyName(@"transpose")]
        public bool? Transpose { get; set;} 

        /// <summary>
        ///     If <c>array</c>, the heatmap&#39;s x coordinates are given by <c>x</c> (the
        ///     default behavior when <c>x</c> is provided). If <c>scaled</c>, the heatmap&#39;s
        ///     x coordinates are given by <c>x0</c> and <c>dx</c> (the default behavior
        ///     when <c>x</c> is not provided).
        /// </summary>
        [JsonPropertyName(@"xtype")]
        public XTypeEnum? XType { get; set;} 

        /// <summary>
        ///     If <c>array</c>, the heatmap&#39;s y coordinates are given by <c>y</c> (the
        ///     default behavior when <c>y</c> is provided) If <c>scaled</c>, the heatmap&#39;s
        ///     y coordinates are given by <c>y0</c> and <c>dy</c> (the default behavior
        ///     when <c>y</c> is not provided)
        /// </summary>
        [JsonPropertyName(@"ytype")]
        public YTypeEnum? YType { get; set;} 

        /// <summary>
        ///     Sets the hover text formatting rule using d3 formatting mini-languages which
        ///     are very similar to those in Python. See: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        /// </summary>
        [JsonPropertyName(@"zhoverformat")]
        public string ZHoverFormat { get; set;} 

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
        ///     Determines whether or not gaps (i.e. {nan} or missing values) in the <c>z</c>
        ///     data have hover labels associated with them.
        /// </summary>
        [JsonPropertyName(@"hoverongaps")]
        public bool? HoverOnGaps { get; set;} 

        /// <summary>
        ///     Determines whether or not gaps (i.e. {nan} or missing values) in the <c>z</c>
        ///     data are filled in. It is defaulted to true if <c>z</c> is a one dimensional
        ///     array otherwise it is defaulted to false.
        /// </summary>
        [JsonPropertyName(@"connectgaps")]
        public bool? ConnectGaps { get; set;} 

        /// <summary>
        ///     Sets the fill color if <c>contours.type</c> is <c>constraint</c>. Defaults
        ///     to a half-transparent variant of the line color, marker color, or marker
        ///     line color, whichever is available.
        /// </summary>
        [JsonPropertyName(@"fillcolor")]
        public object FillColor { get; set;} 

        /// <summary>
        ///     Determines whether or not the contour level attributes are picked by an
        ///     algorithm. If <c>true</c>, the number of contour levels can be set in <c>ncontours</c>.
        ///     If <c>false</c>, set the contour level attributes in <c>contours</c>.
        /// </summary>
        [JsonPropertyName(@"autocontour")]
        public bool? AutoContour { get; set;} 

        /// <summary>
        ///     Sets the maximum number of contour levels. The actual number of contours
        ///     will be chosen automatically to be less than or equal to the value of <c>ncontours</c>.
        ///     Has an effect only if <c>autocontour</c> is <c>true</c> or if <c>contours.size</c>
        ///     is missing.
        /// </summary>
        [JsonPropertyName(@"ncontours")]
        public int? NContours { get; set;} 

        /// <summary>
        ///     Gets or sets the Contours.
        /// </summary>
        [JsonPropertyName(@"contours")]
        public Contours.Contours Contours { get; set;} 

        /// <summary>
        ///     Gets or sets the Line.
        /// </summary>
        [JsonPropertyName(@"line")]
        public Line Line { get; set;} 

        /// <summary>
        ///     Determines whether or not the color domain is computed with respect to the
        ///     input data (here in <c>z</c>) or the bounds set in <c>zmin</c> and <c>zmax</c>
        ///      Defaults to <c>false</c> when <c>zmin</c> and <c>zmax</c> are set by the
        ///     user.
        /// </summary>
        [JsonPropertyName(@"zauto")]
        public bool? ZAuto { get; set;} 

        /// <summary>
        ///     Sets the lower bound of the color domain. Value should have the same units
        ///     as in <c>z</c> and if set, <c>zmax</c> must be set as well.
        /// </summary>
        [JsonPropertyName(@"zmin")]
        public JsNumber? ZMin { get; set;} 

        /// <summary>
        ///     Sets the upper bound of the color domain. Value should have the same units
        ///     as in <c>z</c> and if set, <c>zmin</c> must be set as well.
        /// </summary>
        [JsonPropertyName(@"zmax")]
        public JsNumber? ZMax { get; set;} 

        /// <summary>
        ///     Sets the mid-point of the color domain by scaling <c>zmin</c> and/or <c>zmax</c>
        ///     to be equidistant to this point. Value should have the same units as in
        ///     <c>z</c>. Has no effect when <c>zauto</c> is <c>false</c>.
        /// </summary>
        [JsonPropertyName(@"zmid")]
        public JsNumber? ZMid { get; set;} 

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
        public object ColorScale { get; set;} 

        /// <summary>
        ///     Determines whether the colorscale is a default palette (&#39;autocolorscale:
        ///     true&#39;) or the palette determined by <c>colorscale</c>. In case <c>colorscale</c>
        ///     is unspecified or <c>autocolorscale</c> is true, the default  palette will
        ///     be chosen according to whether numbers in the <c>color</c> array are all
        ///     positive, all negative or mixed.
        /// </summary>
        [JsonPropertyName(@"autocolorscale")]
        public bool? AutoColorScale { get; set;} 

        /// <summary>
        ///     Reverses the color mapping if true. If true, <c>zmin</c> will correspond
        ///     to the last color in the array and <c>zmax</c> will correspond to the first
        ///     color.
        /// </summary>
        [JsonPropertyName(@"reversescale")]
        public bool? ReverseScale { get; set;} 

        /// <summary>
        ///     Determines whether or not a colorbar is displayed for this trace.
        /// </summary>
        [JsonPropertyName(@"showscale")]
        public bool? ShowScale { get; set;} 

        /// <summary>
        ///     Gets or sets the ColorBar.
        /// </summary>
        [JsonPropertyName(@"colorbar")]
        public ColorBar ColorBar { get; set;} 

        /// <summary>
        ///     Sets a reference to a shared color axis. References to these shared color
        ///     axes are <c>coloraxis</c>, <c>coloraxis2</c>, <c>coloraxis3</c>, etc. Settings
        ///     for these shared color axes are set in the layout, under <c>layout.coloraxis</c>,
        ///     <c>layout.coloraxis2</c>, etc. Note that multiple color scales can be linked
        ///     to the same color axis.
        /// </summary>
        [JsonPropertyName(@"coloraxis")]
        public string ColorAxis { get; set;} 

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
        ///     Sets the source reference on Chart Studio Cloud for  z .
        /// </summary>
        [JsonPropertyName(@"zsrc")]
        public string ZSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  x .
        /// </summary>
        [JsonPropertyName(@"xsrc")]
        public string XSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  y .
        /// </summary>
        [JsonPropertyName(@"ysrc")]
        public string YSrc { get; set;} 

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
            if (!(obj is Contour other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        
        public bool Equals([AllowNull] Contour other)
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
                    Name == other.Name &&
                    Name != null && other.Name != null &&
                    Name.Equals(other.Name)
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
                    Equals(Z, other.Z) ||
                    Z != null && other.Z != null &&
                    Z.SequenceEqual(other.Z)
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
                    DX == other.DX &&
                    DX != null && other.DX != null &&
                    DX.Equals(other.DX)
                ) && 
                (
                    Equals(Y, other.Y) ||
                    Y != null && other.Y != null &&
                    Y.SequenceEqual(other.Y)
                ) &&
                (
                    Y0 == other.Y0 &&
                    Y0 != null && other.Y0 != null &&
                    Y0.Equals(other.Y0)
                ) && 
                (
                    Dy == other.Dy &&
                    Dy != null && other.Dy != null &&
                    Dy.Equals(other.Dy)
                ) && 
                (
                    Equals(Text, other.Text) ||
                    Text != null && other.Text != null &&
                    Text.SequenceEqual(other.Text)
                ) &&
                (
                    Equals(HoverText, other.HoverText) ||
                    HoverText != null && other.HoverText != null &&
                    HoverText.SequenceEqual(other.HoverText)
                ) &&
                (
                    Transpose == other.Transpose &&
                    Transpose != null && other.Transpose != null &&
                    Transpose.Equals(other.Transpose)
                ) && 
                (
                    XType == other.XType &&
                    XType != null && other.XType != null &&
                    XType.Equals(other.XType)
                ) && 
                (
                    YType == other.YType &&
                    YType != null && other.YType != null &&
                    YType.Equals(other.YType)
                ) && 
                (
                    ZHoverFormat == other.ZHoverFormat &&
                    ZHoverFormat != null && other.ZHoverFormat != null &&
                    ZHoverFormat.Equals(other.ZHoverFormat)
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
                    HoverOnGaps == other.HoverOnGaps &&
                    HoverOnGaps != null && other.HoverOnGaps != null &&
                    HoverOnGaps.Equals(other.HoverOnGaps)
                ) && 
                (
                    ConnectGaps == other.ConnectGaps &&
                    ConnectGaps != null && other.ConnectGaps != null &&
                    ConnectGaps.Equals(other.ConnectGaps)
                ) && 
                (
                    FillColor == other.FillColor &&
                    FillColor != null && other.FillColor != null &&
                    FillColor.Equals(other.FillColor)
                ) && 
                (
                    AutoContour == other.AutoContour &&
                    AutoContour != null && other.AutoContour != null &&
                    AutoContour.Equals(other.AutoContour)
                ) && 
                (
                    NContours == other.NContours &&
                    NContours != null && other.NContours != null &&
                    NContours.Equals(other.NContours)
                ) && 
                (
                    Contours == other.Contours &&
                    Contours != null && other.Contours != null &&
                    Contours.Equals(other.Contours)
                ) && 
                (
                    Line == other.Line &&
                    Line != null && other.Line != null &&
                    Line.Equals(other.Line)
                ) && 
                (
                    ZAuto == other.ZAuto &&
                    ZAuto != null && other.ZAuto != null &&
                    ZAuto.Equals(other.ZAuto)
                ) && 
                (
                    ZMin == other.ZMin &&
                    ZMin != null && other.ZMin != null &&
                    ZMin.Equals(other.ZMin)
                ) && 
                (
                    ZMax == other.ZMax &&
                    ZMax != null && other.ZMax != null &&
                    ZMax.Equals(other.ZMax)
                ) && 
                (
                    ZMid == other.ZMid &&
                    ZMid != null && other.ZMid != null &&
                    ZMid.Equals(other.ZMid)
                ) && 
                (
                    ColorScale == other.ColorScale &&
                    ColorScale != null && other.ColorScale != null &&
                    ColorScale.Equals(other.ColorScale)
                ) && 
                (
                    AutoColorScale == other.AutoColorScale &&
                    AutoColorScale != null && other.AutoColorScale != null &&
                    AutoColorScale.Equals(other.AutoColorScale)
                ) && 
                (
                    ReverseScale == other.ReverseScale &&
                    ReverseScale != null && other.ReverseScale != null &&
                    ReverseScale.Equals(other.ReverseScale)
                ) && 
                (
                    ShowScale == other.ShowScale &&
                    ShowScale != null && other.ShowScale != null &&
                    ShowScale.Equals(other.ShowScale)
                ) && 
                (
                    ColorBar == other.ColorBar &&
                    ColorBar != null && other.ColorBar != null &&
                    ColorBar.Equals(other.ColorBar)
                ) && 
                (
                    ColorAxis == other.ColorAxis &&
                    ColorAxis != null && other.ColorAxis != null &&
                    ColorAxis.Equals(other.ColorAxis)
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
                    ZSrc == other.ZSrc &&
                    ZSrc != null && other.ZSrc != null &&
                    ZSrc.Equals(other.ZSrc)
                ) && 
                (
                    XSrc == other.XSrc &&
                    XSrc != null && other.XSrc != null &&
                    XSrc.Equals(other.XSrc)
                ) && 
                (
                    YSrc == other.YSrc &&
                    YSrc != null && other.YSrc != null &&
                    YSrc.Equals(other.YSrc)
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
                if (Name != null) hashCode = hashCode * 59 + Name.GetHashCode();
                if (UId != null) hashCode = hashCode * 59 + UId.GetHashCode();
                if (Ids != null) hashCode = hashCode * 59 + Ids.GetHashCode();
                if (CustomData != null) hashCode = hashCode * 59 + CustomData.GetHashCode();
                if (Meta != null) hashCode = hashCode * 59 + Meta.GetHashCode();
                if (MetaArray != null) hashCode = hashCode * 59 + MetaArray.GetHashCode();
                if (HoverInfo != null) hashCode = hashCode * 59 + HoverInfo.GetHashCode();
                if (HoverInfoArray != null) hashCode = hashCode * 59 + HoverInfoArray.GetHashCode();
                if (HoverLabel != null) hashCode = hashCode * 59 + HoverLabel.GetHashCode();
                if (Stream != null) hashCode = hashCode * 59 + Stream.GetHashCode();
                if (Transforms != null) hashCode = hashCode * 59 + Transforms.GetHashCode();
                if (UiRevision != null) hashCode = hashCode * 59 + UiRevision.GetHashCode();
                if (Z != null) hashCode = hashCode * 59 + Z.GetHashCode();
                if (X != null) hashCode = hashCode * 59 + X.GetHashCode();
                if (X0 != null) hashCode = hashCode * 59 + X0.GetHashCode();
                if (DX != null) hashCode = hashCode * 59 + DX.GetHashCode();
                if (Y != null) hashCode = hashCode * 59 + Y.GetHashCode();
                if (Y0 != null) hashCode = hashCode * 59 + Y0.GetHashCode();
                if (Dy != null) hashCode = hashCode * 59 + Dy.GetHashCode();
                if (Text != null) hashCode = hashCode * 59 + Text.GetHashCode();
                if (HoverText != null) hashCode = hashCode * 59 + HoverText.GetHashCode();
                if (Transpose != null) hashCode = hashCode * 59 + Transpose.GetHashCode();
                if (XType != null) hashCode = hashCode * 59 + XType.GetHashCode();
                if (YType != null) hashCode = hashCode * 59 + YType.GetHashCode();
                if (ZHoverFormat != null) hashCode = hashCode * 59 + ZHoverFormat.GetHashCode();
                if (HoverTemplate != null) hashCode = hashCode * 59 + HoverTemplate.GetHashCode();
                if (HoverTemplateArray != null) hashCode = hashCode * 59 + HoverTemplateArray.GetHashCode();
                if (HoverOnGaps != null) hashCode = hashCode * 59 + HoverOnGaps.GetHashCode();
                if (ConnectGaps != null) hashCode = hashCode * 59 + ConnectGaps.GetHashCode();
                if (FillColor != null) hashCode = hashCode * 59 + FillColor.GetHashCode();
                if (AutoContour != null) hashCode = hashCode * 59 + AutoContour.GetHashCode();
                if (NContours != null) hashCode = hashCode * 59 + NContours.GetHashCode();
                if (Contours != null) hashCode = hashCode * 59 + Contours.GetHashCode();
                if (Line != null) hashCode = hashCode * 59 + Line.GetHashCode();
                if (ZAuto != null) hashCode = hashCode * 59 + ZAuto.GetHashCode();
                if (ZMin != null) hashCode = hashCode * 59 + ZMin.GetHashCode();
                if (ZMax != null) hashCode = hashCode * 59 + ZMax.GetHashCode();
                if (ZMid != null) hashCode = hashCode * 59 + ZMid.GetHashCode();
                if (ColorScale != null) hashCode = hashCode * 59 + ColorScale.GetHashCode();
                if (AutoColorScale != null) hashCode = hashCode * 59 + AutoColorScale.GetHashCode();
                if (ReverseScale != null) hashCode = hashCode * 59 + ReverseScale.GetHashCode();
                if (ShowScale != null) hashCode = hashCode * 59 + ShowScale.GetHashCode();
                if (ColorBar != null) hashCode = hashCode * 59 + ColorBar.GetHashCode();
                if (ColorAxis != null) hashCode = hashCode * 59 + ColorAxis.GetHashCode();
                if (XCalendar != null) hashCode = hashCode * 59 + XCalendar.GetHashCode();
                if (YCalendar != null) hashCode = hashCode * 59 + YCalendar.GetHashCode();
                if (XAxis != null) hashCode = hashCode * 59 + XAxis.GetHashCode();
                if (YAxis != null) hashCode = hashCode * 59 + YAxis.GetHashCode();
                if (IdsSrc != null) hashCode = hashCode * 59 + IdsSrc.GetHashCode();
                if (CustomDataSrc != null) hashCode = hashCode * 59 + CustomDataSrc.GetHashCode();
                if (MetaSrc != null) hashCode = hashCode * 59 + MetaSrc.GetHashCode();
                if (HoverInfoSrc != null) hashCode = hashCode * 59 + HoverInfoSrc.GetHashCode();
                if (ZSrc != null) hashCode = hashCode * 59 + ZSrc.GetHashCode();
                if (XSrc != null) hashCode = hashCode * 59 + XSrc.GetHashCode();
                if (YSrc != null) hashCode = hashCode * 59 + YSrc.GetHashCode();
                if (TextSrc != null) hashCode = hashCode * 59 + TextSrc.GetHashCode();
                if (HoverTextSrc != null) hashCode = hashCode * 59 + HoverTextSrc.GetHashCode();
                if (HoverTemplateSrc != null) hashCode = hashCode * 59 + HoverTemplateSrc.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Contour and the right Contour.
        /// </summary>
        /// <param name="left">Left Contour.</param>
        /// <param name="right">Right Contour.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (Contour left, Contour right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Contour and the right Contour.
        /// </summary>
        /// <param name="left">Left Contour.</param>
        /// <param name="right">Right Contour.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (Contour left, Contour right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Contour</returns>
        public Contour DeepClone()
        {
            using MemoryStream ms = new();
            
            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;
            return JsonSerializer.DeserializeAsync<Contour>(ms).Result;
        }
    }
}