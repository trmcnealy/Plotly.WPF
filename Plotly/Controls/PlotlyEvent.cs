using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;

using Plotly.Models;

namespace Plotly
{
    public sealed class PlotlyEvent
    {
        [Required]
        [JsonPropertyName("id")]
        public string Id { get; }

        [Required]
        [JsonPropertyName("event")]
        public string Event { get; }

        [JsonPropertyName("selected")]
        public SelectedData[]? Selected { get; set; }

        public PlotlyEvent(string id,
                           string @event)
        {
            Id    = id;
            Event = @event;
        }

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
