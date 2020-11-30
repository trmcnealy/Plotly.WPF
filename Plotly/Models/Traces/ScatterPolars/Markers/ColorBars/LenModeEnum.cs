using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.ScatterPolars.Markers.ColorBars
{
    /// <summary>
    ///     Determines whether this color bar&#39;s length (i.e. the measure in the
    ///     color variation direction) is set in units of plot <c>fraction</c> or in
    ///     *pixels. Use <c>len</c> to set the value.
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum LenModeEnum
    {
        [EnumMember(Value=@"fraction")]
        Fraction = 0,
        [EnumMember(Value=@"pixels")]
        Pixels
    }
}