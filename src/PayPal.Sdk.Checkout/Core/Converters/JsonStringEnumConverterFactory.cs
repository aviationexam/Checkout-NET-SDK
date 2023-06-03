using System;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PayPal.Sdk.Checkout.Core.Converters;

public class JsonStringEnumConverterFactory : JsonConverterFactory
{
    public override bool CanConvert(
        Type typeToConvert
    ) => typeToConvert.IsEnum;

    public override JsonConverter CreateConverter(
        Type typeToConvert, JsonSerializerOptions options
    ) => (JsonConverter) Activator.CreateInstance(
        typeof(JsonStringEnumConverter<>).MakeGenericType(typeToConvert),
        BindingFlags.Instance | BindingFlags.Public,
        binder: null,
        args: null,
        culture: null
    )!;
}
