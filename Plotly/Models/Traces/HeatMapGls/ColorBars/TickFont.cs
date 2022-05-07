using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Plotly.Models.Traces.HeatMapGls.ColorBars
{
    /// <summary>
    ///     The TickFont class.
    /// </summary>
    [Serializable]
    public class TickFont : IEquatable<TickFont>
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
        ///     Gets or sets the Size.
        /// </summary>
        [JsonPropertyName(@"size")]
        public JsNumber? Size { get; set; }

        /// <summary>
        ///     Gets or sets the Color.
        /// </summary>
        [JsonPropertyName(@"color")]
        public object? Color { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is TickFont other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] TickFont other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (Family == other.Family && Family != null && other.Family != null && Family.Equals(other.Family)) &&
                   (Size   == other.Size   && Size   != null && other.Size   != null && Size.Equals(other.Size))     &&
                   (Color  == other.Color  && Color  != null && other.Color  != null && Color.Equals(other.Color));
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;

                if(Family != null)
                    hashCode = hashCode * 59 + Family.GetHashCode();

                if(Size != null)
                    hashCode = hashCode * 59 + Size.GetHashCode();

                if(Color != null)
                    hashCode = hashCode * 59 + Color.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left TickFont and the right TickFont.
        /// </summary>
        /// <param name="left">Left TickFont.</param>
        /// <param name="right">Right TickFont.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(TickFont left,
                                       TickFont right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left TickFont and the right TickFont.
        /// </summary>
        /// <param name="left">Left TickFont.</param>
        /// <param name="right">Right TickFont.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(TickFont left,
                                       TickFont right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>TickFont</returns>
        public TickFont DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<TickFont>(ms).Result;
        }
    }
}
