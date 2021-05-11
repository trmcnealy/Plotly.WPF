using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Plotly.Models.Traces.TreeMaps.PathBars
{
    /// <summary>
    ///     Determines which shape is used for edges between <c>barpath</c> labels.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum EdgeShapeEnum
    {
        [EnumMember(Value = @">")]
        GreaterThan = 0,

        [EnumMember(Value = @"<")]
        LessThan,

        [EnumMember(Value = @"|")]
        VerticalBar,

        [EnumMember(Value = @"/")]
        Slash,

        [EnumMember(Value = @"\")]
        Backslash
    }
}
