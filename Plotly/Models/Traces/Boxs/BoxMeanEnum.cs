using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Plotly.Models.Traces.Boxs
{
    /// <summary>
    ///     If <c>true</c>, the mean of the box(es)&#39; underlying distribution is
    ///     drawn as a dashed line inside the box(es). If <c>sd</c> the standard deviation
    ///     is also drawn. Defaults to <c>true</c> when <c>mean</c> is set. Defaults
    ///     to <c>sd</c> when <c>sd</c> is set Otherwise defaults to <c>false</c>.
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum BoxMeanEnum
    {
        [EnumMember(Value=@"True")]
        True,
        [EnumMember(Value=@"sd")]
        SD,
        [EnumMember(Value=@"False")]
        False
    }
}