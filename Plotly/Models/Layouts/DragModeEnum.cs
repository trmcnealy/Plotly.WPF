using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Plotly.Models.Layouts
{
    /// <summary>
    ///     Determines the mode of drag interactions. <c>select</c> and <c>lasso</c>
    ///     apply only to scatter traces with markers or text. <c>orbit</c> and <c>turntable</c>
    ///     apply only to 3D scenes.
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum DragModeEnum
    {
        [EnumMember(Value=@"zoom")]
        Zoom = 0,
        [EnumMember(Value=@"pan")]
        Pan,
        [EnumMember(Value=@"select")]
        Select,
        [EnumMember(Value=@"lasso")]
        Lasso,
        [EnumMember(Value=@"drawclosedpath")]
        DrawClosedPath,
        [EnumMember(Value=@"drawopenpath")]
        DrawOpenPath,
        [EnumMember(Value=@"drawline")]
        DrawLine,
        [EnumMember(Value=@"drawrect")]
        DrawRect,
        [EnumMember(Value=@"drawcircle")]
        DrawCircle,
        [EnumMember(Value=@"orbit")]
        Orbit,
        [EnumMember(Value=@"turntable")]
        Turntable,
        [EnumMember(Value=@"False")]
        False
    }
}