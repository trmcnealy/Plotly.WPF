
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Traces.Sankeys;

using Stream = Plotly.Models.Traces.Sankeys.Stream;

namespace Plotly.Models.Traces
{
    /// <summary>
    ///     The Sankey class.
    ///     Implements the <see cref="ITrace" />.
    /// </summary>
    
    [JsonConverter(typeof(PlotlyConverter))]
    [Serializable]
    public class Sankey : ITrace, IEquatable<Sankey>
    {
        /// <inheritdoc/>
        [JsonPropertyName(@"type")]
        public TraceTypeEnum? Type { get; } = TraceTypeEnum.Sankey;

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
        ///     Array containing integer indices of selected points. Has an effect only
        ///     for traces that support selections. Note that an empty array means an empty
        ///     selection where the <c>unselected</c> are turned on for all points, whereas,
        ///     any other non-array values means no selection all where the <c>selected</c>
        ///     and <c>unselected</c> styles have no effect.
        /// </summary>
        [JsonPropertyName(@"selectedpoints")]
        public object SelectedPoints { get; set;} 

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
        ///     Determines which trace information appear on hover. If <c>none</c> or <c>skip</c>
        ///     are set, no information is displayed upon hovering. But, if <c>none</c>
        ///     is set, click and hover events are still fired. Note that this attribute
        ///     is superseded by <c>node.hoverinfo</c> and <c>node.hoverinfo</c> for nodes
        ///     and links respectively.
        /// </summary>
        [JsonPropertyName(@"hoverinfo")]
        public HoverInfoFlag? HoverInfo { get; set;} 

        /// <summary>
        ///     Gets or sets the HoverLabel.
        /// </summary>
        [JsonPropertyName(@"hoverlabel")]
        public HoverLabel HoverLabel { get; set;} 

        /// <summary>
        ///     Gets or sets the Domain.
        /// </summary>
        [JsonPropertyName(@"domain")]
        public Domain Domain { get; set;} 

        /// <summary>
        ///     Sets the orientation of the Sankey diagram.
        /// </summary>
        [JsonPropertyName(@"orientation")]
        public OrientationEnum? Orientation { get; set;} 

        /// <summary>
        ///     Sets the value formatting rule using d3 formatting mini-language which is
        ///     similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        /// </summary>
        [JsonPropertyName(@"valueformat")]
        public string ValueFormat { get; set;} 

        /// <summary>
        ///     Adds a unit to follow the value in the hover tooltip. Add a space if a separation
        ///     is necessary from the value.
        /// </summary>
        [JsonPropertyName(@"valuesuffix")]
        public string ValueSuffix { get; set;} 

        /// <summary>
        ///     If value is <c>snap</c> (the default), the node arrangement is assisted
        ///     by automatic snapping of elements to preserve space between nodes specified
        ///     via <c>nodepad</c>. If value is <c>perpendicular</c>, the nodes can only
        ///     move along a line perpendicular to the flow. If value is <c>freeform</c>,
        ///     the nodes can freely move on the plane. If value is <c>fixed</c>, the nodes
        ///     are stationary.
        /// </summary>
        [JsonPropertyName(@"arrangement")]
        public ArrangementEnum? Arrangement { get; set;} 

        /// <summary>
        ///     Sets the font for node labels
        /// </summary>
        [JsonPropertyName(@"textfont")]
        public TextFont TextFont { get; set;} 

        /// <summary>
        ///     The nodes of the Sankey plot.
        /// </summary>
        [JsonPropertyName(@"node")]
        public Node Node { get; set;} 

        /// <summary>
        ///     The links of the Sankey plot.
        /// </summary>
        [JsonPropertyName(@"link")]
        public Link Link { get; set;} 

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

        
        public override bool Equals(object obj)
        {
            if (!(obj is Sankey other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        
        public bool Equals([AllowNull] Sankey other)
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
                    SelectedPoints == other.SelectedPoints &&
                    SelectedPoints != null && other.SelectedPoints != null &&
                    SelectedPoints.Equals(other.SelectedPoints)
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
                    HoverInfo == other.HoverInfo &&
                    HoverInfo != null && other.HoverInfo != null &&
                    HoverInfo.Equals(other.HoverInfo)
                ) && 
                (
                    HoverLabel == other.HoverLabel &&
                    HoverLabel != null && other.HoverLabel != null &&
                    HoverLabel.Equals(other.HoverLabel)
                ) && 
                (
                    Domain == other.Domain &&
                    Domain != null && other.Domain != null &&
                    Domain.Equals(other.Domain)
                ) && 
                (
                    Orientation == other.Orientation &&
                    Orientation != null && other.Orientation != null &&
                    Orientation.Equals(other.Orientation)
                ) && 
                (
                    ValueFormat == other.ValueFormat &&
                    ValueFormat != null && other.ValueFormat != null &&
                    ValueFormat.Equals(other.ValueFormat)
                ) && 
                (
                    ValueSuffix == other.ValueSuffix &&
                    ValueSuffix != null && other.ValueSuffix != null &&
                    ValueSuffix.Equals(other.ValueSuffix)
                ) && 
                (
                    Arrangement == other.Arrangement &&
                    Arrangement != null && other.Arrangement != null &&
                    Arrangement.Equals(other.Arrangement)
                ) && 
                (
                    TextFont == other.TextFont &&
                    TextFont != null && other.TextFont != null &&
                    TextFont.Equals(other.TextFont)
                ) && 
                (
                    Node == other.Node &&
                    Node != null && other.Node != null &&
                    Node.Equals(other.Node)
                ) && 
                (
                    Link == other.Link &&
                    Link != null && other.Link != null &&
                    Link.Equals(other.Link)
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
                if (Ids != null) hashCode = hashCode * 59 + Ids.GetHashCode();
                if (CustomData != null) hashCode = hashCode * 59 + CustomData.GetHashCode();
                if (Meta != null) hashCode = hashCode * 59 + Meta.GetHashCode();
                if (MetaArray != null) hashCode = hashCode * 59 + MetaArray.GetHashCode();
                if (SelectedPoints != null) hashCode = hashCode * 59 + SelectedPoints.GetHashCode();
                if (Stream != null) hashCode = hashCode * 59 + Stream.GetHashCode();
                if (UiRevision != null) hashCode = hashCode * 59 + UiRevision.GetHashCode();
                if (HoverInfo != null) hashCode = hashCode * 59 + HoverInfo.GetHashCode();
                if (HoverLabel != null) hashCode = hashCode * 59 + HoverLabel.GetHashCode();
                if (Domain != null) hashCode = hashCode * 59 + Domain.GetHashCode();
                if (Orientation != null) hashCode = hashCode * 59 + Orientation.GetHashCode();
                if (ValueFormat != null) hashCode = hashCode * 59 + ValueFormat.GetHashCode();
                if (ValueSuffix != null) hashCode = hashCode * 59 + ValueSuffix.GetHashCode();
                if (Arrangement != null) hashCode = hashCode * 59 + Arrangement.GetHashCode();
                if (TextFont != null) hashCode = hashCode * 59 + TextFont.GetHashCode();
                if (Node != null) hashCode = hashCode * 59 + Node.GetHashCode();
                if (Link != null) hashCode = hashCode * 59 + Link.GetHashCode();
                if (IdsSrc != null) hashCode = hashCode * 59 + IdsSrc.GetHashCode();
                if (CustomDataSrc != null) hashCode = hashCode * 59 + CustomDataSrc.GetHashCode();
                if (MetaSrc != null) hashCode = hashCode * 59 + MetaSrc.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Sankey and the right Sankey.
        /// </summary>
        /// <param name="left">Left Sankey.</param>
        /// <param name="right">Right Sankey.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (Sankey left, Sankey right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Sankey and the right Sankey.
        /// </summary>
        /// <param name="left">Left Sankey.</param>
        /// <param name="right">Right Sankey.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (Sankey left, Sankey right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Sankey</returns>
        public Sankey DeepClone()
        {
            using MemoryStream ms = new();
            
            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;
            return JsonSerializer.DeserializeAsync<Sankey>(ms).Result;
        }
    }
}