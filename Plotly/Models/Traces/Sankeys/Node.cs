using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Traces.Sankeys.Nodes;

namespace Plotly.Models.Traces.Sankeys
{
    /// <summary>
    ///     The Node class.
    /// </summary>
    [JsonConverter(typeof(PlotlyConverter))]
    [Serializable]
    public class Node : IEquatable<Node>
    {
        /// <summary>
        ///     The shown name of the node.
        /// </summary>
        [JsonPropertyName(@"label")]
        public List<object>? Label { get; set; }

        /// <summary>
        ///     Groups of nodes. Each group is defined by an array with the indices of the
        ///     nodes it contains. Multiple groups can be specified.
        /// </summary>
        [JsonPropertyName(@"groups")]
        public List<object>? Groups { get; set; }

        /// <summary>
        ///     The normalized horizontal position of the node.
        /// </summary>
        [JsonPropertyName(@"x")]
        public List<object>? X { get; set; }

        /// <summary>
        ///     The normalized vertical position of the node.
        /// </summary>
        [JsonPropertyName(@"y")]
        public List<object>? Y { get; set; }

        /// <summary>
        ///     Sets the <c>node</c> color. It can be a single value, or an array for specifying
        ///     color for each <c>node</c>. If <c>node.color</c> is omitted, then the default
        ///     <c>Plotly</c> color palette will be cycled through to have a variety of
        ///     colors. These defaults are not fully opaque, to allow some visibility of
        ///     what is beneath the node.
        /// </summary>
        [JsonPropertyName(@"color")]
        public object? Color { get; set; }

        /// <summary>
        ///     Sets the <c>node</c> color. It can be a single value, or an array for specifying
        ///     color for each <c>node</c>. If <c>node.color</c> is omitted, then the default
        ///     <c>Plotly</c> color palette will be cycled through to have a variety of
        ///     colors. These defaults are not fully opaque, to allow some visibility of
        ///     what is beneath the node.
        /// </summary>
        [JsonPropertyName(@"color")]
        [Array]
        public List<object>? ColorArray { get; set; }

        /// <summary>
        ///     Assigns extra data to each node.
        /// </summary>
        [JsonPropertyName(@"customdata")]
        public List<object>? CustomData { get; set; }

        /// <summary>
        ///     Gets or sets the Line.
        /// </summary>
        [JsonPropertyName(@"line")]
        public Line? Line { get; set; }

        /// <summary>
        ///     Sets the padding (in px) between the <c>nodes</c>.
        /// </summary>
        [JsonPropertyName(@"pad")]
        public JsNumber? Pad { get; set; }

        /// <summary>
        ///     Sets the thickness (in px) of the <c>nodes</c>.
        /// </summary>
        [JsonPropertyName(@"thickness")]
        public JsNumber? Thickness { get; set; }

        /// <summary>
        ///     Determines which trace information appear when hovering nodes. If <c>none</c>
        ///     or <c>skip</c> are set, no information is displayed upon hovering. But,
        ///     if <c>none</c> is set, click and hover events are still fired.
        /// </summary>
        [JsonPropertyName(@"hoverinfo")]
        public HoverInfoEnum? HoverInfo { get; set; }

        /// <summary>
        ///     Gets or sets the HoverLabel.
        /// </summary>
        [JsonPropertyName(@"hoverlabel")]
        public Nodes.HoverLabel? HoverLabel { get; set; }

        /// <summary>
        ///     Template string used for rendering the information that appear on hover
        ///     box. Note that this will override <c>hoverinfo</c>. Variables are inserted
        ///     using %{variable}, for example &quot;y: %{y}&quot;. Numbers are formatted
        ///     using d3-format&#39;s syntax %{variable:d3-format}, for example &quot;Price:
        ///     %{y:$.2f}&quot;. https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        ///     for details on the formatting syntax. Dates are formatted using d3-time-format&#39;s
        ///     syntax %{variable|d3-time-format}, for example &quot;Day: %{2019-01-01|%A}&quot;.
        ///     https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format
        ///     for details on the date formatting syntax. The variables available in <c>hovertemplate</c>
        ///     are the ones emitted as event data described at this link https://plotly.com/javascript/plotlyjs-events/#event-data.
        ///     Additionally, every attributes that can be specified per-point (the ones
        ///     that are &#39;arrayOk: true&#39;) are available. variables <c>value</c>
        ///     and <c>label</c>. Anything contained in tag <c>&lt;extra&gt;</c> is displayed
        ///     in the secondary box, for example <c>&lt;extra&gt;{fullData.name}&lt;/extra&gt;</c>.
        ///     To hide the secondary box completely, use an empty tag <c>&lt;extra&gt;&lt;/extra&gt;</c>.
        /// </summary>
        [JsonPropertyName(@"hovertemplate")]
        public string? HoverTemplate { get; set; }

        /// <summary>
        ///     Template string used for rendering the information that appear on hover
        ///     box. Note that this will override <c>hoverinfo</c>. Variables are inserted
        ///     using %{variable}, for example &quot;y: %{y}&quot;. Numbers are formatted
        ///     using d3-format&#39;s syntax %{variable:d3-format}, for example &quot;Price:
        ///     %{y:$.2f}&quot;. https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        ///     for details on the formatting syntax. Dates are formatted using d3-time-format&#39;s
        ///     syntax %{variable|d3-time-format}, for example &quot;Day: %{2019-01-01|%A}&quot;.
        ///     https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format
        ///     for details on the date formatting syntax. The variables available in <c>hovertemplate</c>
        ///     are the ones emitted as event data described at this link https://plotly.com/javascript/plotlyjs-events/#event-data.
        ///     Additionally, every attributes that can be specified per-point (the ones
        ///     that are &#39;arrayOk: true&#39;) are available. variables <c>value</c>
        ///     and <c>label</c>. Anything contained in tag <c>&lt;extra&gt;</c> is displayed
        ///     in the secondary box, for example <c>&lt;extra&gt;{fullData.name}&lt;/extra&gt;</c>.
        ///     To hide the secondary box completely, use an empty tag <c>&lt;extra&gt;&lt;/extra&gt;</c>.
        /// </summary>
        [JsonPropertyName(@"hovertemplate")]
        [Array]
        public List<string>? HoverTemplateArray { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  label .
        /// </summary>
        [JsonPropertyName(@"labelsrc")]
        public string? LabelSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  x .
        /// </summary>
        [JsonPropertyName(@"xsrc")]
        public string? XSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  y .
        /// </summary>
        [JsonPropertyName(@"ysrc")]
        public string? YSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  color .
        /// </summary>
        [JsonPropertyName(@"colorsrc")]
        public string? ColorSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  customdata .
        /// </summary>
        [JsonPropertyName(@"customdatasrc")]
        public string? CustomDataSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  hovertemplate .
        /// </summary>
        [JsonPropertyName(@"hovertemplatesrc")]
        public string? HoverTemplateSrc { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is Node other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] Node other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (Equals(Label,  other.Label)  || Label  != null && other.Label  != null && Label.SequenceEqual(other.Label))                                &&
                   (Equals(Groups, other.Groups) || Groups != null && other.Groups != null && Groups.SequenceEqual(other.Groups))                              &&
                   (Equals(X,      other.X)      || X      != null && other.X      != null && X.SequenceEqual(other.X))                                        &&
                   (Equals(Y,      other.Y)      || Y      != null && other.Y      != null && Y.SequenceEqual(other.Y))                                        &&
                   (Color == other.Color && Color != null && other.Color != null && Color.Equals(other.Color))                                                 &&
                   (Equals(ColorArray, other.ColorArray) || ColorArray != null && other.ColorArray != null && ColorArray.SequenceEqual(other.ColorArray))      &&
                   (Equals(CustomData, other.CustomData) || CustomData != null && other.CustomData != null && CustomData.SequenceEqual(other.CustomData))      &&
                   (Line          == other.Line          && Line          != null && other.Line          != null && Line.Equals(other.Line))                   &&
                   (Pad           == other.Pad           && Pad           != null && other.Pad           != null && Pad.Equals(other.Pad))                     &&
                   (Thickness     == other.Thickness     && Thickness     != null && other.Thickness     != null && Thickness.Equals(other.Thickness))         &&
                   (HoverInfo     == other.HoverInfo     && HoverInfo     != null && other.HoverInfo     != null && HoverInfo.Equals(other.HoverInfo))         &&
                   (HoverLabel    == other.HoverLabel    && HoverLabel    != null && other.HoverLabel    != null && HoverLabel.Equals(other.HoverLabel))       &&
                   (HoverTemplate == other.HoverTemplate && HoverTemplate != null && other.HoverTemplate != null && HoverTemplate.Equals(other.HoverTemplate)) &&
                   (Equals(HoverTemplateArray, other.HoverTemplateArray) ||
                    HoverTemplateArray != null && other.HoverTemplateArray != null && HoverTemplateArray.SequenceEqual(other.HoverTemplateArray))                          &&
                   (LabelSrc         == other.LabelSrc         && LabelSrc         != null && other.LabelSrc         != null && LabelSrc.Equals(other.LabelSrc))           &&
                   (XSrc             == other.XSrc             && XSrc             != null && other.XSrc             != null && XSrc.Equals(other.XSrc))                   &&
                   (YSrc             == other.YSrc             && YSrc             != null && other.YSrc             != null && YSrc.Equals(other.YSrc))                   &&
                   (ColorSrc         == other.ColorSrc         && ColorSrc         != null && other.ColorSrc         != null && ColorSrc.Equals(other.ColorSrc))           &&
                   (CustomDataSrc    == other.CustomDataSrc    && CustomDataSrc    != null && other.CustomDataSrc    != null && CustomDataSrc.Equals(other.CustomDataSrc)) &&
                   (HoverTemplateSrc == other.HoverTemplateSrc && HoverTemplateSrc != null && other.HoverTemplateSrc != null && HoverTemplateSrc.Equals(other.HoverTemplateSrc));
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;

                if(Label != null)
                    hashCode = hashCode * 59 + Label.GetHashCode();

                if(Groups != null)
                    hashCode = hashCode * 59 + Groups.GetHashCode();

                if(X != null)
                    hashCode = hashCode * 59 + X.GetHashCode();

                if(Y != null)
                    hashCode = hashCode * 59 + Y.GetHashCode();

                if(Color != null)
                    hashCode = hashCode * 59 + Color.GetHashCode();

                if(ColorArray != null)
                    hashCode = hashCode * 59 + ColorArray.GetHashCode();

                if(CustomData != null)
                    hashCode = hashCode * 59 + CustomData.GetHashCode();

                if(Line != null)
                    hashCode = hashCode * 59 + Line.GetHashCode();

                if(Pad != null)
                    hashCode = hashCode * 59 + Pad.GetHashCode();

                if(Thickness != null)
                    hashCode = hashCode * 59 + Thickness.GetHashCode();

                if(HoverInfo != null)
                    hashCode = hashCode * 59 + HoverInfo.GetHashCode();

                if(HoverLabel != null)
                    hashCode = hashCode * 59 + HoverLabel.GetHashCode();

                if(HoverTemplate != null)
                    hashCode = hashCode * 59 + HoverTemplate.GetHashCode();

                if(HoverTemplateArray != null)
                    hashCode = hashCode * 59 + HoverTemplateArray.GetHashCode();

                if(LabelSrc != null)
                    hashCode = hashCode * 59 + LabelSrc.GetHashCode();

                if(XSrc != null)
                    hashCode = hashCode * 59 + XSrc.GetHashCode();

                if(YSrc != null)
                    hashCode = hashCode * 59 + YSrc.GetHashCode();

                if(ColorSrc != null)
                    hashCode = hashCode * 59 + ColorSrc.GetHashCode();

                if(CustomDataSrc != null)
                    hashCode = hashCode * 59 + CustomDataSrc.GetHashCode();

                if(HoverTemplateSrc != null)
                    hashCode = hashCode * 59 + HoverTemplateSrc.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Node and the right Node.
        /// </summary>
        /// <param name="left">Left Node.</param>
        /// <param name="right">Right Node.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(Node left,
                                       Node right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Node and the right Node.
        /// </summary>
        /// <param name="left">Left Node.</param>
        /// <param name="right">Right Node.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(Node left,
                                       Node right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Node</returns>
        public Node DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<Node>(ms).Result;
        }
    }
}
