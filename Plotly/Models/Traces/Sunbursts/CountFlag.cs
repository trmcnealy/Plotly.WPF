using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Plotly.Models.Traces.Sunbursts
{
    /// <summary>
    ///     Determines default for <c>values</c> when it is not provided, by inferring
    ///     a 1 for each of the <c>leaves</c> and/or <c>branches</c>, otherwise 0.
    /// </summary>
    
    [Flags]
    [JsonConverter(typeof(EnumConverter))]
    public enum CountFlag
    {
        [EnumMember(Value=@"branches")]
        Branches = 0,
        [EnumMember(Value=@"leaves")]
        Leaves = 1
    }
}