using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Traces.Pies;

using Stream = Plotly.Models.Traces.Pies.Stream;

namespace Plotly.Models.Traces
{
    /// <summary>
    ///     The Pie class.
    ///     Implements the <see cref="ITrace" />.
    /// </summary>
    [JsonConverter(typeof(PlotlyConverter))]
    [Serializable]
    public class Pie : ITrace, IEquatable<Pie>
    {
        /// <inheritdoc/>
        [JsonPropertyName(@"type")]
        public TraceTypeEnum? Type { get; } = TraceTypeEnum.Pie;

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
        ///     Sets the sector labels. If <c>labels</c> entries are duplicated, we sum
        ///     associated <c>values</c> or simply count occurrences if <c>values</c> is
        ///     not provided. For other array attributes (including color) we use the first
        ///     non-empty entry among all occurrences of the label.
        /// </summary>
        [JsonPropertyName(@"labels")]
        public List<object>? Labels { get; set; }

        /// <summary>
        ///     Alternate to <c>labels</c>. Builds a numeric set of labels. Use with <c>dlabel</c>
        ///     where <c>label0</c> is the starting label and <c>dlabel</c> the step.
        /// </summary>
        [JsonPropertyName(@"label0")]
        public JsNumber? Label0 { get; set; }

        /// <summary>
        ///     Sets the label step. See <c>label0</c> for more info.
        /// </summary>
        [JsonPropertyName(@"dlabel")]
        public JsNumber? DLabel { get; set; }

        /// <summary>
        ///     Sets the values of the sectors. If omitted, we count occurrences of each
        ///     label.
        /// </summary>
        [JsonPropertyName(@"values")]
        public List<object>? Values { get; set; }

        /// <summary>
        ///     Gets or sets the Marker.
        /// </summary>
        [JsonPropertyName(@"marker")]
        public Marker? Marker { get; set; }

        /// <summary>
        ///     Sets text elements associated with each sector. If trace <c>textinfo</c>
        ///     contains a <c>text</c> flag, these elements will be seen on the chart. If
        ///     trace <c>hoverinfo</c> contains a <c>text</c> flag and <c>hovertext</c>
        ///     is not set, these elements will be seen in the hover labels.
        /// </summary>
        [JsonPropertyName(@"text")]
        public List<object>? Text { get; set; }

        /// <summary>
        ///     Sets hover text elements associated with each sector. If a single string,
        ///     the same string appears for all data points. If an array of string, the
        ///     items are mapped in order of this trace&#39;s sectors. To be seen, trace
        ///     <c>hoverinfo</c> must contain a <c>text</c> flag.
        /// </summary>
        [JsonPropertyName(@"hovertext")]
        public string? HoverText { get; set; }

        /// <summary>
        ///     Sets hover text elements associated with each sector. If a single string,
        ///     the same string appears for all data points. If an array of string, the
        ///     items are mapped in order of this trace&#39;s sectors. To be seen, trace
        ///     <c>hoverinfo</c> must contain a <c>text</c> flag.
        /// </summary>
        [JsonPropertyName(@"hovertext")]
        [Array]
        public List<string>? HoverTextArray { get; set; }

        /// <summary>
        ///     If there are multiple pie charts that should be sized according to their
        ///     totals, link them by providing a non-empty group id here shared by every
        ///     trace in the same group.
        /// </summary>
        [JsonPropertyName(@"scalegroup")]
        public string? ScaleGroup { get; set; }

        /// <summary>
        ///     Determines which trace information appear on the graph.
        /// </summary>
        [JsonPropertyName(@"textinfo")]
        public TextInfoFlag? TextInfo { get; set; }

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
        ///     that are &#39;arrayOk: true&#39;) are available. variables <c>label</c>,
        ///     <c>color</c>, <c>value</c>, <c>percent</c> and <c>text</c>. Anything contained
        ///     in tag <c>&lt;extra&gt;</c> is displayed in the secondary box, for example
        ///     <c>&lt;extra&gt;{fullData.name}&lt;/extra&gt;</c>. To hide the secondary
        ///     box completely, use an empty tag <c>&lt;extra&gt;&lt;/extra&gt;</c>.
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
        ///     that are &#39;arrayOk: true&#39;) are available. variables <c>label</c>,
        ///     <c>color</c>, <c>value</c>, <c>percent</c> and <c>text</c>. Anything contained
        ///     in tag <c>&lt;extra&gt;</c> is displayed in the secondary box, for example
        ///     <c>&lt;extra&gt;{fullData.name}&lt;/extra&gt;</c>. To hide the secondary
        ///     box completely, use an empty tag <c>&lt;extra&gt;&lt;/extra&gt;</c>.
        /// </summary>
        [JsonPropertyName(@"hovertemplate")]
        [Array]
        public List<string>? HoverTemplateArray { get; set; }

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
        ///     variables <c>label</c>, <c>color</c>, <c>value</c>, <c>percent</c> and <c>text</c>.
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
        ///     variables <c>label</c>, <c>color</c>, <c>value</c>, <c>percent</c> and <c>text</c>.
        /// </summary>
        [JsonPropertyName(@"texttemplate")]
        [Array]
        public List<string>? TextTemplateArray { get; set; }

        /// <summary>
        ///     Specifies the location of the <c>textinfo</c>.
        /// </summary>
        [JsonPropertyName(@"textposition")]
        public TextPositionEnum? TextPosition { get; set; }

        /// <summary>
        ///     Specifies the location of the <c>textinfo</c>.
        /// </summary>
        [JsonPropertyName(@"textposition")]
        [Array]
        public List<TextPositionEnum?>? TextPositionArray { get; set; }

        /// <summary>
        ///     Sets the font used for <c>textinfo</c>.
        /// </summary>
        [JsonPropertyName(@"textfont")]
        public TextFont? TextFont { get; set; }

        /// <summary>
        ///     Controls the orientation of the text inside chart sectors. When set to <c>auto</c>,
        ///     text may be oriented in any direction in order to be as big as possible
        ///     in the middle of a sector. The <c>horizontal</c> option orients text to
        ///     be parallel with the bottom of the chart, and may make text smaller in order
        ///     to achieve that goal. The <c>radial</c> option orients text along the radius
        ///     of the sector. The <c>tangential</c> option orients text perpendicular to
        ///     the radius of the sector.
        /// </summary>
        [JsonPropertyName(@"insidetextorientation")]
        public InsideTextOrientationEnum? InsideTextOrientation { get; set; }

        /// <summary>
        ///     Sets the font used for <c>textinfo</c> lying inside the sector.
        /// </summary>
        [JsonPropertyName(@"insidetextfont")]
        public InsideTextFont? InsideTextFont { get; set; }

        /// <summary>
        ///     Sets the font used for <c>textinfo</c> lying outside the sector.
        /// </summary>
        [JsonPropertyName(@"outsidetextfont")]
        public OutsideTextFont? OutsideTextFont { get; set; }

        /// <summary>
        ///     Determines whether outside text labels can push the margins.
        /// </summary>
        [JsonPropertyName(@"automargin")]
        public bool? AutoMargin { get; set; }

        /// <summary>
        ///     Gets or sets the Title.
        /// </summary>
        [JsonPropertyName(@"title")]
        public Title? Title { get; set; }

        /// <summary>
        ///     Gets or sets the Domain.
        /// </summary>
        [JsonPropertyName(@"domain")]
        public Domain? Domain { get; set; }

        /// <summary>
        ///     Sets the fraction of the radius to cut out of the pie. Use this to make
        ///     a donut chart.
        /// </summary>
        [JsonPropertyName(@"hole")]
        public JsNumber? Hole { get; set; }

        /// <summary>
        ///     Determines whether or not the sectors are reordered from largest to smallest.
        /// </summary>
        [JsonPropertyName(@"sort")]
        public bool? Sort { get; set; }

        /// <summary>
        ///     Specifies the direction at which succeeding sectors follow one another.
        /// </summary>
        [JsonPropertyName(@"direction")]
        public DirectionEnum? Direction { get; set; }

        /// <summary>
        ///     Instead of the first slice starting at 12 o&#39;clock, rotate to some other
        ///     angle.
        /// </summary>
        [JsonPropertyName(@"rotation")]
        public JsNumber? Rotation { get; set; }

        /// <summary>
        ///     Sets the fraction of larger radius to pull the sectors out from the center.
        ///     This can be a constant to pull all slices apart from each other equally
        ///     or an array to highlight one or more slices.
        /// </summary>
        [JsonPropertyName(@"pull")]
        public JsNumber? Pull { get; set; }

        /// <summary>
        ///     Sets the fraction of larger radius to pull the sectors out from the center.
        ///     This can be a constant to pull all slices apart from each other equally
        ///     or an array to highlight one or more slices.
        /// </summary>
        [JsonPropertyName(@"pull")]
        [Array]
        public List<JsNumber?>? PullArray { get; set; }

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
        ///     Sets the source reference on Chart Studio Cloud for  labels .
        /// </summary>
        [JsonPropertyName(@"labelssrc")]
        public string? LabelsSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  values .
        /// </summary>
        [JsonPropertyName(@"valuessrc")]
        public string? ValuesSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  text .
        /// </summary>
        [JsonPropertyName(@"textsrc")]
        public string? TextSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  hovertext .
        /// </summary>
        [JsonPropertyName(@"hovertextsrc")]
        public string? HoverTextSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  hoverinfo .
        /// </summary>
        [JsonPropertyName(@"hoverinfosrc")]
        public string? HoverInfoSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  hovertemplate .
        /// </summary>
        [JsonPropertyName(@"hovertemplatesrc")]
        public string? HoverTemplateSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  texttemplate .
        /// </summary>
        [JsonPropertyName(@"texttemplatesrc")]
        public string? TextTemplateSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  textposition .
        /// </summary>
        [JsonPropertyName(@"textpositionsrc")]
        public string? TextPositionSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  pull .
        /// </summary>
        [JsonPropertyName(@"pullsrc")]
        public string? PullSrc { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is Pie other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] Pie other)
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
                   (HoverLabel == other.HoverLabel && HoverLabel != null && other.HoverLabel != null && HoverLabel.Equals(other.HoverLabel))                                      &&
                   (Stream     == other.Stream     && Stream     != null && other.Stream     != null && Stream.Equals(other.Stream))                                              &&
                   (Equals(Transforms, other.Transforms) || Transforms != null && other.Transforms != null && Transforms.SequenceEqual(other.Transforms))                         &&
                   (UiRevision == other.UiRevision && UiRevision != null && other.UiRevision != null && UiRevision.Equals(other.UiRevision))                                      &&
                   (Equals(Labels, other.Labels) || Labels != null && other.Labels != null && Labels.SequenceEqual(other.Labels))                                                 &&
                   (Label0 == other.Label0 && Label0 != null && other.Label0 != null && Label0.Equals(other.Label0))                                                              &&
                   (DLabel == other.DLabel && DLabel != null && other.DLabel != null && DLabel.Equals(other.DLabel))                                                              &&
                   (Equals(Values, other.Values) || Values != null && other.Values != null && Values.SequenceEqual(other.Values))                                                 &&
                   (Marker == other.Marker && Marker != null && other.Marker != null && Marker.Equals(other.Marker))                                                              &&
                   (Equals(Text, other.Text) || Text != null && other.Text != null && Text.SequenceEqual(other.Text))                                                             &&
                   (HoverText == other.HoverText && HoverText != null && other.HoverText != null && HoverText.Equals(other.HoverText))                                            &&
                   (Equals(HoverTextArray, other.HoverTextArray) || HoverTextArray != null && other.HoverTextArray != null && HoverTextArray.SequenceEqual(other.HoverTextArray)) &&
                   (ScaleGroup == other.ScaleGroup && ScaleGroup != null && other.ScaleGroup != null && ScaleGroup.Equals(other.ScaleGroup))                                      &&
                   (TextInfo   == other.TextInfo   && TextInfo   != null && other.TextInfo   != null && TextInfo.Equals(other.TextInfo))                                          &&
                   (HoverInfo  == other.HoverInfo  && HoverInfo  != null && other.HoverInfo  != null && HoverInfo.Equals(other.HoverInfo))                                        &&
                   (Equals(HoverInfoArray, other.HoverInfoArray) || HoverInfoArray != null && other.HoverInfoArray != null && HoverInfoArray.SequenceEqual(other.HoverInfoArray)) &&
                   (HoverTemplate == other.HoverTemplate && HoverTemplate != null && other.HoverTemplate != null && HoverTemplate.Equals(other.HoverTemplate))                    &&
                   (Equals(HoverTemplateArray, other.HoverTemplateArray) ||
                    HoverTemplateArray != null && other.HoverTemplateArray != null && HoverTemplateArray.SequenceEqual(other.HoverTemplateArray))                                                   &&
                   (TextTemplate == other.TextTemplate && TextTemplate != null && other.TextTemplate != null && TextTemplate.Equals(other.TextTemplate))                                            &&
                   (Equals(TextTemplateArray, other.TextTemplateArray) || TextTemplateArray != null && other.TextTemplateArray != null && TextTemplateArray.SequenceEqual(other.TextTemplateArray)) &&
                   (TextPosition == other.TextPosition && TextPosition != null && other.TextPosition != null && TextPosition.Equals(other.TextPosition))                                            &&
                   (Equals(TextPositionArray, other.TextPositionArray) || TextPositionArray != null && other.TextPositionArray != null && TextPositionArray.SequenceEqual(other.TextPositionArray)) &&
                   (TextFont == other.TextFont && TextFont != null && other.TextFont != null && TextFont.Equals(other.TextFont))                                                                    &&
                   (InsideTextOrientation       == other.InsideTextOrientation &&
                    InsideTextOrientation       != null                        &&
                    other.InsideTextOrientation != null                        &&
                    InsideTextOrientation.Equals(other.InsideTextOrientation))                                                                                                   &&
                   (InsideTextFont  == other.InsideTextFont  && InsideTextFont  != null && other.InsideTextFont  != null && InsideTextFont.Equals(other.InsideTextFont))         &&
                   (OutsideTextFont == other.OutsideTextFont && OutsideTextFont != null && other.OutsideTextFont != null && OutsideTextFont.Equals(other.OutsideTextFont))       &&
                   (AutoMargin      == other.AutoMargin      && AutoMargin      != null && other.AutoMargin      != null && AutoMargin.Equals(other.AutoMargin))                 &&
                   (Title           == other.Title           && Title           != null && other.Title           != null && Title.Equals(other.Title))                           &&
                   (Domain          == other.Domain          && Domain          != null && other.Domain          != null && Domain.Equals(other.Domain))                         &&
                   (Hole            == other.Hole            && Hole            != null && other.Hole            != null && Hole.Equals(other.Hole))                             &&
                   (Sort            == other.Sort            && Sort            != null && other.Sort            != null && Sort.Equals(other.Sort))                             &&
                   (Direction       == other.Direction       && Direction       != null && other.Direction       != null && Direction.Equals(other.Direction))                   &&
                   (Rotation        == other.Rotation        && Rotation        != null && other.Rotation        != null && Rotation.Equals(other.Rotation))                     &&
                   (Pull            == other.Pull            && Pull            != null && other.Pull            != null && Pull.Equals(other.Pull))                             &&
                   (Equals(PullArray, other.PullArray) || PullArray != null && other.PullArray != null && PullArray.SequenceEqual(other.PullArray))                              &&
                   (IdsSrc           == other.IdsSrc           && IdsSrc           != null && other.IdsSrc           != null && IdsSrc.Equals(other.IdsSrc))                     &&
                   (CustomDataSrc    == other.CustomDataSrc    && CustomDataSrc    != null && other.CustomDataSrc    != null && CustomDataSrc.Equals(other.CustomDataSrc))       &&
                   (MetaSrc          == other.MetaSrc          && MetaSrc          != null && other.MetaSrc          != null && MetaSrc.Equals(other.MetaSrc))                   &&
                   (LabelsSrc        == other.LabelsSrc        && LabelsSrc        != null && other.LabelsSrc        != null && LabelsSrc.Equals(other.LabelsSrc))               &&
                   (ValuesSrc        == other.ValuesSrc        && ValuesSrc        != null && other.ValuesSrc        != null && ValuesSrc.Equals(other.ValuesSrc))               &&
                   (TextSrc          == other.TextSrc          && TextSrc          != null && other.TextSrc          != null && TextSrc.Equals(other.TextSrc))                   &&
                   (HoverTextSrc     == other.HoverTextSrc     && HoverTextSrc     != null && other.HoverTextSrc     != null && HoverTextSrc.Equals(other.HoverTextSrc))         &&
                   (HoverInfoSrc     == other.HoverInfoSrc     && HoverInfoSrc     != null && other.HoverInfoSrc     != null && HoverInfoSrc.Equals(other.HoverInfoSrc))         &&
                   (HoverTemplateSrc == other.HoverTemplateSrc && HoverTemplateSrc != null && other.HoverTemplateSrc != null && HoverTemplateSrc.Equals(other.HoverTemplateSrc)) &&
                   (TextTemplateSrc  == other.TextTemplateSrc  && TextTemplateSrc  != null && other.TextTemplateSrc  != null && TextTemplateSrc.Equals(other.TextTemplateSrc))   &&
                   (TextPositionSrc  == other.TextPositionSrc  && TextPositionSrc  != null && other.TextPositionSrc  != null && TextPositionSrc.Equals(other.TextPositionSrc))   &&
                   (PullSrc          == other.PullSrc          && PullSrc          != null && other.PullSrc          != null && PullSrc.Equals(other.PullSrc));
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

                if(HoverLabel != null)
                    hashCode = hashCode * 59 + HoverLabel.GetHashCode();

                if(Stream != null)
                    hashCode = hashCode * 59 + Stream.GetHashCode();

                if(Transforms != null)
                    hashCode = hashCode * 59 + Transforms.GetHashCode();

                if(UiRevision != null)
                    hashCode = hashCode * 59 + UiRevision.GetHashCode();

                if(Labels != null)
                    hashCode = hashCode * 59 + Labels.GetHashCode();

                if(Label0 != null)
                    hashCode = hashCode * 59 + Label0.GetHashCode();

                if(DLabel != null)
                    hashCode = hashCode * 59 + DLabel.GetHashCode();

                if(Values != null)
                    hashCode = hashCode * 59 + Values.GetHashCode();

                if(Marker != null)
                    hashCode = hashCode * 59 + Marker.GetHashCode();

                if(Text != null)
                    hashCode = hashCode * 59 + Text.GetHashCode();

                if(HoverText != null)
                    hashCode = hashCode * 59 + HoverText.GetHashCode();

                if(HoverTextArray != null)
                    hashCode = hashCode * 59 + HoverTextArray.GetHashCode();

                if(ScaleGroup != null)
                    hashCode = hashCode * 59 + ScaleGroup.GetHashCode();

                if(TextInfo != null)
                    hashCode = hashCode * 59 + TextInfo.GetHashCode();

                if(HoverInfo != null)
                    hashCode = hashCode * 59 + HoverInfo.GetHashCode();

                if(HoverInfoArray != null)
                    hashCode = hashCode * 59 + HoverInfoArray.GetHashCode();

                if(HoverTemplate != null)
                    hashCode = hashCode * 59 + HoverTemplate.GetHashCode();

                if(HoverTemplateArray != null)
                    hashCode = hashCode * 59 + HoverTemplateArray.GetHashCode();

                if(TextTemplate != null)
                    hashCode = hashCode * 59 + TextTemplate.GetHashCode();

                if(TextTemplateArray != null)
                    hashCode = hashCode * 59 + TextTemplateArray.GetHashCode();

                if(TextPosition != null)
                    hashCode = hashCode * 59 + TextPosition.GetHashCode();

                if(TextPositionArray != null)
                    hashCode = hashCode * 59 + TextPositionArray.GetHashCode();

                if(TextFont != null)
                    hashCode = hashCode * 59 + TextFont.GetHashCode();

                if(InsideTextOrientation != null)
                    hashCode = hashCode * 59 + InsideTextOrientation.GetHashCode();

                if(InsideTextFont != null)
                    hashCode = hashCode * 59 + InsideTextFont.GetHashCode();

                if(OutsideTextFont != null)
                    hashCode = hashCode * 59 + OutsideTextFont.GetHashCode();

                if(AutoMargin != null)
                    hashCode = hashCode * 59 + AutoMargin.GetHashCode();

                if(Title != null)
                    hashCode = hashCode * 59 + Title.GetHashCode();

                if(Domain != null)
                    hashCode = hashCode * 59 + Domain.GetHashCode();

                if(Hole != null)
                    hashCode = hashCode * 59 + Hole.GetHashCode();

                if(Sort != null)
                    hashCode = hashCode * 59 + Sort.GetHashCode();

                if(Direction != null)
                    hashCode = hashCode * 59 + Direction.GetHashCode();

                if(Rotation != null)
                    hashCode = hashCode * 59 + Rotation.GetHashCode();

                if(Pull != null)
                    hashCode = hashCode * 59 + Pull.GetHashCode();

                if(PullArray != null)
                    hashCode = hashCode * 59 + PullArray.GetHashCode();

                if(IdsSrc != null)
                    hashCode = hashCode * 59 + IdsSrc.GetHashCode();

                if(CustomDataSrc != null)
                    hashCode = hashCode * 59 + CustomDataSrc.GetHashCode();

                if(MetaSrc != null)
                    hashCode = hashCode * 59 + MetaSrc.GetHashCode();

                if(LabelsSrc != null)
                    hashCode = hashCode * 59 + LabelsSrc.GetHashCode();

                if(ValuesSrc != null)
                    hashCode = hashCode * 59 + ValuesSrc.GetHashCode();

                if(TextSrc != null)
                    hashCode = hashCode * 59 + TextSrc.GetHashCode();

                if(HoverTextSrc != null)
                    hashCode = hashCode * 59 + HoverTextSrc.GetHashCode();

                if(HoverInfoSrc != null)
                    hashCode = hashCode * 59 + HoverInfoSrc.GetHashCode();

                if(HoverTemplateSrc != null)
                    hashCode = hashCode * 59 + HoverTemplateSrc.GetHashCode();

                if(TextTemplateSrc != null)
                    hashCode = hashCode * 59 + TextTemplateSrc.GetHashCode();

                if(TextPositionSrc != null)
                    hashCode = hashCode * 59 + TextPositionSrc.GetHashCode();

                if(PullSrc != null)
                    hashCode = hashCode * 59 + PullSrc.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Pie and the right Pie.
        /// </summary>
        /// <param name="left">Left Pie.</param>
        /// <param name="right">Right Pie.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(Pie left,
                                       Pie right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Pie and the right Pie.
        /// </summary>
        /// <param name="left">Left Pie.</param>
        /// <param name="right">Right Pie.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(Pie left,
                                       Pie right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Pie</returns>
        public Pie DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<Pie>(ms).Result;
        }
    }
}
