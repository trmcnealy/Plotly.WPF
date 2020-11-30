using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Layouts.NewShapes
{
    /// <summary>
    ///     Determines the path&#39;s interior. For more info please visit https://developer.mozilla.org/en-US/docs/Web/SVG/Attribute/fill-rule
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum FillRuleEnum
    {
        [EnumMember(Value=@"evenodd")]
        EvenOdd = 0,
        [EnumMember(Value=@"nonzero")]
        Nonzero
    }
}