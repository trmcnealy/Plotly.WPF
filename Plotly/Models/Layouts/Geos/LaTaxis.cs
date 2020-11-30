using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Plotly.Models.Layouts.Geos
{
    /// <summary>
    ///     The LaTaxis class.
    /// </summary>
    
    [Serializable]
    public class LaTaxis : IEquatable<LaTaxis>
    {
        /// <summary>
        ///     Sets the range of this axis (in degrees), sets the map&#39;s clipped coordinates.
        /// </summary>
        [JsonPropertyName(@"range")]
        public List<object> Range { get; set;} 

        /// <summary>
        ///     Sets whether or not graticule are shown on the map.
        /// </summary>
        [JsonPropertyName(@"showgrid")]
        public bool? ShowGrid { get; set;} 

        /// <summary>
        ///     Sets the graticule&#39;s starting tick longitude/latitude.
        /// </summary>
        [JsonPropertyName(@"tick0")]
        public JsNumber? Tick0 { get; set;} 

        /// <summary>
        ///     Sets the graticule&#39;s longitude/latitude tick step.
        /// </summary>
        [JsonPropertyName(@"dtick")]
        public JsNumber? DTick { get; set;} 

        /// <summary>
        ///     Sets the graticule&#39;s stroke color.
        /// </summary>
        [JsonPropertyName(@"gridcolor")]
        public object GridColor { get; set;} 

        /// <summary>
        ///     Sets the graticule&#39;s stroke width (in px).
        /// </summary>
        [JsonPropertyName(@"gridwidth")]
        public JsNumber? GridWidth { get; set;} 

        
        public override bool Equals(object obj)
        {
            if (!(obj is LaTaxis other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        
        public bool Equals([AllowNull] LaTaxis other)
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
                    ShowGrid == other.ShowGrid &&
                    ShowGrid != null && other.ShowGrid != null &&
                    ShowGrid.Equals(other.ShowGrid)
                ) && 
                (
                    Tick0 == other.Tick0 &&
                    Tick0 != null && other.Tick0 != null &&
                    Tick0.Equals(other.Tick0)
                ) && 
                (
                    DTick == other.DTick &&
                    DTick != null && other.DTick != null &&
                    DTick.Equals(other.DTick)
                ) && 
                (
                    GridColor == other.GridColor &&
                    GridColor != null && other.GridColor != null &&
                    GridColor.Equals(other.GridColor)
                ) && 
                (
                    GridWidth == other.GridWidth &&
                    GridWidth != null && other.GridWidth != null &&
                    GridWidth.Equals(other.GridWidth)
                );
        }

        
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (Range != null) hashCode = hashCode * 59 + Range.GetHashCode();
                if (ShowGrid != null) hashCode = hashCode * 59 + ShowGrid.GetHashCode();
                if (Tick0 != null) hashCode = hashCode * 59 + Tick0.GetHashCode();
                if (DTick != null) hashCode = hashCode * 59 + DTick.GetHashCode();
                if (GridColor != null) hashCode = hashCode * 59 + GridColor.GetHashCode();
                if (GridWidth != null) hashCode = hashCode * 59 + GridWidth.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left LaTaxis and the right LaTaxis.
        /// </summary>
        /// <param name="left">Left LaTaxis.</param>
        /// <param name="right">Right LaTaxis.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (LaTaxis left, LaTaxis right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left LaTaxis and the right LaTaxis.
        /// </summary>
        /// <param name="left">Left LaTaxis.</param>
        /// <param name="right">Right LaTaxis.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (LaTaxis left, LaTaxis right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>LaTaxis</returns>
        public LaTaxis DeepClone()
        {
            using MemoryStream ms = new();
            
            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;
            return JsonSerializer.DeserializeAsync<LaTaxis>(ms).Result;
        }
    }
}