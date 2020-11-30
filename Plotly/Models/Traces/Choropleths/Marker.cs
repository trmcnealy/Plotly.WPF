using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Traces.Choropleths.Markers;

namespace Plotly.Models.Traces.Choropleths
{
    /// <summary>
    ///     The Marker class.
    /// </summary>
    
    [JsonConverter(typeof(PlotlyConverter))]
    [Serializable]
    public class Marker : IEquatable<Marker>
    {
        /// <summary>
        ///     Gets or sets the Line.
        /// </summary>
        [JsonPropertyName(@"line")]
        public Line Line { get; set;} 

        /// <summary>
        ///     Sets the opacity of the locations.
        /// </summary>
        [JsonPropertyName(@"opacity")]
        public JsNumber? Opacity { get; set;} 

        /// <summary>
        ///     Sets the opacity of the locations.
        /// </summary>
        [JsonPropertyName(@"opacity")]
        [Array]
        public List<JsNumber?> OpacityArray { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  opacity .
        /// </summary>
        [JsonPropertyName(@"opacitysrc")]
        public string OpacitySrc { get; set;} 

        
        public override bool Equals(object obj)
        {
            if (!(obj is Marker other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        
        public bool Equals([AllowNull] Marker other)
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
                    Opacity == other.Opacity &&
                    Opacity != null && other.Opacity != null &&
                    Opacity.Equals(other.Opacity)
                ) && 
                (
                    Equals(OpacityArray, other.OpacityArray) ||
                    OpacityArray != null && other.OpacityArray != null &&
                    OpacityArray.SequenceEqual(other.OpacityArray)
                ) &&
                (
                    OpacitySrc == other.OpacitySrc &&
                    OpacitySrc != null && other.OpacitySrc != null &&
                    OpacitySrc.Equals(other.OpacitySrc)
                );
        }

        
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (Line != null) hashCode = hashCode * 59 + Line.GetHashCode();
                if (Opacity != null) hashCode = hashCode * 59 + Opacity.GetHashCode();
                if (OpacityArray != null) hashCode = hashCode * 59 + OpacityArray.GetHashCode();
                if (OpacitySrc != null) hashCode = hashCode * 59 + OpacitySrc.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Marker and the right Marker.
        /// </summary>
        /// <param name="left">Left Marker.</param>
        /// <param name="right">Right Marker.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (Marker left, Marker right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Marker and the right Marker.
        /// </summary>
        /// <param name="left">Left Marker.</param>
        /// <param name="right">Right Marker.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (Marker left, Marker right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Marker</returns>
        public Marker DeepClone()
        {
            using MemoryStream ms = new();
            
            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;
            return JsonSerializer.DeserializeAsync<Marker>(ms).Result;
        }
    }
}