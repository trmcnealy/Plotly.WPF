using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Traces.Volumes.Surfaces;

namespace Plotly.Models.Traces.Volumes
{
    /// <summary>
    ///     The Surface class.
    /// </summary>
    
    [Serializable]
    public class Surface : IEquatable<Surface>
    {
        /// <summary>
        ///     Hides/displays surfaces between minimum and maximum iso-values.
        /// </summary>
        [JsonPropertyName(@"show")]
        public bool? Show { get; set;} 

        /// <summary>
        ///     Sets the number of iso-surfaces between minimum and maximum iso-values.
        ///     By default this value is 2 meaning that only minimum and maximum surfaces
        ///     would be drawn.
        /// </summary>
        [JsonPropertyName(@"count")]
        public int? Count { get; set;} 

        /// <summary>
        ///     Sets the fill ratio of the iso-surface. The default fill value of the surface
        ///     is 1 meaning that they are entirely shaded. On the other hand Applying a
        ///     <c>fill</c> ratio less than one would allow the creation of openings parallel
        ///     to the edges.
        /// </summary>
        [JsonPropertyName(@"fill")]
        public JsNumber? Fill { get; set;} 

        /// <summary>
        ///     Sets the surface pattern of the iso-surface 3-D sections. The default pattern
        ///     of the surface is <c>all</c> meaning that the rest of surface elements would
        ///     be shaded. The check options (either 1 or 2) could be used to draw half
        ///     of the squares on the surface. Using various combinations of capital <c>A</c>,
        ///     <c>B</c>, <c>C</c>, <c>D</c> and <c>E</c> may also be used to reduce the
        ///     number of triangles on the iso-surfaces and creating other patterns of interest.
        /// </summary>
        [JsonPropertyName(@"pattern")]
        public PatternFlag? Pattern { get; set;} 

        
        public override bool Equals(object obj)
        {
            if (!(obj is Surface other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        
        public bool Equals([AllowNull] Surface other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Show == other.Show &&
                    Show != null && other.Show != null &&
                    Show.Equals(other.Show)
                ) && 
                (
                    Count == other.Count &&
                    Count != null && other.Count != null &&
                    Count.Equals(other.Count)
                ) && 
                (
                    Fill == other.Fill &&
                    Fill != null && other.Fill != null &&
                    Fill.Equals(other.Fill)
                ) && 
                (
                    Pattern == other.Pattern &&
                    Pattern != null && other.Pattern != null &&
                    Pattern.Equals(other.Pattern)
                );
        }

        
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (Show != null) hashCode = hashCode * 59 + Show.GetHashCode();
                if (Count != null) hashCode = hashCode * 59 + Count.GetHashCode();
                if (Fill != null) hashCode = hashCode * 59 + Fill.GetHashCode();
                if (Pattern != null) hashCode = hashCode * 59 + Pattern.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Surface and the right Surface.
        /// </summary>
        /// <param name="left">Left Surface.</param>
        /// <param name="right">Right Surface.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (Surface left, Surface right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Surface and the right Surface.
        /// </summary>
        /// <param name="left">Left Surface.</param>
        /// <param name="right">Right Surface.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (Surface left, Surface right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Surface</returns>
        public Surface DeepClone()
        {
            using MemoryStream ms = new();
            
            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;
            return JsonSerializer.DeserializeAsync<Surface>(ms).Result;
        }
    }
}