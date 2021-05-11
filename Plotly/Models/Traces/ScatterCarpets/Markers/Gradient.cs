using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Traces.ScatterCarpets.Markers.Gradients;

namespace Plotly.Models.Traces.ScatterCarpets.Markers
{
    /// <summary>
    ///     The Gradient class.
    /// </summary>
    [JsonConverter(typeof(PlotlyConverter))]
    [Serializable]
    public class Gradient : IEquatable<Gradient>
    {
        /// <summary>
        ///     Sets the type of gradient used to fill the markers
        /// </summary>
        [JsonPropertyName(@"type")]
        public TypeEnum? Type { get; set; }

        /// <summary>
        ///     Sets the type of gradient used to fill the markers
        /// </summary>
        [JsonPropertyName(@"type")]
        [Array]
        public List<TypeEnum?> TypeArray { get; set; }

        /// <summary>
        ///     Sets the final color of the gradient fill: the center color for radial,
        ///     the right for horizontal, or the bottom for vertical.
        /// </summary>
        [JsonPropertyName(@"color")]
        public object Color { get; set; }

        /// <summary>
        ///     Sets the final color of the gradient fill: the center color for radial,
        ///     the right for horizontal, or the bottom for vertical.
        /// </summary>
        [JsonPropertyName(@"color")]
        [Array]
        public List<object> ColorArray { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  type .
        /// </summary>
        [JsonPropertyName(@"typesrc")]
        public string TypeSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  color .
        /// </summary>
        [JsonPropertyName(@"colorsrc")]
        public string ColorSrc { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is Gradient other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] Gradient other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (Type == other.Type && Type != null && other.Type != null && Type.Equals(other.Type))                                                  &&
                   (Equals(TypeArray, other.TypeArray) || TypeArray != null && other.TypeArray != null && TypeArray.SequenceEqual(other.TypeArray))       &&
                   (Color == other.Color && Color != null && other.Color != null && Color.Equals(other.Color))                                            &&
                   (Equals(ColorArray, other.ColorArray) || ColorArray != null && other.ColorArray != null && ColorArray.SequenceEqual(other.ColorArray)) &&
                   (TypeSrc  == other.TypeSrc  && TypeSrc  != null && other.TypeSrc  != null && TypeSrc.Equals(other.TypeSrc))                            &&
                   (ColorSrc == other.ColorSrc && ColorSrc != null && other.ColorSrc != null && ColorSrc.Equals(other.ColorSrc));
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;

                if(Type != null)
                    hashCode = hashCode * 59 + Type.GetHashCode();

                if(TypeArray != null)
                    hashCode = hashCode * 59 + TypeArray.GetHashCode();

                if(Color != null)
                    hashCode = hashCode * 59 + Color.GetHashCode();

                if(ColorArray != null)
                    hashCode = hashCode * 59 + ColorArray.GetHashCode();

                if(TypeSrc != null)
                    hashCode = hashCode * 59 + TypeSrc.GetHashCode();

                if(ColorSrc != null)
                    hashCode = hashCode * 59 + ColorSrc.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Gradient and the right Gradient.
        /// </summary>
        /// <param name="left">Left Gradient.</param>
        /// <param name="right">Right Gradient.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(Gradient left,
                                       Gradient right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Gradient and the right Gradient.
        /// </summary>
        /// <param name="left">Left Gradient.</param>
        /// <param name="right">Right Gradient.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(Gradient left,
                                       Gradient right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Gradient</returns>
        public Gradient DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<Gradient>(ms).Result;
        }
    }
}
