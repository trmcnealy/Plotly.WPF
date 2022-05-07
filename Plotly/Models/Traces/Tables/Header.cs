using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models.Traces.Tables.Headers;

namespace Plotly.Models.Traces.Tables
{
    /// <summary>
    ///     The Header class.
    /// </summary>
    [JsonConverter(typeof(PlotlyConverter))]
    [Serializable]
    public class Header : IEquatable<Header>
    {
        /// <summary>
        ///     Header cell values. <c>values[m][n]</c> represents the value of the <c>n</c>th
        ///     point in column <c>m</c>, therefore the <c>values[m]</c> vector length for
        ///     all columns must be the same (longer vectors will be truncated). Each value
        ///     must be a finite number or a string.
        /// </summary>
        [JsonPropertyName(@"values")]
        public List<object>? Values { get; set; }

        /// <summary>
        ///     Sets the cell value formatting rule using d3 formatting mini-language which
        ///     is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        /// </summary>
        [JsonPropertyName(@"format")]
        public List<object>? Format { get; set; }

        /// <summary>
        ///     Prefix for cell values.
        /// </summary>
        [JsonPropertyName(@"prefix")]
        public string? Prefix { get; set; }

        /// <summary>
        ///     Prefix for cell values.
        /// </summary>
        [JsonPropertyName(@"prefix")]
        [Array]
        public List<string>? PrefixArray { get; set; }

        /// <summary>
        ///     Suffix for cell values.
        /// </summary>
        [JsonPropertyName(@"suffix")]
        public string? Suffix { get; set; }

        /// <summary>
        ///     Suffix for cell values.
        /// </summary>
        [JsonPropertyName(@"suffix")]
        [Array]
        public List<string>? SuffixArray { get; set; }

        /// <summary>
        ///     The height of cells.
        /// </summary>
        [JsonPropertyName(@"height")]
        public JsNumber? Height { get; set; }

        /// <summary>
        ///     Sets the horizontal alignment of the <c>text</c> within the box. Has an
        ///     effect only if <c>text</c> spans two or more lines (i.e. <c>text</c> contains
        ///     one or more &lt;br&gt; HTML tags) or if an explicit width is set to override
        ///     the text width.
        /// </summary>
        [JsonPropertyName(@"align")]
        public AlignEnum? Align { get; set; }

        /// <summary>
        ///     Sets the horizontal alignment of the <c>text</c> within the box. Has an
        ///     effect only if <c>text</c> spans two or more lines (i.e. <c>text</c> contains
        ///     one or more &lt;br&gt; HTML tags) or if an explicit width is set to override
        ///     the text width.
        /// </summary>
        [JsonPropertyName(@"align")]
        [Array]
        public List<AlignEnum?>? AlignArray { get; set; }

        /// <summary>
        ///     Gets or sets the Line.
        /// </summary>
        [JsonPropertyName(@"line")]
        public Line? Line { get; set; }

        /// <summary>
        ///     Gets or sets the Fill.
        /// </summary>
        [JsonPropertyName(@"fill")]
        public Fill? Fill { get; set; }

        /// <summary>
        ///     Gets or sets the Font.
        /// </summary>
        [JsonPropertyName(@"font")]
        public Font? Font { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  values .
        /// </summary>
        [JsonPropertyName(@"valuessrc")]
        public string? ValuesSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  format .
        /// </summary>
        [JsonPropertyName(@"formatsrc")]
        public string? FormatSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  prefix .
        /// </summary>
        [JsonPropertyName(@"prefixsrc")]
        public string? PrefixSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  suffix .
        /// </summary>
        [JsonPropertyName(@"suffixsrc")]
        public string? SuffixSrc { get; set; }

        /// <summary>
        ///     Sets the source reference on Chart Studio Cloud for  align .
        /// </summary>
        [JsonPropertyName(@"alignsrc")]
        public string? AlignSrc { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is Header other))
                return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        public bool Equals([AllowNull] Header other)
        {
            if(other == null)
                return false;

            if(ReferenceEquals(this, other))
                return true;

            return (Equals(Values, other.Values) || Values != null && other.Values != null && Values.SequenceEqual(other.Values))                               &&
                   (Equals(Format, other.Format) || Format != null && other.Format != null && Format.SequenceEqual(other.Format))                               &&
                   (Prefix == other.Prefix && Prefix != null && other.Prefix != null && Prefix.Equals(other.Prefix))                                            &&
                   (Equals(PrefixArray, other.PrefixArray) || PrefixArray != null && other.PrefixArray != null && PrefixArray.SequenceEqual(other.PrefixArray)) &&
                   (Suffix == other.Suffix && Suffix != null && other.Suffix != null && Suffix.Equals(other.Suffix))                                            &&
                   (Equals(SuffixArray, other.SuffixArray) || SuffixArray != null && other.SuffixArray != null && SuffixArray.SequenceEqual(other.SuffixArray)) &&
                   (Height == other.Height && Height != null && other.Height != null && Height.Equals(other.Height))                                            &&
                   (Align  == other.Align  && Align  != null && other.Align  != null && Align.Equals(other.Align))                                              &&
                   (Equals(AlignArray, other.AlignArray) || AlignArray != null && other.AlignArray != null && AlignArray.SequenceEqual(other.AlignArray))       &&
                   (Line      == other.Line      && Line      != null && other.Line      != null && Line.Equals(other.Line))                                    &&
                   (Fill      == other.Fill      && Fill      != null && other.Fill      != null && Fill.Equals(other.Fill))                                    &&
                   (Font      == other.Font      && Font      != null && other.Font      != null && Font.Equals(other.Font))                                    &&
                   (ValuesSrc == other.ValuesSrc && ValuesSrc != null && other.ValuesSrc != null && ValuesSrc.Equals(other.ValuesSrc))                          &&
                   (FormatSrc == other.FormatSrc && FormatSrc != null && other.FormatSrc != null && FormatSrc.Equals(other.FormatSrc))                          &&
                   (PrefixSrc == other.PrefixSrc && PrefixSrc != null && other.PrefixSrc != null && PrefixSrc.Equals(other.PrefixSrc))                          &&
                   (SuffixSrc == other.SuffixSrc && SuffixSrc != null && other.SuffixSrc != null && SuffixSrc.Equals(other.SuffixSrc))                          &&
                   (AlignSrc  == other.AlignSrc  && AlignSrc  != null && other.AlignSrc  != null && AlignSrc.Equals(other.AlignSrc));
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;

                if(Values != null)
                    hashCode = hashCode * 59 + Values.GetHashCode();

                if(Format != null)
                    hashCode = hashCode * 59 + Format.GetHashCode();

                if(Prefix != null)
                    hashCode = hashCode * 59 + Prefix.GetHashCode();

                if(PrefixArray != null)
                    hashCode = hashCode * 59 + PrefixArray.GetHashCode();

                if(Suffix != null)
                    hashCode = hashCode * 59 + Suffix.GetHashCode();

                if(SuffixArray != null)
                    hashCode = hashCode * 59 + SuffixArray.GetHashCode();

                if(Height != null)
                    hashCode = hashCode * 59 + Height.GetHashCode();

                if(Align != null)
                    hashCode = hashCode * 59 + Align.GetHashCode();

                if(AlignArray != null)
                    hashCode = hashCode * 59 + AlignArray.GetHashCode();

                if(Line != null)
                    hashCode = hashCode * 59 + Line.GetHashCode();

                if(Fill != null)
                    hashCode = hashCode * 59 + Fill.GetHashCode();

                if(Font != null)
                    hashCode = hashCode * 59 + Font.GetHashCode();

                if(ValuesSrc != null)
                    hashCode = hashCode * 59 + ValuesSrc.GetHashCode();

                if(FormatSrc != null)
                    hashCode = hashCode * 59 + FormatSrc.GetHashCode();

                if(PrefixSrc != null)
                    hashCode = hashCode * 59 + PrefixSrc.GetHashCode();

                if(SuffixSrc != null)
                    hashCode = hashCode * 59 + SuffixSrc.GetHashCode();

                if(AlignSrc != null)
                    hashCode = hashCode * 59 + AlignSrc.GetHashCode();

                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Header and the right Header.
        /// </summary>
        /// <param name="left">Left Header.</param>
        /// <param name="right">Right Header.</param>
        /// <returns>Boolean</returns>
        public static bool operator ==(Header left,
                                       Header right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Header and the right Header.
        /// </summary>
        /// <param name="left">Left Header.</param>
        /// <param name="right">Right Header.</param>
        /// <returns>Boolean</returns>
        public static bool operator !=(Header left,
                                       Header right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Header</returns>
        public Header DeepClone()
        {
            using MemoryStream ms = new();

            JsonSerializer.SerializeAsync(ms, this);
            ms.Position = 0;

            return JsonSerializer.DeserializeAsync<Header>(ms).Result;
        }
    }
}
