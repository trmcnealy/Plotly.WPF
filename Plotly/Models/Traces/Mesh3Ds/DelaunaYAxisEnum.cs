using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Plotly.Models.Traces.Mesh3Ds
{
    /// <summary>
    ///     Sets the Delaunay axis, which is the axis that is perpendicular to the surface
    ///     of the Delaunay triangulation. It has an effect if <c>i</c>, <c>j</c>, <c>k</c>
    ///     are not provided and <c>alphahull</c> is set to indicate Delaunay triangulation.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum DelaunaYAxisEnum
    {
        [EnumMember(Value = @"z")]
        Z = 0,

        [EnumMember(Value = @"x")]
        X,

        [EnumMember(Value = @"y")]
        Y
    }
}
