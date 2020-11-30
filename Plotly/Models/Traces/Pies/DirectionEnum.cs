using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Plotly.Models.Traces.Pies
{
    /// <summary>
    ///     Specifies the direction at which succeeding sectors follow one another.
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum DirectionEnum
    {
        [EnumMember(Value=@"counterclockwise")]
        Counterclockwise = 0,
        [EnumMember(Value=@"clockwise")]
        Clockwise
    }
}