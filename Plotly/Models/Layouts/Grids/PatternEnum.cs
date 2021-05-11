using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Layouts.Grids
{
    /// <summary>
    ///     If no <c>subplots</c>, <c>xaxes</c>, or <c>yaxes</c> are given but we do
    ///     have <c>rows</c> and <c>columns</c>, we can generate defaults using consecutive
    ///     axis IDs, in two ways: <c>coupled</c> gives one x axis per column and one
    ///     y axis per row. <c>independent</c> uses a new xy pair for each cell, left-to-right
    ///     across each row then iterating rows according to <c>roworder</c>.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum PatternEnum
    {
        [EnumMember(Value = @"coupled")]
        Coupled = 0,

        [EnumMember(Value = @"independent")]
        Independent
    }
}
