using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Layouts.Scenes.ZAxes
{
    /// <summary>
    ///     Determines if the axis lines or/and ticks are mirrored to the opposite side
    ///     of the plotting area. If <c>true</c>, the axis lines are mirrored. If <c>ticks</c>,
    ///     the axis lines and ticks are mirrored. If <c>false</c>, mirroring is disable.
    ///     If <c>all</c>, axis lines are mirrored on all shared-axes subplots. If <c>allticks</c>,
    ///     axis lines and ticks are mirrored on all shared-axes subplots.
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum MirrorEnum
    {
        [EnumMember(Value=@"false")]
        False = 0,
        [EnumMember(Value=@"True")]
        True,
        [EnumMember(Value=@"ticks")]
        Ticks,
        [EnumMember(Value=@"all")]
        All,
        [EnumMember(Value=@"allticks")]
        AllTicks
    }
}