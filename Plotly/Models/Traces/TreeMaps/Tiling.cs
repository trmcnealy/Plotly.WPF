using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Traces.TreeMaps.Tilings;

namespace Plotly.Models.Traces.TreeMaps
{
    /// <summary>
    ///     The Tiling class.
    /// </summary>
    [Serializable]
    public class Tiling : IEquatable<Tiling>
    {
        /// <summary>
        ///     Determines d3 treemap solver. For more info please refer to https://github.com/d3/d3-hierarchy#treemap-tiling
        /// </summary>
        [JsonPropertyName(@"packing")]
        public PackingEnum? Packing { get; set; }

        /// <summary>
        ///     When using <c>squarify</c> <c>packing</c> algorithm, according to https://github.com/d3/d3-hierarchy/blob/master/README.md#squarify_ratio
        ///     this option specifies the desired aspect ratio of the generated rectangles.
        ///     The ratio must be specified as a number greater than or equal to one. Note
        ///     that the orientation of the generated rectangles (tall or wide) is not implied
        ///     by the ratio; for example, a ratio of two will attempt to produce a mixture
        ///     of rectangles whose width:height ratio is either 2:1 or 1:2. When using
        ///     <c>squarify</c>, unlike d3 which uses the Golden Ratio i.e. 1.618034, Plotly
        ///     applies 1 to increase squares in treemap layouts.
        /// </summary>
        [JsonPropertyName(@"squarifyratio")]
        public JsNumber? SquarifyRatio { get; set; }

        /// <summary>
        ///     Determines if the positions obtained from solver are flipped on each axis.
        /// </summary>
        [JsonPropertyName(@"flip")]
        public FlipFlag? Flip { get; set; }

        /// <summary>
        ///     Sets the inner padding (in px).
        /// </summary>
        [JsonPropertyName(@"pad")]
        public JsNumber? Pad { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is Tiling other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] Tiling other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (Packing       == other.Packing       && Packing       != null && other.Packing       != null && Packing.Equals(other.Packing))             &&
                   (SquarifyRatio == other.SquarifyRatio && SquarifyRatio != null && other.SquarifyRatio != null && SquarifyRatio.Equals(other.SquarifyRatio)) &&
                   (Flip          == other.Flip          && Flip          != null && other.Flip          != null && Flip.Equals(other.Flip))                   &&
                   (Pad           == other.Pad           && Pad           != null && other.Pad           != null && Pad.Equals(other.Pad));
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;

                if(Packing != null)
                    hashCode = hashCode * 59 + Packing.GetHashCode();

                if(SquarifyRatio != null)
                    hashCode = hashCode * 59 + SquarifyRatio.GetHashCode();

                if(Flip != null)
                    hashCode = hashCode * 59 + Flip.GetHashCode();

                if(Pad != null)
                    hashCode = hashCode * 59 + Pad.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Tiling and the right Tiling.
        /// </summary>
        /// <param name="left">Left Tiling.</param>
        /// <param name="right">Right Tiling.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(Tiling left,
                                       Tiling right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Tiling and the right Tiling.
        /// </summary>
        /// <param name="left">Left Tiling.</param>
        /// <param name="right">Right Tiling.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(Tiling left,
                                       Tiling right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Tiling</returns>
        public Tiling DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<Tiling>(ms).Result;
        }
    }
}
