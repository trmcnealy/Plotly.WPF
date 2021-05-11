#nullable enable
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Plotly.Models
{
    /// <summary>
    ///     <see cref="JsonConverterFactory" /> to convert enums to and from strings, respecting
    ///     <see cref="EnumMemberAttribute" /> decorations. Supports nullable enums.
    ///     This converter is based on Macross.Json.Extensions JsonStringEnumMemberConverter.cs	.
    /// </summary>
    public class EnumConverter : JsonConverterFactory
    {
        private readonly bool              allowIntegerValues;
        private readonly JsonNamingPolicy? namingPolicy;

        /// <summary>
        ///     Initializes a new instance of the <see cref="EnumConverter" /> class.
        /// </summary>
        public EnumConverter()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="EnumConverter" /> class.
        /// </summary>
        /// <param name="namingPolicy">
        ///     Optional naming policy for writing enum values.
        /// </param>
        /// <param name="allowIntegerValues">
        ///     True to allow undefined enum values. When true, if an enum value isn't
        ///     defined it will output as a number rather than a string.
        /// </param>
        public EnumConverter(JsonNamingPolicy? namingPolicy       = null,
                             bool              allowIntegerValues = true)
        {
            this.namingPolicy       = namingPolicy;
            this.allowIntegerValues = allowIntegerValues;
        }

        public override bool CanConvert(Type typeToConvert)
        {
            return typeToConvert.IsEnum || typeToConvert.IsGenericType && TestNullableEnum(typeToConvert).IsNullableEnum;
        }

        public override JsonConverter? CreateConverter(Type                  typeToConvert,
                                                       JsonSerializerOptions options)
        {
            (bool isNullableEnum, Type? underlyingType) = TestNullableEnum(typeToConvert);

            return (JsonConverter?)Activator.CreateInstance(typeof(EnumConverter<>).MakeGenericType(typeToConvert),
                                                            BindingFlags.Instance | BindingFlags.Public,
                                                            null,
                                                            new object?[]
                                                            {
                                                                namingPolicy, allowIntegerValues, isNullableEnum ? underlyingType! : null
                                                            },
                                                            null);
        }

        private static (bool IsNullableEnum, Type? UnderlyingType) TestNullableEnum(Type typeToConvert)
        {
            Type? underlyingType = Nullable.GetUnderlyingType(typeToConvert);

            return (underlyingType?.IsEnum ?? false, underlyingType);
        }
    }

    internal class EnumConverter<T> : JsonConverter<T>
    {
        private const BindingFlags EnumBindings = BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static;

        private class EnumInfo
        {
            public readonly Enum   EnumValue;
            public readonly string Name;
            public readonly ulong  RawValue;

            public EnumInfo(string name,
                            Enum   enumValue,
                            ulong  rawValue)
            {
                Name      = name;
                EnumValue = enumValue;
                RawValue  = rawValue;
            }
        }

        private readonly bool                         allowIntegerValues;
        private readonly Type?                        underlyingType;
        private readonly Type                         enumType;
        private readonly TypeCode                     enumTypeCode;
        private readonly bool                         isFlags;
        private readonly Dictionary<ulong, EnumInfo>  rawToTransformed;
        private readonly Dictionary<string, EnumInfo> transformedToRaw;

        public EnumConverter(JsonNamingPolicy namingPolicy,
                             bool             allowIntegerValues,
                             Type?            underlyingType)
        {
            Debug.Assert(typeof(T).IsEnum && underlyingType == null || Nullable.GetUnderlyingType(typeof(T)) == underlyingType, "Generic type is invalid.");

            this.allowIntegerValues = allowIntegerValues;
            this.underlyingType     = underlyingType;
            enumType                = this.underlyingType ?? typeof(T);
            enumTypeCode            = Type.GetTypeCode(enumType);
            isFlags                 = enumType.IsDefined(typeof(FlagsAttribute), true);

            string[] builtInNames  = enumType.GetEnumNames();
            Array    builtInValues = enumType.GetEnumValues();

            rawToTransformed = new Dictionary<ulong, EnumInfo>();
            transformedToRaw = new Dictionary<string, EnumInfo>();

            for(int i = 0; i < builtInNames.Length; i++)
            {
                Enum? enumValue = (Enum?)builtInValues.GetValue(i);

                if(enumValue != null)
                {
                    ulong rawValue = GetEnumValue(enumValue);

                    string               name                = builtInNames[i];
                    FieldInfo?           field               = enumType.GetField(name, EnumBindings)!;
                    EnumMemberAttribute? enumMemberAttribute = field.GetCustomAttribute<EnumMemberAttribute>(true);
                    string?              transformedName     = enumMemberAttribute?.Value ?? namingPolicy?.ConvertName(name) ?? name;

                    rawToTransformed[rawValue]        = new EnumInfo(transformedName, enumValue, rawValue);
                    transformedToRaw[transformedName] = new EnumInfo(name,            enumValue, rawValue);
                }
            }
        }

        public override T Read(ref Utf8JsonReader    reader,
                               Type                  typeToConvert,
                               JsonSerializerOptions options)
        {
            JsonTokenType token = reader.TokenType;

            if(token == JsonTokenType.String)
            {
                string? enumString = reader.GetString();

                // Case sensitive search attempted first.
                if(enumString != null && transformedToRaw.TryGetValue(enumString, out EnumInfo? enumInfo))
                {
                    return (T)Enum.ToObject(enumType, enumInfo.RawValue);
                }

                if(isFlags)
                {
                    ulong calculatedValue = 0;

                    if(enumString != null)
                    {
                        string[] flagValues = enumString.Split("+");

                        foreach(string flagValue in flagValues)
                        {
                            // Case sensitive search attempted first.
                            if(transformedToRaw.TryGetValue(flagValue, out enumInfo))
                            {
                                calculatedValue |= enumInfo.RawValue;
                            }
                            else
                            {
                                // Case insensitive search attempted second.
                                bool matched = false;

                                foreach(KeyValuePair<string, EnumInfo> enumItem in transformedToRaw.Where(enumItem => string.Equals(enumItem.Key, flagValue, StringComparison.OrdinalIgnoreCase)))
                                {
                                    calculatedValue |= enumItem.Value.RawValue;
                                    matched         =  true;

                                    break;
                                }

                                if(!matched)
                                {
                                    throw new JsonException($"Unknown flag value {flagValue}.");
                                }
                            }
                        }
                    }

                    return (T)Enum.ToObject(enumType, calculatedValue);
                }

                // Case insensitive search attempted second.
                foreach(KeyValuePair<string, EnumInfo> enumItem in transformedToRaw.Where(enumItem => string.Equals(enumItem.Key, enumString, StringComparison.OrdinalIgnoreCase)))
                {
                    return (T)Enum.ToObject(enumType, enumItem.Value.RawValue);
                }

                throw new JsonException($"Unknown value {enumString}.");
            }

            if(token != JsonTokenType.Number || !allowIntegerValues)
            {
                throw new JsonException();
            }

            switch(enumTypeCode)
            {
                // Switch cases ordered by expected frequency.
                case TypeCode.Int32:
                    if(reader.TryGetInt32(out int int32))
                    {
                        return (T)Enum.ToObject(enumType, int32);
                    }

                    break;
                case TypeCode.UInt32:
                    if(reader.TryGetUInt32(out uint uint32))
                    {
                        return (T)Enum.ToObject(enumType, uint32);
                    }

                    break;
                case TypeCode.UInt64:
                    if(reader.TryGetUInt64(out ulong uint64))
                    {
                        return (T)Enum.ToObject(enumType, uint64);
                    }

                    break;
                case TypeCode.Int64:
                    if(reader.TryGetInt64(out long int64))
                    {
                        return (T)Enum.ToObject(enumType, int64);
                    }

                    break;

                case TypeCode.SByte:
                    if(reader.TryGetSByte(out sbyte byte8))
                    {
                        return (T)Enum.ToObject(enumType, byte8);
                    }

                    break;
                case TypeCode.Byte:
                    if(reader.TryGetByte(out byte ubyte8))
                    {
                        return (T)Enum.ToObject(enumType, ubyte8);
                    }

                    break;
                case TypeCode.Int16:
                    if(reader.TryGetInt16(out short int16))
                    {
                        return (T)Enum.ToObject(enumType, int16);
                    }

                    break;
                case TypeCode.UInt16:
                    if(reader.TryGetUInt16(out ushort uint16))
                    {
                        return (T)Enum.ToObject(enumType, uint16);
                    }

                    break;
            }

            throw new JsonException();
        }

        public override void Write(Utf8JsonWriter        writer,
                                   T                     value,
                                   JsonSerializerOptions options)
        {
            // Note: There is no check for value == null because Json serializer won't call the converter in that case.
            ulong rawValue = GetEnumValue(value!);

            if(rawToTransformed.TryGetValue(rawValue, out EnumInfo? enumInfo))
            {
                writer.WriteStringValue(enumInfo.Name);

                return;
            }

            if(isFlags)
            {
                ulong calculatedValue = 0;

                StringBuilder builder = new();

                foreach(KeyValuePair<ulong, EnumInfo> enumItem in rawToTransformed)
                {
                    enumInfo = enumItem.Value;

                    if(!(value as Enum)!.HasFlag(enumInfo.EnumValue) || enumInfo.RawValue == 0) // Definitions with 'None' should hit the cache case.
                    {
                        continue;
                    }

                    // Track the value to make sure all bits are represented.
                    calculatedValue |= enumInfo.RawValue;

                    if(builder.Length > 0)
                    {
                        builder.Append('+');
                    }

                    builder.Append(enumInfo.Name);
                }

                if(calculatedValue == rawValue)
                {
                    writer.WriteStringValue(builder.ToString());

                    return;
                }
            }

            if(!allowIntegerValues)
            {
                throw new JsonException();
            }

            switch(enumTypeCode)
            {
                case TypeCode.Int32:
                    writer.WriteNumberValue((int)rawValue);

                    break;
                case TypeCode.UInt32:
                    writer.WriteNumberValue((uint)rawValue);

                    break;
                case TypeCode.UInt64:
                    writer.WriteNumberValue(rawValue);

                    break;
                case TypeCode.Int64:
                    writer.WriteNumberValue((long)rawValue);

                    break;
                case TypeCode.Int16:
                    writer.WriteNumberValue((short)rawValue);

                    break;
                case TypeCode.UInt16:
                    writer.WriteNumberValue((ushort)rawValue);

                    break;
                case TypeCode.Byte:
                    writer.WriteNumberValue((byte)rawValue);

                    break;
                case TypeCode.SByte:
                    writer.WriteNumberValue((sbyte)rawValue);

                    break;
                default: throw new JsonException();
            }
        }

        private ulong GetEnumValue(object value)
        {
            return enumTypeCode switch
                   {
                       TypeCode.Int32  => (ulong)(int)value,
                       TypeCode.UInt32 => (uint)value,
                       TypeCode.UInt64 => (ulong)value,
                       TypeCode.Int64  => (ulong)(long)value,
                       TypeCode.SByte  => (ulong)(sbyte)value,
                       TypeCode.Byte   => (byte)value,
                       TypeCode.Int16  => (ulong)(short)value,
                       TypeCode.UInt16 => (ushort)value,
                       _               => throw new JsonException()
                   };
        }
    }
}
