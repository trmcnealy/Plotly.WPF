using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Traces.Mesh3Ds;

using Stream = Plotly.Models.Traces.Mesh3Ds.Stream;

namespace Plotly.Models.Traces
{
    /// <summary>
    ///     The Mesh3D class.
    ///     Implements the <see cref="ITrace" />.
    /// </summary>
    [JsonConverter(typeof(PlotlyConverter))]
    [Serializable]
    public class Mesh3D : ITrace, IEquatable<Mesh3D>
    {
        /// <inheritdoc/>
        [JsonPropertyName(@"type")]
        public TraceTypeEnum? Type { get; } = TraceTypeEnum.Mesh3D;

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
        ///     Sets the X coordinates of the vertices. The nth element of vectors <c>x</c>,
        ///     <c>y</c> and <c>z</c> jointly represent the X, Y and Z coordinates of the
        ///     nth vertex.
        /// </summary>
        [JsonPropertyName(@"x")]
        public List<object> X { get; set; }

        /// <summary>
        ///     Sets the Y coordinates of the vertices. The nth element of vectors <c>x</c>,
        ///     <c>y</c> and <c>z</c> jointly represent the X, Y and Z coordinates of the
        ///     nth vertex.
        /// </summary>
        [JsonPropertyName(@"y")]
        public List<object> Y { get; set; }

        /// <summary>
        ///     Sets the Z coordinates of the vertices. The nth element of vectors <c>x</c>,
        ///     <c>y</c> and <c>z</c> jointly represent the X, Y and Z coordinates of the
        ///     nth vertex.
        /// </summary>
        [JsonPropertyName(@"z")]
        public List<object> Z { get; set; }

        /// <summary>
        ///     A vector of vertex indices, i.e. integer values between 0 and the length
        ///     of the vertex vectors, representing the <c>first</c> vertex of a triangle.
        ///     For example, &#39;{i[m], j[m], k[m]}&#39; together represent face m (triangle
        ///     m) in the mesh, where &#39;i[m] = n&#39; points to the triplet &#39;{x[n],
        ///     y[n], z[n]}&#39; in the vertex arrays. Therefore, each element in <c>i</c>
        ///     represents a point in space, which is the first vertex of a triangle.
        /// </summary>
        [JsonPropertyName(@"i")]
        public List<object> I { get; set; }

        /// <summary>
        ///     A vector of vertex indices, i.e. integer values between 0 and the length
        ///     of the vertex vectors, representing the <c>second</c> vertex of a triangle.
        ///     For example, &#39;{i[m], j[m], k[m]}&#39;  together represent face m (triangle
        ///     m) in the mesh, where &#39;j[m] = n&#39; points to the triplet &#39;{x[n],
        ///     y[n], z[n]}&#39; in the vertex arrays. Therefore, each element in <c>j</c>
        ///     represents a point in space, which is the second vertex of a triangle.
        /// </summary>
        [JsonPropertyName(@"j")]
        public List<object> J { get; set; }

        /// <summary>
        ///     A vector of vertex indices, i.e. integer values between 0 and the length
        ///     of the vertex vectors, representing the <c>third</c> vertex of a triangle.
        ///     For example, &#39;{i[m], j[m], k[m]}&#39; together represent face m (triangle
        ///     m) in the mesh, where &#39;k[m] = n&#39; points to the triplet  &#39;{x[n],
        ///     y[n], z[n]}&#39; in the vertex arrays. Therefore, each element in <c>k</c>
        ///     represents a point in space, which is the third vertex of a triangle.
        /// </summary>
        [JsonPropertyName(@"k")]
        public List<object> K { get; set; }

        /// <summary>
        ///     Sets the text elements associated with the vertices. If trace <c>hoverinfo</c>
        ///     contains a <c>text</c> flag and <c>hovertext</c> is not set, these elements
        ///     will be seen in the hover labels.
        /// </summary>
        [JsonPropertyName(@"text")]
        public string Text { get; set; }

        /// <summary>
        ///     Sets the text elements associated with the vertices. If trace <c>hoverinfo</c>
        ///     contains a <c>text</c> flag and <c>hovertext</c> is not set, these elements
        ///     will be seen in the hover labels.
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
        ///     Sets the Delaunay axis, which is the axis that is perpendicular to the surface
        ///     of the Delaunay triangulation. It has an effect if <c>i</c>, <c>j</c>, <c>k</c>
        ///     are not provided and <c>alphahull</c> is set to indicate Delaunay triangulation.
        /// </summary>
        [JsonPropertyName(@"delaunayaxis")]
        public DelaunaYAxisEnum? DelaunaYAxis { get; set; }

        /// <summary>
        ///     Determines how the mesh surface triangles are derived from the set of vertices
        ///     (points) represented by the <c>x</c>, <c>y</c> and <c>z</c> arrays, if the
        ///     <c>i</c>, <c>j</c>, <c>k</c> arrays are not supplied. For general use of
        ///     <c>mesh3d</c> it is preferred that <c>i</c>, <c>j</c>, <c>k</c> are supplied.
        ///     If <c>-1</c>, Delaunay triangulation is used, which is mainly suitable if
        ///     the mesh is a single, more or less layer surface that is perpendicular to
        ///     <c>delaunayaxis</c>. In case the <c>delaunayaxis</c> intersects the mesh
        ///     surface at more than one point it will result triangles that are very long
        ///     in the dimension of <c>delaunayaxis</c>. If <c>&gt;0</c>, the alpha-shape
        ///     algorithm is used. In this case, the positive <c>alphahull</c> value signals
        ///     the use of the alpha-shape algorithm, _and_ its value acts as the parameter
        ///     for the mesh fitting. If <c>0</c>,  the convex-hull algorithm is used. It
        ///     is suitable for convex bodies or if the intention is to enclose the <c>x</c>,
        ///     <c>y</c> and <c>z</c> point set into a convex hull.
        /// </summary>
        [JsonPropertyName(@"alphahull")]
        public JsNumber? AlphaHull { get; set; }

        /// <summary>
        ///     Sets the intensity values for vertices or cells as defined by <c>intensitymode</c>.
        ///     It can be used for plotting fields on meshes.
        /// </summary>
        [JsonPropertyName(@"intensity")]
        public List<object> Intensity { get; set; }

        /// <summary>
        ///     Determines the source of <c>intensity</c> values.
        /// </summary>
        [JsonPropertyName(@"intensitymode")]
        public IntensityModeEnum? IntensityMode { get; set; }

        /// <summary>
        ///     Sets the color of the whole mesh
        /// </summary>
        [JsonPropertyName(@"color")]
        public object Color { get; set; }

        /// <summary>
        ///     Sets the color of each vertex Overrides <c>color</c>. While Red, green and
        ///     blue colors are in the range of 0 and 255; in the case of having vertex
        ///     color data in RGBA format, the alpha color should be normalized to be between
        ///     0 and 1.
        /// </summary>
        [JsonPropertyName(@"vertexcolor")]
        public List<object> VertexColor { get; set; }

        /// <summary>
        ///     Sets the color of each face Overrides <c>color</c> and <c>vertexcolor</c>.
        /// </summary>
        [JsonPropertyName(@"facecolor")]
        public List<object> FaceColor { get; set; }

        /// <summary>
        ///     Determines whether or not the color domain is computed with respect to the
        ///     input data (here <c>intensity</c>) or the bounds set in <c>cmin</c> and
        ///     <c>cmax</c>  Defaults to <c>false</c> when <c>cmin</c> and <c>cmax</c> are
        ///     set by the user.
        /// </summary>
        [JsonPropertyName(@"cauto")]
        public bool? CAuto { get; set; }

        /// <summary>
        ///     Sets the lower bound of the color domain. Value should have the same units
        ///     as <c>intensity</c> and if set, <c>cmax</c> must be set as well.
        /// </summary>
        [JsonPropertyName(@"cmin")]
        public JsNumber? CMin { get; set; }

        /// <summary>
        ///     Sets the upper bound of the color domain. Value should have the same units
        ///     as <c>intensity</c> and if set, <c>cmin</c> must be set as well.
        /// </summary>
        [JsonPropertyName(@"cmax")]
        public JsNumber? CMax { get; set; }

        /// <summary>
        ///     Sets the mid-point of the color domain by scaling <c>cmin</c> and/or <c>cmax</c>
        ///     to be equidistant to this point. Value should have the same units as <c>intensity</c>.
        ///     Has no effect when <c>cauto</c> is <c>false</c>.
        /// </summary>
        [JsonPropertyName(@"cmid")]
        public JsNumber? CMid { get; set; }

        /// <summary>
        ///     Sets the colorscale. The colorscale must be an array containing arrays mapping
        ///     a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string.
        ///     At minimum, a mapping for the lowest (0) and highest (1) values are required.
        ///     For example, &#39;[[0, <c>rgb(0,0,255)</c>], [1, <c>rgb(255,0,0)</c>]]&#39;.
        ///     To control the bounds of the colorscale in color space, use<c>cmin</c> and
        ///     <c>cmax</c>. Alternatively, <c>colorscale</c> may be a palette name string
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
        ///     Reverses the color mapping if true. If true, <c>cmin</c> will correspond
        ///     to the last color in the array and <c>cmax</c> will correspond to the first
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
        ///     Sets the opacity of the surface. Please note that in the case of using high
        ///     <c>opacity</c> values for example a value greater than or equal to 0.5 on
        ///     two surfaces (and 0.25 with four surfaces), an overlay of multiple transparent
        ///     surfaces may not perfectly be sorted in depth by the webgl API. This behavior
        ///     may be improved in the near future and is subject to change.
        /// </summary>
        [JsonPropertyName(@"opacity")]
        public JsNumber? Opacity { get; set; }

        /// <summary>
        ///     Determines whether or not normal smoothing is applied to the meshes, creating
        ///     meshes with an angular, low-poly look via flat reflections.
        /// </summary>
        [JsonPropertyName(@"flatshading")]
        public bool? FlatShading { get; set; }

        /// <summary>
        ///     Gets or sets the Contour.
        /// </summary>
        [JsonPropertyName(@"contour")]
        public Mesh3Ds.Contour Contour { get; set; }

        /// <summary>
        ///     Gets or sets the LightPosition.
        /// </summary>
        [JsonPropertyName(@"lightposition")]
        public LightPosition LightPosition { get; set; }

        /// <summary>
        ///     Gets or sets the Lighting.
        /// </summary>
        [JsonPropertyName(@"lighting")]
        public Lighting Lighting { get; set; }

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
        ///     Determines whether or not an item corresponding to this trace is shown in
        ///     the legend.
        /// </summary>
        [JsonPropertyName(@"showlegend")]
        public bool? ShowLegend { get; set; }

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
        ///     Sets the calendar system to use with <c>z</c> date data.
        /// </summary>
        [JsonPropertyName(@"zcalendar")]
        public ZCalendarEnum? ZCalendar { get; set; }

        /// <summary>
        ///     Sets a reference between this trace&#39;s 3D coordinate system and a 3D
        ///     scene. If <c>scene</c> (the default value), the (x,y,z) coordinates refer
        ///     to <c>layout.scene</c>. If <c>scene2</c>, the (x,y,z) coordinates refer
        ///     to <c>layout.scene2</c>, and so on.
        /// </summary>
        [JsonPropertyName(@"scene")]
        public string Scene { get; set; }

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
        ///     Sets the source reference on Chart Studio Cloud for  i .
        /// </summary>
        [JsonPropertyName(@"isrc")]
        public string ISrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  j .
        /// </summary>
        [JsonPropertyName(@"jsrc")]
        public string JSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  k .
        /// </summary>
        [JsonPropertyName(@"ksrc")]
        public string KSrc { get; set; }

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

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  intensity .
        /// </summary>
        [JsonPropertyName(@"intensitysrc")]
        public string IntensitySrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  vertexcolor .
        /// </summary>
        [JsonPropertyName(@"vertexcolorsrc")]
        public string VertexColorSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  facecolor .
        /// </summary>
        [JsonPropertyName(@"facecolorsrc")]
        public string FaceColorSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  hoverinfo .
        /// </summary>
        [JsonPropertyName(@"hoverinfosrc")]
        public string HoverInfoSrc { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is Mesh3D other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] Mesh3D other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (Type        == other.Type        && Type        != null && other.Type        != null && Type.Equals(other.Type))                                              &&
                   (Visible     == other.Visible     && Visible     != null && other.Visible     != null && Visible.Equals(other.Visible))                                        &&
                   (LegendGroup == other.LegendGroup && LegendGroup != null && other.LegendGroup != null && LegendGroup.Equals(other.LegendGroup))                                &&
                   (Name        == other.Name        && Name        != null && other.Name        != null && Name.Equals(other.Name))                                              &&
                   (UId         == other.UId         && UId         != null && other.UId         != null && UId.Equals(other.UId))                                                &&
                   (Equals(Ids,        other.Ids)        || Ids        != null && other.Ids        != null && Ids.SequenceEqual(other.Ids))                                       &&
                   (Equals(CustomData, other.CustomData) || CustomData != null && other.CustomData != null && CustomData.SequenceEqual(other.CustomData))                         &&
                   (Meta == other.Meta && Meta != null && other.Meta != null && Meta.Equals(other.Meta))                                                                          &&
                   (Equals(MetaArray, other.MetaArray) || MetaArray != null && other.MetaArray != null && MetaArray.SequenceEqual(other.MetaArray))                               &&
                   (HoverLabel == other.HoverLabel && HoverLabel != null && other.HoverLabel != null && HoverLabel.Equals(other.HoverLabel))                                      &&
                   (Stream     == other.Stream     && Stream     != null && other.Stream     != null && Stream.Equals(other.Stream))                                              &&
                   (UiRevision == other.UiRevision && UiRevision != null && other.UiRevision != null && UiRevision.Equals(other.UiRevision))                                      &&
                   (Equals(X, other.X) || X != null && other.X != null && X.SequenceEqual(other.X))                                                                               &&
                   (Equals(Y, other.Y) || Y != null && other.Y != null && Y.SequenceEqual(other.Y))                                                                               &&
                   (Equals(Z, other.Z) || Z != null && other.Z != null && Z.SequenceEqual(other.Z))                                                                               &&
                   (Equals(I, other.I) || I != null && other.I != null && I.SequenceEqual(other.I))                                                                               &&
                   (Equals(J, other.J) || J != null && other.J != null && J.SequenceEqual(other.J))                                                                               &&
                   (Equals(K, other.K) || K != null && other.K != null && K.SequenceEqual(other.K))                                                                               &&
                   (Text == other.Text && Text != null && other.Text != null && Text.Equals(other.Text))                                                                          &&
                   (Equals(TextArray, other.TextArray) || TextArray != null && other.TextArray != null && TextArray.SequenceEqual(other.TextArray))                               &&
                   (HoverText == other.HoverText && HoverText != null && other.HoverText != null && HoverText.Equals(other.HoverText))                                            &&
                   (Equals(HoverTextArray, other.HoverTextArray) || HoverTextArray != null && other.HoverTextArray != null && HoverTextArray.SequenceEqual(other.HoverTextArray)) &&
                   (HoverTemplate == other.HoverTemplate && HoverTemplate != null && other.HoverTemplate != null && HoverTemplate.Equals(other.HoverTemplate))                    &&
                   (Equals(HoverTemplateArray, other.HoverTemplateArray) ||
                    HoverTemplateArray != null && other.HoverTemplateArray != null && HoverTemplateArray.SequenceEqual(other.HoverTemplateArray))                                 &&
                   (DelaunaYAxis == other.DelaunaYAxis && DelaunaYAxis != null && other.DelaunaYAxis != null && DelaunaYAxis.Equals(other.DelaunaYAxis))                          &&
                   (AlphaHull    == other.AlphaHull    && AlphaHull    != null && other.AlphaHull    != null && AlphaHull.Equals(other.AlphaHull))                                &&
                   (Equals(Intensity, other.Intensity) || Intensity != null && other.Intensity != null && Intensity.SequenceEqual(other.Intensity))                               &&
                   (IntensityMode == other.IntensityMode && IntensityMode != null && other.IntensityMode != null && IntensityMode.Equals(other.IntensityMode))                    &&
                   (Color         == other.Color         && Color         != null && other.Color         != null && Color.Equals(other.Color))                                    &&
                   (Equals(VertexColor, other.VertexColor) || VertexColor != null && other.VertexColor != null && VertexColor.SequenceEqual(other.VertexColor))                   &&
                   (Equals(FaceColor,   other.FaceColor)   || FaceColor   != null && other.FaceColor   != null && FaceColor.SequenceEqual(other.FaceColor))                       &&
                   (CAuto          == other.CAuto          && CAuto          != null && other.CAuto          != null && CAuto.Equals(other.CAuto))                                &&
                   (CMin           == other.CMin           && CMin           != null && other.CMin           != null && CMin.Equals(other.CMin))                                  &&
                   (CMax           == other.CMax           && CMax           != null && other.CMax           != null && CMax.Equals(other.CMax))                                  &&
                   (CMid           == other.CMid           && CMid           != null && other.CMid           != null && CMid.Equals(other.CMid))                                  &&
                   (ColorScale     == other.ColorScale     && ColorScale     != null && other.ColorScale     != null && ColorScale.Equals(other.ColorScale))                      &&
                   (AutoColorScale == other.AutoColorScale && AutoColorScale != null && other.AutoColorScale != null && AutoColorScale.Equals(other.AutoColorScale))              &&
                   (ReverseScale   == other.ReverseScale   && ReverseScale   != null && other.ReverseScale   != null && ReverseScale.Equals(other.ReverseScale))                  &&
                   (ShowScale      == other.ShowScale      && ShowScale      != null && other.ShowScale      != null && ShowScale.Equals(other.ShowScale))                        &&
                   (ColorBar       == other.ColorBar       && ColorBar       != null && other.ColorBar       != null && ColorBar.Equals(other.ColorBar))                          &&
                   (ColorAxis      == other.ColorAxis      && ColorAxis      != null && other.ColorAxis      != null && ColorAxis.Equals(other.ColorAxis))                        &&
                   (Opacity        == other.Opacity        && Opacity        != null && other.Opacity        != null && Opacity.Equals(other.Opacity))                            &&
                   (FlatShading    == other.FlatShading    && FlatShading    != null && other.FlatShading    != null && FlatShading.Equals(other.FlatShading))                    &&
                   (Contour        == other.Contour        && Contour        != null && other.Contour        != null && Contour.Equals(other.Contour))                            &&
                   (LightPosition  == other.LightPosition  && LightPosition  != null && other.LightPosition  != null && LightPosition.Equals(other.LightPosition))                &&
                   (Lighting       == other.Lighting       && Lighting       != null && other.Lighting       != null && Lighting.Equals(other.Lighting))                          &&
                   (HoverInfo      == other.HoverInfo      && HoverInfo      != null && other.HoverInfo      != null && HoverInfo.Equals(other.HoverInfo))                        &&
                   (Equals(HoverInfoArray, other.HoverInfoArray) || HoverInfoArray != null && other.HoverInfoArray != null && HoverInfoArray.SequenceEqual(other.HoverInfoArray)) &&
                   (ShowLegend       == other.ShowLegend       && ShowLegend       != null && other.ShowLegend       != null && ShowLegend.Equals(other.ShowLegend))              &&
                   (XCalendar        == other.XCalendar        && XCalendar        != null && other.XCalendar        != null && XCalendar.Equals(other.XCalendar))                &&
                   (YCalendar        == other.YCalendar        && YCalendar        != null && other.YCalendar        != null && YCalendar.Equals(other.YCalendar))                &&
                   (ZCalendar        == other.ZCalendar        && ZCalendar        != null && other.ZCalendar        != null && ZCalendar.Equals(other.ZCalendar))                &&
                   (Scene            == other.Scene            && Scene            != null && other.Scene            != null && Scene.Equals(other.Scene))                        &&
                   (IdsSrc           == other.IdsSrc           && IdsSrc           != null && other.IdsSrc           != null && IdsSrc.Equals(other.IdsSrc))                      &&
                   (CustomDataSrc    == other.CustomDataSrc    && CustomDataSrc    != null && other.CustomDataSrc    != null && CustomDataSrc.Equals(other.CustomDataSrc))        &&
                   (MetaSrc          == other.MetaSrc          && MetaSrc          != null && other.MetaSrc          != null && MetaSrc.Equals(other.MetaSrc))                    &&
                   (XSrc             == other.XSrc             && XSrc             != null && other.XSrc             != null && XSrc.Equals(other.XSrc))                          &&
                   (YSrc             == other.YSrc             && YSrc             != null && other.YSrc             != null && YSrc.Equals(other.YSrc))                          &&
                   (ZSrc             == other.ZSrc             && ZSrc             != null && other.ZSrc             != null && ZSrc.Equals(other.ZSrc))                          &&
                   (ISrc             == other.ISrc             && ISrc             != null && other.ISrc             != null && ISrc.Equals(other.ISrc))                          &&
                   (JSrc             == other.JSrc             && JSrc             != null && other.JSrc             != null && JSrc.Equals(other.JSrc))                          &&
                   (KSrc             == other.KSrc             && KSrc             != null && other.KSrc             != null && KSrc.Equals(other.KSrc))                          &&
                   (TextSrc          == other.TextSrc          && TextSrc          != null && other.TextSrc          != null && TextSrc.Equals(other.TextSrc))                    &&
                   (HoverTextSrc     == other.HoverTextSrc     && HoverTextSrc     != null && other.HoverTextSrc     != null && HoverTextSrc.Equals(other.HoverTextSrc))          &&
                   (HoverTemplateSrc == other.HoverTemplateSrc && HoverTemplateSrc != null && other.HoverTemplateSrc != null && HoverTemplateSrc.Equals(other.HoverTemplateSrc))  &&
                   (IntensitySrc     == other.IntensitySrc     && IntensitySrc     != null && other.IntensitySrc     != null && IntensitySrc.Equals(other.IntensitySrc))          &&
                   (VertexColorSrc   == other.VertexColorSrc   && VertexColorSrc   != null && other.VertexColorSrc   != null && VertexColorSrc.Equals(other.VertexColorSrc))      &&
                   (FaceColorSrc     == other.FaceColorSrc     && FaceColorSrc     != null && other.FaceColorSrc     != null && FaceColorSrc.Equals(other.FaceColorSrc))          &&
                   (HoverInfoSrc     == other.HoverInfoSrc     && HoverInfoSrc     != null && other.HoverInfoSrc     != null && HoverInfoSrc.Equals(other.HoverInfoSrc));
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

                if(HoverLabel != null)
                    hashCode = hashCode * 59 + HoverLabel.GetHashCode();

                if(Stream != null)
                    hashCode = hashCode * 59 + Stream.GetHashCode();

                if(UiRevision != null)
                    hashCode = hashCode * 59 + UiRevision.GetHashCode();

                if(X != null)
                    hashCode = hashCode * 59 + X.GetHashCode();

                if(Y != null)
                    hashCode = hashCode * 59 + Y.GetHashCode();

                if(Z != null)
                    hashCode = hashCode * 59 + Z.GetHashCode();

                if(I != null)
                    hashCode = hashCode * 59 + I.GetHashCode();

                if(J != null)
                    hashCode = hashCode * 59 + J.GetHashCode();

                if(K != null)
                    hashCode = hashCode * 59 + K.GetHashCode();

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

                if(DelaunaYAxis != null)
                    hashCode = hashCode * 59 + DelaunaYAxis.GetHashCode();

                if(AlphaHull != null)
                    hashCode = hashCode * 59 + AlphaHull.GetHashCode();

                if(Intensity != null)
                    hashCode = hashCode * 59 + Intensity.GetHashCode();

                if(IntensityMode != null)
                    hashCode = hashCode * 59 + IntensityMode.GetHashCode();

                if(Color != null)
                    hashCode = hashCode * 59 + Color.GetHashCode();

                if(VertexColor != null)
                    hashCode = hashCode * 59 + VertexColor.GetHashCode();

                if(FaceColor != null)
                    hashCode = hashCode * 59 + FaceColor.GetHashCode();

                if(CAuto != null)
                    hashCode = hashCode * 59 + CAuto.GetHashCode();

                if(CMin != null)
                    hashCode = hashCode * 59 + CMin.GetHashCode();

                if(CMax != null)
                    hashCode = hashCode * 59 + CMax.GetHashCode();

                if(CMid != null)
                    hashCode = hashCode * 59 + CMid.GetHashCode();

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

                if(Opacity != null)
                    hashCode = hashCode * 59 + Opacity.GetHashCode();

                if(FlatShading != null)
                    hashCode = hashCode * 59 + FlatShading.GetHashCode();

                if(Contour != null)
                    hashCode = hashCode * 59 + Contour.GetHashCode();

                if(LightPosition != null)
                    hashCode = hashCode * 59 + LightPosition.GetHashCode();

                if(Lighting != null)
                    hashCode = hashCode * 59 + Lighting.GetHashCode();

                if(HoverInfo != null)
                    hashCode = hashCode * 59 + HoverInfo.GetHashCode();

                if(HoverInfoArray != null)
                    hashCode = hashCode * 59 + HoverInfoArray.GetHashCode();

                if(ShowLegend != null)
                    hashCode = hashCode * 59 + ShowLegend.GetHashCode();

                if(XCalendar != null)
                    hashCode = hashCode * 59 + XCalendar.GetHashCode();

                if(YCalendar != null)
                    hashCode = hashCode * 59 + YCalendar.GetHashCode();

                if(ZCalendar != null)
                    hashCode = hashCode * 59 + ZCalendar.GetHashCode();

                if(Scene != null)
                    hashCode = hashCode * 59 + Scene.GetHashCode();

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

                if(ZSrc != null)
                    hashCode = hashCode * 59 + ZSrc.GetHashCode();

                if(ISrc != null)
                    hashCode = hashCode * 59 + ISrc.GetHashCode();

                if(JSrc != null)
                    hashCode = hashCode * 59 + JSrc.GetHashCode();

                if(KSrc != null)
                    hashCode = hashCode * 59 + KSrc.GetHashCode();

                if(TextSrc != null)
                    hashCode = hashCode * 59 + TextSrc.GetHashCode();

                if(HoverTextSrc != null)
                    hashCode = hashCode * 59 + HoverTextSrc.GetHashCode();

                if(HoverTemplateSrc != null)
                    hashCode = hashCode * 59 + HoverTemplateSrc.GetHashCode();

                if(IntensitySrc != null)
                    hashCode = hashCode * 59 + IntensitySrc.GetHashCode();

                if(VertexColorSrc != null)
                    hashCode = hashCode * 59 + VertexColorSrc.GetHashCode();

                if(FaceColorSrc != null)
                    hashCode = hashCode * 59 + FaceColorSrc.GetHashCode();

                if(HoverInfoSrc != null)
                    hashCode = hashCode * 59 + HoverInfoSrc.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Mesh3D and the right Mesh3D.
        /// </summary>
        /// <param name="left">Left Mesh3D.</param>
        /// <param name="right">Right Mesh3D.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(Mesh3D left,
                                       Mesh3D right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Mesh3D and the right Mesh3D.
        /// </summary>
        /// <param name="left">Left Mesh3D.</param>
        /// <param name="right">Right Mesh3D.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(Mesh3D left,
                                       Mesh3D right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Mesh3D</returns>
        public Mesh3D DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<Mesh3D>(ms).Result;
        }
    }
}
