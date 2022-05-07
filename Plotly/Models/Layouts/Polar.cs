using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Layouts.Polars;

namespace Plotly.Models.Layouts
{
    /// <summary>
    ///     The Polar class.
    /// </summary>
    [Serializable]
    public class Polar : IEquatable<Polar>
    {
        /// <summary>
        ///     Gets or sets the Domain.
        /// </summary>
        [JsonPropertyName(@"domain")]
        public Domain? Domain { get; set; }

        /// <summary>
        ///     Sets angular span of this polar subplot with two angles (in degrees). Sector
        ///     are assumed to be spanned in the counterclockwise direction with <c>0</c>
        ///     corresponding to rightmost limit of the polar subplot.
        /// </summary>
        [JsonPropertyName(@"sector")]
        public List<object>? Sector { get; set; }

        /// <summary>
        ///     Sets the fraction of the radius to cut out of the polar subplot.
        /// </summary>
        [JsonPropertyName(@"hole")]
        public JsNumber? Hole { get; set; }

        /// <summary>
        ///     Set the background color of the subplot
        /// </summary>
        [JsonPropertyName(@"bgcolor")]
        public object? BgColor { get; set; }

        /// <summary>
        ///     Gets or sets the RadialAxis.
        /// </summary>
        [JsonPropertyName(@"radialaxis")]
        public Polars.RadialAxis? RadialAxis { get; set; }

        /// <summary>
        ///     Gets or sets the AngularAxis.
        /// </summary>
        [JsonPropertyName(@"angularaxis")]
        public Polars.AngularAxis? AngularAxis { get; set; }

        /// <summary>
        ///     Determines if the radial axis grid lines and angular axis line are drawn
        ///     as <c>circular</c> sectors or as <c>linear</c> (polygon) sectors. Has an
        ///     effect only when the angular axis has <c>type</c> <c>category</c>. Note
        ///     that <c>radialaxis.angle</c> is snapped to the angle of the closest vertex
        ///     when <c>gridshape</c> is <c>circular</c> (so that radial axis scale is the
        ///     same as the data scale).
        /// </summary>
        [JsonPropertyName(@"gridshape")]
        public GridShapeEnum? GridShape { get; set; }

        /// <summary>
        ///     Controls persistence of user-driven changes in axis attributes, if not overridden
        ///     in the individual axes. Defaults to <c>layout.uirevision</c>.
        /// </summary>
        [JsonPropertyName(@"uirevision")]
        public object? UiRevision { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is Polar other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] Polar other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (Domain == other.Domain && Domain != null && other.Domain != null && Domain.Equals(other.Domain))                               &&
                   (Equals(Sector, other.Sector) || Sector != null && other.Sector != null && Sector.SequenceEqual(other.Sector))                  &&
                   (Hole        == other.Hole        && Hole        != null && other.Hole        != null && Hole.Equals(other.Hole))               &&
                   (BgColor     == other.BgColor     && BgColor     != null && other.BgColor     != null && BgColor.Equals(other.BgColor))         &&
                   (RadialAxis  == other.RadialAxis  && RadialAxis  != null && other.RadialAxis  != null && RadialAxis.Equals(other.RadialAxis))   &&
                   (AngularAxis == other.AngularAxis && AngularAxis != null && other.AngularAxis != null && AngularAxis.Equals(other.AngularAxis)) &&
                   (GridShape   == other.GridShape   && GridShape   != null && other.GridShape   != null && GridShape.Equals(other.GridShape))     &&
                   (UiRevision  == other.UiRevision  && UiRevision  != null && other.UiRevision  != null && UiRevision.Equals(other.UiRevision));
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;

                if(Domain != null)
                    hashCode = hashCode * 59 + Domain.GetHashCode();

                if(Sector != null)
                    hashCode = hashCode * 59 + Sector.GetHashCode();

                if(Hole != null)
                    hashCode = hashCode * 59 + Hole.GetHashCode();

                if(BgColor != null)
                    hashCode = hashCode * 59 + BgColor.GetHashCode();

                if(RadialAxis != null)
                    hashCode = hashCode * 59 + RadialAxis.GetHashCode();

                if(AngularAxis != null)
                    hashCode = hashCode * 59 + AngularAxis.GetHashCode();

                if(GridShape != null)
                    hashCode = hashCode * 59 + GridShape.GetHashCode();

                if(UiRevision != null)
                    hashCode = hashCode * 59 + UiRevision.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Polar and the right Polar.
        /// </summary>
        /// <param name="left">Left Polar.</param>
        /// <param name="right">Right Polar.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(Polar left,
                                       Polar right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Polar and the right Polar.
        /// </summary>
        /// <param name="left">Left Polar.</param>
        /// <param name="right">Right Polar.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(Polar left,
                                       Polar right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Polar</returns>
        public Polar DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<Polar>(ms).Result;
        }
    }
}
