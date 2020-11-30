using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Layouts.Legends
{
    /// <summary>
    ///     Determines if the legend items symbols scale with their corresponding <c>trace</c>
    ///     attributes or remain <c>constant</c> independent of the symbol size on the
    ///     graph.
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum ItemSizingEnum
    {
        [EnumMember(Value=@"trace")]
        Trace = 0,
        [EnumMember(Value=@"constant")]
        Constant
    }
}