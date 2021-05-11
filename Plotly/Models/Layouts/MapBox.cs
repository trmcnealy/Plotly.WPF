using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Layouts.MapBoxs;

namespace Plotly.Models.Layouts
{
    /// <summary>
    ///     The MapBox class.
    /// </summary>
    [Serializable]
    public class MapBox : IEquatable<MapBox>
    {
        /// <summary>
        ///     Gets or sets the Domain.
        /// </summary>
        [JsonPropertyName(@"domain")]
        public Domain Domain { get; set; }

        /// <summary>
        ///     Sets the mapbox access token to be used for this mapbox map. Alternatively,
        ///     the mapbox access token can be set in the configuration options under <c>mapboxAccessToken</c>.
        ///     Note that accessToken are only required when <c>style</c> (e.g with values
        ///     : basic, streets, outdoors, light, dark, satellite, satellite-streets )
        ///     and/or a layout layer references the Mapbox server.
        /// </summary>
        [JsonPropertyName(@"accesstoken")]
        public string AccessToken { get; set; }

        /// <summary>
        ///     Defines the map layers that are rendered by default below the trace layers
        ///     defined in <c>data</c>, which are themselves by default rendered below the
        ///     layers defined in <c>layout.mapbox.layers</c>.  These layers can be defined
        ///     either explicitly as a Mapbox Style object which can contain multiple layer
        ///     definitions that load data from any public or private Tile Map Service (TMS
        ///     or XYZ) or Web Map Service (WMS) or implicitly by using one of the built-in
        ///     style objects which use WMSes which do not require any access tokens, or
        ///     by using a default Mapbox style or custom Mapbox style URL, both of which
        ///     require a Mapbox access token  Note that Mapbox access token can be set
        ///     in the <c>accesstoken</c> attribute or in the <c>mapboxAccessToken</c> config
        ///     option.  Mapbox Style objects are of the form described in the Mapbox GL
        ///     JS documentation available at https://docs.mapbox.com/mapbox-gl-js/style-spec
        ///      The built-in plotly.js styles objects are: open-street-map, white-bg, carto-positron,
        ///     carto-darkmatter, stamen-terrain, stamen-toner, stamen-watercolor  The built-in
        ///     Mapbox styles are: basic, streets, outdoors, light, dark, satellite, satellite-streets
        ///      Mapbox style URLs are of the form: mapbox://mapbox.mapbox-&lt;name&gt;-&lt;version&gt;
        /// </summary>
        [JsonPropertyName(@"style")]
        public object Style { get; set; }

        /// <summary>
        ///     Gets or sets the Center.
        /// </summary>
        [JsonPropertyName(@"center")]
        public Center Center { get; set; }

        /// <summary>
        ///     Sets the zoom level of the map (mapbox.zoom).
        /// </summary>
        [JsonPropertyName(@"zoom")]
        public JsNumber? Zoom { get; set; }

        /// <summary>
        ///     Sets the bearing angle of the map in degrees counter-clockwise from North
        ///     (mapbox.bearing).
        /// </summary>
        [JsonPropertyName(@"bearing")]
        public JsNumber? Bearing { get; set; }

        /// <summary>
        ///     Sets the pitch angle of the map (in degrees, where <c>0</c> means perpendicular
        ///     to the surface of the map) (mapbox.pitch).
        /// </summary>
        [JsonPropertyName(@"pitch")]
        public JsNumber? Pitch { get; set; }

        /// <summary>
        ///     Gets or sets the Layers.
        /// </summary>
        [JsonPropertyName(@"layers")]
        public List<Layer> Layers { get; set; }

        /// <summary>
        ///     Controls persistence of user-driven changes in the view: <c>center</c>,
        ///     <c>zoom</c>, <c>bearing</c>, <c>pitch</c>. Defaults to <c>layout.uirevision</c>.
        /// </summary>
        [JsonPropertyName(@"uirevision")]
        public object UiRevision { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is MapBox other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] MapBox other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (Domain      == other.Domain      && Domain      != null && other.Domain      != null && Domain.Equals(other.Domain))           &&
                   (AccessToken == other.AccessToken && AccessToken != null && other.AccessToken != null && AccessToken.Equals(other.AccessToken)) &&
                   (Style       == other.Style       && Style       != null && other.Style       != null && Style.Equals(other.Style))             &&
                   (Center      == other.Center      && Center      != null && other.Center      != null && Center.Equals(other.Center))           &&
                   (Zoom        == other.Zoom        && Zoom        != null && other.Zoom        != null && Zoom.Equals(other.Zoom))               &&
                   (Bearing     == other.Bearing     && Bearing     != null && other.Bearing     != null && Bearing.Equals(other.Bearing))         &&
                   (Pitch       == other.Pitch       && Pitch       != null && other.Pitch       != null && Pitch.Equals(other.Pitch))             &&
                   (Equals(Layers, other.Layers) || Layers != null && other.Layers != null && Layers.SequenceEqual(other.Layers))                  &&
                   (UiRevision == other.UiRevision && UiRevision != null && other.UiRevision != null && UiRevision.Equals(other.UiRevision));
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;

                if(Domain != null)
                    hashCode = hashCode * 59 + Domain.GetHashCode();

                if(AccessToken != null)
                    hashCode = hashCode * 59 + AccessToken.GetHashCode();

                if(Style != null)
                    hashCode = hashCode * 59 + Style.GetHashCode();

                if(Center != null)
                    hashCode = hashCode * 59 + Center.GetHashCode();

                if(Zoom != null)
                    hashCode = hashCode * 59 + Zoom.GetHashCode();

                if(Bearing != null)
                    hashCode = hashCode * 59 + Bearing.GetHashCode();

                if(Pitch != null)
                    hashCode = hashCode * 59 + Pitch.GetHashCode();

                if(Layers != null)
                    hashCode = hashCode * 59 + Layers.GetHashCode();

                if(UiRevision != null)
                    hashCode = hashCode * 59 + UiRevision.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left MapBox and the right MapBox.
        /// </summary>
        /// <param name="left">Left MapBox.</param>
        /// <param name="right">Right MapBox.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(MapBox left,
                                       MapBox right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left MapBox and the right MapBox.
        /// </summary>
        /// <param name="left">Left MapBox.</param>
        /// <param name="right">Right MapBox.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(MapBox left,
                                       MapBox right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>MapBox</returns>
        public MapBox DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<MapBox>(ms).Result;
        }
    }
}
