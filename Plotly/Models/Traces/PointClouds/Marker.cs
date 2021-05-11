using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Traces.PointClouds.Markers;

namespace Plotly.Models.Traces.PointClouds
{
    /// <summary>
    ///     The Marker class.
    /// </summary>
    [Serializable]
    public class Marker : IEquatable<Marker>
    {
        /// <summary>
        ///     Sets the marker fill color. It accepts a specific color.If the color is
        ///     not fully opaque and there are hundreds of thousandsof points, it may cause
        ///     slower zooming and panning.
        /// </summary>
        [JsonPropertyName(@"color")]
        public object Color { get; set; }

        /// <summary>
        ///     Sets the marker opacity. The default value is <c>1</c> (fully opaque). If
        ///     the markers are not fully opaque and there are hundreds of thousands of
        ///     points, it may cause slower zooming and panning. Opacity fades the color
        ///     even if <c>blend</c> is left on <c>false</c> even if there is no translucency
        ///     effect in that case.
        /// </summary>
        [JsonPropertyName(@"opacity")]
        public JsNumber? Opacity { get; set; }

        /// <summary>
        ///     Determines if colors are blended together for a translucency effect in case
        ///     <c>opacity</c> is specified as a value less then <c>1</c>. Setting <c>blend</c>
        ///     to <c>true</c> reduces zoom/pan speed if used with large numbers of points.
        /// </summary>
        [JsonPropertyName(@"blend")]
        public bool? Blend { get; set; }

        /// <summary>
        ///     Sets the minimum size (in px) of the rendered marker points, effective when
        ///     the <c>pointcloud</c> shows a million or more points.
        /// </summary>
        [JsonPropertyName(@"sizemin")]
        public JsNumber? SizeMin { get; set; }

        /// <summary>
        ///     Sets the maximum size (in px) of the rendered marker points. Effective when
        ///     the <c>pointcloud</c> shows only few points.
        /// </summary>
        [JsonPropertyName(@"sizemax")]
        public JsNumber? SizeMax { get; set; }

        /// <summary>
        ///     Gets or sets the Border.
        /// </summary>
        [JsonPropertyName(@"border")]
        public Border Border { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is Marker other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] Marker other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (Color   == other.Color   && Color   != null && other.Color   != null && Color.Equals(other.Color))     &&
                   (Opacity == other.Opacity && Opacity != null && other.Opacity != null && Opacity.Equals(other.Opacity)) &&
                   (Blend   == other.Blend   && Blend   != null && other.Blend   != null && Blend.Equals(other.Blend))     &&
                   (SizeMin == other.SizeMin && SizeMin != null && other.SizeMin != null && SizeMin.Equals(other.SizeMin)) &&
                   (SizeMax == other.SizeMax && SizeMax != null && other.SizeMax != null && SizeMax.Equals(other.SizeMax)) &&
                   (Border  == other.Border  && Border  != null && other.Border  != null && Border.Equals(other.Border));
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;

                if(Color != null)
                    hashCode = hashCode * 59 + Color.GetHashCode();

                if(Opacity != null)
                    hashCode = hashCode * 59 + Opacity.GetHashCode();

                if(Blend != null)
                    hashCode = hashCode * 59 + Blend.GetHashCode();

                if(SizeMin != null)
                    hashCode = hashCode * 59 + SizeMin.GetHashCode();

                if(SizeMax != null)
                    hashCode = hashCode * 59 + SizeMax.GetHashCode();

                if(Border != null)
                    hashCode = hashCode * 59 + Border.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Marker and the right Marker.
        /// </summary>
        /// <param name="left">Left Marker.</param>
        /// <param name="right">Right Marker.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(Marker left,
                                       Marker right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Marker and the right Marker.
        /// </summary>
        /// <param name="left">Left Marker.</param>
        /// <param name="right">Right Marker.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(Marker left,
                                       Marker right)
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
