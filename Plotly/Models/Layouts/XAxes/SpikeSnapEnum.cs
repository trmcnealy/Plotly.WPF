using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Layouts.XAxes
{
    /// <summary>
    ///     Determines whether spikelines are stuck to the cursor or to the closest
    ///     datapoints.
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum SpikeSnapEnum
    {
        [EnumMember(Value=@"data")]
        Data = 0,
        [EnumMember(Value=@"cursor")]
        Cursor,
        [EnumMember(Value=@"hovered data")]
        HoveredData
    }
}