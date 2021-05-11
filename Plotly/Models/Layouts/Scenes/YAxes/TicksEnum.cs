using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Layouts.Scenes.YAxes
{
    /// <summary>
    ///     Determines whether ticks are drawn or not. If **, this axis&#39; ticks are
    ///     not drawn. If <c>outside</c> (<c>inside</c>), this axis&#39; are drawn outside
    ///     (inside) the axis lines.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum TicksEnum
    {
        [EnumMember(Value = @"outside")]
        Outside,

        [EnumMember(Value = @"inside")]
        Inside,

        [EnumMember(Value = @"")]
        Empty
    }
}
