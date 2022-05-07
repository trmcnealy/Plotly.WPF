using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Traces.ParCoordss.Lines;

namespace Plotly.Models.Traces.ParCoordss
{
    /// <summary>
    ///     The Line class.
    /// </summary>
    [JsonConverter(typeof(PlotlyConverter))]
    [Serializable]
    public class Line : IEquatable<Line>
    {
        /// <summary>
        ///     Sets thelinecolor. It accepts either a specific color or an array of numbers
        ///     that are mapped to the colorscale relative to the max and min values of
        ///     the array or relative to <c>line.cmin</c> and <c>line.cmax</c> if set.
        /// </summary>
        [JsonPropertyName(@"color")]
        public object? Color { get; set; }

        /// <summary>
        ///     Sets thelinecolor. It accepts either a specific color or an array of numbers
        ///     that are mapped to the colorscale relative to the max and min values of
        ///     the array or relative to <c>line.cmin</c> and <c>line.cmax</c> if set.
        /// </summary>
        [JsonPropertyName(@"color")]
        [Array]
        public List<object>? ColorArray { get; set; }

        /// <summary>
        ///     Determines whether or not the color domain is computed with respect to the
        ///     input data (here in <c>line.color</c>) or the bounds set in <c>line.cmin</c>
        ///     and <c>line.cmax</c>  Has an effect only if in <c>line.color</c>is set to
        ///     a numerical array. Defaults to <c>false</c> when <c>line.cmin</c> and <c>line.cmax</c>
        ///     are set by the user.
        /// </summary>
        [JsonPropertyName(@"cauto")]
        public bool? CAuto { get; set; }

        /// <summary>
        ///     Sets the lower bound of the color domain. Has an effect only if in <c>line.color</c>is
        ///     set to a numerical array. Value should have the same units as in <c>line.color</c>
        ///     and if set, <c>line.cmax</c> must be set as well.
        /// </summary>
        [JsonPropertyName(@"cmin")]
        public JsNumber? CMin { get; set; }

        /// <summary>
        ///     Sets the upper bound of the color domain. Has an effect only if in <c>line.color</c>is
        ///     set to a numerical array. Value should have the same units as in <c>line.color</c>
        ///     and if set, <c>line.cmin</c> must be set as well.
        /// </summary>
        [JsonPropertyName(@"cmax")]
        public JsNumber? CMax { get; set; }

        /// <summary>
        ///     Sets the mid-point of the color domain by scaling <c>line.cmin</c> and/or
        ///     <c>line.cmax</c> to be equidistant to this point. Has an effect only if
        ///     in <c>line.color</c>is set to a numerical array. Value should have the same
        ///     units as in <c>line.color</c>. Has no effect when <c>line.cauto</c> is <c>false</c>.
        /// </summary>
        [JsonPropertyName(@"cmid")]
        public JsNumber? CMid { get; set; }

        /// <summary>
        ///     Sets the colorscale. Has an effect only if in <c>line.color</c>is set to
        ///     a numerical array. The colorscale must be an array containing arrays mapping
        ///     a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string.
        ///     At minimum, a mapping for the lowest (0) and highest (1) values are required.
        ///     For example, &#39;[[0, <c>rgb(0,0,255)</c>], [1, <c>rgb(255,0,0)</c>]]&#39;.
        ///     To control the bounds of the colorscale in color space, use<c>line.cmin</c>
        ///     and <c>line.cmax</c>. Alternatively, <c>colorscale</c> may be a palette
        ///     name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
        /// </summary>
        [JsonPropertyName(@"colorscale")]
        public object? ColorScale { get; set; }

        /// <summary>
        ///     Determines whether the colorscale is a default palette (&#39;autocolorscale:
        ///     true&#39;) or the palette determined by <c>line.colorscale</c>. Has an effect
        ///     only if in <c>line.color</c>is set to a numerical array. In case <c>colorscale</c>
        ///     is unspecified or <c>autocolorscale</c> is true, the default  palette will
        ///     be chosen according to whether numbers in the <c>color</c> array are all
        ///     positive, all negative or mixed.
        /// </summary>
        [JsonPropertyName(@"autocolorscale")]
        public bool? AutoColorScale { get; set; }

        /// <summary>
        ///     Reverses the color mapping if true. Has an effect only if in <c>line.color</c>is
        ///     set to a numerical array. If true, <c>line.cmin</c> will correspond to the
        ///     last color in the array and <c>line.cmax</c> will correspond to the first
        ///     color.
        /// </summary>
        [JsonPropertyName(@"reversescale")]
        public bool? ReverseScale { get; set; }

        /// <summary>
        ///     Determines whether or not a colorbar is displayed for this trace. Has an
        ///     effect only if in <c>line.color</c>is set to a numerical array.
        /// </summary>
        [JsonPropertyName(@"showscale")]
        public bool? ShowScale { get; set; }

        /// <summary>
        ///     Gets or sets the ColorBar.
        /// </summary>
        [JsonPropertyName(@"colorbar")]
        public ColorBar? ColorBar { get; set; }

        /// <summary>
        ///     Sets a reference to a shared color axis. References to these shared color
        ///     axes are <c>coloraxis</c>, <c>coloraxis2</c>, <c>coloraxis3</c>, etc. Settings
        ///     for these shared color axes are set in the layout, under <c>layout.coloraxis</c>,
        ///     <c>layout.coloraxis2</c>, etc. Note that multiple color scales can be linked
        ///     to the same color axis.
        /// </summary>
        [JsonPropertyName(@"coloraxis")]
        public string? ColorAxis { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  color .
        /// </summary>
        [JsonPropertyName(@"colorsrc")]
        public string? ColorSrc { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is Line other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] Line other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (Color == other.Color && Color != null && other.Color != null && Color.Equals(other.Color))                                                       &&
                   (Equals(ColorArray, other.ColorArray) || ColorArray != null && other.ColorArray != null && ColorArray.SequenceEqual(other.ColorArray))            &&
                   (CAuto          == other.CAuto          && CAuto          != null && other.CAuto          != null && CAuto.Equals(other.CAuto))                   &&
                   (CMin           == other.CMin           && CMin           != null && other.CMin           != null && CMin.Equals(other.CMin))                     &&
                   (CMax           == other.CMax           && CMax           != null && other.CMax           != null && CMax.Equals(other.CMax))                     &&
                   (CMid           == other.CMid           && CMid           != null && other.CMid           != null && CMid.Equals(other.CMid))                     &&
                   (ColorScale     == other.ColorScale     && ColorScale     != null && other.ColorScale     != null && ColorScale.Equals(other.ColorScale))         &&
                   (AutoColorScale == other.AutoColorScale && AutoColorScale != null && other.AutoColorScale != null && AutoColorScale.Equals(other.AutoColorScale)) &&
                   (ReverseScale   == other.ReverseScale   && ReverseScale   != null && other.ReverseScale   != null && ReverseScale.Equals(other.ReverseScale))     &&
                   (ShowScale      == other.ShowScale      && ShowScale      != null && other.ShowScale      != null && ShowScale.Equals(other.ShowScale))           &&
                   (ColorBar       == other.ColorBar       && ColorBar       != null && other.ColorBar       != null && ColorBar.Equals(other.ColorBar))             &&
                   (ColorAxis      == other.ColorAxis      && ColorAxis      != null && other.ColorAxis      != null && ColorAxis.Equals(other.ColorAxis))           &&
                   (ColorSrc       == other.ColorSrc       && ColorSrc       != null && other.ColorSrc       != null && ColorSrc.Equals(other.ColorSrc));
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;

                if(Color != null)
                    hashCode = hashCode * 59 + Color.GetHashCode();

                if(ColorArray != null)
                    hashCode = hashCode * 59 + ColorArray.GetHashCode();

                if(CAuto != null)
                    hashCode = hashCode * 59 + CAuto.GetHashCode();

                if(CMin != null)
                    hashCode = hashCode * 59 + CMin.GetHashCode();

                if(CMax != null)
                    hashCode = hashCode * 59 + CMax.GetHashCode();

                if(CMid != null)
                    hashCode = hashCode * 59 + CMid.GetHashCode();

                if(ColorScale != null)
                    hashCode = hashCode * 59 + ColorScale.GetHashCode();

                if(AutoColorScale != null)
                    hashCode = hashCode * 59 + AutoColorScale.GetHashCode();

                if(ReverseScale != null)
                    hashCode = hashCode * 59 + ReverseScale.GetHashCode();

                if(ShowScale != null)
                    hashCode = hashCode * 59 + ShowScale.GetHashCode();

                if(ColorBar != null)
                    hashCode = hashCode * 59 + ColorBar.GetHashCode();

                if(ColorAxis != null)
                    hashCode = hashCode * 59 + ColorAxis.GetHashCode();

                if(ColorSrc != null)
                    hashCode = hashCode * 59 + ColorSrc.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Line and the right Line.
        /// </summary>
        /// <param name="left">Left Line.</param>
        /// <param name="right">Right Line.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(Line left,
                                       Line right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Line and the right Line.
        /// </summary>
        /// <param name="left">Left Line.</param>
        /// <param name="right">Right Line.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(Line left,
                                       Line right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Line</returns>
        public Line DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<Line>(ms).Result;
        }
    }
}
