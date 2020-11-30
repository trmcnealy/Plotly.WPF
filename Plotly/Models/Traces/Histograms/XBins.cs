using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Plotly.Models.Traces.Histograms
{
    /// <summary>
    ///     The XBins class.
    /// </summary>
    
    [Serializable]
    public class XBins : IEquatable<XBins>
    {
        /// <summary>
        ///     Sets the starting value for the x axis bins. Defaults to the minimum data
        ///     value, shifted down if necessary to make nice round values and to remove
        ///     ambiguous bin edges. For example, if most of the data is integers we shift
        ///     the bin edges 0.5 down, so a <c>size</c> of 5 would have a default <c>start</c>
        ///     of -0.5, so it is clear that 0-4 are in the first bin, 5-9 in the second,
        ///     but continuous data gets a start of 0 and bins [0,5), [5,10) etc. Dates
        ///     behave similarly, and <c>start</c> should be a date string. For category
        ///     data, <c>start</c> is based on the category serial numbers, and defaults
        ///     to -0.5. If multiple non-overlaying histograms share a subplot, the first
        ///     explicit <c>start</c> is used exactly and all others are shifted down (if
        ///     necessary) to differ from that one by an integer number of bins.
        /// </summary>
        [JsonPropertyName(@"start")]
        public object Start { get; set;} 

        /// <summary>
        ///     Sets the end value for the x axis bins. The last bin may not end exactly
        ///     at this value, we increment the bin edge by <c>size</c> from <c>start</c>
        ///     until we reach or exceed <c>end</c>. Defaults to the maximum data value.
        ///     Like <c>start</c>, for dates use a date string, and for category data <c>end</c>
        ///     is based on the category serial numbers.
        /// </summary>
        [JsonPropertyName(@"end")]
        public object End { get; set;} 

        /// <summary>
        ///     Sets the size of each x axis bin. Default behavior: If <c>nbinsx</c> is
        ///     0 or omitted, we choose a nice round bin size such that the number of bins
        ///     is about the same as the typical number of samples in each bin. If <c>nbinsx</c>
        ///     is provided, we choose a nice round bin size giving no more than that many
        ///     bins. For date data, use milliseconds or <c>M&lt;n&gt;</c> for months, as
        ///     in <c>axis.dtick</c>. For category data, the number of categories to bin
        ///     together (always defaults to 1). If multiple non-overlaying histograms share
        ///     a subplot, the first explicit <c>size</c> is used and all others discarded.
        ///     If no <c>size</c> is provided,the sample data from all traces is combined
        ///     to determine <c>size</c> as described above.
        /// </summary>
        [JsonPropertyName(@"size")]
        public object Size { get; set;} 

        
        public override bool Equals(object obj)
        {
            if (!(obj is XBins other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        
        public bool Equals([AllowNull] XBins other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Start == other.Start &&
                    Start != null && other.Start != null &&
                    Start.Equals(other.Start)
                ) && 
                (
                    End == other.End &&
                    End != null && other.End != null &&
                    End.Equals(other.End)
                ) && 
                (
                    Size == other.Size &&
                    Size != null && other.Size != null &&
                    Size.Equals(other.Size)
                );
        }

        
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (Start != null) hashCode = hashCode * 59 + Start.GetHashCode();
                if (End != null) hashCode = hashCode * 59 + End.GetHashCode();
                if (Size != null) hashCode = hashCode * 59 + Size.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left XBins and the right XBins.
        /// </summary>
        /// <param name="left">Left XBins.</param>
        /// <param name="right">Right XBins.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (XBins left, XBins right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left XBins and the right XBins.
        /// </summary>
        /// <param name="left">Left XBins.</param>
        /// <param name="right">Right XBins.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (XBins left, XBins right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>XBins</returns>
        public XBins DeepClone()
        {
            using MemoryStream ms = new();
            
            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;
            return JsonSerializer.DeserializeAsync<XBins>(ms).Result;
        }
    }
}