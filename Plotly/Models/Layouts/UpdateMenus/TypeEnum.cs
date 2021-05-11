using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Layouts.UpdateMenus
{
    /// <summary>
    ///     Determines whether the buttons are accessible via a dropdown menu or whether
    ///     the buttons are stacked horizontally or vertically
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum TypeEnum
    {
        [EnumMember(Value = @"dropdown")]
        DropDown = 0,

        [EnumMember(Value = @"buttons")]
        Buttons
    }
}
