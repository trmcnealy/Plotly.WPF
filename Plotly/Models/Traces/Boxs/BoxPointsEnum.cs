using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Plotly.Models.Traces.Boxs
{
    /// <summary>
    ///     If <c>outliers</c>, only the sample points lying outside the whiskers are
    ///     shown If <c>suspectedoutliers</c>, the outlier points are shown and points
    ///     either less than 4<c>Q1-3</c>Q3 or greater than 4<c>Q3-3</c>Q1 are highlighted
    ///     (see <c>outliercolor</c>) If <c>all</c>, all sample points are shown If
    ///     <c>false</c>, only the box(es) are shown with no sample points Defaults
    ///     to <c>suspectedoutliers</c> when <c>marker.outliercolor</c> or <c>marker.line.outliercolor</c>
    ///     is set. Defaults to <c>all</c> under the q1/median/q3 signature. Otherwise
    ///     defaults to <c>outliers</c>.
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum BoxPointsEnum
    {
        [EnumMember(Value=@"all")]
        All,
        [EnumMember(Value=@"outliers")]
        Outliers,
        [EnumMember(Value=@"suspectedoutliers")]
        SuspectedOutliers,
        [EnumMember(Value=@"False")]
        False
    }
}