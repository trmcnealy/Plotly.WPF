using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Plotly.Models.Traces.Mesh3Ds
{
    /// <summary>
    ///     The Lighting class.
    /// </summary>
    [Serializable]
    public class Lighting : IEquatable<Lighting>
    {
        /// <summary>
        ///     Epsilon for vertex normals calculation avoids math issues arising from degenerate
        ///     geometry.
        /// </summary>
        [JsonPropertyName(@"vertexnormalsepsilon")]
        public JsNumber? VertexNormalsEpsilon { get; set; }

        /// <summary>
        ///     Epsilon for face normals calculation avoids math issues arising from degenerate
        ///     geometry.
        /// </summary>
        [JsonPropertyName(@"facenormalsepsilon")]
        public JsNumber? FaceNormalsEpsilon { get; set; }

        /// <summary>
        ///     Ambient light increases overall color visibility but can wash out the image.
        /// </summary>
        [JsonPropertyName(@"ambient")]
        public JsNumber? Ambient { get; set; }

        /// <summary>
        ///     Represents the extent that incident rays are reflected in a range of angles.
        /// </summary>
        [JsonPropertyName(@"diffuse")]
        public JsNumber? Diffuse { get; set; }

        /// <summary>
        ///     Represents the level that incident rays are reflected in a single direction,
        ///     causing shine.
        /// </summary>
        [JsonPropertyName(@"specular")]
        public JsNumber? Specular { get; set; }

        /// <summary>
        ///     Alters specular reflection; the rougher the surface, the wider and less
        ///     contrasty the shine.
        /// </summary>
        [JsonPropertyName(@"roughness")]
        public JsNumber? Roughness { get; set; }

        /// <summary>
        ///     Represents the reflectance as a dependency of the viewing angle; e.g. paper
        ///     is reflective when viewing it from the edge of the paper (almost 90 degrees),
        ///     causing shine.
        /// </summary>
        [JsonPropertyName(@"fresnel")]
        public JsNumber? Fresnel { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is Lighting other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] Lighting other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return
                (VertexNormalsEpsilon == other.VertexNormalsEpsilon && VertexNormalsEpsilon != null && other.VertexNormalsEpsilon != null && VertexNormalsEpsilon.Equals(other.VertexNormalsEpsilon)) &&
                (FaceNormalsEpsilon   == other.FaceNormalsEpsilon   && FaceNormalsEpsilon   != null && other.FaceNormalsEpsilon   != null && FaceNormalsEpsilon.Equals(other.FaceNormalsEpsilon))     &&
                (Ambient              == other.Ambient              && Ambient              != null && other.Ambient              != null && Ambient.Equals(other.Ambient))                           &&
                (Diffuse              == other.Diffuse              && Diffuse              != null && other.Diffuse              != null && Diffuse.Equals(other.Diffuse))                           &&
                (Specular             == other.Specular             && Specular             != null && other.Specular             != null && Specular.Equals(other.Specular))                         &&
                (Roughness            == other.Roughness            && Roughness            != null && other.Roughness            != null && Roughness.Equals(other.Roughness))                       &&
                (Fresnel              == other.Fresnel              && Fresnel              != null && other.Fresnel              != null && Fresnel.Equals(other.Fresnel));
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;

                if(VertexNormalsEpsilon != null)
                    hashCode = hashCode * 59 + VertexNormalsEpsilon.GetHashCode();

                if(FaceNormalsEpsilon != null)
                    hashCode = hashCode * 59 + FaceNormalsEpsilon.GetHashCode();

                if(Ambient != null)
                    hashCode = hashCode * 59 + Ambient.GetHashCode();

                if(Diffuse != null)
                    hashCode = hashCode * 59 + Diffuse.GetHashCode();

                if(Specular != null)
                    hashCode = hashCode * 59 + Specular.GetHashCode();

                if(Roughness != null)
                    hashCode = hashCode * 59 + Roughness.GetHashCode();

                if(Fresnel != null)
                    hashCode = hashCode * 59 + Fresnel.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Lighting and the right Lighting.
        /// </summary>
        /// <param name="left">Left Lighting.</param>
        /// <param name="right">Right Lighting.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(Lighting left,
                                       Lighting right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Lighting and the right Lighting.
        /// </summary>
        /// <param name="left">Left Lighting.</param>
        /// <param name="right">Right Lighting.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(Lighting left,
                                       Lighting right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Lighting</returns>
        public Lighting DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<Lighting>(ms).Result;
        }
    }
}
