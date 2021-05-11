using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

            if(value < 0xFFFFFF)
            {
                Alpha = 0xFF;
            }
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
    public readonly struct Color : IEquatable<Color>, IComparable<Color>, IComparable
    {
        [JsonIgnore]
        public readonly byte Alpha;

        [JsonIgnore]
        public readonly byte Red;

        [JsonIgnore]
        public readonly byte Green;

        [JsonIgnore]
        public readonly byte Blue;

        /// <summary>
        /// Only supports:
        /// "000000 - FFFFFF" RGB
        /// "00000000 - FFFFFFFF" ARGB
        /// "#000000 - #FFFFFF" RGB
        /// "#00000000 - #FFFFFFFF" ARGB
        /// "0x000000 - 0xFFFFFF" RGB
        /// "0x00000000 - 0xFFFFFFFF" ARGB
        /// </summary>
        /// <param name="values"></param>
        /// <param name="alpha"></param>
        /// <param name="red"></param>
        /// <param name="green"></param>
        /// <param name="blue"></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        private static void GetChannels(string   values,
                                        out byte alpha,
                                        out byte red,
                                        out byte green,
                                        out byte blue)
        {
            char[] array = values.ToCharArray();

            if(array.Length == 6)
            {
                alpha = 0xFF;
                red   = byte.Parse(new ReadOnlySpan<char>(array, 0, 2));
                green = byte.Parse(new ReadOnlySpan<char>(array, 2, 2));
                blue  = byte.Parse(new ReadOnlySpan<char>(array, 4, 2));
            }
            else if(array.Length == 7 && array[0] == '#')
            {
                alpha = 0xFF;
                red   = byte.Parse(new ReadOnlySpan<char>(array, 1, 2));
                green = byte.Parse(new ReadOnlySpan<char>(array, 3, 2));
                blue  = byte.Parse(new ReadOnlySpan<char>(array, 5, 2));
            }
            else if(array.Length == 8 && (array[0] != '#' || (array[0] != '0' && array[1] != 'x')))
            {
                alpha = byte.Parse(new ReadOnlySpan<char>(array, 0, 2));
                red   = byte.Parse(new ReadOnlySpan<char>(array, 2, 2));
                green = byte.Parse(new ReadOnlySpan<char>(array, 4, 2));
                blue  = byte.Parse(new ReadOnlySpan<char>(array, 6, 2));
            }
            else if(array.Length == 9 && array[0] == '#')
            {
                alpha = byte.Parse(new ReadOnlySpan<char>(array, 1, 2));
                red   = byte.Parse(new ReadOnlySpan<char>(array, 3, 2));
                green = byte.Parse(new ReadOnlySpan<char>(array, 5, 2));
                blue  = byte.Parse(new ReadOnlySpan<char>(array, 7, 2));
            }
            else if(array.Length == 10 && array[0] == '0' && array[1] == 'x')
            {
                alpha = byte.Parse(new ReadOnlySpan<char>(array, 2, 2));
                red   = byte.Parse(new ReadOnlySpan<char>(array, 4, 2));
                green = byte.Parse(new ReadOnlySpan<char>(array, 6, 2));
                blue  = byte.Parse(new ReadOnlySpan<char>(array, 8, 2));
            }

            throw new ArgumentOutOfRangeException();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        private static void GetChannels(ReadOnlySpan<char> values,
                                        out byte           alpha,
                                        out byte           red,
                                        out byte           green,
                                        out byte           blue)
        {
            if(values.Length == 6)
            {
                alpha = 0xFF;
                red   = byte.Parse(values.Slice(0, 2));
                green = byte.Parse(values.Slice(2, 2));
                blue  = byte.Parse(values.Slice(4, 2));
            }
            else if(values.Length == 7 && values[0] == '#')
            {
                alpha = 0xFF;
                red   = byte.Parse(values.Slice(1, 2));
                green = byte.Parse(values.Slice(3, 2));
                blue  = byte.Parse(values.Slice(5, 2));
            }
            else if(values.Length == 8 && (values[0] != '#' || (values[0] != '0' && values[1] != 'x')))
            {
                alpha = byte.Parse(values.Slice(0, 2));
                red   = byte.Parse(values.Slice(2, 2));
                green = byte.Parse(values.Slice(4, 2));
                blue  = byte.Parse(values.Slice(6, 2));
            }
            else if(values.Length == 9 && values[0] == '#')
            {
                alpha = byte.Parse(values.Slice(1, 2));
                red   = byte.Parse(values.Slice(3, 2));
                green = byte.Parse(values.Slice(5, 2));
                blue  = byte.Parse(values.Slice(7, 2));
            }
            else if(values.Length == 10 && values[0] == '0' && values[1] == 'x')
            {
                alpha = byte.Parse(values.Slice(2, 2));
                red   = byte.Parse(values.Slice(4, 2));
                green = byte.Parse(values.Slice(6, 2));
                blue  = byte.Parse(values.Slice(8, 2));
            }

            throw new ArgumentOutOfRangeException();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        private static void GetChannels(uint     values,
                                        out byte alpha,
                                        out byte red,
                                        out byte green,
                                        out byte blue)
        {
            ColorValue value = new(values);

            alpha = value.Alpha;
            red   = value.Red;
            green = value.Green;
            blue  = value.Blue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Color(string values)
        {
            GetChannels(values, out Alpha, out Red, out Green, out Blue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Color(ReadOnlySpan<char> values)
        {
            GetChannels(values, out Alpha, out Red, out Green, out Blue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Color(uint values)
        {
            GetChannels(values, out Alpha, out Red, out Green, out Blue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Color(byte red,
                     byte green,
                     byte blue)
        {
            Alpha = 0xFF;

            Red   = red;
            Green = green;
            Blue  = blue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Color(byte alpha,
                     byte red,
                     byte green,
                     byte blue)
        {
            Alpha = alpha;
            Red   = red;
            Green = green;
            Blue  = blue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Color(float alpha,
                     byte  red,
                     byte  green,
                     byte  blue)
        {
            Alpha = (byte)(alpha * 255);

            Red   = red;
            Green = green;
            Blue  = blue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Color(float[] values)
        {
            if(values.Length == 3)
            {
                Alpha = 0xFF;
                Red   = (byte)(values[0] * 255);
                Green = (byte)(values[1] * 255);
                Blue  = (byte)(values[2] * 255);
            }
            else if(values.Length == 4)
            {
                Alpha = (byte)(values[0] * 255);
                Red   = (byte)(values[1] * 255);
                Green = (byte)(values[2] * 255);
                Blue  = (byte)(values[3] * 255);
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Color(Collection<float> values)
        {
            if(values.Count == 3)
            {
                Alpha = 0xFF;
                Red   = (byte)(values[0] * 255);
                Green = (byte)(values[1] * 255);
                Blue  = (byte)(values[2] * 255);
            }
            else if(values.Count == 4)
            {
                Alpha = (byte)(values[0] * 255);
                Red   = (byte)(values[1] * 255);
                Green = (byte)(values[2] * 255);
                Blue  = (byte)(values[3] * 255);
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Color(float red,
                     float green,
                     float blue)
        {
            Alpha = 0xFF;
            Red   = (byte)(red   * 255);
            Green = (byte)(green * 255);
            Blue  = (byte)(blue  * 255);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Color(float alpha,
                     float red,
                     float green,
                     float blue)
        {
            Alpha = (byte)(alpha * 255);
            Red   = (byte)(red   * 255);
            Green = (byte)(green * 255);
            Blue  = (byte)(blue  * 255);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Color(in Color other)
        {
            Alpha = other.Alpha;
            Red   = other.Red;
            Green = other.Green;
            Blue  = other.Blue;
        }

        #region Equality members

        public bool Equals(Color other)
        {
            return Alpha == other.Alpha && Red == other.Red && Green == other.Green && Blue == other.Blue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override bool Equals(object? obj)
        {
            return obj is Color other && Equals(other);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Alpha, Red, Green, Blue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in Color left,
                                       in Color right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in Color left,
                                       in Color right)
        {
            return !left.Equals(right);
        }

        #endregion

        #region Relational members

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public int CompareTo(Color other)
        {
            return new ColorValue(Alpha, Red, Green, Blue).Value.CompareTo(new ColorValue(other.Alpha, other.Red, other.Green, other.Blue).Value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public int CompareTo(object? obj)
        {
            if(ReferenceEquals(null, obj))
            {
                return 1;
            }

            return obj is Color other ? CompareTo(other) : throw new ArgumentException($"Object must be of type {nameof(Color)}");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <(in Color left,
                                      in Color right)
        {
            return left.CompareTo(right) < 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >(in Color left,
                                      in Color right)
        {
            return left.CompareTo(right) > 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <=(in Color left,
                                       in Color right)
        {
            return left.CompareTo(right) <= 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >=(in Color left,
                                       in Color right)
        {
            return left.CompareTo(right) >= 0;
        }

        #endregion

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override string ToString()
        {
            if(Alpha != 255)
            {
                return $"#{Alpha:x2}{Red:x2}{Green:x2}{Blue:x2}";
            }

            return $"#{Red:x2}{Green:x2}{Blue:x2}";
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Color Mix(in Color from,
                                in Color to,
                                in float mix)
        {
            byte  alpha = (byte)((from.Alpha * mix) + (to.Alpha * (1.0f - mix)));
            float red   = (byte)((from.Red   * mix) + (to.Red   * (1.0f - mix)));
            float green = (byte)((from.Green * mix) + (to.Green * (1.0f - mix)));
            float blue  = (byte)((from.Blue  * mix) + (to.Blue  * (1.0f - mix)));

            return new Color(alpha, red, green, blue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static object[] MixToArray(in Color to, in Color from, in float mix)
        {
            byte  alpha = (byte)((to.Alpha * mix) + (from.Alpha * (1.0f - mix)));
            float red   = (byte)((to.Red   * mix) + (from.Red   * (1.0f - mix)));
            float green = (byte)((to.Green * mix) + (from.Green * (1.0f - mix)));
            float blue  = (byte)((to.Blue  * mix) + (from.Blue  * (1.0f - mix)));

            return new object[]
            {
                mix, new Color(alpha, red, green, blue).ToString()
            };
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

                            byte  red   = byte.Parse(data[0]);
                            byte  green = byte.Parse(data[1]);
                            byte  blue  = byte.Parse(data[2]);
                            float alpha = float.Parse(data[3]);

                            reader.Read();

                            return new Color(alpha, red, green, blue);
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

                        if(value.StartsWith("#") || value.StartsWith("0x") || uint.TryParse(value, out _))
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

        public ColorScaleEntry(double   value,
                               in Color color)
        {
            Value = value;
            Color = color;
        }

        public IEnumerator<object> GetEnumerator()
        {
            yield return Value;

            if(Color.Alpha != 255)
            {
                yield return $"rgba({Color.Red}, {Color.Green}, {Color.Blue}, {((float)Color.Alpha) / 255.0f})";
            }
            else
            {
                yield return $"rgb({Color.Red}, {Color.Green}, {Color.Blue})";
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override string ToString()
        {
            if(Color.Alpha != 255)
            {
                return $"{Value}, \"rgba({Color.Red}, {Color.Green}, {Color.Blue}, {((float)Color.Alpha) / 255.0f})\"";
            }

            return $"{Value}, \"rgb({Color.Red}, {Color.Green}, {Color.Blue})\"";
        }
    }
}
