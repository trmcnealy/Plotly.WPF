using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Plotly.Models.Traces.StreamTubes
{
    /// <summary>
    ///     The Starts class.
    /// </summary>
    [Serializable]
    public class Starts : IEquatable<Starts>
    {
        /// <summary>
        ///     Sets the x components of the starting position of the streamtubes
        /// </summary>
        [JsonPropertyName(@"x")]
        public List<object> X { get; set; }

        /// <summary>
        ///     Sets the y components of the starting position of the streamtubes
        /// </summary>
        [JsonPropertyName(@"y")]
        public List<object> Y { get; set; }

        /// <summary>
        ///     Sets the z components of the starting position of the streamtubes
        /// </summary>
        [JsonPropertyName(@"z")]
        public List<object> Z { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  x .
        /// </summary>
        [JsonPropertyName(@"xsrc")]
        public string XSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  y .
        /// </summary>
        [JsonPropertyName(@"ysrc")]
        public string YSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  z .
        /// </summary>
        [JsonPropertyName(@"zsrc")]
        public string ZSrc { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is Starts other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] Starts other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (Equals(X, other.X) || X != null && other.X != null && X.SequenceEqual(other.X))      &&
                   (Equals(Y, other.Y) || Y != null && other.Y != null && Y.SequenceEqual(other.Y))      &&
                   (Equals(Z, other.Z) || Z != null && other.Z != null && Z.SequenceEqual(other.Z))      &&
                   (XSrc == other.XSrc && XSrc != null && other.XSrc != null && XSrc.Equals(other.XSrc)) &&
                   (YSrc == other.YSrc && YSrc != null && other.YSrc != null && YSrc.Equals(other.YSrc)) &&
                   (ZSrc == other.ZSrc && ZSrc != null && other.ZSrc != null && ZSrc.Equals(other.ZSrc));
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

                if(XSrc != null)
                    hashCode = hashCode * 59 + XSrc.GetHashCode();

                if(YSrc != null)
                    hashCode = hashCode * 59 + YSrc.GetHashCode();

                if(ZSrc != null)
                    hashCode = hashCode * 59 + ZSrc.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Starts and the right Starts.
        /// </summary>
        /// <param name="left">Left Starts.</param>
        /// <param name="right">Right Starts.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(Starts left,
                                       Starts right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Starts and the right Starts.
        /// </summary>
        /// <param name="left">Left Starts.</param>
        /// <param name="right">Right Starts.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(Starts left,
                                       Starts right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Starts</returns>
        public Starts DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<Starts>(ms).Result;
        }
    }
}
