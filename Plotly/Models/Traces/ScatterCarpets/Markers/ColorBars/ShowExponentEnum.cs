using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.ScatterCarpets.Markers.ColorBars
{
    /// <summary>
    ///     If <c>all</c>, all exponents are shown besides their significands. If <c>first</c>,
    ///     only the exponent of the first tick is shown. If <c>last</c>, only the exponent
    ///     of the last tick is shown. If <c>none</c>, no exponents appear.
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum ShowExponentEnum
    {
        [EnumMember(Value=@"all")]
        All = 0,
        [EnumMember(Value=@"first")]
        First,
        [EnumMember(Value=@"last")]
        Last,
        [EnumMember(Value=@"none")]
        None
    }
}