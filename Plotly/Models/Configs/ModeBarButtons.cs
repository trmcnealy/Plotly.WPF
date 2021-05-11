using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Plotly.Models.Configs
{
    [JsonConverter(typeof(EnumConverter))]
    public enum ModeBarButtons
    {
        [EnumMember(Value = @"toImage")]
        ToImage,

        [EnumMember(Value = @"sendDataToCloud")]
        SendDataToCloud,

        [EnumMember(Value = @"editInChartStudio")]
        EditInChartStudio,

        [EnumMember(Value = @"zoom2d")]
        Zoom2d,

        [EnumMember(Value = @"pan2d")]
        Pan2d,

        [EnumMember(Value = @"select2d")]
        Select2d,

        [EnumMember(Value = @"lasso2d")]
        Lasso2d,

        [EnumMember(Value = @"drawclosedpath")]
        Drawclosedpath,

        [EnumMember(Value = @"drawopenpath")]
        Drawopenpath,

        [EnumMember(Value = @"drawline")]
        Drawline,

        [EnumMember(Value = @"drawrect")]
        Drawrect,

        [EnumMember(Value = @"drawcircle")]
        Drawcircle,

        [EnumMember(Value = @"eraseshape")]
        Eraseshape,

        [EnumMember(Value = @"zoomIn2d")]
        ZoomIn2d,

        [EnumMember(Value = @"zoomOut2d")]
        ZoomOut2d,

        [EnumMember(Value = @"autoScale2d")]
        AutoScale2d,

        [EnumMember(Value = @"resetScale2d")]
        ResetScale2d,

        [EnumMember(Value = @"hoverClosestCartesian")]
        HoverClosestCartesian,

        [EnumMember(Value = @"hoverCompareCartesian")]
        HoverCompareCartesian,

        [EnumMember(Value = @"zoom3d")]
        Zoom3d,

        [EnumMember(Value = @"pan3d")]
        Pan3d,

        [EnumMember(Value = @"orbitRotation")]
        OrbitRotation,

        [EnumMember(Value = @"tableRotation")]
        TableRotation,

        [EnumMember(Value = @"resetCameraDefault3d")]
        ResetCameraDefault3d,

        [EnumMember(Value = @"resetCameraLastSave3d")]
        ResetCameraLastSave3d,

        [EnumMember(Value = @"hoverClosest3d")]
        HoverClosest3d,

        [EnumMember(Value = @"zoomInGeo")]
        ZoomInGeo,

        [EnumMember(Value = @"zoomOutGeo")]
        ZoomOutGeo,

        [EnumMember(Value = @"resetGeo")]
        ResetGeo,

        [EnumMember(Value = @"hoverClosrestGeo")]
        HoverClosrestGeo,

        [EnumMember(Value = @"hoverClosestGl2d")]
        HoverClosestGl2d,

        [EnumMember(Value = @"hoverClosestPie")]
        HoverClosestPie,

        [EnumMember(Value = @"resetViewSankey")]
        ResetViewSankey,

        [EnumMember(Value = @"toggleHover")]
        ToggleHover,

        [EnumMember(Value = @"resetViews")]
        ResetViews,

        [EnumMember(Value = @"toggleSpikelines")]
        ToggleSpikelines,

        [EnumMember(Value = @"resetViewMapbo")]
        ResetViewMapbo,

        [EnumMember(Value = @"zoomInMapbox")]
        ZoomInMapbox,

        [EnumMember(Value = @"zoomOutMapbox")]
        ZoomOutMapbox
    }
}
