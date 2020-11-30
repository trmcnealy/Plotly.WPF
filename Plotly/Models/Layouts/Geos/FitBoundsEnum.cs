using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Layouts.Geos
{
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
    
    [JsonConverter(typeof(EnumConverter))]
    public enum FitBoundsEnum
    {
        [EnumMember(Value=@"false")]
        False = 0,
        [EnumMember(Value=@"locations")]
        Locations,
        [EnumMember(Value=@"geojson")]
        GeoJson
    }
}