using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Layouts.UpdateMenus.Buttons;

namespace Plotly.Models.Layouts.UpdateMenus
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
        ///     Sets the Plotly method to be called on click. If the <c>skip</c> method
        ///     is used, the API updatemenu will function as normal but will perform no
        ///     API calls and will not bind automatically to state updates. This may be
        ///     used to create a component interface and attach to updatemenu events manually
        ///     via JavaScript.
        /// </summary>
        [JsonPropertyName(@"method")]
        public MethodEnum? Method { get; set; }

        /// <summary>
        ///     Sets the arguments values to be passed to the Plotly method set in <c>method</c>
        ///     on click.
        /// </summary>
        [JsonPropertyName(@"args")]
        public List<object>? Args { get; set; }

        /// <summary>
        ///     Sets a 2nd set of <c>args</c>, these arguments values are passed to the
        ///     Plotly method set in <c>method</c> when clicking this button while in the
        ///     active state. Use this to create toggle buttons.
        /// </summary>
        [JsonPropertyName(@"args2")]
        public List<object>? Args2 { get; set; }

        /// <summary>
        ///     Sets the text label to appear on the button.
        /// </summary>
        [JsonPropertyName(@"label")]
        public string? Label { get; set; }

        /// <summary>
        ///     When true, the API method is executed. When false, all other behaviors are
        ///     the same and command execution is skipped. This may be useful when hooking
        ///     into, for example, the <c>plotly_buttonclicked</c> method and executing
        ///     the API command manually without losing the benefit of the updatemenu automatically
        ///     binding to the state of the plot through the specification of <c>method</c>
        ///     and <c>args</c>.
        /// </summary>
        [JsonPropertyName(@"execute")]
        public bool? Execute { get; set; }

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

            return (Visible == other.Visible && Visible != null && other.Visible != null && Visible.Equals(other.Visible))                                     &&
                   (Method  == other.Method  && Method  != null && other.Method  != null && Method.Equals(other.Method))                                       &&
                   (Equals(Args,  other.Args)  || Args  != null && other.Args  != null && Args.SequenceEqual(other.Args))                                      &&
                   (Equals(Args2, other.Args2) || Args2 != null && other.Args2 != null && Args2.SequenceEqual(other.Args2))                                    &&
                   (Label            == other.Label            && Label            != null && other.Label            != null && Label.Equals(other.Label))     &&
                   (Execute          == other.Execute          && Execute          != null && other.Execute          != null && Execute.Equals(other.Execute)) &&
                   (Name             == other.Name             && Name             != null && other.Name             != null && Name.Equals(other.Name))       &&
                   (TemplateItemName == other.TemplateItemName && TemplateItemName != null && other.TemplateItemName != null && TemplateItemName.Equals(other.TemplateItemName));
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;

                if(Visible != null)
                    hashCode = hashCode * 59 + Visible.GetHashCode();

                if(Method != null)
                    hashCode = hashCode * 59 + Method.GetHashCode();

                if(Args != null)
                    hashCode = hashCode * 59 + Args.GetHashCode();

                if(Args2 != null)
                    hashCode = hashCode * 59 + Args2.GetHashCode();

                if(Label != null)
                    hashCode = hashCode * 59 + Label.GetHashCode();

                if(Execute != null)
                    hashCode = hashCode * 59 + Execute.GetHashCode();

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
