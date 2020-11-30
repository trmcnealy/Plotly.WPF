using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Layouts.Legends
{
    /// <summary>
    ///     Determines the behavior on legend item double-click. <c>toggle</c> toggles
    ///     the visibility of the item clicked on the graph. <c>toggleothers</c> makes
    ///     the clicked item the sole visible item on the graph. <c>false</c> disable
    ///     legend item double-click interactions.
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum ItemDoubleClickEnum
    {
        [EnumMember(Value=@"toggleothers")]
        ToggleOthers = 0,
        [EnumMember(Value=@"toggle")]
        Toggle,
        [EnumMember(Value=@"False")]
        False
    }
}