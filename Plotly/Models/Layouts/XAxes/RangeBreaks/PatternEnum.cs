using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Layouts.XAxes.RangeBreaks
{
    /// <summary>
    ///     Determines a pattern on the time line that generates breaks. If &#39;day
    ///     of week&#39; - days of the week in English e.g. <c>Sunday</c> or <c>sun</c>
    ///     (matching is case-insensitive and considers only the first three characters),
    ///     as well as Sunday-based integers between 0 and 6. If <c>hour</c> - hour
    ///     (24-hour clock) as JsNumber numbers between 0 and 24. for more info. Examples:
    ///     - { pattern: &#39;day of week&#39;, bounds: [6, 1] }  or simply { bounds:
    ///     [<c>sat</c>, <c>mon</c>] }   breaks from Saturday to Monday (i.e. skips
    ///     the weekends). - { pattern: <c>hour</c>, bounds: [17, 8] }   breaks from
    ///     5pm to 8am (i.e. skips non-work hours).
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum PatternEnum
    {
        [EnumMember(Value = @"day of week")]
        DayOfWeek,

        [EnumMember(Value = @"hour")]
        Hour,

        [EnumMember(Value = @"")]
        Empty
    }
}
