#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Plotly.Models
{
    [JsonConverter(typeof(ArrayRefUnionConverter))]
    public struct ArrayRefUnion : IEquatable<ArrayRefUnion>
    {
        public List<object>? Array;

        public string? Ref;

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public ArrayRefUnion(List<object>? array)
            : this()
        {
            Array = array;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public ArrayRefUnion(string? @ref)
            : this()
        {
            Ref = @ref;
        }

        
        public bool IsArray
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return Array != null; }
        }

        public bool IsRef
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return Ref != null; }
        }


        public bool IsNull
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return Array == null && Ref == null; }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator List<object>?(ArrayRefUnion from)
        {
            return from.Array;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator string?(ArrayRefUnion from)
        {
            return from.Ref;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator ArrayRefUnion(List<object> to)
        {
            return new(to);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator ArrayRefUnion(string to)
        {
            return new(to);
        }

        public bool Equals(ArrayRefUnion other)
        {
            if(IsArray && other.IsArray)
            {
                return Array!.SequenceEqual(other.Array!);
            }

            if(IsRef && other.IsRef)
            {
                return Ref == other.Ref;
            }

            return IsNull && other.IsNull;
        }

        public override bool Equals(object? obj)
        {
            return obj is ArrayRefUnion other && Equals(other);
        }

        public override int GetHashCode()
        {
            if(IsArray)
            {
                return Array!.GetHashCode();
            }

            if(IsRef)
            {
                return Ref!.GetHashCode();
            }

            throw new NullReferenceException();
        }

        public static bool operator ==(ArrayRefUnion left,
                                       ArrayRefUnion right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(ArrayRefUnion left,
                                       ArrayRefUnion right)
        {
            return !left.Equals(right);
        }
    }

    public class ArrayRefUnionConverter : JsonConverter<ArrayRefUnion>
    {
        public static readonly ArrayRefUnionConverter Singleton = new();

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override ArrayRefUnion Read(ref Utf8JsonReader    reader,
                                           Type                  typeToConvert,
                                           JsonSerializerOptions options)
        {
            //if(typeToConvert == typeof(List<object>))
            //{
            //    return new ArrayRefUnion(Int64Value);
            //}

            if(typeToConvert.UnderlyingSystemType == typeof(string))
            {
                return new ArrayRefUnion(reader.GetString());
            }

            throw new NotSupportedException();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override void Write(Utf8JsonWriter        writer,
                                   ArrayRefUnion         value,
                                   JsonSerializerOptions options)
        {
            if(value.IsArray)
            {
                List<object> array = value.Array!;

                writer.WriteStringValue($"{array[0]}");

                for (int i = 1; i < array.Count; ++i)
                {
                    writer.WriteStringValue($",{array[i]}");
                }

                return;
            }
            
            if(value.IsRef)
            {
                writer.WriteStringValue(value.Ref);
                return;
            }

            throw new NotSupportedException();
        }
    }
}