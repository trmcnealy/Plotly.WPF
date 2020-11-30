using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Plotly.Models.Layouts.Polars.AngularAxes
{
    /// <summary>
    ///     Sets the direction corresponding to positive angles.
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum DirectionEnum
    {
        [EnumMember(Value=@"counterclockwise")]
        Counterclockwise = 0,
        [EnumMember(Value=@"clockwise")]
        Clockwise
    }
}