using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Plotly.Models.Traces.Carpets.BAxes
{
    /// <summary>
    ///     Specifies the ordering logic for the case of categorical variables. By default,
    ///     plotly uses <c>trace</c>, which specifies the order that is present in the
    ///     data supplied. Set <c>categoryorder</c> to &#39;category ascending&#39;
    ///     or &#39;category descending&#39; if order should be determined by the alphanumerical
    ///     order of the category names. Set <c>categoryorder</c> to <c>array</c> to
    ///     derive the ordering from the attribute <c>categoryarray</c>. If a category
    ///     is not found in the <c>categoryarray</c> array, the sorting behavior for
    ///     that attribute will be identical to the <c>trace</c> mode. The unspecified
    ///     categories will follow the categories in <c>categoryarray</c>.
    /// </summary>
    
    [JsonConverter(typeof(EnumConverter))]
    public enum CategoryOrderEnum
    {
        [EnumMember(Value=@"trace")]
        Trace = 0,
        [EnumMember(Value=@"category ascending")]
        CategoryAscending,
        [EnumMember(Value=@"category descending")]
        CategoryDescending,
        [EnumMember(Value=@"array")]
        Array
    }
}