using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Plotly.Models.Layouts.Scenes.Annotations
{
    /// <summary>
    ///     Sets the annotation arrow head position.
    /// </summary>
    
    [Flags]
    [JsonConverter(typeof(EnumConverter))]
    public enum ArrowSideFlag
    {
        [EnumMember(Value=@"none")]
        None = 0,
        [EnumMember(Value=@"end")]
        End = 1,
        [EnumMember(Value=@"start")]
        Start = 2
    }
}