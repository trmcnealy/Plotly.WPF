using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.ParCoordss
{
    /// <summary>
    ///     Specifies the location of the <c>label</c>. <c>top</c> positions labels
    ///     above, next to the title <c>bottom</c> positions labels below the graph
    ///     Tilted labels with <c>labelangle</c> may be positioned better inside margins
    ///     when <c>labelposition</c> is set to <c>bottom</c>.
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum LabelSideEnum
    {
        [EnumMember(Value=@"top")]
        Top = 0,
        [EnumMember(Value=@"bottom")]
        Bottom
    }
}