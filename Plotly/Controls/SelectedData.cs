using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models;

namespace Plotly
{
    public sealed class SelectedData
    {
        [JsonPropertyName("curveNumber")]
        public int CurveNumber { get; set; }

        [JsonPropertyName("pointIndex")]
        public int PointIndex { get; set; }

        [JsonPropertyName("pointNumber")]
        public int PointNumber { get; set; }

        [JsonPropertyName("x")]
        public object X { get; set; }

        [JsonPropertyName("y")]
        public object Y { get; set; }

        public static PlotlyEvent? FromJson(string json)
        {
            return JsonSerializer.Deserialize<PlotlyEvent>(json, Converter.SerializerOptions);
        }

        public string ToJson()
        {
            return JsonSerializer.Serialize(this, Converter.SerializerOptions);
        }
    }
}
