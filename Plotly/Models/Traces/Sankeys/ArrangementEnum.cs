using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Plotly.Models.Traces.Sankeys
{
    /// <summary>
    ///     If value is <c>snap</c> (the default), the node arrangement is assisted
    ///     by automatic snapping of elements to preserve space between nodes specified
    ///     via <c>nodepad</c>. If value is <c>perpendicular</c>, the nodes can only
    ///     move along a line perpendicular to the flow. If value is <c>freeform</c>,
    ///     the nodes can freely move on the plane. If value is <c>fixed</c>, the nodes
    ///     are stationary.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum ArrangementEnum
    {
        [EnumMember(Value = @"snap")]
        Snap = 0,

        [EnumMember(Value = @"perpendicular")]
        Perpendicular,

        [EnumMember(Value = @"freeform")]
        FreeForm,

        [EnumMember(Value = @"fixed")]
        Fixed
    }
}
