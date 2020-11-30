using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Plotly.Models.Configs
{
    /// <summary>
    ///     Determines the mode bar display mode. If <c>true</c>, the mode bar is always
    ///     visible. If <c>false</c>, the mode bar is always hidden. If <c>hover</c>,
    ///     the mode bar is visible while the mouse cursor is on the graph container.
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum DisplayModeBarEnum
    {
        [EnumMember(Value=@"hover")]
        Hover = 0,
        [EnumMember(Value=@"True")]
        True,
        [EnumMember(Value=@"False")]
        False
    }
}