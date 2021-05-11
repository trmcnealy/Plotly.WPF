using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Layouts.Scenes.Annotations
{
    /// <summary>
    ///     Sets the vertical alignment of the <c>text</c> within the box. Has an effect
    ///     only if an explicit height is set to override the text height.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum VAlignEnum
    {
        [EnumMember(Value = @"middle")]
        Middle = 0,

        [EnumMember(Value = @"top")]
        Top,

        [EnumMember(Value = @"bottom")]
        Bottom
    }
}
