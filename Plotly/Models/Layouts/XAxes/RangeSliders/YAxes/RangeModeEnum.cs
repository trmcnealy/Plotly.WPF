using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Layouts.XAxes.RangeSliders.YAxes
{
    /// <summary>
    ///     Determines whether or not the range of this axis in the rangeslider use
    ///     the same value than in the main plot when zooming in/out. If <c>auto</c>,
    ///     the autorange will be used. If <c>fixed</c>, the <c>range</c> is used. If
    ///     <c>match</c>, the current range of the corresponding y-axis on the main
    ///     subplot is used.
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum RangeModeEnum
    {
        [EnumMember(Value=@"match")]
        Match = 0,
        [EnumMember(Value=@"auto")]
        Auto,
        [EnumMember(Value=@"fixed")]
        Fixed
    }
}