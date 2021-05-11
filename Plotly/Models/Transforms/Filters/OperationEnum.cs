using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Transforms.Filters
{
    /// <summary>
    ///     Sets the filter operation. <c>=</c> keeps items equal to <c>value</c> <c>!=</c>
    ///     keeps items not equal to <c>value</c> <c>&lt;</c> keeps items less than
    ///     <c>value</c> <c>&lt;=</c> keeps items less than or equal to <c>value</c>
    ///     <c>&gt;</c> keeps items greater than <c>value</c> <c>&gt;=</c> keeps items
    ///     greater than or equal to <c>value</c> <c>[]</c> keeps items inside <c>value[0]</c>
    ///     to <c>value[1]</c> including both bounds <c>()</c> keeps items inside <c>value[0]</c>
    ///     to <c>value[1]</c> excluding both bounds <c>[)</c> keeps items inside <c>value[0]</c>
    ///     to <c>value[1]</c> including <c>value[0]</c> but excluding &#39;value[1]
    ///     <c>(]</c> keeps items inside <c>value[0]</c> to <c>value[1]</c> excluding
    ///     <c>value[0]</c> but including &#39;value[1] <c>][</c> keeps items outside
    ///     <c>value[0]</c> to <c>value[1]</c> and equal to both bounds <c>)(</c> keeps
    ///     items outside <c>value[0]</c> to <c>value[1]</c> <c>](</c> keeps items outside
    ///     <c>value[0]</c> to <c>value[1]</c> and equal to <c>value[0]</c> <c>)[</c>
    ///     keeps items outside <c>value[0]</c> to <c>value[1]</c> and equal to <c>value[1]</c>
    ///     <c>{}</c> keeps items present in a set of values <c>}{</c> keeps items not
    ///     present in a set of values
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum OperationEnum
    {
        [EnumMember(Value = @"=")]
        Equal = 0,

        [EnumMember(Value = @"!=")]
        NotEqual,

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
        ClosingRoundBracketOpeningSquareBracket,

        [EnumMember(Value = @"{}")]
        OpeningCurlyBracketClosingCurlyBracket,

        [EnumMember(Value = @"}{")]
        ClosingCurlyBracketOpeningCurlyBracket
    }
}
