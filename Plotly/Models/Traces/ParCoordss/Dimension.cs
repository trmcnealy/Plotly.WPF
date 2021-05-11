using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Plotly.Models.Traces.ParCoordss
{
    /// <summary>
    ///     The Dimension class.
    /// </summary>
    [Serializable]
    public class Dimension : IEquatable<Dimension>
    {
        /// <summary>
        ///     The shown name of the dimension.
        /// </summary>
        [JsonPropertyName(@"label")]
        public string Label { get; set; }

        /// <summary>
        ///     Sets the values at which ticks on this axis appear.
        /// </summary>
        [JsonPropertyName(@"tickvals")]
        public List<object> TickVals { get; set; }

        /// <summary>
        ///     Sets the text displayed at the ticks position via <c>tickvals</c>.
        /// </summary>
        [JsonPropertyName(@"ticktext")]
        public List<object> TickText { get; set; }

        /// <summary>
        ///     Sets the tick label formatting rule using d3 formatting mini-languages which
        ///     are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        ///     And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format
        ///     We add one item to d3&#39;s date formatter: <c>%{n}f</c> for fractional
        ///     seconds with n digits. For example, &#39;2016-10-13 09:15:23.456&#39; with
        ///     tickformat <c>%H~%M~%S.%2f</c> would display <c>09~15~23.46</c>
        /// </summary>
        [JsonPropertyName(@"tickformat")]
        public string TickFormat { get; set; }

        /// <summary>
        ///     Shows the dimension when set to <c>true</c> (the default). Hides the dimension
        ///     for <c>false</c>.
        /// </summary>
        [JsonPropertyName(@"visible")]
        public bool? Visible { get; set; }

        /// <summary>
        ///     The domain range that represents the full, shown axis extent. Defaults to
        ///     the <c>values</c> extent. Must be an array of &#39;[fromValue, toValue]&#39;
        ///     with finite numbers as elements.
        /// </summary>
        [JsonPropertyName(@"range")]
        public List<object> Range { get; set; }

        /// <summary>
        ///     The domain range to which the filter on the dimension is constrained. Must
        ///     be an array of &#39;[fromValue, toValue]&#39; with &#39;fromValue &lt;=
        ///     toValue&#39;, or if <c>multiselect</c> is not disabled, you may give an
        ///     array of arrays, where each inner array is &#39;[fromValue, toValue]&#39;.
        /// </summary>
        [JsonPropertyName(@"constraintrange")]
        public List<object> ConstraintRange { get; set; }

        /// <summary>
        ///     Do we allow multiple selection ranges or just a single range?
        /// </summary>
        [JsonPropertyName(@"multiselect")]
        public bool? MultiSelect { get; set; }

        /// <summary>
        ///     Dimension values. <c>values[n]</c> represents the value of the <c>n</c>th
        ///     point in the dataset, therefore the <c>values</c> vector for all dimensions
        ///     must be the same (longer vectors will be truncated). Each value must be
        ///     a finite number.
        /// </summary>
        [JsonPropertyName(@"values")]
        public List<object> Values { get; set; }

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

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  tickvals .
        /// </summary>
        [JsonPropertyName(@"tickvalssrc")]
        public string TickValsSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  ticktext .
        /// </summary>
        [JsonPropertyName(@"ticktextsrc")]
        public string TickTextSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  values .
        /// </summary>
        [JsonPropertyName(@"valuessrc")]
        public string ValuesSrc { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is Dimension other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] Dimension other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (Label == other.Label && Label != null && other.Label != null && Label.Equals(other.Label))                                                                          &&
                   (Equals(TickVals, other.TickVals) || TickVals != null && other.TickVals != null && TickVals.SequenceEqual(other.TickVals))                                           &&
                   (Equals(TickText, other.TickText) || TickText != null && other.TickText != null && TickText.SequenceEqual(other.TickText))                                           &&
                   (TickFormat == other.TickFormat && TickFormat != null && other.TickFormat != null && TickFormat.Equals(other.TickFormat))                                            &&
                   (Visible    == other.Visible    && Visible    != null && other.Visible    != null && Visible.Equals(other.Visible))                                                  &&
                   (Equals(Range,           other.Range)           || Range           != null && other.Range           != null && Range.SequenceEqual(other.Range))                     &&
                   (Equals(ConstraintRange, other.ConstraintRange) || ConstraintRange != null && other.ConstraintRange != null && ConstraintRange.SequenceEqual(other.ConstraintRange)) &&
                   (MultiSelect == other.MultiSelect && MultiSelect != null && other.MultiSelect != null && MultiSelect.Equals(other.MultiSelect))                                      &&
                   (Equals(Values, other.Values) || Values != null && other.Values != null && Values.SequenceEqual(other.Values))                                                       &&
                   (Name             == other.Name             && Name             != null && other.Name             != null && Name.Equals(other.Name))                                &&
                   (TemplateItemName == other.TemplateItemName && TemplateItemName != null && other.TemplateItemName != null && TemplateItemName.Equals(other.TemplateItemName))        &&
                   (TickValsSrc      == other.TickValsSrc      && TickValsSrc      != null && other.TickValsSrc      != null && TickValsSrc.Equals(other.TickValsSrc))                  &&
                   (TickTextSrc      == other.TickTextSrc      && TickTextSrc      != null && other.TickTextSrc      != null && TickTextSrc.Equals(other.TickTextSrc))                  &&
                   (ValuesSrc        == other.ValuesSrc        && ValuesSrc        != null && other.ValuesSrc        != null && ValuesSrc.Equals(other.ValuesSrc));
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;

                if(Label != null)
                    hashCode = hashCode * 59 + Label.GetHashCode();

                if(TickVals != null)
                    hashCode = hashCode * 59 + TickVals.GetHashCode();

                if(TickText != null)
                    hashCode = hashCode * 59 + TickText.GetHashCode();

                if(TickFormat != null)
                    hashCode = hashCode * 59 + TickFormat.GetHashCode();

                if(Visible != null)
                    hashCode = hashCode * 59 + Visible.GetHashCode();

                if(Range != null)
                    hashCode = hashCode * 59 + Range.GetHashCode();

                if(ConstraintRange != null)
                    hashCode = hashCode * 59 + ConstraintRange.GetHashCode();

                if(MultiSelect != null)
                    hashCode = hashCode * 59 + MultiSelect.GetHashCode();

                if(Values != null)
                    hashCode = hashCode * 59 + Values.GetHashCode();

                if(Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();

                if(TemplateItemName != null)
                    hashCode = hashCode * 59 + TemplateItemName.GetHashCode();

                if(TickValsSrc != null)
                    hashCode = hashCode * 59 + TickValsSrc.GetHashCode();

                if(TickTextSrc != null)
                    hashCode = hashCode * 59 + TickTextSrc.GetHashCode();

                if(ValuesSrc != null)
                    hashCode = hashCode * 59 + ValuesSrc.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Dimension and the right Dimension.
        /// </summary>
        /// <param name="left">Left Dimension.</param>
        /// <param name="right">Right Dimension.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(Dimension left,
                                       Dimension right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Dimension and the right Dimension.
        /// </summary>
        /// <param name="left">Left Dimension.</param>
        /// <param name="right">Right Dimension.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(Dimension left,
                                       Dimension right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Dimension</returns>
        public Dimension DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<Dimension>(ms).Result;
        }
    }
}
