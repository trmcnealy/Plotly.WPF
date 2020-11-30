using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Layouts.Images
{
    /// <summary>
    ///     Specifies which dimension of the image to constrain.
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum SizingEnum
    {
        [EnumMember(Value=@"contain")]
        Contain = 0,
        [EnumMember(Value=@"fill")]
        Fill,
        [EnumMember(Value=@"stretch")]
        Stretch
    }
}