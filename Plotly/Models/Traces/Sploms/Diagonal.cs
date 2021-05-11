using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Plotly.Models.Traces.Sploms
{
    /// <summary>
    ///     The Diagonal class.
    /// </summary>
    [Serializable]
    public class Diagonal : IEquatable<Diagonal>
    {
        /// <summary>
        ///     Determines whether or not subplots on the diagonal are displayed.
        /// </summary>
        [JsonPropertyName(@"visible")]
        public bool? Visible { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is Diagonal other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] Diagonal other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (Visible == other.Visible && Visible != null && other.Visible != null && Visible.Equals(other.Visible));
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;

                if(Visible != null)
                    hashCode = hashCode * 59 + Visible.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Diagonal and the right Diagonal.
        /// </summary>
        /// <param name="left">Left Diagonal.</param>
        /// <param name="right">Right Diagonal.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(Diagonal left,
                                       Diagonal right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Diagonal and the right Diagonal.
        /// </summary>
        /// <param name="left">Left Diagonal.</param>
        /// <param name="right">Right Diagonal.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(Diagonal left,
                                       Diagonal right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Diagonal</returns>
        public Diagonal DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<Diagonal>(ms).Result;
        }
    }
}
