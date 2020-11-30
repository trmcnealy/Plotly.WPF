
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Traces.ParCatss;

using Stream = Plotly.Models.Traces.ParCatss.Stream;

namespace Plotly.Models.Traces
{
    /// <summary>
    ///     The ParCats class.
    ///     Implements the <see cref="ITrace" />.
    /// </summary>
    
    [JsonConverter(typeof(PlotlyConverter))]
    [Serializable]
    public class ParCats : ITrace, IEquatable<ParCats>
    {
        /// <inheritdoc/>
        [JsonPropertyName(@"type")]
        public TraceTypeEnum? Type { get; } = TraceTypeEnum.ParCats;

        /// <summary>
        ///     Determines whether or not this trace is visible. If <c>legendonly</c>, the
        ///     trace is not drawn, but can appear as a legend item (provided that the legend
        ///     itself is visible).
        /// </summary>
        [JsonPropertyName(@"visible")]
        public VisibleEnum? Visible { get; set;} 

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
        ///     Gets or sets the Domain.
        /// </summary>
        [JsonPropertyName(@"domain")]
        public Domain Domain { get; set;} 

        /// <summary>
        ///     Determines which trace information appear on hover. If <c>none</c> or <c>skip</c>
        ///     are set, no information is displayed upon hovering. But, if <c>none</c>
        ///     is set, click and hover events are still fired.
        /// </summary>
        [JsonPropertyName(@"hoverinfo")]
        public HoverInfoFlag? HoverInfo { get; set;} 

        /// <summary>
        ///     Sets the hover interaction mode for the parcats diagram. If <c>category</c>,
        ///     hover interaction take place per category. If <c>color</c>, hover interactions
        ///     take place per color per category. If <c>dimension</c>, hover interactions
        ///     take place across all categories per dimension.
        /// </summary>
        [JsonPropertyName(@"hoveron")]
        public HoverOnEnum? HoverOn { get; set;} 

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
        ///     that are &#39;arrayOk: true&#39;) are available. variables <c>count</c>,
        ///     <c>probability</c>, <c>category</c>, <c>categorycount</c>, <c>colorcount</c>
        ///     and <c>bandcolorcount</c>. Anything contained in tag <c>&lt;extra&gt;</c>
        ///     is displayed in the secondary box, for example <c>&lt;extra&gt;{fullData.name}&lt;/extra&gt;</c>.
        ///     To hide the secondary box completely, use an empty tag <c>&lt;extra&gt;&lt;/extra&gt;</c>.
        /// </summary>
        [JsonPropertyName(@"hovertemplate")]
        public string HoverTemplate { get; set;} 

        /// <summary>
        ///     Sets the drag interaction mode for categories and dimensions. If <c>perpendicular</c>,
        ///     the categories can only move along a line perpendicular to the paths. If
        ///     <c>freeform</c>, the categories can freely move on the plane. If <c>fixed</c>,
        ///     the categories and dimensions are stationary.
        /// </summary>
        [JsonPropertyName(@"arrangement")]
        public ArrangementEnum? Arrangement { get; set;} 

        /// <summary>
        ///     Sort paths so that like colors are bundled together within each category.
        /// </summary>
        [JsonPropertyName(@"bundlecolors")]
        public bool? BundleColors { get; set;} 

        /// <summary>
        ///     Sets the path sorting algorithm. If <c>forward</c>, sort paths based on
        ///     dimension categories from left to right. If <c>backward</c>, sort paths
        ///     based on dimensions categories from right to left.
        /// </summary>
        [JsonPropertyName(@"sortpaths")]
        public SortPathsEnum? SortPaths { get; set;} 

        /// <summary>
        ///     Sets the font for the <c>dimension</c> labels.
        /// </summary>
        [JsonPropertyName(@"labelfont")]
        public LabelFont LabelFont { get; set;} 

        /// <summary>
        ///     Sets the font for the <c>category</c> labels.
        /// </summary>
        [JsonPropertyName(@"tickfont")]
        public TickFont TickFont { get; set;} 

        /// <summary>
        ///     Gets or sets the Dimensions.
        /// </summary>
        [JsonPropertyName(@"dimensions")]
        public List<Dimension> Dimensions { get; set;} 

        /// <summary>
        ///     Gets or sets the Line.
        /// </summary>
        [JsonPropertyName(@"line")]
        public Line Line { get; set;} 

        /// <summary>
        ///     The number of observations represented by each state. Defaults to 1 so that
        ///     each state represents one observation
        /// </summary>
        [JsonPropertyName(@"counts")]
        public JsNumber? Counts { get; set;} 

        /// <summary>
        ///     The number of observations represented by each state. Defaults to 1 so that
        ///     each state represents one observation
        /// </summary>
        [JsonPropertyName(@"counts")]
        [Array]
        public List<JsNumber?> CountsArray { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  meta .
        /// </summary>
        [JsonPropertyName(@"metasrc")]
        public string MetaSrc { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  counts .
        /// </summary>
        [JsonPropertyName(@"countssrc")]
        public string CountsSrc { get; set;} 

        
        public override bool Equals(object obj)
        {
            if (!(obj is ParCats other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        
        public bool Equals([AllowNull] ParCats other)
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
                    Domain == other.Domain &&
                    Domain != null && other.Domain != null &&
                    Domain.Equals(other.Domain)
                ) && 
                (
                    HoverInfo == other.HoverInfo &&
                    HoverInfo != null && other.HoverInfo != null &&
                    HoverInfo.Equals(other.HoverInfo)
                ) && 
                (
                    HoverOn == other.HoverOn &&
                    HoverOn != null && other.HoverOn != null &&
                    HoverOn.Equals(other.HoverOn)
                ) && 
                (
                    HoverTemplate == other.HoverTemplate &&
                    HoverTemplate != null && other.HoverTemplate != null &&
                    HoverTemplate.Equals(other.HoverTemplate)
                ) && 
                (
                    Arrangement == other.Arrangement &&
                    Arrangement != null && other.Arrangement != null &&
                    Arrangement.Equals(other.Arrangement)
                ) && 
                (
                    BundleColors == other.BundleColors &&
                    BundleColors != null && other.BundleColors != null &&
                    BundleColors.Equals(other.BundleColors)
                ) && 
                (
                    SortPaths == other.SortPaths &&
                    SortPaths != null && other.SortPaths != null &&
                    SortPaths.Equals(other.SortPaths)
                ) && 
                (
                    LabelFont == other.LabelFont &&
                    LabelFont != null && other.LabelFont != null &&
                    LabelFont.Equals(other.LabelFont)
                ) && 
                (
                    TickFont == other.TickFont &&
                    TickFont != null && other.TickFont != null &&
                    TickFont.Equals(other.TickFont)
                ) && 
                (
                    Equals(Dimensions, other.Dimensions) ||
                    Dimensions != null && other.Dimensions != null &&
                    Dimensions.SequenceEqual(other.Dimensions)
                ) &&
                (
                    Line == other.Line &&
                    Line != null && other.Line != null &&
                    Line.Equals(other.Line)
                ) && 
                (
                    Counts == other.Counts &&
                    Counts != null && other.Counts != null &&
                    Counts.Equals(other.Counts)
                ) && 
                (
                    Equals(CountsArray, other.CountsArray) ||
                    CountsArray != null && other.CountsArray != null &&
                    CountsArray.SequenceEqual(other.CountsArray)
                ) &&
                (
                    MetaSrc == other.MetaSrc &&
                    MetaSrc != null && other.MetaSrc != null &&
                    MetaSrc.Equals(other.MetaSrc)
                ) && 
                (
                    CountsSrc == other.CountsSrc &&
                    CountsSrc != null && other.CountsSrc != null &&
                    CountsSrc.Equals(other.CountsSrc)
                );
        }

        
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (Type != null) hashCode = hashCode * 59 + Type.GetHashCode();
                if (Visible != null) hashCode = hashCode * 59 + Visible.GetHashCode();
                if (Name != null) hashCode = hashCode * 59 + Name.GetHashCode();
                if (UId != null) hashCode = hashCode * 59 + UId.GetHashCode();
                if (Meta != null) hashCode = hashCode * 59 + Meta.GetHashCode();
                if (MetaArray != null) hashCode = hashCode * 59 + MetaArray.GetHashCode();
                if (Stream != null) hashCode = hashCode * 59 + Stream.GetHashCode();
                if (Transforms != null) hashCode = hashCode * 59 + Transforms.GetHashCode();
                if (UiRevision != null) hashCode = hashCode * 59 + UiRevision.GetHashCode();
                if (Domain != null) hashCode = hashCode * 59 + Domain.GetHashCode();
                if (HoverInfo != null) hashCode = hashCode * 59 + HoverInfo.GetHashCode();
                if (HoverOn != null) hashCode = hashCode * 59 + HoverOn.GetHashCode();
                if (HoverTemplate != null) hashCode = hashCode * 59 + HoverTemplate.GetHashCode();
                if (Arrangement != null) hashCode = hashCode * 59 + Arrangement.GetHashCode();
                if (BundleColors != null) hashCode = hashCode * 59 + BundleColors.GetHashCode();
                if (SortPaths != null) hashCode = hashCode * 59 + SortPaths.GetHashCode();
                if (LabelFont != null) hashCode = hashCode * 59 + LabelFont.GetHashCode();
                if (TickFont != null) hashCode = hashCode * 59 + TickFont.GetHashCode();
                if (Dimensions != null) hashCode = hashCode * 59 + Dimensions.GetHashCode();
                if (Line != null) hashCode = hashCode * 59 + Line.GetHashCode();
                if (Counts != null) hashCode = hashCode * 59 + Counts.GetHashCode();
                if (CountsArray != null) hashCode = hashCode * 59 + CountsArray.GetHashCode();
                if (MetaSrc != null) hashCode = hashCode * 59 + MetaSrc.GetHashCode();
                if (CountsSrc != null) hashCode = hashCode * 59 + CountsSrc.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left ParCats and the right ParCats.
        /// </summary>
        /// <param name="left">Left ParCats.</param>
        /// <param name="right">Right ParCats.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (ParCats left, ParCats right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left ParCats and the right ParCats.
        /// </summary>
        /// <param name="left">Left ParCats.</param>
        /// <param name="right">Right ParCats.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (ParCats left, ParCats right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>ParCats</returns>
        public ParCats DeepClone()
        {
            using MemoryStream ms = new();
            
            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;
            return JsonSerializer.DeserializeAsync<ParCats>(ms).Result;
        }
    }
}