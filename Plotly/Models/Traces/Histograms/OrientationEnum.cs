using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.Histograms
{
    /// <summary>
    ///     Sets the orientation of the bars. With <c>v</c> (<c>h</c>), the value of
    ///     the each bar spans along the vertical (horizontal).
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum OrientationEnum
    {
        [EnumMember(Value=@"v")]
        V,
        [EnumMember(Value=@"h")]
        H
    }
}