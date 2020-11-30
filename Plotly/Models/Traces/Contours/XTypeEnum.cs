using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.Contours
{
    /// <summary>
    ///     If <c>array</c>, the heatmap&#39;s x coordinates are given by <c>x</c> (the
    ///     default behavior when <c>x</c> is provided). If <c>scaled</c>, the heatmap&#39;s
    ///     x coordinates are given by <c>x0</c> and <c>dx</c> (the default behavior
    ///     when <c>x</c> is not provided).
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum XTypeEnum
    {
        [EnumMember(Value=@"array")]
        Array,
        [EnumMember(Value=@"scaled")]
        Scaled
    }
}