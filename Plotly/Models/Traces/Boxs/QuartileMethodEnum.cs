using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.Boxs
{
    /// <summary>
    ///     Sets the method used to compute the sample&#39;s Q1 and Q3 quartiles. The
    ///     <c>linear</c> method uses the 25th percentile for Q1 and 75th percentile
    ///     for Q3 as computed using method #10 (listed on http://www.amstat.org/publications/jse/v14n3/langford.html).
    ///     The <c>exclusive</c> method uses the median to divide the ordered dataset
    ///     into two halves if the sample is odd, it does not include the median in
    ///     either half - Q1 is then the median of the lower half and Q3 the median
    ///     of the upper half. The <c>inclusive</c> method also uses the median to divide
    ///     the ordered dataset into two halves but if the sample is odd, it includes
    ///     the median in both halves - Q1 is then the median of the lower half and
    ///     Q3 the median of the upper half.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum QuartileMethodEnum
    {
        [EnumMember(Value = @"linear")]
        Linear = 0,

        [EnumMember(Value = @"exclusive")]
        Exclusive,

        [EnumMember(Value = @"inclusive")]
        Inclusive
    }
}
