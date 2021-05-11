using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Layouts.Images
{
    /// <summary>
    ///     Sets the anchor for the y position.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum YAnchorEnum
    {
        [EnumMember(Value = @"top")]
        Top = 0,

        [EnumMember(Value = @"middle")]
        Middle,

        [EnumMember(Value = @"bottom")]
        Bottom
    }
}
