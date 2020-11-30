using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Layouts.Legends
{
    /// <summary>
    ///     Sets the legend&#39;s vertical position anchor This anchor binds the <c>y</c>
    ///     position to the <c>top</c>, <c>middle</c> or <c>bottom</c> of the legend.
    ///     Value <c>auto</c> anchors legends at their bottom for <c>y</c> values less
    ///     than or equal to 1/3, anchors legends to at their top for <c>y</c> values
    ///     greater than or equal to 2/3 and anchors legends with respect to their middle
    ///     otherwise.
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum YAnchorEnum
    {
        [EnumMember(Value=@"auto")]
        Auto,
        [EnumMember(Value=@"top")]
        Top,
        [EnumMember(Value=@"middle")]
        Middle,
        [EnumMember(Value=@"bottom")]
        Bottom
    }
}