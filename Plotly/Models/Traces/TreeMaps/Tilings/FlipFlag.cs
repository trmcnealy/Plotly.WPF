using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.TreeMaps.Tilings
{
    /// <summary>
    ///     Determines if the positions obtained from solver are flipped on each axis.
    /// </summary>
    
    [Flags]
    [JsonConverter(typeof(EnumConverter))]
    public enum FlipFlag
    {
        [EnumMember(Value=@"x")]
        X = 0,
        [EnumMember(Value=@"y")]
        Y = 1
    }
}