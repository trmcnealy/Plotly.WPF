using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.Indicators
{
    /// <summary>
    ///     Determines how the value is displayed on the graph. <c>number</c> displays
    ///     the value numerically in text. <c>delta</c> displays the difference to a
    ///     reference value in text. Finally, <c>gauge</c> displays the value graphically
    ///     on an axis.
    /// </summary>
    [Flags]
    [JsonConverter(typeof(EnumConverter))]
    public enum ModeFlag
    {
        [EnumMember(Value = @"number")]
        Number = 0,

        [EnumMember(Value = @"delta")]
        Delta = 1,

        [EnumMember(Value = @"gauge")]
        Gauge = 2
    }
}
