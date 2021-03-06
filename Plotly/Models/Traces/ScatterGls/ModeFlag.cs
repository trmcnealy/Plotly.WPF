using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

#pragma warning disable 1591

namespace Plotly.Models.Traces
{
    public partial class ScatterGl
    {
        /// <summary>
        ///     Determines the drawing mode for this scatter trace.
        /// </summary>
        [Flags]
        [JsonConverter(typeof(EnumConverter))]
        public enum ModeFlag
        {
            [EnumMember(Value = @"none")]
            None = 0,

            [EnumMember(Value = @"lines")]
            Lines = 1,

            [EnumMember(Value = @"markers")]
            Markers = 2,

            [EnumMember(Value = @"text")]
            Text = 4
        }
    }
}
