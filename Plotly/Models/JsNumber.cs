using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Plotly.Models
{
    [JsonConverter(typeof(JsNumberConverter))]
    [ComVisible(true)]
    public struct JsNumber
    {
        public float? Single;

        public double? Double;

        public int? Int32;

        public long? Int64;

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public JsNumber(double to)
            : this()
        {
            Double = to;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public JsNumber(int to)
            : this()
        {
            Int32 = to;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public JsNumber(long to)
            : this()
        {
            Int64 = to;
        }

        public bool IsSingle
        {
            get { return Single != null; }
        }

        public bool IsDouble
        {
            get { return Double != null; }
        }

        public bool IsInt32
        {
            get { return Int32 != null; }
        }

        public bool IsInt64
        {
            get { return Int64 != null; }
        }

        public bool IsNull
        {
            get { return Single == null && Double == null && Int32 == null && Int64 == null; }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator float?(JsNumber from)
        {
            return from.Single;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator double?(JsNumber from)
        {
            return from.Double;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator int?(JsNumber from)
        {
            return from.Int32;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator long?(JsNumber from)
        {
            return from.Int64;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator JsNumber(float to)
        {
            return new ()
            {
                Single = to
            };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator JsNumber(double to)
        {
            return new ()
            {
                Double = to
            };
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator JsNumber(int to)
        {
            return new ()
            {
                Int32 = to
            };
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator JsNumber(long to)
        {
            return new ()
            {
                Int64 = to
            };
        }
    }

    public class JsNumberConverter : JsonConverter<JsNumber>
    {
        public static readonly JsNumberConverter Singleton = new();

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override JsNumber Read(ref Utf8JsonReader    reader,
                                      Type                  typeToConvert,
                                      JsonSerializerOptions options)
        {
            if(reader.TryGetInt64(out long Int64Value))
            {
                return new JsNumber(Int64Value);
            }

            if(reader.TryGetDouble(out double DoubleValue))
            {
                return new JsNumber(DoubleValue);
            }

            if(reader.TryGetInt32(out int Int32Value))
            {
                return new JsNumber(Int32Value);
            }

            if(reader.TryGetSingle(out float FloatValue))
            {
                return new JsNumber(FloatValue);
            }

            return new JsNumber(double.NaN);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override void Write(Utf8JsonWriter        writer,
                                   JsNumber              value,
                                   JsonSerializerOptions options)
        {
            if(value.IsSingle)
            {
                writer.WriteNumberValue(value.Single.Value);
            }
            else if(value.IsDouble)
            {
                writer.WriteNumberValue(value.Double.Value);
            }
            else if(value.IsInt32)
            {
                writer.WriteNumberValue(value.Int32.Value);
            }
            else if(value.IsInt64)
            {
                writer.WriteNumberValue(value.Int64.Value);
            }
            else
            {
                writer.WriteStringValue("NaN");
            }
        }
    }
}