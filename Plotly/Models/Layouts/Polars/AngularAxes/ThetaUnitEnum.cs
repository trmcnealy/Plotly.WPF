using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Layouts.Polars.AngularAxes
{
    /// <summary>
    ///     Sets the format unit of the formatted <c>theta</c> values. Has an effect
    ///     only when <c>angularaxis.type</c> is <c>linear</c>.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum ThetaUnitEnum
    {
        [EnumMember(Value = @"degrees")]
        Degrees = 0,

        [EnumMember(Value = @"radians")]
        Radians
    }
}
