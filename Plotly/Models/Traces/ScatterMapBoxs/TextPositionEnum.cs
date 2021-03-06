using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.ScatterMapBoxs
{
    /// <summary>
    ///     Sets the positions of the <c>text</c> elements with respects to the (x,y)
    ///     coordinates.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum TextPositionEnum
    {
        [EnumMember(Value = @"middle center")]
        MiddleCenter = 0,

        [EnumMember(Value = @"top left")]
        TopLeft,

        [EnumMember(Value = @"top center")]
        TopCenter,

        [EnumMember(Value = @"top right")]
        TopRight,

        [EnumMember(Value = @"middle left")]
        MiddleLeft,

        [EnumMember(Value = @"middle right")]
        MiddleRight,

        [EnumMember(Value = @"bottom left")]
        BottomLeft,

        [EnumMember(Value = @"bottom center")]
        BottomCenter,

        [EnumMember(Value = @"bottom right")]
        BottomRight
    }
}
