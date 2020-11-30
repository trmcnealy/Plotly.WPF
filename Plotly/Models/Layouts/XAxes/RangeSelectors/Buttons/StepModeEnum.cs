using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Layouts.XAxes.RangeSelectors.Buttons
{
    /// <summary>
    ///     Sets the range update mode. If <c>backward</c>, the range update shifts
    ///     the start of range back <c>count</c> times <c>step</c> milliseconds. If
    ///     <c>todate</c>, the range update shifts the start of range back to the first
    ///     timestamp from <c>count</c> times <c>step</c> milliseconds back. For example,
    ///     with <c>step</c> set to <c>year</c> and <c>count</c> set to <c>1</c> the
    ///     range update shifts the start of the range back to January 01 of the current
    ///     year. Month and year <c>todate</c> are currently available only for the
    ///     built-in (Gregorian) calendar.
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum StepModeEnum
    {
        [EnumMember(Value=@"backward")]
        Backward = 0,
        [EnumMember(Value=@"todate")]
        ToDate
    }
}