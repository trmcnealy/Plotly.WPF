using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Layouts.YAxes
{
    /// <summary>
    ///     Determines where ticks and grid lines are drawn with respect to their corresponding
    ///     tick labels. Only has an effect for axes of <c>type</c> <c>category</c>
    ///     or <c>multicategory</c>. When set to <c>boundaries</c>, ticks and grid lines
    ///     are drawn half a category to the left/bottom of labels.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum TickSonEnum
    {
        [EnumMember(Value = @"labels")]
        Labels = 0,

        [EnumMember(Value = @"boundaries")]
        Boundaries
    }
}
