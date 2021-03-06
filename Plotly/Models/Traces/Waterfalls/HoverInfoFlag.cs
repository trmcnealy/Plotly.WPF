using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.Waterfalls
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

        [EnumMember(Value = @"name")]
        Name = 2,

        [EnumMember(Value = @"x")]
        X = 4,

        [EnumMember(Value = @"y")]
        Y = 8,

        [EnumMember(Value = @"text")]
        Text = 16,

        [EnumMember(Value = @"initial")]
        Initial = 32,

        [EnumMember(Value = @"delta")]
        Delta = 64,

        [EnumMember(Value = @"final")]
        Final = 128,

        [EnumMember(Value = @"all")]
        All = Name | X | Y | Text | Initial | Delta | Final
    }
}
