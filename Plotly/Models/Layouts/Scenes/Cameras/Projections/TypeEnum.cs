using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Layouts.Scenes.Cameras.Projections
{
    /// <summary>
    ///     Sets the projection type. The projection type could be either <c>perspective</c>
    ///     or <c>orthographic</c>. The default is <c>perspective</c>.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum TypeEnum
    {
        [EnumMember(Value = @"perspective")]
        Perspective = 0,

        [EnumMember(Value = @"orthographic")]
        Orthographic
    }
}
