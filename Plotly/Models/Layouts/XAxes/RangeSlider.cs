using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Plotly.Models.Layouts.XAxes
{
    /// <summary>
    ///     The RangeSlider class.
    /// </summary>
    [JsonConverter(typeof(PlotlyConverter))]
    [Serializable]
    public class RangeSlider : IEquatable<RangeSlider>
    {
        /// <summary>
        ///     Sets the background color of the range slider.
        /// </summary>
        [JsonPropertyName(@"bgcolor")]
        public object? BgColor { get; set; }

        /// <summary>
        ///     Sets the border color of the range slider.
        /// </summary>
        [JsonPropertyName(@"bordercolor")]
        public object? BorderColor { get; set; }

        /// <summary>
        ///     Sets the border width of the range slider.
        /// </summary>
        [JsonPropertyName(@"borderwidth")]
        public int? BorderWidth { get; set; }

        /// <summary>
        ///     Determines whether or not the range slider range is computed in relation
        ///     to the input data. If <c>range</c> is provided, then <c>autorange</c> is
        ///     set to <c>false</c>.
        /// </summary>
        [JsonPropertyName(@"autorange")]
        public bool? AutoRange { get; set; }

        /// <summary>
        ///     Sets the range of the range slider. If not set, defaults to the full xaxis
        ///     range. If the axis <c>type</c> is <c>log</c>, then you must take the log
        ///     of your desired range. If the axis <c>type</c> is <c>date</c>, it should
        ///     be date strings, like date data, though Date objects and unix milliseconds
        ///     will be accepted and converted to strings. If the axis <c>type</c> is <c>category</c>,
        ///     it should be numbers, using the scale where each category is assigned a
        ///     serial number from zero in the order it appears.
        /// </summary>
        [JsonPropertyName(@"range")]
        public List<object>? Range { get; set; }

        /// <summary>
        ///     The height of the range slider as a fraction of the total plot area height.
        /// </summary>
        [JsonPropertyName(@"thickness")]
        public JsNumber? Thickness { get; set; }

        /// <summary>
        ///     Determines whether or not the range slider will be visible. If visible,
        ///     perpendicular axes will be set to <c>fixedrange</c>
        /// </summary>
        [JsonPropertyName(@"visible")]
        public bool? Visible { get; set; }

        /// <summary>
        ///     Gets or sets the YAxis.
        /// </summary>
        [JsonPropertyName(@"yaxis")]
        [Subplot]
        public List<RangeSliders.YAxis>? YAxis { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is RangeSlider other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] RangeSlider other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (BgColor     == other.BgColor     && BgColor     != null && other.BgColor     != null && BgColor.Equals(other.BgColor))         &&
                   (BorderColor == other.BorderColor && BorderColor != null && other.BorderColor != null && BorderColor.Equals(other.BorderColor)) &&
                   (BorderWidth == other.BorderWidth && BorderWidth != null && other.BorderWidth != null && BorderWidth.Equals(other.BorderWidth)) &&
                   (AutoRange   == other.AutoRange   && AutoRange   != null && other.AutoRange   != null && AutoRange.Equals(other.AutoRange))     &&
                   (Equals(Range, other.Range) || Range != null && other.Range != null && Range.SequenceEqual(other.Range))                        &&
                   (Thickness == other.Thickness && Thickness != null && other.Thickness != null && Thickness.Equals(other.Thickness))             &&
                   (Visible   == other.Visible   && Visible   != null && other.Visible   != null && Visible.Equals(other.Visible))                 &&
                   (Equals(YAxis, other.YAxis) || YAxis != null && other.YAxis != null && YAxis.SequenceEqual(other.YAxis));
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;

                if(BgColor != null)
                    hashCode = hashCode * 59 + BgColor.GetHashCode();

                if(BorderColor != null)
                    hashCode = hashCode * 59 + BorderColor.GetHashCode();

                if(BorderWidth != null)
                    hashCode = hashCode * 59 + BorderWidth.GetHashCode();

                if(AutoRange != null)
                    hashCode = hashCode * 59 + AutoRange.GetHashCode();

                if(Range != null)
                    hashCode = hashCode * 59 + Range.GetHashCode();

                if(Thickness != null)
                    hashCode = hashCode * 59 + Thickness.GetHashCode();

                if(Visible != null)
                    hashCode = hashCode * 59 + Visible.GetHashCode();

                if(YAxis != null)
                    hashCode = hashCode * 59 + YAxis.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left RangeSlider and the right RangeSlider.
        /// </summary>
        /// <param name="left">Left RangeSlider.</param>
        /// <param name="right">Right RangeSlider.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(RangeSlider left,
                                       RangeSlider right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left RangeSlider and the right RangeSlider.
        /// </summary>
        /// <param name="left">Left RangeSlider.</param>
        /// <param name="right">Right RangeSlider.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(RangeSlider left,
                                       RangeSlider right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>RangeSlider</returns>
        public RangeSlider DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<RangeSlider>(ms).Result;
        }
    }
}
