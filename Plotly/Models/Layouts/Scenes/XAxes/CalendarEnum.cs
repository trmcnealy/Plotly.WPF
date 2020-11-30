using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Plotly.Models.Layouts.Scenes.XAxes
{
    /// <summary>
    ///     Sets the calendar system to use for <c>range</c> and <c>tick0</c> if this
    ///     is a date axis. This does not set the calendar for interpreting data on
    ///     this axis, that&#39;s specified in the trace or via the global <c>layout.calendar</c>
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum CalendarEnum
    {
        [EnumMember(Value=@"gregorian")]
        Gregorian = 0,
        [EnumMember(Value=@"chinese")]
        Chinese,
        [EnumMember(Value=@"coptic")]
        Coptic,
        [EnumMember(Value=@"discworld")]
        DiscWorld,
        [EnumMember(Value=@"ethiopian")]
        Ethiopian,
        [EnumMember(Value=@"hebrew")]
        Hebrew,
        [EnumMember(Value=@"islamic")]
        Islamic,
        [EnumMember(Value=@"julian")]
        Julian,
        [EnumMember(Value=@"mayan")]
        Mayan,
        [EnumMember(Value=@"nanakshahi")]
        Nanakshahi,
        [EnumMember(Value=@"nepali")]
        Nepali,
        [EnumMember(Value=@"persian")]
        Persian,
        [EnumMember(Value=@"jalali")]
        Jalali,
        [EnumMember(Value=@"taiwan")]
        Taiwan,
        [EnumMember(Value=@"thai")]
        Thai,
        [EnumMember(Value=@"ummalqura")]
        Ummalqura
    }
}