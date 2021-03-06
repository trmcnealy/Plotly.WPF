using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.Scatter3Ds
{
    /// <summary>
    ///     If <c>-1</c>, the scatter points are not fill with a surface If <c>0</c>,
    ///     <c>1</c>, <c>2</c>, the scatter points are filled with a Delaunay surface
    ///     about the x, y, z respectively.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum SurfaceAxisEnum
    {
        [EnumMember(Value = @"-1")]
        _1 = 0,

        [EnumMember(Value = @"0")]
        _0,

        [EnumMember(Value = @"2")]
        _2
    }
}
