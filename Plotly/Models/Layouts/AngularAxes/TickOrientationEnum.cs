using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Layouts.AngularAxes
{
    /// <summary>
    ///     Legacy polar charts are deprecated! Please switch to <c>polar</c> subplots.
    ///     Sets the orientation (from the paper perspective) of the angular axis tick
    ///     labels.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum TickOrientationEnum
    {
        [EnumMember(Value = @"horizontal")]
        Horizontal,

        [EnumMember(Value = @"vertical")]
        Vertical
    }
}
