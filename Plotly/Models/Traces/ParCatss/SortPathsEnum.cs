using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.ParCatss
{
    /// <summary>
    ///     Sets the path sorting algorithm. If <c>forward</c>, sort paths based on
    ///     dimension categories from left to right. If <c>backward</c>, sort paths
    ///     based on dimensions categories from right to left.
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum SortPathsEnum
    {
        [EnumMember(Value=@"forward")]
        Forward = 0,
        [EnumMember(Value=@"backward")]
        Backward
    }
}