using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.ParCatss
{
    /// <summary>
    ///     Determines which trace information appear on hover. If <c>none</c> or <c>skip</c>
    ///     are set, no information is displayed upon hovering. But, if <c>none</c>
    ///     is set, click and hover events are still fired.
    /// </summary>
    [Flags]
    [JsonConverter(typeof(EnumConverter))]
    public enum HoverInfoFlag
    {
        [EnumMember(Value = @"skip")]
        Skip = 0,

        [EnumMember(Value = @"none")]
        None = 1,

        [EnumMember(Value = @"count")]
        Count = 2,

        [EnumMember(Value = @"probability")]
        Probability = 4,

        [EnumMember(Value = @"all")]
        All = Count | Probability
    }
}
