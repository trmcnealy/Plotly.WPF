using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Plotly.Models.Layouts.YAxes
{
    /// <summary>
    ///     If this axis needs to be compressed (either due to its own <c>scaleanchor</c>
    ///     and <c>scaleratio</c> or those of the other axis), determines which direction
    ///     we push the originally specified plot area. Options are <c>left</c>, <c>center</c>
    ///     (default), and <c>right</c> for x axes, and <c>top</c>, <c>middle</c> (default),
    ///     and <c>bottom</c> for y axes.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum ConstrainTowardEnum
    {
        [EnumMember(Value = @"left")]
        Left,

        [EnumMember(Value = @"center")]
        Center,

        [EnumMember(Value = @"right")]
        Right,

        [EnumMember(Value = @"top")]
        Top,

        [EnumMember(Value = @"middle")]
        Middle,

        [EnumMember(Value = @"bottom")]
        Bottom
    }
}
