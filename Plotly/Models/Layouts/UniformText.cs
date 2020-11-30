using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Layouts.UniformTexts;

namespace Plotly.Models.Layouts
{
    /// <summary>
    ///     The UniformText class.
    /// </summary>
    
    [Serializable]
    public class UniformText : IEquatable<UniformText>
    {
        /// <summary>
        ///     Determines how the font size for various text elements are uniformed between
        ///     each trace type. If the computed text sizes were smaller than the minimum
        ///     size defined by <c>uniformtext.minsize</c> using <c>hide</c> option hides
        ///     the text; and using <c>show</c> option shows the text without further downscaling.
        ///     Please note that if the size defined by <c>minsize</c> is greater than the
        ///     font size defined by trace, then the <c>minsize</c> is used.
        /// </summary>
        [JsonPropertyName(@"mode")]
        public ModeEnum? Mode { get; set;} 

        /// <summary>
        ///     Sets the minimum text size between traces of the same type.
        /// </summary>
        [JsonPropertyName(@"minsize")]
        public JsNumber? MinSize { get; set;} 

        
        public override bool Equals(object obj)
        {
            if (!(obj is UniformText other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        
        public bool Equals([AllowNull] UniformText other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Mode == other.Mode &&
                    Mode != null && other.Mode != null &&
                    Mode.Equals(other.Mode)
                ) && 
                (
                    MinSize == other.MinSize &&
                    MinSize != null && other.MinSize != null &&
                    MinSize.Equals(other.MinSize)
                );
        }

        
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (Mode != null) hashCode = hashCode * 59 + Mode.GetHashCode();
                if (MinSize != null) hashCode = hashCode * 59 + MinSize.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left UniformText and the right UniformText.
        /// </summary>
        /// <param name="left">Left UniformText.</param>
        /// <param name="right">Right UniformText.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (UniformText left, UniformText right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left UniformText and the right UniformText.
        /// </summary>
        /// <param name="left">Left UniformText.</param>
        /// <param name="right">Right UniformText.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (UniformText left, UniformText right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>UniformText</returns>
        public UniformText DeepClone()
        {
            using MemoryStream ms = new();
            
            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;
            return JsonSerializer.DeserializeAsync<UniformText>(ms).Result;
        }
    }
}