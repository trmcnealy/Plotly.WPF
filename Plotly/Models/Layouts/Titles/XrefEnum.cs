using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Layouts.Titles
{
    /// <summary>
    ///     Sets the container <c>x</c> refers to. <c>container</c> spans the entire
    ///     <c>width</c> of the plot. <c>paper</c> refers to the width of the plotting
    ///     area only.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum XRefEnum
    {
        [EnumMember(Value = @"container")]
        Container = 0,

        [EnumMember(Value = @"paper")]
        Paper
    }
}
