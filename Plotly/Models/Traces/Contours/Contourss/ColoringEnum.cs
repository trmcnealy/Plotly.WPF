using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Plotly.Models.Traces.Contours.Contourss
{
    /// <summary>
    ///     Determines the coloring method showing the contour values. If <c>fill</c>,
    ///     coloring is done evenly between each contour level If <c>heatmap</c>, a
    ///     heatmap gradient coloring is applied between each contour level. If <c>lines</c>,
    ///     coloring is done on the contour lines. If <c>none</c>, no coloring is applied
    ///     on this trace.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum ColoringEnum
    {
        [EnumMember(Value = @"fill")]
        Fill = 0,

        [EnumMember(Value = @"heatmap")]
        HeatMap,

        [EnumMember(Value = @"lines")]
        Lines,

        [EnumMember(Value = @"none")]
        None
    }
}
