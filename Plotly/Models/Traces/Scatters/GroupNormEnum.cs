using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.Scatters
{
    /// <summary>
    ///     Only relevant when <c>stackgroup</c> is used, and only the first <c>groupnorm</c>
    ///     found in the <c>stackgroup</c> will be used - including if <c>visible</c>
    ///     is <c>legendonly</c> but not if it is <c>false</c>. Sets the normalization
    ///     for the sum of this <c>stackgroup</c>. With <c>fraction</c>, the value of
    ///     each trace at each location is divided by the sum of all trace values at
    ///     that location. <c>percent</c> is the same but multiplied by 100 to show
    ///     percentages. If there are multiple subplots, or multiple <c>stackgroup</c>s
    ///     on one subplot, each will be normalized within its own set.
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum GroupNormEnum
    {
        [EnumMember(Value=@"")]
        Empty = 0,
        [EnumMember(Value=@"fraction")]
        Fraction,
        [EnumMember(Value=@"percent")]
        Percent
    }
}