using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text.Json;

#pragma warning disable 1591

namespace Plotly.Models
{
    public static class Extensions
    {
        /// <summary>
        ///     Prepares an object for js interop operations, converting the object to a dictionary.
        ///     This operation can be customized using own serializer options.
        ///     Current it's not possible to define serializer options for the JSRuntime directly.
        /// </summary>
        /// <typeparam name="T">Type of the object.</typeparam>
        /// <param name="obj">The object.</param>
        /// <param name="serializerOptions">Optional serializerOptions.</param>
        /// <returns></returns>
        public static object PrepareJsInterop<T>(this T                obj,
                                                 JsonSerializerOptions serializerOptions = null)
        {
            Type type = obj?.GetType();

            // Handle simple types
            if(obj == null || type.IsPrimitive || type == typeof(string))
            {
                return obj;
            }

            // Handle jsonElements
            if(obj is JsonElement jsonElement)
            {
                return jsonElement.PrepareJsonElement();
            }

            // Set default serializer options if necessary
            serializerOptions ??= new JsonSerializerOptions
            {
                IgnoreNullValues = true, PropertyNamingPolicy = null
            };

            // Handle all kind of complex objects
            return JsonSerializer.Deserialize<JsonElement>(JsonSerializer.Serialize<object>(obj, serializerOptions)).PrepareJsonElement();
        }

        private static object PrepareJsonElement(this JsonElement obj)
        {
            switch(obj.ValueKind)
            {
                case JsonValueKind.Object:
                    IDictionary<string, object> expando = new ExpandoObject();

                    foreach(JsonProperty property in obj.EnumerateObject())
                    {
                        expando.Add(property.Name, property.Value.PrepareJsonElement());
                    }

                    return expando;
                case JsonValueKind.Array:     return obj.EnumerateArray().Select(jsonElement => jsonElement.PrepareJsonElement());
                case JsonValueKind.String:    return obj.GetString();
                case JsonValueKind.Number:    return obj.GetDouble();
                case JsonValueKind.True:      return true;
                case JsonValueKind.False:     return false;
                case JsonValueKind.Null:      return null;
                case JsonValueKind.Undefined: return null;
                default:                      throw new ArgumentException();
            }
        }
    }
}
