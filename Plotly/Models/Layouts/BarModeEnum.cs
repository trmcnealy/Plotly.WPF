using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Plotly.Models.Layouts
{
    /// <summary>
    ///     Determines how bars at the same location coordinate are displayed on the
    ///     graph. With <c>stack</c>, the bars are stacked on top of one another With
    ///     <c>relative</c>, the bars are stacked on top of one another, with negative
    ///     values below the axis, positive values above With <c>group</c>, the bars
    ///     are plotted next to one another centered around the shared location. With
    ///     <c>overlay</c>, the bars are plotted over one another, you might need to
    ///     an <c>opacity</c> to see multiple bars.
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum BarModeEnum
    {
        [EnumMember(Value=@"group")]
        Group = 0,
        [EnumMember(Value=@"stack")]
        Stack,
        [EnumMember(Value=@"overlay")]
        Overlay,
        [EnumMember(Value=@"relative")]
        Relative
    }
}