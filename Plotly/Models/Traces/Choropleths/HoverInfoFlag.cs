using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.Choropleths
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

        [EnumMember(Value = @"location")]
        Location = 2,

        [EnumMember(Value = @"z")]
        Z = 4,

        [EnumMember(Value = @"text")]
        Text = 8,

        [EnumMember(Value = @"name")]
        Name = 16,

        [EnumMember(Value = @"all")]
        All = Location | Z | Text | Name
    }
}
