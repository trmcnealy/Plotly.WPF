using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Traces.Tables;

using Stream = Plotly.Models.Traces.Tables.Stream;

namespace Plotly.Models.Traces
{
    /// <summary>
    ///     The Table class.
    ///     Implements the <see cref="ITrace" />.
    /// </summary>
    [JsonConverter(typeof(PlotlyConverter))]
    [Serializable]
    public class Table : ITrace, IEquatable<Table>
    {
        /// <inheritdoc/>
        [JsonPropertyName(@"type")]
        public TraceTypeEnum? Type { get; } = TraceTypeEnum.Table;

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
        ///     The width of columns expressed as a ratio. Columns fill the available width
        ///     in proportion of their specified column widths.
        /// </summary>
        [JsonPropertyName(@"columnwidth")]
        public JsNumber? ColumnWidth { get; set; }

        /// <summary>
        ///     The width of columns expressed as a ratio. Columns fill the available width
        ///     in proportion of their specified column widths.
        /// </summary>
        [JsonPropertyName(@"columnwidth")]
        [Array]
        public List<JsNumber?> ColumnWidthArray { get; set; }

        /// <summary>
        ///     Specifies the rendered order of the data columns; for example, a value <c>2</c>
        ///     at position <c>0</c> means that column index <c>0</c> in the data will be
        ///     rendered as the third column, as columns have an index base of zero.
        /// </summary>
        [JsonPropertyName(@"columnorder")]
        public List<object> ColumnOrder { get; set; }

        /// <summary>
        ///     Gets or sets the Header.
        /// </summary>
        [JsonPropertyName(@"header")]
        public Header Header { get; set; }

        /// <summary>
        ///     Gets or sets the Cells.
        /// </summary>
        [JsonPropertyName(@"cells")]
        public Cells Cells { get; set; }

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
        ///     Sets the source reference on Chart Studio Cloud for  columnwidth .
        /// </summary>
        [JsonPropertyName(@"columnwidthsrc")]
        public string ColumnWidthSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  columnorder .
        /// </summary>
        [JsonPropertyName(@"columnordersrc")]
        public string ColumnOrderSrc { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is Table other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] Table other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (Type    == other.Type    && Type    != null && other.Type    != null && Type.Equals(other.Type))                                                                          &&
                   (Visible == other.Visible && Visible != null && other.Visible != null && Visible.Equals(other.Visible))                                                                    &&
                   (Name    == other.Name    && Name    != null && other.Name    != null && Name.Equals(other.Name))                                                                          &&
                   (UId     == other.UId     && UId     != null && other.UId     != null && UId.Equals(other.UId))                                                                            &&
                   (Equals(Ids,        other.Ids)        || Ids        != null && other.Ids        != null && Ids.SequenceEqual(other.Ids))                                                   &&
                   (Equals(CustomData, other.CustomData) || CustomData != null && other.CustomData != null && CustomData.SequenceEqual(other.CustomData))                                     &&
                   (Meta == other.Meta && Meta != null && other.Meta != null && Meta.Equals(other.Meta))                                                                                      &&
                   (Equals(MetaArray, other.MetaArray) || MetaArray != null && other.MetaArray != null && MetaArray.SequenceEqual(other.MetaArray))                                           &&
                   (HoverInfo == other.HoverInfo && HoverInfo != null && other.HoverInfo != null && HoverInfo.Equals(other.HoverInfo))                                                        &&
                   (Equals(HoverInfoArray, other.HoverInfoArray) || HoverInfoArray != null && other.HoverInfoArray != null && HoverInfoArray.SequenceEqual(other.HoverInfoArray))             &&
                   (HoverLabel  == other.HoverLabel  && HoverLabel  != null && other.HoverLabel  != null && HoverLabel.Equals(other.HoverLabel))                                              &&
                   (Stream      == other.Stream      && Stream      != null && other.Stream      != null && Stream.Equals(other.Stream))                                                      &&
                   (UiRevision  == other.UiRevision  && UiRevision  != null && other.UiRevision  != null && UiRevision.Equals(other.UiRevision))                                              &&
                   (Domain      == other.Domain      && Domain      != null && other.Domain      != null && Domain.Equals(other.Domain))                                                      &&
                   (ColumnWidth == other.ColumnWidth && ColumnWidth != null && other.ColumnWidth != null && ColumnWidth.Equals(other.ColumnWidth))                                            &&
                   (Equals(ColumnWidthArray, other.ColumnWidthArray) || ColumnWidthArray != null && other.ColumnWidthArray != null && ColumnWidthArray.SequenceEqual(other.ColumnWidthArray)) &&
                   (Equals(ColumnOrder,      other.ColumnOrder)      || ColumnOrder      != null && other.ColumnOrder      != null && ColumnOrder.SequenceEqual(other.ColumnOrder))           &&
                   (Header         == other.Header         && Header         != null && other.Header         != null && Header.Equals(other.Header))                                          &&
                   (Cells          == other.Cells          && Cells          != null && other.Cells          != null && Cells.Equals(other.Cells))                                            &&
                   (IdsSrc         == other.IdsSrc         && IdsSrc         != null && other.IdsSrc         != null && IdsSrc.Equals(other.IdsSrc))                                          &&
                   (CustomDataSrc  == other.CustomDataSrc  && CustomDataSrc  != null && other.CustomDataSrc  != null && CustomDataSrc.Equals(other.CustomDataSrc))                            &&
                   (MetaSrc        == other.MetaSrc        && MetaSrc        != null && other.MetaSrc        != null && MetaSrc.Equals(other.MetaSrc))                                        &&
                   (HoverInfoSrc   == other.HoverInfoSrc   && HoverInfoSrc   != null && other.HoverInfoSrc   != null && HoverInfoSrc.Equals(other.HoverInfoSrc))                              &&
                   (ColumnWidthSrc == other.ColumnWidthSrc && ColumnWidthSrc != null && other.ColumnWidthSrc != null && ColumnWidthSrc.Equals(other.ColumnWidthSrc))                          &&
                   (ColumnOrderSrc == other.ColumnOrderSrc && ColumnOrderSrc != null && other.ColumnOrderSrc != null && ColumnOrderSrc.Equals(other.ColumnOrderSrc));
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

                if(HoverInfo != null)
                    hashCode = hashCode * 59 + HoverInfo.GetHashCode();

                if(HoverInfoArray != null)
                    hashCode = hashCode * 59 + HoverInfoArray.GetHashCode();

                if(HoverLabel != null)
                    hashCode = hashCode * 59 + HoverLabel.GetHashCode();

                if(Stream != null)
                    hashCode = hashCode * 59 + Stream.GetHashCode();

                if(UiRevision != null)
                    hashCode = hashCode * 59 + UiRevision.GetHashCode();

                if(Domain != null)
                    hashCode = hashCode * 59 + Domain.GetHashCode();

                if(ColumnWidth != null)
                    hashCode = hashCode * 59 + ColumnWidth.GetHashCode();

                if(ColumnWidthArray != null)
                    hashCode = hashCode * 59 + ColumnWidthArray.GetHashCode();

                if(ColumnOrder != null)
                    hashCode = hashCode * 59 + ColumnOrder.GetHashCode();

                if(Header != null)
                    hashCode = hashCode * 59 + Header.GetHashCode();

                if(Cells != null)
                    hashCode = hashCode * 59 + Cells.GetHashCode();

                if(IdsSrc != null)
                    hashCode = hashCode * 59 + IdsSrc.GetHashCode();

                if(CustomDataSrc != null)
                    hashCode = hashCode * 59 + CustomDataSrc.GetHashCode();

                if(MetaSrc != null)
                    hashCode = hashCode * 59 + MetaSrc.GetHashCode();

                if(HoverInfoSrc != null)
                    hashCode = hashCode * 59 + HoverInfoSrc.GetHashCode();

                if(ColumnWidthSrc != null)
                    hashCode = hashCode * 59 + ColumnWidthSrc.GetHashCode();

                if(ColumnOrderSrc != null)
                    hashCode = hashCode * 59 + ColumnOrderSrc.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Table and the right Table.
        /// </summary>
        /// <param name="left">Left Table.</param>
        /// <param name="right">Right Table.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(Table left,
                                       Table right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Table and the right Table.
        /// </summary>
        /// <param name="left">Left Table.</param>
        /// <param name="right">Right Table.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(Table left,
                                       Table right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Table</returns>
        public Table DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<Table>(ms).Result;
        }
    }
}
