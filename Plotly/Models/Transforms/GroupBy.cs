using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Transforms.GroupBys;

namespace Plotly.Models.Transforms
{
    /// <summary>
    ///     The GroupBy class.
    ///     Implements the <see cref="ITransform" />.
    /// </summary>
    [Serializable]
    public class GroupBy : ITransform, IEquatable<GroupBy>
    {
        /// <inheritdoc/>
        [JsonPropertyName(@"type")]
        public TransformTypeEnum? Type { get; } = TransformTypeEnum.GroupBy;

        /// <summary>
        ///     Determines whether this group-by transform is enabled or disabled.
        /// </summary>
        [JsonPropertyName(@"enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        ///     Sets the groups in which the trace data will be split. For example, with
        ///     <c>x</c> set to &#39;[1, 2, 3, 4]&#39; and <c>groups</c> set to &#39;[<c>a</c>,
        ///     <c>b</c>, <c>a</c>, <c>b</c>]&#39;, the groupby transform with split in
        ///     one trace with <c>x</c> [1, 3] and one trace with <c>x</c> [2, 4].
        /// </summary>
        [JsonPropertyName(@"groups")]
        public List<object>? Groups { get; set; }

        /// <summary>
        ///     Pattern by which grouped traces are named. If only one trace is present,
        ///     defaults to the group name (<c><c>%{group}</c></c>), otherwise defaults
        ///     to the group name with trace name (&#39;&quot;%{group} (%{trace})&quot;&#39;).
        ///     Available escape sequences are <c>%{group}</c>, which inserts the group
        ///     name, and <c>%{trace}</c>, which inserts the trace name. If grouping GDP
        ///     data by country when more than one trace is present, for example, the default
        ///     &quot;%{group} (%{trace})&quot; would return &quot;Monaco (GDP per capita)&quot;.
        /// </summary>
        [JsonPropertyName(@"nameformat")]
        public string? NameFormat { get; set; }

        /// <summary>
        ///     Gets or sets the Styles.
        /// </summary>
        [JsonPropertyName(@"styles")]
        public List<Style>? Styles { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  groups .
        /// </summary>
        [JsonPropertyName(@"groupssrc")]
        public string? GroupsSrc { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is GroupBy other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] GroupBy other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (Type    == other.Type    && Type    != null && other.Type    != null && Type.Equals(other.Type))                         &&
                   (Enabled == other.Enabled && Enabled != null && other.Enabled != null && Enabled.Equals(other.Enabled))                   &&
                   (Equals(Groups, other.Groups) || Groups != null && other.Groups != null && Groups.SequenceEqual(other.Groups))            &&
                   (NameFormat == other.NameFormat && NameFormat != null && other.NameFormat != null && NameFormat.Equals(other.NameFormat)) &&
                   (Equals(Styles, other.Styles) || Styles != null && other.Styles != null && Styles.SequenceEqual(other.Styles))            &&
                   (GroupsSrc == other.GroupsSrc && GroupsSrc != null && other.GroupsSrc != null && GroupsSrc.Equals(other.GroupsSrc));
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;

                if(Type != null)
                    hashCode = hashCode * 59 + Type.GetHashCode();

                if(Enabled != null)
                    hashCode = hashCode * 59 + Enabled.GetHashCode();

                if(Groups != null)
                    hashCode = hashCode * 59 + Groups.GetHashCode();

                if(NameFormat != null)
                    hashCode = hashCode * 59 + NameFormat.GetHashCode();

                if(Styles != null)
                    hashCode = hashCode * 59 + Styles.GetHashCode();

                if(GroupsSrc != null)
                    hashCode = hashCode * 59 + GroupsSrc.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left GroupBy and the right GroupBy.
        /// </summary>
        /// <param name="left">Left GroupBy.</param>
        /// <param name="right">Right GroupBy.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(GroupBy left,
                                       GroupBy right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left GroupBy and the right GroupBy.
        /// </summary>
        /// <param name="left">Left GroupBy.</param>
        /// <param name="right">Right GroupBy.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(GroupBy left,
                                       GroupBy right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>GroupBy</returns>
        public GroupBy DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<GroupBy>(ms).Result;
        }
    }
}
