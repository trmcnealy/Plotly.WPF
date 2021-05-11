using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Layouts.XAxes.RangeSelectors
{
    /// <summary>
    ///     Sets the range selector&#39;s vertical position anchor This anchor binds
    ///     the <c>y</c> position to the <c>top</c>, <c>middle</c> or <c>bottom</c>
    ///     of the range selector.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum YAnchorEnum
    {
        [EnumMember(Value = @"bottom")]
        Bottom = 0,

        [EnumMember(Value = @"auto")]
        Auto,

        [EnumMember(Value = @"top")]
        Top,

        [EnumMember(Value = @"middle")]
        Middle
    }
}
