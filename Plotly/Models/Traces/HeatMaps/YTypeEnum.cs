using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.HeatMaps
{
    /// <summary>
    ///     If <c>array</c>, the heatmap&#39;s y coordinates are given by <c>y</c> (the
    ///     default behavior when <c>y</c> is provided) If <c>scaled</c>, the heatmap&#39;s
    ///     y coordinates are given by <c>y0</c> and <c>dy</c> (the default behavior
    ///     when <c>y</c> is not provided)
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum YTypeEnum
    {
        [EnumMember(Value=@"array")]
        Array,
        [EnumMember(Value=@"scaled")]
        Scaled
    }
}