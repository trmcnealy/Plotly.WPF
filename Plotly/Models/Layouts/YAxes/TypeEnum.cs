using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Layouts.YAxes
{
    /// <summary>
    ///     Sets the axis type. By default, plotly attempts to determined the axis type
    ///     by looking into the data of the traces that referenced the axis in question.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum TypeEnum
    {
        [EnumMember(Value = @"-")]
        Minus = 0,

        [EnumMember(Value = @"linear")]
        Linear,

        [EnumMember(Value = @"log")]
        Log,

        [EnumMember(Value = @"date")]
        Date,

        [EnumMember(Value = @"category")]
        Category,

        [EnumMember(Value = @"multicategory")]
        MultiCategory
    }
}
