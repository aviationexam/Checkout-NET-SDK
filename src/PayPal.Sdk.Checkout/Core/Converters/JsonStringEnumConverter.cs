using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PayPal.Sdk.Checkout.Core.Converters;

public class JsonStringEnumConverter<TEnum> : JsonConverter<TEnum>
    where TEnum : struct, Enum
{
    private readonly IDictionary<TEnum, string> _enumToString = new Dictionary<TEnum, string>();
    private readonly IDictionary<string, TEnum> _stringToEnum = new Dictionary<string, TEnum>();

    public JsonStringEnumConverter()
    {
        var type = typeof(TEnum);

        foreach (TEnum value in type.GetEnumValues())
        {
            var enumName = type.GetEnumName(value)!;
            var enumField = type.GetField(enumName)!;

            if (enumField.GetCustomAttribute<EnumMemberAttribute>(false) is { Value: { } enumMemberAttributeValue })
            {
                _enumToString.Add(value, enumMemberAttributeValue);
                _stringToEnum.Add(enumMemberAttributeValue, value);
            }
            else
            {
                _enumToString.Add(value, enumName);
                _stringToEnum.Add(enumName, value);
            }
        }
    }

    public override TEnum Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        if (
            reader.TokenType is JsonTokenType.String
            && reader.GetString() is { } stringValue
            && _stringToEnum.TryGetValue(stringValue, out var enumValue)
        )
        {
            return enumValue;
        }

        return default;
    }

    public override void Write(
        Utf8JsonWriter writer,
        TEnum value,
        JsonSerializerOptions options
    ) => writer.WriteStringValue(_enumToString[value]);
}
