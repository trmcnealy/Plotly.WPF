using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.HeatMaps.ColorBars
{
    /// <summary>
    ///     Determines whether this color bar&#39;s thickness (i.e. the measure in the
    ///     constant color direction) is set in units of plot <c>fraction</c> or in
    ///     <c>pixels</c>. Use <c>thickness</c> to set the value.
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum ThicknessModeEnum
    {
        [EnumMember(Value=@"pixels")]
        Pixels = 0,
        [EnumMember(Value=@"fraction")]
        Fraction
    }
}