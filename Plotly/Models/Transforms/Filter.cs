
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Transforms.Filters;

namespace Plotly.Models.Transforms
{
    /// <summary>
    ///     The Filter class.
    ///     Implements the <see cref="ITransform" />.
    /// </summary>
    
    [JsonConverter(typeof(PlotlyConverter))]
    [Serializable]
    public class Filter : ITransform, IEquatable<Filter>
    {
        /// <inheritdoc/>
        [JsonPropertyName(@"type")]
        public TransformTypeEnum? Type { get; } = TransformTypeEnum.Filter;

        /// <summary>
        ///     Determines whether this filter transform is enabled or disabled.
        /// </summary>
        [JsonPropertyName(@"enabled")]
        public bool? Enabled { get; set;} 

        /// <summary>
        ///     Sets the filter target by which the filter is applied. If a string, <c>target</c>
        ///     is assumed to be a reference to a data array in the parent trace object.
        ///     To filter about nested variables, use <c>.</c> to access them. For example,
        ///     set <c>target</c> to <c>marker.color</c> to filter about the marker color
        ///     array. If an array, <c>target</c> is then the data array by which the filter
        ///     is applied.
        /// </summary>
        [JsonPropertyName(@"target")]
        public string Target { get; set;} 

        /// <summary>
        ///     Sets the filter target by which the filter is applied. If a string, <c>target</c>
        ///     is assumed to be a reference to a data array in the parent trace object.
        ///     To filter about nested variables, use <c>.</c> to access them. For example,
        ///     set <c>target</c> to <c>marker.color</c> to filter about the marker color
        ///     array. If an array, <c>target</c> is then the data array by which the filter
        ///     is applied.
        /// </summary>
        [JsonPropertyName(@"target")]
        [Array]
        public List<string> TargetArray { get; set;} 

        /// <summary>
        ///     Sets the filter operation. <c>=</c> keeps items equal to <c>value</c> <c>!=</c>
        ///     keeps items not equal to <c>value</c> <c>&lt;</c> keeps items less than
        ///     <c>value</c> <c>&lt;=</c> keeps items less than or equal to <c>value</c>
        ///     <c>&gt;</c> keeps items greater than <c>value</c> <c>&gt;=</c> keeps items
        ///     greater than or equal to <c>value</c> <c>[]</c> keeps items inside <c>value[0]</c>
        ///     to <c>value[1]</c> including both bounds <c>()</c> keeps items inside <c>value[0]</c>
        ///     to <c>value[1]</c> excluding both bounds <c>[)</c> keeps items inside <c>value[0]</c>
        ///     to <c>value[1]</c> including <c>value[0]</c> but excluding &#39;value[1]
        ///     <c>(]</c> keeps items inside <c>value[0]</c> to <c>value[1]</c> excluding
        ///     <c>value[0]</c> but including &#39;value[1] <c>][</c> keeps items outside
        ///     <c>value[0]</c> to <c>value[1]</c> and equal to both bounds <c>)(</c> keeps
        ///     items outside <c>value[0]</c> to <c>value[1]</c> <c>](</c> keeps items outside
        ///     <c>value[0]</c> to <c>value[1]</c> and equal to <c>value[0]</c> <c>)[</c>
        ///     keeps items outside <c>value[0]</c> to <c>value[1]</c> and equal to <c>value[1]</c>
        ///     <c>{}</c> keeps items present in a set of values <c>}{</c> keeps items not
        ///     present in a set of values
        /// </summary>
        [JsonPropertyName(@"operation")]
        public OperationEnum? Operation { get; set;} 

        /// <summary>
        ///     Sets the value or values by which to filter. Values are expected to be in
        ///     the same type as the data linked to <c>target</c>. When <c>operation</c>
        ///     is set to one of the comparison values (=,!=,&lt;,&gt;=,&gt;,&lt;=) <c>value</c>
        ///     is expected to be a number or a string. When <c>operation</c> is set to
        ///     one of the interval values ([],(),[),(],][,)(,](,)[) <c>value</c> is expected
        ///     to be 2-item array where the first item is the lower bound and the second
        ///     item is the upper bound. When <c>operation</c>, is set to one of the set
        ///     values ({},}{) <c>value</c> is expected to be an array with as many items
        ///     as the desired set elements.
        /// </summary>
        [JsonPropertyName(@"value")]
        public object Value { get; set;} 

        /// <summary>
        ///     Determines whether or not gaps in data arrays produced by the filter operation
        ///     are preserved. Setting this to <c>true</c> might be useful when plotting
        ///     a line chart with <c>connectgaps</c> set to <c>false</c>.
        /// </summary>
        [JsonPropertyName(@"preservegaps")]
        public bool? PreserveGaps { get; set;} 

        /// <summary>
        ///     Sets the calendar system to use for <c>value</c>, if it is a date.
        /// </summary>
        [JsonPropertyName(@"valuecalendar")]
        public ValueCalendarEnum? ValueCalendar { get; set;} 

        /// <summary>
        ///     Sets the calendar system to use for <c>target</c>, if it is an array of
        ///     dates. If <c>target</c> is a string (eg <c>x</c>) we use the corresponding
        ///     trace attribute (eg <c>xcalendar</c>) if it exists, even if <c>targetcalendar</c>
        ///     is provided.
        /// </summary>
        [JsonPropertyName(@"targetcalendar")]
        public TargetCalendarEnum? TargetCalendar { get; set;} 

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  target .
        /// </summary>
        [JsonPropertyName(@"targetsrc")]
        public string TargetSrc { get; set;} 

        
        public override bool Equals(object obj)
        {
            if (!(obj is Filter other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        
        public bool Equals([AllowNull] Filter other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Type == other.Type &&
                    Type != null && other.Type != null &&
                    Type.Equals(other.Type)
                ) && 
                (
                    Enabled == other.Enabled &&
                    Enabled != null && other.Enabled != null &&
                    Enabled.Equals(other.Enabled)
                ) && 
                (
                    Target == other.Target &&
                    Target != null && other.Target != null &&
                    Target.Equals(other.Target)
                ) && 
                (
                    Equals(TargetArray, other.TargetArray) ||
                    TargetArray != null && other.TargetArray != null &&
                    TargetArray.SequenceEqual(other.TargetArray)
                ) &&
                (
                    Operation == other.Operation &&
                    Operation != null && other.Operation != null &&
                    Operation.Equals(other.Operation)
                ) && 
                (
                    Value == other.Value &&
                    Value != null && other.Value != null &&
                    Value.Equals(other.Value)
                ) && 
                (
                    PreserveGaps == other.PreserveGaps &&
                    PreserveGaps != null && other.PreserveGaps != null &&
                    PreserveGaps.Equals(other.PreserveGaps)
                ) && 
                (
                    ValueCalendar == other.ValueCalendar &&
                    ValueCalendar != null && other.ValueCalendar != null &&
                    ValueCalendar.Equals(other.ValueCalendar)
                ) && 
                (
                    TargetCalendar == other.TargetCalendar &&
                    TargetCalendar != null && other.TargetCalendar != null &&
                    TargetCalendar.Equals(other.TargetCalendar)
                ) && 
                (
                    TargetSrc == other.TargetSrc &&
                    TargetSrc != null && other.TargetSrc != null &&
                    TargetSrc.Equals(other.TargetSrc)
                );
        }

        
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (Type != null) hashCode = hashCode * 59 + Type.GetHashCode();
                if (Enabled != null) hashCode = hashCode * 59 + Enabled.GetHashCode();
                if (Target != null) hashCode = hashCode * 59 + Target.GetHashCode();
                if (TargetArray != null) hashCode = hashCode * 59 + TargetArray.GetHashCode();
                if (Operation != null) hashCode = hashCode * 59 + Operation.GetHashCode();
                if (Value != null) hashCode = hashCode * 59 + Value.GetHashCode();
                if (PreserveGaps != null) hashCode = hashCode * 59 + PreserveGaps.GetHashCode();
                if (ValueCalendar != null) hashCode = hashCode * 59 + ValueCalendar.GetHashCode();
                if (TargetCalendar != null) hashCode = hashCode * 59 + TargetCalendar.GetHashCode();
                if (TargetSrc != null) hashCode = hashCode * 59 + TargetSrc.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Filter and the right Filter.
        /// </summary>
        /// <param name="left">Left Filter.</param>
        /// <param name="right">Right Filter.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (Filter left, Filter right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Filter and the right Filter.
        /// </summary>
        /// <param name="left">Left Filter.</param>
        /// <param name="right">Right Filter.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (Filter left, Filter right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Filter</returns>
        public Filter DeepClone()
        {
            using MemoryStream ms = new();
            
            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;
            return JsonSerializer.DeserializeAsync<Filter>(ms).Result;
        }
    }
}