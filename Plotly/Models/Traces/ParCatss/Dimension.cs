using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Traces.ParCatss.Dimensions;

namespace Plotly.Models.Traces.ParCatss
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
        ///     Specifies the ordering logic for the categories in the dimension. By default,
        ///     plotly uses <c>trace</c>, which specifies the order that is present in the
        ///     data supplied. Set <c>categoryorder</c> to &#39;category ascending&#39;
        ///     or &#39;category descending&#39; if order should be determined by the alphanumerical
        ///     order of the category names. Set <c>categoryorder</c> to <c>array</c> to
        ///     derive the ordering from the attribute <c>categoryarray</c>. If a category
        ///     is not found in the <c>categoryarray</c> array, the sorting behavior for
        ///     that attribute will be identical to the <c>trace</c> mode. The unspecified
        ///     categories will follow the categories in <c>categoryarray</c>.
        /// </summary>
        [JsonPropertyName(@"categoryorder")]
        public CategoryOrderEnum? CategoryOrder { get; set; }

        /// <summary>
        ///     Sets the order in which categories in this dimension appear. Only has an
        ///     effect if <c>categoryorder</c> is set to <c>array</c>. Used with <c>categoryorder</c>.
        /// </summary>
        [JsonPropertyName(@"categoryarray")]
        public List<object> CategoryArray { get; set; }

        /// <summary>
        ///     Sets alternative tick labels for the categories in this dimension. Only
        ///     has an effect if <c>categoryorder</c> is set to <c>array</c>. Should be
        ///     an array the same length as <c>categoryarray</c> Used with <c>categoryorder</c>.
        /// </summary>
        [JsonPropertyName(@"ticktext")]
        public List<object> TickText { get; set; }

        /// <summary>
        ///     Dimension values. <c>values[n]</c> represents the category value of the
        ///     <c>n</c>th point in the dataset, therefore the <c>values</c> vector for
        ///     all dimensions must be the same (longer vectors will be truncated).
        /// </summary>
        [JsonPropertyName(@"values")]
        public List<object> Values { get; set; }

        /// <summary>
        ///     The display index of dimension, from left to right, zero indexed, defaults
        ///     to dimension index.
        /// </summary>
        [JsonPropertyName(@"displayindex")]
        public int? DisplayIndex { get; set; }

        /// <summary>
        ///     Shows the dimension when set to <c>true</c> (the default). Hides the dimension
        ///     for <c>false</c>.
        /// </summary>
        [JsonPropertyName(@"visible")]
        public bool? Visible { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  categoryarray .
        /// </summary>
        [JsonPropertyName(@"categoryarraysrc")]
        public string CategoryArraySrc { get; set; }

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

            return (Label         == other.Label         && Label         != null && other.Label         != null && Label.Equals(other.Label))                                   &&
                   (CategoryOrder == other.CategoryOrder && CategoryOrder != null && other.CategoryOrder != null && CategoryOrder.Equals(other.CategoryOrder))                   &&
                   (Equals(CategoryArray, other.CategoryArray) || CategoryArray != null && other.CategoryArray != null && CategoryArray.SequenceEqual(other.CategoryArray))      &&
                   (Equals(TickText,      other.TickText)      || TickText      != null && other.TickText      != null && TickText.SequenceEqual(other.TickText))                &&
                   (Equals(Values,        other.Values)        || Values        != null && other.Values        != null && Values.SequenceEqual(other.Values))                    &&
                   (DisplayIndex     == other.DisplayIndex     && DisplayIndex     != null && other.DisplayIndex     != null && DisplayIndex.Equals(other.DisplayIndex))         &&
                   (Visible          == other.Visible          && Visible          != null && other.Visible          != null && Visible.Equals(other.Visible))                   &&
                   (CategoryArraySrc == other.CategoryArraySrc && CategoryArraySrc != null && other.CategoryArraySrc != null && CategoryArraySrc.Equals(other.CategoryArraySrc)) &&
                   (TickTextSrc      == other.TickTextSrc      && TickTextSrc      != null && other.TickTextSrc      != null && TickTextSrc.Equals(other.TickTextSrc))           &&
                   (ValuesSrc        == other.ValuesSrc        && ValuesSrc        != null && other.ValuesSrc        != null && ValuesSrc.Equals(other.ValuesSrc));
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;

                if(Label != null)
                    hashCode = hashCode * 59 + Label.GetHashCode();

                if(CategoryOrder != null)
                    hashCode = hashCode * 59 + CategoryOrder.GetHashCode();

                if(CategoryArray != null)
                    hashCode = hashCode * 59 + CategoryArray.GetHashCode();

                if(TickText != null)
                    hashCode = hashCode * 59 + TickText.GetHashCode();

                if(Values != null)
                    hashCode = hashCode * 59 + Values.GetHashCode();

                if(DisplayIndex != null)
                    hashCode = hashCode * 59 + DisplayIndex.GetHashCode();

                if(Visible != null)
                    hashCode = hashCode * 59 + Visible.GetHashCode();

                if(CategoryArraySrc != null)
                    hashCode = hashCode * 59 + CategoryArraySrc.GetHashCode();

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
