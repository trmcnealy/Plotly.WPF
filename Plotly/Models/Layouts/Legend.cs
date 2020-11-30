using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Layouts.Legends;

namespace Plotly.Models.Layouts
{
    /// <summary>
    ///     The Legend class.
    /// </summary>
    
    [Serializable]
    public class Legend : IEquatable<Legend>
    {
        /// <summary>
        ///     Sets the legend background color. Defaults to <c>layout.paper_bgcolor</c>.
        /// </summary>
        [JsonPropertyName(@"bgcolor")]
        public object BgColor { get; set;} 

        /// <summary>
        ///     Sets the color of the border enclosing the legend.
        /// </summary>
        [JsonPropertyName(@"bordercolor")]
        public object BorderColor { get; set;} 

        /// <summary>
        ///     Sets the width (in px) of the border enclosing the legend.
        /// </summary>
        [JsonPropertyName(@"borderwidth")]
        public JsNumber? BorderWidth { get; set;} 

        /// <summary>
        ///     Sets the font used to text the legend items.
        /// </summary>
        [JsonPropertyName(@"font")]
        public Legends.Font Font { get; set;} 

        /// <summary>
        ///     Sets the orientation of the legend.
        /// </summary>
        [JsonPropertyName(@"orientation")]
        public OrientationEnum? Orientation { get; set;} 

        /// <summary>
        ///     Determines the order at which the legend items are displayed. If <c>normal</c>,
        ///     the items are displayed top-to-bottom in the same order as the input data.
        ///     If <c>reversed</c>, the items are displayed in the opposite order as <c>normal</c>.
        ///     If <c>grouped</c>, the items are displayed in groups (when a trace <c>legendgroup</c>
        ///     is provided). if <c>grouped+reversed</c>, the items are displayed in the
        ///     opposite order as <c>grouped</c>.
        /// </summary>
        [JsonPropertyName(@"traceorder")]
        public TraceOrderFlag? TraceOrder { get; set;} 

        /// <summary>
        ///     Sets the amount of vertical space (in px) between legend groups.
        /// </summary>
        [JsonPropertyName(@"tracegroupgap")]
        public JsNumber? TraceGroupGap { get; set;} 

        /// <summary>
        ///     Determines if the legend items symbols scale with their corresponding <c>trace</c>
        ///     attributes or remain <c>constant</c> independent of the symbol size on the
        ///     graph.
        /// </summary>
        [JsonPropertyName(@"itemsizing")]
        public ItemSizingEnum? ItemSizing { get; set;} 

        /// <summary>
        ///     Determines the behavior on legend item click. <c>toggle</c> toggles the
        ///     visibility of the item clicked on the graph. <c>toggleothers</c> makes the
        ///     clicked item the sole visible item on the graph. <c>false</c> disable legend
        ///     item click interactions.
        /// </summary>
        [JsonPropertyName(@"itemclick")]
        public ItemClickEnum? ItemClick { get; set;} 

        /// <summary>
        ///     Determines the behavior on legend item double-click. <c>toggle</c> toggles
        ///     the visibility of the item clicked on the graph. <c>toggleothers</c> makes
        ///     the clicked item the sole visible item on the graph. <c>false</c> disable
        ///     legend item double-click interactions.
        /// </summary>
        [JsonPropertyName(@"itemdoubleclick")]
        public ItemDoubleClickEnum? ItemDoubleClick { get; set;} 

        /// <summary>
        ///     Sets the x position (in normalized coordinates) of the legend. Defaults
        ///     to <c>1.02</c> for vertical legends and defaults to <c>0</c> for horizontal
        ///     legends.
        /// </summary>
        [JsonPropertyName(@"x")]
        public JsNumber? X { get; set;} 

        /// <summary>
        ///     Sets the legend&#39;s horizontal position anchor. This anchor binds the
        ///     <c>x</c> position to the <c>left</c>, <c>center</c> or <c>right</c> of the
        ///     legend. Value <c>auto</c> anchors legends to the right for <c>x</c> values
        ///     greater than or equal to 2/3, anchors legends to the left for <c>x</c> values
        ///     less than or equal to 1/3 and anchors legends with respect to their center
        ///     otherwise.
        /// </summary>
        [JsonPropertyName(@"xanchor")]
        public XAnchorEnum? XAnchor { get; set;} 

        /// <summary>
        ///     Sets the y position (in normalized coordinates) of the legend. Defaults
        ///     to <c>1</c> for vertical legends, defaults to <c>-0.1</c> for horizontal
        ///     legends on graphs w/o range sliders and defaults to <c>1.1</c> for horizontal
        ///     legends on graph with one or multiple range sliders.
        /// </summary>
        [JsonPropertyName(@"y")]
        public JsNumber? Y { get; set;} 

        /// <summary>
        ///     Sets the legend&#39;s vertical position anchor This anchor binds the <c>y</c>
        ///     position to the <c>top</c>, <c>middle</c> or <c>bottom</c> of the legend.
        ///     Value <c>auto</c> anchors legends at their bottom for <c>y</c> values less
        ///     than or equal to 1/3, anchors legends to at their top for <c>y</c> values
        ///     greater than or equal to 2/3 and anchors legends with respect to their middle
        ///     otherwise.
        /// </summary>
        [JsonPropertyName(@"yanchor")]
        public YAnchorEnum? YAnchor { get; set;} 

        /// <summary>
        ///     Controls persistence of legend-driven changes in trace and pie label visibility.
        ///     Defaults to <c>layout.uirevision</c>.
        /// </summary>
        [JsonPropertyName(@"uirevision")]
        public object UiRevision { get; set;} 

        /// <summary>
        ///     Sets the vertical alignment of the symbols with respect to their associated
        ///     text.
        /// </summary>
        [JsonPropertyName(@"valign")]
        public VAlignEnum? VAlign { get; set;} 

        /// <summary>
        ///     Gets or sets the Title.
        /// </summary>
        [JsonPropertyName(@"title")]
        public Legends.Title Title { get; set;} 

        
        public override bool Equals(object obj)
        {
            if (!(obj is Legend other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        
        public bool Equals([AllowNull] Legend other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    BgColor == other.BgColor &&
                    BgColor != null && other.BgColor != null &&
                    BgColor.Equals(other.BgColor)
                ) && 
                (
                    BorderColor == other.BorderColor &&
                    BorderColor != null && other.BorderColor != null &&
                    BorderColor.Equals(other.BorderColor)
                ) && 
                (
                    BorderWidth == other.BorderWidth &&
                    BorderWidth != null && other.BorderWidth != null &&
                    BorderWidth.Equals(other.BorderWidth)
                ) && 
                (
                    Font == other.Font &&
                    Font != null && other.Font != null &&
                    Font.Equals(other.Font)
                ) && 
                (
                    Orientation == other.Orientation &&
                    Orientation != null && other.Orientation != null &&
                    Orientation.Equals(other.Orientation)
                ) && 
                (
                    TraceOrder == other.TraceOrder &&
                    TraceOrder != null && other.TraceOrder != null &&
                    TraceOrder.Equals(other.TraceOrder)
                ) && 
                (
                    TraceGroupGap == other.TraceGroupGap &&
                    TraceGroupGap != null && other.TraceGroupGap != null &&
                    TraceGroupGap.Equals(other.TraceGroupGap)
                ) && 
                (
                    ItemSizing == other.ItemSizing &&
                    ItemSizing != null && other.ItemSizing != null &&
                    ItemSizing.Equals(other.ItemSizing)
                ) && 
                (
                    ItemClick == other.ItemClick &&
                    ItemClick != null && other.ItemClick != null &&
                    ItemClick.Equals(other.ItemClick)
                ) && 
                (
                    ItemDoubleClick == other.ItemDoubleClick &&
                    ItemDoubleClick != null && other.ItemDoubleClick != null &&
                    ItemDoubleClick.Equals(other.ItemDoubleClick)
                ) && 
                (
                    X == other.X &&
                    X != null && other.X != null &&
                    X.Equals(other.X)
                ) && 
                (
                    XAnchor == other.XAnchor &&
                    XAnchor != null && other.XAnchor != null &&
                    XAnchor.Equals(other.XAnchor)
                ) && 
                (
                    Y == other.Y &&
                    Y != null && other.Y != null &&
                    Y.Equals(other.Y)
                ) && 
                (
                    YAnchor == other.YAnchor &&
                    YAnchor != null && other.YAnchor != null &&
                    YAnchor.Equals(other.YAnchor)
                ) && 
                (
                    UiRevision == other.UiRevision &&
                    UiRevision != null && other.UiRevision != null &&
                    UiRevision.Equals(other.UiRevision)
                ) && 
                (
                    VAlign == other.VAlign &&
                    VAlign != null && other.VAlign != null &&
                    VAlign.Equals(other.VAlign)
                ) && 
                (
                    Title == other.Title &&
                    Title != null && other.Title != null &&
                    Title.Equals(other.Title)
                );
        }

        
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (BgColor != null) hashCode = hashCode * 59 + BgColor.GetHashCode();
                if (BorderColor != null) hashCode = hashCode * 59 + BorderColor.GetHashCode();
                if (BorderWidth != null) hashCode = hashCode * 59 + BorderWidth.GetHashCode();
                if (Font != null) hashCode = hashCode * 59 + Font.GetHashCode();
                if (Orientation != null) hashCode = hashCode * 59 + Orientation.GetHashCode();
                if (TraceOrder != null) hashCode = hashCode * 59 + TraceOrder.GetHashCode();
                if (TraceGroupGap != null) hashCode = hashCode * 59 + TraceGroupGap.GetHashCode();
                if (ItemSizing != null) hashCode = hashCode * 59 + ItemSizing.GetHashCode();
                if (ItemClick != null) hashCode = hashCode * 59 + ItemClick.GetHashCode();
                if (ItemDoubleClick != null) hashCode = hashCode * 59 + ItemDoubleClick.GetHashCode();
                if (X != null) hashCode = hashCode * 59 + X.GetHashCode();
                if (XAnchor != null) hashCode = hashCode * 59 + XAnchor.GetHashCode();
                if (Y != null) hashCode = hashCode * 59 + Y.GetHashCode();
                if (YAnchor != null) hashCode = hashCode * 59 + YAnchor.GetHashCode();
                if (UiRevision != null) hashCode = hashCode * 59 + UiRevision.GetHashCode();
                if (VAlign != null) hashCode = hashCode * 59 + VAlign.GetHashCode();
                if (Title != null) hashCode = hashCode * 59 + Title.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Legend and the right Legend.
        /// </summary>
        /// <param name="left">Left Legend.</param>
        /// <param name="right">Right Legend.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (Legend left, Legend right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Legend and the right Legend.
        /// </summary>
        /// <param name="left">Left Legend.</param>
        /// <param name="right">Right Legend.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (Legend left, Legend right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Legend</returns>
        public Legend DeepClone()
        {
            using MemoryStream ms = new();
            
            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;
            return JsonSerializer.DeserializeAsync<Legend>(ms).Result;
        }
    }
}