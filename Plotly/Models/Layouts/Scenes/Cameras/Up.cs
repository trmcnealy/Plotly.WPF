using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Plotly.Models.Layouts.Scenes.Cameras
{
    /// <summary>
    ///     The Up class.
    /// </summary>
    [Serializable]
    public class Up : IEquatable<Up>
    {
        /// <summary>
        ///     Gets or sets the X.
        /// </summary>
        [JsonPropertyName(@"x")]
        public JsNumber? X { get; set; }

        /// <summary>
        ///     Gets or sets the Y.
        /// </summary>
        [JsonPropertyName(@"y")]
        public JsNumber? Y { get; set; }

        /// <summary>
        ///     Gets or sets the Z.
        /// </summary>
        [JsonPropertyName(@"z")]
        public JsNumber? Z { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is Up other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] Up other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (X == other.X && X != null && other.X != null && X.Equals(other.X)) &&
                   (Y == other.Y && Y != null && other.Y != null && Y.Equals(other.Y)) &&
                   (Z == other.Z && Z != null && other.Z != null && Z.Equals(other.Z));
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;

                if(X != null)
                    hashCode = hashCode * 59 + X.GetHashCode();

                if(Y != null)
                    hashCode = hashCode * 59 + Y.GetHashCode();

                if(Z != null)
                    hashCode = hashCode * 59 + Z.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Up and the right Up.
        /// </summary>
        /// <param name="left">Left Up.</param>
        /// <param name="right">Right Up.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(Up left,
                                       Up right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Up and the right Up.
        /// </summary>
        /// <param name="left">Left Up.</param>
        /// <param name="right">Right Up.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(Up left,
                                       Up right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Up</returns>
        public Up DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<Up>(ms).Result;
        }
    }
}
