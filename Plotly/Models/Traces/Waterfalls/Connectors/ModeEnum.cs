using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.Waterfalls.Connectors
{
    /// <summary>
    ///     Sets the shape of connector lines.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum ModeEnum
    {
        [EnumMember(Value = @"between")]
        Between = 0,

        [EnumMember(Value = @"spanning")]
        Spanning
    }
}
