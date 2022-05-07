using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Plotly.Models.Layouts.Ternarys
{
    /// <summary>
    ///     The Domain class.
    /// </summary>
    [Serializable]
    public class Domain : IEquatable<Domain>
    {
        /// <summary>
        ///     Sets the horizontal domain of this ternary subplot (in plot fraction).
        /// </summary>
        [JsonPropertyName(@"x")]
        public List<object>? X { get; set; }

        /// <summary>
        ///     Sets the vertical domain of this ternary subplot (in plot fraction).
        /// </summary>
        [JsonPropertyName(@"y")]
        public List<object>? Y { get; set; }

        /// <summary>
        ///     If there is a layout grid, use the domain for this row in the grid for this
        ///     ternary subplot .
        /// </summary>
        [JsonPropertyName(@"row")]
        public int? Row { get; set; }

        /// <summary>
        ///     If there is a layout grid, use the domain for this column in the grid for
        ///     this ternary subplot .
        /// </summary>
        [JsonPropertyName(@"column")]
        public int? Column { get; set; }

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

            return (Equals(X, other.X) || X != null && other.X != null && X.SequenceEqual(other.X))            &&
                   (Equals(Y, other.Y) || Y != null && other.Y != null && Y.SequenceEqual(other.Y))            &&
                   (Row    == other.Row    && Row    != null && other.Row    != null && Row.Equals(other.Row)) &&
                   (Column == other.Column && Column != null && other.Column != null && Column.Equals(other.Column));
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

                if(Row != null)
                    hashCode = hashCode * 59 + Row.GetHashCode();

                if(Column != null)
                    hashCode = hashCode * 59 + Column.GetHashCode();

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
