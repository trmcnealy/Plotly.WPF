using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.ScatterGls
{
    /// <summary>
    ///     Sets the area to fill with a solid color. Defaults to <c>none</c> unless
    ///     this trace is stacked, then it gets <c>tonexty</c> (<c>tonextx</c>) if <c>orientation</c>
    ///     is <c>v</c> (<c>h</c>) Use with <c>fillcolor</c> if not <c>none</c>. <c>tozerox</c>
    ///     and <c>tozeroy</c> fill to x=0 and y=0 respectively. <c>tonextx</c> and
    ///     <c>tonexty</c> fill between the endpoints of this trace and the endpoints
    ///     of the trace before it, connecting those endpoints with straight lines (to
    ///     make a stacked area graph); if there is no trace before it, they behave
    ///     like <c>tozerox</c> and <c>tozeroy</c>. <c>toself</c> connects the endpoints
    ///     of the trace (or each segment of the trace if it has gaps) into a closed
    ///     shape. <c>tonext</c> fills the space between two traces if one completely
    ///     encloses the other (eg consecutive contour lines), and behaves like <c>toself</c>
    ///     if there is no trace before it. <c>tonext</c> should not be used if one
    ///     trace does not enclose the other. Traces in a <c>stackgroup</c> will only
    ///     fill to (or be filled to) other traces in the same group. With multiple
    ///     <c>stackgroup</c>s or some traces stacked and some not, if fill-linked traces
    ///     are not already consecutive, the later ones will be pushed down in the drawing
    ///     order.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum FillEnum
    {
        [EnumMember(Value = @"none")]
        None = 0,

        [EnumMember(Value = @"tozeroy")]
        ToZeroY,

        [EnumMember(Value = @"tozerox")]
        ToZeroX,

        [EnumMember(Value = @"tonexty")]
        ToNextY,

        [EnumMember(Value = @"tonextx")]
        ToNextX,

        [EnumMember(Value = @"toself")]
        ToSelf,

        [EnumMember(Value = @"tonext")]
        ToNext
    }
}
