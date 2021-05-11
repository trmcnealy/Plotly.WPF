using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Layouts.Transitions
{
    /// <summary>
    ///     Determines whether the figure&#39;s layout or traces smoothly transitions
    ///     during updates that make both traces and layout change.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum OrderingEnum
    {
        [EnumMember(Value = @"layout first")]
        LayoutFirst = 0,

        [EnumMember(Value = @"traces first")]
        TracesFirst
    }
}
