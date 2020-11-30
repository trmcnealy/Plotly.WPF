using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.Sankeys
{
    /// <summary>
    ///     Sets the orientation of the Sankey diagram.
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum OrientationEnum
    {
        [EnumMember(Value=@"h")]
        H = 0,
        [EnumMember(Value=@"v")]
        V
    }
}