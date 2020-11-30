using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Layouts.MapBoxs.Layers
{
    /// <summary>
    ///     Sets the layer type, that is the how the layer data set in <c>source</c>
    ///     will be rendered With <c>sourcetype</c> set to <c>geojson</c>, the following
    ///     values are allowed: <c>circle</c>, <c>line</c>, <c>fill</c> and <c>symbol</c>.
    ///     but note that <c>line</c> and <c>fill</c> are not compatible with Point
    ///     GeoJSON geometries. With <c>sourcetype</c> set to <c>vector</c>, the following
    ///     values are allowed:  <c>circle</c>, <c>line</c>, <c>fill</c> and <c>symbol</c>.
    ///     With <c>sourcetype</c> set to <c>raster</c> or <c><c>image</c></c>, only
    ///     the <c>raster</c> value is allowed.
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum TypeEnum
    {
        [EnumMember(Value=@"circle")]
        Circle = 0,
        [EnumMember(Value=@"line")]
        Line,
        [EnumMember(Value=@"fill")]
        Fill,
        [EnumMember(Value=@"symbol")]
        Symbol,
        [EnumMember(Value=@"raster")]
        Raster
    }
}