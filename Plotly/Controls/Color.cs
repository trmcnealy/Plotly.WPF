using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Plotly
{
    [StructLayout(LayoutKind.Explicit, Pack = sizeof(byte), Size = sizeof(byte) * 4)]
    internal struct ColorValue
    {
        [DataMember]
        [FieldOffset(0)]
        public uint Value;

        [DataMember]
        [FieldOffset(0)]
        public byte Blue;

        [DataMember]
        [FieldOffset(sizeof(byte))]
        public byte Green;

        [DataMember]
        [FieldOffset(sizeof(byte) * 2)]
        public byte Red;

        [DataMember]
        [FieldOffset(sizeof(byte) * 3)]
        public byte Alpha;

        public ColorValue(uint value)
        {
            Alpha = 0;
            Red   = 0;
            Green = 0;
            Blue  = 0;

            Value = value;
        }

        public ColorValue(byte alpha,
                          byte red,
                          byte green,
                          byte blue)
        {
            Value = 0;

            Alpha = alpha;
            Red   = red;
            Green = green;
            Blue  = blue;
        }

        #region Overrides of ValueType

        public override string ToString()
        {
            return $"#{Alpha:x2}{Red:x2}{Green:x2}{Blue:x2}";
        }

        #endregion
    }

    [JsonConverter(typeof(ColorJsonConverter))]
    public readonly struct Color : IEquatable<Color>
    {
        [JsonIgnore]
        public readonly byte Red;

        [JsonIgnore]
        public readonly byte Green;

        [JsonIgnore]
        public readonly byte Blue;

        private static void GetChannels(string   values,
                                        out byte red,
                                        out byte green,
                                        out byte blue)
        {
            char[] array = values.ToCharArray();

            if(array.Length == 6)
            {
                red   = byte.Parse(new ReadOnlySpan<char>(array, 0, 2));
                green = byte.Parse(new ReadOnlySpan<char>(array, 2, 2));
                blue  = byte.Parse(new ReadOnlySpan<char>(array, 4, 2));
            }
            else if(array.Length == 7)
            {
                red   = byte.Parse(new ReadOnlySpan<char>(array, 1, 2));
                green = byte.Parse(new ReadOnlySpan<char>(array, 3, 2));
                blue  = byte.Parse(new ReadOnlySpan<char>(array, 5, 2));
            }
            else if(array.Length == 8)
            {
                red   = byte.Parse(new ReadOnlySpan<char>(array, 2, 2));
                green = byte.Parse(new ReadOnlySpan<char>(array, 4, 2));
                blue  = byte.Parse(new ReadOnlySpan<char>(array, 6, 2));
            }
            else if(array.Length == 9)
            {
                red   = byte.Parse(new ReadOnlySpan<char>(array, 3, 2));
                green = byte.Parse(new ReadOnlySpan<char>(array, 5, 2));
                blue  = byte.Parse(new ReadOnlySpan<char>(array, 7, 2));
            }

            throw new ArgumentOutOfRangeException();
        }

        private static void GetChannels(ReadOnlySpan<char> values,
                                        out byte           red,
                                        out byte           green,
                                        out byte           blue)
        {
            if(values.Length == 6)
            {
                red   = byte.Parse(values.Slice(0, 2));
                green = byte.Parse(values.Slice(2, 2));
                blue  = byte.Parse(values.Slice(4, 2));
            }
            else if(values.Length == 7)
            {
                red   = byte.Parse(values.Slice(1, 2));
                green = byte.Parse(values.Slice(3, 2));
                blue  = byte.Parse(values.Slice(5, 2));
            }
            else if(values.Length == 8)
            {
                red   = byte.Parse(values.Slice(2, 2));
                green = byte.Parse(values.Slice(4, 2));
                blue  = byte.Parse(values.Slice(6, 2));
            }
            else if(values.Length == 9)
            {
                red   = byte.Parse(values.Slice(3, 2));
                green = byte.Parse(values.Slice(5, 2));
                blue  = byte.Parse(values.Slice(7, 2));
            }

            throw new ArgumentOutOfRangeException();
        }

        private static void GetChannels(uint     values,
                                        out byte red,
                                        out byte green,
                                        out byte blue)
        {
            ColorValue value = new(values);

            red   = value.Red;
            green = value.Green;
            blue  = value.Blue;
        }

        public Color(string values)
        {
            GetChannels(values, out Red, out Green, out Blue);
        }

        public Color(ReadOnlySpan<char> values)
        {
            GetChannels(values, out Red, out Green, out Blue);
        }

        public Color(uint values)
        {
            GetChannels(values, out Red, out Green, out Blue);
        }

        public Color(byte red,
                     byte green,
                     byte blue)
        {
            Red   = red;
            Green = green;
            Blue  = blue;
        }

        public Color(float[] values)
        {
            Red   = (byte)(values[0] * 255);
            Green = (byte)(values[1] * 255);
            Blue  = (byte)(values[2] * 255);
        }

        public Color(List<float> values)
        {
            Red   = (byte)(values[0] * 255);
            Green = (byte)(values[1] * 255);
            Blue  = (byte)(values[2] * 255);
        }

        public Color(float red,
                     float green,
                     float blue)
        {
            Red   = (byte)(red   * 255);
            Green = (byte)(green * 255);
            Blue  = (byte)(blue  * 255);
        }

        public Color(in Color other)
        {
            Red   = other.Red;
            Green = other.Green;
            Blue  = other.Blue;
        }

        #region Equality members

        public bool Equals(Color other)
        {
            return Red == other.Red && Green == other.Green && Blue == other.Blue;
        }

        public override bool Equals(object? obj)
        {
            return obj is Color other && Equals(other);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Red, Green, Blue);
        }

        public static bool operator ==(Color left,
                                       Color right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Color left,
                                       Color right)
        {
            return !left.Equals(right);
        }

        #endregion

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override string ToString()
        {
            return $"#{Red:x2}{Green:x2}{Blue:x2}";
        }
    }

    public class ColorJsonConverter : JsonConverter<Color>
    {
        public override Color Read(ref Utf8JsonReader    reader,
                                   Type                  typeToConvert,
                                   JsonSerializerOptions options)
        {
            while(reader.Read())
            {
                switch(reader.TokenType)
                {
                    case JsonTokenType.String:
                    {
                        ReadOnlySpan<char> value = reader.GetString();

                        if(value.StartsWith("rgba"))
                        {
                            int start = value.IndexOf("(");
                            int end   = value.IndexOf(")");

                            ReadOnlySpan<char> values = value.Slice(start + 1, end - start);

                            string[] data = values.ToString().Split(",");

                            byte red   = byte.Parse(data[0]);
                            byte green = byte.Parse(data[1]);
                            byte blue  = byte.Parse(data[2]);

                            reader.Read();

                            return new Color(red, green, blue);
                        }
                        else if(value.StartsWith("rgb"))
                        {
                            int start = value.IndexOf("(");
                            int end   = value.IndexOf(")");

                            ReadOnlySpan<char> values = value.Slice(start + 1, end - start);

                            string[] data = values.ToString().Split(",");

                            byte red   = byte.Parse(data[0]);
                            byte green = byte.Parse(data[1]);
                            byte blue  = byte.Parse(data[2]);

                            reader.Read();

                            return new Color(red, green, blue);
                        }

                        if(value.StartsWith("#"))
                        {
                            return new Color(value);
                        }

                        break;
                    }
                }
            }

            throw new JsonException();
        }

        public override void Write(Utf8JsonWriter        writer,
                                   Color                 value,
                                   JsonSerializerOptions options)
        {
            writer.WriteStartArray();
            writer.WriteStringValue(value.ToString());
            writer.WriteEndArray();
        }
    }
}

namespace Plotly
{
    public class ColorScaleEntryJsonConverter : JsonConverter<ColorScaleEntry>
    {
        public override ColorScaleEntry Read(ref Utf8JsonReader    reader,
                                             Type                  typeToConvert,
                                             JsonSerializerOptions options)
        {
            while(reader.Read())
            {
                switch(reader.TokenType)
                {
                    case JsonTokenType.StartArray:
                    {
                        reader.Read();

                        double value = reader.GetDouble();

                        reader.Read();

                        JsonConverter<Color> converter = options.GetConverter(typeof(ColorJsonConverter)) as JsonConverter<Color>;

                        Color color = converter.Read(ref reader, typeof(Color), options);

                        reader.Read();

                        return new ColorScaleEntry(value, color);
                    }
                }
            }

            throw new JsonException();
        }

        public override void Write(Utf8JsonWriter        writer,
                                   ColorScaleEntry       value,
                                   JsonSerializerOptions options)
        {
            writer.WriteStartArray();
            writer.WriteStringValue(value.ToString());
            writer.WriteEndArray();
        }
    }

    [JsonConverter(typeof(ColorScaleEntryJsonConverter))]
    public struct ColorScaleEntry : IEnumerable<object>
    {
        [JsonIgnore]
        public double Value;

        [JsonIgnore]
        public Color Color;

        public ColorScaleEntry(double value,
                               Color  color)
        {
            Value = value;
            Color = color;
        }

        public IEnumerator<object> GetEnumerator()
        {
            yield return Value;
            yield return $"rgb({Color.Red}, {Color.Green}, {Color.Blue})";
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override string ToString()
        {
            return $"{Value}, \"rgb({Color.Red}, {Color.Green}, {Color.Blue})\"";
        }
    }
}
