using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.Violins
{
    /// <summary>
    ///     Determines on which side of the position value the density function making
    ///     up one half of a violin is plotted. Useful when comparing two violin traces
    ///     under <c>overlay</c> mode, where one trace has <c>side</c> set to <c>positive</c>
    ///     and the other to <c>negative</c>.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum SideEnum
    {
        [EnumMember(Value = @"both")]
        Both = 0,

        [EnumMember(Value = @"positive")]
        Positive,

        [EnumMember(Value = @"negative")]
        Negative
    }
}
