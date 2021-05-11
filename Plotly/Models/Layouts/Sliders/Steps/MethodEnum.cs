using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Layouts.Sliders.Steps
{
    /// <summary>
    ///     Sets the Plotly method to be called when the slider value is changed. If
    ///     the <c>skip</c> method is used, the API slider will function as normal but
    ///     will perform no API calls and will not bind automatically to state updates.
    ///     This may be used to create a component interface and attach to slider events
    ///     manually via JavaScript.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum MethodEnum
    {
        [EnumMember(Value = @"restyle")]
        Restyle = 0,

        [EnumMember(Value = @"relayout")]
        ReLayout,

        [EnumMember(Value = @"animate")]
        Animate,

        [EnumMember(Value = @"update")]
        Update,

        [EnumMember(Value = @"skip")]
        Skip
    }
}
