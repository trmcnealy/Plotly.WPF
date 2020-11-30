using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Layouts.Geos;

namespace Plotly.Models.Layouts
{
    /// <summary>
    ///     The Geo class.
    /// </summary>
    
    [Serializable]
    public class Geo : IEquatable<Geo>
    {
        /// <summary>
        ///     Gets or sets the Domain.
        /// </summary>
        [JsonPropertyName(@"domain")]
        public Domain Domain { get; set;} 

        /// <summary>
        ///     Determines if this subplot&#39;s view settings are auto-computed to fit
        ///     trace data. On scoped maps, setting <c>fitbounds</c> leads to <c>center.lon</c>
        ///     and <c>center.lat</c> getting auto-filled. On maps with a non-clipped projection,
        ///     setting <c>fitbounds</c> leads to <c>center.lon</c>, <c>center.lat</c>,
        ///     and <c>projection.rotation.lon</c> getting auto-filled. On maps with a clipped
        ///     projection, setting <c>fitbounds</c> leads to <c>center.lon</c>, <c>center.lat</c>,
        ///     <c>projection.rotation.lon</c>, <c>projection.rotation.lat</c>, <c>lonaxis.range</c>
        ///     and <c>lonaxis.range</c> getting auto-filled. If <c>locations</c>, only
        ///     the trace&#39;s visible locations are considered in the <c>fitbounds</c>
        ///     computations. If <c>geojson</c>, the entire trace input <c>geojson</c> (if
        ///     provided) is considered in the <c>fitbounds</c> computations, Defaults to
        ///     <c>false</c>.
        /// </summary>
        [JsonPropertyName(@"fitbounds")]
        public FitBoundsEnum? FitBounds { get; set;} 

        /// <summary>
        ///     Sets the resolution of the base layers. The values have units of km/mm e.g.
        ///     110 corresponds to a scale ratio of 1:110,000,000.
        /// </summary>
        [JsonPropertyName(@"resolution")]
        public ResolutionEnum? Resolution { get; set;} 

        /// <summary>
        ///     Set the scope of the map.
        /// </summary>
        [JsonPropertyName(@"scope")]
        public ScopeEnum? Scope { get; set;} 

        /// <summary>
        ///     Gets or sets the Projection.
        /// </summary>
        [JsonPropertyName(@"projection")]
        public Projection Projection { get; set;} 

        /// <summary>
        ///     Gets or sets the Center.
        /// </summary>
        [JsonPropertyName(@"center")]
        public Center Center { get; set;} 

        /// <summary>
        ///     Sets the default visibility of the base layers.
        /// </summary>
        [JsonPropertyName(@"visible")]
        public bool? Visible { get; set;} 

        /// <summary>
        ///     Sets whether or not the coastlines are drawn.
        /// </summary>
        [JsonPropertyName(@"showcoastlines")]
        public bool? ShowCoastlines { get; set;} 

        /// <summary>
        ///     Sets the coastline color.
        /// </summary>
        [JsonPropertyName(@"coastlinecolor")]
        public object CoastlineColor { get; set;} 

        /// <summary>
        ///     Sets the coastline stroke width (in px).
        /// </summary>
        [JsonPropertyName(@"coastlinewidth")]
        public JsNumber? CoastlineWidth { get; set;} 

        /// <summary>
        ///     Sets whether or not land masses are filled in color.
        /// </summary>
        [JsonPropertyName(@"showland")]
        public bool? ShowLand { get; set;} 

        /// <summary>
        ///     Sets the land mass color.
        /// </summary>
        [JsonPropertyName(@"landcolor")]
        public object LandColor { get; set;} 

        /// <summary>
        ///     Sets whether or not oceans are filled in color.
        /// </summary>
        [JsonPropertyName(@"showocean")]
        public bool? ShowOcean { get; set;} 

        /// <summary>
        ///     Sets the ocean color
        /// </summary>
        [JsonPropertyName(@"oceancolor")]
        public object OceanColor { get; set;} 

        /// <summary>
        ///     Sets whether or not lakes are drawn.
        /// </summary>
        [JsonPropertyName(@"showlakes")]
        public bool? ShowLakes { get; set;} 

        /// <summary>
        ///     Sets the color of the lakes.
        /// </summary>
        [JsonPropertyName(@"lakecolor")]
        public object LakeColor { get; set;} 

        /// <summary>
        ///     Sets whether or not rivers are drawn.
        /// </summary>
        [JsonPropertyName(@"showrivers")]
        public bool? ShowRivers { get; set;} 

        /// <summary>
        ///     Sets color of the rivers.
        /// </summary>
        [JsonPropertyName(@"rivercolor")]
        public object RiverColor { get; set;} 

        /// <summary>
        ///     Sets the stroke width (in px) of the rivers.
        /// </summary>
        [JsonPropertyName(@"riverwidth")]
        public JsNumber? RiverWidth { get; set;} 

        /// <summary>
        ///     Sets whether or not country boundaries are drawn.
        /// </summary>
        [JsonPropertyName(@"showcountries")]
        public bool? ShowCountries { get; set;} 

        /// <summary>
        ///     Sets line color of the country boundaries.
        /// </summary>
        [JsonPropertyName(@"countrycolor")]
        public object CountryColor { get; set;} 

        /// <summary>
        ///     Sets line width (in px) of the country boundaries.
        /// </summary>
        [JsonPropertyName(@"countrywidth")]
        public JsNumber? CountryWidth { get; set;} 

        /// <summary>
        ///     Sets whether or not boundaries of subunits within countries (e.g. states,
        ///     provinces) are drawn.
        /// </summary>
        [JsonPropertyName(@"showsubunits")]
        public bool? ShowSubUnits { get; set;} 

        /// <summary>
        ///     Sets the color of the subunits boundaries.
        /// </summary>
        [JsonPropertyName(@"subunitcolor")]
        public object SubUnitColor { get; set;} 

        /// <summary>
        ///     Sets the stroke width (in px) of the subunits boundaries.
        /// </summary>
        [JsonPropertyName(@"subunitwidth")]
        public JsNumber? SubUnitWidth { get; set;} 

        /// <summary>
        ///     Sets whether or not a frame is drawn around the map.
        /// </summary>
        [JsonPropertyName(@"showframe")]
        public bool? ShowFrame { get; set;} 

        /// <summary>
        ///     Sets the color the frame.
        /// </summary>
        [JsonPropertyName(@"framecolor")]
        public object FrameColor { get; set;} 

        /// <summary>
        ///     Sets the stroke width (in px) of the frame.
        /// </summary>
        [JsonPropertyName(@"framewidth")]
        public JsNumber? FrameWidth { get; set;} 

        /// <summary>
        ///     Set the background color of the map
        /// </summary>
        [JsonPropertyName(@"bgcolor")]
        public object BgColor { get; set;} 

        /// <summary>
        ///     Gets or sets the LonAxis.
        /// </summary>
        [JsonPropertyName(@"lonaxis")]
        public LonAxis LonAxis { get; set;} 

        /// <summary>
        ///     Gets or sets the LaTaxis.
        /// </summary>
        [JsonPropertyName(@"lataxis")]
        public LaTaxis LaTaxis { get; set;} 

        /// <summary>
        ///     Controls persistence of user-driven changes in the view (projection and
        ///     center). Defaults to <c>layout.uirevision</c>.
        /// </summary>
        [JsonPropertyName(@"uirevision")]
        public object UiRevision { get; set;} 

        
        public override bool Equals(object obj)
        {
            if (!(obj is Geo other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        
        public bool Equals([AllowNull] Geo other)
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
                    FitBounds == other.FitBounds &&
                    FitBounds != null && other.FitBounds != null &&
                    FitBounds.Equals(other.FitBounds)
                ) && 
                (
                    Resolution == other.Resolution &&
                    Resolution != null && other.Resolution != null &&
                    Resolution.Equals(other.Resolution)
                ) && 
                (
                    Scope == other.Scope &&
                    Scope != null && other.Scope != null &&
                    Scope.Equals(other.Scope)
                ) && 
                (
                    Projection == other.Projection &&
                    Projection != null && other.Projection != null &&
                    Projection.Equals(other.Projection)
                ) && 
                (
                    Center == other.Center &&
                    Center != null && other.Center != null &&
                    Center.Equals(other.Center)
                ) && 
                (
                    Visible == other.Visible &&
                    Visible != null && other.Visible != null &&
                    Visible.Equals(other.Visible)
                ) && 
                (
                    ShowCoastlines == other.ShowCoastlines &&
                    ShowCoastlines != null && other.ShowCoastlines != null &&
                    ShowCoastlines.Equals(other.ShowCoastlines)
                ) && 
                (
                    CoastlineColor == other.CoastlineColor &&
                    CoastlineColor != null && other.CoastlineColor != null &&
                    CoastlineColor.Equals(other.CoastlineColor)
                ) && 
                (
                    CoastlineWidth == other.CoastlineWidth &&
                    CoastlineWidth != null && other.CoastlineWidth != null &&
                    CoastlineWidth.Equals(other.CoastlineWidth)
                ) && 
                (
                    ShowLand == other.ShowLand &&
                    ShowLand != null && other.ShowLand != null &&
                    ShowLand.Equals(other.ShowLand)
                ) && 
                (
                    LandColor == other.LandColor &&
                    LandColor != null && other.LandColor != null &&
                    LandColor.Equals(other.LandColor)
                ) && 
                (
                    ShowOcean == other.ShowOcean &&
                    ShowOcean != null && other.ShowOcean != null &&
                    ShowOcean.Equals(other.ShowOcean)
                ) && 
                (
                    OceanColor == other.OceanColor &&
                    OceanColor != null && other.OceanColor != null &&
                    OceanColor.Equals(other.OceanColor)
                ) && 
                (
                    ShowLakes == other.ShowLakes &&
                    ShowLakes != null && other.ShowLakes != null &&
                    ShowLakes.Equals(other.ShowLakes)
                ) && 
                (
                    LakeColor == other.LakeColor &&
                    LakeColor != null && other.LakeColor != null &&
                    LakeColor.Equals(other.LakeColor)
                ) && 
                (
                    ShowRivers == other.ShowRivers &&
                    ShowRivers != null && other.ShowRivers != null &&
                    ShowRivers.Equals(other.ShowRivers)
                ) && 
                (
                    RiverColor == other.RiverColor &&
                    RiverColor != null && other.RiverColor != null &&
                    RiverColor.Equals(other.RiverColor)
                ) && 
                (
                    RiverWidth == other.RiverWidth &&
                    RiverWidth != null && other.RiverWidth != null &&
                    RiverWidth.Equals(other.RiverWidth)
                ) && 
                (
                    ShowCountries == other.ShowCountries &&
                    ShowCountries != null && other.ShowCountries != null &&
                    ShowCountries.Equals(other.ShowCountries)
                ) && 
                (
                    CountryColor == other.CountryColor &&
                    CountryColor != null && other.CountryColor != null &&
                    CountryColor.Equals(other.CountryColor)
                ) && 
                (
                    CountryWidth == other.CountryWidth &&
                    CountryWidth != null && other.CountryWidth != null &&
                    CountryWidth.Equals(other.CountryWidth)
                ) && 
                (
                    ShowSubUnits == other.ShowSubUnits &&
                    ShowSubUnits != null && other.ShowSubUnits != null &&
                    ShowSubUnits.Equals(other.ShowSubUnits)
                ) && 
                (
                    SubUnitColor == other.SubUnitColor &&
                    SubUnitColor != null && other.SubUnitColor != null &&
                    SubUnitColor.Equals(other.SubUnitColor)
                ) && 
                (
                    SubUnitWidth == other.SubUnitWidth &&
                    SubUnitWidth != null && other.SubUnitWidth != null &&
                    SubUnitWidth.Equals(other.SubUnitWidth)
                ) && 
                (
                    ShowFrame == other.ShowFrame &&
                    ShowFrame != null && other.ShowFrame != null &&
                    ShowFrame.Equals(other.ShowFrame)
                ) && 
                (
                    FrameColor == other.FrameColor &&
                    FrameColor != null && other.FrameColor != null &&
                    FrameColor.Equals(other.FrameColor)
                ) && 
                (
                    FrameWidth == other.FrameWidth &&
                    FrameWidth != null && other.FrameWidth != null &&
                    FrameWidth.Equals(other.FrameWidth)
                ) && 
                (
                    BgColor == other.BgColor &&
                    BgColor != null && other.BgColor != null &&
                    BgColor.Equals(other.BgColor)
                ) && 
                (
                    LonAxis == other.LonAxis &&
                    LonAxis != null && other.LonAxis != null &&
                    LonAxis.Equals(other.LonAxis)
                ) && 
                (
                    LaTaxis == other.LaTaxis &&
                    LaTaxis != null && other.LaTaxis != null &&
                    LaTaxis.Equals(other.LaTaxis)
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
                if (FitBounds != null) hashCode = hashCode * 59 + FitBounds.GetHashCode();
                if (Resolution != null) hashCode = hashCode * 59 + Resolution.GetHashCode();
                if (Scope != null) hashCode = hashCode * 59 + Scope.GetHashCode();
                if (Projection != null) hashCode = hashCode * 59 + Projection.GetHashCode();
                if (Center != null) hashCode = hashCode * 59 + Center.GetHashCode();
                if (Visible != null) hashCode = hashCode * 59 + Visible.GetHashCode();
                if (ShowCoastlines != null) hashCode = hashCode * 59 + ShowCoastlines.GetHashCode();
                if (CoastlineColor != null) hashCode = hashCode * 59 + CoastlineColor.GetHashCode();
                if (CoastlineWidth != null) hashCode = hashCode * 59 + CoastlineWidth.GetHashCode();
                if (ShowLand != null) hashCode = hashCode * 59 + ShowLand.GetHashCode();
                if (LandColor != null) hashCode = hashCode * 59 + LandColor.GetHashCode();
                if (ShowOcean != null) hashCode = hashCode * 59 + ShowOcean.GetHashCode();
                if (OceanColor != null) hashCode = hashCode * 59 + OceanColor.GetHashCode();
                if (ShowLakes != null) hashCode = hashCode * 59 + ShowLakes.GetHashCode();
                if (LakeColor != null) hashCode = hashCode * 59 + LakeColor.GetHashCode();
                if (ShowRivers != null) hashCode = hashCode * 59 + ShowRivers.GetHashCode();
                if (RiverColor != null) hashCode = hashCode * 59 + RiverColor.GetHashCode();
                if (RiverWidth != null) hashCode = hashCode * 59 + RiverWidth.GetHashCode();
                if (ShowCountries != null) hashCode = hashCode * 59 + ShowCountries.GetHashCode();
                if (CountryColor != null) hashCode = hashCode * 59 + CountryColor.GetHashCode();
                if (CountryWidth != null) hashCode = hashCode * 59 + CountryWidth.GetHashCode();
                if (ShowSubUnits != null) hashCode = hashCode * 59 + ShowSubUnits.GetHashCode();
                if (SubUnitColor != null) hashCode = hashCode * 59 + SubUnitColor.GetHashCode();
                if (SubUnitWidth != null) hashCode = hashCode * 59 + SubUnitWidth.GetHashCode();
                if (ShowFrame != null) hashCode = hashCode * 59 + ShowFrame.GetHashCode();
                if (FrameColor != null) hashCode = hashCode * 59 + FrameColor.GetHashCode();
                if (FrameWidth != null) hashCode = hashCode * 59 + FrameWidth.GetHashCode();
                if (BgColor != null) hashCode = hashCode * 59 + BgColor.GetHashCode();
                if (LonAxis != null) hashCode = hashCode * 59 + LonAxis.GetHashCode();
                if (LaTaxis != null) hashCode = hashCode * 59 + LaTaxis.GetHashCode();
                if (UiRevision != null) hashCode = hashCode * 59 + UiRevision.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Geo and the right Geo.
        /// </summary>
        /// <param name="left">Left Geo.</param>
        /// <param name="right">Right Geo.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (Geo left, Geo right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Geo and the right Geo.
        /// </summary>
        /// <param name="left">Left Geo.</param>
        /// <param name="right">Right Geo.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (Geo left, Geo right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Geo</returns>
        public Geo DeepClone()
        {
            using MemoryStream ms = new();
            
            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;
            return JsonSerializer.DeserializeAsync<Geo>(ms).Result;
        }
    }
}