using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.Violins
{
    /// <summary>
    ///     Sets the metric by which the width of each violin is determined.<c>width</c>
    ///     means each violin has the same (max) width<c>count</c> means the violins
    ///     are scaled by the number of sample points makingup each violin.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum ScaleModeEnum
    {
        [EnumMember(Value = @"width")]
        Width = 0,

        [EnumMember(Value = @"count")]
        Count
    }
}
