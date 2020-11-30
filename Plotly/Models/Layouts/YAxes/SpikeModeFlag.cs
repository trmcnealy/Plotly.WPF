using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Layouts.YAxes
{
    /// <summary>
    ///     Determines the drawing mode for the spike line If <c>toaxis</c>, the line
    ///     is drawn from the data point to the axis the  series is plotted on. If <c>across</c>,
    ///     the line is drawn across the entire plot area, and supercedes <c>toaxis</c>.
    ///     If <c>marker</c>, then a marker dot is drawn on the axis the series is plotted
    ///     on
    /// </summary>
    
    [Flags]
    [JsonConverter(typeof(EnumConverter))]
    public enum SpikeModeFlag
    {
        [EnumMember(Value=@"toaxis")]
        ToAxis = 0,
        [EnumMember(Value=@"across")]
        Across = 1,
        [EnumMember(Value=@"marker")]
        Marker = 2
    }
}