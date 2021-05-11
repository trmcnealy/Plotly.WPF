using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Animations.Transitions;

namespace Plotly.Models.Animations
{
    /// <summary>
    ///     The Transition class.
    /// </summary>
    [Serializable]
    public class Transition : IEquatable<Transition>
    {
        /// <summary>
        ///     The duration of the transition, in milliseconds. If equal to zero, updates
        ///     are synchronous.
        /// </summary>
        [JsonPropertyName(@"duration")]
        public JsNumber? Duration { get; set; }

        /// <summary>
        ///     The easing function used for the transition
        /// </summary>
        [JsonPropertyName(@"easing")]
        public EasingEnum? Easing { get; set; }

        /// <summary>
        ///     Determines whether the figure&#39;s layout or traces smoothly transitions
        ///     during updates that make both traces and layout change.
        /// </summary>
        [JsonPropertyName(@"ordering")]
        public OrderingEnum? Ordering { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is Transition other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] Transition other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (Duration == other.Duration && Duration != null && other.Duration != null && Duration.Equals(other.Duration)) &&
                   (Easing   == other.Easing   && Easing   != null && other.Easing   != null && Easing.Equals(other.Easing))     &&
                   (Ordering == other.Ordering && Ordering != null && other.Ordering != null && Ordering.Equals(other.Ordering));
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;

                if(Duration != null)
                    hashCode = hashCode * 59 + Duration.GetHashCode();

                if(Easing != null)
                    hashCode = hashCode * 59 + Easing.GetHashCode();

                if(Ordering != null)
                    hashCode = hashCode * 59 + Ordering.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Transition and the right Transition.
        /// </summary>
        /// <param name="left">Left Transition.</param>
        /// <param name="right">Right Transition.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(Transition left,
                                       Transition right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Transition and the right Transition.
        /// </summary>
        /// <param name="left">Left Transition.</param>
        /// <param name="right">Right Transition.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(Transition left,
                                       Transition right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Transition</returns>
        public Transition DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<Transition>(ms).Result;
        }
    }
}
