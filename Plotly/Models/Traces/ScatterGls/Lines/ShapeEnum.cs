using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.ScatterGls.Lines
{
    /// <summary>
    ///     Determines the line shape. The values correspond to step-wise line shapes.
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum ShapeEnum
    {
        [EnumMember(Value=@"linear")]
        Linear = 0,
        [EnumMember(Value=@"hv")]
        Hv,
        [EnumMember(Value=@"vh")]
        Vh,
        [EnumMember(Value=@"hvh")]
        Hvh,
        [EnumMember(Value=@"vhv")]
        Vhv
    }
}