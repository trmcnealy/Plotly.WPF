using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Plotly.Models.Traces.Indicators
{
    /// <summary>
    ///     Sets the horizontal alignment of the <c>text</c> within the box. Note that
    ///     this attribute has no effect if an angular gauge is displayed: in this case,
    ///     it is always centered
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum AlignEnum
    {
        [EnumMember(Value=@"left")]
        Left,
        [EnumMember(Value=@"center")]
        Center,
        [EnumMember(Value=@"right")]
        Right
    }
}