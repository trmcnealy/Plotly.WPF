using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.Mesh3Ds
{
    /// <summary>
    ///     Determines the source of <c>intensity</c> values.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum IntensityModeEnum
    {
        [EnumMember(Value = @"vertex")]
        Vertex = 0,

        [EnumMember(Value = @"cell")]
        Cell
    }
}
