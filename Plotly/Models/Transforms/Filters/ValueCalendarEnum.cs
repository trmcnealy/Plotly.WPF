using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Transforms.Filters
{
    /// <summary>
    ///     Sets the calendar system to use for <c>value</c>, if it is a date.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum ValueCalendarEnum
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
