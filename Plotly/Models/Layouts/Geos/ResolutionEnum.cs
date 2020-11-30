using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Layouts.Geos
{
    /// <summary>
    ///     Sets the resolution of the base layers. The values have units of km/mm e.g.
    ///     110 corresponds to a scale ratio of 1:110,000,000.
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum ResolutionEnum
    {
        [EnumMember(Value=@"110")]
        _110 = 0,
        [EnumMember(Value=@"50")]
        _50
    }
}