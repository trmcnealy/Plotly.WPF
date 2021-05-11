using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.Scatters
{
    /// <summary>
    ///     Only relevant when <c>stackgroup</c> is used, and only the first <c>orientation</c>
    ///     found in the <c>stackgroup</c> will be used - including if <c>visible</c>
    ///     is <c>legendonly</c> but not if it is <c>false</c>. Sets the stacking direction.
    ///     With <c>v</c> (<c>h</c>), the y (x) values of subsequent traces are added.
    ///     Also affects the default value of <c>fill</c>.
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
