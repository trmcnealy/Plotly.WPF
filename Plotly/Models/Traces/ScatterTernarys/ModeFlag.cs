using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.ScatterTernarys
{
    /// <summary>
    ///     Determines the drawing mode for this scatter trace. If the provided <c>mode</c>
    ///     includes <c>text</c> then the <c>text</c> elements appear at the coordinates.
    ///     Otherwise, the <c>text</c> elements appear on hover. If there are less than
    ///     20 points and the trace is not stacked then the default is <c>lines+markers</c>.
    ///     Otherwise, <c>lines</c>.
    /// </summary>
    [Flags]
    [JsonConverter(typeof(EnumConverter))]
    public enum ModeFlag
    {
        [EnumMember(Value = @"none")]
        None = 0,

        [EnumMember(Value = @"lines")]
        Lines = 1,

        [EnumMember(Value = @"markers")]
        Markers = 2,

        [EnumMember(Value = @"text")]
        Text = 4
    }
}
