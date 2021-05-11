using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.BarPolars
{
    /// <summary>
    ///     Sets the unit of input <c>theta</c> values. Has an effect only when on <c>linear</c>
    ///     angular axes.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum ThetaUnitEnum
    {
        [EnumMember(Value = @"degrees")]
        Degrees = 0,

        [EnumMember(Value = @"radians")]
        Radians,

        [EnumMember(Value = @"gradians")]
        Gradians
    }
}
