using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Layouts.Grids
{
    /// <summary>
    ///     Is the first row the top or the bottom? Note that columns are always enumerated
    ///     from left to right.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum RowOrderEnum
    {
        [EnumMember(Value = @"top to bottom")]
        TopToBottom = 0,

        [EnumMember(Value = @"bottom to top")]
        BottomToTop
    }
}
