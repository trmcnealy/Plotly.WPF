using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.TreeMaps.PathBars
{
    /// <summary>
    ///     Determines on which side of the the treemap the <c>pathbar</c> should be
    ///     presented.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum SideEnum
    {
        [EnumMember(Value = @"top")]
        Top = 0,

        [EnumMember(Value = @"bottom")]
        Bottom
    }
}
