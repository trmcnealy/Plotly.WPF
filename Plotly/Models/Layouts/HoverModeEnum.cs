using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Layouts
{
    /// <summary>
    ///     Determines the mode of hover interactions. If <c>closest</c>, a single hoverlabel
    ///     will appear for the <c>closest</c> point within the <c>hoverdistance</c>.
    ///     If <c>x</c> (or <c>y</c>), multiple hoverlabels will appear for multiple
    ///     points at the <c>closest</c> x- (or y-) coordinate within the <c>hoverdistance</c>,
    ///     with the caveat that no more than one hoverlabel will appear per trace.
    ///     If &#39;x unified&#39; (or &#39;y unified&#39;), a single hoverlabel will
    ///     appear multiple points at the closest x- (or y-) coordinate within the <c>hoverdistance</c>
    ///     with the caveat that no more than one hoverlabel will appear per trace.
    ///     In this mode, spikelines are enabled by default perpendicular to the specified
    ///     axis. If false, hover interactions are disabled. If <c>clickmode</c> includes
    ///     the <c>select</c> flag, <c>hovermode</c> defaults to <c>closest</c>. If
    ///     <c>clickmode</c> lacks the <c>select</c> flag, it defaults to <c>x</c> or
    ///     <c>y</c> (depending on the trace&#39;s <c>orientation</c> value) for plots
    ///     based on cartesian coordinates. For anything else the default value is <c>closest</c>.
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum HoverModeEnum
    {
        [EnumMember(Value=@"x")]
        X,
        [EnumMember(Value=@"y")]
        Y,
        [EnumMember(Value=@"closest")]
        Closest,
        [EnumMember(Value=@"False")]
        False,
        [EnumMember(Value=@"x unified")]
        XUnified,
        [EnumMember(Value=@"y unified")]
        YUnified
    }
}