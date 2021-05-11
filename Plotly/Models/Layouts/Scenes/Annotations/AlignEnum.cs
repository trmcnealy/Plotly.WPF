using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Plotly.Models.Layouts.Scenes.Annotations
{
    /// <summary>
    ///     Sets the horizontal alignment of the <c>text</c> within the box. Has an
    ///     effect only if <c>text</c> spans two or more lines (i.e. <c>text</c> contains
    ///     one or more &lt;br&gt; HTML tags) or if an explicit width is set to override
    ///     the text width.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum AlignEnum
    {
        [EnumMember(Value = @"center")]
        Center = 0,

        [EnumMember(Value = @"left")]
        Left,

        [EnumMember(Value = @"right")]
        Right
    }
}
