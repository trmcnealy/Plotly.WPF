using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.Choropleths.ColorBars.Titles
{
    /// <summary>
    ///     Determines the location of color bar&#39;s title with respect to the color
    ///     bar. Note that the title&#39;s location used to be set by the now deprecated
    ///     <c>titleside</c> attribute.
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum SideEnum
    {
        [EnumMember(Value=@"top")]
        Top = 0,
        [EnumMember(Value=@"right")]
        Right,
        [EnumMember(Value=@"bottom")]
        Bottom
    }
}