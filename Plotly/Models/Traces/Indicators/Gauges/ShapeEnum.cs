using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.Indicators.Gauges
{
    /// <summary>
    ///     Set the shape of the gauge
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum ShapeEnum
    {
        [EnumMember(Value = @"angular")]
        Angular = 0,

        [EnumMember(Value = @"bullet")]
        Bullet
    }
}
