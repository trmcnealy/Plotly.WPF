using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Layouts.Scenes.Cameras.Projections;

namespace Plotly.Models.Layouts.Scenes.Cameras
{
    /// <summary>
    ///     The Projection class.
    /// </summary>
    [Serializable]
    public class Projection : IEquatable<Projection>
    {
        /// <summary>
        ///     Sets the projection type. The projection type could be either <c>perspective</c>
        ///     or <c>orthographic</c>. The default is <c>perspective</c>.
        /// </summary>
        [JsonPropertyName(@"type")]
        public TypeEnum? Type { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is Projection other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] Projection other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (Type == other.Type && Type != null && other.Type != null && Type.Equals(other.Type));
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;

                if(Type != null)
                    hashCode = hashCode * 59 + Type.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Projection and the right Projection.
        /// </summary>
        /// <param name="left">Left Projection.</param>
        /// <param name="right">Right Projection.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(Projection left,
                                       Projection right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Projection and the right Projection.
        /// </summary>
        /// <param name="left">Left Projection.</param>
        /// <param name="right">Right Projection.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(Projection left,
                                       Projection right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Projection</returns>
        public Projection DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<Projection>(ms).Result;
        }
    }
}
