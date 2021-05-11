using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Layouts.Grids
{
    /// <summary>
    ///     Sets where the y axis labels and titles go. <c>left</c> means the very left
    ///     edge of the grid. &#39;left plot&#39; is the leftmost plot that each y axis
    ///     is used in. <c>right</c> and &#39;right plot&#39; are similar.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum YSideEnum
    {
        [EnumMember(Value = @"left plot")]
        LeftPlot = 0,

        [EnumMember(Value = @"left")]
        Left,

        [EnumMember(Value = @"right plot")]
        RightPlot,

        [EnumMember(Value = @"right")]
        Right
    }
}
