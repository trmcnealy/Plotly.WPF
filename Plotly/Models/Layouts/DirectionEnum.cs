using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Plotly.Models.Layouts
{
    /// <summary>
    ///     Legacy polar charts are deprecated! Please switch to <c>polar</c> subplots.
    ///     Sets the direction corresponding to positive angles in legacy polar charts.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum DirectionEnum
    {
        [EnumMember(Value = @"clockwise")]
        Clockwise,

        [EnumMember(Value = @"counterclockwise")]
        Counterclockwise
    }
}
