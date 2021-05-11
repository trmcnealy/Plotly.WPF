using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.Choropleths
{
    /// <summary>
    ///     Determines the set of locations used to match entries in <c>locations</c>
    ///     to regions on the map. Values <c>ISO-3</c>, <c>USA-states</c>, &#39;country
    ///     names&#39; correspond to features on the base map and value <c>geojson-id</c>
    ///     corresponds to features from a custom GeoJSON linked to the <c>geojson</c>
    ///     attribute.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum LocationModeEnum
    {
        [EnumMember(Value = @"iso-3")]
        ISO3 = 0,

        [EnumMember(Value = @"USA-states")]
        USAStates,

        [EnumMember(Value = @"country names")]
        CountryNames,

        [EnumMember(Value = @"geojson-id")]
        GeoJsonId
    }
}
