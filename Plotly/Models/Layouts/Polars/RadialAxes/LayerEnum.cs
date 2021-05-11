using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Layouts.Polars.RadialAxes
{
    /// <summary>
    ///     Sets the layer on which this axis is displayed. If &#39;above traces&#39;,
    ///     this axis is displayed above all the subplot&#39;s traces If &#39;below
    ///     traces&#39;, this axis is displayed below all the subplot&#39;s traces,
    ///     but above the grid lines. Useful when used together with scatter-like traces
    ///     with <c>cliponaxis</c> set to <c>false</c> to show markers and/or text nodes
    ///     above this axis.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum LayerEnum
    {
        [EnumMember(Value = @"above traces")]
        AboveTraces = 0,

        [EnumMember(Value = @"below traces")]
        BelowTraces
    }
}
