using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Plotly.Models.Layouts.Sliders
{
    /// <summary>
    ///     The CurrentValue class.
    /// </summary>
    [Serializable]
    public class CurrentValue : IEquatable<CurrentValue>
    {
        /// <summary>
        ///     Shows the currently-selected value above the slider.
        /// </summary>
        [JsonPropertyName(@"visible")]
        public bool? Visible { get; set; }

        /// <summary>
        ///     The alignment of the value readout relative to the length of the slider.
        /// </summary>
        [JsonPropertyName(@"xanchor")]
        public CurrentValues.XAnchorEnum? XAnchor { get; set; }

        /// <summary>
        ///     The amount of space, in pixels, between the current value label and the
        ///     slider.
        /// </summary>
        [JsonPropertyName(@"offset")]
        public JsNumber? Offset { get; set; }

        /// <summary>
        ///     When currentvalue.visible is true, this sets the prefix of the label.
        /// </summary>
        [JsonPropertyName(@"prefix")]
        public string Prefix { get; set; }

        /// <summary>
        ///     When currentvalue.visible is true, this sets the suffix of the label.
        /// </summary>
        [JsonPropertyName(@"suffix")]
        public string Suffix { get; set; }

        /// <summary>
        ///     Sets the font of the current value label text.
        /// </summary>
        [JsonPropertyName(@"font")]
        public CurrentValues.Font Font { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is CurrentValue other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] CurrentValue other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (Visible == other.Visible && Visible != null && other.Visible != null && Visible.Equals(other.Visible)) &&
                   (XAnchor == other.XAnchor && XAnchor != null && other.XAnchor != null && XAnchor.Equals(other.XAnchor)) &&
                   (Offset  == other.Offset  && Offset  != null && other.Offset  != null && Offset.Equals(other.Offset))   &&
                   (Prefix  == other.Prefix  && Prefix  != null && other.Prefix  != null && Prefix.Equals(other.Prefix))   &&
                   (Suffix  == other.Suffix  && Suffix  != null && other.Suffix  != null && Suffix.Equals(other.Suffix))   &&
                   (Font    == other.Font    && Font    != null && other.Font    != null && Font.Equals(other.Font));
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;

                if(Visible != null)
                    hashCode = hashCode * 59 + Visible.GetHashCode();

                if(XAnchor != null)
                    hashCode = hashCode * 59 + XAnchor.GetHashCode();

                if(Offset != null)
                    hashCode = hashCode * 59 + Offset.GetHashCode();

                if(Prefix != null)
                    hashCode = hashCode * 59 + Prefix.GetHashCode();

                if(Suffix != null)
                    hashCode = hashCode * 59 + Suffix.GetHashCode();

                if(Font != null)
                    hashCode = hashCode * 59 + Font.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left CurrentValue and the right CurrentValue.
        /// </summary>
        /// <param name="left">Left CurrentValue.</param>
        /// <param name="right">Right CurrentValue.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(CurrentValue left,
                                       CurrentValue right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left CurrentValue and the right CurrentValue.
        /// </summary>
        /// <param name="left">Left CurrentValue.</param>
        /// <param name="right">Right CurrentValue.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(CurrentValue left,
                                       CurrentValue right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>CurrentValue</returns>
        public CurrentValue DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<CurrentValue>(ms).Result;
        }
    }
}
