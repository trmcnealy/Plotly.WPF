using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.TreeMaps
{
    /// <summary>
    ///     Sets the positions of the <c>text</c> elements.
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum TextPositionEnum
    {
        [EnumMember(Value=@"top left")]
        TopLeft = 0,
        [EnumMember(Value=@"top center")]
        TopCenter,
        [EnumMember(Value=@"top right")]
        TopRight,
        [EnumMember(Value=@"middle left")]
        MiddleLeft,
        [EnumMember(Value=@"middle center")]
        MiddleCenter,
        [EnumMember(Value=@"middle right")]
        MiddleRight,
        [EnumMember(Value=@"bottom left")]
        BottomLeft,
        [EnumMember(Value=@"bottom center")]
        BottomCenter,
        [EnumMember(Value=@"bottom right")]
        BottomRight
    }
}