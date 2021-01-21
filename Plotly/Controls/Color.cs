using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
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
            return "#" + Value.ToString("X6");
        }

        #endregion
    }

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

        private static void GetChannels(uint     values,
                                        out byte red,
                                        out byte green,
                                        out byte blue)
        {
            ColorValue value = new (values);

            red   = value.Red;
            green = value.Green;
            blue  = value.Blue;
        }

        public Color(string values)
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
            return new ColorValue(0, Red, Green, Blue).ToString();
                //$"rgb({Red},{Green},{Blue})";
        }
    }

}