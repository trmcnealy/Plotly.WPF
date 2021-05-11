using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Layouts.MapBoxs.Layers
{
    /// <summary>
    ///     Sets the source type for this layer, that is the type of the layer data.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum SourceTypeEnum
    {
        [EnumMember(Value = @"geojson")]
        GeoJson = 0,

        [EnumMember(Value = @"vector")]
        Vector,

        [EnumMember(Value = @"raster")]
        Raster,

        [EnumMember(Value = @"image")]
        Image
    }
}
