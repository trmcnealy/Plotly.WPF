using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Layouts.Titles
{
    /// <summary>
    ///     Sets the container <c>y</c> refers to. <c>container</c> spans the entire
    ///     <c>height</c> of the plot. <c>paper</c> refers to the height of the plotting
    ///     area only.
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum YRefEnum
    {
        [EnumMember(Value=@"container")]
        Container = 0,
        [EnumMember(Value=@"paper")]
        Paper
    }
}