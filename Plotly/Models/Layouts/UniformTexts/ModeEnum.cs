using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Layouts.UniformTexts
{
    /// <summary>
    ///     Determines how the font size for various text elements are uniformed between
    ///     each trace type. If the computed text sizes were smaller than the minimum
    ///     size defined by <c>uniformtext.minsize</c> using <c>hide</c> option hides
    ///     the text; and using <c>show</c> option shows the text without further downscaling.
    ///     Please note that if the size defined by <c>minsize</c> is greater than the
    ///     font size defined by trace, then the <c>minsize</c> is used.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum ModeEnum
    {
        [EnumMember(Value = @"false")]
        False = 0,

        [EnumMember(Value = @"hide")]
        Hide,

        [EnumMember(Value = @"show")]
        Show
    }
}
