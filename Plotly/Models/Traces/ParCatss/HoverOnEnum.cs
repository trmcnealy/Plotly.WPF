using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.ParCatss
{
    /// <summary>
    ///     Sets the hover interaction mode for the parcats diagram. If <c>category</c>,
    ///     hover interaction take place per category. If <c>color</c>, hover interactions
    ///     take place per color per category. If <c>dimension</c>, hover interactions
    ///     take place across all categories per dimension.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum HoverOnEnum
    {
        [EnumMember(Value = @"category")]
        Category = 0,

        [EnumMember(Value = @"color")]
        Color,

        [EnumMember(Value = @"dimension")]
        Dimension
    }
}
