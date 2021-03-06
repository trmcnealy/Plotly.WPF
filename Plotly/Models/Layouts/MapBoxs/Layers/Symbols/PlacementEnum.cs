using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Layouts.MapBoxs.Layers.Symbols
{
    /// <summary>
    ///     Sets the symbol and/or text placement (mapbox.layer.layout.symbol-placement).
    ///     If <c>placement</c> is <c>point</c>, the label is placed where the geometry
    ///     is located If <c>placement</c> is <c>line</c>, the label is placed along
    ///     the line of the geometry If <c>placement</c> is <c>line-center</c>, the
    ///     label is placed on the center of the geometry
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum PlacementEnum
    {
        [EnumMember(Value = @"point")]
        Point = 0,

        [EnumMember(Value = @"line")]
        Line,

        [EnumMember(Value = @"line-center")]
        LineCenter
    }
}
