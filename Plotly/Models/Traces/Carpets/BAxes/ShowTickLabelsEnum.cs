using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.Carpets.BAxes
{
    /// <summary>
    ///     Determines whether axis labels are drawn on the low side, the high side,
    ///     both, or neither side of the axis.
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum ShowTickLabelsEnum
    {
        [EnumMember(Value=@"start")]
        Start = 0,
        [EnumMember(Value=@"end")]
        End,
        [EnumMember(Value=@"both")]
        Both,
        [EnumMember(Value=@"none")]
        None
    }
}