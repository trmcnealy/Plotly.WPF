using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.Sankeys.Nodes
{
    /// <summary>
    ///     Determines which trace information appear when hovering nodes. If <c>none</c>
    ///     or <c>skip</c> are set, no information is displayed upon hovering. But,
    ///     if <c>none</c> is set, click and hover events are still fired.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum HoverInfoEnum
    {
        [EnumMember(Value = @"all")]
        All = 0,

        [EnumMember(Value = @"none")]
        None,

        [EnumMember(Value = @"skip")]
        Skip
    }
}
