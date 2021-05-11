using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Plotly.Models.Layouts.Grids
{
    /// <summary>
    ///     The Domain class.
    /// </summary>
    [Serializable]
    public class Domain : IEquatable<Domain>
    {
        /// <summary>
        ///     Sets the horizontal domain of this grid subplot (in plot fraction). The
        ///     first and last cells end exactly at the domain edges, with no grout around
        ///     the edges.
        /// </summary>
        [JsonPropertyName(@"x")]
        public List<object> X { get; set; }

        /// <summary>
        ///     Sets the vertical domain of this grid subplot (in plot fraction). The first
        ///     and last cells end exactly at the domain edges, with no grout around the
        ///     edges.
        /// </summary>
        [JsonPropertyName(@"y")]
        public List<object> Y { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is Domain other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] Domain other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (Equals(X, other.X) || X != null && other.X != null && X.SequenceEqual(other.X)) && (Equals(Y, other.Y) || Y != null && other.Y != null && Y.SequenceEqual(other.Y));
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

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Domain and the right Domain.
        /// </summary>
        /// <param name="left">Left Domain.</param>
        /// <param name="right">Right Domain.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(Domain left,
                                       Domain right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Domain and the right Domain.
        /// </summary>
        /// <param name="left">Left Domain.</param>
        /// <param name="right">Right Domain.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(Domain left,
                                       Domain right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Domain</returns>
        public Domain DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<Domain>(ms).Result;
        }
    }
}
