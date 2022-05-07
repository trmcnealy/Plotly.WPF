using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Layouts.ColorAxes;

namespace Plotly.Models.Layouts
{
    /// <summary>
    ///     The ColorAxis class.
    /// </summary>
    [Serializable]
    public class ColorAxis : IEquatable<ColorAxis>
    {
        /// <summary>
        ///     Determines whether or not the color domain is computed with respect to the
        ///     input data (here corresponding trace color array(s)) or the bounds set in
        ///     <c>cmin</c> and <c>cmax</c>  Defaults to <c>false</c> when <c>cmin</c> and
        ///     <c>cmax</c> are set by the user.
        /// </summary>
        [JsonPropertyName(@"cauto")]
        public bool? CAuto { get; set; }

        /// <summary>
        ///     Sets the lower bound of the color domain. Value should have the same units
        ///     as corresponding trace color array(s) and if set, <c>cmax</c> must be set
        ///     as well.
        /// </summary>
        [JsonPropertyName(@"cmin")]
        public JsNumber? CMin { get; set; }

        /// <summary>
        ///     Sets the upper bound of the color domain. Value should have the same units
        ///     as corresponding trace color array(s) and if set, <c>cmin</c> must be set
        ///     as well.
        /// </summary>
        [JsonPropertyName(@"cmax")]
        public JsNumber? CMax { get; set; }

        /// <summary>
        ///     Sets the mid-point of the color domain by scaling <c>cmin</c> and/or <c>cmax</c>
        ///     to be equidistant to this point. Value should have the same units as corresponding
        ///     trace color array(s). Has no effect when <c>cauto</c> is <c>false</c>.
        /// </summary>
        [JsonPropertyName(@"cmid")]
        public JsNumber? CMid { get; set; }

        /// <summary>
        ///     Sets the colorscale. The colorscale must be an array containing arrays mapping
        ///     a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string.
        ///     At minimum, a mapping for the lowest (0) and highest (1) values are required.
        ///     For example, &#39;[[0, <c>rgb(0,0,255)</c>], [1, <c>rgb(255,0,0)</c>]]&#39;.
        ///     To control the bounds of the colorscale in color space, use<c>cmin</c> and
        ///     <c>cmax</c>. Alternatively, <c>colorscale</c> may be a palette name string
        ///     of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
        /// </summary>
        [JsonPropertyName(@"colorscale")]
        public object? ColorScale { get; set; }

        /// <summary>
        ///     Determines whether the colorscale is a default palette (&#39;autocolorscale:
        ///     true&#39;) or the palette determined by <c>colorscale</c>. In case <c>colorscale</c>
        ///     is unspecified or <c>autocolorscale</c> is true, the default  palette will
        ///     be chosen according to whether numbers in the <c>color</c> array are all
        ///     positive, all negative or mixed.
        /// </summary>
        [JsonPropertyName(@"autocolorscale")]
        public bool? AutoColorScale { get; set; }

        /// <summary>
        ///     Reverses the color mapping if true. If true, <c>cmin</c> will correspond
        ///     to the last color in the array and <c>cmax</c> will correspond to the first
        ///     color.
        /// </summary>
        [JsonPropertyName(@"reversescale")]
        public bool? ReverseScale { get; set; }

        /// <summary>
        ///     Determines whether or not a colorbar is displayed for this trace.
        /// </summary>
        [JsonPropertyName(@"showscale")]
        public bool? ShowScale { get; set; }

        /// <summary>
        ///     Gets or sets the ColorBar.
        /// </summary>
        [JsonPropertyName(@"colorbar")]
        public ColorBar? ColorBar { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is ColorAxis other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] ColorAxis other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (CAuto          == other.CAuto          && CAuto          != null && other.CAuto          != null && CAuto.Equals(other.CAuto))                   &&
                   (CMin           == other.CMin           && CMin           != null && other.CMin           != null && CMin.Equals(other.CMin))                     &&
                   (CMax           == other.CMax           && CMax           != null && other.CMax           != null && CMax.Equals(other.CMax))                     &&
                   (CMid           == other.CMid           && CMid           != null && other.CMid           != null && CMid.Equals(other.CMid))                     &&
                   (ColorScale     == other.ColorScale     && ColorScale     != null && other.ColorScale     != null && ColorScale.Equals(other.ColorScale))         &&
                   (AutoColorScale == other.AutoColorScale && AutoColorScale != null && other.AutoColorScale != null && AutoColorScale.Equals(other.AutoColorScale)) &&
                   (ReverseScale   == other.ReverseScale   && ReverseScale   != null && other.ReverseScale   != null && ReverseScale.Equals(other.ReverseScale))     &&
                   (ShowScale      == other.ShowScale      && ShowScale      != null && other.ShowScale      != null && ShowScale.Equals(other.ShowScale))           &&
                   (ColorBar       == other.ColorBar       && ColorBar       != null && other.ColorBar       != null && ColorBar.Equals(other.ColorBar));
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;

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

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left ColorAxis and the right ColorAxis.
        /// </summary>
        /// <param name="left">Left ColorAxis.</param>
        /// <param name="right">Right ColorAxis.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(ColorAxis left,
                                       ColorAxis right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left ColorAxis and the right ColorAxis.
        /// </summary>
        /// <param name="left">Left ColorAxis.</param>
        /// <param name="right">Right ColorAxis.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(ColorAxis left,
                                       ColorAxis right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>ColorAxis</returns>
        public ColorAxis DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<ColorAxis>(ms).Result;
        }
    }
}
