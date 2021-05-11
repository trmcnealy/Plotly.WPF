using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Layouts.Shapes;

namespace Plotly.Models.Layouts
{
    /// <summary>
    ///     The Shape class.
    /// </summary>
    [Serializable]
    public class Shape : IEquatable<Shape>
    {
        /// <summary>
        ///     Determines whether or not this shape is visible.
        /// </summary>
        [JsonPropertyName(@"visible")]
        public bool? Visible { get; set; }

        /// <summary>
        ///     Specifies the shape type to be drawn. If <c>line</c>, a line is drawn from
        ///     (<c>x0</c>,<c>y0</c>) to (<c>x1</c>,<c>y1</c>) with respect to the axes&#39;
        ///     sizing mode. If <c>circle</c>, a circle is drawn from ((<c>x0</c>+<c>x1</c>)/2,
        ///     (<c>y0</c>+<c>y1</c>)/2)) with radius (|(<c>x0</c>+<c>x1</c>)/2 - <c>x0</c>|,
        ///     |(<c>y0</c>+<c>y1</c>)/2 -<c>y0</c>)|) with respect to the axes&#39; sizing
        ///     mode. If <c>rect</c>, a rectangle is drawn linking (<c>x0</c>,<c>y0</c>),
        ///     (<c>x1</c>,<c>y0</c>), (<c>x1</c>,<c>y1</c>), (<c>x0</c>,<c>y1</c>), (<c>x0</c>,<c>y0</c>)
        ///     with respect to the axes&#39; sizing mode. If <c>path</c>, draw a custom
        ///     SVG path using <c>path</c>. with respect to the axes&#39; sizing mode.
        /// </summary>
        [JsonPropertyName(@"type")]
        public TypeEnum? Type { get; set; }

        /// <summary>
        ///     Specifies whether shapes are drawn below or above traces.
        /// </summary>
        [JsonPropertyName(@"layer")]
        public LayerEnum? Layer { get; set; }

        /// <summary>
        ///     Sets the shape&#39;s x coordinate axis. If set to an x axis id (e.g. <c>x</c>
        ///     or <c>x2</c>), the <c>x</c> position refers to an x coordinate. If set to
        ///     <c>paper</c>, the <c>x</c> position refers to the distance from the left
        ///     side of the plotting area in normalized coordinates where <c>0</c> (<c>1</c>)
        ///     corresponds to the left (right) side. If the axis <c>type</c> is <c>log</c>,
        ///     then you must take the log of your desired range. If the axis <c>type</c>
        ///     is <c>date</c>, then you must convert the date to unix time in milliseconds.
        /// </summary>
        [JsonPropertyName(@"xref")]
        public string XRef { get; set; }

        /// <summary>
        ///     Sets the shapes&#39;s sizing mode along the x axis. If set to <c>scaled</c>,
        ///     <c>x0</c>, <c>x1</c> and x coordinates within <c>path</c> refer to data
        ///     values on the x axis or a fraction of the plot area&#39;s width (<c>xref</c>
        ///     set to <c>paper</c>). If set to <c>pixel</c>, <c>xanchor</c> specifies the
        ///     x position in terms of data or plot fraction but <c>x0</c>, <c>x1</c> and
        ///     x coordinates within <c>path</c> are pixels relative to <c>xanchor</c>.
        ///     This way, the shape can have a fixed width while maintaining a position
        ///     relative to data or plot fraction.
        /// </summary>
        [JsonPropertyName(@"xsizemode")]
        public XSizeModeEnum? XSizeMode { get; set; }

        /// <summary>
        ///     Only relevant in conjunction with <c>xsizemode</c> set to <c>pixel</c>.
        ///     Specifies the anchor point on the x axis to which <c>x0</c>, <c>x1</c> and
        ///     x coordinates within <c>path</c> are relative to. E.g. useful to attach
        ///     a pixel sized shape to a certain data value. No effect when <c>xsizemode</c>
        ///     not set to <c>pixel</c>.
        /// </summary>
        [JsonPropertyName(@"xanchor")]
        public object XAnchor { get; set; }

        /// <summary>
        ///     Sets the shape&#39;s starting x position. See <c>type</c> and <c>xsizemode</c>
        ///     for more info.
        /// </summary>
        [JsonPropertyName(@"x0")]
        public object X0 { get; set; }

        /// <summary>
        ///     Sets the shape&#39;s end x position. See <c>type</c> and <c>xsizemode</c>
        ///     for more info.
        /// </summary>
        [JsonPropertyName(@"x1")]
        public object X1 { get; set; }

        /// <summary>
        ///     Sets the annotation&#39;s y coordinate axis. If set to an y axis id (e.g.
        ///     <c>y</c> or <c>y2</c>), the <c>y</c> position refers to an y coordinate
        ///     If set to <c>paper</c>, the <c>y</c> position refers to the distance from
        ///     the bottom of the plotting area in normalized coordinates where <c>0</c>
        ///     (<c>1</c>) corresponds to the bottom (top).
        /// </summary>
        [JsonPropertyName(@"yref")]
        public string YRef { get; set; }

        /// <summary>
        ///     Sets the shapes&#39;s sizing mode along the y axis. If set to <c>scaled</c>,
        ///     <c>y0</c>, <c>y1</c> and y coordinates within <c>path</c> refer to data
        ///     values on the y axis or a fraction of the plot area&#39;s height (<c>yref</c>
        ///     set to <c>paper</c>). If set to <c>pixel</c>, <c>yanchor</c> specifies the
        ///     y position in terms of data or plot fraction but <c>y0</c>, <c>y1</c> and
        ///     y coordinates within <c>path</c> are pixels relative to <c>yanchor</c>.
        ///     This way, the shape can have a fixed height while maintaining a position
        ///     relative to data or plot fraction.
        /// </summary>
        [JsonPropertyName(@"ysizemode")]
        public YSizeModeEnum? YSizeMode { get; set; }

        /// <summary>
        ///     Only relevant in conjunction with <c>ysizemode</c> set to <c>pixel</c>.
        ///     Specifies the anchor point on the y axis to which <c>y0</c>, <c>y1</c> and
        ///     y coordinates within <c>path</c> are relative to. E.g. useful to attach
        ///     a pixel sized shape to a certain data value. No effect when <c>ysizemode</c>
        ///     not set to <c>pixel</c>.
        /// </summary>
        [JsonPropertyName(@"yanchor")]
        public object YAnchor { get; set; }

        /// <summary>
        ///     Sets the shape&#39;s starting y position. See <c>type</c> and <c>ysizemode</c>
        ///     for more info.
        /// </summary>
        [JsonPropertyName(@"y0")]
        public object Y0 { get; set; }

        /// <summary>
        ///     Sets the shape&#39;s end y position. See <c>type</c> and <c>ysizemode</c>
        ///     for more info.
        /// </summary>
        [JsonPropertyName(@"y1")]
        public object Y1 { get; set; }

        /// <summary>
        ///     For <c>type</c> <c>path</c> - a valid SVG path with the pixel values replaced
        ///     by data values in <c>xsizemode</c>/<c>ysizemode</c> being <c>scaled</c>
        ///     and taken unmodified as pixels relative to <c>xanchor</c> and <c>yanchor</c>
        ///     in case of <c>pixel</c> size mode. There are a few restrictions / quirks
        ///     only absolute instructions, not relative. So the allowed segments are: M,
        ///     L, H, V, Q, C, T, S, and Z arcs (A) are not allowed because radius rx and
        ///     ry are relative. In the future we could consider supporting relative commands,
        ///     but we would have to decide on how to handle date and log axes. Note that
        ///     even as is, Q and C Bezier paths that are smooth on linear axes may not
        ///     be smooth on log, and vice versa. no chained <c>polybezier</c> commands
        ///     - specify the segment type for each one. On category axes, values are numbers
        ///     scaled to the serial numbers of categories because using the categories
        ///     themselves there would be no way to describe fractional positions On data
        ///     axes: because space and T are both normal components of path strings, we
        ///     can&#39;t use either to separate date from time parts. Therefore we&#39;ll
        ///     use underscore for this purpose: 2015-02-21_13:45:56.789
        /// </summary>
        [JsonPropertyName(@"path")]
        public string Path { get; set; }

        /// <summary>
        ///     Sets the opacity of the shape.
        /// </summary>
        [JsonPropertyName(@"opacity")]
        public JsNumber? Opacity { get; set; }

        /// <summary>
        ///     Gets or sets the Line.
        /// </summary>
        [JsonPropertyName(@"line")]
        public Line Line { get; set; }

        /// <summary>
        ///     Sets the color filling the shape&#39;s interior. Only applies to closed
        ///     shapes.
        /// </summary>
        [JsonPropertyName(@"fillcolor")]
        public object FillColor { get; set; }

        /// <summary>
        ///     Determines which regions of complex paths constitute the interior. For more
        ///     info please visit https://developer.mozilla.org/en-US/docs/Web/SVG/Attribute/fill-rule
        /// </summary>
        [JsonPropertyName(@"fillrule")]
        public FillRuleEnum? FillRule { get; set; }

        /// <summary>
        ///     Determines whether the shape could be activated for edit or not. Has no
        ///     effect when the older editable shapes mode is enabled via <c>config.editable</c>
        ///     or <c>config.edits.shapePosition</c>.
        /// </summary>
        [JsonPropertyName(@"editable")]
        public bool? Editable { get; set; }

        /// <summary>
        ///     When used in a template, named items are created in the output figure in
        ///     addition to any items the figure already has in this array. You can modify
        ///     these items in the output figure by making your own item with <c>templateitemname</c>
        ///     matching this <c>name</c> alongside your modifications (including &#39;visible:
        ///     false&#39; or &#39;enabled: false&#39; to hide it). Has no effect outside
        ///     of a template.
        /// </summary>
        [JsonPropertyName(@"name")]
        public string Name { get; set; }

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
        public string TemplateItemName { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is Shape other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] Shape other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (Visible          == other.Visible          && Visible          != null && other.Visible          != null && Visible.Equals(other.Visible))     &&
                   (Type             == other.Type             && Type             != null && other.Type             != null && Type.Equals(other.Type))           &&
                   (Layer            == other.Layer            && Layer            != null && other.Layer            != null && Layer.Equals(other.Layer))         &&
                   (XRef             == other.XRef             && XRef             != null && other.XRef             != null && XRef.Equals(other.XRef))           &&
                   (XSizeMode        == other.XSizeMode        && XSizeMode        != null && other.XSizeMode        != null && XSizeMode.Equals(other.XSizeMode)) &&
                   (XAnchor          == other.XAnchor          && XAnchor          != null && other.XAnchor          != null && XAnchor.Equals(other.XAnchor))     &&
                   (X0               == other.X0               && X0               != null && other.X0               != null && X0.Equals(other.X0))               &&
                   (X1               == other.X1               && X1               != null && other.X1               != null && X1.Equals(other.X1))               &&
                   (YRef             == other.YRef             && YRef             != null && other.YRef             != null && YRef.Equals(other.YRef))           &&
                   (YSizeMode        == other.YSizeMode        && YSizeMode        != null && other.YSizeMode        != null && YSizeMode.Equals(other.YSizeMode)) &&
                   (YAnchor          == other.YAnchor          && YAnchor          != null && other.YAnchor          != null && YAnchor.Equals(other.YAnchor))     &&
                   (Y0               == other.Y0               && Y0               != null && other.Y0               != null && Y0.Equals(other.Y0))               &&
                   (Y1               == other.Y1               && Y1               != null && other.Y1               != null && Y1.Equals(other.Y1))               &&
                   (Path             == other.Path             && Path             != null && other.Path             != null && Path.Equals(other.Path))           &&
                   (Opacity          == other.Opacity          && Opacity          != null && other.Opacity          != null && Opacity.Equals(other.Opacity))     &&
                   (Line             == other.Line             && Line             != null && other.Line             != null && Line.Equals(other.Line))           &&
                   (FillColor        == other.FillColor        && FillColor        != null && other.FillColor        != null && FillColor.Equals(other.FillColor)) &&
                   (FillRule         == other.FillRule         && FillRule         != null && other.FillRule         != null && FillRule.Equals(other.FillRule))   &&
                   (Editable         == other.Editable         && Editable         != null && other.Editable         != null && Editable.Equals(other.Editable))   &&
                   (Name             == other.Name             && Name             != null && other.Name             != null && Name.Equals(other.Name))           &&
                   (TemplateItemName == other.TemplateItemName && TemplateItemName != null && other.TemplateItemName != null && TemplateItemName.Equals(other.TemplateItemName));
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;

                if(Visible != null)
                    hashCode = hashCode * 59 + Visible.GetHashCode();

                if(Type != null)
                    hashCode = hashCode * 59 + Type.GetHashCode();

                if(Layer != null)
                    hashCode = hashCode * 59 + Layer.GetHashCode();

                if(XRef != null)
                    hashCode = hashCode * 59 + XRef.GetHashCode();

                if(XSizeMode != null)
                    hashCode = hashCode * 59 + XSizeMode.GetHashCode();

                if(XAnchor != null)
                    hashCode = hashCode * 59 + XAnchor.GetHashCode();

                if(X0 != null)
                    hashCode = hashCode * 59 + X0.GetHashCode();

                if(X1 != null)
                    hashCode = hashCode * 59 + X1.GetHashCode();

                if(YRef != null)
                    hashCode = hashCode * 59 + YRef.GetHashCode();

                if(YSizeMode != null)
                    hashCode = hashCode * 59 + YSizeMode.GetHashCode();

                if(YAnchor != null)
                    hashCode = hashCode * 59 + YAnchor.GetHashCode();

                if(Y0 != null)
                    hashCode = hashCode * 59 + Y0.GetHashCode();

                if(Y1 != null)
                    hashCode = hashCode * 59 + Y1.GetHashCode();

                if(Path != null)
                    hashCode = hashCode * 59 + Path.GetHashCode();

                if(Opacity != null)
                    hashCode = hashCode * 59 + Opacity.GetHashCode();

                if(Line != null)
                    hashCode = hashCode * 59 + Line.GetHashCode();

                if(FillColor != null)
                    hashCode = hashCode * 59 + FillColor.GetHashCode();

                if(FillRule != null)
                    hashCode = hashCode * 59 + FillRule.GetHashCode();

                if(Editable != null)
                    hashCode = hashCode * 59 + Editable.GetHashCode();

                if(Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();

                if(TemplateItemName != null)
                    hashCode = hashCode * 59 + TemplateItemName.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Shape and the right Shape.
        /// </summary>
        /// <param name="left">Left Shape.</param>
        /// <param name="right">Right Shape.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(Shape left,
                                       Shape right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Shape and the right Shape.
        /// </summary>
        /// <param name="left">Left Shape.</param>
        /// <param name="right">Right Shape.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(Shape left,
                                       Shape right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Shape</returns>
        public Shape DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<Shape>(ms).Result;
        }
    }
}
