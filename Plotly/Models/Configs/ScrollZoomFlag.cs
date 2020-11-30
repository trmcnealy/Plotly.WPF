using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Configs
{
    /// <summary>
    ///     Determines whether mouse wheel or two-finger scroll zooms is enable. Turned
    ///     on by default for gl3d, geo and mapbox subplots (as these subplot types
    ///     do not have zoombox via pan), but turned off by default for cartesian subplots.
    ///     Set <c>scrollZoom</c> to <c>false</c> to disable scrolling for all subplots.
    /// </summary>
    
    [Flags]
    [JsonConverter(typeof(EnumConverter))]
    public enum ScrollZoomFlag
    {
        [EnumMember(Value=@"True")]
        True = 0,
        [EnumMember(Value=@"False")]
        False = 1,
        [EnumMember(Value=@"cartesian")]
        Cartesian = 2,
        [EnumMember(Value=@"gl3d")]
        Gl3D = 4,
        [EnumMember(Value=@"geo")]
        Geo = 8,
        [EnumMember(Value=@"mapbox")]
        MapBox = 16
    }
}