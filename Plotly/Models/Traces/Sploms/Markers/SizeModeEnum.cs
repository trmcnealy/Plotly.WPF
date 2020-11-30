using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.Sploms.Markers
{
    /// <summary>
    ///     Has an effect only if <c>marker.size</c> is set to a numerical array. Sets
    ///     the rule for which the data in <c>size</c> is converted to pixels.
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum SizeModeEnum
    {
        [EnumMember(Value=@"diameter")]
        Diameter = 0,
        [EnumMember(Value=@"area")]
        Area
    }
}