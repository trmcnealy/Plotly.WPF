using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.HeatMaps.ColorBars
{
    /// <summary>
    ///     Determines a formatting rule for the tick exponents. For example, consider
    ///     the number 1,000,000,000. If <c>none</c>, it appears as 1,000,000,000. If
    ///     <c>e</c>, 1e+9. If <c>E</c>, 1E+9. If <c>power</c>, 1x10^9 (with 9 in a
    ///     super script). If <c>SI</c>, 1G. If <c>B</c>, 1B.
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum ExponentFormatEnum
    {
        [EnumMember(Value=@"b")]
        B = 0,
        [EnumMember(Value=@"none")]
        None,
        [EnumMember(Value=@"e")]
        e,
        [EnumMember(Value=@"E")]
        E,
        [EnumMember(Value=@"power")]
        Power,
        [EnumMember(Value=@"SI")]
        SI
    }
}