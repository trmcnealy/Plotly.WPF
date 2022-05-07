using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Plotly.Models.Transforms.GroupBys
{
    /// <summary>
    ///     The Style class.
    /// </summary>
    [Serializable]
    public class Style : IEquatable<Style>
    {
        /// <summary>
        ///     The group value which receives these styles.
        /// </summary>
        [JsonPropertyName(@"target")]
        public string? Target { get; set; }

        /// <summary>
        ///     Sets each group styles. For example, with <c>groups</c> set to &#39;[<c>a</c>,
        ///     <c>b</c>, <c>a</c>, <c>b</c>]&#39; and <c>styles</c> set to *[{target: <c>a</c>,
        ///     value: { marker: { color: <c>red</c> } }}] marker points in group <c><c>a</c></c>
        ///     will be drawn in red.
        /// </summary>
        [JsonPropertyName(@"value")]
        public object? Value { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is Style other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] Style other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (Target == other.Target && Target != null && other.Target != null && Target.Equals(other.Target)) &&
                   (Value  == other.Value  && Value  != null && other.Value  != null && Value.Equals(other.Value));
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;

                if(Target != null)
                    hashCode = hashCode * 59 + Target.GetHashCode();

                if(Value != null)
                    hashCode = hashCode * 59 + Value.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Style and the right Style.
        /// </summary>
        /// <param name="left">Left Style.</param>
        /// <param name="right">Right Style.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(Style left,
                                       Style right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Style and the right Style.
        /// </summary>
        /// <param name="left">Left Style.</param>
        /// <param name="right">Right Style.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(Style left,
                                       Style right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Style</returns>
        public Style DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<Style>(ms).Result;
        }
    }
}
