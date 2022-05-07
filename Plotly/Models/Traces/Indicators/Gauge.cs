using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Traces.Indicators.Gauges;

namespace Plotly.Models.Traces.Indicators
{
    /// <summary>
    ///     The Gauge class.
    /// </summary>
    [Serializable]
    public class Gauge : IEquatable<Gauge>
    {
        /// <summary>
        ///     Set the shape of the gauge
        /// </summary>
        [JsonPropertyName(@"shape")]
        public ShapeEnum? Shape { get; set; }

        /// <summary>
        ///     Set the appearance of the gauge&#39;s value
        /// </summary>
        [JsonPropertyName(@"bar")]
        public Gauges.Bar? Bar { get; set; }

        /// <summary>
        ///     Sets the gauge background color.
        /// </summary>
        [JsonPropertyName(@"bgcolor")]
        public object? BgColor { get; set; }

        /// <summary>
        ///     Sets the color of the border enclosing the gauge.
        /// </summary>
        [JsonPropertyName(@"bordercolor")]
        public object? BorderColor { get; set; }

        /// <summary>
        ///     Sets the width (in px) of the border enclosing the gauge.
        /// </summary>
        [JsonPropertyName(@"borderwidth")]
        public JsNumber? BorderWidth { get; set; }

        /// <summary>
        ///     Gets or sets the Axis.
        /// </summary>
        [JsonPropertyName(@"axis")]
        public Axis? Axis { get; set; }

        /// <summary>
        ///     Gets or sets the Steps.
        /// </summary>
        [JsonPropertyName(@"steps")]
        public List<Step>? Steps { get; set; }

        /// <summary>
        ///     Gets or sets the Threshold.
        /// </summary>
        [JsonPropertyName(@"threshold")]
        public Threshold? Threshold { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is Gauge other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] Gauge other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (Shape       == other.Shape       && Shape       != null && other.Shape       != null && Shape.Equals(other.Shape))             &&
                   (Bar         == other.Bar         && Bar         != null && other.Bar         != null && Bar.Equals(other.Bar))                 &&
                   (BgColor     == other.BgColor     && BgColor     != null && other.BgColor     != null && BgColor.Equals(other.BgColor))         &&
                   (BorderColor == other.BorderColor && BorderColor != null && other.BorderColor != null && BorderColor.Equals(other.BorderColor)) &&
                   (BorderWidth == other.BorderWidth && BorderWidth != null && other.BorderWidth != null && BorderWidth.Equals(other.BorderWidth)) &&
                   (Axis        == other.Axis        && Axis        != null && other.Axis        != null && Axis.Equals(other.Axis))               &&
                   (Equals(Steps, other.Steps) || Steps != null && other.Steps != null && Steps.SequenceEqual(other.Steps))                        &&
                   (Threshold == other.Threshold && Threshold != null && other.Threshold != null && Threshold.Equals(other.Threshold));
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;

                if(Shape != null)
                    hashCode = hashCode * 59 + Shape.GetHashCode();

                if(Bar != null)
                    hashCode = hashCode * 59 + Bar.GetHashCode();

                if(BgColor != null)
                    hashCode = hashCode * 59 + BgColor.GetHashCode();

                if(BorderColor != null)
                    hashCode = hashCode * 59 + BorderColor.GetHashCode();

                if(BorderWidth != null)
                    hashCode = hashCode * 59 + BorderWidth.GetHashCode();

                if(Axis != null)
                    hashCode = hashCode * 59 + Axis.GetHashCode();

                if(Steps != null)
                    hashCode = hashCode * 59 + Steps.GetHashCode();

                if(Threshold != null)
                    hashCode = hashCode * 59 + Threshold.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Gauge and the right Gauge.
        /// </summary>
        /// <param name="left">Left Gauge.</param>
        /// <param name="right">Right Gauge.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(Gauge left,
                                       Gauge right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Gauge and the right Gauge.
        /// </summary>
        /// <param name="left">Left Gauge.</param>
        /// <param name="right">Right Gauge.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(Gauge left,
                                       Gauge right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Gauge</returns>
        public Gauge DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<Gauge>(ms).Result;
        }
    }
}
