using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Plotly.Models.Traces.Cones
{
    /// <summary>
    ///     Sets the cones&#39; anchor with respect to their x/y/z positions. Note that
    ///     <c>cm</c> denote the cone&#39;s center of mass which corresponds to 1/4
    ///     from the tail to tip.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum AnchorEnum
    {
        [EnumMember(Value = @"cm")]
        Cm = 0,

        [EnumMember(Value = @"tip")]
        Tip,

        [EnumMember(Value = @"tail")]
        Tail,

        [EnumMember(Value = @"center")]
        Center
    }
}
