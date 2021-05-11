using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Plotly.Models.Layouts.Geos.Projections
{
    /// <summary>
    ///     The Rotation class.
    /// </summary>
    [Serializable]
    public class Rotation : IEquatable<Rotation>
    {
        /// <summary>
        ///     Rotates the map along parallels (in degrees East). Defaults to the center
        ///     of the <c>lonaxis.range</c> values.
        /// </summary>
        [JsonPropertyName(@"lon")]
        public JsNumber? Lon { get; set; }

        /// <summary>
        ///     Rotates the map along meridians (in degrees North).
        /// </summary>
        [JsonPropertyName(@"lat")]
        public JsNumber? Lat { get; set; }

        /// <summary>
        ///     Roll the map (in degrees) For example, a roll of <c>180</c> makes the map
        ///     appear upside down.
        /// </summary>
        [JsonPropertyName(@"roll")]
        public JsNumber? Roll { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is Rotation other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] Rotation other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (Lon  == other.Lon  && Lon  != null && other.Lon  != null && Lon.Equals(other.Lon)) &&
                   (Lat  == other.Lat  && Lat  != null && other.Lat  != null && Lat.Equals(other.Lat)) &&
                   (Roll == other.Roll && Roll != null && other.Roll != null && Roll.Equals(other.Roll));
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;

                if(Lon != null)
                    hashCode = hashCode * 59 + Lon.GetHashCode();

                if(Lat != null)
                    hashCode = hashCode * 59 + Lat.GetHashCode();

                if(Roll != null)
                    hashCode = hashCode * 59 + Roll.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Rotation and the right Rotation.
        /// </summary>
        /// <param name="left">Left Rotation.</param>
        /// <param name="right">Right Rotation.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(Rotation left,
                                       Rotation right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Rotation and the right Rotation.
        /// </summary>
        /// <param name="left">Left Rotation.</param>
        /// <param name="right">Right Rotation.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(Rotation left,
                                       Rotation right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Rotation</returns>
        public Rotation DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<Rotation>(ms).Result;
        }
    }
}
