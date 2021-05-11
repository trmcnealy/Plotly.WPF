using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Layouts.Scenes
{
    /// <summary>
    ///     Determines the mode of hover interactions for this scene.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum HoverModeEnum
    {
        [EnumMember(Value = @"closest")]
        Closest = 0,

        [EnumMember(Value = @"False")]
        False
    }
}
