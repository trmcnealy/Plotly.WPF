using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.ScatterPolars
{
    /// <summary>
    ///     Do the hover effects highlight individual points (markers or line points)
    ///     or do they highlight filled regions? If the fill is <c>toself</c> or <c>tonext</c>
    ///     and there are no markers or text, then the default is <c>fills</c>, otherwise
    ///     it is <c>points</c>.
    /// </summary>
    
    [Flags]
    [JsonConverter(typeof(EnumConverter))]
    public enum HoverOnFlag
    {
        [EnumMember(Value=@"points")]
        Points = 0,
        [EnumMember(Value=@"fills")]
        Fills = 1
    }
}