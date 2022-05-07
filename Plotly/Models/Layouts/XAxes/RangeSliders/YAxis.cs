using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Plotly.Models.Layouts.XAxes.RangeSliders
{
    /// <summary>
    ///     The YAxis class.
    /// </summary>
    [Serializable]
    public class YAxis : IEquatable<YAxis>
    {
        /// <summary>
        ///     Determines whether or not the range of this axis in the rangeslider use
        ///     the same value than in the main plot when zooming in/out. If <c>auto</c>,
        ///     the autorange will be used. If <c>fixed</c>, the <c>range</c> is used. If
        ///     <c>match</c>, the current range of the corresponding y-axis on the main
        ///     subplot is used.
        /// </summary>
        [JsonPropertyName(@"rangemode")]
        public YAxes.RangeModeEnum? RangeMode { get; set; }

        /// <summary>
        ///     Sets the range of this axis for the rangeslider.
        /// </summary>
        [JsonPropertyName(@"range")]
        public List<object>? Range { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is YAxis other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] YAxis other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (RangeMode == other.RangeMode && RangeMode != null && other.RangeMode != null && RangeMode.Equals(other.RangeMode)) &&
                   (Equals(Range, other.Range) || Range != null && other.Range != null && Range.SequenceEqual(other.Range));
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;

                if(RangeMode != null)
                    hashCode = hashCode * 59 + RangeMode.GetHashCode();

                if(Range != null)
                    hashCode = hashCode * 59 + Range.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left YAxis and the right YAxis.
        /// </summary>
        /// <param name="left">Left YAxis.</param>
        /// <param name="right">Right YAxis.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(YAxis left,
                                       YAxis right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left YAxis and the right YAxis.
        /// </summary>
        /// <param name="left">Left YAxis.</param>
        /// <param name="right">Right YAxis.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(YAxis left,
                                       YAxis right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>YAxis</returns>
        public YAxis DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<YAxis>(ms).Result;
        }
    }
}
