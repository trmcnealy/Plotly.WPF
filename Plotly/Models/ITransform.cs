using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace Plotly.Models
{
    /// <summary>
    ///     The transform interface.
    /// </summary>
    public interface ITransform
    {
        /// <summary>
        ///     The type of the transform.
        /// </summary>
        [JsonPropertyName(@"type")]
        public TransformTypeEnum? Type { get; }
    }
}
