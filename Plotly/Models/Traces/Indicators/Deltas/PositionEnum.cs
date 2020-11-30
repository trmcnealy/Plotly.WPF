using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.Indicators.Deltas
{
    /// <summary>
    ///     Sets the position of delta with respect to the number.
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum PositionEnum
    {
        [EnumMember(Value=@"bottom")]
        Bottom = 0,
        [EnumMember(Value=@"top")]
        Top,
        [EnumMember(Value=@"left")]
        Left,
        [EnumMember(Value=@"right")]
        Right
    }
}