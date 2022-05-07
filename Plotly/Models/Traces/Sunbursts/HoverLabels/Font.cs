using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Plotly.Models.Traces.Sunbursts.HoverLabels
{
    /// <summary>
    ///     The Font class.
    /// </summary>
    [JsonConverter(typeof(PlotlyConverter))]
    [Serializable]
    public class Font : IEquatable<Font>
    {
        /// <summary>
        ///     HTML font family - the typeface that will be applied by the web browser.
        ///     The web browser will only be able to apply a font if it is available on
        ///     the system which it operates. Provide multiple font families, separated
        ///     by commas, to indicate the preference in which to apply fonts if they aren&#39;t
        ///     available on the system. The Chart Studio Cloud (at https://chart-studio.plotly.com
        ///     or on-premise) generates images on a server, where only a select number
        ///     of fonts are installed and supported. These include <c>Arial</c>, <c>Balto</c>,
        ///     &#39;Courier New&#39;, &#39;Droid Sans&#39;,, &#39;Droid Serif&#39;, &#39;Droid
        ///     Sans Mono&#39;, &#39;Gravitas One&#39;, &#39;Old Standard TT&#39;, &#39;Open
        ///     Sans&#39;, <c>Overpass</c>, &#39;PT Sans Narrow&#39;, <c>Raleway</c>, &#39;Times
        ///     New Roman&#39;.
        /// </summary>
        [JsonPropertyName(@"family")]
        public string? Family { get; set; }

        /// <summary>
        ///     HTML font family - the typeface that will be applied by the web browser.
        ///     The web browser will only be able to apply a font if it is available on
        ///     the system which it operates. Provide multiple font families, separated
        ///     by commas, to indicate the preference in which to apply fonts if they aren&#39;t
        ///     available on the system. The Chart Studio Cloud (at https://chart-studio.plotly.com
        ///     or on-premise) generates images on a server, where only a select number
        ///     of fonts are installed and supported. These include <c>Arial</c>, <c>Balto</c>,
        ///     &#39;Courier New&#39;, &#39;Droid Sans&#39;,, &#39;Droid Serif&#39;, &#39;Droid
        ///     Sans Mono&#39;, &#39;Gravitas One&#39;, &#39;Old Standard TT&#39;, &#39;Open
        ///     Sans&#39;, <c>Overpass</c>, &#39;PT Sans Narrow&#39;, <c>Raleway</c>, &#39;Times
        ///     New Roman&#39;.
        /// </summary>
        [JsonPropertyName(@"family")]
        [Array]
        public List<string>? FamilyArray { get; set; }

        /// <summary>
        ///     Gets or sets the Size.
        /// </summary>
        [JsonPropertyName(@"size")]
        public JsNumber? Size { get; set; }

        /// <summary>
        ///     Gets or sets the Size.
        /// </summary>
        [JsonPropertyName(@"size")]
        [Array]
        public List<JsNumber?>? SizeArray { get; set; }

        /// <summary>
        ///     Gets or sets the Color.
        /// </summary>
        [JsonPropertyName(@"color")]
        public object? Color { get; set; }

        /// <summary>
        ///     Gets or sets the Color.
        /// </summary>
        [JsonPropertyName(@"color")]
        [Array]
        public List<object>? ColorArray { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  family .
        /// </summary>
        [JsonPropertyName(@"familysrc")]
        public string? FamilySrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  size .
        /// </summary>
        [JsonPropertyName(@"sizesrc")]
        public string? SizeSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  color .
        /// </summary>
        [JsonPropertyName(@"colorsrc")]
        public string? ColorSrc { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is Font other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] Font other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (Family == other.Family && Family != null && other.Family != null && Family.Equals(other.Family))                                            &&
                   (Equals(FamilyArray, other.FamilyArray) || FamilyArray != null && other.FamilyArray != null && FamilyArray.SequenceEqual(other.FamilyArray)) &&
                   (Size == other.Size && Size != null && other.Size != null && Size.Equals(other.Size))                                                        &&
                   (Equals(SizeArray, other.SizeArray) || SizeArray != null && other.SizeArray != null && SizeArray.SequenceEqual(other.SizeArray))             &&
                   (Color == other.Color && Color != null && other.Color != null && Color.Equals(other.Color))                                                  &&
                   (Equals(ColorArray, other.ColorArray) || ColorArray != null && other.ColorArray != null && ColorArray.SequenceEqual(other.ColorArray))       &&
                   (FamilySrc == other.FamilySrc && FamilySrc != null && other.FamilySrc != null && FamilySrc.Equals(other.FamilySrc))                          &&
                   (SizeSrc   == other.SizeSrc   && SizeSrc   != null && other.SizeSrc   != null && SizeSrc.Equals(other.SizeSrc))                              &&
                   (ColorSrc  == other.ColorSrc  && ColorSrc  != null && other.ColorSrc  != null && ColorSrc.Equals(other.ColorSrc));
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;

                if(Family != null)
                    hashCode = hashCode * 59 + Family.GetHashCode();

                if(FamilyArray != null)
                    hashCode = hashCode * 59 + FamilyArray.GetHashCode();

                if(Size != null)
                    hashCode = hashCode * 59 + Size.GetHashCode();

                if(SizeArray != null)
                    hashCode = hashCode * 59 + SizeArray.GetHashCode();

                if(Color != null)
                    hashCode = hashCode * 59 + Color.GetHashCode();

                if(ColorArray != null)
                    hashCode = hashCode * 59 + ColorArray.GetHashCode();

                if(FamilySrc != null)
                    hashCode = hashCode * 59 + FamilySrc.GetHashCode();

                if(SizeSrc != null)
                    hashCode = hashCode * 59 + SizeSrc.GetHashCode();

                if(ColorSrc != null)
                    hashCode = hashCode * 59 + ColorSrc.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Font and the right Font.
        /// </summary>
        /// <param name="left">Left Font.</param>
        /// <param name="right">Right Font.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(Font left,
                                       Font right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Font and the right Font.
        /// </summary>
        /// <param name="left">Left Font.</param>
        /// <param name="right">Right Font.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(Font left,
                                       Font right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Font</returns>
        public Font DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<Font>(ms).Result;
        }
    }
}
