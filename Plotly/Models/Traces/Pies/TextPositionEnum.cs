using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.Pies
{
    /// <summary>
    ///     Specifies the location of the <c>textinfo</c>.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum TextPositionEnum
    {
        [EnumMember(Value = @"auto")]
        Auto = 0,

        [EnumMember(Value = @"inside")]
        Inside,

        [EnumMember(Value = @"outside")]
        Outside,

        [EnumMember(Value = @"none")]
        None
    }
}
