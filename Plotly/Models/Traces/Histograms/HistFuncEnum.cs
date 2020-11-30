using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.Histograms
{
    /// <summary>
    ///     Specifies the binning function used for this histogram trace. If <c>count</c>,
    ///     the histogram values are computed by counting the number of values lying
    ///     inside each bin. If <c>sum</c>, <c>avg</c>, <c>min</c>, <c>max</c>, the
    ///     histogram values are computed using the sum, the average, the minimum or
    ///     the maximum of the values lying inside each bin respectively.
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum HistFuncEnum
    {
        [EnumMember(Value=@"count")]
        Count = 0,
        [EnumMember(Value=@"sum")]
        Sum,
        [EnumMember(Value=@"avg")]
        Avg,
        [EnumMember(Value=@"min")]
        Min,
        [EnumMember(Value=@"max")]
        Max
    }
}