using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Traces.Indicators.Gauges.Thresholds;

namespace Plotly.Models.Traces.Indicators.Gauges
{
    /// <summary>
    ///     The Threshold class.
    /// </summary>
    
    [Serializable]
    public class Threshold : IEquatable<Threshold>
    {
        /// <summary>
        ///     Gets or sets the Line.
        /// </summary>
        [JsonPropertyName(@"line")]
        public Line Line { get; set;} 

        /// <summary>
        ///     Sets the thickness of the threshold line as a fraction of the thickness
        ///     of the gauge.
        /// </summary>
        [JsonPropertyName(@"thickness")]
        public JsNumber? Thickness { get; set;} 

        /// <summary>
        ///     Sets a treshold value drawn as a line.
        /// </summary>
        [JsonPropertyName(@"value")]
        public JsNumber? Value { get; set;} 

        
        public override bool Equals(object obj)
        {
            if (!(obj is Threshold other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        
        public bool Equals([AllowNull] Threshold other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Line == other.Line &&
                    Line != null && other.Line != null &&
                    Line.Equals(other.Line)
                ) && 
                (
                    Thickness == other.Thickness &&
                    Thickness != null && other.Thickness != null &&
                    Thickness.Equals(other.Thickness)
                ) && 
                (
                    Value == other.Value &&
                    Value != null && other.Value != null &&
                    Value.Equals(other.Value)
                );
        }

        
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (Line != null) hashCode = hashCode * 59 + Line.GetHashCode();
                if (Thickness != null) hashCode = hashCode * 59 + Thickness.GetHashCode();
                if (Value != null) hashCode = hashCode * 59 + Value.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Threshold and the right Threshold.
        /// </summary>
        /// <param name="left">Left Threshold.</param>
        /// <param name="right">Right Threshold.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (Threshold left, Threshold right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Threshold and the right Threshold.
        /// </summary>
        /// <param name="left">Left Threshold.</param>
        /// <param name="right">Right Threshold.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (Threshold left, Threshold right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Threshold</returns>
        public Threshold DeepClone()
        {
            using MemoryStream ms = new();
            
            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;
            return JsonSerializer.DeserializeAsync<Threshold>(ms).Result;
        }
    }
}