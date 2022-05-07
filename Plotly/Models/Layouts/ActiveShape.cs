using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Plotly.Models.Layouts
{
    /// <summary>
    ///     The ActiveShape class.
    /// </summary>
    [Serializable]
    public class ActiveShape : IEquatable<ActiveShape>
    {
        /// <summary>
        ///     Sets the color filling the active shape&#39; interior.
        /// </summary>
        [JsonPropertyName(@"fillcolor")]
        public object? FillColor { get; set; }

        /// <summary>
        ///     Sets the opacity of the active shape.
        /// </summary>
        [JsonPropertyName(@"opacity")]
        public JsNumber? Opacity { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is ActiveShape other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] ActiveShape other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (FillColor == other.FillColor && FillColor != null && other.FillColor != null && FillColor.Equals(other.FillColor)) &&
                   (Opacity   == other.Opacity   && Opacity   != null && other.Opacity   != null && Opacity.Equals(other.Opacity));
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;

                if(FillColor != null)
                    hashCode = hashCode * 59 + FillColor.GetHashCode();

                if(Opacity != null)
                    hashCode = hashCode * 59 + Opacity.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left ActiveShape and the right ActiveShape.
        /// </summary>
        /// <param name="left">Left ActiveShape.</param>
        /// <param name="right">Right ActiveShape.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(ActiveShape left,
                                       ActiveShape right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left ActiveShape and the right ActiveShape.
        /// </summary>
        /// <param name="left">Left ActiveShape.</param>
        /// <param name="right">Right ActiveShape.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(ActiveShape left,
                                       ActiveShape right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>ActiveShape</returns>
        public ActiveShape DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<ActiveShape>(ms).Result;
        }
    }
}
