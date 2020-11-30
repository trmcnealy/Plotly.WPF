using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Layouts.Legends
{
    /// <summary>
    ///     Sets the vertical alignment of the symbols with respect to their associated
    ///     text.
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum VAlignEnum
    {
        [EnumMember(Value=@"middle")]
        Middle = 0,
        [EnumMember(Value=@"top")]
        Top,
        [EnumMember(Value=@"bottom")]
        Bottom
    }
}