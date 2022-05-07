using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Traces.TreeMaps;

using Stream = Plotly.Models.Traces.TreeMaps.Stream;

namespace Plotly.Models.Traces
{
    /// <summary>
    ///     The TreeMap class.
    ///     Implements the <see cref="ITrace" />.
    /// </summary>
    [JsonConverter(typeof(PlotlyConverter))]
    [Serializable]
    public class TreeMap : ITrace, IEquatable<TreeMap>
    {
        /// <inheritdoc/>
        [JsonPropertyName(@"type")]
        public TraceTypeEnum? Type { get; } = TraceTypeEnum.TreeMap;

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
        ///     Sets the labels of each of the sectors.
        /// </summary>
        [JsonPropertyName(@"labels")]
        public List<object>? Labels { get; set; }

        /// <summary>
        ///     Sets the parent sectors for each of the sectors. Empty string items &#39;&#39;
        ///     are understood to reference the root node in the hierarchy. If <c>ids</c>
        ///     is filled, <c>parents</c> items are understood to be <c>ids</c> themselves.
        ///     When <c>ids</c> is not set, plotly attempts to find matching items in <c>labels</c>,
        ///     but beware they must be unique.
        /// </summary>
        [JsonPropertyName(@"parents")]
        public List<object>? Parents { get; set; }

        /// <summary>
        ///     Sets the values associated with each of the sectors. Use with <c>branchvalues</c>
        ///     to determine how the values are summed.
        /// </summary>
        [JsonPropertyName(@"values")]
        public List<object>? Values { get; set; }

        /// <summary>
        ///     Determines how the items in <c>values</c> are summed. When set to <c>total</c>,
        ///     items in <c>values</c> are taken to be value of all its descendants. When
        ///     set to <c>remainder</c>, items in <c>values</c> corresponding to the root
        ///     and the branches sectors are taken to be the extra part not part of the
        ///     sum of the values at their leaves.
        /// </summary>
        [JsonPropertyName(@"branchvalues")]
        public BranchValuesEnum? BranchValues { get; set; }

        /// <summary>
        ///     Determines default for <c>values</c> when it is not provided, by inferring
        ///     a 1 for each of the <c>leaves</c> and/or <c>branches</c>, otherwise 0.
        /// </summary>
        [JsonPropertyName(@"count")]
        public CountFlag? Count { get; set; }

        /// <summary>
        ///     Sets the level from which this trace hierarchy is rendered. Set <c>level</c>
        ///     to <c>&#39;&#39;</c> to start from the root node in the hierarchy. Must
        ///     be an <c>id</c> if <c>ids</c> is filled in, otherwise plotly attempts to
        ///     find a matching item in <c>labels</c>.
        /// </summary>
        [JsonPropertyName(@"level")]
        public object? Level { get; set; }

        /// <summary>
        ///     Sets the number of rendered sectors from any given <c>level</c>. Set <c>maxdepth</c>
        ///     to <c>-1</c> to render all the levels in the hierarchy.
        /// </summary>
        [JsonPropertyName(@"maxdepth")]
        public int? MaxDepth { get; set; }

        /// <summary>
        ///     Gets or sets the Tiling.
        /// </summary>
        [JsonPropertyName(@"tiling")]
        public Tiling? Tiling { get; set; }

        /// <summary>
        ///     Gets or sets the Marker.
        /// </summary>
        [JsonPropertyName(@"marker")]
        public Marker? Marker { get; set; }

        /// <summary>
        ///     Gets or sets the PathBar.
        /// </summary>
        [JsonPropertyName(@"pathbar")]
        public PathBar? PathBar { get; set; }

        /// <summary>
        ///     Sets text elements associated with each sector. If trace <c>textinfo</c>
        ///     contains a <c>text</c> flag, these elements will be seen on the chart. If
        ///     trace <c>hoverinfo</c> contains a <c>text</c> flag and <c>hovertext</c>
        ///     is not set, these elements will be seen in the hover labels.
        /// </summary>
        [JsonPropertyName(@"text")]
        public List<object>? Text { get; set; }

        /// <summary>
        ///     Determines which trace information appear on the graph.
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
        ///     variables <c>currentPath</c>, <c>root</c>, <c>entry</c>, <c>percentRoot</c>,
        ///     <c>percentEntry</c>, <c>percentParent</c>, <c>label</c> and <c>value</c>.
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
        ///     variables <c>currentPath</c>, <c>root</c>, <c>entry</c>, <c>percentRoot</c>,
        ///     <c>percentEntry</c>, <c>percentParent</c>, <c>label</c> and <c>value</c>.
        /// </summary>
        [JsonPropertyName(@"texttemplate")]
        [Array]
        public List<string>? TextTemplateArray { get; set; }

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
        ///     that are &#39;arrayOk: true&#39;) are available. variables <c>currentPath</c>,
        ///     <c>root</c>, <c>entry</c>, <c>percentRoot</c>, <c>percentEntry</c> and <c>percentParent</c>.
        ///     Anything contained in tag <c>&lt;extra&gt;</c> is displayed in the secondary
        ///     box, for example <c>&lt;extra&gt;{fullData.name}&lt;/extra&gt;</c>. To hide
        ///     the secondary box completely, use an empty tag <c>&lt;extra&gt;&lt;/extra&gt;</c>.
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
        ///     that are &#39;arrayOk: true&#39;) are available. variables <c>currentPath</c>,
        ///     <c>root</c>, <c>entry</c>, <c>percentRoot</c>, <c>percentEntry</c> and <c>percentParent</c>.
        ///     Anything contained in tag <c>&lt;extra&gt;</c> is displayed in the secondary
        ///     box, for example <c>&lt;extra&gt;{fullData.name}&lt;/extra&gt;</c>. To hide
        ///     the secondary box completely, use an empty tag <c>&lt;extra&gt;&lt;/extra&gt;</c>.
        /// </summary>
        [JsonPropertyName(@"hovertemplate")]
        [Array]
        public List<string>? HoverTemplateArray { get; set; }

        /// <summary>
        ///     Sets the font used for <c>textinfo</c>.
        /// </summary>
        [JsonPropertyName(@"textfont")]
        public TextFont? TextFont { get; set; }

        /// <summary>
        ///     Sets the font used for <c>textinfo</c> lying inside the sector.
        /// </summary>
        [JsonPropertyName(@"insidetextfont")]
        public InsideTextFont? InsideTextFont { get; set; }

        /// <summary>
        ///     Sets the font used for <c>textinfo</c> lying outside the sector. This option
        ///     refers to the root of the hierarchy presented on top left corner of a treemap
        ///     graph. Please note that if a hierarchy has multiple root nodes, this option
        ///     won&#39;t have any effect and <c>insidetextfont</c> would be used.
        /// </summary>
        [JsonPropertyName(@"outsidetextfont")]
        public OutsideTextFont? OutsideTextFont { get; set; }

        /// <summary>
        ///     Sets the positions of the <c>text</c> elements.
        /// </summary>
        [JsonPropertyName(@"textposition")]
        public TextPositionEnum? TextPosition { get; set; }

        /// <summary>
        ///     Gets or sets the Domain.
        /// </summary>
        [JsonPropertyName(@"domain")]
        public Domain? Domain { get; set; }

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
        ///     Sets the source reference on Chart Studio Cloud for  parents .
        /// </summary>
        [JsonPropertyName(@"parentssrc")]
        public string? ParentsSrc { get; set; }

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
        ///     Sets the source reference on Chart Studio Cloud for  texttemplate .
        /// </summary>
        [JsonPropertyName(@"texttemplatesrc")]
        public string? TextTemplateSrc { get; set; }

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

        public override bool Equals(object obj)
        {
            if(!(obj is TreeMap other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] TreeMap other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (Type    == other.Type    && Type    != null && other.Type    != null && Type.Equals(other.Type))                                                                                &&
                   (Visible == other.Visible && Visible != null && other.Visible != null && Visible.Equals(other.Visible))                                                                          &&
                   (Opacity == other.Opacity && Opacity != null && other.Opacity != null && Opacity.Equals(other.Opacity))                                                                          &&
                   (Name    == other.Name    && Name    != null && other.Name    != null && Name.Equals(other.Name))                                                                                &&
                   (UId     == other.UId     && UId     != null && other.UId     != null && UId.Equals(other.UId))                                                                                  &&
                   (Equals(Ids,        other.Ids)        || Ids        != null && other.Ids        != null && Ids.SequenceEqual(other.Ids))                                                         &&
                   (Equals(CustomData, other.CustomData) || CustomData != null && other.CustomData != null && CustomData.SequenceEqual(other.CustomData))                                           &&
                   (Meta == other.Meta && Meta != null && other.Meta != null && Meta.Equals(other.Meta))                                                                                            &&
                   (Equals(MetaArray, other.MetaArray) || MetaArray != null && other.MetaArray != null && MetaArray.SequenceEqual(other.MetaArray))                                                 &&
                   (HoverLabel == other.HoverLabel && HoverLabel != null && other.HoverLabel != null && HoverLabel.Equals(other.HoverLabel))                                                        &&
                   (Stream     == other.Stream     && Stream     != null && other.Stream     != null && Stream.Equals(other.Stream))                                                                &&
                   (Equals(Transforms, other.Transforms) || Transforms != null && other.Transforms != null && Transforms.SequenceEqual(other.Transforms))                                           &&
                   (UiRevision == other.UiRevision && UiRevision != null && other.UiRevision != null && UiRevision.Equals(other.UiRevision))                                                        &&
                   (Equals(Labels,  other.Labels)  || Labels  != null && other.Labels  != null && Labels.SequenceEqual(other.Labels))                                                               &&
                   (Equals(Parents, other.Parents) || Parents != null && other.Parents != null && Parents.SequenceEqual(other.Parents))                                                             &&
                   (Equals(Values,  other.Values)  || Values  != null && other.Values  != null && Values.SequenceEqual(other.Values))                                                               &&
                   (BranchValues == other.BranchValues && BranchValues != null && other.BranchValues != null && BranchValues.Equals(other.BranchValues))                                            &&
                   (Count        == other.Count        && Count        != null && other.Count        != null && Count.Equals(other.Count))                                                          &&
                   (Level        == other.Level        && Level        != null && other.Level        != null && Level.Equals(other.Level))                                                          &&
                   (MaxDepth     == other.MaxDepth     && MaxDepth     != null && other.MaxDepth     != null && MaxDepth.Equals(other.MaxDepth))                                                    &&
                   (Tiling       == other.Tiling       && Tiling       != null && other.Tiling       != null && Tiling.Equals(other.Tiling))                                                        &&
                   (Marker       == other.Marker       && Marker       != null && other.Marker       != null && Marker.Equals(other.Marker))                                                        &&
                   (PathBar      == other.PathBar      && PathBar      != null && other.PathBar      != null && PathBar.Equals(other.PathBar))                                                      &&
                   (Equals(Text, other.Text) || Text != null && other.Text != null && Text.SequenceEqual(other.Text))                                                                               &&
                   (TextInfo     == other.TextInfo     && TextInfo     != null && other.TextInfo     != null && TextInfo.Equals(other.TextInfo))                                                    &&
                   (TextTemplate == other.TextTemplate && TextTemplate != null && other.TextTemplate != null && TextTemplate.Equals(other.TextTemplate))                                            &&
                   (Equals(TextTemplateArray, other.TextTemplateArray) || TextTemplateArray != null && other.TextTemplateArray != null && TextTemplateArray.SequenceEqual(other.TextTemplateArray)) &&
                   (HoverText == other.HoverText && HoverText != null && other.HoverText != null && HoverText.Equals(other.HoverText))                                                              &&
                   (Equals(HoverTextArray, other.HoverTextArray) || HoverTextArray != null && other.HoverTextArray != null && HoverTextArray.SequenceEqual(other.HoverTextArray))                   &&
                   (HoverInfo == other.HoverInfo && HoverInfo != null && other.HoverInfo != null && HoverInfo.Equals(other.HoverInfo))                                                              &&
                   (Equals(HoverInfoArray, other.HoverInfoArray) || HoverInfoArray != null && other.HoverInfoArray != null && HoverInfoArray.SequenceEqual(other.HoverInfoArray))                   &&
                   (HoverTemplate == other.HoverTemplate && HoverTemplate != null && other.HoverTemplate != null && HoverTemplate.Equals(other.HoverTemplate))                                      &&
                   (Equals(HoverTemplateArray, other.HoverTemplateArray) ||
                    HoverTemplateArray != null && other.HoverTemplateArray != null && HoverTemplateArray.SequenceEqual(other.HoverTemplateArray))                              &&
                   (TextFont         == other.TextFont         && TextFont         != null && other.TextFont         != null && TextFont.Equals(other.TextFont))               &&
                   (InsideTextFont   == other.InsideTextFont   && InsideTextFont   != null && other.InsideTextFont   != null && InsideTextFont.Equals(other.InsideTextFont))   &&
                   (OutsideTextFont  == other.OutsideTextFont  && OutsideTextFont  != null && other.OutsideTextFont  != null && OutsideTextFont.Equals(other.OutsideTextFont)) &&
                   (TextPosition     == other.TextPosition     && TextPosition     != null && other.TextPosition     != null && TextPosition.Equals(other.TextPosition))       &&
                   (Domain           == other.Domain           && Domain           != null && other.Domain           != null && Domain.Equals(other.Domain))                   &&
                   (IdsSrc           == other.IdsSrc           && IdsSrc           != null && other.IdsSrc           != null && IdsSrc.Equals(other.IdsSrc))                   &&
                   (CustomDataSrc    == other.CustomDataSrc    && CustomDataSrc    != null && other.CustomDataSrc    != null && CustomDataSrc.Equals(other.CustomDataSrc))     &&
                   (MetaSrc          == other.MetaSrc          && MetaSrc          != null && other.MetaSrc          != null && MetaSrc.Equals(other.MetaSrc))                 &&
                   (LabelsSrc        == other.LabelsSrc        && LabelsSrc        != null && other.LabelsSrc        != null && LabelsSrc.Equals(other.LabelsSrc))             &&
                   (ParentsSrc       == other.ParentsSrc       && ParentsSrc       != null && other.ParentsSrc       != null && ParentsSrc.Equals(other.ParentsSrc))           &&
                   (ValuesSrc        == other.ValuesSrc        && ValuesSrc        != null && other.ValuesSrc        != null && ValuesSrc.Equals(other.ValuesSrc))             &&
                   (TextSrc          == other.TextSrc          && TextSrc          != null && other.TextSrc          != null && TextSrc.Equals(other.TextSrc))                 &&
                   (TextTemplateSrc  == other.TextTemplateSrc  && TextTemplateSrc  != null && other.TextTemplateSrc  != null && TextTemplateSrc.Equals(other.TextTemplateSrc)) &&
                   (HoverTextSrc     == other.HoverTextSrc     && HoverTextSrc     != null && other.HoverTextSrc     != null && HoverTextSrc.Equals(other.HoverTextSrc))       &&
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

                if(Parents != null)
                    hashCode = hashCode * 59 + Parents.GetHashCode();

                if(Values != null)
                    hashCode = hashCode * 59 + Values.GetHashCode();

                if(BranchValues != null)
                    hashCode = hashCode * 59 + BranchValues.GetHashCode();

                if(Count != null)
                    hashCode = hashCode * 59 + Count.GetHashCode();

                if(Level != null)
                    hashCode = hashCode * 59 + Level.GetHashCode();

                if(MaxDepth != null)
                    hashCode = hashCode * 59 + MaxDepth.GetHashCode();

                if(Tiling != null)
                    hashCode = hashCode * 59 + Tiling.GetHashCode();

                if(Marker != null)
                    hashCode = hashCode * 59 + Marker.GetHashCode();

                if(PathBar != null)
                    hashCode = hashCode * 59 + PathBar.GetHashCode();

                if(Text != null)
                    hashCode = hashCode * 59 + Text.GetHashCode();

                if(TextInfo != null)
                    hashCode = hashCode * 59 + TextInfo.GetHashCode();

                if(TextTemplate != null)
                    hashCode = hashCode * 59 + TextTemplate.GetHashCode();

                if(TextTemplateArray != null)
                    hashCode = hashCode * 59 + TextTemplateArray.GetHashCode();

                if(HoverText != null)
                    hashCode = hashCode * 59 + HoverText.GetHashCode();

                if(HoverTextArray != null)
                    hashCode = hashCode * 59 + HoverTextArray.GetHashCode();

                if(HoverInfo != null)
                    hashCode = hashCode * 59 + HoverInfo.GetHashCode();

                if(HoverInfoArray != null)
                    hashCode = hashCode * 59 + HoverInfoArray.GetHashCode();

                if(HoverTemplate != null)
                    hashCode = hashCode * 59 + HoverTemplate.GetHashCode();

                if(HoverTemplateArray != null)
                    hashCode = hashCode * 59 + HoverTemplateArray.GetHashCode();

                if(TextFont != null)
                    hashCode = hashCode * 59 + TextFont.GetHashCode();

                if(InsideTextFont != null)
                    hashCode = hashCode * 59 + InsideTextFont.GetHashCode();

                if(OutsideTextFont != null)
                    hashCode = hashCode * 59 + OutsideTextFont.GetHashCode();

                if(TextPosition != null)
                    hashCode = hashCode * 59 + TextPosition.GetHashCode();

                if(Domain != null)
                    hashCode = hashCode * 59 + Domain.GetHashCode();

                if(IdsSrc != null)
                    hashCode = hashCode * 59 + IdsSrc.GetHashCode();

                if(CustomDataSrc != null)
                    hashCode = hashCode * 59 + CustomDataSrc.GetHashCode();

                if(MetaSrc != null)
                    hashCode = hashCode * 59 + MetaSrc.GetHashCode();

                if(LabelsSrc != null)
                    hashCode = hashCode * 59 + LabelsSrc.GetHashCode();

                if(ParentsSrc != null)
                    hashCode = hashCode * 59 + ParentsSrc.GetHashCode();

                if(ValuesSrc != null)
                    hashCode = hashCode * 59 + ValuesSrc.GetHashCode();

                if(TextSrc != null)
                    hashCode = hashCode * 59 + TextSrc.GetHashCode();

                if(TextTemplateSrc != null)
                    hashCode = hashCode * 59 + TextTemplateSrc.GetHashCode();

                if(HoverTextSrc != null)
                    hashCode = hashCode * 59 + HoverTextSrc.GetHashCode();

                if(HoverInfoSrc != null)
                    hashCode = hashCode * 59 + HoverInfoSrc.GetHashCode();

                if(HoverTemplateSrc != null)
                    hashCode = hashCode * 59 + HoverTemplateSrc.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left TreeMap and the right TreeMap.
        /// </summary>
        /// <param name="left">Left TreeMap.</param>
        /// <param name="right">Right TreeMap.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(TreeMap left,
                                       TreeMap right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left TreeMap and the right TreeMap.
        /// </summary>
        /// <param name="left">Left TreeMap.</param>
        /// <param name="right">Right TreeMap.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(TreeMap left,
                                       TreeMap right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>TreeMap</returns>
        public TreeMap DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<TreeMap>(ms).Result;
        }
    }
}
