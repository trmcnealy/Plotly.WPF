using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.FunnelAreas.Titles
{
    /// <summary>
    ///     Specifies the location of the <c>title</c>. Note that the title&#39;s position
    ///     used to be set by the now deprecated <c>titleposition</c> attribute.
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum PositionEnum
    {
        [EnumMember(Value=@"top center")]
        TopCenter = 0,
        [EnumMember(Value=@"top left")]
        TopLeft,
        [EnumMember(Value=@"top right")]
        TopRight
    }
}