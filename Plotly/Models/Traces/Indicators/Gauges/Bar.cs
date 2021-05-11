using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Traces.Indicators.Gauges.Bars;

namespace Plotly.Models.Traces.Indicators.Gauges
{
    /// <summary>
    ///     The Bar class.
    /// </summary>
    [Serializable]
    public class Bar : IEquatable<Bar>
    {
        /// <summary>
        ///     Sets the background color of the arc.
        /// </summary>
        [JsonPropertyName(@"color")]
        public object Color { get; set; }

        /// <summary>
        ///     Gets or sets the Line.
        /// </summary>
        [JsonPropertyName(@"line")]
        public Line Line { get; set; }

        /// <summary>
        ///     Sets the thickness of the bar as a fraction of the total thickness of the
        ///     gauge.
        /// </summary>
        [JsonPropertyName(@"thickness")]
        public JsNumber? Thickness { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is Bar other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] Bar other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (Color     == other.Color     && Color     != null && other.Color     != null && Color.Equals(other.Color)) &&
                   (Line      == other.Line      && Line      != null && other.Line      != null && Line.Equals(other.Line))   &&
                   (Thickness == other.Thickness && Thickness != null && other.Thickness != null && Thickness.Equals(other.Thickness));
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;

                if(Color != null)
                    hashCode = hashCode * 59 + Color.GetHashCode();

                if(Line != null)
                    hashCode = hashCode * 59 + Line.GetHashCode();

                if(Thickness != null)
                    hashCode = hashCode * 59 + Thickness.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Bar and the right Bar.
        /// </summary>
        /// <param name="left">Left Bar.</param>
        /// <param name="right">Right Bar.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(Bar left,
                                       Bar right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Bar and the right Bar.
        /// </summary>
        /// <param name="left">Left Bar.</param>
        /// <param name="right">Right Bar.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(Bar left,
                                       Bar right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Bar</returns>
        public Bar DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<Bar>(ms).Result;
        }
    }
}
