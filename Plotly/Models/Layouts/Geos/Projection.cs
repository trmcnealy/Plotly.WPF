using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Layouts.Geos.Projections;

namespace Plotly.Models.Layouts.Geos
{
    /// <summary>
    ///     The Projection class.
    /// </summary>
    [Serializable]
    public class Projection : IEquatable<Projection>
    {
        /// <summary>
        ///     Sets the projection type.
        /// </summary>
        [JsonPropertyName(@"type")]
        public TypeEnum? Type { get; set; }

        /// <summary>
        ///     Gets or sets the Rotation.
        /// </summary>
        [JsonPropertyName(@"rotation")]
        public Rotation? Rotation { get; set; }

        /// <summary>
        ///     For conic projection types only. Sets the parallels (tangent, secant) where
        ///     the cone intersects the sphere.
        /// </summary>
        [JsonPropertyName(@"parallels")]
        public List<object>? Parallels { get; set; }

        /// <summary>
        ///     Zooms in or out on the map view. A scale of <c>1</c> corresponds to the
        ///     largest zoom level that fits the map&#39;s lon and lat ranges. 
        /// </summary>
        [JsonPropertyName(@"scale")]
        public JsNumber? Scale { get; set; }

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

            return (Type     == other.Type     && Type     != null && other.Type     != null && Type.Equals(other.Type))                            &&
                   (Rotation == other.Rotation && Rotation != null && other.Rotation != null && Rotation.Equals(other.Rotation))                    &&
                   (Equals(Parallels, other.Parallels) || Parallels != null && other.Parallels != null && Parallels.SequenceEqual(other.Parallels)) &&
                   (Scale == other.Scale && Scale != null && other.Scale != null && Scale.Equals(other.Scale));
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;

                if(Type != null)
                    hashCode = hashCode * 59 + Type.GetHashCode();

                if(Rotation != null)
                    hashCode = hashCode * 59 + Rotation.GetHashCode();

                if(Parallels != null)
                    hashCode = hashCode * 59 + Parallels.GetHashCode();

                if(Scale != null)
                    hashCode = hashCode * 59 + Scale.GetHashCode();

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
