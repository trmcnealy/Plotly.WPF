using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.Boxs
{
    /// <summary>
    ///     Do the hover effects highlight individual boxes  or sample points or both?
    /// </summary>
    
    [Flags]
    [JsonConverter(typeof(EnumConverter))]
    public enum HoverOnFlag
    {
        [EnumMember(Value=@"boxes")]
        Boxes = 0,
        [EnumMember(Value=@"points")]
        Points = 1
    }
}