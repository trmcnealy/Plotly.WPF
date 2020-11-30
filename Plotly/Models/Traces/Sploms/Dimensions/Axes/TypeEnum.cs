using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.Sploms.Dimensions.Axes
{
    /// <summary>
    ///     Sets the axis type for this dimension&#39;s generated x and y axes. Note
    ///     that the axis <c>type</c> values set in layout take precedence over this
    ///     attribute.
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum TypeEnum
    {
        [EnumMember(Value=@"linear")]
        Linear,
        [EnumMember(Value=@"log")]
        Log,
        [EnumMember(Value=@"date")]
        Date,
        [EnumMember(Value=@"category")]
        Category
    }
}