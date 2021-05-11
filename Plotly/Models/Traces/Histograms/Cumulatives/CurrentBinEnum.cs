using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Plotly.Models.Traces.Histograms.Cumulatives
{
    /// <summary>
    ///     Only applies if cumulative is enabled. Sets whether the current bin is included,
    ///     excluded, or has half of its value included in the current cumulative value.
    ///     <c>include</c> is the default for compatibility with various other tools,
    ///     however it introduces a half-bin bias to the results. <c>exclude</c> makes
    ///     the opposite half-bin bias, and <c>half</c> removes it.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum CurrentBinEnum
    {
        [EnumMember(Value = @"include")]
        Include = 0,

        [EnumMember(Value = @"exclude")]
        Exclude,

        [EnumMember(Value = @"half")]
        Half
    }
}
