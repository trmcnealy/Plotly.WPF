using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Traces.Histograms.Cumulatives;

namespace Plotly.Models.Traces.Histograms
{
    /// <summary>
    ///     The Cumulative class.
    /// </summary>
    
    [Serializable]
    public class Cumulative : IEquatable<Cumulative>
    {
        /// <summary>
        ///     If true, display the cumulative distribution by summing the binned values.
        ///     Use the <c>direction</c> and <c>centralbin</c> attributes to tune the accumulation
        ///     method. Note: in this mode, the <c>density</c> <c>histnorm</c> settings
        ///     behave the same as their equivalents without <c>density</c>: *&#39; and
        ///     <c>density</c> both rise to the number of data points, and <c>probability</c>
        ///     and &#39;probability density* both rise to the number of sample points.
        /// </summary>
        [JsonPropertyName(@"enabled")]
        public bool? Enabled { get; set;} 

        /// <summary>
        ///     Only applies if cumulative is enabled. If <c>increasing</c> (default) we
        ///     sum all prior bins, so the result increases from left to right. If <c>decreasing</c>
        ///     we sum later bins so the result decreases from left to right.
        /// </summary>
        [JsonPropertyName(@"direction")]
        public DirectionEnum? Direction { get; set;} 

        /// <summary>
        ///     Only applies if cumulative is enabled. Sets whether the current bin is included,
        ///     excluded, or has half of its value included in the current cumulative value.
        ///     <c>include</c> is the default for compatibility with various other tools,
        ///     however it introduces a half-bin bias to the results. <c>exclude</c> makes
        ///     the opposite half-bin bias, and <c>half</c> removes it.
        /// </summary>
        [JsonPropertyName(@"currentbin")]
        public CurrentBinEnum? CurrentBin { get; set;} 

        
        public override bool Equals(object obj)
        {
            if (!(obj is Cumulative other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        
        public bool Equals([AllowNull] Cumulative other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Enabled == other.Enabled &&
                    Enabled != null && other.Enabled != null &&
                    Enabled.Equals(other.Enabled)
                ) && 
                (
                    Direction == other.Direction &&
                    Direction != null && other.Direction != null &&
                    Direction.Equals(other.Direction)
                ) && 
                (
                    CurrentBin == other.CurrentBin &&
                    CurrentBin != null && other.CurrentBin != null &&
                    CurrentBin.Equals(other.CurrentBin)
                );
        }

        
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (Enabled != null) hashCode = hashCode * 59 + Enabled.GetHashCode();
                if (Direction != null) hashCode = hashCode * 59 + Direction.GetHashCode();
                if (CurrentBin != null) hashCode = hashCode * 59 + CurrentBin.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Cumulative and the right Cumulative.
        /// </summary>
        /// <param name="left">Left Cumulative.</param>
        /// <param name="right">Right Cumulative.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (Cumulative left, Cumulative right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Cumulative and the right Cumulative.
        /// </summary>
        /// <param name="left">Left Cumulative.</param>
        /// <param name="right">Right Cumulative.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (Cumulative left, Cumulative right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Cumulative</returns>
        public Cumulative DeepClone()
        {
            using MemoryStream ms = new();
            
            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;
            return JsonSerializer.DeserializeAsync<Cumulative>(ms).Result;
        }
    }
}