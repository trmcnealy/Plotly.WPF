using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Layouts
{
    /// <summary>
    ///     When <c>dragmode</c> is set to <c>select</c>, this limits the selection
    ///     of the drag to horizontal, vertical or diagonal. <c>h</c> only allows horizontal
    ///     selection, <c>v</c> only vertical, <c>d</c> only diagonal and <c>any</c>
    ///     sets no limit.
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum SelectDirectionEnum
    {
        [EnumMember(Value=@"any")]
        Any = 0,
        [EnumMember(Value=@"h")]
        H,
        [EnumMember(Value=@"v")]
        V,
        [EnumMember(Value=@"d")]
        D
    }
}