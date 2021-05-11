using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Layouts.Shapes
{
    /// <summary>
    ///     Sets the shapes&#39;s sizing mode along the x axis. If set to <c>scaled</c>,
    ///     <c>x0</c>, <c>x1</c> and x coordinates within <c>path</c> refer to data
    ///     values on the x axis or a fraction of the plot area&#39;s width (<c>xref</c>
    ///     set to <c>paper</c>). If set to <c>pixel</c>, <c>xanchor</c> specifies the
    ///     x position in terms of data or plot fraction but <c>x0</c>, <c>x1</c> and
    ///     x coordinates within <c>path</c> are pixels relative to <c>xanchor</c>.
    ///     This way, the shape can have a fixed width while maintaining a position
    ///     relative to data or plot fraction.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum XSizeModeEnum
    {
        [EnumMember(Value = @"scaled")]
        Scaled = 0,

        [EnumMember(Value = @"pixel")]
        Pixel
    }
}
