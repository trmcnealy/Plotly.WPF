using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Layouts.MapBoxs.Layers.Symbols;

namespace Plotly.Models.Layouts.MapBoxs.Layers
{
    /// <summary>
    ///     The Symbol class.
    /// </summary>
    
    [Serializable]
    public class Symbol : IEquatable<Symbol>
    {
        /// <summary>
        ///     Sets the symbol icon image (mapbox.layer.layout.icon-image). Full list:
        ///     https://www.mapbox.com/maki-icons/
        /// </summary>
        [JsonPropertyName(@"icon")]
        public string Icon { get; set;} 

        /// <summary>
        ///     Sets the symbol icon size (mapbox.layer.layout.icon-size). Has an effect
        ///     only when <c>type</c> is set to <c>symbol</c>.
        /// </summary>
        [JsonPropertyName(@"iconsize")]
        public JsNumber? IconSize { get; set;} 

        /// <summary>
        ///     Sets the symbol text (mapbox.layer.layout.text-field).
        /// </summary>
        [JsonPropertyName(@"text")]
        public string Text { get; set;} 

        /// <summary>
        ///     Sets the symbol and/or text placement (mapbox.layer.layout.symbol-placement).
        ///     If <c>placement</c> is <c>point</c>, the label is placed where the geometry
        ///     is located If <c>placement</c> is <c>line</c>, the label is placed along
        ///     the line of the geometry If <c>placement</c> is <c>line-center</c>, the
        ///     label is placed on the center of the geometry
        /// </summary>
        [JsonPropertyName(@"placement")]
        public PlacementEnum? Placement { get; set;} 

        /// <summary>
        ///     Sets the icon text font (color=mapbox.layer.paint.text-color, size=mapbox.layer.layout.text-size).
        ///     Has an effect only when <c>type</c> is set to <c>symbol</c>.
        /// </summary>
        [JsonPropertyName(@"textfont")]
        public TextFont TextFont { get; set;} 

        /// <summary>
        ///     Sets the positions of the <c>text</c> elements with respects to the (x,y)
        ///     coordinates.
        /// </summary>
        [JsonPropertyName(@"textposition")]
        public TextPositionEnum? TextPosition { get; set;} 

        
        public override bool Equals(object obj)
        {
            if (!(obj is Symbol other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        
        public bool Equals([AllowNull] Symbol other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Icon == other.Icon &&
                    Icon != null && other.Icon != null &&
                    Icon.Equals(other.Icon)
                ) && 
                (
                    IconSize == other.IconSize &&
                    IconSize != null && other.IconSize != null &&
                    IconSize.Equals(other.IconSize)
                ) && 
                (
                    Text == other.Text &&
                    Text != null && other.Text != null &&
                    Text.Equals(other.Text)
                ) && 
                (
                    Placement == other.Placement &&
                    Placement != null && other.Placement != null &&
                    Placement.Equals(other.Placement)
                ) && 
                (
                    TextFont == other.TextFont &&
                    TextFont != null && other.TextFont != null &&
                    TextFont.Equals(other.TextFont)
                ) && 
                (
                    TextPosition == other.TextPosition &&
                    TextPosition != null && other.TextPosition != null &&
                    TextPosition.Equals(other.TextPosition)
                );
        }

        
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (Icon != null) hashCode = hashCode * 59 + Icon.GetHashCode();
                if (IconSize != null) hashCode = hashCode * 59 + IconSize.GetHashCode();
                if (Text != null) hashCode = hashCode * 59 + Text.GetHashCode();
                if (Placement != null) hashCode = hashCode * 59 + Placement.GetHashCode();
                if (TextFont != null) hashCode = hashCode * 59 + TextFont.GetHashCode();
                if (TextPosition != null) hashCode = hashCode * 59 + TextPosition.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Symbol and the right Symbol.
        /// </summary>
        /// <param name="left">Left Symbol.</param>
        /// <param name="right">Right Symbol.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (Symbol left, Symbol right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Symbol and the right Symbol.
        /// </summary>
        /// <param name="left">Left Symbol.</param>
        /// <param name="right">Right Symbol.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (Symbol left, Symbol right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Symbol</returns>
        public Symbol DeepClone()
        {
            using MemoryStream ms = new();
            
            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;
            return JsonSerializer.DeserializeAsync<Symbol>(ms).Result;
        }
    }
}