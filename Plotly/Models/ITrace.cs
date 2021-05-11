using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Plotly.Models
{
    /// <summary>
    ///     The trace interface.
    /// </summary>
    public interface ITrace
    {
        /// <summary>
        ///     The type of the trace.
        /// </summary>
        [JsonPropertyName(@"type")]
        public TraceTypeEnum? Type { get; }
    }
}
