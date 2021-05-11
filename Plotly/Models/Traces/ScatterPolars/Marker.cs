using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Traces.ScatterPolars.Markers;

namespace Plotly.Models.Traces.ScatterPolars
{
    /// <summary>
    ///     The Marker class.
    /// </summary>
    [JsonConverter(typeof(PlotlyConverter))]
    [Serializable]
    public class Marker : IEquatable<Marker>
    {
        /// <summary>
        ///     Sets the marker symbol type. Adding 100 is equivalent to appending <c>-open</c>
        ///     to a symbol name. Adding 200 is equivalent to appending <c>-dot</c> to a
        ///     symbol name. Adding 300 is equivalent to appending <c>-open-dot</c> or <c>dot-open</c>
        ///     to a symbol name.
        /// </summary>
        [JsonPropertyName(@"symbol")]
        public SymbolEnum? Symbol { get; set; }

        /// <summary>
        ///     Sets the marker symbol type. Adding 100 is equivalent to appending <c>-open</c>
        ///     to a symbol name. Adding 200 is equivalent to appending <c>-dot</c> to a
        ///     symbol name. Adding 300 is equivalent to appending <c>-open-dot</c> or <c>dot-open</c>
        ///     to a symbol name.
        /// </summary>
        [JsonPropertyName(@"symbol")]
        [Array]
        public List<SymbolEnum?> SymbolArray { get; set; }

        /// <summary>
        ///     Sets the marker opacity.
        /// </summary>
        [JsonPropertyName(@"opacity")]
        public JsNumber? Opacity { get; set; }

        /// <summary>
        ///     Sets the marker opacity.
        /// </summary>
        [JsonPropertyName(@"opacity")]
        [Array]
        public List<JsNumber?> OpacityArray { get; set; }

        /// <summary>
        ///     Sets the marker size (in px).
        /// </summary>
        [JsonPropertyName(@"size")]
        public JsNumber? Size { get; set; }

        /// <summary>
        ///     Sets the marker size (in px).
        /// </summary>
        [JsonPropertyName(@"size")]
        [Array]
        public List<JsNumber?> SizeArray { get; set; }

        /// <summary>
        ///     Sets a maximum number of points to be drawn on the graph. <c>0</c> corresponds
        ///     to no limit.
        /// </summary>
        [JsonPropertyName(@"maxdisplayed")]
        public JsNumber? MaxDisplayed { get; set; }

        /// <summary>
        ///     Has an effect only if <c>marker.size</c> is set to a numerical array. Sets
        ///     the scale factor used to determine the rendered size of marker points. Use
        ///     with <c>sizemin</c> and <c>sizemode</c>.
        /// </summary>
        [JsonPropertyName(@"sizeref")]
        public JsNumber? SizeRef { get; set; }

        /// <summary>
        ///     Has an effect only if <c>marker.size</c> is set to a numerical array. Sets
        ///     the minimum size (in px) of the rendered marker points.
        /// </summary>
        [JsonPropertyName(@"sizemin")]
        public JsNumber? SizeMin { get; set; }

        /// <summary>
        ///     Has an effect only if <c>marker.size</c> is set to a numerical array. Sets
        ///     the rule for which the data in <c>size</c> is converted to pixels.
        /// </summary>
        [JsonPropertyName(@"sizemode")]
        public SizeModeEnum? SizeMode { get; set; }

        /// <summary>
        ///     Gets or sets the Line.
        /// </summary>
        [JsonPropertyName(@"line")]
        public Markers.Line Line { get; set; }

        /// <summary>
        ///     Gets or sets the Gradient.
        /// </summary>
        [JsonPropertyName(@"gradient")]
        public Gradient Gradient { get; set; }

        /// <summary>
        ///     Sets themarkercolor. It accepts either a specific color or an array of numbers
        ///     that are mapped to the colorscale relative to the max and min values of
        ///     the array or relative to <c>marker.cmin</c> and <c>marker.cmax</c> if set.
        /// </summary>
        [JsonPropertyName(@"color")]
        public object Color { get; set; }

        /// <summary>
        ///     Sets themarkercolor. It accepts either a specific color or an array of numbers
        ///     that are mapped to the colorscale relative to the max and min values of
        ///     the array or relative to <c>marker.cmin</c> and <c>marker.cmax</c> if set.
        /// </summary>
        [JsonPropertyName(@"color")]
        [Array]
        public List<object> ColorArray { get; set; }

        /// <summary>
        ///     Determines whether or not the color domain is computed with respect to the
        ///     input data (here in <c>marker.color</c>) or the bounds set in <c>marker.cmin</c>
        ///     and <c>marker.cmax</c>  Has an effect only if in <c>marker.color</c>is set
        ///     to a numerical array. Defaults to <c>false</c> when <c>marker.cmin</c> and
        ///     <c>marker.cmax</c> are set by the user.
        /// </summary>
        [JsonPropertyName(@"cauto")]
        public bool? CAuto { get; set; }

        /// <summary>
        ///     Sets the lower bound of the color domain. Has an effect only if in <c>marker.color</c>is
        ///     set to a numerical array. Value should have the same units as in <c>marker.color</c>
        ///     and if set, <c>marker.cmax</c> must be set as well.
        /// </summary>
        [JsonPropertyName(@"cmin")]
        public JsNumber? CMin { get; set; }

        /// <summary>
        ///     Sets the upper bound of the color domain. Has an effect only if in <c>marker.color</c>is
        ///     set to a numerical array. Value should have the same units as in <c>marker.color</c>
        ///     and if set, <c>marker.cmin</c> must be set as well.
        /// </summary>
        [JsonPropertyName(@"cmax")]
        public JsNumber? CMax { get; set; }

        /// <summary>
        ///     Sets the mid-point of the color domain by scaling <c>marker.cmin</c> and/or
        ///     <c>marker.cmax</c> to be equidistant to this point. Has an effect only if
        ///     in <c>marker.color</c>is set to a numerical array. Value should have the
        ///     same units as in <c>marker.color</c>. Has no effect when <c>marker.cauto</c>
        ///     is <c>false</c>.
        /// </summary>
        [JsonPropertyName(@"cmid")]
        public JsNumber? CMid { get; set; }

        /// <summary>
        ///     Sets the colorscale. Has an effect only if in <c>marker.color</c>is set
        ///     to a numerical array. The colorscale must be an array containing arrays
        ///     mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color
        ///     string. At minimum, a mapping for the lowest (0) and highest (1) values
        ///     are required. For example, &#39;[[0, <c>rgb(0,0,255)</c>], [1, <c>rgb(255,0,0)</c>]]&#39;.
        ///     To control the bounds of the colorscale in color space, use<c>marker.cmin</c>
        ///     and <c>marker.cmax</c>. Alternatively, <c>colorscale</c> may be a palette
        ///     name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
        /// </summary>
        [JsonPropertyName(@"colorscale")]
        public object ColorScale { get; set; }

        /// <summary>
        ///     Determines whether the colorscale is a default palette (&#39;autocolorscale:
        ///     true&#39;) or the palette determined by <c>marker.colorscale</c>. Has an
        ///     effect only if in <c>marker.color</c>is set to a numerical array. In case
        ///     <c>colorscale</c> is unspecified or <c>autocolorscale</c> is true, the default
        ///      palette will be chosen according to whether numbers in the <c>color</c>
        ///     array are all positive, all negative or mixed.
        /// </summary>
        [JsonPropertyName(@"autocolorscale")]
        public bool? AutoColorScale { get; set; }

        /// <summary>
        ///     Reverses the color mapping if true. Has an effect only if in <c>marker.color</c>is
        ///     set to a numerical array. If true, <c>marker.cmin</c> will correspond to
        ///     the last color in the array and <c>marker.cmax</c> will correspond to the
        ///     first color.
        /// </summary>
        [JsonPropertyName(@"reversescale")]
        public bool? ReverseScale { get; set; }

        /// <summary>
        ///     Determines whether or not a colorbar is displayed for this trace. Has an
        ///     effect only if in <c>marker.color</c>is set to a numerical array.
        /// </summary>
        [JsonPropertyName(@"showscale")]
        public bool? ShowScale { get; set; }

        /// <summary>
        ///     Gets or sets the ColorBar.
        /// </summary>
        [JsonPropertyName(@"colorbar")]
        public ColorBar ColorBar { get; set; }

        /// <summary>
        ///     Sets a reference to a shared color axis. References to these shared color
        ///     axes are <c>coloraxis</c>, <c>coloraxis2</c>, <c>coloraxis3</c>, etc. Settings
        ///     for these shared color axes are set in the layout, under <c>layout.coloraxis</c>,
        ///     <c>layout.coloraxis2</c>, etc. Note that multiple color scales can be linked
        ///     to the same color axis.
        /// </summary>
        [JsonPropertyName(@"coloraxis")]
        public string ColorAxis { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  symbol .
        /// </summary>
        [JsonPropertyName(@"symbolsrc")]
        public string SymbolSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  opacity .
        /// </summary>
        [JsonPropertyName(@"opacitysrc")]
        public string OpacitySrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  size .
        /// </summary>
        [JsonPropertyName(@"sizesrc")]
        public string SizeSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  color .
        /// </summary>
        [JsonPropertyName(@"colorsrc")]
        public string ColorSrc { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is Marker other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] Marker other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (Symbol == other.Symbol && Symbol != null && other.Symbol != null && Symbol.Equals(other.Symbol))                                                  &&
                   (Equals(SymbolArray, other.SymbolArray) || SymbolArray != null && other.SymbolArray != null && SymbolArray.SequenceEqual(other.SymbolArray))       &&
                   (Opacity == other.Opacity && Opacity != null && other.Opacity != null && Opacity.Equals(other.Opacity))                                            &&
                   (Equals(OpacityArray, other.OpacityArray) || OpacityArray != null && other.OpacityArray != null && OpacityArray.SequenceEqual(other.OpacityArray)) &&
                   (Size == other.Size && Size != null && other.Size != null && Size.Equals(other.Size))                                                              &&
                   (Equals(SizeArray, other.SizeArray) || SizeArray != null && other.SizeArray != null && SizeArray.SequenceEqual(other.SizeArray))                   &&
                   (MaxDisplayed == other.MaxDisplayed && MaxDisplayed != null && other.MaxDisplayed != null && MaxDisplayed.Equals(other.MaxDisplayed))              &&
                   (SizeRef      == other.SizeRef      && SizeRef      != null && other.SizeRef      != null && SizeRef.Equals(other.SizeRef))                        &&
                   (SizeMin      == other.SizeMin      && SizeMin      != null && other.SizeMin      != null && SizeMin.Equals(other.SizeMin))                        &&
                   (SizeMode     == other.SizeMode     && SizeMode     != null && other.SizeMode     != null && SizeMode.Equals(other.SizeMode))                      &&
                   (Line         == other.Line         && Line         != null && other.Line         != null && Line.Equals(other.Line))                              &&
                   (Gradient     == other.Gradient     && Gradient     != null && other.Gradient     != null && Gradient.Equals(other.Gradient))                      &&
                   (Color        == other.Color        && Color        != null && other.Color        != null && Color.Equals(other.Color))                            &&
                   (Equals(ColorArray, other.ColorArray) || ColorArray != null && other.ColorArray != null && ColorArray.SequenceEqual(other.ColorArray))             &&
                   (CAuto          == other.CAuto          && CAuto          != null && other.CAuto          != null && CAuto.Equals(other.CAuto))                    &&
                   (CMin           == other.CMin           && CMin           != null && other.CMin           != null && CMin.Equals(other.CMin))                      &&
                   (CMax           == other.CMax           && CMax           != null && other.CMax           != null && CMax.Equals(other.CMax))                      &&
                   (CMid           == other.CMid           && CMid           != null && other.CMid           != null && CMid.Equals(other.CMid))                      &&
                   (ColorScale     == other.ColorScale     && ColorScale     != null && other.ColorScale     != null && ColorScale.Equals(other.ColorScale))          &&
                   (AutoColorScale == other.AutoColorScale && AutoColorScale != null && other.AutoColorScale != null && AutoColorScale.Equals(other.AutoColorScale))  &&
                   (ReverseScale   == other.ReverseScale   && ReverseScale   != null && other.ReverseScale   != null && ReverseScale.Equals(other.ReverseScale))      &&
                   (ShowScale      == other.ShowScale      && ShowScale      != null && other.ShowScale      != null && ShowScale.Equals(other.ShowScale))            &&
                   (ColorBar       == other.ColorBar       && ColorBar       != null && other.ColorBar       != null && ColorBar.Equals(other.ColorBar))              &&
                   (ColorAxis      == other.ColorAxis      && ColorAxis      != null && other.ColorAxis      != null && ColorAxis.Equals(other.ColorAxis))            &&
                   (SymbolSrc      == other.SymbolSrc      && SymbolSrc      != null && other.SymbolSrc      != null && SymbolSrc.Equals(other.SymbolSrc))            &&
                   (OpacitySrc     == other.OpacitySrc     && OpacitySrc     != null && other.OpacitySrc     != null && OpacitySrc.Equals(other.OpacitySrc))          &&
                   (SizeSrc        == other.SizeSrc        && SizeSrc        != null && other.SizeSrc        != null && SizeSrc.Equals(other.SizeSrc))                &&
                   (ColorSrc       == other.ColorSrc       && ColorSrc       != null && other.ColorSrc       != null && ColorSrc.Equals(other.ColorSrc));
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;

                if(Symbol != null)
                    hashCode = hashCode * 59 + Symbol.GetHashCode();

                if(SymbolArray != null)
                    hashCode = hashCode * 59 + SymbolArray.GetHashCode();

                if(Opacity != null)
                    hashCode = hashCode * 59 + Opacity.GetHashCode();

                if(OpacityArray != null)
                    hashCode = hashCode * 59 + OpacityArray.GetHashCode();

                if(Size != null)
                    hashCode = hashCode * 59 + Size.GetHashCode();

                if(SizeArray != null)
                    hashCode = hashCode * 59 + SizeArray.GetHashCode();

                if(MaxDisplayed != null)
                    hashCode = hashCode * 59 + MaxDisplayed.GetHashCode();

                if(SizeRef != null)
                    hashCode = hashCode * 59 + SizeRef.GetHashCode();

                if(SizeMin != null)
                    hashCode = hashCode * 59 + SizeMin.GetHashCode();

                if(SizeMode != null)
                    hashCode = hashCode * 59 + SizeMode.GetHashCode();

                if(Line != null)
                    hashCode = hashCode * 59 + Line.GetHashCode();

                if(Gradient != null)
                    hashCode = hashCode * 59 + Gradient.GetHashCode();

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

                if(SymbolSrc != null)
                    hashCode = hashCode * 59 + SymbolSrc.GetHashCode();

                if(OpacitySrc != null)
                    hashCode = hashCode * 59 + OpacitySrc.GetHashCode();

                if(SizeSrc != null)
                    hashCode = hashCode * 59 + SizeSrc.GetHashCode();

                if(ColorSrc != null)
                    hashCode = hashCode * 59 + ColorSrc.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Marker and the right Marker.
        /// </summary>
        /// <param name="left">Left Marker.</param>
        /// <param name="right">Right Marker.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(Marker left,
                                       Marker right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Marker and the right Marker.
        /// </summary>
        /// <param name="left">Left Marker.</param>
        /// <param name="right">Right Marker.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(Marker left,
                                       Marker right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Marker</returns>
        public Marker DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<Marker>(ms).Result;
        }
    }
}
