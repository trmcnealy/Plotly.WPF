using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Layouts.Scenes;

namespace Plotly.Models.Layouts
{
    /// <summary>
    ///     The Scene class.
    /// </summary>
    
    [Serializable]
    public class Scene : IEquatable<Scene>
    {
        /// <summary>
        ///     Gets or sets the BgColor.
        /// </summary>
        [JsonPropertyName(@"bgcolor")]
        public object BgColor { get; set;} 

        /// <summary>
        ///     Gets or sets the Camera.
        /// </summary>
        [JsonPropertyName(@"camera")]
        public Camera Camera { get; set;} 

        /// <summary>
        ///     Gets or sets the Domain.
        /// </summary>
        [JsonPropertyName(@"domain")]
        public Domain Domain { get; set;} 

        /// <summary>
        ///     If <c>cube</c>, this scene&#39;s axes are drawn as a cube, regardless of
        ///     the axes&#39; ranges. If <c>data</c>, this scene&#39;s axes are drawn in
        ///     proportion with the axes&#39; ranges. If <c>manual</c>, this scene&#39;s
        ///     axes are drawn in proportion with the input of <c>aspectratio</c> (the default
        ///     behavior if <c>aspectratio</c> is provided). If <c>auto</c>, this scene&#39;s
        ///     axes are drawn using the results of <c>data</c> except when one axis is
        ///     more than four times the size of the two others, where in that case the
        ///     results of <c>cube</c> are used.
        /// </summary>
        [JsonPropertyName(@"aspectmode")]
        public AspectModeEnum? AspectMode { get; set;} 

        /// <summary>
        ///     Sets this scene&#39;s axis aspectratio.
        /// </summary>
        [JsonPropertyName(@"aspectratio")]
        public AspectRatio AspectRatio { get; set;} 

        /// <summary>
        ///     Gets or sets the XAxis.
        /// </summary>
        [JsonPropertyName(@"xaxis")]
        public Scenes.XAxis XAxis { get; set;} 

        /// <summary>
        ///     Gets or sets the YAxis.
        /// </summary>
        [JsonPropertyName(@"yaxis")]
        public Scenes.YAxis YAxis { get; set;} 

        /// <summary>
        ///     Gets or sets the ZAxis.
        /// </summary>
        [JsonPropertyName(@"zaxis")]
        public ZAxis ZAxis { get; set;} 

        /// <summary>
        ///     Determines the mode of drag interactions for this scene.
        /// </summary>
        [JsonPropertyName(@"dragmode")]
        public Scenes.DragModeEnum? DragMode { get; set;} 

        /// <summary>
        ///     Determines the mode of hover interactions for this scene.
        /// </summary>
        [JsonPropertyName(@"hovermode")]
        public Scenes.HoverModeEnum? HoverMode { get; set;} 

        /// <summary>
        ///     Controls persistence of user-driven changes in camera attributes. Defaults
        ///     to <c>layout.uirevision</c>.
        /// </summary>
        [JsonPropertyName(@"uirevision")]
        public object UiRevision { get; set;} 

        /// <summary>
        ///     Gets or sets the Annotations.
        /// </summary>
        [JsonPropertyName(@"annotations")]
        public List<Scenes.Annotation> Annotations { get; set;} 

        
        public override bool Equals(object obj)
        {
            if (!(obj is Scene other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        
        public bool Equals([AllowNull] Scene other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    BgColor == other.BgColor &&
                    BgColor != null && other.BgColor != null &&
                    BgColor.Equals(other.BgColor)
                ) && 
                (
                    Camera == other.Camera &&
                    Camera != null && other.Camera != null &&
                    Camera.Equals(other.Camera)
                ) && 
                (
                    Domain == other.Domain &&
                    Domain != null && other.Domain != null &&
                    Domain.Equals(other.Domain)
                ) && 
                (
                    AspectMode == other.AspectMode &&
                    AspectMode != null && other.AspectMode != null &&
                    AspectMode.Equals(other.AspectMode)
                ) && 
                (
                    AspectRatio == other.AspectRatio &&
                    AspectRatio != null && other.AspectRatio != null &&
                    AspectRatio.Equals(other.AspectRatio)
                ) && 
                (
                    XAxis == other.XAxis &&
                    XAxis != null && other.XAxis != null &&
                    XAxis.Equals(other.XAxis)
                ) && 
                (
                    YAxis == other.YAxis &&
                    YAxis != null && other.YAxis != null &&
                    YAxis.Equals(other.YAxis)
                ) && 
                (
                    ZAxis == other.ZAxis &&
                    ZAxis != null && other.ZAxis != null &&
                    ZAxis.Equals(other.ZAxis)
                ) && 
                (
                    DragMode == other.DragMode &&
                    DragMode != null && other.DragMode != null &&
                    DragMode.Equals(other.DragMode)
                ) && 
                (
                    HoverMode == other.HoverMode &&
                    HoverMode != null && other.HoverMode != null &&
                    HoverMode.Equals(other.HoverMode)
                ) && 
                (
                    UiRevision == other.UiRevision &&
                    UiRevision != null && other.UiRevision != null &&
                    UiRevision.Equals(other.UiRevision)
                ) && 
                (
                    Equals(Annotations, other.Annotations) ||
                    Annotations != null && other.Annotations != null &&
                    Annotations.SequenceEqual(other.Annotations)
                );
        }

        
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (BgColor != null) hashCode = hashCode * 59 + BgColor.GetHashCode();
                if (Camera != null) hashCode = hashCode * 59 + Camera.GetHashCode();
                if (Domain != null) hashCode = hashCode * 59 + Domain.GetHashCode();
                if (AspectMode != null) hashCode = hashCode * 59 + AspectMode.GetHashCode();
                if (AspectRatio != null) hashCode = hashCode * 59 + AspectRatio.GetHashCode();
                if (XAxis != null) hashCode = hashCode * 59 + XAxis.GetHashCode();
                if (YAxis != null) hashCode = hashCode * 59 + YAxis.GetHashCode();
                if (ZAxis != null) hashCode = hashCode * 59 + ZAxis.GetHashCode();
                if (DragMode != null) hashCode = hashCode * 59 + DragMode.GetHashCode();
                if (HoverMode != null) hashCode = hashCode * 59 + HoverMode.GetHashCode();
                if (UiRevision != null) hashCode = hashCode * 59 + UiRevision.GetHashCode();
                if (Annotations != null) hashCode = hashCode * 59 + Annotations.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Scene and the right Scene.
        /// </summary>
        /// <param name="left">Left Scene.</param>
        /// <param name="right">Right Scene.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (Scene left, Scene right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Scene and the right Scene.
        /// </summary>
        /// <param name="left">Left Scene.</param>
        /// <param name="right">Right Scene.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (Scene left, Scene right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Scene</returns>
        public Scene DeepClone()
        {
            using MemoryStream ms = new();
            
            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;
            return JsonSerializer.DeserializeAsync<Scene>(ms).Result;
        }
    }
}