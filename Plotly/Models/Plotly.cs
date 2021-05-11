#nullable enable

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Documents;

namespace Plotly.Models
{
    internal static class Converter
    {
        public sealed class DefaultJavaScriptEncoderBasicLatin : JavaScriptEncoder
        {
            public static readonly DefaultJavaScriptEncoderBasicLatin s_singleton = new();

            private DefaultJavaScriptEncoderBasicLatin()
            {
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public override bool WillEncode(int unicodeScalar)
            {
                return false;
            }

            public override unsafe int FindFirstCharacterToEncode(char* text,
                                                                  int   textLength)
            {
                return -1;
            }

            public override int FindFirstCharacterToEncodeUtf8(ReadOnlySpan<byte> utf8Text)
            {
                return -1;
            }

            public override int MaxOutputCharactersPerInputCharacter
            {
                get { return 12; }
            }

            public override unsafe bool TryEncodeUnicodeScalar(int     unicodeScalar,
                                                               char*   buffer,
                                                               int     bufferLength,
                                                               out int numberOfCharactersWritten)
            {
                numberOfCharactersWritten = 0;

                return false;
            }
        }

        public static readonly JsonSerializerOptions SerializerOptions = new()
        {
            Encoder                     = DefaultJavaScriptEncoderBasicLatin.s_singleton,
            PropertyNameCaseInsensitive = false,
            IgnoreNullValues            = true,
            WriteIndented               = true,
            //PropertyNamingPolicy        = JsonNamingPolicy.CamelCase,
            Converters =
            {
                PolymorphicConverter<ITrace>.Singleton,
                PolymorphicConverter<ITransform>.Singleton,
                DateTimeConverter.Singleton,
                DateTimeOffsetConverter.Singleton,
                JsNumberConverter.Singleton
            }
        };
    }

    public sealed class Plot
    {
        [JsonPropertyName("id")]
        public string Id { get; }

        [JsonPropertyName("data")]
        public List<ITrace> Data { get; }

        [JsonPropertyName("layout")]
        public Layout? Layout { get; }

        [JsonPropertyName("config")]
        public Config? Config { get; }

        [JsonPropertyName("frames")]
        public List<Frames>? Frames { get; }

        public Plot(string        id,
                    List<ITrace>  data,
                    Layout?       layout,
                    Config?       config = null,
                    List<Frames>? frames = null)
        {
            Id     = id;
            Data   = data;
            Layout = layout;
            Config = config;
            Frames = frames;
        }

        public static Plot? FromJson(string json)
        {
            return JsonSerializer.Deserialize<Plot>(json, Converter.SerializerOptions);
        }

        public string ToJson()
        {
            return JsonSerializer.Serialize(this, Converter.SerializerOptions);
        }

        public string NewPlot()
        {
            //StringBuilder sb   = new StringBuilder();

            //if(Data is not null)
            //{
            //    sb.Append($"const data = {JsonSerializer.Serialize(Data, Converter.SerializerOptions)};\n");
            //}

            //if(Layout is not null)
            //{
            //    sb.Append($"const layout = {JsonSerializer.Serialize(Layout, Converter.SerializerOptions)};\n");
            //}
            //else
            //{
            //    sb.Append("const layout = { title: \"ClickonPoints\" };\n");
            //}

            //if(Config is not null)
            //{
            //    sb.Append($"const config = {JsonSerializer.Serialize(Config, Converter.SerializerOptions)};\n");
            //}
            //else
            //{
            //    sb.Append("const config = { responsive: true };\n");
            //}

            //if(Frames is not null)
            //{
            //    sb.Append($"const frame = {JsonSerializer.Serialize(Data, Converter.SerializerOptions)};\n");
            //    //sb.Append($"window.Plotly.newPlot(\"{Id}\", data, layout, config, frame);\n");
            //}
            //else
            //{
            //    //sb.Append($"window.Plotly.newPlot(\"{Id}\", data, layout, config);\n");
            //}

            string json = JsonSerializer.Serialize(this, Converter.SerializerOptions);

            return json.Replace("\r\n", "\n");
        }
    }

    //public struct ColorUnion
    //{
    //    public List<List<Number>>? AnythingArray;
    //    public List<Number>?       Array;
    //    public Number?             Number;

    //    public static implicit operator ColorUnion(List<List<Number>> value) => new ColorUnion { AnythingArray = value };
    //    public static implicit operator ColorUnion(List<Number>       value) => new ColorUnion { Array         = value };
    //    public static implicit operator ColorUnion(double             value) => new ColorUnion { Number        = value };
    //    public static implicit operator ColorUnion(string             value) => new ColorUnion { Number        = value };
    //}
}
