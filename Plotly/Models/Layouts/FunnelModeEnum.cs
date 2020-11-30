using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Layouts
{
    /// <summary>
    ///     Determines how bars at the same location coordinate are displayed on the
    ///     graph. With <c>stack</c>, the bars are stacked on top of one another With
    ///     <c>group</c>, the bars are plotted next to one another centered around the
    ///     shared location. With <c>overlay</c>, the bars are plotted over one another,
    ///     you might need to an <c>opacity</c> to see multiple bars.
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum FunnelModeEnum
    {
        [EnumMember(Value=@"stack")]
        Stack = 0,
        [EnumMember(Value=@"group")]
        Group,
        [EnumMember(Value=@"overlay")]
        Overlay
    }
}