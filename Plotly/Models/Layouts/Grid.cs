using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Layouts.Grids;

namespace Plotly.Models.Layouts
{
    /// <summary>
    ///     The Grid class.
    /// </summary>
    [Serializable]
    public class Grid : IEquatable<Grid>
    {
        /// <summary>
        ///     The number of rows in the grid. If you provide a 2D <c>subplots</c> array
        ///     or a <c>yaxes</c> array, its length is used as the default. But it&#39;s
        ///     also possible to have a different length, if you want to leave a row at
        ///     the end for non-cartesian subplots.
        /// </summary>
        [JsonPropertyName(@"rows")]
        public int? Rows { get; set; }

        /// <summary>
        ///     Is the first row the top or the bottom? Note that columns are always enumerated
        ///     from left to right.
        /// </summary>
        [JsonPropertyName(@"roworder")]
        public RowOrderEnum? RowOrder { get; set; }

        /// <summary>
        ///     The number of columns in the grid. If you provide a 2D <c>subplots</c> array,
        ///     the length of its longest row is used as the default. If you give an <c>xaxes</c>
        ///     array, its length is used as the default. But it&#39;s also possible to
        ///     have a different length, if you want to leave a row at the end for non-cartesian
        ///     subplots.
        /// </summary>
        [JsonPropertyName(@"columns")]
        public int? Columns { get; set; }

        /// <summary>
        ///     Used for freeform grids, where some axes may be shared across subplots but
        ///     others are not. Each entry should be a cartesian subplot id, like <c>xy</c>
        ///     or <c>x3y2</c>, or ** to leave that cell empty. You may reuse x axes within
        ///     the same column, and y axes within the same row. Non-cartesian subplots
        ///     and traces that support <c>domain</c> can place themselves in this grid
        ///     separately using the <c>gridcell</c> attribute.
        /// </summary>
        [JsonPropertyName(@"subplots")]
        public List<object> Subplots { get; set; }

        /// <summary>
        ///     Used with <c>yaxes</c> when the x and y axes are shared across columns and
        ///     rows. Each entry should be an x axis id like <c>x</c>, <c>x2</c>, etc.,
        ///     or *&#39; to not put an x axis in that column. Entries other than &#39;*
        ///     must be unique. Ignored if <c>subplots</c> is present. If missing but <c>yaxes</c>
        ///     is present, will generate consecutive IDs.
        /// </summary>
        [JsonPropertyName(@"xaxes")]
        public List<object> XAxes { get; set; }

        /// <summary>
        ///     Used with <c>yaxes</c> when the x and y axes are shared across columns and
        ///     rows. Each entry should be an y axis id like <c>y</c>, <c>y2</c>, etc.,
        ///     or *&#39; to not put a y axis in that row. Entries other than &#39;* must
        ///     be unique. Ignored if <c>subplots</c> is present. If missing but <c>xaxes</c>
        ///     is present, will generate consecutive IDs.
        /// </summary>
        [JsonPropertyName(@"yaxes")]
        public List<object> YAxes { get; set; }

        /// <summary>
        ///     If no <c>subplots</c>, <c>xaxes</c>, or <c>yaxes</c> are given but we do
        ///     have <c>rows</c> and <c>columns</c>, we can generate defaults using consecutive
        ///     axis IDs, in two ways: <c>coupled</c> gives one x axis per column and one
        ///     y axis per row. <c>independent</c> uses a new xy pair for each cell, left-to-right
        ///     across each row then iterating rows according to <c>roworder</c>.
        /// </summary>
        [JsonPropertyName(@"pattern")]
        public PatternEnum? Pattern { get; set; }

        /// <summary>
        ///     Horizontal space between grid cells, expressed as a fraction of the total
        ///     width available to one cell. Defaults to 0.1 for coupled-axes grids and
        ///     0.2 for independent grids.
        /// </summary>
        [JsonPropertyName(@"xgap")]
        public JsNumber? XGap { get; set; }

        /// <summary>
        ///     Vertical space between grid cells, expressed as a fraction of the total
        ///     height available to one cell. Defaults to 0.1 for coupled-axes grids and
        ///     0.3 for independent grids.
        /// </summary>
        [JsonPropertyName(@"ygap")]
        public JsNumber? YGap { get; set; }

        /// <summary>
        ///     Gets or sets the Domain.
        /// </summary>
        [JsonPropertyName(@"domain")]
        public Domain Domain { get; set; }

        /// <summary>
        ///     Sets where the x axis labels and titles go. <c>bottom</c> means the very
        ///     bottom of the grid. &#39;bottom plot&#39; is the lowest plot that each x
        ///     axis is used in. <c>top</c> and &#39;top plot&#39; are similar.
        /// </summary>
        [JsonPropertyName(@"xside")]
        public XSideEnum? XSide { get; set; }

        /// <summary>
        ///     Sets where the y axis labels and titles go. <c>left</c> means the very left
        ///     edge of the grid. &#39;left plot&#39; is the leftmost plot that each y axis
        ///     is used in. <c>right</c> and &#39;right plot&#39; are similar.
        /// </summary>
        [JsonPropertyName(@"yside")]
        public YSideEnum? YSide { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is Grid other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] Grid other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (Rows     == other.Rows     && Rows     != null && other.Rows     != null && Rows.Equals(other.Rows))                      &&
                   (RowOrder == other.RowOrder && RowOrder != null && other.RowOrder != null && RowOrder.Equals(other.RowOrder))              &&
                   (Columns  == other.Columns  && Columns  != null && other.Columns  != null && Columns.Equals(other.Columns))                &&
                   (Equals(Subplots, other.Subplots) || Subplots != null && other.Subplots != null && Subplots.SequenceEqual(other.Subplots)) &&
                   (Equals(XAxes,    other.XAxes)    || XAxes    != null && other.XAxes    != null && XAxes.SequenceEqual(other.XAxes))       &&
                   (Equals(YAxes,    other.YAxes)    || YAxes    != null && other.YAxes    != null && YAxes.SequenceEqual(other.YAxes))       &&
                   (Pattern == other.Pattern && Pattern != null && other.Pattern != null && Pattern.Equals(other.Pattern))                    &&
                   (XGap    == other.XGap    && XGap    != null && other.XGap    != null && XGap.Equals(other.XGap))                          &&
                   (YGap    == other.YGap    && YGap    != null && other.YGap    != null && YGap.Equals(other.YGap))                          &&
                   (Domain  == other.Domain  && Domain  != null && other.Domain  != null && Domain.Equals(other.Domain))                      &&
                   (XSide   == other.XSide   && XSide   != null && other.XSide   != null && XSide.Equals(other.XSide))                        &&
                   (YSide   == other.YSide   && YSide   != null && other.YSide   != null && YSide.Equals(other.YSide));
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;

                if(Rows != null)
                    hashCode = hashCode * 59 + Rows.GetHashCode();

                if(RowOrder != null)
                    hashCode = hashCode * 59 + RowOrder.GetHashCode();

                if(Columns != null)
                    hashCode = hashCode * 59 + Columns.GetHashCode();

                if(Subplots != null)
                    hashCode = hashCode * 59 + Subplots.GetHashCode();

                if(XAxes != null)
                    hashCode = hashCode * 59 + XAxes.GetHashCode();

                if(YAxes != null)
                    hashCode = hashCode * 59 + YAxes.GetHashCode();

                if(Pattern != null)
                    hashCode = hashCode * 59 + Pattern.GetHashCode();

                if(XGap != null)
                    hashCode = hashCode * 59 + XGap.GetHashCode();

                if(YGap != null)
                    hashCode = hashCode * 59 + YGap.GetHashCode();

                if(Domain != null)
                    hashCode = hashCode * 59 + Domain.GetHashCode();

                if(XSide != null)
                    hashCode = hashCode * 59 + XSide.GetHashCode();

                if(YSide != null)
                    hashCode = hashCode * 59 + YSide.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Grid and the right Grid.
        /// </summary>
        /// <param name="left">Left Grid.</param>
        /// <param name="right">Right Grid.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(Grid left,
                                       Grid right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Grid and the right Grid.
        /// </summary>
        /// <param name="left">Left Grid.</param>
        /// <param name="right">Right Grid.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(Grid left,
                                       Grid right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Grid</returns>
        public Grid DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<Grid>(ms).Result;
        }
    }
}
