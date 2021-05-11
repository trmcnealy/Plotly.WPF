using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Plotly.Models.Layouts.Geos
{
    /// <summary>
    ///     The Center class.
    /// </summary>
    [Serializable]
    public class Center : IEquatable<Center>
    {
        /// <summary>
        ///     Sets the longitude of the map&#39;s center. By default, the map&#39;s longitude
        ///     center lies at the middle of the longitude range for scoped projection and
        ///     above <c>projection.rotation.lon</c> otherwise.
        /// </summary>
        [JsonPropertyName(@"lon")]
        public JsNumber? Lon { get; set; }

        /// <summary>
        ///     Sets the latitude of the map&#39;s center. For all projection types, the
        ///     map&#39;s latitude center lies at the middle of the latitude range by default.
        /// </summary>
        [JsonPropertyName(@"lat")]
        public JsNumber? Lat { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is Center other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] Center other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (Lon == other.Lon && Lon != null && other.Lon != null && Lon.Equals(other.Lon)) && (Lat == other.Lat && Lat != null && other.Lat != null && Lat.Equals(other.Lat));
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

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Center and the right Center.
        /// </summary>
        /// <param name="left">Left Center.</param>
        /// <param name="right">Right Center.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(Center left,
                                       Center right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Center and the right Center.
        /// </summary>
        /// <param name="left">Left Center.</param>
        /// <param name="right">Right Center.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(Center left,
                                       Center right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Center</returns>
        public Center DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<Center>(ms).Result;
        }
    }
}
