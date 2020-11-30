using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.Pies.Titles
{
    /// <summary>
    ///     Specifies the location of the <c>title</c>. Note that the title&#39;s position
    ///     used to be set by the now deprecated <c>titleposition</c> attribute.
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum PositionEnum
    {
        [EnumMember(Value=@"top left")]
        TopLeft,
        [EnumMember(Value=@"top center")]
        TopCenter,
        [EnumMember(Value=@"top right")]
        TopRight,
        [EnumMember(Value=@"middle center")]
        MiddleCenter,
        [EnumMember(Value=@"bottom left")]
        BottomLeft,
        [EnumMember(Value=@"bottom center")]
        BottomCenter,
        [EnumMember(Value=@"bottom right")]
        BottomRight
    }
}