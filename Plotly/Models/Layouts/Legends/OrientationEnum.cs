using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Layouts.Legends
{
    /// <summary>
    ///     Sets the orientation of the legend.
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum OrientationEnum
    {
        [EnumMember(Value=@"v")]
        V = 0,
        [EnumMember(Value=@"h")]
        H
    }
}