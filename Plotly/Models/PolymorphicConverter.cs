#nullable enable

using System;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Plotly.Models
{
    public class PolymorphicConverter : JsonConverterFactory
    {
        public static readonly PolymorphicConverter Singleton = new();

        public override bool CanConvert(Type typeToConvert)
        {
            Type? type = typeToConvert.GetGenericArguments().FirstOrDefault() ?? typeToConvert;
            type = Nullable.GetUnderlyingType(type) ?? type;

            return type.IsInterface || type.IsAbstract;
        }

        public override JsonConverter? CreateConverter(Type                  typeToConvert,
                                                      JsonSerializerOptions options)
        {
            return (JsonConverter?)Activator.CreateInstance(typeof(PolymorphicConverter<>).MakeGenericType(typeToConvert),
                                                           BindingFlags.Instance | BindingFlags.Public,
                                                           null,
                                                           new object[]
                                                           {
                                                           },
                                                           null);
        }
    }

    public class PolymorphicConverter<T> : JsonConverter<T>
    {
        public static readonly PolymorphicConverter<T> Singleton = new();

        public override T Read(ref Utf8JsonReader    reader,
                               Type                  typeToConvert,
                               JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }

        public override void Write(Utf8JsonWriter        writer,
                                   T                     value,
                                   JsonSerializerOptions options)
        {
            if(value != null)
            {
                JsonSerializer.Serialize(writer, value, value.GetType(), options);
            }
        }
    }
}