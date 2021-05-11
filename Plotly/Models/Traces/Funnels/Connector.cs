using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Traces.Funnels.Connectors;

namespace Plotly.Models.Traces.Funnels
{
    /// <summary>
    ///     The Connector class.
    /// </summary>
    [Serializable]
    public class Connector : IEquatable<Connector>
    {
        /// <summary>
        ///     Sets the fill color.
        /// </summary>
        [JsonPropertyName(@"fillcolor")]
        public object FillColor { get; set; }

        /// <summary>
        ///     Gets or sets the Line.
        /// </summary>
        [JsonPropertyName(@"line")]
        public Line Line { get; set; }

        /// <summary>
        ///     Determines if connector regions and lines are drawn.
        /// </summary>
        [JsonPropertyName(@"visible")]
        public bool? Visible { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is Connector other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] Connector other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (FillColor == other.FillColor && FillColor != null && other.FillColor != null && FillColor.Equals(other.FillColor)) &&
                   (Line      == other.Line      && Line      != null && other.Line      != null && Line.Equals(other.Line))           &&
                   (Visible   == other.Visible   && Visible   != null && other.Visible   != null && Visible.Equals(other.Visible));
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;

                if(FillColor != null)
                    hashCode = hashCode * 59 + FillColor.GetHashCode();

                if(Line != null)
                    hashCode = hashCode * 59 + Line.GetHashCode();

                if(Visible != null)
                    hashCode = hashCode * 59 + Visible.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Connector and the right Connector.
        /// </summary>
        /// <param name="left">Left Connector.</param>
        /// <param name="right">Right Connector.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(Connector left,
                                       Connector right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Connector and the right Connector.
        /// </summary>
        /// <param name="left">Left Connector.</param>
        /// <param name="right">Right Connector.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(Connector left,
                                       Connector right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Connector</returns>
        public Connector DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<Connector>(ms).Result;
        }
    }
}
