using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Traces.PointClouds;

using Stream = Plotly.Models.Traces.PointClouds.Stream;

namespace Plotly.Models.Traces
{
    /// <summary>
    ///     The PointCloud class.
    ///     Implements the <see cref="ITrace" />.
    /// </summary>
    [JsonConverter(typeof(PlotlyConverter))]
    [Serializable]
    public class PointCloud : ITrace, IEquatable<PointCloud>
    {
        /// <inheritdoc/>
        [JsonPropertyName(@"type")]
        public TraceTypeEnum? Type { get; } = TraceTypeEnum.PointCloud;

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
        ///     Sets the x coordinates.
        /// </summary>
        [JsonPropertyName(@"x")]
        public List<object> X { get; set; }

        /// <summary>
        ///     Sets the y coordinates.
        /// </summary>
        [JsonPropertyName(@"y")]
        public List<object> Y { get; set; }

        /// <summary>
        ///     Faster alternative to specifying <c>x</c> and <c>y</c> separately. If supplied,
        ///     it must be a typed <c>Float32Array</c> array that represents points such
        ///     that &#39;xy[i &#39; 2] = x[i]&#39; and &#39;xy[i &#39; 2 + 1] = y[i]&#39;
        /// </summary>
        [JsonPropertyName(@"xy")]
        public List<object> XY { get; set; }

        /// <summary>
        ///     A sequential value, 0..n, supply it to avoid creating this array inside
        ///     plotting. If specified, it must be a typed <c>Int32Array</c> array. Its
        ///     length must be equal to or greater than the number of points. For the best
        ///     performance and memory use, create one large <c>indices</c> typed array
        ///     that is guaranteed to be at least as long as the largest number of points
        ///     during use, and reuse it on each <c>Plotly.restyle()</c> call.
        /// </summary>
        [JsonPropertyName(@"indices")]
        public List<object> Indices { get; set; }

        /// <summary>
        ///     Specify <c>xbounds</c> in the shape of `[xMin, xMax] to avoid looping through
        ///     the <c>xy</c> typed array. Use it in conjunction with <c>xy</c> and <c>ybounds</c>
        ///     for the performance benefits.
        /// </summary>
        [JsonPropertyName(@"xbounds")]
        public List<object> XBounds { get; set; }

        /// <summary>
        ///     Specify <c>ybounds</c> in the shape of `[yMin, yMax] to avoid looping through
        ///     the <c>xy</c> typed array. Use it in conjunction with <c>xy</c> and <c>xbounds</c>
        ///     for the performance benefits.
        /// </summary>
        [JsonPropertyName(@"ybounds")]
        public List<object> YBounds { get; set; }

        /// <summary>
        ///     Sets text elements associated with each (x,y) pair. If a single string,
        ///     the same string appears over all the data points. If an array of string,
        ///     the items are mapped in order to the this trace&#39;s (x,y) coordinates.
        ///     If trace <c>hoverinfo</c> contains a <c>text</c> flag and <c>hovertext</c>
        ///     is not set, these elements will be seen in the hover labels.
        /// </summary>
        [JsonPropertyName(@"text")]
        public string Text { get; set; }

        /// <summary>
        ///     Sets text elements associated with each (x,y) pair. If a single string,
        ///     the same string appears over all the data points. If an array of string,
        ///     the items are mapped in order to the this trace&#39;s (x,y) coordinates.
        ///     If trace <c>hoverinfo</c> contains a <c>text</c> flag and <c>hovertext</c>
        ///     is not set, these elements will be seen in the hover labels.
        /// </summary>
        [JsonPropertyName(@"text")]
        [Array]
        public List<string> TextArray { get; set; }

        /// <summary>
        ///     Gets or sets the Marker.
        /// </summary>
        [JsonPropertyName(@"marker")]
        public Marker Marker { get; set; }

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
        ///     Sets the source reference on Chart Studio Cloud for  hoverinfo .
        /// </summary>
        [JsonPropertyName(@"hoverinfosrc")]
        public string HoverInfoSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  x .
        /// </summary>
        [JsonPropertyName(@"xsrc")]
        public string XSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  y .
        /// </summary>
        [JsonPropertyName(@"ysrc")]
        public string YSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  xy .
        /// </summary>
        [JsonPropertyName(@"xysrc")]
        public string XYSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  indices .
        /// </summary>
        [JsonPropertyName(@"indicessrc")]
        public string IndicesSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  xbounds .
        /// </summary>
        [JsonPropertyName(@"xboundssrc")]
        public string XBoundsSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  ybounds .
        /// </summary>
        [JsonPropertyName(@"yboundssrc")]
        public string YBoundsSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  text .
        /// </summary>
        [JsonPropertyName(@"textsrc")]
        public string TextSrc { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is PointCloud other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] PointCloud other)
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
                   (HoverInfo == other.HoverInfo && HoverInfo != null && other.HoverInfo != null && HoverInfo.Equals(other.HoverInfo))                                            &&
                   (Equals(HoverInfoArray, other.HoverInfoArray) || HoverInfoArray != null && other.HoverInfoArray != null && HoverInfoArray.SequenceEqual(other.HoverInfoArray)) &&
                   (HoverLabel == other.HoverLabel && HoverLabel != null && other.HoverLabel != null && HoverLabel.Equals(other.HoverLabel))                                      &&
                   (Stream     == other.Stream     && Stream     != null && other.Stream     != null && Stream.Equals(other.Stream))                                              &&
                   (UiRevision == other.UiRevision && UiRevision != null && other.UiRevision != null && UiRevision.Equals(other.UiRevision))                                      &&
                   (Equals(X,       other.X)       || X       != null && other.X       != null && X.SequenceEqual(other.X))                                                       &&
                   (Equals(Y,       other.Y)       || Y       != null && other.Y       != null && Y.SequenceEqual(other.Y))                                                       &&
                   (Equals(XY,      other.XY)      || XY      != null && other.XY      != null && XY.SequenceEqual(other.XY))                                                     &&
                   (Equals(Indices, other.Indices) || Indices != null && other.Indices != null && Indices.SequenceEqual(other.Indices))                                           &&
                   (Equals(XBounds, other.XBounds) || XBounds != null && other.XBounds != null && XBounds.SequenceEqual(other.XBounds))                                           &&
                   (Equals(YBounds, other.YBounds) || YBounds != null && other.YBounds != null && YBounds.SequenceEqual(other.YBounds))                                           &&
                   (Text == other.Text && Text != null && other.Text != null && Text.Equals(other.Text))                                                                          &&
                   (Equals(TextArray, other.TextArray) || TextArray != null && other.TextArray != null && TextArray.SequenceEqual(other.TextArray))                               &&
                   (Marker        == other.Marker        && Marker        != null && other.Marker        != null && Marker.Equals(other.Marker))                                  &&
                   (XAxis         == other.XAxis         && XAxis         != null && other.XAxis         != null && XAxis.Equals(other.XAxis))                                    &&
                   (YAxis         == other.YAxis         && YAxis         != null && other.YAxis         != null && YAxis.Equals(other.YAxis))                                    &&
                   (IdsSrc        == other.IdsSrc        && IdsSrc        != null && other.IdsSrc        != null && IdsSrc.Equals(other.IdsSrc))                                  &&
                   (CustomDataSrc == other.CustomDataSrc && CustomDataSrc != null && other.CustomDataSrc != null && CustomDataSrc.Equals(other.CustomDataSrc))                    &&
                   (MetaSrc       == other.MetaSrc       && MetaSrc       != null && other.MetaSrc       != null && MetaSrc.Equals(other.MetaSrc))                                &&
                   (HoverInfoSrc  == other.HoverInfoSrc  && HoverInfoSrc  != null && other.HoverInfoSrc  != null && HoverInfoSrc.Equals(other.HoverInfoSrc))                      &&
                   (XSrc          == other.XSrc          && XSrc          != null && other.XSrc          != null && XSrc.Equals(other.XSrc))                                      &&
                   (YSrc          == other.YSrc          && YSrc          != null && other.YSrc          != null && YSrc.Equals(other.YSrc))                                      &&
                   (XYSrc         == other.XYSrc         && XYSrc         != null && other.XYSrc         != null && XYSrc.Equals(other.XYSrc))                                    &&
                   (IndicesSrc    == other.IndicesSrc    && IndicesSrc    != null && other.IndicesSrc    != null && IndicesSrc.Equals(other.IndicesSrc))                          &&
                   (XBoundsSrc    == other.XBoundsSrc    && XBoundsSrc    != null && other.XBoundsSrc    != null && XBoundsSrc.Equals(other.XBoundsSrc))                          &&
                   (YBoundsSrc    == other.YBoundsSrc    && YBoundsSrc    != null && other.YBoundsSrc    != null && YBoundsSrc.Equals(other.YBoundsSrc))                          &&
                   (TextSrc       == other.TextSrc       && TextSrc       != null && other.TextSrc       != null && TextSrc.Equals(other.TextSrc));
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

                if(X != null)
                    hashCode = hashCode * 59 + X.GetHashCode();

                if(Y != null)
                    hashCode = hashCode * 59 + Y.GetHashCode();

                if(XY != null)
                    hashCode = hashCode * 59 + XY.GetHashCode();

                if(Indices != null)
                    hashCode = hashCode * 59 + Indices.GetHashCode();

                if(XBounds != null)
                    hashCode = hashCode * 59 + XBounds.GetHashCode();

                if(YBounds != null)
                    hashCode = hashCode * 59 + YBounds.GetHashCode();

                if(Text != null)
                    hashCode = hashCode * 59 + Text.GetHashCode();

                if(TextArray != null)
                    hashCode = hashCode * 59 + TextArray.GetHashCode();

                if(Marker != null)
                    hashCode = hashCode * 59 + Marker.GetHashCode();

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

                if(HoverInfoSrc != null)
                    hashCode = hashCode * 59 + HoverInfoSrc.GetHashCode();

                if(XSrc != null)
                    hashCode = hashCode * 59 + XSrc.GetHashCode();

                if(YSrc != null)
                    hashCode = hashCode * 59 + YSrc.GetHashCode();

                if(XYSrc != null)
                    hashCode = hashCode * 59 + XYSrc.GetHashCode();

                if(IndicesSrc != null)
                    hashCode = hashCode * 59 + IndicesSrc.GetHashCode();

                if(XBoundsSrc != null)
                    hashCode = hashCode * 59 + XBoundsSrc.GetHashCode();

                if(YBoundsSrc != null)
                    hashCode = hashCode * 59 + YBoundsSrc.GetHashCode();

                if(TextSrc != null)
                    hashCode = hashCode * 59 + TextSrc.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left PointCloud and the right PointCloud.
        /// </summary>
        /// <param name="left">Left PointCloud.</param>
        /// <param name="right">Right PointCloud.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(PointCloud left,
                                       PointCloud right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left PointCloud and the right PointCloud.
        /// </summary>
        /// <param name="left">Left PointCloud.</param>
        /// <param name="right">Right PointCloud.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(PointCloud left,
                                       PointCloud right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>PointCloud</returns>
        public PointCloud DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<PointCloud>(ms).Result;
        }
    }
}
