using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Plotly.Models.Layouts
{
    /// <summary>
    ///     Sets the normalization for bar traces on the graph. With <c>fraction</c>,
    ///     the value of each bar is divided by the sum of all values at that location
    ///     coordinate. <c>percent</c> is the same but multiplied by 100 to show percentages.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum BarNormEnum
    {
        [EnumMember(Value = @"")]
        Empty = 0,

        [EnumMember(Value = @"fraction")]
        Fraction,

        [EnumMember(Value = @"percent")]
        Percent
    }
}
