using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Plotly.Models.Layouts.Scenes
{
    /// <summary>
    ///     Determines the mode of drag interactions for this scene.
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum DragModeEnum
    {
        [EnumMember(Value=@"orbit")]
        Orbit,
        [EnumMember(Value=@"turntable")]
        Turntable,
        [EnumMember(Value=@"zoom")]
        Zoom,
        [EnumMember(Value=@"pan")]
        Pan,
        [EnumMember(Value=@"False")]
        False
    }
}