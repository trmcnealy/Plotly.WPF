

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Traces.ContourCarpets;

using Stream = Plotly.Models.Traces.ContourCarpets.Stream;

namespace Plotly.Models.Traces
{
    /// <summary>
    ///     The ContourCarpet class.
    ///     Implements the <see cref="ITrace" />.
    /// </summary>
    
    [JsonConverter(typeof(PlotlyConverter))]
    [Serializable]
    public class ContourCarpet : ITrace, IEquatable<ContourCarpet>
    {
        /// <inheritdoc/>
        [JsonPropertyName(@"type")]
        public TraceTypeEnum? Type { get; } = TraceTypeEnum.ContourCarpet;

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
        ///     Gets or sets the Stream.
        /// </summary>
        [JsonPropertyName(@"stream")]
        public Stream Stream { get; set;} 

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
        ///     The <c>carpet</c> of the carpet axes on which this contour trace lies
        /// </summary>
        [JsonPropertyName(@"carpet")]
        public string Carpet { get; set;} 

        /// <summary>
        ///     Sets the z data.
        /// </summary>
        [JsonPropertyName(@"z")]
        public List<object> Z { get; set;} 

        /// <summary>
        ///     Sets the x coordinates.
        /// </summary>
        [JsonPropertyName(@"a")]
        public List<object> A { get; set;} 

        /// <summary>
        ///     Alternate to <c>x</c>. Builds a linear space of x coordinates. Use with
        ///     <c>dx</c> where <c>x0</c> is the starting coordinate and <c>dx</c> the step.
        /// </summary>
        [JsonPropertyName(@"a0")]
        public object A0 { get; set;} 

        /// <summary>
        ///     Sets the x coordinate step. See <c>x0</c> for more info.
        /// </summary>
        [JsonPropertyName(@"da")]
        public JsNumber? DA { get; set;} 

        /// <summary>
        ///     Sets the y coordinates.
        /// </summary>
        [JsonPropertyName(@"b")]
        public List<object> B { get; set;} 

        /// <summary>
        ///     Alternate to <c>y</c>. Builds a linear space of y coordinates. Use with
        ///     <c>dy</c> where <c>y0</c> is the starting coordinate and <c>dy</c> the step.
        /// </summary>
        [JsonPropertyName(@"b0")]
        public object B0 { get; set;} 

        /// <summary>
        ///     Sets the y coordinate step. See <c>y0</c> for more info.
        /// </summary>
        [JsonPropertyName(@"db")]
        public JsNumber? Db { get; set;} 

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
        [JsonPropertyName(@"atype")]
        public ATypeEnum? AType { get; set;} 

        /// <summary>
        ///     If <c>array</c>, the heatmap&#39;s y coordinates are given by <c>y</c> (the
        ///     default behavior when <c>y</c> is provided) If <c>scaled</c>, the heatmap&#39;s
        ///     y coordinates are given by <c>y0</c> and <c>dy</c> (the default behavior
        ///     when <c>y</c> is not provided)
        /// </summary>
        [JsonPropertyName(@"btype")]
        public BTypeEnum? BType { get; set;} 

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
        public ContourCarpets.Contours Contours { get; set;} 

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
        ///     Sets the source reference on Chart Studio Cloud for  z .
        /// </summary>
        [JsonPropertyName(@"zsrc")]
        public string ZSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  a .
        /// </summary>
        [JsonPropertyName(@"asrc")]
        public string ASrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  b .
        /// </summary>
        [JsonPropertyName(@"bsrc")]
        public string BSrc { get; set;} 

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

        
        public override bool Equals(object obj)
        {
            if (!(obj is ContourCarpet other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        
        public bool Equals([AllowNull] ContourCarpet other)
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
                    Stream == other.Stream &&
                    Stream != null && other.Stream != null &&
                    Stream.Equals(other.Stream)
                ) && 
                (
                    UiRevision == other.UiRevision &&
                    UiRevision != null && other.UiRevision != null &&
                    UiRevision.Equals(other.UiRevision)
                ) && 
                (
                    Carpet == other.Carpet &&
                    Carpet != null && other.Carpet != null &&
                    Carpet.Equals(other.Carpet)
                ) && 
                (
                    Equals(Z, other.Z) ||
                    Z != null && other.Z != null &&
                    Z.SequenceEqual(other.Z)
                ) &&
                (
                    Equals(A, other.A) ||
                    A != null && other.A != null &&
                    A.SequenceEqual(other.A)
                ) &&
                (
                    A0 == other.A0 &&
                    A0 != null && other.A0 != null &&
                    A0.Equals(other.A0)
                ) && 
                (
                    DA == other.DA &&
                    DA != null && other.DA != null &&
                    DA.Equals(other.DA)
                ) && 
                (
                    Equals(B, other.B) ||
                    B != null && other.B != null &&
                    B.SequenceEqual(other.B)
                ) &&
                (
                    B0 == other.B0 &&
                    B0 != null && other.B0 != null &&
                    B0.Equals(other.B0)
                ) && 
                (
                    Db == other.Db &&
                    Db != null && other.Db != null &&
                    Db.Equals(other.Db)
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
                    AType == other.AType &&
                    AType != null && other.AType != null &&
                    AType.Equals(other.AType)
                ) && 
                (
                    BType == other.BType &&
                    BType != null && other.BType != null &&
                    BType.Equals(other.BType)
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
                    ZSrc == other.ZSrc &&
                    ZSrc != null && other.ZSrc != null &&
                    ZSrc.Equals(other.ZSrc)
                ) && 
                (
                    ASrc == other.ASrc &&
                    ASrc != null && other.ASrc != null &&
                    ASrc.Equals(other.ASrc)
                ) && 
                (
                    BSrc == other.BSrc &&
                    BSrc != null && other.BSrc != null &&
                    BSrc.Equals(other.BSrc)
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
                if (Stream != null) hashCode = hashCode * 59 + Stream.GetHashCode();
                if (UiRevision != null) hashCode = hashCode * 59 + UiRevision.GetHashCode();
                if (Carpet != null) hashCode = hashCode * 59 + Carpet.GetHashCode();
                if (Z != null) hashCode = hashCode * 59 + Z.GetHashCode();
                if (A != null) hashCode = hashCode * 59 + A.GetHashCode();
                if (A0 != null) hashCode = hashCode * 59 + A0.GetHashCode();
                if (DA != null) hashCode = hashCode * 59 + DA.GetHashCode();
                if (B != null) hashCode = hashCode * 59 + B.GetHashCode();
                if (B0 != null) hashCode = hashCode * 59 + B0.GetHashCode();
                if (Db != null) hashCode = hashCode * 59 + Db.GetHashCode();
                if (Text != null) hashCode = hashCode * 59 + Text.GetHashCode();
                if (HoverText != null) hashCode = hashCode * 59 + HoverText.GetHashCode();
                if (Transpose != null) hashCode = hashCode * 59 + Transpose.GetHashCode();
                if (AType != null) hashCode = hashCode * 59 + AType.GetHashCode();
                if (BType != null) hashCode = hashCode * 59 + BType.GetHashCode();
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
                if (XAxis != null) hashCode = hashCode * 59 + XAxis.GetHashCode();
                if (YAxis != null) hashCode = hashCode * 59 + YAxis.GetHashCode();
                if (IdsSrc != null) hashCode = hashCode * 59 + IdsSrc.GetHashCode();
                if (CustomDataSrc != null) hashCode = hashCode * 59 + CustomDataSrc.GetHashCode();
                if (MetaSrc != null) hashCode = hashCode * 59 + MetaSrc.GetHashCode();
                if (ZSrc != null) hashCode = hashCode * 59 + ZSrc.GetHashCode();
                if (ASrc != null) hashCode = hashCode * 59 + ASrc.GetHashCode();
                if (BSrc != null) hashCode = hashCode * 59 + BSrc.GetHashCode();
                if (TextSrc != null) hashCode = hashCode * 59 + TextSrc.GetHashCode();
                if (HoverTextSrc != null) hashCode = hashCode * 59 + HoverTextSrc.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left ContourCarpet and the right ContourCarpet.
        /// </summary>
        /// <param name="left">Left ContourCarpet.</param>
        /// <param name="right">Right ContourCarpet.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (ContourCarpet left, ContourCarpet right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left ContourCarpet and the right ContourCarpet.
        /// </summary>
        /// <param name="left">Left ContourCarpet.</param>
        /// <param name="right">Right ContourCarpet.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (ContourCarpet left, ContourCarpet right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>ContourCarpet</returns>
        public ContourCarpet DeepClone()
        {
            using MemoryStream ms = new();
            
            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;
            return JsonSerializer.DeserializeAsync<ContourCarpet>(ms).Result;
        }
    }
}