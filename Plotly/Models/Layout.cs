using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Layouts;

namespace Plotly.Models
{
    /// <summary>
    ///     The Layout class.
    /// </summary>
    [JsonConverter(typeof(PlotlyConverter))]
    [Serializable]
    public class Layout : IEquatable<Layout>
    {
        /// <summary>
        ///     Determines how bars at the same location coordinate are displayed on the
        ///     graph. With <c>stack</c>, the bars are stacked on top of one another With
        ///     <c>relative</c>, the bars are stacked on top of one another, with negative
        ///     values below the axis, positive values above With <c>group</c>, the bars
        ///     are plotted next to one another centered around the shared location. With
        ///     <c>overlay</c>, the bars are plotted over one another, you might need to
        ///     an <c>opacity</c> to see multiple bars.
        /// </summary>
        [JsonPropertyName(@"barmode")]
        public BarModeEnum? BarMode { get; set; }

        /// <summary>
        ///     Sets the normalization for bar traces on the graph. With <c>fraction</c>,
        ///     the value of each bar is divided by the sum of all values at that location
        ///     coordinate. <c>percent</c> is the same but multiplied by 100 to show percentages.
        /// </summary>
        [JsonPropertyName(@"barnorm")]
        public BarNormEnum? BarNorm { get; set; }

        /// <summary>
        ///     Sets the gap (in plot fraction) between bars of adjacent location coordinates.
        /// </summary>
        [JsonPropertyName(@"bargap")]
        public JsNumber? BarGap { get; set; }

        /// <summary>
        ///     Sets the gap (in plot fraction) between bars of the same location coordinate.
        /// </summary>
        [JsonPropertyName(@"bargroupgap")]
        public JsNumber? BarGroupGap { get; set; }

        /// <summary>
        ///     Determines how boxes at the same location coordinate are displayed on the
        ///     graph. If <c>group</c>, the boxes are plotted next to one another centered
        ///     around the shared location. If <c>overlay</c>, the boxes are plotted over
        ///     one another, you might need to set <c>opacity</c> to see them multiple boxes.
        ///     Has no effect on traces that have <c>width</c> set.
        /// </summary>
        [JsonPropertyName(@"boxmode")]
        public BoxModeEnum? BoxMode { get; set; }

        /// <summary>
        ///     Sets the gap (in plot fraction) between boxes of adjacent location coordinates.
        ///     Has no effect on traces that have <c>width</c> set.
        /// </summary>
        [JsonPropertyName(@"boxgap")]
        public JsNumber? BoxGap { get; set; }

        /// <summary>
        ///     Sets the gap (in plot fraction) between boxes of the same location coordinate.
        ///     Has no effect on traces that have <c>width</c> set.
        /// </summary>
        [JsonPropertyName(@"boxgroupgap")]
        public JsNumber? BoxGroupGap { get; set; }

        /// <summary>
        ///     Determines how violins at the same location coordinate are displayed on
        ///     the graph. If <c>group</c>, the violins are plotted next to one another
        ///     centered around the shared location. If <c>overlay</c>, the violins are
        ///     plotted over one another, you might need to set <c>opacity</c> to see them
        ///     multiple violins. Has no effect on traces that have <c>width</c> set.
        /// </summary>
        [JsonPropertyName(@"violinmode")]
        public ViolinModeEnum? ViolinMode { get; set; }

        /// <summary>
        ///     Sets the gap (in plot fraction) between violins of adjacent location coordinates.
        ///     Has no effect on traces that have <c>width</c> set.
        /// </summary>
        [JsonPropertyName(@"violingap")]
        public JsNumber? ViolinGap { get; set; }

        /// <summary>
        ///     Sets the gap (in plot fraction) between violins of the same location coordinate.
        ///     Has no effect on traces that have <c>width</c> set.
        /// </summary>
        [JsonPropertyName(@"violingroupgap")]
        public JsNumber? ViolinGroupGap { get; set; }

        /// <summary>
        ///     Determines how bars at the same location coordinate are displayed on the
        ///     graph. With <c>stack</c>, the bars are stacked on top of one another With
        ///     <c>group</c>, the bars are plotted next to one another centered around the
        ///     shared location. With <c>overlay</c>, the bars are plotted over one another,
        ///     you might need to an <c>opacity</c> to see multiple bars.
        /// </summary>
        [JsonPropertyName(@"funnelmode")]
        public FunnelModeEnum? FunnelMode { get; set; }

        /// <summary>
        ///     Sets the gap (in plot fraction) between bars of adjacent location coordinates.
        /// </summary>
        [JsonPropertyName(@"funnelgap")]
        public JsNumber? FunnelGap { get; set; }

        /// <summary>
        ///     Sets the gap (in plot fraction) between bars of the same location coordinate.
        /// </summary>
        [JsonPropertyName(@"funnelgroupgap")]
        public JsNumber? FunnelGroupGap { get; set; }

        /// <summary>
        ///     Determines how bars at the same location coordinate are displayed on the
        ///     graph. With <c>group</c>, the bars are plotted next to one another centered
        ///     around the shared location. With <c>overlay</c>, the bars are plotted over
        ///     one another, you might need to an <c>opacity</c> to see multiple bars.
        /// </summary>
        [JsonPropertyName(@"waterfallmode")]
        public WaterfallModeEnum? WaterfallMode { get; set; }

        /// <summary>
        ///     Sets the gap (in plot fraction) between bars of adjacent location coordinates.
        /// </summary>
        [JsonPropertyName(@"waterfallgap")]
        public JsNumber? WaterfallGap { get; set; }

        /// <summary>
        ///     Sets the gap (in plot fraction) between bars of the same location coordinate.
        /// </summary>
        [JsonPropertyName(@"waterfallgroupgap")]
        public JsNumber? WaterfallGroupGap { get; set; }

        /// <summary>
        ///     hiddenlabels is the funnelarea &amp; pie chart analog of visible:<c>legendonly</c>
        ///     but it can contain many labels, and can simultaneously hide slices from
        ///     several pies/funnelarea charts
        /// </summary>
        [JsonPropertyName(@"hiddenlabels")]
        public List<object>? HiddenLabels { get; set; }

        /// <summary>
        ///     Sets the default pie slice colors. Defaults to the main <c>colorway</c>
        ///     used for trace colors. If you specify a new list here it can still be extended
        ///     with lighter and darker colors, see <c>extendpiecolors</c>.
        /// </summary>
        [JsonPropertyName(@"piecolorway")]
        public List<object>? PieColorway { get; set; }

        /// <summary>
        ///     If <c>true</c>, the pie slice colors (whether given by <c>piecolorway</c>
        ///     or inherited from <c>colorway</c>) will be extended to three times its original
        ///     length by first repeating every color 20% lighter then each color 20% darker.
        ///     This is intended to reduce the likelihood of reusing the same color when
        ///     you have many slices, but you can set <c>false</c> to disable. Colors provided
        ///     in the trace, using <c>marker.colors</c>, are never extended.
        /// </summary>
        [JsonPropertyName(@"extendpiecolors")]
        public bool? ExtendPieColors { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  hiddenlabels .
        /// </summary>
        [JsonPropertyName(@"hiddenlabelssrc")]
        public string? HiddenLabelsSrc { get; set; }

        /// <summary>
        ///     Sets the default sunburst slice colors. Defaults to the main <c>colorway</c>
        ///     used for trace colors. If you specify a new list here it can still be extended
        ///     with lighter and darker colors, see <c>extendsunburstcolors</c>.
        /// </summary>
        [JsonPropertyName(@"sunburstcolorway")]
        public List<object>? SunburstColorway { get; set; }

        /// <summary>
        ///     If <c>true</c>, the sunburst slice colors (whether given by <c>sunburstcolorway</c>
        ///     or inherited from <c>colorway</c>) will be extended to three times its original
        ///     length by first repeating every color 20% lighter then each color 20% darker.
        ///     This is intended to reduce the likelihood of reusing the same color when
        ///     you have many slices, but you can set <c>false</c> to disable. Colors provided
        ///     in the trace, using <c>marker.colors</c>, are never extended.
        /// </summary>
        [JsonPropertyName(@"extendsunburstcolors")]
        public bool? ExtendSunburstColors { get; set; }

        /// <summary>
        ///     Sets the default treemap slice colors. Defaults to the main <c>colorway</c>
        ///     used for trace colors. If you specify a new list here it can still be extended
        ///     with lighter and darker colors, see <c>extendtreemapcolors</c>.
        /// </summary>
        [JsonPropertyName(@"treemapcolorway")]
        public List<object>? TreeMapColorway { get; set; }

        /// <summary>
        ///     If <c>true</c>, the treemap slice colors (whether given by <c>treemapcolorway</c>
        ///     or inherited from <c>colorway</c>) will be extended to three times its original
        ///     length by first repeating every color 20% lighter then each color 20% darker.
        ///     This is intended to reduce the likelihood of reusing the same color when
        ///     you have many slices, but you can set <c>false</c> to disable. Colors provided
        ///     in the trace, using <c>marker.colors</c>, are never extended.
        /// </summary>
        [JsonPropertyName(@"extendtreemapcolors")]
        public bool? ExtendTreeMapColors { get; set; }

        /// <summary>
        ///     Sets the default funnelarea slice colors. Defaults to the main <c>colorway</c>
        ///     used for trace colors. If you specify a new list here it can still be extended
        ///     with lighter and darker colors, see <c>extendfunnelareacolors</c>.
        /// </summary>
        [JsonPropertyName(@"funnelareacolorway")]
        public List<object>? FunnelAreaColorway { get; set; }

        /// <summary>
        ///     If <c>true</c>, the funnelarea slice colors (whether given by <c>funnelareacolorway</c>
        ///     or inherited from <c>colorway</c>) will be extended to three times its original
        ///     length by first repeating every color 20% lighter then each color 20% darker.
        ///     This is intended to reduce the likelihood of reusing the same color when
        ///     you have many slices, but you can set <c>false</c> to disable. Colors provided
        ///     in the trace, using <c>marker.colors</c>, are never extended.
        /// </summary>
        [JsonPropertyName(@"extendfunnelareacolors")]
        public bool? ExtendFunnelAreaColors { get; set; }

        /// <summary>
        ///     Sets the global font. Note that fonts used in traces and other layout components
        ///     inherit from the global font.
        /// </summary>
        [JsonPropertyName(@"font")]
        public Font? Font { get; set; }

        /// <summary>
        ///     Gets or sets the Title.
        /// </summary>
        [JsonPropertyName(@"title")]
        public Title? Title { get; set; }

        /// <summary>
        ///     Gets or sets the UniformText.
        /// </summary>
        [JsonPropertyName(@"uniformtext")]
        public UniformText? UniformText { get; set; }

        /// <summary>
        ///     Determines whether or not a layout width or height that has been left undefined
        ///     by the user is initialized on each relayout. Note that, regardless of this
        ///     attribute, an undefined layout width or height is always initialized on
        ///     the first call to plot.
        /// </summary>
        [JsonPropertyName(@"autosize")]
        public bool? AutoSize { get; set; }

        /// <summary>
        ///     Sets the plot&#39;s width (in px).
        /// </summary>
        [JsonPropertyName(@"width")]
        public JsNumber? Width { get; set; }

        /// <summary>
        ///     Sets the plot&#39;s height (in px).
        /// </summary>
        [JsonPropertyName(@"height")]
        public JsNumber? Height { get; set; }

        /// <summary>
        ///     Gets or sets the Margin.
        /// </summary>
        [JsonPropertyName(@"margin")]
        public Margin? Margin { get; set; }

        /// <summary>
        ///     Sets the background color of the paper where the graph is drawn.
        /// </summary>
        [JsonPropertyName(@"paper_bgcolor")]
        public object? PaperBgColor { get; set; }

        /// <summary>
        ///     Sets the background color of the plotting area in-between x and y axes.
        /// </summary>
        [JsonPropertyName(@"plot_bgcolor")]
        public object? PlotBgColor { get; set; }

        /// <summary>
        ///     Sets the JsNumber and thousand separators. For example, &#39;. &#39; puts
        ///     a <c>.</c> before decimals and a space between thousands. In English locales,
        ///     dflt is <c>.,</c> but other locales may alter this default.
        /// </summary>
        [JsonPropertyName(@"separators")]
        public string? Separators { get; set; }

        /// <summary>
        ///     Determines whether or not a text link citing the data source is placed at
        ///     the bottom-right cored of the figure. Has only an effect only on graphs
        ///     that have been generated via forked graphs from the Chart Studio Cloud (at
        ///     https://chart-studio.plotly.com or on-premise).
        /// </summary>
        [JsonPropertyName(@"hidesources")]
        public bool? HideSources { get; set; }

        /// <summary>
        ///     Determines whether or not a legend is drawn. Default is <c>true</c> if there
        ///     is a trace to show and any of these: a) Two or more traces would by default
        ///     be shown in the legend. b) One pie trace is shown in the legend. c) One
        ///     trace is explicitly given with &#39;showlegend: true&#39;.
        /// </summary>
        [JsonPropertyName(@"showlegend")]
        public bool? ShowLegend { get; set; }

        /// <summary>
        ///     Sets the default trace colors.
        /// </summary>
        [JsonPropertyName(@"colorway")]
        public List<object>? Colorway { get; set; }

        /// <summary>
        ///     If provided, a changed value tells <c>Plotly.react</c> that one or more
        ///     data arrays has changed. This way you can modify arrays in-place rather
        ///     than making a complete new copy for an incremental change. If NOT provided,
        ///     <c>Plotly.react</c> assumes that data arrays are being treated as immutable,
        ///     thus any data array with a different identity from its predecessor contains
        ///     new data.
        /// </summary>
        [JsonPropertyName(@"datarevision")]
        public object? DataRevision { get; set; }

        /// <summary>
        ///     Used to allow user interactions with the plot to persist after <c>Plotly.react</c>
        ///     calls that are unaware of these interactions. If <c>uirevision</c> is omitted,
        ///     or if it is given and it changed from the previous <c>Plotly.react</c> call,
        ///     the exact new figure is used. If <c>uirevision</c> is truthy and did NOT
        ///     change, any attribute that has been affected by user interactions and did
        ///     not receive a different value in the new figure will keep the interaction
        ///     value. <c>layout.uirevision</c> attribute serves as the default for <c>uirevision</c>
        ///     attributes in various sub-containers. For finer control you can set these
        ///     sub-attributes directly. For example, if your app separately controls the
        ///     data on the x and y axes you might set <c>xaxis.uirevision=<c>time</c></c>
        ///     and <c>yaxis.uirevision=<c>cost</c></c>. Then if only the y data is changed,
        ///     you can update <c>yaxis.uirevision=<c>quantity</c></c> and the y axis range
        ///     will reset but the x axis range will retain any user-driven zoom.
        /// </summary>
        [JsonPropertyName(@"uirevision")]
        public object? UiRevision { get; set; }

        /// <summary>
        ///     Controls persistence of user-driven changes in &#39;editable: true&#39;
        ///     configuration, other than trace names and axis titles. Defaults to <c>layout.uirevision</c>.
        /// </summary>
        [JsonPropertyName(@"editrevision")]
        public object? EditRevision { get; set; }

        /// <summary>
        ///     Controls persistence of user-driven changes in selected points from all
        ///     traces.
        /// </summary>
        [JsonPropertyName(@"selectionrevision")]
        public object? SelectionRevision { get; set; }

        /// <summary>
        ///     Default attributes to be applied to the plot. Templates can be created from
        ///     existing plots using <c>Plotly.makeTemplate</c>, or created manually. They
        ///     should be objects with format: &#39;{layout: layoutTemplate, data: {[type]:
        ///     [traceTemplate, ...]}, ...}&#39; <c>layoutTemplate</c> and <c>traceTemplate</c>
        ///     are objects matching the attribute structure of <c>layout</c> and a data
        ///     trace.  Trace templates are applied cyclically to traces of each type. Container
        ///     arrays (eg <c>annotations</c>) have special handling: An object ending in
        ///     <c>defaults</c> (eg <c>annotationdefaults</c>) is applied to each array
        ///     item. But if an item has a <c>templateitemname</c> key we look in the template
        ///     array for an item with matching <c>name</c> and apply that instead. If no
        ///     matching <c>name</c> is found we mark the item invisible. Any named template
        ///     item not referenced is appended to the end of the array, so you can use
        ///     this for a watermark annotation or a logo image, for example. To omit one
        ///     of these items on the plot, make an item with matching <c>templateitemname</c>
        ///     and &#39;visible: false&#39;.
        /// </summary>
        [JsonPropertyName(@"template")]
        public object? Template { get; set; }

        /// <summary>
        ///     Gets or sets the ModeBar.
        /// </summary>
        [JsonPropertyName(@"modebar")]
        public ModeBar? ModeBar { get; set; }

        /// <summary>
        ///     Gets or sets the NewShape.
        /// </summary>
        [JsonPropertyName(@"newshape")]
        public NewShape? NewShape { get; set; }

        /// <summary>
        ///     Gets or sets the ActiveShape.
        /// </summary>
        [JsonPropertyName(@"activeshape")]
        public ActiveShape? ActiveShape { get; set; }

        /// <summary>
        ///     Assigns extra meta information that can be used in various <c>text</c> attributes.
        ///     Attributes such as the graph, axis and colorbar <c>title.text</c>, annotation
        ///     <c>text</c> <c>trace.name</c> in legend items, <c>rangeselector</c>, <c>updatemenus</c>
        ///     and <c>sliders</c> <c>label</c> text all support <c>meta</c>. One can access
        ///     <c>meta</c> fields using template strings: <c>%{meta[i]}</c> where <c>i</c>
        ///     is the index of the <c>meta</c> item in question. <c>meta</c> can also be
        ///     an object for example &#39;{key: value}&#39; which can be accessed %{meta[key]}.
        /// </summary>
        [JsonPropertyName(@"meta")]
        public object? Meta { get; set; }

        /// <summary>
        ///     Assigns extra meta information that can be used in various <c>text</c> attributes.
        ///     Attributes such as the graph, axis and colorbar <c>title.text</c>, annotation
        ///     <c>text</c> <c>trace.name</c> in legend items, <c>rangeselector</c>, <c>updatemenus</c>
        ///     and <c>sliders</c> <c>label</c> text all support <c>meta</c>. One can access
        ///     <c>meta</c> fields using template strings: <c>%{meta[i]}</c> where <c>i</c>
        ///     is the index of the <c>meta</c> item in question. <c>meta</c> can also be
        ///     an object for example &#39;{key: value}&#39; which can be accessed %{meta[key]}.
        /// </summary>
        [JsonPropertyName(@"meta")]
        [Array]
        public List<object>? MetaArray { get; set; }

        /// <summary>
        ///     Sets transition options used during Plotly.react updates.
        /// </summary>
        [JsonPropertyName(@"transition")]
        public Transition? Transition { get; set; }

        /// <summary>
        ///     Determines the mode of single click interactions. <c>event</c> is the default
        ///     value and emits the <c>plotly_click</c> event. In addition this mode emits
        ///     the <c>plotly_selected</c> event in drag modes <c>lasso</c> and <c>select</c>,
        ///     but with no event data attached (kept for compatibility reasons). The <c>select</c>
        ///     flag enables selecting single data points via click. This mode also supports
        ///     persistent selections, meaning that pressing Shift while clicking, adds
        ///     to / subtracts from an existing selection. <c>select</c> with <c>hovermode</c>:
        ///     <c>x</c> can be confusing, consider explicitly setting <c>hovermode</c>:
        ///     <c>closest</c> when using this feature. Selection events are sent accordingly
        ///     as long as <c>event</c> flag is set as well. When the <c>event</c> flag
        ///     is missing, <c>plotly_click</c> and <c>plotly_selected</c> events are not
        ///     fired.
        /// </summary>
        [JsonPropertyName(@"clickmode")]
        public ClickModeFlag? ClickMode { get; set; }

        /// <summary>
        ///     Determines the mode of drag interactions. <c>select</c> and <c>lasso</c>
        ///     apply only to scatter traces with markers or text. <c>orbit</c> and <c>turntable</c>
        ///     apply only to 3D scenes.
        /// </summary>
        [JsonPropertyName(@"dragmode")]
        public DragModeEnum? DragMode { get; set; }

        /// <summary>
        ///     Determines the mode of hover interactions. If <c>closest</c>, a single hoverlabel
        ///     will appear for the <c>closest</c> point within the <c>hoverdistance</c>.
        ///     If <c>x</c> (or <c>y</c>), multiple hoverlabels will appear for multiple
        ///     points at the <c>closest</c> x- (or y-) coordinate within the <c>hoverdistance</c>,
        ///     with the caveat that no more than one hoverlabel will appear per trace.
        ///     If &#39;x unified&#39; (or &#39;y unified&#39;), a single hoverlabel will
        ///     appear multiple points at the closest x- (or y-) coordinate within the <c>hoverdistance</c>
        ///     with the caveat that no more than one hoverlabel will appear per trace.
        ///     In this mode, spikelines are enabled by default perpendicular to the specified
        ///     axis. If false, hover interactions are disabled. If <c>clickmode</c> includes
        ///     the <c>select</c> flag, <c>hovermode</c> defaults to <c>closest</c>. If
        ///     <c>clickmode</c> lacks the <c>select</c> flag, it defaults to <c>x</c> or
        ///     <c>y</c> (depending on the trace&#39;s <c>orientation</c> value) for plots
        ///     based on cartesian coordinates. For anything else the default value is <c>closest</c>.
        /// </summary>
        [JsonPropertyName(@"hovermode")]
        public HoverModeEnum? HoverMode { get; set; }

        /// <summary>
        ///     Sets the default distance (in pixels) to look for data to add hover labels
        ///     (-1 means no cutoff, 0 means no looking for data). This is only a real distance
        ///     for hovering on point-like objects, like scatter points. For area-like objects
        ///     (bars, scatter fills, etc) hovering is on inside the area and off outside,
        ///     but these objects will not supersede hover on point-like objects in case
        ///     of conflict.
        /// </summary>
        [JsonPropertyName(@"hoverdistance")]
        public int? HoverDistance { get; set; }

        /// <summary>
        ///     Sets the default distance (in pixels) to look for data to draw spikelines
        ///     to (-1 means no cutoff, 0 means no looking for data). As with hoverdistance,
        ///     distance does not apply to area-like objects. In addition, some objects
        ///     can be hovered on but will not generate spikelines, such as scatter fills.
        /// </summary>
        [JsonPropertyName(@"spikedistance")]
        public int? SpikeDistance { get; set; }

        /// <summary>
        ///     Gets or sets the HoverLabel.
        /// </summary>
        [JsonPropertyName(@"hoverlabel")]
        public HoverLabel? HoverLabel { get; set; }

        /// <summary>
        ///     When <c>dragmode</c> is set to <c>select</c>, this limits the selection
        ///     of the drag to horizontal, vertical or diagonal. <c>h</c> only allows horizontal
        ///     selection, <c>v</c> only vertical, <c>d</c> only diagonal and <c>any</c>
        ///     sets no limit.
        /// </summary>
        [JsonPropertyName(@"selectdirection")]
        public SelectDirectionEnum? SelectDirection { get; set; }

        /// <summary>
        ///     Gets or sets the Grid.
        /// </summary>
        [JsonPropertyName(@"grid")]
        public Grid? Grid { get; set; }

        /// <summary>
        ///     Sets the default calendar system to use for interpreting and displaying
        ///     dates throughout the plot.
        /// </summary>
        [JsonPropertyName(@"calendar")]
        public CalendarEnum? Calendar { get; set; }

        /// <summary>
        ///     Gets or sets the XAxis.
        /// </summary>
        [JsonPropertyName(@"xaxis")]
        [Subplot]
        public List<XAxis>? XAxis { get; set; }

        /// <summary>
        ///     Gets or sets the YAxis.
        /// </summary>
        [JsonPropertyName(@"yaxis")]
        [Subplot]
        public List<YAxis>? YAxis { get; set; }

        /// <summary>
        ///     Gets or sets the Ternary.
        /// </summary>
        [JsonPropertyName(@"ternary")]
        [Subplot]
        public List<Ternary>? Ternary { get; set; }

        /// <summary>
        ///     Gets or sets the Scene.
        /// </summary>
        [JsonPropertyName(@"scene")]
        [Subplot]
        public List<Scene>? Scene { get; set; }

        /// <summary>
        ///     Gets or sets the Geo.
        /// </summary>
        [JsonPropertyName(@"geo")]
        [Subplot]
        public List<Geo>? Geo { get; set; }

        /// <summary>
        ///     Gets or sets the MapBox.
        /// </summary>
        [JsonPropertyName(@"mapbox")]
        [Subplot]
        public List<MapBox>? MapBox { get; set; }

        /// <summary>
        ///     Gets or sets the Polar.
        /// </summary>
        [JsonPropertyName(@"polar")]
        [Subplot]
        public List<Polar>? Polar { get; set; }

        /// <summary>
        ///     Gets or sets the RadialAxis.
        /// </summary>
        [JsonPropertyName(@"radialaxis")]
        public RadialAxis? RadialAxis { get; set; }

        /// <summary>
        ///     Gets or sets the AngularAxis.
        /// </summary>
        [JsonPropertyName(@"angularaxis")]
        public AngularAxis? AngularAxis { get; set; }

        /// <summary>
        ///     Legacy polar charts are deprecated! Please switch to <c>polar</c> subplots.
        ///     Sets the direction corresponding to positive angles in legacy polar charts.
        /// </summary>
        [JsonPropertyName(@"direction")]
        public DirectionEnum? Direction { get; set; }

        /// <summary>
        ///     Legacy polar charts are deprecated! Please switch to <c>polar</c> subplots.
        ///     Rotates the entire polar by the given angle in legacy polar charts.
        /// </summary>
        [JsonPropertyName(@"orientation")]
        public JsNumber? Orientation { get; set; }

        /// <summary>
        ///     Gets or sets the Legend.
        /// </summary>
        [JsonPropertyName(@"legend")]
        public Legend? Legend { get; set; }

        /// <summary>
        ///     Gets or sets the Annotations.
        /// </summary>
        [JsonPropertyName(@"annotations")]
        public List<Annotation>? Annotations { get; set; }

        /// <summary>
        ///     Gets or sets the Shapes.
        /// </summary>
        [JsonPropertyName(@"shapes")]
        public List<Shape>? Shapes { get; set; }

        /// <summary>
        ///     Gets or sets the Images.
        /// </summary>
        [JsonPropertyName(@"images")]
        public List<Image>? Images { get; set; }

        /// <summary>
        ///     Gets or sets the UpdateMenus.
        /// </summary>
        [JsonPropertyName(@"updatemenus")]
        public List<UpdateMenu>? UpdateMenus { get; set; }

        /// <summary>
        ///     Gets or sets the Sliders.
        /// </summary>
        [JsonPropertyName(@"sliders")]
        public List<Slider>? Sliders { get; set; }

        /// <summary>
        ///     Gets or sets the ColorScale.
        /// </summary>
        [JsonPropertyName(@"colorscale")]
        public ColorScale? ColorScale { get; set; }

        /// <summary>
        ///     Gets or sets the ColorAxis.
        /// </summary>
        [JsonPropertyName(@"coloraxis")]
        [Subplot]
        public List<ColorAxis>? ColorAxis { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  meta .
        /// </summary>
        [JsonPropertyName(@"metasrc")]
        public string? MetaSrc { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is Layout other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] Layout other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (BarMode           == other.BarMode           && BarMode           != null && other.BarMode           != null && BarMode.Equals(other.BarMode))                            &&
                   (BarNorm           == other.BarNorm           && BarNorm           != null && other.BarNorm           != null && BarNorm.Equals(other.BarNorm))                            &&
                   (BarGap            == other.BarGap            && BarGap            != null && other.BarGap            != null && BarGap.Equals(other.BarGap))                              &&
                   (BarGroupGap       == other.BarGroupGap       && BarGroupGap       != null && other.BarGroupGap       != null && BarGroupGap.Equals(other.BarGroupGap))                    &&
                   (BoxMode           == other.BoxMode           && BoxMode           != null && other.BoxMode           != null && BoxMode.Equals(other.BoxMode))                            &&
                   (BoxGap            == other.BoxGap            && BoxGap            != null && other.BoxGap            != null && BoxGap.Equals(other.BoxGap))                              &&
                   (BoxGroupGap       == other.BoxGroupGap       && BoxGroupGap       != null && other.BoxGroupGap       != null && BoxGroupGap.Equals(other.BoxGroupGap))                    &&
                   (ViolinMode        == other.ViolinMode        && ViolinMode        != null && other.ViolinMode        != null && ViolinMode.Equals(other.ViolinMode))                      &&
                   (ViolinGap         == other.ViolinGap         && ViolinGap         != null && other.ViolinGap         != null && ViolinGap.Equals(other.ViolinGap))                        &&
                   (ViolinGroupGap    == other.ViolinGroupGap    && ViolinGroupGap    != null && other.ViolinGroupGap    != null && ViolinGroupGap.Equals(other.ViolinGroupGap))              &&
                   (FunnelMode        == other.FunnelMode        && FunnelMode        != null && other.FunnelMode        != null && FunnelMode.Equals(other.FunnelMode))                      &&
                   (FunnelGap         == other.FunnelGap         && FunnelGap         != null && other.FunnelGap         != null && FunnelGap.Equals(other.FunnelGap))                        &&
                   (FunnelGroupGap    == other.FunnelGroupGap    && FunnelGroupGap    != null && other.FunnelGroupGap    != null && FunnelGroupGap.Equals(other.FunnelGroupGap))              &&
                   (WaterfallMode     == other.WaterfallMode     && WaterfallMode     != null && other.WaterfallMode     != null && WaterfallMode.Equals(other.WaterfallMode))                &&
                   (WaterfallGap      == other.WaterfallGap      && WaterfallGap      != null && other.WaterfallGap      != null && WaterfallGap.Equals(other.WaterfallGap))                  &&
                   (WaterfallGroupGap == other.WaterfallGroupGap && WaterfallGroupGap != null && other.WaterfallGroupGap != null && WaterfallGroupGap.Equals(other.WaterfallGroupGap))        &&
                   (Equals(HiddenLabels, other.HiddenLabels) || HiddenLabels != null && other.HiddenLabels != null && HiddenLabels.SequenceEqual(other.HiddenLabels))                         &&
                   (Equals(PieColorway,  other.PieColorway)  || PieColorway  != null && other.PieColorway  != null && PieColorway.SequenceEqual(other.PieColorway))                           &&
                   (ExtendPieColors == other.ExtendPieColors && ExtendPieColors != null && other.ExtendPieColors != null && ExtendPieColors.Equals(other.ExtendPieColors))                    &&
                   (HiddenLabelsSrc == other.HiddenLabelsSrc && HiddenLabelsSrc != null && other.HiddenLabelsSrc != null && HiddenLabelsSrc.Equals(other.HiddenLabelsSrc))                    &&
                   (Equals(SunburstColorway, other.SunburstColorway) || SunburstColorway != null && other.SunburstColorway != null && SunburstColorway.SequenceEqual(other.SunburstColorway)) &&
                   (ExtendSunburstColors       == other.ExtendSunburstColors &&
                    ExtendSunburstColors       != null                       &&
                    other.ExtendSunburstColors != null                       &&
                    ExtendSunburstColors.Equals(other.ExtendSunburstColors))                                                                                                                       &&
                   (Equals(TreeMapColorway, other.TreeMapColorway) || TreeMapColorway != null && other.TreeMapColorway != null && TreeMapColorway.SequenceEqual(other.TreeMapColorway))            &&
                   (ExtendTreeMapColors == other.ExtendTreeMapColors && ExtendTreeMapColors != null && other.ExtendTreeMapColors != null && ExtendTreeMapColors.Equals(other.ExtendTreeMapColors)) &&
                   (Equals(FunnelAreaColorway, other.FunnelAreaColorway) ||
                    FunnelAreaColorway != null && other.FunnelAreaColorway != null && FunnelAreaColorway.SequenceEqual(other.FunnelAreaColorway)) &&
                   (ExtendFunnelAreaColors       == other.ExtendFunnelAreaColors &&
                    ExtendFunnelAreaColors       != null                         &&
                    other.ExtendFunnelAreaColors != null                         &&
                    ExtendFunnelAreaColors.Equals(other.ExtendFunnelAreaColors))                                                                                                       &&
                   (Font         == other.Font         && Font         != null && other.Font         != null && Font.Equals(other.Font))                                               &&
                   (Title        == other.Title        && Title        != null && other.Title        != null && Title.Equals(other.Title))                                             &&
                   (UniformText  == other.UniformText  && UniformText  != null && other.UniformText  != null && UniformText.Equals(other.UniformText))                                 &&
                   (AutoSize     == other.AutoSize     && AutoSize     != null && other.AutoSize     != null && AutoSize.Equals(other.AutoSize))                                       &&
                   (Width        == other.Width        && Width        != null && other.Width        != null && Width.Equals(other.Width))                                             &&
                   (Height       == other.Height       && Height       != null && other.Height       != null && Height.Equals(other.Height))                                           &&
                   (Margin       == other.Margin       && Margin       != null && other.Margin       != null && Margin.Equals(other.Margin))                                           &&
                   (PaperBgColor == other.PaperBgColor && PaperBgColor != null && other.PaperBgColor != null && PaperBgColor.Equals(other.PaperBgColor))                               &&
                   (PlotBgColor  == other.PlotBgColor  && PlotBgColor  != null && other.PlotBgColor  != null && PlotBgColor.Equals(other.PlotBgColor))                                 &&
                   (Separators   == other.Separators   && Separators   != null && other.Separators   != null && Separators.Equals(other.Separators))                                   &&
                   (HideSources  == other.HideSources  && HideSources  != null && other.HideSources  != null && HideSources.Equals(other.HideSources))                                 &&
                   (ShowLegend   == other.ShowLegend   && ShowLegend   != null && other.ShowLegend   != null && ShowLegend.Equals(other.ShowLegend))                                   &&
                   (Equals(Colorway, other.Colorway) || Colorway != null && other.Colorway != null && Colorway.SequenceEqual(other.Colorway))                                          &&
                   (DataRevision      == other.DataRevision      && DataRevision      != null && other.DataRevision      != null && DataRevision.Equals(other.DataRevision))           &&
                   (UiRevision        == other.UiRevision        && UiRevision        != null && other.UiRevision        != null && UiRevision.Equals(other.UiRevision))               &&
                   (EditRevision      == other.EditRevision      && EditRevision      != null && other.EditRevision      != null && EditRevision.Equals(other.EditRevision))           &&
                   (SelectionRevision == other.SelectionRevision && SelectionRevision != null && other.SelectionRevision != null && SelectionRevision.Equals(other.SelectionRevision)) &&
                   (Template          == other.Template          && Template          != null && other.Template          != null && Template.Equals(other.Template))                   &&
                   (ModeBar           == other.ModeBar           && ModeBar           != null && other.ModeBar           != null && ModeBar.Equals(other.ModeBar))                     &&
                   (NewShape          == other.NewShape          && NewShape          != null && other.NewShape          != null && NewShape.Equals(other.NewShape))                   &&
                   (ActiveShape       == other.ActiveShape       && ActiveShape       != null && other.ActiveShape       != null && ActiveShape.Equals(other.ActiveShape))             &&
                   (Meta              == other.Meta              && Meta              != null && other.Meta              != null && Meta.Equals(other.Meta))                           &&
                   (Equals(MetaArray, other.MetaArray) || MetaArray != null && other.MetaArray != null && MetaArray.SequenceEqual(other.MetaArray))                                    &&
                   (Transition      == other.Transition      && Transition      != null && other.Transition      != null && Transition.Equals(other.Transition))                       &&
                   (ClickMode       == other.ClickMode       && ClickMode       != null && other.ClickMode       != null && ClickMode.Equals(other.ClickMode))                         &&
                   (DragMode        == other.DragMode        && DragMode        != null && other.DragMode        != null && DragMode.Equals(other.DragMode))                           &&
                   (HoverMode       == other.HoverMode       && HoverMode       != null && other.HoverMode       != null && HoverMode.Equals(other.HoverMode))                         &&
                   (HoverDistance   == other.HoverDistance   && HoverDistance   != null && other.HoverDistance   != null && HoverDistance.Equals(other.HoverDistance))                 &&
                   (SpikeDistance   == other.SpikeDistance   && SpikeDistance   != null && other.SpikeDistance   != null && SpikeDistance.Equals(other.SpikeDistance))                 &&
                   (HoverLabel      == other.HoverLabel      && HoverLabel      != null && other.HoverLabel      != null && HoverLabel.Equals(other.HoverLabel))                       &&
                   (SelectDirection == other.SelectDirection && SelectDirection != null && other.SelectDirection != null && SelectDirection.Equals(other.SelectDirection))             &&
                   (Grid            == other.Grid            && Grid            != null && other.Grid            != null && Grid.Equals(other.Grid))                                   &&
                   (Calendar        == other.Calendar        && Calendar        != null && other.Calendar        != null && Calendar.Equals(other.Calendar))                           &&
                   (Equals(XAxis,   other.XAxis)   || XAxis   != null && other.XAxis   != null && XAxis.SequenceEqual(other.XAxis))                                                    &&
                   (Equals(YAxis,   other.YAxis)   || YAxis   != null && other.YAxis   != null && YAxis.SequenceEqual(other.YAxis))                                                    &&
                   (Equals(Ternary, other.Ternary) || Ternary != null && other.Ternary != null && Ternary.SequenceEqual(other.Ternary))                                                &&
                   (Equals(Scene,   other.Scene)   || Scene   != null && other.Scene   != null && Scene.SequenceEqual(other.Scene))                                                    &&
                   (Equals(Geo,     other.Geo)     || Geo     != null && other.Geo     != null && Geo.SequenceEqual(other.Geo))                                                        &&
                   (Equals(MapBox,  other.MapBox)  || MapBox  != null && other.MapBox  != null && MapBox.SequenceEqual(other.MapBox))                                                  &&
                   (Equals(Polar,   other.Polar)   || Polar   != null && other.Polar   != null && Polar.SequenceEqual(other.Polar))                                                    &&
                   (RadialAxis  == other.RadialAxis  && RadialAxis  != null && other.RadialAxis  != null && RadialAxis.Equals(other.RadialAxis))                                       &&
                   (AngularAxis == other.AngularAxis && AngularAxis != null && other.AngularAxis != null && AngularAxis.Equals(other.AngularAxis))                                     &&
                   (Direction   == other.Direction   && Direction   != null && other.Direction   != null && Direction.Equals(other.Direction))                                         &&
                   (Orientation == other.Orientation && Orientation != null && other.Orientation != null && Orientation.Equals(other.Orientation))                                     &&
                   (Legend      == other.Legend      && Legend      != null && other.Legend      != null && Legend.Equals(other.Legend))                                               &&
                   (Equals(Annotations, other.Annotations) || Annotations != null && other.Annotations != null && Annotations.SequenceEqual(other.Annotations))                        &&
                   (Equals(Shapes,      other.Shapes)      || Shapes      != null && other.Shapes      != null && Shapes.SequenceEqual(other.Shapes))                                  &&
                   (Equals(Images,      other.Images)      || Images      != null && other.Images      != null && Images.SequenceEqual(other.Images))                                  &&
                   (Equals(UpdateMenus, other.UpdateMenus) || UpdateMenus != null && other.UpdateMenus != null && UpdateMenus.SequenceEqual(other.UpdateMenus))                        &&
                   (Equals(Sliders,     other.Sliders)     || Sliders     != null && other.Sliders     != null && Sliders.SequenceEqual(other.Sliders))                                &&
                   (ColorScale == other.ColorScale && ColorScale != null && other.ColorScale != null && ColorScale.Equals(other.ColorScale))                                           &&
                   (Equals(ColorAxis, other.ColorAxis) || ColorAxis != null && other.ColorAxis != null && ColorAxis.SequenceEqual(other.ColorAxis))                                    &&
                   (MetaSrc == other.MetaSrc && MetaSrc != null && other.MetaSrc != null && MetaSrc.Equals(other.MetaSrc));
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;

                if(BarMode != null)
                    hashCode = hashCode * 59 + BarMode.GetHashCode();

                if(BarNorm != null)
                    hashCode = hashCode * 59 + BarNorm.GetHashCode();

                if(BarGap != null)
                    hashCode = hashCode * 59 + BarGap.GetHashCode();

                if(BarGroupGap != null)
                    hashCode = hashCode * 59 + BarGroupGap.GetHashCode();

                if(BoxMode != null)
                    hashCode = hashCode * 59 + BoxMode.GetHashCode();

                if(BoxGap != null)
                    hashCode = hashCode * 59 + BoxGap.GetHashCode();

                if(BoxGroupGap != null)
                    hashCode = hashCode * 59 + BoxGroupGap.GetHashCode();

                if(ViolinMode != null)
                    hashCode = hashCode * 59 + ViolinMode.GetHashCode();

                if(ViolinGap != null)
                    hashCode = hashCode * 59 + ViolinGap.GetHashCode();

                if(ViolinGroupGap != null)
                    hashCode = hashCode * 59 + ViolinGroupGap.GetHashCode();

                if(FunnelMode != null)
                    hashCode = hashCode * 59 + FunnelMode.GetHashCode();

                if(FunnelGap != null)
                    hashCode = hashCode * 59 + FunnelGap.GetHashCode();

                if(FunnelGroupGap != null)
                    hashCode = hashCode * 59 + FunnelGroupGap.GetHashCode();

                if(WaterfallMode != null)
                    hashCode = hashCode * 59 + WaterfallMode.GetHashCode();

                if(WaterfallGap != null)
                    hashCode = hashCode * 59 + WaterfallGap.GetHashCode();

                if(WaterfallGroupGap != null)
                    hashCode = hashCode * 59 + WaterfallGroupGap.GetHashCode();

                if(HiddenLabels != null)
                    hashCode = hashCode * 59 + HiddenLabels.GetHashCode();

                if(PieColorway != null)
                    hashCode = hashCode * 59 + PieColorway.GetHashCode();

                if(ExtendPieColors != null)
                    hashCode = hashCode * 59 + ExtendPieColors.GetHashCode();

                if(HiddenLabelsSrc != null)
                    hashCode = hashCode * 59 + HiddenLabelsSrc.GetHashCode();

                if(SunburstColorway != null)
                    hashCode = hashCode * 59 + SunburstColorway.GetHashCode();

                if(ExtendSunburstColors != null)
                    hashCode = hashCode * 59 + ExtendSunburstColors.GetHashCode();

                if(TreeMapColorway != null)
                    hashCode = hashCode * 59 + TreeMapColorway.GetHashCode();

                if(ExtendTreeMapColors != null)
                    hashCode = hashCode * 59 + ExtendTreeMapColors.GetHashCode();

                if(FunnelAreaColorway != null)
                    hashCode = hashCode * 59 + FunnelAreaColorway.GetHashCode();

                if(ExtendFunnelAreaColors != null)
                    hashCode = hashCode * 59 + ExtendFunnelAreaColors.GetHashCode();

                if(Font != null)
                    hashCode = hashCode * 59 + Font.GetHashCode();

                if(Title != null)
                    hashCode = hashCode * 59 + Title.GetHashCode();

                if(UniformText != null)
                    hashCode = hashCode * 59 + UniformText.GetHashCode();

                if(AutoSize != null)
                    hashCode = hashCode * 59 + AutoSize.GetHashCode();

                if(Width != null)
                    hashCode = hashCode * 59 + Width.GetHashCode();

                if(Height != null)
                    hashCode = hashCode * 59 + Height.GetHashCode();

                if(Margin != null)
                    hashCode = hashCode * 59 + Margin.GetHashCode();

                if(PaperBgColor != null)
                    hashCode = hashCode * 59 + PaperBgColor.GetHashCode();

                if(PlotBgColor != null)
                    hashCode = hashCode * 59 + PlotBgColor.GetHashCode();

                if(Separators != null)
                    hashCode = hashCode * 59 + Separators.GetHashCode();

                if(HideSources != null)
                    hashCode = hashCode * 59 + HideSources.GetHashCode();

                if(ShowLegend != null)
                    hashCode = hashCode * 59 + ShowLegend.GetHashCode();

                if(Colorway != null)
                    hashCode = hashCode * 59 + Colorway.GetHashCode();

                if(DataRevision != null)
                    hashCode = hashCode * 59 + DataRevision.GetHashCode();

                if(UiRevision != null)
                    hashCode = hashCode * 59 + UiRevision.GetHashCode();

                if(EditRevision != null)
                    hashCode = hashCode * 59 + EditRevision.GetHashCode();

                if(SelectionRevision != null)
                    hashCode = hashCode * 59 + SelectionRevision.GetHashCode();

                if(Template != null)
                    hashCode = hashCode * 59 + Template.GetHashCode();

                if(ModeBar != null)
                    hashCode = hashCode * 59 + ModeBar.GetHashCode();

                if(NewShape != null)
                    hashCode = hashCode * 59 + NewShape.GetHashCode();

                if(ActiveShape != null)
                    hashCode = hashCode * 59 + ActiveShape.GetHashCode();

                if(Meta != null)
                    hashCode = hashCode * 59 + Meta.GetHashCode();

                if(MetaArray != null)
                    hashCode = hashCode * 59 + MetaArray.GetHashCode();

                if(Transition != null)
                    hashCode = hashCode * 59 + Transition.GetHashCode();

                if(ClickMode != null)
                    hashCode = hashCode * 59 + ClickMode.GetHashCode();

                if(DragMode != null)
                    hashCode = hashCode * 59 + DragMode.GetHashCode();

                if(HoverMode != null)
                    hashCode = hashCode * 59 + HoverMode.GetHashCode();

                if(HoverDistance != null)
                    hashCode = hashCode * 59 + HoverDistance.GetHashCode();

                if(SpikeDistance != null)
                    hashCode = hashCode * 59 + SpikeDistance.GetHashCode();

                if(HoverLabel != null)
                    hashCode = hashCode * 59 + HoverLabel.GetHashCode();

                if(SelectDirection != null)
                    hashCode = hashCode * 59 + SelectDirection.GetHashCode();

                if(Grid != null)
                    hashCode = hashCode * 59 + Grid.GetHashCode();

                if(Calendar != null)
                    hashCode = hashCode * 59 + Calendar.GetHashCode();

                if(XAxis != null)
                    hashCode = hashCode * 59 + XAxis.GetHashCode();

                if(YAxis != null)
                    hashCode = hashCode * 59 + YAxis.GetHashCode();

                if(Ternary != null)
                    hashCode = hashCode * 59 + Ternary.GetHashCode();

                if(Scene != null)
                    hashCode = hashCode * 59 + Scene.GetHashCode();

                if(Geo != null)
                    hashCode = hashCode * 59 + Geo.GetHashCode();

                if(MapBox != null)
                    hashCode = hashCode * 59 + MapBox.GetHashCode();

                if(Polar != null)
                    hashCode = hashCode * 59 + Polar.GetHashCode();

                if(RadialAxis != null)
                    hashCode = hashCode * 59 + RadialAxis.GetHashCode();

                if(AngularAxis != null)
                    hashCode = hashCode * 59 + AngularAxis.GetHashCode();

                if(Direction != null)
                    hashCode = hashCode * 59 + Direction.GetHashCode();

                if(Orientation != null)
                    hashCode = hashCode * 59 + Orientation.GetHashCode();

                if(Legend != null)
                    hashCode = hashCode * 59 + Legend.GetHashCode();

                if(Annotations != null)
                    hashCode = hashCode * 59 + Annotations.GetHashCode();

                if(Shapes != null)
                    hashCode = hashCode * 59 + Shapes.GetHashCode();

                if(Images != null)
                    hashCode = hashCode * 59 + Images.GetHashCode();

                if(UpdateMenus != null)
                    hashCode = hashCode * 59 + UpdateMenus.GetHashCode();

                if(Sliders != null)
                    hashCode = hashCode * 59 + Sliders.GetHashCode();

                if(ColorScale != null)
                    hashCode = hashCode * 59 + ColorScale.GetHashCode();

                if(ColorAxis != null)
                    hashCode = hashCode * 59 + ColorAxis.GetHashCode();

                if(MetaSrc != null)
                    hashCode = hashCode * 59 + MetaSrc.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Layout and the right Layout.
        /// </summary>
        /// <param name="left">Left Layout.</param>
        /// <param name="right">Right Layout.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(Layout left,
                                       Layout right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Layout and the right Layout.
        /// </summary>
        /// <param name="left">Left Layout.</param>
        /// <param name="right">Right Layout.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(Layout left,
                                       Layout right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Layout</returns>
        public Layout? DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<Layout>(ms).Result;
        }
    }
}
