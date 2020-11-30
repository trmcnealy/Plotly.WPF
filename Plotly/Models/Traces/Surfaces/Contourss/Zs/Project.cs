using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Plotly.Models.Traces.Surfaces.Contourss.Zs
{
    /// <summary>
    ///     The Project class.
    /// </summary>
    
    [Serializable]
    public class Project : IEquatable<Project>
    {
        /// <summary>
        ///     Determines whether or not these contour lines are projected on the x plane.
        ///     If <c>highlight</c> is set to <c>true</c> (the default), the projected lines
        ///     are shown on hover. If <c>show</c> is set to <c>true</c>, the projected
        ///     lines are shown in permanence.
        /// </summary>
        [JsonPropertyName(@"x")]
        public bool? X { get; set;} 

        /// <summary>
        ///     Determines whether or not these contour lines are projected on the y plane.
        ///     If <c>highlight</c> is set to <c>true</c> (the default), the projected lines
        ///     are shown on hover. If <c>show</c> is set to <c>true</c>, the projected
        ///     lines are shown in permanence.
        /// </summary>
        [JsonPropertyName(@"y")]
        public bool? Y { get; set;} 

        /// <summary>
        ///     Determines whether or not these contour lines are projected on the z plane.
        ///     If <c>highlight</c> is set to <c>true</c> (the default), the projected lines
        ///     are shown on hover. If <c>show</c> is set to <c>true</c>, the projected
        ///     lines are shown in permanence.
        /// </summary>
        [JsonPropertyName(@"z")]
        public bool? Z { get; set;} 

        
        public override bool Equals(object obj)
        {
            if (!(obj is Project other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        
        public bool Equals([AllowNull] Project other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    X == other.X &&
                    X != null && other.X != null &&
                    X.Equals(other.X)
                ) && 
                (
                    Y == other.Y &&
                    Y != null && other.Y != null &&
                    Y.Equals(other.Y)
                ) && 
                (
                    Z == other.Z &&
                    Z != null && other.Z != null &&
                    Z.Equals(other.Z)
                );
        }

        
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (X != null) hashCode = hashCode * 59 + X.GetHashCode();
                if (Y != null) hashCode = hashCode * 59 + Y.GetHashCode();
                if (Z != null) hashCode = hashCode * 59 + Z.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Project and the right Project.
        /// </summary>
        /// <param name="left">Left Project.</param>
        /// <param name="right">Right Project.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (Project left, Project right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Project and the right Project.
        /// </summary>
        /// <param name="left">Left Project.</param>
        /// <param name="right">Right Project.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (Project left, Project right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Project</returns>
        public Project DeepClone()
        {
            using MemoryStream ms = new();
            
            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;
            return JsonSerializer.DeserializeAsync<Project>(ms).Result;
        }
    }
}