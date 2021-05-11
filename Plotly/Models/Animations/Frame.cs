using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Plotly.Models.Animations
{
    /// <summary>
    ///     The Frame class.
    /// </summary>
    [Serializable]
    public class Frame : IEquatable<Frame>
    {
        /// <summary>
        ///     The duration in milliseconds of each frame. If greater than the frame duration,
        ///     it will be limited to the frame duration.
        /// </summary>
        [JsonPropertyName(@"duration")]
        public JsNumber? Duration { get; set; }

        /// <summary>
        ///     Redraw the plot at completion of the transition. This is desirable for transitions
        ///     that include properties that cannot be transitioned, but may significantly
        ///     slow down updates that do not require a full redraw of the plot
        /// </summary>
        [JsonPropertyName(@"redraw")]
        public bool? Redraw { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is Frame other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] Frame other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (Duration == other.Duration && Duration != null && other.Duration != null && Duration.Equals(other.Duration)) &&
                   (Redraw   == other.Redraw   && Redraw   != null && other.Redraw   != null && Redraw.Equals(other.Redraw));
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;

                if(Duration != null)
                    hashCode = hashCode * 59 + Duration.GetHashCode();

                if(Redraw != null)
                    hashCode = hashCode * 59 + Redraw.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Frame and the right Frame.
        /// </summary>
        /// <param name="left">Left Frame.</param>
        /// <param name="right">Right Frame.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(Frame left,
                                       Frame right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Frame and the right Frame.
        /// </summary>
        /// <param name="left">Left Frame.</param>
        /// <param name="right">Right Frame.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(Frame left,
                                       Frame right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Frame</returns>
        public Frame DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<Frame>(ms).Result;
        }
    }
}
