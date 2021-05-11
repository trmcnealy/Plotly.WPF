using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Transforms.Aggregates.Aggregations
{
    /// <summary>
    ///     <c>stddev</c> supports two formula variants: <c>sample</c> (normalize by
    ///     N-1) and <c>population</c> (normalize by N).
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum FuncModeEnum
    {
        [EnumMember(Value = @"sample")]
        Sample = 0,

        [EnumMember(Value = @"population")]
        Population
    }
}
