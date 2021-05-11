using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Plotly.Models
{
    /// <summary>
    ///     The Frames class.
    /// </summary>
    [Serializable]
    public class Frames : IEquatable<Frames>
    {
        /// <summary>
        ///     An identifier that specifies the group to which the frame belongs, used
        ///     by animate to select a subset of frames.
        /// </summary>
        [JsonPropertyName(@"group")]
        public string Group { get; set; }

        /// <summary>
        ///     A label by which to identify the frame
        /// </summary>
        [JsonPropertyName(@"name")]
        public string Name { get; set; }

        /// <summary>
        ///     A list of trace indices that identify the respective traces in the data
        ///     attribute
        /// </summary>
        [JsonPropertyName(@"traces")]
        public object Traces { get; set; }

        /// <summary>
        ///     The name of the frame into which this frame&#39;s properties are merged
        ///     before applying. This is used to unify properties and avoid needing to specify
        ///     the same values for the same properties in multiple frames.
        /// </summary>
        [JsonPropertyName(@"baseframe")]
        public string BaseFrame { get; set; }

        /// <summary>
        ///     A list of traces this frame modifies. The format is identical to the normal
        ///     trace definition.
        /// </summary>
        [JsonPropertyName(@"data")]
        public ITrace Data { get; set; }

        /// <summary>
        ///     Layout properties which this frame modifies. The format is identical to
        ///     the normal layout definition.
        /// </summary>
        [JsonPropertyName(@"layout")]
        public Layout Layout { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is Frames other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] Frames other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (Group     == other.Group     && Group     != null && other.Group     != null && Group.Equals(other.Group))         &&
                   (Name      == other.Name      && Name      != null && other.Name      != null && Name.Equals(other.Name))           &&
                   (Traces    == other.Traces    && Traces    != null && other.Traces    != null && Traces.Equals(other.Traces))       &&
                   (BaseFrame == other.BaseFrame && BaseFrame != null && other.BaseFrame != null && BaseFrame.Equals(other.BaseFrame)) &&
                   (Data      == other.Data      && Data      != null && other.Data      != null && Data.Equals(other.Data))           &&
                   (Layout    == other.Layout    && Layout    != null && other.Layout    != null && Layout.Equals(other.Layout));
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;

                if(Group != null)
                    hashCode = hashCode * 59 + Group.GetHashCode();

                if(Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();

                if(Traces != null)
                    hashCode = hashCode * 59 + Traces.GetHashCode();

                if(BaseFrame != null)
                    hashCode = hashCode * 59 + BaseFrame.GetHashCode();

                if(Data != null)
                    hashCode = hashCode * 59 + Data.GetHashCode();

                if(Layout != null)
                    hashCode = hashCode * 59 + Layout.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Frames and the right Frames.
        /// </summary>
        /// <param name="left">Left Frames.</param>
        /// <param name="right">Right Frames.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(Frames left,
                                       Frames right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Frames and the right Frames.
        /// </summary>
        /// <param name="left">Left Frames.</param>
        /// <param name="right">Right Frames.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(Frames left,
                                       Frames right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Frames</returns>
        public Frames DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<Frames>(ms).Result;
        }
    }
}
