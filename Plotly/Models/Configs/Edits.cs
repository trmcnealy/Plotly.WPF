using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Plotly.Models.Configs
{
    /// <summary>
    ///     The Edits class.
    /// </summary>
    
    [Serializable]
    public class Edits : IEquatable<Edits>
    {
        /// <summary>
        ///     Determines if the main anchor of the annotation is editable. The main anchor
        ///     corresponds to the text (if no arrow) or the arrow (which drags the whole
        ///     thing leaving the arrow length &amp; direction unchanged).
        /// </summary>
        [JsonPropertyName(@"annotationPosition")]
        public bool? AnnotationPosition { get; set;} 

        /// <summary>
        ///     Has only an effect for annotations with arrows. Enables changing the length
        ///     and direction of the arrow.
        /// </summary>
        [JsonPropertyName(@"annotationTail")]
        public bool? AnnotationTail { get; set;} 

        /// <summary>
        ///     Enables editing annotation text.
        /// </summary>
        [JsonPropertyName(@"annotationText")]
        public bool? AnnotationText { get; set;} 

        /// <summary>
        ///     Enables editing axis title text.
        /// </summary>
        [JsonPropertyName(@"axisTitleText")]
        public bool? AxisTitleText { get; set;} 

        /// <summary>
        ///     Enables moving colorbars.
        /// </summary>
        [JsonPropertyName(@"colorbarPosition")]
        public bool? ColorbarPosition { get; set;} 

        /// <summary>
        ///     Enables editing colorbar title text.
        /// </summary>
        [JsonPropertyName(@"colorbarTitleText")]
        public bool? ColorbarTitleText { get; set;} 

        /// <summary>
        ///     Enables moving the legend.
        /// </summary>
        [JsonPropertyName(@"legendPosition")]
        public bool? LegendPosition { get; set;} 

        /// <summary>
        ///     Enables editing the trace name fields from the legend
        /// </summary>
        [JsonPropertyName(@"legendText")]
        public bool? LegendText { get; set;} 

        /// <summary>
        ///     Enables moving shapes.
        /// </summary>
        [JsonPropertyName(@"shapePosition")]
        public bool? ShapePosition { get; set;} 

        /// <summary>
        ///     Enables editing the global layout title.
        /// </summary>
        [JsonPropertyName(@"titleText")]
        public bool? TitleText { get; set;} 

        
        public override bool Equals(object obj)
        {
            if (!(obj is Edits other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        
        public bool Equals([AllowNull] Edits other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    AnnotationPosition == other.AnnotationPosition &&
                    AnnotationPosition != null && other.AnnotationPosition != null &&
                    AnnotationPosition.Equals(other.AnnotationPosition)
                ) && 
                (
                    AnnotationTail == other.AnnotationTail &&
                    AnnotationTail != null && other.AnnotationTail != null &&
                    AnnotationTail.Equals(other.AnnotationTail)
                ) && 
                (
                    AnnotationText == other.AnnotationText &&
                    AnnotationText != null && other.AnnotationText != null &&
                    AnnotationText.Equals(other.AnnotationText)
                ) && 
                (
                    AxisTitleText == other.AxisTitleText &&
                    AxisTitleText != null && other.AxisTitleText != null &&
                    AxisTitleText.Equals(other.AxisTitleText)
                ) && 
                (
                    ColorbarPosition == other.ColorbarPosition &&
                    ColorbarPosition != null && other.ColorbarPosition != null &&
                    ColorbarPosition.Equals(other.ColorbarPosition)
                ) && 
                (
                    ColorbarTitleText == other.ColorbarTitleText &&
                    ColorbarTitleText != null && other.ColorbarTitleText != null &&
                    ColorbarTitleText.Equals(other.ColorbarTitleText)
                ) && 
                (
                    LegendPosition == other.LegendPosition &&
                    LegendPosition != null && other.LegendPosition != null &&
                    LegendPosition.Equals(other.LegendPosition)
                ) && 
                (
                    LegendText == other.LegendText &&
                    LegendText != null && other.LegendText != null &&
                    LegendText.Equals(other.LegendText)
                ) && 
                (
                    ShapePosition == other.ShapePosition &&
                    ShapePosition != null && other.ShapePosition != null &&
                    ShapePosition.Equals(other.ShapePosition)
                ) && 
                (
                    TitleText == other.TitleText &&
                    TitleText != null && other.TitleText != null &&
                    TitleText.Equals(other.TitleText)
                );
        }

        
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (AnnotationPosition != null) hashCode = hashCode * 59 + AnnotationPosition.GetHashCode();
                if (AnnotationTail != null) hashCode = hashCode * 59 + AnnotationTail.GetHashCode();
                if (AnnotationText != null) hashCode = hashCode * 59 + AnnotationText.GetHashCode();
                if (AxisTitleText != null) hashCode = hashCode * 59 + AxisTitleText.GetHashCode();
                if (ColorbarPosition != null) hashCode = hashCode * 59 + ColorbarPosition.GetHashCode();
                if (ColorbarTitleText != null) hashCode = hashCode * 59 + ColorbarTitleText.GetHashCode();
                if (LegendPosition != null) hashCode = hashCode * 59 + LegendPosition.GetHashCode();
                if (LegendText != null) hashCode = hashCode * 59 + LegendText.GetHashCode();
                if (ShapePosition != null) hashCode = hashCode * 59 + ShapePosition.GetHashCode();
                if (TitleText != null) hashCode = hashCode * 59 + TitleText.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Edits and the right Edits.
        /// </summary>
        /// <param name="left">Left Edits.</param>
        /// <param name="right">Right Edits.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (Edits left, Edits right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Edits and the right Edits.
        /// </summary>
        /// <param name="left">Left Edits.</param>
        /// <param name="right">Right Edits.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (Edits left, Edits right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Edits</returns>
        public Edits DeepClone()
        {
            using MemoryStream ms = new();
            
            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;
            return JsonSerializer.DeserializeAsync<Edits>(ms).Result;
        }
    }
}