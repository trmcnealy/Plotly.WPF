using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Layouts.Ternarys;

namespace Plotly.Models.Layouts
{
    /// <summary>
    ///     The Ternary class.
    /// </summary>
    
    [Serializable]
    public class Ternary : IEquatable<Ternary>
    {
        /// <summary>
        ///     Gets or sets the Domain.
        /// </summary>
        [JsonPropertyName(@"domain")]
        public Domain Domain { get; set;} 

        /// <summary>
        ///     Set the background color of the subplot
        /// </summary>
        [JsonPropertyName(@"bgcolor")]
        public object BgColor { get; set;} 

        /// <summary>
        ///     The number each triplet should sum to, and the maximum range of each axis
        /// </summary>
        [JsonPropertyName(@"sum")]
        public JsNumber? Sum { get; set;} 

        /// <summary>
        ///     Gets or sets the AAxis.
        /// </summary>
        [JsonPropertyName(@"aaxis")]
        public AAxis AAxis { get; set;} 

        /// <summary>
        ///     Gets or sets the BAxis.
        /// </summary>
        [JsonPropertyName(@"baxis")]
        public BAxis BAxis { get; set;} 

        /// <summary>
        ///     Gets or sets the CAxis.
        /// </summary>
        [JsonPropertyName(@"caxis")]
        public CAxis CAxis { get; set;} 

        /// <summary>
        ///     Controls persistence of user-driven changes in axis <c>min</c> and <c>title</c>,
        ///     if not overridden in the individual axes. Defaults to <c>layout.uirevision</c>.
        /// </summary>
        [JsonPropertyName(@"uirevision")]
        public object UiRevision { get; set;} 

        
        public override bool Equals(object obj)
        {
            if (!(obj is Ternary other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        
        public bool Equals([AllowNull] Ternary other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Domain == other.Domain &&
                    Domain != null && other.Domain != null &&
                    Domain.Equals(other.Domain)
                ) && 
                (
                    BgColor == other.BgColor &&
                    BgColor != null && other.BgColor != null &&
                    BgColor.Equals(other.BgColor)
                ) && 
                (
                    Sum == other.Sum &&
                    Sum != null && other.Sum != null &&
                    Sum.Equals(other.Sum)
                ) && 
                (
                    AAxis == other.AAxis &&
                    AAxis != null && other.AAxis != null &&
                    AAxis.Equals(other.AAxis)
                ) && 
                (
                    BAxis == other.BAxis &&
                    BAxis != null && other.BAxis != null &&
                    BAxis.Equals(other.BAxis)
                ) && 
                (
                    CAxis == other.CAxis &&
                    CAxis != null && other.CAxis != null &&
                    CAxis.Equals(other.CAxis)
                ) && 
                (
                    UiRevision == other.UiRevision &&
                    UiRevision != null && other.UiRevision != null &&
                    UiRevision.Equals(other.UiRevision)
                );
        }

        
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (Domain != null) hashCode = hashCode * 59 + Domain.GetHashCode();
                if (BgColor != null) hashCode = hashCode * 59 + BgColor.GetHashCode();
                if (Sum != null) hashCode = hashCode * 59 + Sum.GetHashCode();
                if (AAxis != null) hashCode = hashCode * 59 + AAxis.GetHashCode();
                if (BAxis != null) hashCode = hashCode * 59 + BAxis.GetHashCode();
                if (CAxis != null) hashCode = hashCode * 59 + CAxis.GetHashCode();
                if (UiRevision != null) hashCode = hashCode * 59 + UiRevision.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Ternary and the right Ternary.
        /// </summary>
        /// <param name="left">Left Ternary.</param>
        /// <param name="right">Right Ternary.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (Ternary left, Ternary right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Ternary and the right Ternary.
        /// </summary>
        /// <param name="left">Left Ternary.</param>
        /// <param name="right">Right Ternary.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (Ternary left, Ternary right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Ternary</returns>
        public Ternary DeepClone()
        {
            using MemoryStream ms = new();
            
            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;
            return JsonSerializer.DeserializeAsync<Ternary>(ms).Result;
        }
    }
}