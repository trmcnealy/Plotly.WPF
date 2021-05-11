using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Plotly.Models.Traces.IsoSurfaces
{
    /// <summary>
    ///     The SpaceFrame class.
    /// </summary>
    [Serializable]
    public class SpaceFrame : IEquatable<SpaceFrame>
    {
        /// <summary>
        ///     Displays/hides tetrahedron shapes between minimum and maximum iso-values.
        ///     Often useful when either caps or surfaces are disabled or filled with values
        ///     less than 1.
        /// </summary>
        [JsonPropertyName(@"show")]
        public bool? Show { get; set; }

        /// <summary>
        ///     Sets the fill ratio of the <c>spaceframe</c> elements. The default fill
        ///     value is 0.15 meaning that only 15% of the area of every faces of tetras
        ///     would be shaded. Applying a greater <c>fill</c> ratio would allow the creation
        ///     of stronger elements or could be sued to have entirely closed areas (in
        ///     case of using 1).
        /// </summary>
        [JsonPropertyName(@"fill")]
        public JsNumber? Fill { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is SpaceFrame other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] SpaceFrame other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (Show == other.Show && Show != null && other.Show != null && Show.Equals(other.Show)) && (Fill == other.Fill && Fill != null && other.Fill != null && Fill.Equals(other.Fill));
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;

                if(Show != null)
                    hashCode = hashCode * 59 + Show.GetHashCode();

                if(Fill != null)
                    hashCode = hashCode * 59 + Fill.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left SpaceFrame and the right SpaceFrame.
        /// </summary>
        /// <param name="left">Left SpaceFrame.</param>
        /// <param name="right">Right SpaceFrame.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(SpaceFrame left,
                                       SpaceFrame right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left SpaceFrame and the right SpaceFrame.
        /// </summary>
        /// <param name="left">Left SpaceFrame.</param>
        /// <param name="right">Right SpaceFrame.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(SpaceFrame left,
                                       SpaceFrame right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>SpaceFrame</returns>
        public SpaceFrame DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<SpaceFrame>(ms).Result;
        }
    }
}
