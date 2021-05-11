using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Traces.Sankeys.Links;

namespace Plotly.Models.Traces.Sankeys
{
    /// <summary>
    ///     The Link class.
    /// </summary>
    [JsonConverter(typeof(PlotlyConverter))]
    [Serializable]
    public class Link : IEquatable<Link>
    {
        /// <summary>
        ///     The shown name of the link.
        /// </summary>
        [JsonPropertyName(@"label")]
        public List<object> Label { get; set; }

        /// <summary>
        ///     Sets the <c>link</c> color. It can be a single value, or an array for specifying
        ///     color for each <c>link</c>. If <c>link.color</c> is omitted, then by default,
        ///     a translucent grey link will be used.
        /// </summary>
        [JsonPropertyName(@"color")]
        public object Color { get; set; }

        /// <summary>
        ///     Sets the <c>link</c> color. It can be a single value, or an array for specifying
        ///     color for each <c>link</c>. If <c>link.color</c> is omitted, then by default,
        ///     a translucent grey link will be used.
        /// </summary>
        [JsonPropertyName(@"color")]
        [Array]
        public List<object> ColorArray { get; set; }

        /// <summary>
        ///     Assigns extra data to each link.
        /// </summary>
        [JsonPropertyName(@"customdata")]
        public List<object> CustomData { get; set; }

        /// <summary>
        ///     Gets or sets the Line.
        /// </summary>
        [JsonPropertyName(@"line")]
        public Line Line { get; set; }

        /// <summary>
        ///     An integer number &#39;[0..nodes.length - 1]&#39; that represents the source
        ///     node.
        /// </summary>
        [JsonPropertyName(@"source")]
        public List<object> Source { get; set; }

        /// <summary>
        ///     An integer number &#39;[0..nodes.length - 1]&#39; that represents the target
        ///     node.
        /// </summary>
        [JsonPropertyName(@"target")]
        public List<object> Target { get; set; }

        /// <summary>
        ///     A numeric value representing the flow volume value.
        /// </summary>
        [JsonPropertyName(@"value")]
        public List<object> Value { get; set; }

        /// <summary>
        ///     Determines which trace information appear when hovering links. If <c>none</c>
        ///     or <c>skip</c> are set, no information is displayed upon hovering. But,
        ///     if <c>none</c> is set, click and hover events are still fired.
        /// </summary>
        [JsonPropertyName(@"hoverinfo")]
        public HoverInfoEnum? HoverInfo { get; set; }

        /// <summary>
        ///     Gets or sets the HoverLabel.
        /// </summary>
        [JsonPropertyName(@"hoverlabel")]
        public Links.HoverLabel HoverLabel { get; set; }

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
        public string HoverTemplate { get; set; }

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
        public List<string> HoverTemplateArray { get; set; }

        /// <summary>
        ///     Gets or sets the ColorScales.
        /// </summary>
        [JsonPropertyName(@"colorscales")]
        public List<ConcentrationScales> ColorScales { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  label .
        /// </summary>
        [JsonPropertyName(@"labelsrc")]
        public string LabelSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  color .
        /// </summary>
        [JsonPropertyName(@"colorsrc")]
        public string ColorSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  customdata .
        /// </summary>
        [JsonPropertyName(@"customdatasrc")]
        public string CustomDataSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  source .
        /// </summary>
        [JsonPropertyName(@"sourcesrc")]
        public string SourceSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  target .
        /// </summary>
        [JsonPropertyName(@"targetsrc")]
        public string TargetSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  value .
        /// </summary>
        [JsonPropertyName(@"valuesrc")]
        public string ValueSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  hovertemplate .
        /// </summary>
        [JsonPropertyName(@"hovertemplatesrc")]
        public string HoverTemplateSrc { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is Link other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] Link other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (Equals(Label, other.Label) || Label != null && other.Label != null && Label.SequenceEqual(other.Label))                                    &&
                   (Color == other.Color && Color != null && other.Color != null && Color.Equals(other.Color))                                                 &&
                   (Equals(ColorArray, other.ColorArray) || ColorArray != null && other.ColorArray != null && ColorArray.SequenceEqual(other.ColorArray))      &&
                   (Equals(CustomData, other.CustomData) || CustomData != null && other.CustomData != null && CustomData.SequenceEqual(other.CustomData))      &&
                   (Line == other.Line && Line != null && other.Line != null && Line.Equals(other.Line))                                                       &&
                   (Equals(Source, other.Source) || Source != null && other.Source != null && Source.SequenceEqual(other.Source))                              &&
                   (Equals(Target, other.Target) || Target != null && other.Target != null && Target.SequenceEqual(other.Target))                              &&
                   (Equals(Value,  other.Value)  || Value  != null && other.Value  != null && Value.SequenceEqual(other.Value))                                &&
                   (HoverInfo     == other.HoverInfo     && HoverInfo     != null && other.HoverInfo     != null && HoverInfo.Equals(other.HoverInfo))         &&
                   (HoverLabel    == other.HoverLabel    && HoverLabel    != null && other.HoverLabel    != null && HoverLabel.Equals(other.HoverLabel))       &&
                   (HoverTemplate == other.HoverTemplate && HoverTemplate != null && other.HoverTemplate != null && HoverTemplate.Equals(other.HoverTemplate)) &&
                   (Equals(HoverTemplateArray, other.HoverTemplateArray) ||
                    HoverTemplateArray != null && other.HoverTemplateArray != null && HoverTemplateArray.SequenceEqual(other.HoverTemplateArray))                          &&
                   (Equals(ColorScales, other.ColorScales) || ColorScales != null && other.ColorScales != null && ColorScales.SequenceEqual(other.ColorScales))            &&
                   (LabelSrc         == other.LabelSrc         && LabelSrc         != null && other.LabelSrc         != null && LabelSrc.Equals(other.LabelSrc))           &&
                   (ColorSrc         == other.ColorSrc         && ColorSrc         != null && other.ColorSrc         != null && ColorSrc.Equals(other.ColorSrc))           &&
                   (CustomDataSrc    == other.CustomDataSrc    && CustomDataSrc    != null && other.CustomDataSrc    != null && CustomDataSrc.Equals(other.CustomDataSrc)) &&
                   (SourceSrc        == other.SourceSrc        && SourceSrc        != null && other.SourceSrc        != null && SourceSrc.Equals(other.SourceSrc))         &&
                   (TargetSrc        == other.TargetSrc        && TargetSrc        != null && other.TargetSrc        != null && TargetSrc.Equals(other.TargetSrc))         &&
                   (ValueSrc         == other.ValueSrc         && ValueSrc         != null && other.ValueSrc         != null && ValueSrc.Equals(other.ValueSrc))           &&
                   (HoverTemplateSrc == other.HoverTemplateSrc && HoverTemplateSrc != null && other.HoverTemplateSrc != null && HoverTemplateSrc.Equals(other.HoverTemplateSrc));
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;

                if(Label != null)
                    hashCode = hashCode * 59 + Label.GetHashCode();

                if(Color != null)
                    hashCode = hashCode * 59 + Color.GetHashCode();

                if(ColorArray != null)
                    hashCode = hashCode * 59 + ColorArray.GetHashCode();

                if(CustomData != null)
                    hashCode = hashCode * 59 + CustomData.GetHashCode();

                if(Line != null)
                    hashCode = hashCode * 59 + Line.GetHashCode();

                if(Source != null)
                    hashCode = hashCode * 59 + Source.GetHashCode();

                if(Target != null)
                    hashCode = hashCode * 59 + Target.GetHashCode();

                if(Value != null)
                    hashCode = hashCode * 59 + Value.GetHashCode();

                if(HoverInfo != null)
                    hashCode = hashCode * 59 + HoverInfo.GetHashCode();

                if(HoverLabel != null)
                    hashCode = hashCode * 59 + HoverLabel.GetHashCode();

                if(HoverTemplate != null)
                    hashCode = hashCode * 59 + HoverTemplate.GetHashCode();

                if(HoverTemplateArray != null)
                    hashCode = hashCode * 59 + HoverTemplateArray.GetHashCode();

                if(ColorScales != null)
                    hashCode = hashCode * 59 + ColorScales.GetHashCode();

                if(LabelSrc != null)
                    hashCode = hashCode * 59 + LabelSrc.GetHashCode();

                if(ColorSrc != null)
                    hashCode = hashCode * 59 + ColorSrc.GetHashCode();

                if(CustomDataSrc != null)
                    hashCode = hashCode * 59 + CustomDataSrc.GetHashCode();

                if(SourceSrc != null)
                    hashCode = hashCode * 59 + SourceSrc.GetHashCode();

                if(TargetSrc != null)
                    hashCode = hashCode * 59 + TargetSrc.GetHashCode();

                if(ValueSrc != null)
                    hashCode = hashCode * 59 + ValueSrc.GetHashCode();

                if(HoverTemplateSrc != null)
                    hashCode = hashCode * 59 + HoverTemplateSrc.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Link and the right Link.
        /// </summary>
        /// <param name="left">Left Link.</param>
        /// <param name="right">Right Link.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(Link left,
                                       Link right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Link and the right Link.
        /// </summary>
        /// <param name="left">Left Link.</param>
        /// <param name="right">Right Link.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(Link left,
                                       Link right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Link</returns>
        public Link DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<Link>(ms).Result;
        }
    }
}
