using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Plotly.Models.Layouts.UpdateMenus
{
    /// <summary>
    ///     Determines the direction in which the buttons are laid out, whether in a
    ///     dropdown menu or a row/column of buttons. For <c>left</c> and <c>up</c>,
    ///     the buttons will still appear in left-to-right or top-to-bottom order respectively.
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum DirectionEnum
    {
        [EnumMember(Value=@"down")]
        Down = 0,
        [EnumMember(Value=@"left")]
        Left,
        [EnumMember(Value=@"right")]
        Right,
        [EnumMember(Value=@"up")]
        Up
    }
}