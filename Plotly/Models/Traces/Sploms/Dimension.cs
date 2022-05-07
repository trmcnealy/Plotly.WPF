using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Traces.Sploms.Dimensions;

namespace Plotly.Models.Traces.Sploms
{
    /// <summary>
    ///     The Dimension class.
    /// </summary>
    [Serializable]
    public class Dimension : IEquatable<Dimension>
    {
        /// <summary>
        ///     Determines whether or not this dimension is shown on the graph. Note that
        ///     even visible false dimension contribute to the default grid generate by
        ///     this splom trace.
        /// </summary>
        [JsonPropertyName(@"visible")]
        public bool? Visible { get; set; }

        /// <summary>
        ///     Sets the label corresponding to this splom dimension.
        /// </summary>
        [JsonPropertyName(@"label")]
        public string? Label { get; set; }

        /// <summary>
        ///     Sets the dimension values to be plotted.
        /// </summary>
        [JsonPropertyName(@"values")]
        public List<object>? Values { get; set; }

        /// <summary>
        ///     Gets or sets the Axis.
        /// </summary>
        [JsonPropertyName(@"axis")]
        public Axis? Axis { get; set; }

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

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  values .
        /// </summary>
        [JsonPropertyName(@"valuessrc")]
        public string? ValuesSrc { get; set; }

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

            return (Visible == other.Visible && Visible != null && other.Visible != null && Visible.Equals(other.Visible))                                                       &&
                   (Label   == other.Label   && Label   != null && other.Label   != null && Label.Equals(other.Label))                                                           &&
                   (Equals(Values, other.Values) || Values != null && other.Values != null && Values.SequenceEqual(other.Values))                                                &&
                   (Axis             == other.Axis             && Axis             != null && other.Axis             != null && Axis.Equals(other.Axis))                         &&
                   (Name             == other.Name             && Name             != null && other.Name             != null && Name.Equals(other.Name))                         &&
                   (TemplateItemName == other.TemplateItemName && TemplateItemName != null && other.TemplateItemName != null && TemplateItemName.Equals(other.TemplateItemName)) &&
                   (ValuesSrc        == other.ValuesSrc        && ValuesSrc        != null && other.ValuesSrc        != null && ValuesSrc.Equals(other.ValuesSrc));
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;

                if(Visible != null)
                    hashCode = hashCode * 59 + Visible.GetHashCode();

                if(Label != null)
                    hashCode = hashCode * 59 + Label.GetHashCode();

                if(Values != null)
                    hashCode = hashCode * 59 + Values.GetHashCode();

                if(Axis != null)
                    hashCode = hashCode * 59 + Axis.GetHashCode();

                if(Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();

                if(TemplateItemName != null)
                    hashCode = hashCode * 59 + TemplateItemName.GetHashCode();

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
