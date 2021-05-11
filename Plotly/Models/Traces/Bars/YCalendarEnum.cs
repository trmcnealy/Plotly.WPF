using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces.Bars
{
    /// <summary>
    ///     Sets the calendar system to use with <c>y</c> date data.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum YCalendarEnum
    {
        [EnumMember(Value = @"gregorian")]
        Gregorian = 0,

        [EnumMember(Value = @"chinese")]
        Chinese,

        [EnumMember(Value = @"coptic")]
        Coptic,

        [EnumMember(Value = @"discworld")]
        DiscWorld,

        [EnumMember(Value = @"ethiopian")]
        Ethiopian,

        [EnumMember(Value = @"hebrew")]
        Hebrew,

        [EnumMember(Value = @"islamic")]
        Islamic,

        [EnumMember(Value = @"julian")]
        Julian,

        [EnumMember(Value = @"mayan")]
        Mayan,

        [EnumMember(Value = @"nanakshahi")]
        Nanakshahi,

        [EnumMember(Value = @"nepali")]
        Nepali,

        [EnumMember(Value = @"persian")]
        Persian,

        [EnumMember(Value = @"jalali")]
        Jalali,

        [EnumMember(Value = @"taiwan")]
        Taiwan,

        [EnumMember(Value = @"thai")]
        Thai,

        [EnumMember(Value = @"ummalqura")]
        Ummalqura
    }
}
