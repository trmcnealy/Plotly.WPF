using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.ContourCarpets.Contourss
{
    /// <summary>
    ///     If <c>levels</c>, the data is represented as a contour plot with multiple
    ///     levels displayed. If <c>constraint</c>, the data is represented as constraints
    ///     with the invalid region shaded as specified by the <c>operation</c> and
    ///     <c>value</c> parameters.
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum TypeEnum
    {
        [EnumMember(Value=@"levels")]
        Levels = 0,
        [EnumMember(Value=@"constraint")]
        Constraint
    }
}