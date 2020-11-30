using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Layouts.Grids
{
    /// <summary>
    ///     Sets where the x axis labels and titles go. <c>bottom</c> means the very
    ///     bottom of the grid. &#39;bottom plot&#39; is the lowest plot that each x
    ///     axis is used in. <c>top</c> and &#39;top plot&#39; are similar.
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum XSideEnum
    {
        [EnumMember(Value=@"bottom plot")]
        BottomPlot = 0,
        [EnumMember(Value=@"bottom")]
        Bottom,
        [EnumMember(Value=@"top plot")]
        TopPlot,
        [EnumMember(Value=@"top")]
        Top
    }
}