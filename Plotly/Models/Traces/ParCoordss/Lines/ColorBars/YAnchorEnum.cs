using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.ParCoordss.Lines.ColorBars
{
    /// <summary>
    ///     Sets this color bar&#39;s vertical position anchor This anchor binds the
    ///     <c>y</c> position to the <c>top</c>, <c>middle</c> or <c>bottom</c> of the
    ///     color bar.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum YAnchorEnum
    {
        [EnumMember(Value = @"middle")]
        Middle = 0,

        [EnumMember(Value = @"top")]
        Top,

        [EnumMember(Value = @"bottom")]
        Bottom
    }
}
