using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Traces.Indicators.Deltas;

namespace Plotly.Models.Traces.Indicators
{
    /// <summary>
    ///     The Delta class.
    /// </summary>
    [Serializable]
    public class Delta : IEquatable<Delta>
    {
        /// <summary>
        ///     Sets the reference value to compute the delta. By default, it is set to
        ///     the current value.
        /// </summary>
        [JsonPropertyName(@"reference")]
        public JsNumber? Reference { get; set; }

        /// <summary>
        ///     Sets the position of delta with respect to the number.
        /// </summary>
        [JsonPropertyName(@"position")]
        public PositionEnum? Position { get; set; }

        /// <summary>
        ///     Show relative change
        /// </summary>
        [JsonPropertyName(@"relative")]
        public bool? Relative { get; set; }

        /// <summary>
        ///     Sets the value formatting rule using d3 formatting mini-language which is
        ///     similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        /// </summary>
        [JsonPropertyName(@"valueformat")]
        public string? ValueFormat { get; set; }

        /// <summary>
        ///     Gets or sets the Increasing.
        /// </summary>
        [JsonPropertyName(@"increasing")]
        public Increasing? Increasing { get; set; }

        /// <summary>
        ///     Gets or sets the Decreasing.
        /// </summary>
        [JsonPropertyName(@"decreasing")]
        public Decreasing? Decreasing { get; set; }

        /// <summary>
        ///     Set the font used to display the delta
        /// </summary>
        [JsonPropertyName(@"font")]
        public Font? Font { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is Delta other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] Delta other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (Reference   == other.Reference   && Reference   != null && other.Reference   != null && Reference.Equals(other.Reference))     &&
                   (Position    == other.Position    && Position    != null && other.Position    != null && Position.Equals(other.Position))       &&
                   (Relative    == other.Relative    && Relative    != null && other.Relative    != null && Relative.Equals(other.Relative))       &&
                   (ValueFormat == other.ValueFormat && ValueFormat != null && other.ValueFormat != null && ValueFormat.Equals(other.ValueFormat)) &&
                   (Increasing  == other.Increasing  && Increasing  != null && other.Increasing  != null && Increasing.Equals(other.Increasing))   &&
                   (Decreasing  == other.Decreasing  && Decreasing  != null && other.Decreasing  != null && Decreasing.Equals(other.Decreasing))   &&
                   (Font        == other.Font        && Font        != null && other.Font        != null && Font.Equals(other.Font));
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;

                if(Reference != null)
                    hashCode = hashCode * 59 + Reference.GetHashCode();

                if(Position != null)
                    hashCode = hashCode * 59 + Position.GetHashCode();

                if(Relative != null)
                    hashCode = hashCode * 59 + Relative.GetHashCode();

                if(ValueFormat != null)
                    hashCode = hashCode * 59 + ValueFormat.GetHashCode();

                if(Increasing != null)
                    hashCode = hashCode * 59 + Increasing.GetHashCode();

                if(Decreasing != null)
                    hashCode = hashCode * 59 + Decreasing.GetHashCode();

                if(Font != null)
                    hashCode = hashCode * 59 + Font.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Delta and the right Delta.
        /// </summary>
        /// <param name="left">Left Delta.</param>
        /// <param name="right">Right Delta.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(Delta left,
                                       Delta right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Delta and the right Delta.
        /// </summary>
        /// <param name="left">Left Delta.</param>
        /// <param name="right">Right Delta.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(Delta left,
                                       Delta right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Delta</returns>
        public Delta DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<Delta>(ms).Result;
        }
    }
}
