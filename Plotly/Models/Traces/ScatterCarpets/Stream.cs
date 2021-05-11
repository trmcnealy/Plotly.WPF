using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Plotly.Models.Traces.ScatterCarpets
{
    /// <summary>
    ///     The Stream class.
    /// </summary>
    [Serializable]
    public class Stream : IEquatable<Stream>
    {
        /// <summary>
        ///     The stream id number links a data trace on a plot with a stream. See https://chart-studio.plotly.com/settings
        ///     for more details.
        /// </summary>
        [JsonPropertyName(@"token")]
        public string Token { get; set; }

        /// <summary>
        ///     Sets the maximum number of points to keep on the plots from an incoming
        ///     stream. If <c>maxpoints</c> is set to <c>50</c>, only the newest 50 points
        ///     will be displayed on the plot.
        /// </summary>
        [JsonPropertyName(@"maxpoints")]
        public JsNumber? MaxPoints { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is Stream other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] Stream other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (Token     == other.Token     && Token     != null && other.Token     != null && Token.Equals(other.Token)) &&
                   (MaxPoints == other.MaxPoints && MaxPoints != null && other.MaxPoints != null && MaxPoints.Equals(other.MaxPoints));
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;

                if(Token != null)
                    hashCode = hashCode * 59 + Token.GetHashCode();

                if(MaxPoints != null)
                    hashCode = hashCode * 59 + MaxPoints.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Stream and the right Stream.
        /// </summary>
        /// <param name="left">Left Stream.</param>
        /// <param name="right">Right Stream.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(Stream left,
                                       Stream right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Stream and the right Stream.
        /// </summary>
        /// <param name="left">Left Stream.</param>
        /// <param name="right">Right Stream.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(Stream left,
                                       Stream right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Stream</returns>
        public Stream DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<Stream>(ms).Result;
        }
    }
}
