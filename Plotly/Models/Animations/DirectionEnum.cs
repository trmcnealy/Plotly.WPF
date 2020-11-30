using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Plotly.Models.Animations
{
    /// <summary>
    ///     The direction in which to play the frames triggered by the animation call
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum DirectionEnum
    {
        [EnumMember(Value=@"forward")]
        Forward = 0,
        [EnumMember(Value=@"reverse")]
        Reverse
    }
}