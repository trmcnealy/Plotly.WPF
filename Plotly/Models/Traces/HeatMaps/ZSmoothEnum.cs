using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.HeatMaps
{
    /// <summary>
    ///     Picks a smoothing algorithm use to smooth <c>z</c> data.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum ZSmoothEnum
    {
        [EnumMember(Value = @"false")]
        False = 0,

        [EnumMember(Value = @"fast")]
        Fast,

        [EnumMember(Value = @"best")]
        Best
    }
}
