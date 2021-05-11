using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Plotly.Models.Layouts.Polars.RadialAxes
{
    /// <summary>
    ///     Determines whether or not the range of this axis is computed in relation
    ///     to the input data. See <c>rangemode</c> for more info. If <c>range</c> is
    ///     provided, then <c>autorange</c> is set to <c>false</c>.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum AutoRangeEnum
    {
        [EnumMember(Value = @"true")]
        True = 0,

        [EnumMember(Value = @"False")]
        False,

        [EnumMember(Value = @"reversed")]
        Reversed
    }
}
