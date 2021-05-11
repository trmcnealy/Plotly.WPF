using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Layouts.Geos
{
    /// <summary>
    ///     Set the scope of the map.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum ScopeEnum
    {
        [EnumMember(Value = @"world")]
        World = 0,

        [EnumMember(Value = @"usa")]
        USA,

        [EnumMember(Value = @"europe")]
        Europe,

        [EnumMember(Value = @"asia")]
        Asia,

        [EnumMember(Value = @"africa")]
        Africa,

        [EnumMember(Value = @"north america")]
        NorthAmerica,

        [EnumMember(Value = @"south america")]
        SouthAmerica
    }
}
