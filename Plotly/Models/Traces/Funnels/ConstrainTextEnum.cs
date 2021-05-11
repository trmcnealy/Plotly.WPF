using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Plotly.Models.Traces.Funnels
{
    /// <summary>
    ///     Constrain the size of text inside or outside a bar to be no larger than
    ///     the bar itself.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum ConstrainTextEnum
    {
        [EnumMember(Value = @"both")]
        Both = 0,

        [EnumMember(Value = @"inside")]
        Inside,

        [EnumMember(Value = @"outside")]
        Outside,

        [EnumMember(Value = @"none")]
        None
    }
}
