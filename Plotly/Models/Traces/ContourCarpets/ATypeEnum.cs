using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Plotly.Models.Traces.ContourCarpets
{
    /// <summary>
    ///     If <c>array</c>, the heatmap&#39;s x coordinates are given by <c>x</c> (the
    ///     default behavior when <c>x</c> is provided). If <c>scaled</c>, the heatmap&#39;s
    ///     x coordinates are given by <c>x0</c> and <c>dx</c> (the default behavior
    ///     when <c>x</c> is not provided).
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum ATypeEnum
    {
        [EnumMember(Value = @"array")]
        Array,

        [EnumMember(Value = @"scaled")]
        Scaled
    }
}
