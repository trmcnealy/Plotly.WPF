using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Plotly.Models.Traces.Histograms.Cumulatives
{
    /// <summary>
    ///     Only applies if cumulative is enabled. If <c>increasing</c> (default) we
    ///     sum all prior bins, so the result increases from left to right. If <c>decreasing</c>
    ///     we sum later bins so the result decreases from left to right.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum DirectionEnum
    {
        [EnumMember(Value = @"increasing")]
        Increasing = 0,

        [EnumMember(Value = @"decreasing")]
        Decreasing
    }
}
