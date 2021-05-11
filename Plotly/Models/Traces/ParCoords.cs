using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Traces.ParCoordss;

using Stream = Plotly.Models.Traces.ParCoordss.Stream;

namespace Plotly.Models.Traces
{
    /// <summary>
    ///     The ParCoords class.
    ///     Implements the <see cref="ITrace" />.
    /// </summary>
    [JsonConverter(typeof(PlotlyConverter))]
    [Serializable]
    public class ParCoords : ITrace, IEquatable<ParCoords>
    {
        /// <inheritdoc/>
        [JsonPropertyName(@"type")]
        public TraceTypeEnum? Type { get; } = TraceTypeEnum.ParCoords;

        /// <summary>
        ///     Determines whether or not this trace is visible. If <c>legendonly</c>, the
        ///     trace is not drawn, but can appear as a legend item (provided that the legend
        ///     itself is visible).
        /// </summary>
        [JsonPropertyName(@"visible")]
        public VisibleEnum? Visible { get; set; }

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
        ///     Gets or sets the Domain.
        /// </summary>
        [JsonPropertyName(@"domain")]
        public Domain Domain { get; set; }

        /// <summary>
        ///     Sets the angle of the labels with respect to the horizontal. For example,
        ///     a <c>tickangle</c> of -90 draws the labels vertically. Tilted labels with
        ///     <c>labelangle</c> may be positioned better inside margins when <c>labelposition</c>
        ///     is set to <c>bottom</c>.
        /// </summary>
        [JsonPropertyName(@"labelangle")]
        public JsNumber? LabelAngle { get; set; }

        /// <summary>
        ///     Specifies the location of the <c>label</c>. <c>top</c> positions labels
        ///     above, next to the title <c>bottom</c> positions labels below the graph
        ///     Tilted labels with <c>labelangle</c> may be positioned better inside margins
        ///     when <c>labelposition</c> is set to <c>bottom</c>.
        /// </summary>
        [JsonPropertyName(@"labelside")]
        public LabelSideEnum? LabelSide { get; set; }

        /// <summary>
        ///     Sets the font for the <c>dimension</c> labels.
        /// </summary>
        [JsonPropertyName(@"labelfont")]
        public LabelFont LabelFont { get; set; }

        /// <summary>
        ///     Sets the font for the <c>dimension</c> tick values.
        /// </summary>
        [JsonPropertyName(@"tickfont")]
        public TickFont TickFont { get; set; }

        /// <summary>
        ///     Sets the font for the <c>dimension</c> range values.
        /// </summary>
        [JsonPropertyName(@"rangefont")]
        public RangeFont RangeFont { get; set; }

        /// <summary>
        ///     Gets or sets the Dimensions.
        /// </summary>
        [JsonPropertyName(@"dimensions")]
        public List<Dimension> Dimensions { get; set; }

        /// <summary>
        ///     Gets or sets the Line.
        /// </summary>
        [JsonPropertyName(@"line")]
        public Line Line { get; set; }

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

        public override bool Equals(object obj)
        {
            if(!(obj is ParCoords other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] ParCoords other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (Type    == other.Type    && Type    != null && other.Type    != null && Type.Equals(other.Type))                                           &&
                   (Visible == other.Visible && Visible != null && other.Visible != null && Visible.Equals(other.Visible))                                     &&
                   (Name    == other.Name    && Name    != null && other.Name    != null && Name.Equals(other.Name))                                           &&
                   (UId     == other.UId     && UId     != null && other.UId     != null && UId.Equals(other.UId))                                             &&
                   (Equals(Ids,        other.Ids)        || Ids        != null && other.Ids        != null && Ids.SequenceEqual(other.Ids))                    &&
                   (Equals(CustomData, other.CustomData) || CustomData != null && other.CustomData != null && CustomData.SequenceEqual(other.CustomData))      &&
                   (Meta == other.Meta && Meta != null && other.Meta != null && Meta.Equals(other.Meta))                                                       &&
                   (Equals(MetaArray, other.MetaArray) || MetaArray != null && other.MetaArray != null && MetaArray.SequenceEqual(other.MetaArray))            &&
                   (Stream == other.Stream && Stream != null && other.Stream != null && Stream.Equals(other.Stream))                                           &&
                   (Equals(Transforms, other.Transforms) || Transforms != null && other.Transforms != null && Transforms.SequenceEqual(other.Transforms))      &&
                   (UiRevision == other.UiRevision && UiRevision != null && other.UiRevision != null && UiRevision.Equals(other.UiRevision))                   &&
                   (Domain     == other.Domain     && Domain     != null && other.Domain     != null && Domain.Equals(other.Domain))                           &&
                   (LabelAngle == other.LabelAngle && LabelAngle != null && other.LabelAngle != null && LabelAngle.Equals(other.LabelAngle))                   &&
                   (LabelSide  == other.LabelSide  && LabelSide  != null && other.LabelSide  != null && LabelSide.Equals(other.LabelSide))                     &&
                   (LabelFont  == other.LabelFont  && LabelFont  != null && other.LabelFont  != null && LabelFont.Equals(other.LabelFont))                     &&
                   (TickFont   == other.TickFont   && TickFont   != null && other.TickFont   != null && TickFont.Equals(other.TickFont))                       &&
                   (RangeFont  == other.RangeFont  && RangeFont  != null && other.RangeFont  != null && RangeFont.Equals(other.RangeFont))                     &&
                   (Equals(Dimensions, other.Dimensions) || Dimensions != null && other.Dimensions != null && Dimensions.SequenceEqual(other.Dimensions))      &&
                   (Line          == other.Line          && Line          != null && other.Line          != null && Line.Equals(other.Line))                   &&
                   (IdsSrc        == other.IdsSrc        && IdsSrc        != null && other.IdsSrc        != null && IdsSrc.Equals(other.IdsSrc))               &&
                   (CustomDataSrc == other.CustomDataSrc && CustomDataSrc != null && other.CustomDataSrc != null && CustomDataSrc.Equals(other.CustomDataSrc)) &&
                   (MetaSrc       == other.MetaSrc       && MetaSrc       != null && other.MetaSrc       != null && MetaSrc.Equals(other.MetaSrc));
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

                if(Stream != null)
                    hashCode = hashCode * 59 + Stream.GetHashCode();

                if(Transforms != null)
                    hashCode = hashCode * 59 + Transforms.GetHashCode();

                if(UiRevision != null)
                    hashCode = hashCode * 59 + UiRevision.GetHashCode();

                if(Domain != null)
                    hashCode = hashCode * 59 + Domain.GetHashCode();

                if(LabelAngle != null)
                    hashCode = hashCode * 59 + LabelAngle.GetHashCode();

                if(LabelSide != null)
                    hashCode = hashCode * 59 + LabelSide.GetHashCode();

                if(LabelFont != null)
                    hashCode = hashCode * 59 + LabelFont.GetHashCode();

                if(TickFont != null)
                    hashCode = hashCode * 59 + TickFont.GetHashCode();

                if(RangeFont != null)
                    hashCode = hashCode * 59 + RangeFont.GetHashCode();

                if(Dimensions != null)
                    hashCode = hashCode * 59 + Dimensions.GetHashCode();

                if(Line != null)
                    hashCode = hashCode * 59 + Line.GetHashCode();

                if(IdsSrc != null)
                    hashCode = hashCode * 59 + IdsSrc.GetHashCode();

                if(CustomDataSrc != null)
                    hashCode = hashCode * 59 + CustomDataSrc.GetHashCode();

                if(MetaSrc != null)
                    hashCode = hashCode * 59 + MetaSrc.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left ParCoords and the right ParCoords.
        /// </summary>
        /// <param name="left">Left ParCoords.</param>
        /// <param name="right">Right ParCoords.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(ParCoords left,
                                       ParCoords right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left ParCoords and the right ParCoords.
        /// </summary>
        /// <param name="left">Left ParCoords.</param>
        /// <param name="right">Right ParCoords.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(ParCoords left,
                                       ParCoords right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>ParCoords</returns>
        public ParCoords DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<ParCoords>(ms).Result;
        }
    }
}
