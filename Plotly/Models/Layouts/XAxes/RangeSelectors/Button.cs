using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Layouts.XAxes.RangeSelectors.Buttons;

namespace Plotly.Models.Layouts.XAxes.RangeSelectors
{
    /// <summary>
    ///     The Button class.
    /// </summary>
    [Serializable]
    public class Button : IEquatable<Button>
    {
        /// <summary>
        ///     Determines whether or not this button is visible.
        /// </summary>
        [JsonPropertyName(@"visible")]
        public bool? Visible { get; set; }

        /// <summary>
        ///     The unit of measurement that the <c>count</c> value will set the range by.
        /// </summary>
        [JsonPropertyName(@"step")]
        public StepEnum? Step { get; set; }

        /// <summary>
        ///     Sets the range update mode. If <c>backward</c>, the range update shifts
        ///     the start of range back <c>count</c> times <c>step</c> milliseconds. If
        ///     <c>todate</c>, the range update shifts the start of range back to the first
        ///     timestamp from <c>count</c> times <c>step</c> milliseconds back. For example,
        ///     with <c>step</c> set to <c>year</c> and <c>count</c> set to <c>1</c> the
        ///     range update shifts the start of the range back to January 01 of the current
        ///     year. Month and year <c>todate</c> are currently available only for the
        ///     built-in (Gregorian) calendar.
        /// </summary>
        [JsonPropertyName(@"stepmode")]
        public StepModeEnum? StepMode { get; set; }

        /// <summary>
        ///     Sets the number of steps to take to update the range. Use with <c>step</c>
        ///     to specify the update interval.
        /// </summary>
        [JsonPropertyName(@"count")]
        public JsNumber? Count { get; set; }

        /// <summary>
        ///     Sets the text label to appear on the button.
        /// </summary>
        [JsonPropertyName(@"label")]
        public string? Label { get; set; }

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
            if(!(obj is Button other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] Button other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (Visible          == other.Visible          && Visible          != null && other.Visible          != null && Visible.Equals(other.Visible))   &&
                   (Step             == other.Step             && Step             != null && other.Step             != null && Step.Equals(other.Step))         &&
                   (StepMode         == other.StepMode         && StepMode         != null && other.StepMode         != null && StepMode.Equals(other.StepMode)) &&
                   (Count            == other.Count            && Count            != null && other.Count            != null && Count.Equals(other.Count))       &&
                   (Label            == other.Label            && Label            != null && other.Label            != null && Label.Equals(other.Label))       &&
                   (Name             == other.Name             && Name             != null && other.Name             != null && Name.Equals(other.Name))         &&
                   (TemplateItemName == other.TemplateItemName && TemplateItemName != null && other.TemplateItemName != null && TemplateItemName.Equals(other.TemplateItemName));
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;

                if(Visible != null)
                    hashCode = hashCode * 59 + Visible.GetHashCode();

                if(Step != null)
                    hashCode = hashCode * 59 + Step.GetHashCode();

                if(StepMode != null)
                    hashCode = hashCode * 59 + StepMode.GetHashCode();

                if(Count != null)
                    hashCode = hashCode * 59 + Count.GetHashCode();

                if(Label != null)
                    hashCode = hashCode * 59 + Label.GetHashCode();

                if(Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();

                if(TemplateItemName != null)
                    hashCode = hashCode * 59 + TemplateItemName.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Button and the right Button.
        /// </summary>
        /// <param name="left">Left Button.</param>
        /// <param name="right">Right Button.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(Button left,
                                       Button right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Button and the right Button.
        /// </summary>
        /// <param name="left">Left Button.</param>
        /// <param name="right">Right Button.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(Button left,
                                       Button right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Button</returns>
        public Button DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<Button>(ms).Result;
        }
    }
}
