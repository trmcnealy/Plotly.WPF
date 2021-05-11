using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Plotly.Models.Traces.TreeMaps.Markers
{
    /// <summary>
    ///     Determines if the sector colors are faded towards the background from the
    ///     leaves up to the headers. This option is unavailable when a <c>colorscale</c>
    ///     is present, defaults to false when <c>marker.colors</c> is set, but otherwise
    ///     defaults to true. When set to <c>reversed</c>, the fading direction is inverted,
    ///     that is the top elements within hierarchy are drawn with fully saturated
    ///     colors while the leaves are faded towards the background color.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum DepthFadeEnum
    {
        [EnumMember(Value = @"True")]
        True,

        [EnumMember(Value = @"False")]
        False,

        [EnumMember(Value = @"reversed")]
        Reversed
    }
}
