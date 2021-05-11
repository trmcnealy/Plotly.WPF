using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Plotly.Models.Traces.Carpets.BAxes
{
    /// <summary>
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum CheaterTypeEnum
    {
        [EnumMember(Value = @"value")]
        Value = 0,

        [EnumMember(Value = @"index")]
        Index
    }
}
