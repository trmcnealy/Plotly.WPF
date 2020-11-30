using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Layouts.XAxes.RangeSelectors.Buttons
{
    /// <summary>
    ///     The unit of measurement that the <c>count</c> value will set the range by.
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum StepEnum
    {
        [EnumMember(Value=@"month")]
        Month = 0,
        [EnumMember(Value=@"year")]
        Year,
        [EnumMember(Value=@"day")]
        Day,
        [EnumMember(Value=@"hour")]
        Hour,
        [EnumMember(Value=@"minute")]
        Minute,
        [EnumMember(Value=@"second")]
        Second,
        [EnumMember(Value=@"all")]
        All
    }
}