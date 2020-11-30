using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Layouts.Shapes
{
    /// <summary>
    ///     Determines which regions of complex paths constitute the interior. For more
    ///     info please visit https://developer.mozilla.org/en-US/docs/Web/SVG/Attribute/fill-rule
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