using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.Violins
{
    /// <summary>
    ///     Sets the method by which the span in data space where the density function
    ///     will be computed. <c>soft</c> means the span goes from the sample&#39;s
    ///     minimum value minus two bandwidths to the sample&#39;s maximum value plus
    ///     two bandwidths. <c>hard</c> means the span goes from the sample&#39;s minimum
    ///     to its maximum value. For custom span settings, use mode <c>manual</c> and
    ///     fill in the <c>span</c> attribute.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum SpanModeEnum
    {
        [EnumMember(Value = @"soft")]
        Soft = 0,

        [EnumMember(Value = @"hard")]
        Hard,

        [EnumMember(Value = @"manual")]
        Manual
    }
}
