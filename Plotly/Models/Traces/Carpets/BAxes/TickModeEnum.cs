using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.Carpets.BAxes
{
    /// <summary>
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum TickModeEnum
    {
        [EnumMember(Value=@"array")]
        Array = 0,
        [EnumMember(Value=@"linear")]
        Linear
    }
}