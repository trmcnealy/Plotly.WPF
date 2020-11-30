using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.Carpets.AAxes
{
    /// <summary>
    ///     If <c>normal</c>, the range is computed in relation to the extrema of the
    ///     input data. If <c>tozero</c>`, the range extends to 0, regardless of the
    ///     input data If <c>nonnegative</c>, the range is non-negative, regardless
    ///     of the input data.
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum RangeModeEnum
    {
        [EnumMember(Value=@"normal")]
        Normal = 0,
        [EnumMember(Value=@"tozero")]
        ToZero,
        [EnumMember(Value=@"nonnegative")]
        NonNegative
    }
}