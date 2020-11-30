using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Plotly.Models.Traces.TreeMaps
{
    /// <summary>
    ///     Determines how the items in <c>values</c> are summed. When set to <c>total</c>,
    ///     items in <c>values</c> are taken to be value of all its descendants. When
    ///     set to <c>remainder</c>, items in <c>values</c> corresponding to the root
    ///     and the branches sectors are taken to be the extra part not part of the
    ///     sum of the values at their leaves.
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum BranchValuesEnum
    {
        [EnumMember(Value=@"remainder")]
        Remainder = 0,
        [EnumMember(Value=@"total")]
        Total
    }
}