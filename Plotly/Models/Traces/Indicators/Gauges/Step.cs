using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Traces.Indicators.Gauges.Steps;

namespace Plotly.Models.Traces.Indicators.Gauges
{
    /// <summary>
    ///     The Step class.
    /// </summary>
    [Serializable]
    public class Step : IEquatable<Step>
    {
        /// <summary>
        ///     Sets the background color of the arc.
        /// </summary>
        [JsonPropertyName(@"color")]
        public object? Color { get; set; }

        /// <summary>
        ///     Gets or sets the Line.
        /// </summary>
        [JsonPropertyName(@"line")]
        public Line? Line { get; set; }

        /// <summary>
        ///     Sets the thickness of the bar as a fraction of the total thickness of the
        ///     gauge.
        /// </summary>
        [JsonPropertyName(@"thickness")]
        public JsNumber? Thickness { get; set; }

        /// <summary>
        ///     Sets the range of this axis.
        /// </summary>
        [JsonPropertyName(@"range")]
        public List<object>? Range { get; set; }

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
            if(!(obj is Step other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] Step other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (Color     == other.Color     && Color     != null && other.Color     != null && Color.Equals(other.Color))                           &&
                   (Line      == other.Line      && Line      != null && other.Line      != null && Line.Equals(other.Line))                             &&
                   (Thickness == other.Thickness && Thickness != null && other.Thickness != null && Thickness.Equals(other.Thickness))                   &&
                   (Equals(Range, other.Range) || Range != null && other.Range != null && Range.SequenceEqual(other.Range))                              &&
                   (Name             == other.Name             && Name             != null && other.Name             != null && Name.Equals(other.Name)) &&
                   (TemplateItemName == other.TemplateItemName && TemplateItemName != null && other.TemplateItemName != null && TemplateItemName.Equals(other.TemplateItemName));
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;

                if(Color != null)
                    hashCode = hashCode * 59 + Color.GetHashCode();

                if(Line != null)
                    hashCode = hashCode * 59 + Line.GetHashCode();

                if(Thickness != null)
                    hashCode = hashCode * 59 + Thickness.GetHashCode();

                if(Range != null)
                    hashCode = hashCode * 59 + Range.GetHashCode();

                if(Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();

                if(TemplateItemName != null)
                    hashCode = hashCode * 59 + TemplateItemName.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Step and the right Step.
        /// </summary>
        /// <param name="left">Left Step.</param>
        /// <param name="right">Right Step.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(Step left,
                                       Step right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Step and the right Step.
        /// </summary>
        /// <param name="left">Left Step.</param>
        /// <param name="right">Right Step.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(Step left,
                                       Step right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Step</returns>
        public Step DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<Step>(ms).Result;
        }
    }
}
