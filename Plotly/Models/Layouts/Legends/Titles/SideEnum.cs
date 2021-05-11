using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Layouts.Legends.Titles
{
    /// <summary>
    ///     Determines the location of legend&#39;s title with respect to the legend
    ///     items. Defaulted to <c>top</c> with <c>orientation</c> is <c>h</c>. Defaulted
    ///     to <c>left</c> with <c>orientation</c> is <c>v</c>. The &#39;top left&#39;
    ///     options could be used to expand legend area in both x and y sides.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum SideEnum
    {
        [EnumMember(Value = @"top")]
        Top,

        [EnumMember(Value = @"left")]
        Left,

        [EnumMember(Value = @"top left")]
        TopLeft
    }
}
