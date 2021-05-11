using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Layouts.Legends
{
    /// <summary>
    ///     Determines the behavior on legend item click. <c>toggle</c> toggles the
    ///     visibility of the item clicked on the graph. <c>toggleothers</c> makes the
    ///     clicked item the sole visible item on the graph. <c>false</c> disable legend
    ///     item click interactions.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum ItemClickEnum
    {
        [EnumMember(Value = @"toggle")]
        Toggle = 0,

        [EnumMember(Value = @"toggleothers")]
        ToggleOthers,

        [EnumMember(Value = @"False")]
        False
    }
}
