using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Layouts.Titles
{
    /// <summary>
    ///     Sets the title&#39;s horizontal alignment with respect to its x position.
    ///     <c>left</c> means that the title starts at x, <c>right</c> means that the
    ///     title ends at x and <c>center</c> means that the title&#39;s center is at
    ///     x. <c>auto</c> divides <c>xref</c> by three and calculates the <c>xanchor</c>
    ///     value automatically based on the value of <c>x</c>.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum XAnchorEnum
    {
        [EnumMember(Value = @"auto")]
        Auto = 0,

        [EnumMember(Value = @"left")]
        Left,

        [EnumMember(Value = @"center")]
        Center,

        [EnumMember(Value = @"right")]
        Right
    }
}
