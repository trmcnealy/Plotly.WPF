using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Layouts.Shapes
{
    /// <summary>
    ///     Specifies the shape type to be drawn. If <c>line</c>, a line is drawn from
    ///     (<c>x0</c>,<c>y0</c>) to (<c>x1</c>,<c>y1</c>) with respect to the axes&#39;
    ///     sizing mode. If <c>circle</c>, a circle is drawn from ((<c>x0</c>+<c>x1</c>)/2,
    ///     (<c>y0</c>+<c>y1</c>)/2)) with radius (|(<c>x0</c>+<c>x1</c>)/2 - <c>x0</c>|,
    ///     |(<c>y0</c>+<c>y1</c>)/2 -<c>y0</c>)|) with respect to the axes&#39; sizing
    ///     mode. If <c>rect</c>, a rectangle is drawn linking (<c>x0</c>,<c>y0</c>),
    ///     (<c>x1</c>,<c>y0</c>), (<c>x1</c>,<c>y1</c>), (<c>x0</c>,<c>y1</c>), (<c>x0</c>,<c>y0</c>)
    ///     with respect to the axes&#39; sizing mode. If <c>path</c>, draw a custom
    ///     SVG path using <c>path</c>. with respect to the axes&#39; sizing mode.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum TypeEnum
    {
        [EnumMember(Value = @"circle")]
        Circle,

        [EnumMember(Value = @"rect")]
        Rect,

        [EnumMember(Value = @"path")]
        Path,

        [EnumMember(Value = @"line")]
        Line
    }
}
