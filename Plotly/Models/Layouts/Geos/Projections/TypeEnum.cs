using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Layouts.Geos.Projections
{
    /// <summary>
    ///     Sets the projection type.
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum TypeEnum
    {
        [EnumMember(Value=@"equirectangular")]
        EquiRectangular,
        [EnumMember(Value=@"mercator")]
        Mercator,
        [EnumMember(Value=@"orthographic")]
        Orthographic,
        [EnumMember(Value=@"natural earth")]
        NaturalEarth,
        [EnumMember(Value=@"kavrayskiy7")]
        Kavrayskiy7,
        [EnumMember(Value=@"miller")]
        Miller,
        [EnumMember(Value=@"robinson")]
        Robinson,
        [EnumMember(Value=@"eckert4")]
        Eckert4,
        [EnumMember(Value=@"azimuthal equal area")]
        AzimuthalEqualArea,
        [EnumMember(Value=@"azimuthal equidistant")]
        AzimuthalEquidistant,
        [EnumMember(Value=@"conic equal area")]
        ConicEqualArea,
        [EnumMember(Value=@"conic conformal")]
        ConicConFormal,
        [EnumMember(Value=@"conic equidistant")]
        ConicEquidistant,
        [EnumMember(Value=@"gnomonic")]
        Gnomonic,
        [EnumMember(Value=@"stereographic")]
        StereoGraphic,
        [EnumMember(Value=@"mollweide")]
        Mollweide,
        [EnumMember(Value=@"hammer")]
        Hammer,
        [EnumMember(Value=@"transverse mercator")]
        TransverseMercator,
        [EnumMember(Value=@"albers usa")]
        AlbersUSA,
        [EnumMember(Value=@"winkel tripel")]
        WinkelTripeL,
        [EnumMember(Value=@"aitoff")]
        Aitoff,
        [EnumMember(Value=@"sinusoidal")]
        Sinusoidal
    }
}