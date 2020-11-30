using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Plotly.Models.Layouts.YAxes
{
    /// <summary>
    ///     If this axis needs to be compressed (either due to its own <c>scaleanchor</c>
    ///     and <c>scaleratio</c> or those of the other axis), determines how that happens:
    ///     by increasing the <c>range</c> (default), or by decreasing the <c>domain</c>.
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum ConstrainEnum
    {
        [EnumMember(Value=@"range")]
        Range = 0,
        [EnumMember(Value=@"domain")]
        Domain
    }
}