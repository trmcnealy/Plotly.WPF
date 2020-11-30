using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Layouts.AngularAxes;

namespace Plotly.Models.Layouts
{
    /// <summary>
    ///     The AngularAxis class.
    /// </summary>
    
    [Serializable]
    public class AngularAxis : IEquatable<AngularAxis>
    {
        /// <summary>
        ///     Legacy polar charts are deprecated! Please switch to <c>polar</c> subplots.
        ///     Defines the start and end point of this angular axis.
        /// </summary>
        [JsonPropertyName(@"range")]
        public List<object> Range { get; set;} 

        /// <summary>
        ///     Polar chart subplots are not supported yet. This key has currently no effect.
        /// </summary>
        [JsonPropertyName(@"domain")]
        public List<object> Domain { get; set;} 

        /// <summary>
        ///     Legacy polar charts are deprecated! Please switch to <c>polar</c> subplots.
        ///     Determines whether or not the line bounding this angular axis will be shown
        ///     on the figure.
        /// </summary>
        [JsonPropertyName(@"showline")]
        public bool? ShowLine { get; set;} 

        /// <summary>
        ///     Legacy polar charts are deprecated! Please switch to <c>polar</c> subplots.
        ///     Determines whether or not the angular axis ticks will feature tick labels.
        /// </summary>
        [JsonPropertyName(@"showticklabels")]
        public bool? ShowTickLabels { get; set;} 

        /// <summary>
        ///     Legacy polar charts are deprecated! Please switch to <c>polar</c> subplots.
        ///     Sets the orientation (from the paper perspective) of the angular axis tick
        ///     labels.
        /// </summary>
        [JsonPropertyName(@"tickorientation")]
        public TickOrientationEnum? TickOrientation { get; set;} 

        /// <summary>
        ///     Legacy polar charts are deprecated! Please switch to <c>polar</c> subplots.
        ///     Sets the length of the tick lines on this angular axis.
        /// </summary>
        [JsonPropertyName(@"ticklen")]
        public JsNumber? TickleN { get; set;} 

        /// <summary>
        ///     Legacy polar charts are deprecated! Please switch to <c>polar</c> subplots.
        ///     Sets the color of the tick lines on this angular axis.
        /// </summary>
        [JsonPropertyName(@"tickcolor")]
        public object TickColor { get; set;} 

        /// <summary>
        ///     Legacy polar charts are deprecated! Please switch to <c>polar</c> subplots.
        ///     Sets the length of the tick lines on this angular axis.
        /// </summary>
        [JsonPropertyName(@"ticksuffix")]
        public string TickSuffix { get; set;} 

        /// <summary>
        ///     Legacy polar charts are deprecated! Please switch to <c>polar</c> subplots.
        /// </summary>
        [JsonPropertyName(@"endpadding")]
        public JsNumber? EndPadding { get; set;} 

        /// <summary>
        ///     Legacy polar charts are deprecated! Please switch to <c>polar</c> subplots.
        ///     Determines whether or not this axis will be visible.
        /// </summary>
        [JsonPropertyName(@"visible")]
        public bool? Visible { get; set;} 

        
        public override bool Equals(object obj)
        {
            if (!(obj is AngularAxis other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        
        public bool Equals([AllowNull] AngularAxis other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Equals(Range, other.Range) ||
                    Range != null && other.Range != null &&
                    Range.SequenceEqual(other.Range)
                ) &&
                (
                    Equals(Domain, other.Domain) ||
                    Domain != null && other.Domain != null &&
                    Domain.SequenceEqual(other.Domain)
                ) &&
                (
                    ShowLine == other.ShowLine &&
                    ShowLine != null && other.ShowLine != null &&
                    ShowLine.Equals(other.ShowLine)
                ) && 
                (
                    ShowTickLabels == other.ShowTickLabels &&
                    ShowTickLabels != null && other.ShowTickLabels != null &&
                    ShowTickLabels.Equals(other.ShowTickLabels)
                ) && 
                (
                    TickOrientation == other.TickOrientation &&
                    TickOrientation != null && other.TickOrientation != null &&
                    TickOrientation.Equals(other.TickOrientation)
                ) && 
                (
                    TickleN == other.TickleN &&
                    TickleN != null && other.TickleN != null &&
                    TickleN.Equals(other.TickleN)
                ) && 
                (
                    TickColor == other.TickColor &&
                    TickColor != null && other.TickColor != null &&
                    TickColor.Equals(other.TickColor)
                ) && 
                (
                    TickSuffix == other.TickSuffix &&
                    TickSuffix != null && other.TickSuffix != null &&
                    TickSuffix.Equals(other.TickSuffix)
                ) && 
                (
                    EndPadding == other.EndPadding &&
                    EndPadding != null && other.EndPadding != null &&
                    EndPadding.Equals(other.EndPadding)
                ) && 
                (
                    Visible == other.Visible &&
                    Visible != null && other.Visible != null &&
                    Visible.Equals(other.Visible)
                );
        }

        
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (Range != null) hashCode = hashCode * 59 + Range.GetHashCode();
                if (Domain != null) hashCode = hashCode * 59 + Domain.GetHashCode();
                if (ShowLine != null) hashCode = hashCode * 59 + ShowLine.GetHashCode();
                if (ShowTickLabels != null) hashCode = hashCode * 59 + ShowTickLabels.GetHashCode();
                if (TickOrientation != null) hashCode = hashCode * 59 + TickOrientation.GetHashCode();
                if (TickleN != null) hashCode = hashCode * 59 + TickleN.GetHashCode();
                if (TickColor != null) hashCode = hashCode * 59 + TickColor.GetHashCode();
                if (TickSuffix != null) hashCode = hashCode * 59 + TickSuffix.GetHashCode();
                if (EndPadding != null) hashCode = hashCode * 59 + EndPadding.GetHashCode();
                if (Visible != null) hashCode = hashCode * 59 + Visible.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left AngularAxis and the right AngularAxis.
        /// </summary>
        /// <param name="left">Left AngularAxis.</param>
        /// <param name="right">Right AngularAxis.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (AngularAxis left, AngularAxis right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left AngularAxis and the right AngularAxis.
        /// </summary>
        /// <param name="left">Left AngularAxis.</param>
        /// <param name="right">Right AngularAxis.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (AngularAxis left, AngularAxis right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>AngularAxis</returns>
        public AngularAxis DeepClone()
        {
            using MemoryStream ms = new();
            
            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;
            return JsonSerializer.DeserializeAsync<AngularAxis>(ms).Result;
        }
    }
}