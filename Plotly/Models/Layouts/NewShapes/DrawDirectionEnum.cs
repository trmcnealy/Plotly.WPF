using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Plotly.Models.Layouts.NewShapes
{
    /// <summary>
    ///     When <c>dragmode</c> is set to <c>drawrect</c>, <c>drawline</c> or <c>drawcircle</c>
    ///     this limits the drag to be horizontal, vertical or diagonal. Using <c>diagonal</c>
    ///     there is no limit e.g. in drawing lines in any direction. <c>ortho</c> limits
    ///     the draw to be either horizontal or vertical. <c>horizontal</c> allows horizontal
    ///     extend. <c>vertical</c> allows vertical extend.
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum DrawDirectionEnum
    {
        [EnumMember(Value=@"diagonal")]
        Diagonal = 0,
        [EnumMember(Value=@"ortho")]
        OrTho,
        [EnumMember(Value=@"horizontal")]
        Horizontal,
        [EnumMember(Value=@"vertical")]
        Vertical
    }
}