using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Transforms.Aggregates.Aggregations;

namespace Plotly.Models.Transforms.Aggregates
{
    /// <summary>
    ///     The Aggregation class.
    /// </summary>
    [Serializable]
    public class Aggregation : IEquatable<Aggregation>
    {
        /// <summary>
        ///     A reference to the data array in the parent trace to aggregate. To aggregate
        ///     by nested variables, use <c>.</c> to access them. For example, set <c>groups</c>
        ///     to <c>marker.color</c> to aggregate over the marker color array. The referenced
        ///     array must already exist, unless <c>func</c> is <c>count</c>, and each array
        ///     may only be referenced once.
        /// </summary>
        [JsonPropertyName(@"target")]
        public string Target { get; set; }

        /// <summary>
        ///     Sets the aggregation function. All values from the linked <c>target</c>,
        ///     corresponding to the same value in the <c>groups</c> array, are collected
        ///     and reduced by this function. <c>count</c> is simply the number of values
        ///     in the <c>groups</c> array, so does not even require the linked array to
        ///     exist. <c>first</c> (<c>last</c>) is just the first (last) linked value.
        ///     Invalid values are ignored, so for example in <c>avg</c> they do not contribute
        ///     to either the numerator or the denominator. Any data type (numeric, date,
        ///     category) may be aggregated with any function, even though in certain cases
        ///     it is unlikely to make sense, for example a sum of dates or average of categories.
        ///     <c>median</c> will return the average of the two central values if there
        ///     is an even count. <c>mode</c> will return the first value to reach the maximum
        ///     count, in case of a tie. <c>change</c> will return the difference between
        ///     the first and last linked values. <c>range</c> will return the difference
        ///     between the min and max linked values.
        /// </summary>
        [JsonPropertyName(@"func")]
        public FuncEnum? Func { get; set; }

        /// <summary>
        ///     <c>stddev</c> supports two formula variants: <c>sample</c> (normalize by
        ///     N-1) and <c>population</c> (normalize by N).
        /// </summary>
        [JsonPropertyName(@"funcmode")]
        public FuncModeEnum? FuncMode { get; set; }

        /// <summary>
        ///     Determines whether this aggregation function is enabled or disabled.
        /// </summary>
        [JsonPropertyName(@"enabled")]
        public bool? Enabled { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is Aggregation other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] Aggregation other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (Target   == other.Target   && Target   != null && other.Target   != null && Target.Equals(other.Target))     &&
                   (Func     == other.Func     && Func     != null && other.Func     != null && Func.Equals(other.Func))         &&
                   (FuncMode == other.FuncMode && FuncMode != null && other.FuncMode != null && FuncMode.Equals(other.FuncMode)) &&
                   (Enabled  == other.Enabled  && Enabled  != null && other.Enabled  != null && Enabled.Equals(other.Enabled));
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;

                if(Target != null)
                    hashCode = hashCode * 59 + Target.GetHashCode();

                if(Func != null)
                    hashCode = hashCode * 59 + Func.GetHashCode();

                if(FuncMode != null)
                    hashCode = hashCode * 59 + FuncMode.GetHashCode();

                if(Enabled != null)
                    hashCode = hashCode * 59 + Enabled.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Aggregation and the right Aggregation.
        /// </summary>
        /// <param name="left">Left Aggregation.</param>
        /// <param name="right">Right Aggregation.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(Aggregation left,
                                       Aggregation right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Aggregation and the right Aggregation.
        /// </summary>
        /// <param name="left">Left Aggregation.</param>
        /// <param name="right">Right Aggregation.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(Aggregation left,
                                       Aggregation right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Aggregation</returns>
        public Aggregation DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<Aggregation>(ms).Result;
        }
    }
}
