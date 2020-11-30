using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Layouts.Scenes.ZAxes
{
    /// <summary>
    ///     Sets the tick mode for this axis. If <c>auto</c>, the number of ticks is
    ///     set via <c>nticks</c>. If <c>linear</c>, the placement of the ticks is determined
    ///     by a starting position <c>tick0</c> and a tick step <c>dtick</c> (<c>linear</c>
    ///     is the default value if <c>tick0</c> and <c>dtick</c> are provided). If
    ///     <c>array</c>, the placement of the ticks is set via <c>tickvals</c> and
    ///     the tick text is <c>ticktext</c>. (<c>array</c> is the default value if
    ///     <c>tickvals</c> is provided).
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum TickModeEnum
    {
        [EnumMember(Value=@"auto")]
        Auto,
        [EnumMember(Value=@"linear")]
        Linear,
        [EnumMember(Value=@"array")]
        Array
    }
}