using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Plotly.Models.Traces.ContourCarpets
{
    /// <summary>
    ///     If <c>array</c>, the heatmap&#39;s y coordinates are given by <c>y</c> (the
    ///     default behavior when <c>y</c> is provided) If <c>scaled</c>, the heatmap&#39;s
    ///     y coordinates are given by <c>y0</c> and <c>dy</c> (the default behavior
    ///     when <c>y</c> is not provided)
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum BTypeEnum
    {
        [EnumMember(Value = @"array")]
        Array,

        [EnumMember(Value = @"scaled")]
        Scaled
    }
}
