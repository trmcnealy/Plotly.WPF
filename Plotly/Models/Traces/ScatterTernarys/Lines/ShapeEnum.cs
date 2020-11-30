using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.ScatterTernarys.Lines
{
    /// <summary>
    ///     Determines the line shape. With <c>spline</c> the lines are drawn using
    ///     spline interpolation. The other available values correspond to step-wise
    ///     line shapes.
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum ShapeEnum
    {
        [EnumMember(Value=@"linear")]
        Linear = 0,
        [EnumMember(Value=@"spline")]
        Spline
    }
}