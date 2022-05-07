using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Layouts.Scenes.Annotations;

namespace Plotly.Models.Layouts.Scenes
{
    /// <summary>
    ///     The Annotation class.
    /// </summary>
    [Serializable]
    public class Annotation : IEquatable<Annotation>
    {
        /// <summary>
        ///     Determines whether or not this annotation is visible.
        /// </summary>
        [JsonPropertyName(@"visible")]
        public bool? Visible { get; set; }

        /// <summary>
        ///     Sets the annotation&#39;s x position.
        /// </summary>
        [JsonPropertyName(@"x")]
        public object? X { get; set; }

        /// <summary>
        ///     Sets the annotation&#39;s y position.
        /// </summary>
        [JsonPropertyName(@"y")]
        public object? Y { get; set; }

        /// <summary>
        ///     Sets the annotation&#39;s z position.
        /// </summary>
        [JsonPropertyName(@"z")]
        public object? Z { get; set; }

        /// <summary>
        ///     Sets the x component of the arrow tail about the arrow head (in pixels).
        /// </summary>
        [JsonPropertyName(@"ax")]
        public JsNumber? Ax { get; set; }

        /// <summary>
        ///     Sets the y component of the arrow tail about the arrow head (in pixels).
        /// </summary>
        [JsonPropertyName(@"ay")]
        public JsNumber? Ay { get; set; }

        /// <summary>
        ///     Sets the text box&#39;s horizontal position anchor This anchor binds the
        ///     <c>x</c> position to the <c>left</c>, <c>center</c> or <c>right</c> of the
        ///     annotation. For example, if <c>x</c> is set to 1, <c>xref</c> to <c>paper</c>
        ///     and <c>xanchor</c> to <c>right</c> then the right-most portion of the annotation
        ///     lines up with the right-most edge of the plotting area. If <c>auto</c>,
        ///     the anchor is equivalent to <c>center</c> for data-referenced annotations
        ///     or if there is an arrow, whereas for paper-referenced with no arrow, the
        ///     anchor picked corresponds to the closest side.
        /// </summary>
        [JsonPropertyName(@"xanchor")]
        public XAnchorEnum? XAnchor { get; set; }

        /// <summary>
        ///     Shifts the position of the whole annotation and arrow to the right (positive)
        ///     or left (negative) by this many pixels.
        /// </summary>
        [JsonPropertyName(@"xshift")]
        public JsNumber? XShift { get; set; }

        /// <summary>
        ///     Sets the text box&#39;s vertical position anchor This anchor binds the <c>y</c>
        ///     position to the <c>top</c>, <c>middle</c> or <c>bottom</c> of the annotation.
        ///     For example, if <c>y</c> is set to 1, <c>yref</c> to <c>paper</c> and <c>yanchor</c>
        ///     to <c>top</c> then the top-most portion of the annotation lines up with
        ///     the top-most edge of the plotting area. If <c>auto</c>, the anchor is equivalent
        ///     to <c>middle</c> for data-referenced annotations or if there is an arrow,
        ///     whereas for paper-referenced with no arrow, the anchor picked corresponds
        ///     to the closest side.
        /// </summary>
        [JsonPropertyName(@"yanchor")]
        public YAnchorEnum? YAnchor { get; set; }

        /// <summary>
        ///     Shifts the position of the whole annotation and arrow up (positive) or down
        ///     (negative) by this many pixels.
        /// </summary>
        [JsonPropertyName(@"yshift")]
        public JsNumber? YShift { get; set; }

        /// <summary>
        ///     Sets the text associated with this annotation. Plotly uses a subset of HTML
        ///     tags to do things like newline (&lt;br&gt;), bold (&lt;b&gt;&lt;/b&gt;),
        ///     italics (&lt;i&gt;&lt;/i&gt;), hyperlinks (&lt;a href=<c>...</c>&gt;&lt;/a&gt;).
        ///     Tags &lt;em&gt;, &lt;sup&gt;, &lt;sub&gt; &lt;span&gt; are also supported.
        /// </summary>
        [JsonPropertyName(@"text")]
        public string? Text { get; set; }

        /// <summary>
        ///     Sets the angle at which the <c>text</c> is drawn with respect to the horizontal.
        /// </summary>
        [JsonPropertyName(@"textangle")]
        public JsNumber? TextAngle { get; set; }

        /// <summary>
        ///     Sets the annotation text font.
        /// </summary>
        [JsonPropertyName(@"font")]
        public Annotations.Font? Font { get; set; }

        /// <summary>
        ///     Sets an explicit width for the text box. null (default) lets the text set
        ///     the box width. Wider text will be clipped. There is no automatic wrapping;
        ///     use &lt;br&gt; to start a new line.
        /// </summary>
        [JsonPropertyName(@"width")]
        public JsNumber? Width { get; set; }

        /// <summary>
        ///     Sets an explicit height for the text box. null (default) lets the text set
        ///     the box height. Taller text will be clipped.
        /// </summary>
        [JsonPropertyName(@"height")]
        public JsNumber? Height { get; set; }

        /// <summary>
        ///     Sets the opacity of the annotation (text + arrow).
        /// </summary>
        [JsonPropertyName(@"opacity")]
        public JsNumber? Opacity { get; set; }

        /// <summary>
        ///     Sets the horizontal alignment of the <c>text</c> within the box. Has an
        ///     effect only if <c>text</c> spans two or more lines (i.e. <c>text</c> contains
        ///     one or more &lt;br&gt; HTML tags) or if an explicit width is set to override
        ///     the text width.
        /// </summary>
        [JsonPropertyName(@"align")]
        public AlignEnum? Align { get; set; }

        /// <summary>
        ///     Sets the vertical alignment of the <c>text</c> within the box. Has an effect
        ///     only if an explicit height is set to override the text height.
        /// </summary>
        [JsonPropertyName(@"valign")]
        public VAlignEnum? VAlign { get; set; }

        /// <summary>
        ///     Sets the background color of the annotation.
        /// </summary>
        [JsonPropertyName(@"bgcolor")]
        public object? BgColor { get; set; }

        /// <summary>
        ///     Sets the color of the border enclosing the annotation <c>text</c>.
        /// </summary>
        [JsonPropertyName(@"bordercolor")]
        public object? BorderColor { get; set; }

        /// <summary>
        ///     Sets the padding (in px) between the <c>text</c> and the enclosing border.
        /// </summary>
        [JsonPropertyName(@"borderpad")]
        public JsNumber? BorderPad { get; set; }

        /// <summary>
        ///     Sets the width (in px) of the border enclosing the annotation <c>text</c>.
        /// </summary>
        [JsonPropertyName(@"borderwidth")]
        public JsNumber? BorderWidth { get; set; }

        /// <summary>
        ///     Determines whether or not the annotation is drawn with an arrow. If <c>true</c>,
        ///     <c>text</c> is placed near the arrow&#39;s tail. If <c>false</c>, <c>text</c>
        ///     lines up with the <c>x</c> and <c>y</c> provided.
        /// </summary>
        [JsonPropertyName(@"showarrow")]
        public bool? ShowArrow { get; set; }

        /// <summary>
        ///     Sets the color of the annotation arrow.
        /// </summary>
        [JsonPropertyName(@"arrowcolor")]
        public object? ArrowColor { get; set; }

        /// <summary>
        ///     Sets the end annotation arrow head style.
        /// </summary>
        [JsonPropertyName(@"arrowhead")]
        public int? Arrowhead { get; set; }

        /// <summary>
        ///     Sets the start annotation arrow head style.
        /// </summary>
        [JsonPropertyName(@"startarrowhead")]
        public int? StartArrowhead { get; set; }

        /// <summary>
        ///     Sets the annotation arrow head position.
        /// </summary>
        [JsonPropertyName(@"arrowside")]
        public ArrowSideFlag? ArrowSide { get; set; }

        /// <summary>
        ///     Sets the size of the end annotation arrow head, relative to <c>arrowwidth</c>.
        ///     A value of 1 (default) gives a head about 3x as wide as the line.
        /// </summary>
        [JsonPropertyName(@"arrowsize")]
        public JsNumber? ArrowSize { get; set; }

        /// <summary>
        ///     Sets the size of the start annotation arrow head, relative to <c>arrowwidth</c>.
        ///     A value of 1 (default) gives a head about 3x as wide as the line.
        /// </summary>
        [JsonPropertyName(@"startarrowsize")]
        public JsNumber? StartArrowSize { get; set; }

        /// <summary>
        ///     Sets the width (in px) of annotation arrow line.
        /// </summary>
        [JsonPropertyName(@"arrowwidth")]
        public JsNumber? ArrowWidth { get; set; }

        /// <summary>
        ///     Sets a distance, in pixels, to move the end arrowhead away from the position
        ///     it is pointing at, for example to point at the edge of a marker independent
        ///     of zoom. Note that this shortens the arrow from the <c>ax</c> / <c>ay</c>
        ///     vector, in contrast to <c>xshift</c> / <c>yshift</c> which moves everything
        ///     by this amount.
        /// </summary>
        [JsonPropertyName(@"standoff")]
        public JsNumber? Standoff { get; set; }

        /// <summary>
        ///     Sets a distance, in pixels, to move the start arrowhead away from the position
        ///     it is pointing at, for example to point at the edge of a marker independent
        ///     of zoom. Note that this shortens the arrow from the <c>ax</c> / <c>ay</c>
        ///     vector, in contrast to <c>xshift</c> / <c>yshift</c> which moves everything
        ///     by this amount.
        /// </summary>
        [JsonPropertyName(@"startstandoff")]
        public JsNumber? StartStandoff { get; set; }

        /// <summary>
        ///     Sets text to appear when hovering over this annotation. If omitted or blank,
        ///     no hover label will appear.
        /// </summary>
        [JsonPropertyName(@"hovertext")]
        public string? HoverText { get; set; }

        /// <summary>
        ///     Gets or sets the HoverLabel.
        /// </summary>
        [JsonPropertyName(@"hoverlabel")]
        public Annotations.HoverLabel? HoverLabel { get; set; }

        /// <summary>
        ///     Determines whether the annotation text box captures mouse move and click
        ///     events, or allows those events to pass through to data points in the plot
        ///     that may be behind the annotation. By default <c>captureevents</c> is <c>false</c>
        ///     unless <c>hovertext</c> is provided. If you use the event <c>plotly_clickannotation</c>
        ///     without <c>hovertext</c> you must explicitly enable <c>captureevents</c>.
        /// </summary>
        [JsonPropertyName(@"captureevents")]
        public bool? CaptureEvents { get; set; }

        /// <summary>
        ///     When used in a template, named items are created in the output figure in
        ///     addition to any items the figure already has in this array. You can modify
        ///     these items in the output figure by making your own item with <c>templateitemname</c>
        ///     matching this <c>name</c> alongside your modifications (including &#39;visible:
        ///     false&#39; or &#39;enabled: false&#39; to hide it). Has no effect outside
        ///     of a template.
        /// </summary>
        [JsonPropertyName(@"name")]
        public string? Name { get; set; }

        /// <summary>
        ///     Used to refer to a named item in this array in the template. Named items
        ///     from the template will be created even without a matching item in the input
        ///     figure, but you can modify one by making an item with <c>templateitemname</c>
        ///     matching its <c>name</c>, alongside your modifications (including &#39;visible:
        ///     false&#39; or &#39;enabled: false&#39; to hide it). If there is no template
        ///     or no matching item, this item will be hidden unless you explicitly show
        ///     it with &#39;visible: true&#39;.
        /// </summary>
        [JsonPropertyName(@"templateitemname")]
        public string? TemplateItemName { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is Annotation other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] Annotation other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (Visible          == other.Visible          && Visible          != null && other.Visible          != null && Visible.Equals(other.Visible))               &&
                   (X                == other.X                && X                != null && other.X                != null && X.Equals(other.X))                           &&
                   (Y                == other.Y                && Y                != null && other.Y                != null && Y.Equals(other.Y))                           &&
                   (Z                == other.Z                && Z                != null && other.Z                != null && Z.Equals(other.Z))                           &&
                   (Ax               == other.Ax               && Ax               != null && other.Ax               != null && Ax.Equals(other.Ax))                         &&
                   (Ay               == other.Ay               && Ay               != null && other.Ay               != null && Ay.Equals(other.Ay))                         &&
                   (XAnchor          == other.XAnchor          && XAnchor          != null && other.XAnchor          != null && XAnchor.Equals(other.XAnchor))               &&
                   (XShift           == other.XShift           && XShift           != null && other.XShift           != null && XShift.Equals(other.XShift))                 &&
                   (YAnchor          == other.YAnchor          && YAnchor          != null && other.YAnchor          != null && YAnchor.Equals(other.YAnchor))               &&
                   (YShift           == other.YShift           && YShift           != null && other.YShift           != null && YShift.Equals(other.YShift))                 &&
                   (Text             == other.Text             && Text             != null && other.Text             != null && Text.Equals(other.Text))                     &&
                   (TextAngle        == other.TextAngle        && TextAngle        != null && other.TextAngle        != null && TextAngle.Equals(other.TextAngle))           &&
                   (Font             == other.Font             && Font             != null && other.Font             != null && Font.Equals(other.Font))                     &&
                   (Width            == other.Width            && Width            != null && other.Width            != null && Width.Equals(other.Width))                   &&
                   (Height           == other.Height           && Height           != null && other.Height           != null && Height.Equals(other.Height))                 &&
                   (Opacity          == other.Opacity          && Opacity          != null && other.Opacity          != null && Opacity.Equals(other.Opacity))               &&
                   (Align            == other.Align            && Align            != null && other.Align            != null && Align.Equals(other.Align))                   &&
                   (VAlign           == other.VAlign           && VAlign           != null && other.VAlign           != null && VAlign.Equals(other.VAlign))                 &&
                   (BgColor          == other.BgColor          && BgColor          != null && other.BgColor          != null && BgColor.Equals(other.BgColor))               &&
                   (BorderColor      == other.BorderColor      && BorderColor      != null && other.BorderColor      != null && BorderColor.Equals(other.BorderColor))       &&
                   (BorderPad        == other.BorderPad        && BorderPad        != null && other.BorderPad        != null && BorderPad.Equals(other.BorderPad))           &&
                   (BorderWidth      == other.BorderWidth      && BorderWidth      != null && other.BorderWidth      != null && BorderWidth.Equals(other.BorderWidth))       &&
                   (ShowArrow        == other.ShowArrow        && ShowArrow        != null && other.ShowArrow        != null && ShowArrow.Equals(other.ShowArrow))           &&
                   (ArrowColor       == other.ArrowColor       && ArrowColor       != null && other.ArrowColor       != null && ArrowColor.Equals(other.ArrowColor))         &&
                   (Arrowhead        == other.Arrowhead        && Arrowhead        != null && other.Arrowhead        != null && Arrowhead.Equals(other.Arrowhead))           &&
                   (StartArrowhead   == other.StartArrowhead   && StartArrowhead   != null && other.StartArrowhead   != null && StartArrowhead.Equals(other.StartArrowhead)) &&
                   (ArrowSide        == other.ArrowSide        && ArrowSide        != null && other.ArrowSide        != null && ArrowSide.Equals(other.ArrowSide))           &&
                   (ArrowSize        == other.ArrowSize        && ArrowSize        != null && other.ArrowSize        != null && ArrowSize.Equals(other.ArrowSize))           &&
                   (StartArrowSize   == other.StartArrowSize   && StartArrowSize   != null && other.StartArrowSize   != null && StartArrowSize.Equals(other.StartArrowSize)) &&
                   (ArrowWidth       == other.ArrowWidth       && ArrowWidth       != null && other.ArrowWidth       != null && ArrowWidth.Equals(other.ArrowWidth))         &&
                   (Standoff         == other.Standoff         && Standoff         != null && other.Standoff         != null && Standoff.Equals(other.Standoff))             &&
                   (StartStandoff    == other.StartStandoff    && StartStandoff    != null && other.StartStandoff    != null && StartStandoff.Equals(other.StartStandoff))   &&
                   (HoverText        == other.HoverText        && HoverText        != null && other.HoverText        != null && HoverText.Equals(other.HoverText))           &&
                   (HoverLabel       == other.HoverLabel       && HoverLabel       != null && other.HoverLabel       != null && HoverLabel.Equals(other.HoverLabel))         &&
                   (CaptureEvents    == other.CaptureEvents    && CaptureEvents    != null && other.CaptureEvents    != null && CaptureEvents.Equals(other.CaptureEvents))   &&
                   (Name             == other.Name             && Name             != null && other.Name             != null && Name.Equals(other.Name))                     &&
                   (TemplateItemName == other.TemplateItemName && TemplateItemName != null && other.TemplateItemName != null && TemplateItemName.Equals(other.TemplateItemName));
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;

                if(Visible != null)
                    hashCode = hashCode * 59 + Visible.GetHashCode();

                if(X != null)
                    hashCode = hashCode * 59 + X.GetHashCode();

                if(Y != null)
                    hashCode = hashCode * 59 + Y.GetHashCode();

                if(Z != null)
                    hashCode = hashCode * 59 + Z.GetHashCode();

                if(Ax != null)
                    hashCode = hashCode * 59 + Ax.GetHashCode();

                if(Ay != null)
                    hashCode = hashCode * 59 + Ay.GetHashCode();

                if(XAnchor != null)
                    hashCode = hashCode * 59 + XAnchor.GetHashCode();

                if(XShift != null)
                    hashCode = hashCode * 59 + XShift.GetHashCode();

                if(YAnchor != null)
                    hashCode = hashCode * 59 + YAnchor.GetHashCode();

                if(YShift != null)
                    hashCode = hashCode * 59 + YShift.GetHashCode();

                if(Text != null)
                    hashCode = hashCode * 59 + Text.GetHashCode();

                if(TextAngle != null)
                    hashCode = hashCode * 59 + TextAngle.GetHashCode();

                if(Font != null)
                    hashCode = hashCode * 59 + Font.GetHashCode();

                if(Width != null)
                    hashCode = hashCode * 59 + Width.GetHashCode();

                if(Height != null)
                    hashCode = hashCode * 59 + Height.GetHashCode();

                if(Opacity != null)
                    hashCode = hashCode * 59 + Opacity.GetHashCode();

                if(Align != null)
                    hashCode = hashCode * 59 + Align.GetHashCode();

                if(VAlign != null)
                    hashCode = hashCode * 59 + VAlign.GetHashCode();

                if(BgColor != null)
                    hashCode = hashCode * 59 + BgColor.GetHashCode();

                if(BorderColor != null)
                    hashCode = hashCode * 59 + BorderColor.GetHashCode();

                if(BorderPad != null)
                    hashCode = hashCode * 59 + BorderPad.GetHashCode();

                if(BorderWidth != null)
                    hashCode = hashCode * 59 + BorderWidth.GetHashCode();

                if(ShowArrow != null)
                    hashCode = hashCode * 59 + ShowArrow.GetHashCode();

                if(ArrowColor != null)
                    hashCode = hashCode * 59 + ArrowColor.GetHashCode();

                if(Arrowhead != null)
                    hashCode = hashCode * 59 + Arrowhead.GetHashCode();

                if(StartArrowhead != null)
                    hashCode = hashCode * 59 + StartArrowhead.GetHashCode();

                if(ArrowSide != null)
                    hashCode = hashCode * 59 + ArrowSide.GetHashCode();

                if(ArrowSize != null)
                    hashCode = hashCode * 59 + ArrowSize.GetHashCode();

                if(StartArrowSize != null)
                    hashCode = hashCode * 59 + StartArrowSize.GetHashCode();

                if(ArrowWidth != null)
                    hashCode = hashCode * 59 + ArrowWidth.GetHashCode();

                if(Standoff != null)
                    hashCode = hashCode * 59 + Standoff.GetHashCode();

                if(StartStandoff != null)
                    hashCode = hashCode * 59 + StartStandoff.GetHashCode();

                if(HoverText != null)
                    hashCode = hashCode * 59 + HoverText.GetHashCode();

                if(HoverLabel != null)
                    hashCode = hashCode * 59 + HoverLabel.GetHashCode();

                if(CaptureEvents != null)
                    hashCode = hashCode * 59 + CaptureEvents.GetHashCode();

                if(Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();

                if(TemplateItemName != null)
                    hashCode = hashCode * 59 + TemplateItemName.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Annotation and the right Annotation.
        /// </summary>
        /// <param name="left">Left Annotation.</param>
        /// <param name="right">Right Annotation.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(Annotation left,
                                       Annotation right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Annotation and the right Annotation.
        /// </summary>
        /// <param name="left">Left Annotation.</param>
        /// <param name="right">Right Annotation.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(Annotation left,
                                       Annotation right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Annotation</returns>
        public Annotation DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<Annotation>(ms).Result;
        }
    }
}
