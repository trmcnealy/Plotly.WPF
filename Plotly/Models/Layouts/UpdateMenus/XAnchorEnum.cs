using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Layouts.UpdateMenus
{
    /// <summary>
    ///     Sets the update menu&#39;s horizontal position anchor. This anchor binds
    ///     the <c>x</c> position to the <c>left</c>, <c>center</c> or <c>right</c>
    ///     of the range selector.
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum XAnchorEnum
    {
        [EnumMember(Value=@"right")]
        Right = 0,
        [EnumMember(Value=@"auto")]
        Auto,
        [EnumMember(Value=@"left")]
        Left,
        [EnumMember(Value=@"center")]
        Center
    }
}