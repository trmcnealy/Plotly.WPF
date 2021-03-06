using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.Contours.Contourss
{
    /// <summary>
    ///     Sets the constraint operation. <c>=</c> keeps regions equal to <c>value</c>
    ///     <c>&lt;</c> and <c>&lt;=</c> keep regions less than <c>value</c> <c>&gt;</c>
    ///     and <c>&gt;=</c> keep regions greater than <c>value</c> <c>[]</c>, <c>()</c>,
    ///     <c>[)</c>, and <c>(]</c> keep regions inside <c>value[0]</c> to <c>value[1]</c>
    ///     <c>][</c>, <c>)(</c>, <c>](</c>, <c>)[</c> keep regions outside <c>value[0]</c>
    ///     to value[1]` Open vs. closed intervals make no difference to constraint
    ///     display, but all versions are allowed for consistency with filter transforms.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum OperationEnum
    {
        [EnumMember(Value = @"=")]
        Equal = 0,

        [EnumMember(Value = @"<")]
        LessThan,

        [EnumMember(Value = @">=")]
        GreaterThanOrEqual,

        [EnumMember(Value = @">")]
        GreaterThan,

        [EnumMember(Value = @"<=")]
        LessThanOrEqual,

        [EnumMember(Value = @"[]")]
        OpeningSquareBracketClosingSquareBracket,

        [EnumMember(Value = @"()")]
        OpeningRoundBracketClosingRoundBracket,

        [EnumMember(Value = @"[)")]
        OpeningSquareBracketClosingRoundBracket,

        [EnumMember(Value = @"(]")]
        OpeningRoundBracketClosingSquareBracket,

        [EnumMember(Value = @"][")]
        ClosingSquareBracketOpeningSquareBracket,

        [EnumMember(Value = @")(")]
        ClosingRoundBracketOpeningRoundBracket,

        [EnumMember(Value = @"](")]
        ClosingSquareBracketOpeningRoundBracket,

        [EnumMember(Value = @")[")]
        ClosingRoundBracketOpeningSquareBracket
    }
}
