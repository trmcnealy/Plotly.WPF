using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Layouts.Polars.AngularAxes
{
    /// <summary>
    ///     Sets the angular axis type. If <c>linear</c>, set <c>thetaunit</c> to determine
    ///     the unit in which axis value are shown. If *category, use <c>period</c>
    ///     to set the number of integer coordinates around polar axis.
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum TypeEnum
    {
        [EnumMember(Value=@"-")]
        Minus = 0,
        [EnumMember(Value=@"linear")]
        Linear,
        [EnumMember(Value=@"category")]
        Category
    }
}