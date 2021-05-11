using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Plotly.Models.Traces.ParCatss
{
    /// <summary>
    ///     Sets the drag interaction mode for categories and dimensions. If <c>perpendicular</c>,
    ///     the categories can only move along a line perpendicular to the paths. If
    ///     <c>freeform</c>, the categories can freely move on the plane. If <c>fixed</c>,
    ///     the categories and dimensions are stationary.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum ArrangementEnum
    {
        [EnumMember(Value = @"perpendicular")]
        Perpendicular = 0,

        [EnumMember(Value = @"freeform")]
        FreeForm,

        [EnumMember(Value = @"fixed")]
        Fixed
    }
}
