using System;
using System.Text.Json.Serialization;

namespace Plotly.Models.Configs
{
    public class ImageButtonOptions
    {
        [JsonPropertyName("format")]
        public string Format { get; set; }

        [JsonPropertyName("filename")]
        public string Filename { get; set; }

        [JsonPropertyName("height")]
        public long Height { get; set; }

        [JsonPropertyName("width")]
        public long Width { get; set; }

        [JsonPropertyName("scale")]
        public long Scale { get; set; }
    }
}
