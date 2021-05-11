using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Traces.Carpets;

using Stream = Plotly.Models.Traces.Carpets.Stream;

namespace Plotly.Models.Traces
{
    /// <summary>
    ///     The Carpet class.
    ///     Implements the <see cref="ITrace" />.
    /// </summary>
    [JsonConverter(typeof(PlotlyConverter))]
    [Serializable]
    public class Carpet : ITrace, IEquatable<Carpet>
    {
        /// <inheritdoc/>
        [JsonPropertyName(@"type")]
        public TraceTypeEnum? Type { get; } = TraceTypeEnum.Carpet;

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
        public string _Carpet { get; set; }

        /// <summary>
        ///     A two dimensional array of x coordinates at each carpet point. If ommitted,
        ///     the plot is a cheater plot and the xaxis is hidden by default.
        /// </summary>
        [JsonPropertyName(@"x")]
        public List<object> X { get; set; }

        /// <summary>
        ///     A two dimensional array of y coordinates at each carpet point.
        /// </summary>
        [JsonPropertyName(@"y")]
        public List<object> Y { get; set; }

        /// <summary>
        ///     An array containing values of the first parameter value
        /// </summary>
        [JsonPropertyName(@"a")]
        public List<object> A { get; set; }

        /// <summary>
        ///     Alternate to <c>a</c>. Builds a linear space of a coordinates. Use with
        ///     <c>da</c> where <c>a0</c> is the starting coordinate and <c>da</c> the step.
        /// </summary>
        [JsonPropertyName(@"a0")]
        public JsNumber? A0 { get; set; }

        /// <summary>
        ///     Sets the a coordinate step. See <c>a0</c> for more info.
        /// </summary>
        [JsonPropertyName(@"da")]
        public JsNumber? DA { get; set; }

        /// <summary>
        ///     A two dimensional array of y coordinates at each carpet point.
        /// </summary>
        [JsonPropertyName(@"b")]
        public List<object> B { get; set; }

        /// <summary>
        ///     Alternate to <c>b</c>. Builds a linear space of a coordinates. Use with
        ///     <c>db</c> where <c>b0</c> is the starting coordinate and <c>db</c> the step.
        /// </summary>
        [JsonPropertyName(@"b0")]
        public JsNumber? B0 { get; set; }

        /// <summary>
        ///     Sets the b coordinate step. See <c>b0</c> for more info.
        /// </summary>
        [JsonPropertyName(@"db")]
        public JsNumber? Db { get; set; }

        /// <summary>
        ///     The shift applied to each successive row of data in creating a cheater plot.
        ///     Only used if <c>x</c> is been ommitted.
        /// </summary>
        [JsonPropertyName(@"cheaterslope")]
        public JsNumber? CheaterSlope { get; set; }

        /// <summary>
        ///     Gets or sets the AAxis.
        /// </summary>
        [JsonPropertyName(@"aaxis")]
        public AAxis AAxis { get; set; }

        /// <summary>
        ///     Gets or sets the BAxis.
        /// </summary>
        [JsonPropertyName(@"baxis")]
        public BAxis BAxis { get; set; }

        /// <summary>
        ///     The default font used for axis &amp; tick labels on this carpet
        /// </summary>
        [JsonPropertyName(@"font")]
        public Font Font { get; set; }

        /// <summary>
        ///     Sets default for all colors associated with this axis all at once: line,
        ///     font, tick, and grid colors. Grid color is lightened by blending this with
        ///     the plot background Individual pieces can override this.
        /// </summary>
        [JsonPropertyName(@"color")]
        public object Color { get; set; }

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
        ///     Sets the source reference on Chart Studio Cloud for  a .
        /// </summary>
        [JsonPropertyName(@"asrc")]
        public string ASrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  b .
        /// </summary>
        [JsonPropertyName(@"bsrc")]
        public string BSrc { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is Carpet other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] Carpet other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (Type    == other.Type    && Type    != null && other.Type    != null && Type.Equals(other.Type))                                           &&
                   (Visible == other.Visible && Visible != null && other.Visible != null && Visible.Equals(other.Visible))                                     &&
                   (Opacity == other.Opacity && Opacity != null && other.Opacity != null && Opacity.Equals(other.Opacity))                                     &&
                   (Name    == other.Name    && Name    != null && other.Name    != null && Name.Equals(other.Name))                                           &&
                   (UId     == other.UId     && UId     != null && other.UId     != null && UId.Equals(other.UId))                                             &&
                   (Equals(Ids,        other.Ids)        || Ids        != null && other.Ids        != null && Ids.SequenceEqual(other.Ids))                    &&
                   (Equals(CustomData, other.CustomData) || CustomData != null && other.CustomData != null && CustomData.SequenceEqual(other.CustomData))      &&
                   (Meta == other.Meta && Meta != null && other.Meta != null && Meta.Equals(other.Meta))                                                       &&
                   (Equals(MetaArray, other.MetaArray) || MetaArray != null && other.MetaArray != null && MetaArray.SequenceEqual(other.MetaArray))            &&
                   (Stream     == other.Stream     && Stream     != null && other.Stream     != null && Stream.Equals(other.Stream))                           &&
                   (UiRevision == other.UiRevision && UiRevision != null && other.UiRevision != null && UiRevision.Equals(other.UiRevision))                   &&
                   (_Carpet    == other._Carpet    && _Carpet    != null && other._Carpet    != null && _Carpet.Equals(other._Carpet))                         &&
                   (Equals(X, other.X) || X != null && other.X != null && X.SequenceEqual(other.X))                                                            &&
                   (Equals(Y, other.Y) || Y != null && other.Y != null && Y.SequenceEqual(other.Y))                                                            &&
                   (Equals(A, other.A) || A != null && other.A != null && A.SequenceEqual(other.A))                                                            &&
                   (A0 == other.A0 && A0 != null && other.A0 != null && A0.Equals(other.A0))                                                                   &&
                   (DA == other.DA && DA != null && other.DA != null && DA.Equals(other.DA))                                                                   &&
                   (Equals(B, other.B) || B != null && other.B != null && B.SequenceEqual(other.B))                                                            &&
                   (B0            == other.B0            && B0            != null && other.B0            != null && B0.Equals(other.B0))                       &&
                   (Db            == other.Db            && Db            != null && other.Db            != null && Db.Equals(other.Db))                       &&
                   (CheaterSlope  == other.CheaterSlope  && CheaterSlope  != null && other.CheaterSlope  != null && CheaterSlope.Equals(other.CheaterSlope))   &&
                   (AAxis         == other.AAxis         && AAxis         != null && other.AAxis         != null && AAxis.Equals(other.AAxis))                 &&
                   (BAxis         == other.BAxis         && BAxis         != null && other.BAxis         != null && BAxis.Equals(other.BAxis))                 &&
                   (Font          == other.Font          && Font          != null && other.Font          != null && Font.Equals(other.Font))                   &&
                   (Color         == other.Color         && Color         != null && other.Color         != null && Color.Equals(other.Color))                 &&
                   (XAxis         == other.XAxis         && XAxis         != null && other.XAxis         != null && XAxis.Equals(other.XAxis))                 &&
                   (YAxis         == other.YAxis         && YAxis         != null && other.YAxis         != null && YAxis.Equals(other.YAxis))                 &&
                   (IdsSrc        == other.IdsSrc        && IdsSrc        != null && other.IdsSrc        != null && IdsSrc.Equals(other.IdsSrc))               &&
                   (CustomDataSrc == other.CustomDataSrc && CustomDataSrc != null && other.CustomDataSrc != null && CustomDataSrc.Equals(other.CustomDataSrc)) &&
                   (MetaSrc       == other.MetaSrc       && MetaSrc       != null && other.MetaSrc       != null && MetaSrc.Equals(other.MetaSrc))             &&
                   (XSrc          == other.XSrc          && XSrc          != null && other.XSrc          != null && XSrc.Equals(other.XSrc))                   &&
                   (YSrc          == other.YSrc          && YSrc          != null && other.YSrc          != null && YSrc.Equals(other.YSrc))                   &&
                   (ASrc          == other.ASrc          && ASrc          != null && other.ASrc          != null && ASrc.Equals(other.ASrc))                   &&
                   (BSrc          == other.BSrc          && BSrc          != null && other.BSrc          != null && BSrc.Equals(other.BSrc));
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

                if(Stream != null)
                    hashCode = hashCode * 59 + Stream.GetHashCode();

                if(UiRevision != null)
                    hashCode = hashCode * 59 + UiRevision.GetHashCode();

                if(_Carpet != null)
                    hashCode = hashCode * 59 + _Carpet.GetHashCode();

                if(X != null)
                    hashCode = hashCode * 59 + X.GetHashCode();

                if(Y != null)
                    hashCode = hashCode * 59 + Y.GetHashCode();

                if(A != null)
                    hashCode = hashCode * 59 + A.GetHashCode();

                if(A0 != null)
                    hashCode = hashCode * 59 + A0.GetHashCode();

                if(DA != null)
                    hashCode = hashCode * 59 + DA.GetHashCode();

                if(B != null)
                    hashCode = hashCode * 59 + B.GetHashCode();

                if(B0 != null)
                    hashCode = hashCode * 59 + B0.GetHashCode();

                if(Db != null)
                    hashCode = hashCode * 59 + Db.GetHashCode();

                if(CheaterSlope != null)
                    hashCode = hashCode * 59 + CheaterSlope.GetHashCode();

                if(AAxis != null)
                    hashCode = hashCode * 59 + AAxis.GetHashCode();

                if(BAxis != null)
                    hashCode = hashCode * 59 + BAxis.GetHashCode();

                if(Font != null)
                    hashCode = hashCode * 59 + Font.GetHashCode();

                if(Color != null)
                    hashCode = hashCode * 59 + Color.GetHashCode();

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

                if(XSrc != null)
                    hashCode = hashCode * 59 + XSrc.GetHashCode();

                if(YSrc != null)
                    hashCode = hashCode * 59 + YSrc.GetHashCode();

                if(ASrc != null)
                    hashCode = hashCode * 59 + ASrc.GetHashCode();

                if(BSrc != null)
                    hashCode = hashCode * 59 + BSrc.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Carpet and the right Carpet.
        /// </summary>
        /// <param name="left">Left Carpet.</param>
        /// <param name="right">Right Carpet.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(Carpet left,
                                       Carpet right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Carpet and the right Carpet.
        /// </summary>
        /// <param name="left">Left Carpet.</param>
        /// <param name="right">Right Carpet.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(Carpet left,
                                       Carpet right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Carpet</returns>
        public Carpet DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<Carpet>(ms).Result;
        }
    }
}
