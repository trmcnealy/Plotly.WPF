using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.Cones
{
    /// <summary>
    ///     Determines whether <c>sizeref</c> is set as a <c>scaled</c> (i.e unitless)
    ///     scalar (normalized by the max u/v/w norm in the vector field) or as <c>absolute</c>
    ///     value (in the same units as the vector field).
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum SizeModeEnum
    {
        [EnumMember(Value=@"scaled")]
        Scaled = 0,
        [EnumMember(Value=@"absolute")]
        Absolute
    }
}