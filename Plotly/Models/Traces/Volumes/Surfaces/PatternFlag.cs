using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.Volumes.Surfaces
{
    /// <summary>
    ///     Sets the surface pattern of the iso-surface 3-D sections. The default pattern
    ///     of the surface is <c>all</c> meaning that the rest of surface elements would
    ///     be shaded. The check options (either 1 or 2) could be used to draw half
    ///     of the squares on the surface. Using various combinations of capital <c>A</c>,
    ///     <c>B</c>, <c>C</c>, <c>D</c> and <c>E</c> may also be used to reduce the
    ///     number of triangles on the iso-surfaces and creating other patterns of interest.
    /// </summary>
    [Flags]
    [JsonConverter(typeof(EnumConverter))]
    public enum PatternFlag
    {
        [EnumMember(Value = @"odd")]
        Odd = 0,

        [EnumMember(Value = @"even")]
        Even = 1,

        [EnumMember(Value = @"A")]
        A = 2,

        [EnumMember(Value = @"B")]
        B = 4,

        [EnumMember(Value = @"C")]
        C = 8,

        [EnumMember(Value = @"D")]
        D = 16,

        [EnumMember(Value = @"E")]
        E = 32,

        [EnumMember(Value = @"all")]
        All = A | B | C | D | E
    }
}
