using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Plotly.Models.Configs
{
    /// <summary>
    ///     Sets the double click interaction mode. Has an effect only in cartesian
    ///     plots. If <c>false</c>, double click is disable. If <c>reset</c>, double
    ///     click resets the axis ranges to their initial values. If <c>autosize</c>,
    ///     double click set the axis ranges to their autorange values. If <c>reset+autosize</c>,
    ///     the odd double clicks resets the axis ranges to their initial values and
    ///     even double clicks set the axis ranges to their autorange values.
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum DoubleClickEnum
    {
        [EnumMember(Value=@"reset+autosize")]
        ResetAutoSize = 0,
        [EnumMember(Value=@"False")]
        False,
        [EnumMember(Value=@"reset")]
        Reset,
        [EnumMember(Value=@"autosize")]
        AutoSize
    }
}