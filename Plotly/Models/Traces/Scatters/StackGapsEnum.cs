using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.Scatters
{
    /// <summary>
    ///     Only relevant when <c>stackgroup</c> is used, and only the first <c>stackgaps</c>
    ///     found in the <c>stackgroup</c> will be used - including if <c>visible</c>
    ///     is <c>legendonly</c> but not if it is <c>false</c>. Determines how we handle
    ///     locations at which other traces in this group have data but this one does
    ///     not. With &#39;infer zero&#39; we insert a zero at these locations. With
    ///     <c>interpolate</c> we linearly interpolate between existing values, and
    ///     extrapolate a constant beyond the existing values.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum StackGapsEnum
    {
        [EnumMember(Value = @"infer zero")]
        InferZero = 0,

        [EnumMember(Value = @"interpolate")]
        Interpolate
    }
}
