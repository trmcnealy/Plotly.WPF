using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Traces.StreamTubes;

using Stream = Plotly.Models.Traces.StreamTubes.Stream;

namespace Plotly.Models.Traces
{
    /// <summary>
    ///     The StreamTube class.
    ///     Implements the <see cref="ITrace" />.
    /// </summary>
    [JsonConverter(typeof(PlotlyConverter))]
    [Serializable]
    public class StreamTube : ITrace, IEquatable<StreamTube>
    {
        /// <inheritdoc/>
        [JsonPropertyName(@"type")]
        public TraceTypeEnum? Type { get; } = TraceTypeEnum.StreamTube;

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
        public string? LegendGroup { get; set; }

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
        ///     Sets the x coordinates of the vector field.
        /// </summary>
        [JsonPropertyName(@"x")]
        public List<object>? X { get; set; }

        /// <summary>
        ///     Sets the y coordinates of the vector field.
        /// </summary>
        [JsonPropertyName(@"y")]
        public List<object>? Y { get; set; }

        /// <summary>
        ///     Sets the z coordinates of the vector field.
        /// </summary>
        [JsonPropertyName(@"z")]
        public List<object>? Z { get; set; }

        /// <summary>
        ///     Sets the x components of the vector field.
        /// </summary>
        [JsonPropertyName(@"u")]
        public List<object>? U { get; set; }

        /// <summary>
        ///     Sets the y components of the vector field.
        /// </summary>
        [JsonPropertyName(@"v")]
        public List<object>? V { get; set; }

        /// <summary>
        ///     Sets the z components of the vector field.
        /// </summary>
        [JsonPropertyName(@"w")]
        public List<object>? W { get; set; }

        /// <summary>
        ///     Gets or sets the Starts.
        /// </summary>
        [JsonPropertyName(@"starts")]
        public Starts? Starts { get; set; }

        /// <summary>
        ///     The maximum number of displayed segments in a streamtube.
        /// </summary>
        [JsonPropertyName(@"maxdisplayed")]
        public int? MaxDisplayed { get; set; }

        /// <summary>
        ///     The scaling factor for the streamtubes. The default is 1, which avoids two
        ///     max divergence tubes from touching at adjacent starting positions.
        /// </summary>
        [JsonPropertyName(@"sizeref")]
        public JsNumber? SizeRef { get; set; }

        /// <summary>
        ///     Sets a text element associated with this trace. If trace <c>hoverinfo</c>
        ///     contains a <c>text</c> flag, this text element will be seen in all hover
        ///     labels. Note that streamtube traces do not support array <c>text</c> values.
        /// </summary>
        [JsonPropertyName(@"text")]
        public string? Text { get; set; }

        /// <summary>
        ///     Same as <c>text</c>.
        /// </summary>
        [JsonPropertyName(@"hovertext")]
        public string? HoverText { get; set; }

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
        ///     that are &#39;arrayOk: true&#39;) are available. variables <c>tubex</c>,
        ///     <c>tubey</c>, <c>tubez</c>, <c>tubeu</c>, <c>tubev</c>, <c>tubew</c>, <c>norm</c>
        ///     and <c>divergence</c>. Anything contained in tag <c>&lt;extra&gt;</c> is
        ///     displayed in the secondary box, for example <c>&lt;extra&gt;{fullData.name}&lt;/extra&gt;</c>.
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
        ///     that are &#39;arrayOk: true&#39;) are available. variables <c>tubex</c>,
        ///     <c>tubey</c>, <c>tubez</c>, <c>tubeu</c>, <c>tubev</c>, <c>tubew</c>, <c>norm</c>
        ///     and <c>divergence</c>. Anything contained in tag <c>&lt;extra&gt;</c> is
        ///     displayed in the secondary box, for example <c>&lt;extra&gt;{fullData.name}&lt;/extra&gt;</c>.
        ///     To hide the secondary box completely, use an empty tag <c>&lt;extra&gt;&lt;/extra&gt;</c>.
        /// </summary>
        [JsonPropertyName(@"hovertemplate")]
        [Array]
        public List<string>? HoverTemplateArray { get; set; }

        /// <summary>
        ///     Determines whether or not an item corresponding to this trace is shown in
        ///     the legend.
        /// </summary>
        [JsonPropertyName(@"showlegend")]
        public bool? ShowLegend { get; set; }

        /// <summary>
        ///     Determines whether or not the color domain is computed with respect to the
        ///     input data (here u/v/w norm) or the bounds set in <c>cmin</c> and <c>cmax</c>
        ///      Defaults to <c>false</c> when <c>cmin</c> and <c>cmax</c> are set by the
        ///     user.
        /// </summary>
        [JsonPropertyName(@"cauto")]
        public bool? CAuto { get; set; }

        /// <summary>
        ///     Sets the lower bound of the color domain. Value should have the same units
        ///     as u/v/w norm and if set, <c>cmax</c> must be set as well.
        /// </summary>
        [JsonPropertyName(@"cmin")]
        public JsNumber? CMin { get; set; }

        /// <summary>
        ///     Sets the upper bound of the color domain. Value should have the same units
        ///     as u/v/w norm and if set, <c>cmin</c> must be set as well.
        /// </summary>
        [JsonPropertyName(@"cmax")]
        public JsNumber? CMax { get; set; }

        /// <summary>
        ///     Sets the mid-point of the color domain by scaling <c>cmin</c> and/or <c>cmax</c>
        ///     to be equidistant to this point. Value should have the same units as u/v/w
        ///     norm. Has no effect when <c>cauto</c> is <c>false</c>.
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
        public object? ColorScale { get; set; }

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
        public ColorBar? ColorBar { get; set; }

        /// <summary>
        ///     Sets a reference to a shared color axis. References to these shared color
        ///     axes are <c>coloraxis</c>, <c>coloraxis2</c>, <c>coloraxis3</c>, etc. Settings
        ///     for these shared color axes are set in the layout, under <c>layout.coloraxis</c>,
        ///     <c>layout.coloraxis2</c>, etc. Note that multiple color scales can be linked
        ///     to the same color axis.
        /// </summary>
        [JsonPropertyName(@"coloraxis")]
        public string? ColorAxis { get; set; }

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
        ///     Gets or sets the LightPosition.
        /// </summary>
        [JsonPropertyName(@"lightposition")]
        public LightPosition? LightPosition { get; set; }

        /// <summary>
        ///     Gets or sets the Lighting.
        /// </summary>
        [JsonPropertyName(@"lighting")]
        public Lighting? Lighting { get; set; }

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
        ///     Sets a reference between this trace&#39;s 3D coordinate system and a 3D
        ///     scene. If <c>scene</c> (the default value), the (x,y,z) coordinates refer
        ///     to <c>layout.scene</c>. If <c>scene2</c>, the (x,y,z) coordinates refer
        ///     to <c>layout.scene2</c>, and so on.
        /// </summary>
        [JsonPropertyName(@"scene")]
        public string? Scene { get; set; }

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
        ///     Sets the source reference on Chart Studio Cloud for  z .
        /// </summary>
        [JsonPropertyName(@"zsrc")]
        public string? ZSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  u .
        /// </summary>
        [JsonPropertyName(@"usrc")]
        public string? USrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  v .
        /// </summary>
        [JsonPropertyName(@"vsrc")]
        public string? VSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  w .
        /// </summary>
        [JsonPropertyName(@"wsrc")]
        public string? WSrc { get; set; }

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

        public override bool Equals(object obj)
        {
            if(!(obj is StreamTube other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] StreamTube other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (Type        == other.Type        && Type        != null && other.Type        != null && Type.Equals(other.Type))                           &&
                   (Visible     == other.Visible     && Visible     != null && other.Visible     != null && Visible.Equals(other.Visible))                     &&
                   (LegendGroup == other.LegendGroup && LegendGroup != null && other.LegendGroup != null && LegendGroup.Equals(other.LegendGroup))             &&
                   (Name        == other.Name        && Name        != null && other.Name        != null && Name.Equals(other.Name))                           &&
                   (UId         == other.UId         && UId         != null && other.UId         != null && UId.Equals(other.UId))                             &&
                   (Equals(Ids,        other.Ids)        || Ids        != null && other.Ids        != null && Ids.SequenceEqual(other.Ids))                    &&
                   (Equals(CustomData, other.CustomData) || CustomData != null && other.CustomData != null && CustomData.SequenceEqual(other.CustomData))      &&
                   (Meta == other.Meta && Meta != null && other.Meta != null && Meta.Equals(other.Meta))                                                       &&
                   (Equals(MetaArray, other.MetaArray) || MetaArray != null && other.MetaArray != null && MetaArray.SequenceEqual(other.MetaArray))            &&
                   (HoverLabel == other.HoverLabel && HoverLabel != null && other.HoverLabel != null && HoverLabel.Equals(other.HoverLabel))                   &&
                   (Stream     == other.Stream     && Stream     != null && other.Stream     != null && Stream.Equals(other.Stream))                           &&
                   (UiRevision == other.UiRevision && UiRevision != null && other.UiRevision != null && UiRevision.Equals(other.UiRevision))                   &&
                   (Equals(X, other.X) || X != null && other.X != null && X.SequenceEqual(other.X))                                                            &&
                   (Equals(Y, other.Y) || Y != null && other.Y != null && Y.SequenceEqual(other.Y))                                                            &&
                   (Equals(Z, other.Z) || Z != null && other.Z != null && Z.SequenceEqual(other.Z))                                                            &&
                   (Equals(U, other.U) || U != null && other.U != null && U.SequenceEqual(other.U))                                                            &&
                   (Equals(V, other.V) || V != null && other.V != null && V.SequenceEqual(other.V))                                                            &&
                   (Equals(W, other.W) || W != null && other.W != null && W.SequenceEqual(other.W))                                                            &&
                   (Starts        == other.Starts        && Starts        != null && other.Starts        != null && Starts.Equals(other.Starts))               &&
                   (MaxDisplayed  == other.MaxDisplayed  && MaxDisplayed  != null && other.MaxDisplayed  != null && MaxDisplayed.Equals(other.MaxDisplayed))   &&
                   (SizeRef       == other.SizeRef       && SizeRef       != null && other.SizeRef       != null && SizeRef.Equals(other.SizeRef))             &&
                   (Text          == other.Text          && Text          != null && other.Text          != null && Text.Equals(other.Text))                   &&
                   (HoverText     == other.HoverText     && HoverText     != null && other.HoverText     != null && HoverText.Equals(other.HoverText))         &&
                   (HoverTemplate == other.HoverTemplate && HoverTemplate != null && other.HoverTemplate != null && HoverTemplate.Equals(other.HoverTemplate)) &&
                   (Equals(HoverTemplateArray, other.HoverTemplateArray) ||
                    HoverTemplateArray != null && other.HoverTemplateArray != null && HoverTemplateArray.SequenceEqual(other.HoverTemplateArray))                                 &&
                   (ShowLegend     == other.ShowLegend     && ShowLegend     != null && other.ShowLegend     != null && ShowLegend.Equals(other.ShowLegend))                      &&
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
                   (LightPosition  == other.LightPosition  && LightPosition  != null && other.LightPosition  != null && LightPosition.Equals(other.LightPosition))                &&
                   (Lighting       == other.Lighting       && Lighting       != null && other.Lighting       != null && Lighting.Equals(other.Lighting))                          &&
                   (HoverInfo      == other.HoverInfo      && HoverInfo      != null && other.HoverInfo      != null && HoverInfo.Equals(other.HoverInfo))                        &&
                   (Equals(HoverInfoArray, other.HoverInfoArray) || HoverInfoArray != null && other.HoverInfoArray != null && HoverInfoArray.SequenceEqual(other.HoverInfoArray)) &&
                   (Scene            == other.Scene            && Scene            != null && other.Scene            != null && Scene.Equals(other.Scene))                        &&
                   (IdsSrc           == other.IdsSrc           && IdsSrc           != null && other.IdsSrc           != null && IdsSrc.Equals(other.IdsSrc))                      &&
                   (CustomDataSrc    == other.CustomDataSrc    && CustomDataSrc    != null && other.CustomDataSrc    != null && CustomDataSrc.Equals(other.CustomDataSrc))        &&
                   (MetaSrc          == other.MetaSrc          && MetaSrc          != null && other.MetaSrc          != null && MetaSrc.Equals(other.MetaSrc))                    &&
                   (XSrc             == other.XSrc             && XSrc             != null && other.XSrc             != null && XSrc.Equals(other.XSrc))                          &&
                   (YSrc             == other.YSrc             && YSrc             != null && other.YSrc             != null && YSrc.Equals(other.YSrc))                          &&
                   (ZSrc             == other.ZSrc             && ZSrc             != null && other.ZSrc             != null && ZSrc.Equals(other.ZSrc))                          &&
                   (USrc             == other.USrc             && USrc             != null && other.USrc             != null && USrc.Equals(other.USrc))                          &&
                   (VSrc             == other.VSrc             && VSrc             != null && other.VSrc             != null && VSrc.Equals(other.VSrc))                          &&
                   (WSrc             == other.WSrc             && WSrc             != null && other.WSrc             != null && WSrc.Equals(other.WSrc))                          &&
                   (HoverTemplateSrc == other.HoverTemplateSrc && HoverTemplateSrc != null && other.HoverTemplateSrc != null && HoverTemplateSrc.Equals(other.HoverTemplateSrc))  &&
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

                if(U != null)
                    hashCode = hashCode * 59 + U.GetHashCode();

                if(V != null)
                    hashCode = hashCode * 59 + V.GetHashCode();

                if(W != null)
                    hashCode = hashCode * 59 + W.GetHashCode();

                if(Starts != null)
                    hashCode = hashCode * 59 + Starts.GetHashCode();

                if(MaxDisplayed != null)
                    hashCode = hashCode * 59 + MaxDisplayed.GetHashCode();

                if(SizeRef != null)
                    hashCode = hashCode * 59 + SizeRef.GetHashCode();

                if(Text != null)
                    hashCode = hashCode * 59 + Text.GetHashCode();

                if(HoverText != null)
                    hashCode = hashCode * 59 + HoverText.GetHashCode();

                if(HoverTemplate != null)
                    hashCode = hashCode * 59 + HoverTemplate.GetHashCode();

                if(HoverTemplateArray != null)
                    hashCode = hashCode * 59 + HoverTemplateArray.GetHashCode();

                if(ShowLegend != null)
                    hashCode = hashCode * 59 + ShowLegend.GetHashCode();

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

                if(LightPosition != null)
                    hashCode = hashCode * 59 + LightPosition.GetHashCode();

                if(Lighting != null)
                    hashCode = hashCode * 59 + Lighting.GetHashCode();

                if(HoverInfo != null)
                    hashCode = hashCode * 59 + HoverInfo.GetHashCode();

                if(HoverInfoArray != null)
                    hashCode = hashCode * 59 + HoverInfoArray.GetHashCode();

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

                if(USrc != null)
                    hashCode = hashCode * 59 + USrc.GetHashCode();

                if(VSrc != null)
                    hashCode = hashCode * 59 + VSrc.GetHashCode();

                if(WSrc != null)
                    hashCode = hashCode * 59 + WSrc.GetHashCode();

                if(HoverTemplateSrc != null)
                    hashCode = hashCode * 59 + HoverTemplateSrc.GetHashCode();

                if(HoverInfoSrc != null)
                    hashCode = hashCode * 59 + HoverInfoSrc.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left StreamTube and the right StreamTube.
        /// </summary>
        /// <param name="left">Left StreamTube.</param>
        /// <param name="right">Right StreamTube.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(StreamTube left,
                                       StreamTube right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left StreamTube and the right StreamTube.
        /// </summary>
        /// <param name="left">Left StreamTube.</param>
        /// <param name="right">Right StreamTube.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(StreamTube left,
                                       StreamTube right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>StreamTube</returns>
        public StreamTube DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<StreamTube>(ms).Result;
        }
    }
}
