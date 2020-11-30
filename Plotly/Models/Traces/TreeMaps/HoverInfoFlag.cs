using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.TreeMaps
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
        [EnumMember(Value=@"skip")]
        Skip = 0,
        [EnumMember(Value=@"none")]
        None = 1,
        [EnumMember(Value=@"label")]
        Label = 2,
        [EnumMember(Value=@"text")]
        Text = 4,
        [EnumMember(Value=@"value")]
        Value = 8,
        [EnumMember(Value=@"name")]
        Name = 16,
        [EnumMember(Value=@"current path")]
        CurrentPath = 32,
        [EnumMember(Value=@"percent root")]
        PercentRoot = 64,
        [EnumMember(Value=@"percent entry")]
        PercentEntry = 128,
        [EnumMember(Value=@"percent parent")]
        PercentParent = 256,
        [EnumMember(Value=@"all")]
        All = Label | Text | Value | Name | CurrentPath | PercentRoot | PercentEntry | PercentParent
    }
}