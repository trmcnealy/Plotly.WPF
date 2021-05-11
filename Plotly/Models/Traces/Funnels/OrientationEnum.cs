using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.Funnels
{
    /// <summary>
    ///     Sets the orientation of the funnels. With <c>v</c> (<c>h</c>), the value
    ///     of the each bar spans along the vertical (horizontal). By default funnels
    ///     are tend to be oriented horizontally; unless only <c>y</c> array is presented
    ///     or orientation is set to <c>v</c>. Also regarding graphs including only
    ///     <c>horizontal</c> funnels, <c>autorange</c> on the <c>y-axis</c> are set
    ///     to <c>reversed</c>.
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
