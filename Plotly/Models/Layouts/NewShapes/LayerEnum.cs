using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Layouts.NewShapes
{
    /// <summary>
    ///     Specifies whether new shapes are drawn below or above traces.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum LayerEnum
    {
        [EnumMember(Value = @"above")]
        Above = 0,

        [EnumMember(Value = @"below")]
        Below
    }
}
