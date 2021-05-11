using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Plotly.Models.Traces.Indicators.Titles
{
    /// <summary>
    ///     Sets the horizontal alignment of the title. It defaults to <c>center</c>
    ///     except for bullet charts for which it defaults to right.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum AlignEnum
    {
        [EnumMember(Value = @"left")]
        Left,

        [EnumMember(Value = @"center")]
        Center,

        [EnumMember(Value = @"right")]
        Right
    }
}
