using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Layouts.Images
{
    /// <summary>
    ///     Specifies whether images are drawn below or above traces. When <c>xref</c>
    ///     and <c>yref</c> are both set to <c>paper</c>, image is drawn below the entire
    ///     plot area.
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
