using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.Boxs
{
    /// <summary>
    ///     Sets the orientation of the box(es). If <c>v</c> (<c>h</c>), the distribution
    ///     is visualized along the vertical (horizontal).
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum OrientationEnum
    {
        [EnumMember(Value = @"v")]
        V,

        [EnumMember(Value = @"h")]
        H
    }
}
