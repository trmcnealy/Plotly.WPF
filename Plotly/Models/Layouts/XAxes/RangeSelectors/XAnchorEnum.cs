using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Layouts.XAxes.RangeSelectors
{
    /// <summary>
    ///     Sets the range selector&#39;s horizontal position anchor. This anchor binds
    ///     the <c>x</c> position to the <c>left</c>, <c>center</c> or <c>right</c>
    ///     of the range selector.
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum XAnchorEnum
    {
        [EnumMember(Value=@"left")]
        Left = 0,
        [EnumMember(Value=@"auto")]
        Auto,
        [EnumMember(Value=@"center")]
        Center,
        [EnumMember(Value=@"right")]
        Right
    }
}