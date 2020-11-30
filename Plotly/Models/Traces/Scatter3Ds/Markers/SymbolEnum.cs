using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.Scatter3Ds.Markers
{
    /// <summary>
    ///     Sets the marker symbol type.
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum SymbolEnum
    {
        [EnumMember(Value=@"circle")]
        Circle = 0,
        [EnumMember(Value=@"circle-open")]
        CircleOpen,
        [EnumMember(Value=@"square")]
        Square,
        [EnumMember(Value=@"square-open")]
        SquareOpen,
        [EnumMember(Value=@"diamond")]
        Diamond,
        [EnumMember(Value=@"diamond-open")]
        DiamondOpen,
        [EnumMember(Value=@"cross")]
        Cross,
        [EnumMember(Value=@"x")]
        X
    }
}