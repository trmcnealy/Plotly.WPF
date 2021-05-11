using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Traces.ScatterCarpets;

using Stream = Plotly.Models.Traces.ScatterCarpets.Stream;

namespace Plotly.Models.Traces
{
    /// <summary>
    ///     The ScatterCarpet class.
    ///     Implements the <see cref="ITrace" />.
    /// </summary>
    [JsonConverter(typeof(PlotlyConverter))]
    [Serializable]
    public class ScatterCarpet : ITrace, IEquatable<ScatterCarpet>
    {
        /// <inheritdoc/>
        [JsonPropertyName(@"type")]
        public TraceTypeEnum? Type { get; } = TraceTypeEnum.ScatterCarpet;

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
        ///     Array containing integer indices of selected points. Has an effect only
        ///     for traces that support selections. Note that an empty array means an empty
        ///     selection where the <c>unselected</c> are turned on for all points, whereas,
        ///     any other non-array values means no selection all where the <c>selected</c>
        ///     and <c>unselected</c> styles have no effect.
        /// </summary>
        [JsonPropertyName(@"selectedpoints")]
        public object SelectedPoints { get; set; }

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
        ///     An identifier for this carpet, so that <c>scattercarpet</c> and <c>contourcarpet</c>
        ///     traces can specify a carpet plot on which they lie
        /// </summary>
        [JsonPropertyName(@"carpet")]
        public string Carpet { get; set; }

        /// <summary>
        ///     Sets the a-axis coordinates.
        /// </summary>
        [JsonPropertyName(@"a")]
        public List<object> A { get; set; }

        /// <summary>
        ///     Sets the b-axis coordinates.
        /// </summary>
        [JsonPropertyName(@"b")]
        public List<object> B { get; set; }

        /// <summary>
        ///     Determines the drawing mode for this scatter trace. If the provided <c>mode</c>
        ///     includes <c>text</c> then the <c>text</c> elements appear at the coordinates.
        ///     Otherwise, the <c>text</c> elements appear on hover. If there are less than
        ///     20 points and the trace is not stacked then the default is <c>lines+markers</c>.
        ///     Otherwise, <c>lines</c>.
        /// </summary>
        [JsonPropertyName(@"mode")]
        public ModeFlag? Mode { get; set; }

        /// <summary>
        ///     Sets text elements associated with each (a,b) point. If a single string,
        ///     the same string appears over all the data points. If an array of strings,
        ///     the items are mapped in order to the the data points in (a,b). If trace
        ///     <c>hoverinfo</c> contains a <c>text</c> flag and <c>hovertext</c> is not
        ///     set, these elements will be seen in the hover labels.
        /// </summary>
        [JsonPropertyName(@"text")]
        public string Text { get; set; }

        /// <summary>
        ///     Sets text elements associated with each (a,b) point. If a single string,
        ///     the same string appears over all the data points. If an array of strings,
        ///     the items are mapped in order to the the data points in (a,b). If trace
        ///     <c>hoverinfo</c> contains a <c>text</c> flag and <c>hovertext</c> is not
        ///     set, these elements will be seen in the hover labels.
        /// </summary>
        [JsonPropertyName(@"text")]
        [Array]
        public List<string> TextArray { get; set; }

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
        ///     variables <c>a</c>, <c>b</c> and <c>text</c>.
        /// </summary>
        [JsonPropertyName(@"texttemplate")]
        public string TextTemplate { get; set; }

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
        ///     variables <c>a</c>, <c>b</c> and <c>text</c>.
        /// </summary>
        [JsonPropertyName(@"texttemplate")]
        [Array]
        public List<string> TextTemplateArray { get; set; }

        /// <summary>
        ///     Sets hover text elements associated with each (a,b) point. If a single string,
        ///     the same string appears over all the data points. If an array of strings,
        ///     the items are mapped in order to the the data points in (a,b). To be seen,
        ///     trace <c>hoverinfo</c> must contain a <c>text</c> flag.
        /// </summary>
        [JsonPropertyName(@"hovertext")]
        public string HoverText { get; set; }

        /// <summary>
        ///     Sets hover text elements associated with each (a,b) point. If a single string,
        ///     the same string appears over all the data points. If an array of strings,
        ///     the items are mapped in order to the the data points in (a,b). To be seen,
        ///     trace <c>hoverinfo</c> must contain a <c>text</c> flag.
        /// </summary>
        [JsonPropertyName(@"hovertext")]
        [Array]
        public List<string> HoverTextArray { get; set; }

        /// <summary>
        ///     Gets or sets the Line.
        /// </summary>
        [JsonPropertyName(@"line")]
        public Line Line { get; set; }

        /// <summary>
        ///     Determines whether or not gaps (i.e. {nan} or missing values) in the provided
        ///     data arrays are connected.
        /// </summary>
        [JsonPropertyName(@"connectgaps")]
        public bool? ConnectGaps { get; set; }

        /// <summary>
        ///     Sets the area to fill with a solid color. Use with <c>fillcolor</c> if not
        ///     <c>none</c>. scatterternary has a subset of the options available to scatter.
        ///     <c>toself</c> connects the endpoints of the trace (or each segment of the
        ///     trace if it has gaps) into a closed shape. <c>tonext</c> fills the space
        ///     between two traces if one completely encloses the other (eg consecutive
        ///     contour lines), and behaves like <c>toself</c> if there is no trace before
        ///     it. <c>tonext</c> should not be used if one trace does not enclose the other.
        /// </summary>
        [JsonPropertyName(@"fill")]
        public FillEnum? Fill { get; set; }

        /// <summary>
        ///     Sets the fill color. Defaults to a half-transparent variant of the line
        ///     color, marker color, or marker line color, whichever is available.
        /// </summary>
        [JsonPropertyName(@"fillcolor")]
        public object FillColor { get; set; }

        /// <summary>
        ///     Gets or sets the Marker.
        /// </summary>
        [JsonPropertyName(@"marker")]
        public Marker Marker { get; set; }

        /// <summary>
        ///     Sets the text font.
        /// </summary>
        [JsonPropertyName(@"textfont")]
        public TextFont TextFont { get; set; }

        /// <summary>
        ///     Sets the positions of the <c>text</c> elements with respects to the (x,y)
        ///     coordinates.
        /// </summary>
        [JsonPropertyName(@"textposition")]
        public TextPositionEnum? TextPosition { get; set; }

        /// <summary>
        ///     Sets the positions of the <c>text</c> elements with respects to the (x,y)
        ///     coordinates.
        /// </summary>
        [JsonPropertyName(@"textposition")]
        [Array]
        public List<TextPositionEnum?> TextPositionArray { get; set; }

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
        ///     Do the hover effects highlight individual points (markers or line points)
        ///     or do they highlight filled regions? If the fill is <c>toself</c> or <c>tonext</c>
        ///     and there are no markers or text, then the default is <c>fills</c>, otherwise
        ///     it is <c>points</c>.
        /// </summary>
        [JsonPropertyName(@"hoveron")]
        public HoverOnFlag? HoverOn { get; set; }

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
        ///     Sets the source reference on Chart Studio Cloud for  a .
        /// </summary>
        [JsonPropertyName(@"asrc")]
        public string ASrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  b .
        /// </summary>
        [JsonPropertyName(@"bsrc")]
        public string BSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  text .
        /// </summary>
        [JsonPropertyName(@"textsrc")]
        public string TextSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  texttemplate .
        /// </summary>
        [JsonPropertyName(@"texttemplatesrc")]
        public string TextTemplateSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  hovertext .
        /// </summary>
        [JsonPropertyName(@"hovertextsrc")]
        public string HoverTextSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  textposition .
        /// </summary>
        [JsonPropertyName(@"textpositionsrc")]
        public string TextPositionSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  hoverinfo .
        /// </summary>
        [JsonPropertyName(@"hoverinfosrc")]
        public string HoverInfoSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  hovertemplate .
        /// </summary>
        [JsonPropertyName(@"hovertemplatesrc")]
        public string HoverTemplateSrc { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is ScatterCarpet other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] ScatterCarpet other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (Type        == other.Type        && Type        != null && other.Type        != null && Type.Equals(other.Type))                                                                &&
                   (Visible     == other.Visible     && Visible     != null && other.Visible     != null && Visible.Equals(other.Visible))                                                          &&
                   (ShowLegend  == other.ShowLegend  && ShowLegend  != null && other.ShowLegend  != null && ShowLegend.Equals(other.ShowLegend))                                                    &&
                   (LegendGroup == other.LegendGroup && LegendGroup != null && other.LegendGroup != null && LegendGroup.Equals(other.LegendGroup))                                                  &&
                   (Opacity     == other.Opacity     && Opacity     != null && other.Opacity     != null && Opacity.Equals(other.Opacity))                                                          &&
                   (Name        == other.Name        && Name        != null && other.Name        != null && Name.Equals(other.Name))                                                                &&
                   (UId         == other.UId         && UId         != null && other.UId         != null && UId.Equals(other.UId))                                                                  &&
                   (Equals(Ids,        other.Ids)        || Ids        != null && other.Ids        != null && Ids.SequenceEqual(other.Ids))                                                         &&
                   (Equals(CustomData, other.CustomData) || CustomData != null && other.CustomData != null && CustomData.SequenceEqual(other.CustomData))                                           &&
                   (Meta == other.Meta && Meta != null && other.Meta != null && Meta.Equals(other.Meta))                                                                                            &&
                   (Equals(MetaArray, other.MetaArray) || MetaArray != null && other.MetaArray != null && MetaArray.SequenceEqual(other.MetaArray))                                                 &&
                   (SelectedPoints == other.SelectedPoints && SelectedPoints != null && other.SelectedPoints != null && SelectedPoints.Equals(other.SelectedPoints))                                &&
                   (HoverLabel     == other.HoverLabel     && HoverLabel     != null && other.HoverLabel     != null && HoverLabel.Equals(other.HoverLabel))                                        &&
                   (Stream         == other.Stream         && Stream         != null && other.Stream         != null && Stream.Equals(other.Stream))                                                &&
                   (Equals(Transforms, other.Transforms) || Transforms != null && other.Transforms != null && Transforms.SequenceEqual(other.Transforms))                                           &&
                   (UiRevision == other.UiRevision && UiRevision != null && other.UiRevision != null && UiRevision.Equals(other.UiRevision))                                                        &&
                   (Carpet     == other.Carpet     && Carpet     != null && other.Carpet     != null && Carpet.Equals(other.Carpet))                                                                &&
                   (Equals(A, other.A) || A != null && other.A != null && A.SequenceEqual(other.A))                                                                                                 &&
                   (Equals(B, other.B) || B != null && other.B != null && B.SequenceEqual(other.B))                                                                                                 &&
                   (Mode == other.Mode && Mode != null && other.Mode != null && Mode.Equals(other.Mode))                                                                                            &&
                   (Text == other.Text && Text != null && other.Text != null && Text.Equals(other.Text))                                                                                            &&
                   (Equals(TextArray, other.TextArray) || TextArray != null && other.TextArray != null && TextArray.SequenceEqual(other.TextArray))                                                 &&
                   (TextTemplate == other.TextTemplate && TextTemplate != null && other.TextTemplate != null && TextTemplate.Equals(other.TextTemplate))                                            &&
                   (Equals(TextTemplateArray, other.TextTemplateArray) || TextTemplateArray != null && other.TextTemplateArray != null && TextTemplateArray.SequenceEqual(other.TextTemplateArray)) &&
                   (HoverText == other.HoverText && HoverText != null && other.HoverText != null && HoverText.Equals(other.HoverText))                                                              &&
                   (Equals(HoverTextArray, other.HoverTextArray) || HoverTextArray != null && other.HoverTextArray != null && HoverTextArray.SequenceEqual(other.HoverTextArray))                   &&
                   (Line         == other.Line         && Line         != null && other.Line         != null && Line.Equals(other.Line))                                                            &&
                   (ConnectGaps  == other.ConnectGaps  && ConnectGaps  != null && other.ConnectGaps  != null && ConnectGaps.Equals(other.ConnectGaps))                                              &&
                   (Fill         == other.Fill         && Fill         != null && other.Fill         != null && Fill.Equals(other.Fill))                                                            &&
                   (FillColor    == other.FillColor    && FillColor    != null && other.FillColor    != null && FillColor.Equals(other.FillColor))                                                  &&
                   (Marker       == other.Marker       && Marker       != null && other.Marker       != null && Marker.Equals(other.Marker))                                                        &&
                   (TextFont     == other.TextFont     && TextFont     != null && other.TextFont     != null && TextFont.Equals(other.TextFont))                                                    &&
                   (TextPosition == other.TextPosition && TextPosition != null && other.TextPosition != null && TextPosition.Equals(other.TextPosition))                                            &&
                   (Equals(TextPositionArray, other.TextPositionArray) || TextPositionArray != null && other.TextPositionArray != null && TextPositionArray.SequenceEqual(other.TextPositionArray)) &&
                   (Selected   == other.Selected   && Selected   != null && other.Selected   != null && Selected.Equals(other.Selected))                                                            &&
                   (Unselected == other.Unselected && Unselected != null && other.Unselected != null && Unselected.Equals(other.Unselected))                                                        &&
                   (HoverInfo  == other.HoverInfo  && HoverInfo  != null && other.HoverInfo  != null && HoverInfo.Equals(other.HoverInfo))                                                          &&
                   (Equals(HoverInfoArray, other.HoverInfoArray) || HoverInfoArray != null && other.HoverInfoArray != null && HoverInfoArray.SequenceEqual(other.HoverInfoArray))                   &&
                   (HoverOn       == other.HoverOn       && HoverOn       != null && other.HoverOn       != null && HoverOn.Equals(other.HoverOn))                                                  &&
                   (HoverTemplate == other.HoverTemplate && HoverTemplate != null && other.HoverTemplate != null && HoverTemplate.Equals(other.HoverTemplate))                                      &&
                   (Equals(HoverTemplateArray, other.HoverTemplateArray) ||
                    HoverTemplateArray != null && other.HoverTemplateArray != null && HoverTemplateArray.SequenceEqual(other.HoverTemplateArray))                              &&
                   (XAxis            == other.XAxis            && XAxis            != null && other.XAxis            != null && XAxis.Equals(other.XAxis))                     &&
                   (YAxis            == other.YAxis            && YAxis            != null && other.YAxis            != null && YAxis.Equals(other.YAxis))                     &&
                   (IdsSrc           == other.IdsSrc           && IdsSrc           != null && other.IdsSrc           != null && IdsSrc.Equals(other.IdsSrc))                   &&
                   (CustomDataSrc    == other.CustomDataSrc    && CustomDataSrc    != null && other.CustomDataSrc    != null && CustomDataSrc.Equals(other.CustomDataSrc))     &&
                   (MetaSrc          == other.MetaSrc          && MetaSrc          != null && other.MetaSrc          != null && MetaSrc.Equals(other.MetaSrc))                 &&
                   (ASrc             == other.ASrc             && ASrc             != null && other.ASrc             != null && ASrc.Equals(other.ASrc))                       &&
                   (BSrc             == other.BSrc             && BSrc             != null && other.BSrc             != null && BSrc.Equals(other.BSrc))                       &&
                   (TextSrc          == other.TextSrc          && TextSrc          != null && other.TextSrc          != null && TextSrc.Equals(other.TextSrc))                 &&
                   (TextTemplateSrc  == other.TextTemplateSrc  && TextTemplateSrc  != null && other.TextTemplateSrc  != null && TextTemplateSrc.Equals(other.TextTemplateSrc)) &&
                   (HoverTextSrc     == other.HoverTextSrc     && HoverTextSrc     != null && other.HoverTextSrc     != null && HoverTextSrc.Equals(other.HoverTextSrc))       &&
                   (TextPositionSrc  == other.TextPositionSrc  && TextPositionSrc  != null && other.TextPositionSrc  != null && TextPositionSrc.Equals(other.TextPositionSrc)) &&
                   (HoverInfoSrc     == other.HoverInfoSrc     && HoverInfoSrc     != null && other.HoverInfoSrc     != null && HoverInfoSrc.Equals(other.HoverInfoSrc))       &&
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

                if(Carpet != null)
                    hashCode = hashCode * 59 + Carpet.GetHashCode();

                if(A != null)
                    hashCode = hashCode * 59 + A.GetHashCode();

                if(B != null)
                    hashCode = hashCode * 59 + B.GetHashCode();

                if(Mode != null)
                    hashCode = hashCode * 59 + Mode.GetHashCode();

                if(Text != null)
                    hashCode = hashCode * 59 + Text.GetHashCode();

                if(TextArray != null)
                    hashCode = hashCode * 59 + TextArray.GetHashCode();

                if(TextTemplate != null)
                    hashCode = hashCode * 59 + TextTemplate.GetHashCode();

                if(TextTemplateArray != null)
                    hashCode = hashCode * 59 + TextTemplateArray.GetHashCode();

                if(HoverText != null)
                    hashCode = hashCode * 59 + HoverText.GetHashCode();

                if(HoverTextArray != null)
                    hashCode = hashCode * 59 + HoverTextArray.GetHashCode();

                if(Line != null)
                    hashCode = hashCode * 59 + Line.GetHashCode();

                if(ConnectGaps != null)
                    hashCode = hashCode * 59 + ConnectGaps.GetHashCode();

                if(Fill != null)
                    hashCode = hashCode * 59 + Fill.GetHashCode();

                if(FillColor != null)
                    hashCode = hashCode * 59 + FillColor.GetHashCode();

                if(Marker != null)
                    hashCode = hashCode * 59 + Marker.GetHashCode();

                if(TextFont != null)
                    hashCode = hashCode * 59 + TextFont.GetHashCode();

                if(TextPosition != null)
                    hashCode = hashCode * 59 + TextPosition.GetHashCode();

                if(TextPositionArray != null)
                    hashCode = hashCode * 59 + TextPositionArray.GetHashCode();

                if(Selected != null)
                    hashCode = hashCode * 59 + Selected.GetHashCode();

                if(Unselected != null)
                    hashCode = hashCode * 59 + Unselected.GetHashCode();

                if(HoverInfo != null)
                    hashCode = hashCode * 59 + HoverInfo.GetHashCode();

                if(HoverInfoArray != null)
                    hashCode = hashCode * 59 + HoverInfoArray.GetHashCode();

                if(HoverOn != null)
                    hashCode = hashCode * 59 + HoverOn.GetHashCode();

                if(HoverTemplate != null)
                    hashCode = hashCode * 59 + HoverTemplate.GetHashCode();

                if(HoverTemplateArray != null)
                    hashCode = hashCode * 59 + HoverTemplateArray.GetHashCode();

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

                if(ASrc != null)
                    hashCode = hashCode * 59 + ASrc.GetHashCode();

                if(BSrc != null)
                    hashCode = hashCode * 59 + BSrc.GetHashCode();

                if(TextSrc != null)
                    hashCode = hashCode * 59 + TextSrc.GetHashCode();

                if(TextTemplateSrc != null)
                    hashCode = hashCode * 59 + TextTemplateSrc.GetHashCode();

                if(HoverTextSrc != null)
                    hashCode = hashCode * 59 + HoverTextSrc.GetHashCode();

                if(TextPositionSrc != null)
                    hashCode = hashCode * 59 + TextPositionSrc.GetHashCode();

                if(HoverInfoSrc != null)
                    hashCode = hashCode * 59 + HoverInfoSrc.GetHashCode();

                if(HoverTemplateSrc != null)
                    hashCode = hashCode * 59 + HoverTemplateSrc.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left ScatterCarpet and the right ScatterCarpet.
        /// </summary>
        /// <param name="left">Left ScatterCarpet.</param>
        /// <param name="right">Right ScatterCarpet.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(ScatterCarpet left,
                                       ScatterCarpet right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left ScatterCarpet and the right ScatterCarpet.
        /// </summary>
        /// <param name="left">Left ScatterCarpet.</param>
        /// <param name="right">Right ScatterCarpet.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(ScatterCarpet left,
                                       ScatterCarpet right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>ScatterCarpet</returns>
        public ScatterCarpet DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<ScatterCarpet>(ms).Result;
        }
    }
}
