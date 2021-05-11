using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Traces.HeatMapGls;

using Stream = Plotly.Models.Traces.HeatMapGls.Stream;

namespace Plotly.Models.Traces
{
    /// <summary>
    ///     The HeatMapGl class.
    ///     Implements the <see cref="ITrace" />.
    /// </summary>
    [JsonConverter(typeof(PlotlyConverter))]
    [Serializable]
    public class HeatMapGl : ITrace, IEquatable<HeatMapGl>
    {
        /// <inheritdoc/>
        [JsonPropertyName(@"type")]
        public TraceTypeEnum? Type { get; } = TraceTypeEnum.HeatMapGl;

        /// <summary>
        ///     Determines whether or not this trace is visible. If <c>legendonly</c>, the
        ///     trace is not drawn, but can appear as a legend item (provided that the legend
        ///     itself is visible).
        /// </summary>
        [JsonPropertyName(@"visible")]
        public VisibleEnum? Visible { get; set; }

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
        ///     Sets the z data.
        /// </summary>
        [JsonPropertyName(@"z")]
        public List<object> Z { get; set; }

        /// <summary>
        ///     Sets the x coordinates.
        /// </summary>
        [JsonPropertyName(@"x")]
        public List<object> X { get; set; }

        /// <summary>
        ///     Alternate to <c>x</c>. Builds a linear space of x coordinates. Use with
        ///     <c>dx</c> where <c>x0</c> is the starting coordinate and <c>dx</c> the step.
        /// </summary>
        [JsonPropertyName(@"x0")]
        public object X0 { get; set; }

        /// <summary>
        ///     Sets the x coordinate step. See <c>x0</c> for more info.
        /// </summary>
        [JsonPropertyName(@"dx")]
        public JsNumber? DX { get; set; }

        /// <summary>
        ///     Sets the y coordinates.
        /// </summary>
        [JsonPropertyName(@"y")]
        public List<object> Y { get; set; }

        /// <summary>
        ///     Alternate to <c>y</c>. Builds a linear space of y coordinates. Use with
        ///     <c>dy</c> where <c>y0</c> is the starting coordinate and <c>dy</c> the step.
        /// </summary>
        [JsonPropertyName(@"y0")]
        public object Y0 { get; set; }

        /// <summary>
        ///     Sets the y coordinate step. See <c>y0</c> for more info.
        /// </summary>
        [JsonPropertyName(@"dy")]
        public JsNumber? Dy { get; set; }

        /// <summary>
        ///     Sets the text elements associated with each z value.
        /// </summary>
        [JsonPropertyName(@"text")]
        public List<object> Text { get; set; }

        /// <summary>
        ///     Transposes the z data.
        /// </summary>
        [JsonPropertyName(@"transpose")]
        public bool? Transpose { get; set; }

        /// <summary>
        ///     If <c>array</c>, the heatmap&#39;s x coordinates are given by <c>x</c> (the
        ///     default behavior when <c>x</c> is provided). If <c>scaled</c>, the heatmap&#39;s
        ///     x coordinates are given by <c>x0</c> and <c>dx</c> (the default behavior
        ///     when <c>x</c> is not provided).
        /// </summary>
        [JsonPropertyName(@"xtype")]
        public XTypeEnum? XType { get; set; }

        /// <summary>
        ///     If <c>array</c>, the heatmap&#39;s y coordinates are given by <c>y</c> (the
        ///     default behavior when <c>y</c> is provided) If <c>scaled</c>, the heatmap&#39;s
        ///     y coordinates are given by <c>y0</c> and <c>dy</c> (the default behavior
        ///     when <c>y</c> is not provided)
        /// </summary>
        [JsonPropertyName(@"ytype")]
        public YTypeEnum? YType { get; set; }

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
        ///     Sets the source reference on Chart Studio Cloud for  z .
        /// </summary>
        [JsonPropertyName(@"zsrc")]
        public string ZSrc { get; set; }

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
        ///     Sets the source reference on Chart Studio Cloud for  text .
        /// </summary>
        [JsonPropertyName(@"textsrc")]
        public string TextSrc { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is HeatMapGl other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] HeatMapGl other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (Type    == other.Type    && Type    != null && other.Type    != null && Type.Equals(other.Type))                                                              &&
                   (Visible == other.Visible && Visible != null && other.Visible != null && Visible.Equals(other.Visible))                                                        &&
                   (Opacity == other.Opacity && Opacity != null && other.Opacity != null && Opacity.Equals(other.Opacity))                                                        &&
                   (Name    == other.Name    && Name    != null && other.Name    != null && Name.Equals(other.Name))                                                              &&
                   (UId     == other.UId     && UId     != null && other.UId     != null && UId.Equals(other.UId))                                                                &&
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
                   (Equals(Z, other.Z) || Z != null && other.Z != null && Z.SequenceEqual(other.Z))                                                                               &&
                   (Equals(X, other.X) || X != null && other.X != null && X.SequenceEqual(other.X))                                                                               &&
                   (X0 == other.X0 && X0 != null && other.X0 != null && X0.Equals(other.X0))                                                                                      &&
                   (DX == other.DX && DX != null && other.DX != null && DX.Equals(other.DX))                                                                                      &&
                   (Equals(Y, other.Y) || Y != null && other.Y != null && Y.SequenceEqual(other.Y))                                                                               &&
                   (Y0 == other.Y0 && Y0 != null && other.Y0 != null && Y0.Equals(other.Y0))                                                                                      &&
                   (Dy == other.Dy && Dy != null && other.Dy != null && Dy.Equals(other.Dy))                                                                                      &&
                   (Equals(Text, other.Text) || Text != null && other.Text != null && Text.SequenceEqual(other.Text))                                                             &&
                   (Transpose      == other.Transpose      && Transpose      != null && other.Transpose      != null && Transpose.Equals(other.Transpose))                        &&
                   (XType          == other.XType          && XType          != null && other.XType          != null && XType.Equals(other.XType))                                &&
                   (YType          == other.YType          && YType          != null && other.YType          != null && YType.Equals(other.YType))                                &&
                   (ZAuto          == other.ZAuto          && ZAuto          != null && other.ZAuto          != null && ZAuto.Equals(other.ZAuto))                                &&
                   (ZMin           == other.ZMin           && ZMin           != null && other.ZMin           != null && ZMin.Equals(other.ZMin))                                  &&
                   (ZMax           == other.ZMax           && ZMax           != null && other.ZMax           != null && ZMax.Equals(other.ZMax))                                  &&
                   (ZMid           == other.ZMid           && ZMid           != null && other.ZMid           != null && ZMid.Equals(other.ZMid))                                  &&
                   (ColorScale     == other.ColorScale     && ColorScale     != null && other.ColorScale     != null && ColorScale.Equals(other.ColorScale))                      &&
                   (AutoColorScale == other.AutoColorScale && AutoColorScale != null && other.AutoColorScale != null && AutoColorScale.Equals(other.AutoColorScale))              &&
                   (ReverseScale   == other.ReverseScale   && ReverseScale   != null && other.ReverseScale   != null && ReverseScale.Equals(other.ReverseScale))                  &&
                   (ShowScale      == other.ShowScale      && ShowScale      != null && other.ShowScale      != null && ShowScale.Equals(other.ShowScale))                        &&
                   (ColorBar       == other.ColorBar       && ColorBar       != null && other.ColorBar       != null && ColorBar.Equals(other.ColorBar))                          &&
                   (ColorAxis      == other.ColorAxis      && ColorAxis      != null && other.ColorAxis      != null && ColorAxis.Equals(other.ColorAxis))                        &&
                   (XAxis          == other.XAxis          && XAxis          != null && other.XAxis          != null && XAxis.Equals(other.XAxis))                                &&
                   (YAxis          == other.YAxis          && YAxis          != null && other.YAxis          != null && YAxis.Equals(other.YAxis))                                &&
                   (IdsSrc         == other.IdsSrc         && IdsSrc         != null && other.IdsSrc         != null && IdsSrc.Equals(other.IdsSrc))                              &&
                   (CustomDataSrc  == other.CustomDataSrc  && CustomDataSrc  != null && other.CustomDataSrc  != null && CustomDataSrc.Equals(other.CustomDataSrc))                &&
                   (MetaSrc        == other.MetaSrc        && MetaSrc        != null && other.MetaSrc        != null && MetaSrc.Equals(other.MetaSrc))                            &&
                   (HoverInfoSrc   == other.HoverInfoSrc   && HoverInfoSrc   != null && other.HoverInfoSrc   != null && HoverInfoSrc.Equals(other.HoverInfoSrc))                  &&
                   (ZSrc           == other.ZSrc           && ZSrc           != null && other.ZSrc           != null && ZSrc.Equals(other.ZSrc))                                  &&
                   (XSrc           == other.XSrc           && XSrc           != null && other.XSrc           != null && XSrc.Equals(other.XSrc))                                  &&
                   (YSrc           == other.YSrc           && YSrc           != null && other.YSrc           != null && YSrc.Equals(other.YSrc))                                  &&
                   (TextSrc        == other.TextSrc        && TextSrc        != null && other.TextSrc        != null && TextSrc.Equals(other.TextSrc));
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

                if(Z != null)
                    hashCode = hashCode * 59 + Z.GetHashCode();

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

                if(Text != null)
                    hashCode = hashCode * 59 + Text.GetHashCode();

                if(Transpose != null)
                    hashCode = hashCode * 59 + Transpose.GetHashCode();

                if(XType != null)
                    hashCode = hashCode * 59 + XType.GetHashCode();

                if(YType != null)
                    hashCode = hashCode * 59 + YType.GetHashCode();

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

                if(ZSrc != null)
                    hashCode = hashCode * 59 + ZSrc.GetHashCode();

                if(XSrc != null)
                    hashCode = hashCode * 59 + XSrc.GetHashCode();

                if(YSrc != null)
                    hashCode = hashCode * 59 + YSrc.GetHashCode();

                if(TextSrc != null)
                    hashCode = hashCode * 59 + TextSrc.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left HeatMapGl and the right HeatMapGl.
        /// </summary>
        /// <param name="left">Left HeatMapGl.</param>
        /// <param name="right">Right HeatMapGl.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(HeatMapGl left,
                                       HeatMapGl right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left HeatMapGl and the right HeatMapGl.
        /// </summary>
        /// <param name="left">Left HeatMapGl.</param>
        /// <param name="right">Right HeatMapGl.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(HeatMapGl left,
                                       HeatMapGl right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>HeatMapGl</returns>
        public HeatMapGl DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<HeatMapGl>(ms).Result;
        }
    }
}
