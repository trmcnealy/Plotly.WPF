using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.Waterfalls
{
    /// <summary>
    ///     Specifies the location of the <c>text</c>. <c>inside</c> positions <c>text</c>
    ///     inside, next to the bar end (rotated and scaled if needed). <c>outside</c>
    ///     positions <c>text</c> outside, next to the bar end (scaled if needed), unless
    ///     there is another bar stacked on this one, then the text gets pushed inside.
    ///     <c>auto</c> tries to position <c>text</c> inside the bar, but if the bar
    ///     is too small and no bar is stacked on this one the text is moved outside.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum TextPositionEnum
    {
        [EnumMember(Value = @"none")]
        None = 0,

        [EnumMember(Value = @"inside")]
        Inside,

        [EnumMember(Value = @"outside")]
        Outside,

        [EnumMember(Value = @"auto")]
        Auto
    }
}
