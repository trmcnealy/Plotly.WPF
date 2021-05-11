using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Transforms.Sorts
{
    /// <summary>
    ///     Sets the sort transform order.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum OrderEnum
    {
        [EnumMember(Value = @"ascending")]
        Ascending = 0,

        [EnumMember(Value = @"descending")]
        Descending
    }
}
