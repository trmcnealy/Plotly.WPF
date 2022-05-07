using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Layouts.NewShapes;

namespace Plotly.Models.Layouts
{
    /// <summary>
    ///     The NewShape class.
    /// </summary>
    [Serializable]
    public class NewShape : IEquatable<NewShape>
    {
        /// <summary>
        ///     Gets or sets the Line.
        /// </summary>
        [JsonPropertyName(@"line")]
        public Line? Line { get; set; }

        /// <summary>
        ///     Sets the color filling new shapes&#39; interior. Please note that if using
        ///     a fillcolor with alpha greater than half, drag inside the active shape starts
        ///     moving the shape underneath, otherwise a new shape could be started over.
        /// </summary>
        [JsonPropertyName(@"fillcolor")]
        public object? FillColor { get; set; }

        /// <summary>
        ///     Determines the path&#39;s interior. For more info please visit https://developer.mozilla.org/en-US/docs/Web/SVG/Attribute/fill-rule
        /// </summary>
        [JsonPropertyName(@"fillrule")]
        public FillRuleEnum? FillRule { get; set; }

        /// <summary>
        ///     Sets the opacity of new shapes.
        /// </summary>
        [JsonPropertyName(@"opacity")]
        public JsNumber? Opacity { get; set; }

        /// <summary>
        ///     Specifies whether new shapes are drawn below or above traces.
        /// </summary>
        [JsonPropertyName(@"layer")]
        public LayerEnum? Layer { get; set; }

        /// <summary>
        ///     When <c>dragmode</c> is set to <c>drawrect</c>, <c>drawline</c> or <c>drawcircle</c>
        ///     this limits the drag to be horizontal, vertical or diagonal. Using <c>diagonal</c>
        ///     there is no limit e.g. in drawing lines in any direction. <c>ortho</c> limits
        ///     the draw to be either horizontal or vertical. <c>horizontal</c> allows horizontal
        ///     extend. <c>vertical</c> allows vertical extend.
        /// </summary>
        [JsonPropertyName(@"drawdirection")]
        public DrawDirectionEnum? DrawDirection { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is NewShape other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] NewShape other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (Line          == other.Line          && Line          != null && other.Line          != null && Line.Equals(other.Line))           &&
                   (FillColor     == other.FillColor     && FillColor     != null && other.FillColor     != null && FillColor.Equals(other.FillColor)) &&
                   (FillRule      == other.FillRule      && FillRule      != null && other.FillRule      != null && FillRule.Equals(other.FillRule))   &&
                   (Opacity       == other.Opacity       && Opacity       != null && other.Opacity       != null && Opacity.Equals(other.Opacity))     &&
                   (Layer         == other.Layer         && Layer         != null && other.Layer         != null && Layer.Equals(other.Layer))         &&
                   (DrawDirection == other.DrawDirection && DrawDirection != null && other.DrawDirection != null && DrawDirection.Equals(other.DrawDirection));
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;

                if(Line != null)
                    hashCode = hashCode * 59 + Line.GetHashCode();

                if(FillColor != null)
                    hashCode = hashCode * 59 + FillColor.GetHashCode();

                if(FillRule != null)
                    hashCode = hashCode * 59 + FillRule.GetHashCode();

                if(Opacity != null)
                    hashCode = hashCode * 59 + Opacity.GetHashCode();

                if(Layer != null)
                    hashCode = hashCode * 59 + Layer.GetHashCode();

                if(DrawDirection != null)
                    hashCode = hashCode * 59 + DrawDirection.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left NewShape and the right NewShape.
        /// </summary>
        /// <param name="left">Left NewShape.</param>
        /// <param name="right">Right NewShape.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(NewShape left,
                                       NewShape right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left NewShape and the right NewShape.
        /// </summary>
        /// <param name="left">Left NewShape.</param>
        /// <param name="right">Right NewShape.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(NewShape left,
                                       NewShape right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>NewShape</returns>
        public NewShape DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<NewShape>(ms).Result;
        }
    }
}
