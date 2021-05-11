using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Layouts.Images;

namespace Plotly.Models.Layouts
{
    /// <summary>
    ///     The Image class.
    /// </summary>
    [Serializable]
    public class Image : IEquatable<Image>
    {
        /// <summary>
        ///     Determines whether or not this image is visible.
        /// </summary>
        [JsonPropertyName(@"visible")]
        public bool? Visible { get; set; }

        /// <summary>
        ///     Specifies the URL of the image to be used. The URL must be accessible from
        ///     the domain where the plot code is run, and can be either relative or absolute.
        /// </summary>
        [JsonPropertyName(@"source")]
        public string Source { get; set; }

        /// <summary>
        ///     Specifies whether images are drawn below or above traces. When <c>xref</c>
        ///     and <c>yref</c> are both set to <c>paper</c>, image is drawn below the entire
        ///     plot area.
        /// </summary>
        [JsonPropertyName(@"layer")]
        public LayerEnum? Layer { get; set; }

        /// <summary>
        ///     Sets the image container size horizontally. The image will be sized based
        ///     on the <c>position</c> value. When <c>xref</c> is set to <c>paper</c>, units
        ///     are sized relative to the plot width.
        /// </summary>
        [JsonPropertyName(@"sizex")]
        public JsNumber? SizeX { get; set; }

        /// <summary>
        ///     Sets the image container size vertically. The image will be sized based
        ///     on the <c>position</c> value. When <c>yref</c> is set to <c>paper</c>, units
        ///     are sized relative to the plot height.
        /// </summary>
        [JsonPropertyName(@"sizey")]
        public JsNumber? SizeY { get; set; }

        /// <summary>
        ///     Specifies which dimension of the image to constrain.
        /// </summary>
        [JsonPropertyName(@"sizing")]
        public SizingEnum? Sizing { get; set; }

        /// <summary>
        ///     Sets the opacity of the image.
        /// </summary>
        [JsonPropertyName(@"opacity")]
        public JsNumber? Opacity { get; set; }

        /// <summary>
        ///     Sets the image&#39;s x position. When <c>xref</c> is set to <c>paper</c>,
        ///     units are sized relative to the plot height. See <c>xref</c> for more info
        /// </summary>
        [JsonPropertyName(@"x")]
        public object X { get; set; }

        /// <summary>
        ///     Sets the image&#39;s y position. When <c>yref</c> is set to <c>paper</c>,
        ///     units are sized relative to the plot height. See <c>yref</c> for more info
        /// </summary>
        [JsonPropertyName(@"y")]
        public object Y { get; set; }

        /// <summary>
        ///     Sets the anchor for the x position
        /// </summary>
        [JsonPropertyName(@"xanchor")]
        public XAnchorEnum? XAnchor { get; set; }

        /// <summary>
        ///     Sets the anchor for the y position.
        /// </summary>
        [JsonPropertyName(@"yanchor")]
        public YAnchorEnum? YAnchor { get; set; }

        /// <summary>
        ///     Sets the images&#39;s x coordinate axis. If set to a x axis id (e.g. <c>x</c>
        ///     or <c>x2</c>), the <c>x</c> position refers to an x data coordinate If set
        ///     to <c>paper</c>, the <c>x</c> position refers to the distance from the left
        ///     of plot in normalized coordinates where <c>0</c> (<c>1</c>) corresponds
        ///     to the left (right).
        /// </summary>
        [JsonPropertyName(@"xref")]
        public string XRef { get; set; }

        /// <summary>
        ///     Sets the images&#39;s y coordinate axis. If set to a y axis id (e.g. <c>y</c>
        ///     or <c>y2</c>), the <c>y</c> position refers to a y data coordinate. If set
        ///     to <c>paper</c>, the <c>y</c> position refers to the distance from the bottom
        ///     of the plot in normalized coordinates where <c>0</c> (<c>1</c>) corresponds
        ///     to the bottom (top).
        /// </summary>
        [JsonPropertyName(@"yref")]
        public string YRef { get; set; }

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
            if(!(obj is Image other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] Image other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (Visible          == other.Visible          && Visible          != null && other.Visible          != null && Visible.Equals(other.Visible)) &&
                   (Source           == other.Source           && Source           != null && other.Source           != null && Source.Equals(other.Source))   &&
                   (Layer            == other.Layer            && Layer            != null && other.Layer            != null && Layer.Equals(other.Layer))     &&
                   (SizeX            == other.SizeX            && SizeX            != null && other.SizeX            != null && SizeX.Equals(other.SizeX))     &&
                   (SizeY            == other.SizeY            && SizeY            != null && other.SizeY            != null && SizeY.Equals(other.SizeY))     &&
                   (Sizing           == other.Sizing           && Sizing           != null && other.Sizing           != null && Sizing.Equals(other.Sizing))   &&
                   (Opacity          == other.Opacity          && Opacity          != null && other.Opacity          != null && Opacity.Equals(other.Opacity)) &&
                   (X                == other.X                && X                != null && other.X                != null && X.Equals(other.X))             &&
                   (Y                == other.Y                && Y                != null && other.Y                != null && Y.Equals(other.Y))             &&
                   (XAnchor          == other.XAnchor          && XAnchor          != null && other.XAnchor          != null && XAnchor.Equals(other.XAnchor)) &&
                   (YAnchor          == other.YAnchor          && YAnchor          != null && other.YAnchor          != null && YAnchor.Equals(other.YAnchor)) &&
                   (XRef             == other.XRef             && XRef             != null && other.XRef             != null && XRef.Equals(other.XRef))       &&
                   (YRef             == other.YRef             && YRef             != null && other.YRef             != null && YRef.Equals(other.YRef))       &&
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

                if(Source != null)
                    hashCode = hashCode * 59 + Source.GetHashCode();

                if(Layer != null)
                    hashCode = hashCode * 59 + Layer.GetHashCode();

                if(SizeX != null)
                    hashCode = hashCode * 59 + SizeX.GetHashCode();

                if(SizeY != null)
                    hashCode = hashCode * 59 + SizeY.GetHashCode();

                if(Sizing != null)
                    hashCode = hashCode * 59 + Sizing.GetHashCode();

                if(Opacity != null)
                    hashCode = hashCode * 59 + Opacity.GetHashCode();

                if(X != null)
                    hashCode = hashCode * 59 + X.GetHashCode();

                if(Y != null)
                    hashCode = hashCode * 59 + Y.GetHashCode();

                if(XAnchor != null)
                    hashCode = hashCode * 59 + XAnchor.GetHashCode();

                if(YAnchor != null)
                    hashCode = hashCode * 59 + YAnchor.GetHashCode();

                if(XRef != null)
                    hashCode = hashCode * 59 + XRef.GetHashCode();

                if(YRef != null)
                    hashCode = hashCode * 59 + YRef.GetHashCode();

                if(Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();

                if(TemplateItemName != null)
                    hashCode = hashCode * 59 + TemplateItemName.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Image and the right Image.
        /// </summary>
        /// <param name="left">Left Image.</param>
        /// <param name="right">Right Image.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(Image left,
                                       Image right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Image and the right Image.
        /// </summary>
        /// <param name="left">Left Image.</param>
        /// <param name="right">Right Image.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(Image left,
                                       Image right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Image</returns>
        public Image DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<Image>(ms).Result;
        }
    }
}
