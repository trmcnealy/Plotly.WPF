using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.ParCatss.Lines
{
    /// <summary>
    ///     Sets the shape of the paths. If <c>linear</c>, paths are composed of straight
    ///     lines. If <c>hspline</c>, paths are composed of horizontal curved splines
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum ShapeEnum
    {
        [EnumMember(Value = @"linear")]
        Linear = 0,

        [EnumMember(Value = @"hspline")]
        HSpline
    }
}
