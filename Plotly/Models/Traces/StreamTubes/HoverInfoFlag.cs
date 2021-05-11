using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.StreamTubes
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

        [EnumMember(Value = @"x")]
        X = 2,

        [EnumMember(Value = @"y")]
        Y = 4,

        [EnumMember(Value = @"z")]
        Z = 8,

        [EnumMember(Value = @"u")]
        U = 16,

        [EnumMember(Value = @"v")]
        V = 32,

        [EnumMember(Value = @"w")]
        W = 64,

        [EnumMember(Value = @"norm")]
        Norm = 128,

        [EnumMember(Value = @"divergence")]
        Divergence = 256,

        [EnumMember(Value = @"text")]
        Text = 512,

        [EnumMember(Value = @"name")]
        Name = 1024,

        [EnumMember(Value = @"all")]
        All = X | Y | Z | U | V | W | Norm | Divergence | Text | Name
    }
}
