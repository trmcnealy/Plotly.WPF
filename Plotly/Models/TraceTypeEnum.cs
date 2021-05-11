using System.Text.Json.Serialization;
using System.Runtime.Serialization;

#pragma warning disable 1591

namespace Plotly.Models
{
    /// <summary>
    ///     Determines the type of the trace.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum TraceTypeEnum
    {
        [EnumMember(Value = @"scatter")]
        Scatter,

        [EnumMember(Value = @"bar")]
        Bar,

        [EnumMember(Value = @"box")]
        Box,

        [EnumMember(Value = @"heatmap")]
        HeatMap,

        [EnumMember(Value = @"histogram")]
        Histogram,

        [EnumMember(Value = @"histogram2d")]
        Histogram2D,

        [EnumMember(Value = @"histogram2dcontour")]
        Histogram2DContour,

        [EnumMember(Value = @"contour")]
        Contour,

        [EnumMember(Value = @"scatterternary")]
        ScatterTernary,

        [EnumMember(Value = @"violin")]
        Violin,

        [EnumMember(Value = @"funnel")]
        Funnel,

        [EnumMember(Value = @"waterfall")]
        Waterfall,

        [EnumMember(Value = @"image")]
        Image,

        [EnumMember(Value = @"pie")]
        Pie,

        [EnumMember(Value = @"sunburst")]
        Sunburst,

        [EnumMember(Value = @"treemap")]
        TreeMap,

        [EnumMember(Value = @"funnelarea")]
        FunnelArea,

        [EnumMember(Value = @"scatter3d")]
        Scatter3D,

        [EnumMember(Value = @"surface")]
        Surface,

        [EnumMember(Value = @"isosurface")]
        IsoSurface,

        [EnumMember(Value = @"volume")]
        Volume,

        [EnumMember(Value = @"mesh3d")]
        Mesh3D,

        [EnumMember(Value = @"cone")]
        Cone,

        [EnumMember(Value = @"streamtube")]
        StreamTube,

        [EnumMember(Value = @"scattergeo")]
        ScatterGeo,

        [EnumMember(Value = @"choropleth")]
        Choropleth,

        [EnumMember(Value = @"scattergl")]
        ScatterGl,

        [EnumMember(Value = @"splom")]
        Splom,

        [EnumMember(Value = @"pointcloud")]
        PointCloud,

        [EnumMember(Value = @"heatmapgl")]
        HeatMapGl,

        [EnumMember(Value = @"parcoords")]
        ParCoords,

        [EnumMember(Value = @"parcats")]
        ParCats,

        [EnumMember(Value = @"scattermapbox")]
        ScatterMapBox,

        [EnumMember(Value = @"choroplethmapbox")]
        ChoroplethMapBox,

        [EnumMember(Value = @"densitymapbox")]
        DensityMapBox,

        [EnumMember(Value = @"sankey")]
        Sankey,

        [EnumMember(Value = @"indicator")]
        Indicator,

        [EnumMember(Value = @"table")]
        Table,

        [EnumMember(Value = @"carpet")]
        Carpet,

        [EnumMember(Value = @"scattercarpet")]
        ScatterCarpet,

        [EnumMember(Value = @"contourcarpet")]
        ContourCarpet,

        [EnumMember(Value = @"ohlc")]
        Ohlc,

        [EnumMember(Value = @"candlestick")]
        Candlestick,

        [EnumMember(Value = @"scatterpolar")]
        ScatterPolar,

        [EnumMember(Value = @"scatterpolargl")]
        ScatterPolarGl,

        [EnumMember(Value = @"barpolar")]
        BarPolar,

        [EnumMember(Value = @"area")]
        Area
    }
}
