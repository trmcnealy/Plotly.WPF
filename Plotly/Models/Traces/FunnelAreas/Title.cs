using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Traces.FunnelAreas.Titles;

namespace Plotly.Models.Traces.FunnelAreas
{
    /// <summary>
    ///     The Title class.
    /// </summary>
    
    [Serializable]
    public class Title : IEquatable<Title>
    {
        /// <summary>
        ///     Sets the title of the chart. If it is empty, no title is displayed. Note
        ///     that before the existence of <c>title.text</c>, the title&#39;s contents
        ///     used to be defined as the <c>title</c> attribute itself. This behavior has
        ///     been deprecated.
        /// </summary>
        [JsonPropertyName(@"text")]
        public string Text { get; set;} 

        /// <summary>
        ///     Sets the font used for <c>title</c>. Note that the title&#39;s font used
        ///     to be set by the now deprecated <c>titlefont</c> attribute.
        /// </summary>
        [JsonPropertyName(@"font")]
        public Font Font { get; set;} 

        /// <summary>
        ///     Specifies the location of the <c>title</c>. Note that the title&#39;s position
        ///     used to be set by the now deprecated <c>titleposition</c> attribute.
        /// </summary>
        [JsonPropertyName(@"position")]
        public PositionEnum? Position { get; set;} 

        
        public override bool Equals(object obj)
        {
            if (!(obj is Title other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        
        public bool Equals([AllowNull] Title other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Text == other.Text &&
                    Text != null && other.Text != null &&
                    Text.Equals(other.Text)
                ) && 
                (
                    Font == other.Font &&
                    Font != null && other.Font != null &&
                    Font.Equals(other.Font)
                ) && 
                (
                    Position == other.Position &&
                    Position != null && other.Position != null &&
                    Position.Equals(other.Position)
                );
        }

        
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (Text != null) hashCode = hashCode * 59 + Text.GetHashCode();
                if (Font != null) hashCode = hashCode * 59 + Font.GetHashCode();
                if (Position != null) hashCode = hashCode * 59 + Position.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Title and the right Title.
        /// </summary>
        /// <param name="left">Left Title.</param>
        /// <param name="right">Right Title.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (Title left, Title right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Title and the right Title.
        /// </summary>
        /// <param name="left">Left Title.</param>
        /// <param name="right">Right Title.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (Title left, Title right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Title</returns>
        public Title DeepClone()
        {
            using MemoryStream ms = new();
            
            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;
            return JsonSerializer.DeserializeAsync<Title>(ms).Result;
        }
    }
}