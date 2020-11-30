using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.Violins
{
    /// <summary>
    ///     Do the hover effects highlight individual violins or sample points or the
    ///     kernel density estimate or any combination of them?
    /// </summary>
    
    [Flags]
    [JsonConverter(typeof(EnumConverter))]
    public enum HoverOnFlag
    {
        [EnumMember(Value=@"violins")]
        Violins = 0,
        [EnumMember(Value=@"points")]
        Points = 1,
        [EnumMember(Value=@"kde")]
        Kde = 2,
        [EnumMember(Value=@"all")]
        All = Violins | Points | Kde
    }
}