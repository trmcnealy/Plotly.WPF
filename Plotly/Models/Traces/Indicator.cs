using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Traces.Indicators;

using Stream = Plotly.Models.Traces.Indicators.Stream;

namespace Plotly.Models.Traces
{
    /// <summary>
    ///     The Indicator class.
    ///     Implements the <see cref="ITrace" />.
    /// </summary>
    [JsonConverter(typeof(PlotlyConverter))]
    [Serializable]
    public class Indicator : ITrace, IEquatable<Indicator>
    {
        /// <inheritdoc/>
        [JsonPropertyName(@"type")]
        public TraceTypeEnum? Type { get; } = TraceTypeEnum.Indicator;

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
        ///     Determines how the value is displayed on the graph. <c>number</c> displays
        ///     the value numerically in text. <c>delta</c> displays the difference to a
        ///     reference value in text. Finally, <c>gauge</c> displays the value graphically
        ///     on an axis.
        /// </summary>
        [JsonPropertyName(@"mode")]
        public ModeFlag? Mode { get; set; }

        /// <summary>
        ///     Sets the number to be displayed.
        /// </summary>
        [JsonPropertyName(@"value")]
        public JsNumber? Value { get; set; }

        /// <summary>
        ///     Sets the horizontal alignment of the <c>text</c> within the box. Note that
        ///     this attribute has no effect if an angular gauge is displayed: in this case,
        ///     it is always centered
        /// </summary>
        [JsonPropertyName(@"align")]
        public AlignEnum? Align { get; set; }

        /// <summary>
        ///     Gets or sets the Domain.
        /// </summary>
        [JsonPropertyName(@"domain")]
        public Domain? Domain { get; set; }

        /// <summary>
        ///     Gets or sets the Title.
        /// </summary>
        [JsonPropertyName(@"title")]
        public Title? Title { get; set; }

        /// <summary>
        ///     Gets or sets the Number.
        /// </summary>
        [JsonPropertyName(@"number")]
        public Number? Number { get; set; }

        /// <summary>
        ///     Gets or sets the Delta.
        /// </summary>
        [JsonPropertyName(@"delta")]
        public Delta? Delta { get; set; }

        /// <summary>
        ///     The gauge of the Indicator plot.
        /// </summary>
        [JsonPropertyName(@"gauge")]
        public Gauge? Gauge { get; set; }

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

        public override bool Equals(object obj)
        {
            if(!(obj is Indicator other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] Indicator other)
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
                   (UiRevision    == other.UiRevision    && UiRevision    != null && other.UiRevision    != null && UiRevision.Equals(other.UiRevision))       &&
                   (Mode          == other.Mode          && Mode          != null && other.Mode          != null && Mode.Equals(other.Mode))                   &&
                   (Value         == other.Value         && Value         != null && other.Value         != null && Value.Equals(other.Value))                 &&
                   (Align         == other.Align         && Align         != null && other.Align         != null && Align.Equals(other.Align))                 &&
                   (Domain        == other.Domain        && Domain        != null && other.Domain        != null && Domain.Equals(other.Domain))               &&
                   (Title         == other.Title         && Title         != null && other.Title         != null && Title.Equals(other.Title))                 &&
                   (Number        == other.Number        && Number        != null && other.Number        != null && Number.Equals(other.Number))               &&
                   (Delta         == other.Delta         && Delta         != null && other.Delta         != null && Delta.Equals(other.Delta))                 &&
                   (Gauge         == other.Gauge         && Gauge         != null && other.Gauge         != null && Gauge.Equals(other.Gauge))                 &&
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

                if(Mode != null)
                    hashCode = hashCode * 59 + Mode.GetHashCode();

                if(Value != null)
                    hashCode = hashCode * 59 + Value.GetHashCode();

                if(Align != null)
                    hashCode = hashCode * 59 + Align.GetHashCode();

                if(Domain != null)
                    hashCode = hashCode * 59 + Domain.GetHashCode();

                if(Title != null)
                    hashCode = hashCode * 59 + Title.GetHashCode();

                if(Number != null)
                    hashCode = hashCode * 59 + Number.GetHashCode();

                if(Delta != null)
                    hashCode = hashCode * 59 + Delta.GetHashCode();

                if(Gauge != null)
                    hashCode = hashCode * 59 + Gauge.GetHashCode();

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
        ///     Checks for equality of the left Indicator and the right Indicator.
        /// </summary>
        /// <param name="left">Left Indicator.</param>
        /// <param name="right">Right Indicator.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(Indicator left,
                                       Indicator right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Indicator and the right Indicator.
        /// </summary>
        /// <param name="left">Left Indicator.</param>
        /// <param name="right">Right Indicator.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(Indicator left,
                                       Indicator right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Indicator</returns>
        public Indicator DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<Indicator>(ms).Result;
        }
    }
}
