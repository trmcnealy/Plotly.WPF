using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.TreeMaps.Tilings
{
    /// <summary>
    ///     Determines d3 treemap solver. For more info please refer to https://github.com/d3/d3-hierarchy#treemap-tiling
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum PackingEnum
    {
        [EnumMember(Value=@"squarify")]
        Squarify = 0,
        [EnumMember(Value=@"binary")]
        Binary,
        [EnumMember(Value=@"dice")]
        Dice,
        [EnumMember(Value=@"slice")]
        Slice,
        [EnumMember(Value=@"slice-dice")]
        SliceDice,
        [EnumMember(Value=@"dice-slice")]
        DiceSlice
    }
}