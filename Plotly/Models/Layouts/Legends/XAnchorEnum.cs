using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Layouts.Legends
{
    /// <summary>
    ///     Sets the legend&#39;s horizontal position anchor. This anchor binds the
    ///     <c>x</c> position to the <c>left</c>, <c>center</c> or <c>right</c> of the
    ///     legend. Value <c>auto</c> anchors legends to the right for <c>x</c> values
    ///     greater than or equal to 2/3, anchors legends to the left for <c>x</c> values
    ///     less than or equal to 1/3 and anchors legends with respect to their center
    ///     otherwise.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum XAnchorEnum
    {
        [EnumMember(Value = @"left")]
        Left = 0,

        [EnumMember(Value = @"auto")]
        Auto,

        [EnumMember(Value = @"center")]
        Center,

        [EnumMember(Value = @"right")]
        Right
    }
}
