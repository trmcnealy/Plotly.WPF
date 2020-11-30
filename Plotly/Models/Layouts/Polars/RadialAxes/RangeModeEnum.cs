using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Layouts.Polars.RadialAxes
{
    /// <summary>
    ///     If <c>tozero</c>`, the range extends to 0, regardless of the input data
    ///     If <c>nonnegative</c>, the range is non-negative, regardless of the input
    ///     data. If <c>normal</c>, the range is computed in relation to the extrema
    ///     of the input data (same behavior as for cartesian axes).
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum RangeModeEnum
    {
        [EnumMember(Value=@"tozero")]
        ToZero = 0,
        [EnumMember(Value=@"nonnegative")]
        NonNegative,
        [EnumMember(Value=@"normal")]
        Normal
    }
}