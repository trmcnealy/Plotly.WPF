using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Plotly.Models.Traces.DensityMapBoxs.HoverLabels
{
    /// <summary>
    ///     Sets the horizontal alignment of the text content within hover label box.
    ///     Has an effect only if the hover label text spans more two or more lines
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum AlignEnum
    {
        [EnumMember(Value=@"auto")]
        Auto = 0,
        [EnumMember(Value=@"left")]
        Left,
        [EnumMember(Value=@"right")]
        Right
    }
}