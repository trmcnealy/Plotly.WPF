
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Traces.Images;

using Stream = Plotly.Models.Traces.Images.Stream;

namespace Plotly.Models.Traces
{
    /// <summary>
    ///     The Image class.
    ///     Implements the <see cref="ITrace" />.
    /// </summary>
    
    [JsonConverter(typeof(PlotlyConverter))]
    [Serializable]
    public class Image : ITrace, IEquatable<Image>
    {
        /// <inheritdoc/>
        [JsonPropertyName(@"type")]
        public TraceTypeEnum? Type { get; } = TraceTypeEnum.Image;

        /// <summary>
        ///     Determines whether or not this trace is visible. If <c>legendonly</c>, the
        ///     trace is not drawn, but can appear as a legend item (provided that the legend
        ///     itself is visible).
        /// </summary>
        [JsonPropertyName(@"visible")]
        public VisibleEnum? Visible { get; set;} 

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
        ///     A 2-dimensional array in which each element is an array of 3 or 4 numbers
        ///     representing a color.
        /// </summary>
        [JsonPropertyName(@"z")]
        public List<object> Z { get; set;} 

        /// <summary>
        ///     Color model used to map the numerical color components described in <c>z</c>
        ///     into colors.
        /// </summary>
        [JsonPropertyName(@"colormodel")]
        public ColorModelEnum? ColorModel { get; set;} 

        /// <summary>
        ///     Array defining the lower bound for each color component. Note that the default
        ///     value will depend on the colormodel. For the <c>rgb</c> colormodel, it is
        ///     [0, 0, 0]. For the <c>rgba</c> colormodel, it is [0, 0, 0, 0]. For the <c>hsl</c>
        ///     colormodel, it is [0, 0, 0]. For the <c>hsla</c> colormodel, it is [0, 0,
        ///     0, 0].
        /// </summary>
        [JsonPropertyName(@"zmin")]
        public List<object> ZMin { get; set;} 

        /// <summary>
        ///     Array defining the higher bound for each color component. Note that the
        ///     default value will depend on the colormodel. For the <c>rgb</c> colormodel,
        ///     it is [255, 255, 255]. For the <c>rgba</c> colormodel, it is [255, 255,
        ///     255, 1]. For the <c>hsl</c> colormodel, it is [360, 100, 100]. For the <c>hsla</c>
        ///     colormodel, it is [360, 100, 100, 1].
        /// </summary>
        [JsonPropertyName(@"zmax")]
        public List<object> ZMax { get; set;} 

        /// <summary>
        ///     Set the image&#39;s x position.
        /// </summary>
        [JsonPropertyName(@"x0")]
        public object X0 { get; set;} 

        /// <summary>
        ///     Set the image&#39;s y position.
        /// </summary>
        [JsonPropertyName(@"y0")]
        public object Y0 { get; set;} 

        /// <summary>
        ///     Set the pixel&#39;s horizontal size.
        /// </summary>
        [JsonPropertyName(@"dx")]
        public JsNumber? DX { get; set;} 

        /// <summary>
        ///     Set the pixel&#39;s vertical size
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
        ///     that are &#39;arrayOk: true&#39;) are available. variables <c>z</c>, <c>color</c>
        ///     and <c>colormodel</c>. Anything contained in tag <c>&lt;extra&gt;</c> is
        ///     displayed in the secondary box, for example <c>&lt;extra&gt;{fullData.name}&lt;/extra&gt;</c>.
        ///     To hide the secondary box completely, use an empty tag <c>&lt;extra&gt;&lt;/extra&gt;</c>.
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
        ///     that are &#39;arrayOk: true&#39;) are available. variables <c>z</c>, <c>color</c>
        ///     and <c>colormodel</c>. Anything contained in tag <c>&lt;extra&gt;</c> is
        ///     displayed in the secondary box, for example <c>&lt;extra&gt;{fullData.name}&lt;/extra&gt;</c>.
        ///     To hide the secondary box completely, use an empty tag <c>&lt;extra&gt;&lt;/extra&gt;</c>.
        /// </summary>
        [JsonPropertyName(@"hovertemplate")]
        [Array]
        public List<string> HoverTemplateArray { get; set;} 

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
        ///     Sets the source reference on Chart Studio Cloud for  hoverinfo .
        /// </summary>
        [JsonPropertyName(@"hoverinfosrc")]
        public string HoverInfoSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  hovertemplate .
        /// </summary>
        [JsonPropertyName(@"hovertemplatesrc")]
        public string HoverTemplateSrc { get; set;} 

        
        public override bool Equals(object obj)
        {
            if (!(obj is Image other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        
        public bool Equals([AllowNull] Image other)
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
                    ColorModel == other.ColorModel &&
                    ColorModel != null && other.ColorModel != null &&
                    ColorModel.Equals(other.ColorModel)
                ) && 
                (
                    Equals(ZMin, other.ZMin) ||
                    ZMin != null && other.ZMin != null &&
                    ZMin.SequenceEqual(other.ZMin)
                ) &&
                (
                    Equals(ZMax, other.ZMax) ||
                    ZMax != null && other.ZMax != null &&
                    ZMax.SequenceEqual(other.ZMax)
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
                    HoverInfoSrc == other.HoverInfoSrc &&
                    HoverInfoSrc != null && other.HoverInfoSrc != null &&
                    HoverInfoSrc.Equals(other.HoverInfoSrc)
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
                if (Opacity != null) hashCode = hashCode * 59 + Opacity.GetHashCode();
                if (Name != null) hashCode = hashCode * 59 + Name.GetHashCode();
                if (UId != null) hashCode = hashCode * 59 + UId.GetHashCode();
                if (Ids != null) hashCode = hashCode * 59 + Ids.GetHashCode();
                if (CustomData != null) hashCode = hashCode * 59 + CustomData.GetHashCode();
                if (Meta != null) hashCode = hashCode * 59 + Meta.GetHashCode();
                if (MetaArray != null) hashCode = hashCode * 59 + MetaArray.GetHashCode();
                if (HoverLabel != null) hashCode = hashCode * 59 + HoverLabel.GetHashCode();
                if (Stream != null) hashCode = hashCode * 59 + Stream.GetHashCode();
                if (UiRevision != null) hashCode = hashCode * 59 + UiRevision.GetHashCode();
                if (Z != null) hashCode = hashCode * 59 + Z.GetHashCode();
                if (ColorModel != null) hashCode = hashCode * 59 + ColorModel.GetHashCode();
                if (ZMin != null) hashCode = hashCode * 59 + ZMin.GetHashCode();
                if (ZMax != null) hashCode = hashCode * 59 + ZMax.GetHashCode();
                if (X0 != null) hashCode = hashCode * 59 + X0.GetHashCode();
                if (Y0 != null) hashCode = hashCode * 59 + Y0.GetHashCode();
                if (DX != null) hashCode = hashCode * 59 + DX.GetHashCode();
                if (Dy != null) hashCode = hashCode * 59 + Dy.GetHashCode();
                if (Text != null) hashCode = hashCode * 59 + Text.GetHashCode();
                if (HoverText != null) hashCode = hashCode * 59 + HoverText.GetHashCode();
                if (HoverInfo != null) hashCode = hashCode * 59 + HoverInfo.GetHashCode();
                if (HoverInfoArray != null) hashCode = hashCode * 59 + HoverInfoArray.GetHashCode();
                if (HoverTemplate != null) hashCode = hashCode * 59 + HoverTemplate.GetHashCode();
                if (HoverTemplateArray != null) hashCode = hashCode * 59 + HoverTemplateArray.GetHashCode();
                if (XAxis != null) hashCode = hashCode * 59 + XAxis.GetHashCode();
                if (YAxis != null) hashCode = hashCode * 59 + YAxis.GetHashCode();
                if (IdsSrc != null) hashCode = hashCode * 59 + IdsSrc.GetHashCode();
                if (CustomDataSrc != null) hashCode = hashCode * 59 + CustomDataSrc.GetHashCode();
                if (MetaSrc != null) hashCode = hashCode * 59 + MetaSrc.GetHashCode();
                if (ZSrc != null) hashCode = hashCode * 59 + ZSrc.GetHashCode();
                if (TextSrc != null) hashCode = hashCode * 59 + TextSrc.GetHashCode();
                if (HoverTextSrc != null) hashCode = hashCode * 59 + HoverTextSrc.GetHashCode();
                if (HoverInfoSrc != null) hashCode = hashCode * 59 + HoverInfoSrc.GetHashCode();
                if (HoverTemplateSrc != null) hashCode = hashCode * 59 + HoverTemplateSrc.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Image and the right Image.
        /// </summary>
        /// <param name="left">Left Image.</param>
        /// <param name="right">Right Image.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (Image left, Image right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Image and the right Image.
        /// </summary>
        /// <param name="left">Left Image.</param>
        /// <param name="right">Right Image.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (Image left, Image right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Image</returns>
        public Image DeepClone()
        {
            using MemoryStream ms = new();
            
            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;
            return JsonSerializer.DeserializeAsync<Image>(ms).Result;
        }
    }
}